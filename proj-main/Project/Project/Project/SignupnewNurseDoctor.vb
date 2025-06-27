Imports System.Data.SqlClient

Public Class SignupnewNurseDoctor
    Dim connStr As String = "Data Source=(localdb)\ProjectModels;Initial Catalog=New Database;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"

    Private Sub SignupnewNurseDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxRole.Items.Add("nurse")
        ComboBoxRole.Items.Add("doctor")
        ComboBoxRole.SelectedIndex = 0
        UpdateDepartmentVisibility()
    End Sub

    Private Sub ComboBoxRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRole.SelectedIndexChanged
        Dim isDoctor As Boolean = ComboBoxRole.SelectedItem.ToString().ToLower() = "doctor"
        TextBoxAdminKey.Visible = isDoctor
        LabelAdminKey.Visible = isDoctor
        UpdateDepartmentVisibility()
    End Sub

    Private Sub UpdateDepartmentVisibility()
        ' Nurses need department, doctors doesn't
        Dim isNurse As Boolean = ComboBoxRole.SelectedItem.ToString().ToLower() = "nurse"
        LabelDepartment.Visible = isNurse
        TextBoxDepartment.Visible = isNurse
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Dim idNumber = TextBoxID.Text.Trim()
        Dim password = TextBoxPass.Text.Trim()
        Dim role = ComboBoxRole.Text.ToLower()
        Dim department = TextBoxDepartment.Text.Trim()

        If idNumber = "" OrElse password = "" Then
            MessageBox.Show("Please fill in all required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If role = "nurse" AndAlso department = "" Then
            MessageBox.Show("Please enter a department for the nurse.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Admin check for doctor
        If role = "doctor" Then
            Dim adminKey = TextBoxAdminKey.Text.Trim()

            If adminKey = "" Then
                MessageBox.Show("Admin password is required to create a doctor account.", "Admin Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not IsAdminPasswordValid(adminKey) Then
                MessageBox.Show("Invalid admin password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim trans As SqlTransaction = conn.BeginTransaction()

            Try
                ' Insert new user and get new Id
                Dim userCmd As New SqlCommand("INSERT INTO users (IdNumber, Password, Role) OUTPUT INSERTED.Id VALUES (@id, @pass, @role)", conn, trans)
                userCmd.Parameters.AddWithValue("@id", idNumber)
                Dim hashedPassword As String = PasswordHelper.HashPassword(password)
                userCmd.Parameters.AddWithValue("@pass", hashedPassword)
                userCmd.Parameters.AddWithValue("@role", role)
                Dim newUserId As Integer = CInt(userCmd.ExecuteScalar())

                ' Insert into nurse or doctor profile table
                If role = "nurse" Then
                    Dim nurseCmd As New SqlCommand("INSERT INTO nurses (UserId, Department) VALUES (@userid, @dept)", conn, trans)
                    nurseCmd.Parameters.AddWithValue("@userid", newUserId)
                    nurseCmd.Parameters.AddWithValue("@dept", department)
                    nurseCmd.ExecuteNonQuery()
                ElseIf role = "doctor" Then
                    Dim doctorCmd As New SqlCommand("INSERT INTO doctors (UserId) VALUES (@userid)", conn, trans)
                    doctorCmd.Parameters.AddWithValue("@userid", newUserId)
                    doctorCmd.ExecuteNonQuery()
                End If

                trans.Commit()
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear inputs
                TextBoxID.Text = ""
                TextBoxPass.Text = ""
                TextBoxAdminKey.Text = ""
                TextBoxDepartment.Text = ""
            Catch ex As SqlException
                trans.Rollback()
                MessageBox.Show("Error creating account: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Checks admin password using hashed comparison
    Private Function IsAdminPasswordValid(adminPass As String) As Boolean
        Using conn As New SqlConnection(connStr)
            Dim cmd As New SqlCommand("SELECT Password FROM users WHERE Role = 'admin'", conn)
            conn.Open()
            Dim reader = cmd.ExecuteReader()
            If reader.Read() Then
                Dim storedHash = reader.GetString(0)
                Return PasswordHelper.VerifyPassword(adminPass, storedHash)
            End If
        End Using
        Return False
    End Function
End Class
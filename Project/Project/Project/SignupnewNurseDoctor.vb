Imports System.Data.SqlClient

Public Class SignupnewNurseDoctor

    Dim connStr As String = "Data Source=(localdb)\ProjectModels;Initial Catalog=New Database;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"

    Private Sub SignupnewNurseDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxRole.Items.Add("nurse")
        ComboBoxRole.Items.Add("doctor")
        ComboBoxRole.SelectedIndex = 0 ' Default to nurse
    End Sub

    Private Sub ComboBoxRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRole.SelectedIndexChanged
        Dim isDoctor As Boolean = ComboBoxRole.SelectedItem.ToString().ToLower() = "doctor"
        TextBoxAdminKey.Visible = isDoctor
        LabelAdminKey.Visible = isDoctor
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Dim idNumber = TextBoxID.Text.Trim()
        Dim password = TextBoxPass.Text.Trim()
        Dim role = ComboBoxRole.Text.ToLower()

        If idNumber = "" Or password = "" Then
            MessageBox.Show("Please fill in all required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 🔐 Admin check for doctor
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

        ' ✅ Insert new user
        Using conn As New SqlConnection(connStr)
            Dim cmd As New SqlCommand("INSERT INTO users (IdNumber, Password, Role) VALUES (@id, @pass, @role)", conn)
            cmd.Parameters.AddWithValue("@id", idNumber)
            cmd.Parameters.AddWithValue("@pass", password)
            cmd.Parameters.AddWithValue("@role", role)

            conn.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear inputs
            TextBoxID.Text = ""
            TextBoxPass.Text = ""
            TextBoxAdminKey.Text = ""
        End Using
    End Sub

    Private Function IsAdminPasswordValid(adminPass As String) As Boolean
        Using conn As New SqlConnection(connStr)
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM users WHERE Role = 'admin' AND Password = @pass", conn)
            cmd.Parameters.AddWithValue("@pass", adminPass)

            conn.Open()
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using
    End Function

End Class

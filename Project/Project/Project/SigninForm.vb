Imports System.Data.SqlClient

Public Class SigninForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial button style
        buttonSignin.BackColor = Color.Black
        buttonSignin.ForeColor = Color.White
        buttonSignin.FlatStyle = FlatStyle.Flat
        buttonSignin.FlatAppearance.BorderSize = 0
        buttonSignin.Cursor = Cursors.Hand
    End Sub

    Private Sub ButtonSignin_Click(sender As Object, e As EventArgs) Handles buttonSignin.Click
        Dim idNumber = textUsername.Text.Trim()
        Dim password = textPassword.Text
        Dim role As String = ""

        If idNumber = "" Or password = "" Then
            labelMessage.Text = "Please enter ID number and password."
            Return
        End If

        Dim connStr As String = "Data Source=(localdb)\ProjectModels;Initial Catalog=New Database;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"
        Using conn As New SqlConnection(connStr)
            ' Get the hashed password, role, and user PK (Id) for the user
            Dim cmd As New SqlCommand("SELECT Id, IdNumber, Password, Role FROM users WHERE IdNumber = @id", conn)
            cmd.Parameters.AddWithValue("@id", idNumber)

            conn.Open()
            Dim reader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim userId As Integer = reader.GetInt32(0)
                Dim userIdNumber As String = reader.GetString(1)
                Dim storedHash = reader.GetString(2)
                role = reader.GetString(3).ToLower()

                ' Check hashed password
                If PasswordHelper.VerifyPassword(password, storedHash) Then
                    Select Case role
                        Case "doctor"
                            reader.Close()
                            ' Find the doctor record by UserId (not by idnumber)
                            Dim doctorCmd As New SqlCommand("SELECT DoctorId FROM doctors WHERE UserId = @userid", conn)
                            doctorCmd.Parameters.AddWithValue("@userid", userId)
                            Dim doctorIdObj = doctorCmd.ExecuteScalar()
                            If doctorIdObj IsNot Nothing Then
                                Dim docForm As New DoctorForm()
                                docForm.CurrentUsername = idNumber
                                docForm.CurrentDoctorId = Convert.ToInt32(doctorIdObj)
                                ' >>> ADD THESE LINES <<<
                                docForm.CurrentUserRole = role
                                docForm.CurrentUserId = userId
                                ' <<<<<<<<<<<<<<<<<<<<<<<
                                docForm.Show()
                                Me.Hide()
                            Else
                                labelMessage.Text = "No doctor profile linked to this user."
                            End If
                        Case "nurse"
                            reader.Close()
                            ' Find the nurse record by UserId (not by idnumber)
                            Dim nurseCmd As New SqlCommand("SELECT NurseId FROM nurses WHERE UserId = @userid", conn)
                            nurseCmd.Parameters.AddWithValue("@userid", userId)
                            Dim nurseIdObj = nurseCmd.ExecuteScalar()
                            If nurseIdObj IsNot Nothing Then
                                Dim nurseForm As New txtRelationship()
                                nurseForm.CurrentUsername = idNumber
                                nurseForm.CurrentNurseId = Convert.ToInt32(nurseIdObj)
                                ' >>> ADD THESE LINES <<<
                                nurseForm.CurrentUserRole = role
                                nurseForm.CurrentUserId = userId
                                ' <<<<<<<<<<<<<<<<<<<<<<<
                                nurseForm.Show()
                                Me.Hide()
                            Else
                                labelMessage.Text = "No nurse profile linked to this user."
                            End If
                        Case Else
                            labelMessage.Text = "Only doctor or nurse logins are allowed here."
                    End Select
                Else
                    labelMessage.Text = "Invalid ID number or password!"
                End If
            Else
                labelMessage.Text = "Invalid ID number or password!"
            End If
        End Using

        ' Clear inputs
        textUsername.Text = ""
        textPassword.Text = ""
    End Sub

    Private Sub ButtonSignin_MouseEnter(sender As Object, e As EventArgs) Handles buttonSignin.MouseEnter
        ' Change button background color to a dark gray when the mouse enters
        buttonSignin.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub ButtonSignin_MouseLeave(sender As Object, e As EventArgs) Handles buttonSignin.MouseLeave
        ' Revert button background color when the mouse leaves
        buttonSignin.BackColor = Color.Black
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim patientForm As New PatientForm()
        PatientView.ShowDialog()
    End Sub

    Private Sub labelUsername_Click(sender As Object, e As EventArgs) Handles labelUsername.Click

    End Sub
End Class
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
            ' Get the hashed password and role for the user
            Dim cmd As New SqlCommand("SELECT Password, Role FROM users WHERE IdNumber = @id", conn)
            cmd.Parameters.AddWithValue("@id", idNumber)

            conn.Open()
            Dim reader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim storedHash = reader.GetString(0)
                role = reader.GetString(1).ToLower()

                ' Check hashed password
                If PasswordHelper.VerifyPassword(password, storedHash) Then
                    Select Case role
                        Case "doctor"
                            Dim docForm As New DoctorForm()
                            docForm.CurrentUserRole = "Doctor"
                            docForm.CurrentUserId = idNumber
                            docForm.Show()
                            Me.Hide()
                        Case "nurse"
                            Dim nurseForm As New NurseForm()
                            nurseForm.Show()
                            Me.Hide()
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
End Class
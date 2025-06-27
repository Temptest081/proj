Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class patientsignup

    Dim connectionString As String = ""
    Dim connection As New SqlConnection(connectionString)

    Private Sub Buttonlogin_Click(sender As Object, e As EventArgs) Handles Buttonlogin.Click
        ' Validate password match
        If TextBox2.Text <> TextBox3.Text Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        MessageBox.Show("Account registered.")

        Me.Close()
        SigninForm.Show()

    End Sub

    Private Sub patientsignup_load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Username"
        TextBox1.ForeColor = Color.DarkGray

        TextBox2.Text = "Password"
        TextBox3.ForeColor = Color.DarkGray

        TextBox3.Text = "Password"
        TextBox3.ForeColor = Color.DarkGray
    End Sub

    Private Sub textbox1_gotfocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Username" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub textbox1_lostfocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Username"
            TextBox1.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub textbox2_gotfocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "Password" Then
            TextBox2.Text = ""
            TextBox2.PasswordChar = "●"
            TextBox2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub textbox2_lostfocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "Password"
            TextBox2.PasswordChar = ""
            TextBox2.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub textbox3_gotfocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        If TextBox3.Text = "Confirm Password" Then
            TextBox3.Text = ""
            TextBox3.PasswordChar = "●"
            TextBox3.ForeColor = Color.Black
        End If
    End Sub
    Private Sub textbox3_lostfocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        If TextBox3.Text = "" Then
            TextBox3.Text = "Confirm Password"
            TextBox3.PasswordChar = ""
            TextBox3.ForeColor = Color.DarkGray
        End If
    End Sub
End Class

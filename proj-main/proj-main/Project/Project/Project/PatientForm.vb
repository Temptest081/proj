Imports System.IO

Public Class PatientForm
    Private passwordVisible As Boolean = False
    Private Sub PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CprojectdbDataSet.cprojectdb' table. You can move, or remove it, as needed.
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.AllowDrop = True
    End Sub

    ' Show SigninForm and hide current form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SigninForm.Show()
        Me.Hide()
    End Sub

    ' Upload photo using File Dialog
    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Select an Image"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Image = Image.FromFile(ofd.FileName)
            Catch ex As Exception
                MessageBox.Show("Failed to load image: " & ex.Message)
            End Try
        End If
    End Sub

    ' Drag and Drop handlers (optional, if you still want drag-and-drop support)
    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length > 0 Then
            Try
                PictureBox1.Image = Image.FromFile(files(0))
            Catch ex As Exception
                MessageBox.Show("Invalid image file.")
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonTogglePassword.Click
        passwordVisible = Not passwordVisible

        If passwordVisible Then
            TextBoxPassword.UseSystemPasswordChar = False
            TextBoxPassword1.UseSystemPasswordChar = False
            ButtonTogglePassword.Text = "🙈 Hide"
        Else
            TextBoxPassword.UseSystemPasswordChar = True
            TextBoxPassword1.UseSystemPasswordChar = True
            ButtonTogglePassword.Text = "👁 Show"
        End If
    End Sub
End Class

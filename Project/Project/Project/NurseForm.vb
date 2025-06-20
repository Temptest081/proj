Public Class NurseForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SigninForm.Show()
        Me.Hide()
    End Sub

    Private Sub NurseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_DatabaseDataSet.collab' table. You can move, or remove it, as needed.
        Me.CollabTableAdapter.Fill(Me.New_DatabaseDataSet.collab)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Validate and end edits first
            Me.Validate()
            Me.CollabBindingSource.EndEdit()

            ' Save changes to the database
            Me.CollabTableAdapter.Update(Me.New_DatabaseDataSet.collab)

            MessageBox.Show("Changes saved successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CollabBindingSource.AddNew()
    End Sub
End Class
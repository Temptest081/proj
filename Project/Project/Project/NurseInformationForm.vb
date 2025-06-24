Public Class NurseInformationForm
    Public Property CurrentNurseId As Integer
    Private Sub NursesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.NursesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.New_DatabaseDataSet)

    End Sub

    Private Sub NurseInformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_DatabaseDataSet.nurses' table. You can move, or remove it, as needed.
        Me.NursesTableAdapter.Fill(Me.New_DatabaseDataSet.nurses)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Validate and end edit on the BindingSource
            Me.Validate()
            Me.NursesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.New_DatabaseDataSet)

            MessageBox.Show("Nurse information saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to save nurse information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
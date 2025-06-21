Public Class InformationForm
    Private Sub DoctorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DoctorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.New_DatabaseDataSet)
    End Sub

    Private Sub InformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_DatabaseDataSet.doctors' table. You can move, or remove it, as needed.
        Me.DoctorsTableAdapter.Fill(Me.New_DatabaseDataSet.doctors)
    End Sub

    ' ---- ADD THIS CODE ----
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.DoctorsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.New_DatabaseDataSet)
            MessageBox.Show("Doctor information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving doctor information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
    ' ---- END OF NEW CODE ----

End Class
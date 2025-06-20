Public Class PatientView

    Private Sub CollabBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CollabBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.New_DatabaseDataSet)
    End Sub

    Private Sub PatientView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CollabTableAdapter.Fill(Me.New_DatabaseDataSet.collab)
        Me.CollabDataGridView.ReadOnly = True ' prevent editing
    End Sub


    ' 🔍 Search button click
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim keyword As String = TextBoxSearch.Text.Trim().Replace("'", "''")

        If keyword = "" Then
            CollabBindingSource.RemoveFilter() ' Reset to full list
        Else
            CollabBindingSource.Filter = $"Name LIKE '%{keyword}%'"
        End If
    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim keyword As String = TextBoxSearch.Text.Trim().Replace("'", "''")

        If keyword = "" Then
            CollabBindingSource.RemoveFilter()
        Else
            CollabBindingSource.Filter = $"Name LIKE '%{keyword}%'"
        End If
    End Sub


    ' Optional: trigger search when pressing Enter
    Private Sub TextBoxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonSearch.PerformClick()
        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show(
            "📋 Patient Search Bar - FAQ" & vbCrLf & vbCrLf &
            "🔍 Q1: How does the search bar work?" & vbCrLf &
            "Type part or full patient name and click Search or press Enter." & vbCrLf & vbCrLf &
            "🔡 Q2: Do I need to type the full name?" & vbCrLf &
            "No, partial names like 'Mar' will match Maria, Marvin, etc." & vbCrLf & vbCrLf &
            "🔄 Q3: How do I reset the search?" & vbCrLf &
            "Clear the search box and click Search to view all patients again." & vbCrLf & vbCrLf &
            "🧠 Q4: What does the search look at?" & vbCrLf &
            "It only checks the Name field. Not age, gender, or other fields." & vbCrLf & vbCrLf &
            "⚠️ Q5: Why is nothing showing?" & vbCrLf &
            "You may have typed a name that doesn't exist. Try again or clear the box.",
            "Patient Search Bar – FAQ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class

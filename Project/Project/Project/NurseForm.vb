Imports System.Data.SqlClient

Public Class txtRelationship
    ' Properties set from SigninForm
    Public Property CurrentUsername As String
    Public Property CurrentNurseId As Integer
    Public Property CurrentUserRole As String
    Public Property CurrentUserId As Integer

    Private Sub NurseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the 'New_DatabaseDataSet.collab' table.
        Me.CollabTableAdapter.Fill(Me.New_DatabaseDataSet.collab)
        labelUserName.Text = CurrentUserRole
        labelUserId.Text = CurrentUserId.ToString()

        ' Bind patientList to the CollabBindingSource, not directly to DataTable!
        CollabBindingSource.DataSource = Me.New_DatabaseDataSet.collab
        patientList.DataSource = CollabBindingSource
        patientList.DisplayMember = "Name"   ' Use your actual column for patient name
        patientList.ValueMember = "id"       ' Use your actual column for patient ID
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Optional: custom painting code
    End Sub

    Private Sub panelUserInfo_Paint(sender As Object, e As PaintEventArgs) Handles txtSurgeries.Paint
        ' Optional: custom painting code
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SigninForm.Show()
        Me.Hide()
    End Sub

    ' "New Patient" Button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CollabBindingSource.AddNew()
        CollabBindingSource.Position = CollabBindingSource.Count - 1
        patientList.SelectedIndex = CollabBindingSource.Position

        ' Clear or reset all relevant input controls for new patient entry
        txtSystolic.Text = ""
        txtDiastolic.Text = ""
        txtHeartBeat.Text = ""
        txtTemperature.Text = ""
        txtRespiratoryRate.Text = ""
        TextBox7.Text = ""
        ComboBox1.SelectedIndex = -1
        txtSymptoms.Text = ""
        txtAllergies.Text = ""
        txtPastMedical.Text = ""
        Medication.SelectedIndex = -1
        Surgeries.SelectedIndex = -1
        VapeSmokeDrinkComboBox.SelectedIndex = -1
        Symptoms.SelectedIndex = -1
        Inherit.SelectedIndex = -1
        Ability.SelectedIndex = -1
        Vaccine.SelectedIndex = -1
        Pregnant.SelectedIndex = -1
        txtLastMenstrualPeriod.Text = ""
        comboPainScale.SelectedIndex = -1
        txtSystolic.Focus()
    End Sub

    ' "Save Patient" Button (works for new or edited)
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
            Me.CollabBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.New_DatabaseDataSet)
            MessageBox.Show("Patient added or updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.CollabTableAdapter.Fill(Me.New_DatabaseDataSet.collab)
        Catch ex As Exception
            MessageBox.Show("Error saving patient: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' When a patient is selected from the list, fill the fields
    Private Sub patientList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles patientList.SelectedIndexChanged
        If patientList.SelectedValue Is Nothing Then Exit Sub
        Dim selectedPatientId As Integer
        If Integer.TryParse(patientList.SelectedValue.ToString(), selectedPatientId) Then
            Dim rows() As DataRow = Me.New_DatabaseDataSet.collab.Select("id = " & selectedPatientId)
            If rows.Length > 0 Then
                Dim row As DataRow = rows(0)
                txtSystolic.Text = row("Systolic").ToString()
                txtDiastolic.Text = row("Diastolic").ToString()
                txtHeartBeat.Text = row("heartbeat").ToString()
                txtTemperature.Text = row("Temp").ToString()
                txtRespiratoryRate.Text = row("RespiratoryRate").ToString()
                TextBox7.Text = row("EmergencyContact").ToString()
                If Not IsDBNull(row("Relationship")) Then
                    ComboBox1.SelectedItem = row("Relationship").ToString()
                Else
                    ComboBox1.SelectedIndex = -1
                End If
                txtSymptoms.Text = row("Symptoms").ToString()
                txtAllergies.Text = row("Allergies").ToString()
                txtPastMedical.Text = row("PastMedicalCondition").ToString()
                If Not IsDBNull(row("TakingMedication")) Then
                    Medication.SelectedItem = If(row("TakingMedication").ToString() = "1", "Yes", "No")
                Else
                    Medication.SelectedIndex = -1
                End If
                If Not IsDBNull(row("Surgeries")) Then
                    Surgeries.SelectedItem = If(row("Surgeries").ToString() = "1", "Yes", "No")
                Else
                    Surgeries.SelectedIndex = -1
                End If
                If Not IsDBNull(row("VapeSmokeDrink")) Then
                    VapeSmokeDrinkComboBox.SelectedItem = If(row("VapeSmokeDrink").ToString() = "1", "Yes", "No")
                Else
                    VapeSmokeDrinkComboBox.SelectedIndex = -1
                End If
                If Not IsDBNull(row("gottenbetter")) Then
                    Symptoms.SelectedItem = If(row("gottenbetter").ToString() = "1", "Yes", "No")
                Else
                    Symptoms.SelectedIndex = -1
                End If
                If Not IsDBNull(row("Inheritable")) Then
                    Inherit.SelectedItem = If(row("Inheritable").ToString() = "1", "Yes", "No")
                Else
                    Inherit.SelectedIndex = -1
                End If
                If Not IsDBNull(row("affectbody")) Then
                    Ability.SelectedItem = If(row("affectbody").ToString() = "1", "Yes", "No")
                Else
                    Ability.SelectedIndex = -1
                End If
                If Not IsDBNull(row("Vaccination")) Then
                    Vaccine.SelectedItem = If(row("Vaccination").ToString() = "1", "Yes", "No")
                Else
                    Vaccine.SelectedIndex = -1
                End If
                If Not IsDBNull(row("Thinkmightbepregnant")) Then
                    Pregnant.SelectedItem = If(row("Thinkmightbepregnant").ToString() = "1", "Yes", "No")
                Else
                    Pregnant.SelectedIndex = -1
                End If
                txtLastMenstrualPeriod.Text = row("FonlylastPeriod").ToString()
                If Not IsDBNull(row("Pain")) Then
                    comboPainScale.SelectedItem = row("Pain").ToString()
                Else
                    comboPainScale.SelectedIndex = -1
                End If
            End If
        End If
    End Sub

    Private Sub CollabBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CollabBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.New_DatabaseDataSet)
    End Sub

    Private Sub InfoTab_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles InfoTab.LinkClicked
        Dim infoNurseForm As New NurseInformationForm()
        infoNurseForm.CurrentNurseId = Me.CurrentNurseId
        infoNurseForm.StartPosition = FormStartPosition.CenterParent
        infoNurseForm.ShowDialog()
    End Sub
End Class
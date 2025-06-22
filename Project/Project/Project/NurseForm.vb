Imports System.Data.SqlClient

Public Class txtRelationship
    ' Properties set from SigninForm
    Public Property CurrentUsername As String
    Public Property CurrentNurseId As Integer
    Public Property CurrentUserRole As String
    Public Property CurrentUserId As Integer

    Private Sub NurseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_DatabaseDataSet.collab' table. You can move, or remove it, as needed.
        Me.CollabTableAdapter.Fill(Me.New_DatabaseDataSet.collab)
        ' Show user role and user id
        labelUserName.Text = CurrentUserRole
        labelUserId.Text = CurrentUserId.ToString()
        ' Load collab data
        Me.CollabTableAdapter.Fill(Me.New_DatabaseDataSet.collab)

        ' Bind patientList ListBox to collab table (if not already bound in designer)
        ' Display patient name, value is id (change "Name" and "id" if your table uses different names)
        Try
            patientList.DataSource = Me.New_DatabaseDataSet.collab
            patientList.DisplayMember = "Name"    ' Use your actual column for patient name
            patientList.ValueMember = "id"        ' Use your actual column for patient ID
        Catch ex As Exception
            ' Ignore if already bound or fails, just for safety
        End Try
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CollabBindingSource.AddNew()
    End Sub

    ' Update form fields when a different patient is selected
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
                txtEmergencyContact.Text = row("EmergencyContact").ToString()
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
                ' ------ HERE is the update ------
                If Not IsDBNull(row("VapeSmokeDrink")) Then
                    VapeSmokeDrinkComboBox.SelectedItem = If(row("VapeSmokeDrink").ToString() = "1", "Yes", "No")
                Else
                    VapeSmokeDrinkComboBox.SelectedIndex = -1
                End If
                ' --------------------------------
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

    ' Custom ButtonSave: Writes follow-up answers to collab table
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            ' Make sure a patient is selected (replace `selectedPatientId` with your method for getting the current collab.id)
            Dim selectedPatientId As Integer
            If patientList.SelectedValue IsNot Nothing AndAlso Integer.TryParse(patientList.SelectedValue.ToString(), selectedPatientId) Then

                Dim connStr As String = "Data Source=(localdb)\ProjectModels;Initial Catalog=New Database;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"

                Using conn As New SqlConnection(connStr)
                    Dim cmd As New SqlCommand("
UPDATE collab SET
    Systolic = @Systolic,
    Diastolic = @Diastolic,
    heartbeat = @heartbeat,
    Temp = @Temp,
    RespiratoryRate = @RespiratoryRate,
    EmergencyContact = @EmergencyContact,
    Relationship = @Relationship,
    Symptoms = @Symptoms,
    Allergies = @Allergies,
    PastMedicalCondition = @PastMedicalCondition,
    TakingMedication = @TakingMedication,
    Surgeries = @Surgeries,
    VapeSmokeDrink = @VapeSmokeDrink,
    gottenbetter = @gottenbetter,
    Inheritable = @Inheritable,
    affectbody = @affectbody,
    Vaccination = @Vaccination,
    Thinkmightbepregnant = @Thinkmightbepregnant,
    FonlylastPeriod = @FonlylastPeriod,
    Pain = @Pain
WHERE Id = @Id
", conn)
                    ' Map your form controls to the database columns
                    cmd.Parameters.AddWithValue("@Id", selectedPatientId)
                    cmd.Parameters.AddWithValue("@Systolic", Integer.Parse(txtSystolic.Text))
                    cmd.Parameters.AddWithValue("@Diastolic", Integer.Parse(txtDiastolic.Text))
                    cmd.Parameters.AddWithValue("@heartbeat", Integer.Parse(txtHeartBeat.Text))
                    cmd.Parameters.AddWithValue("@Temp", Double.Parse(txtTemperature.Text))
                    cmd.Parameters.AddWithValue("@RespiratoryRate", Double.Parse(txtRespiratoryRate.Text))
                    cmd.Parameters.AddWithValue("@EmergencyContact", txtEmergencyContact.Text)

                    ' Relationship ComboBox (assume string like "Mother", "Father", etc.)
                    If ComboBox1.SelectedItem IsNot Nothing Then
                        cmd.Parameters.AddWithValue("@Relationship", ComboBox1.SelectedItem.ToString())
                    Else
                        cmd.Parameters.AddWithValue("@Relationship", DBNull.Value)
                    End If

                    cmd.Parameters.AddWithValue("@Symptoms", txtSymptoms.Text)
                    cmd.Parameters.AddWithValue("@Allergies", txtAllergies.Text)
                    cmd.Parameters.AddWithValue("@PastMedicalCondition", txtPastMedical.Text)

                    ' For follow-up Yes/No ComboBoxes: store as 1 for "Yes", 0 for "No"
                    cmd.Parameters.AddWithValue("@TakingMedication", If(Medication.SelectedItem IsNot Nothing AndAlso Medication.SelectedItem.ToString().ToLower() = "yes", 1, 0))
                    cmd.Parameters.AddWithValue("@Surgeries", If(Surgeries.SelectedItem IsNot Nothing AndAlso Surgeries.SelectedItem.ToString().ToLower() = "yes", 1, 0))
                    ' ------ HERE is the update ------
                    cmd.Parameters.AddWithValue("@VapeSmokeDrink", If(VapeSmokeDrinkComboBox.SelectedItem IsNot Nothing AndAlso VapeSmokeDrinkComboBox.SelectedItem.ToString().ToLower() = "yes", 1, 0))
                    ' --------------------------------
                    cmd.Parameters.AddWithValue("@gottenbetter", If(Symptoms.SelectedItem IsNot Nothing AndAlso Symptoms.SelectedItem.ToString().ToLower() = "yes", 1, 0))
                    cmd.Parameters.AddWithValue("@Inheritable", If(Inherit.SelectedItem IsNot Nothing AndAlso Inherit.SelectedItem.ToString().ToLower() = "yes", 1, 0))
                    cmd.Parameters.AddWithValue("@affectbody", If(Ability.SelectedItem IsNot Nothing AndAlso Ability.SelectedItem.ToString().ToLower() = "yes", 1, 0))
                    cmd.Parameters.AddWithValue("@Vaccination", If(Vaccine.SelectedItem IsNot Nothing AndAlso Vaccine.SelectedItem.ToString().ToLower() = "yes", 1, 0))
                    cmd.Parameters.AddWithValue("@Thinkmightbepregnant", If(Pregnant.SelectedItem IsNot Nothing AndAlso Pregnant.SelectedItem.ToString().ToLower() = "yes", 1, 0))

                    cmd.Parameters.AddWithValue("@FonlylastPeriod", txtLastMenstrualPeriod.Text)

                    If comboPainScale.SelectedItem IsNot Nothing Then
                        cmd.Parameters.AddWithValue("@Pain", Integer.Parse(comboPainScale.SelectedItem.ToString()))
                    Else
                        cmd.Parameters.AddWithValue("@Pain", DBNull.Value)
                    End If

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Follow-up answers saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Optional: Refresh data after update
                        Me.CollabTableAdapter.Fill(Me.New_DatabaseDataSet.collab)
                    Else
                        MessageBox.Show("No record was updated. Check if the patient is selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Else
                MessageBox.Show("Please select a patient from the list.", "No patient selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CollabBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CollabBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.New_DatabaseDataSet)

    End Sub
End Class
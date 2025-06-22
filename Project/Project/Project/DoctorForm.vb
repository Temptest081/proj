Imports System.Data.SqlClient

Public Class DoctorForm
    Private connStr As String = "Data Source=(localdb)\ProjectModels;Initial Catalog=New Database;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"

    ' Properties set from SigninForm
    Public Property CurrentUsername As String
    Public Property CurrentDoctorId As Integer
    Public Property CurrentUserRole As String
    Public Property CurrentUserId As Integer

    Private Sub DoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show user role and user id
        labelUserName.Text = CurrentUserRole
        labelUserId.Text = CurrentUserId.ToString()

        SetCurrentDoctorIdByUsername(CurrentUsername)
        LoadPatientList()
    End Sub

    Private Sub SetCurrentDoctorIdByUsername(idNumber As String)
        Using conn As New SqlConnection(connStr)
            Dim cmd As New SqlCommand("
                SELECT d.DoctorId
                FROM doctors d
                INNER JOIN users u ON d.UserId = u.Id
                WHERE u.IdNumber = @idNumber", conn)
            cmd.Parameters.AddWithValue("@idNumber", idNumber)
            conn.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                CurrentDoctorId = Convert.ToInt32(result)
            Else
                MessageBox.Show("Doctor not found for this user ID number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        End Using
    End Sub

    Private Sub LoadPatientList()
        Using conn As New SqlConnection(connStr)
            Dim cmd As New SqlCommand("SELECT id, Name FROM collab", conn)
            Dim dt As New DataTable()
            conn.Open()
            dt.Load(cmd.ExecuteReader())
            patientList.DataSource = dt
            patientList.DisplayMember = "Name"
            patientList.ValueMember = "id"
        End Using
    End Sub

    Private Sub patientList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles patientList.SelectedIndexChanged
        If patientList.SelectedValue Is Nothing OrElse Not TypeOf patientList.SelectedValue Is Integer Then
            patientDetailsText.Text = "No patient selected."
            Return
        End If

        Dim patientId As Integer = CInt(patientList.SelectedValue)
        Using conn As New SqlConnection(connStr)
            ' Use collab instead of patients
            Dim cmd As New SqlCommand("SELECT * FROM collab WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", patientId)
            conn.Open()
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' Safely read columns, handle DBNull
                    Dim name As String = If(reader("Name") IsNot DBNull.Value, reader("Name").ToString(), "")
                    Dim gender As String = If(reader("Gender") IsNot DBNull.Value, reader("Gender").ToString(), "")
                    Dim dob As String = If(reader("DateofBirth") IsNot DBNull.Value, Convert.ToDateTime(reader("DateofBirth")).ToShortDateString(), "")
                    Dim symptoms As String = If(reader("Symptoms") IsNot DBNull.Value, reader("Symptoms").ToString(), "")
                    Dim allergies As String = If(reader("Allergies") IsNot DBNull.Value, reader("Allergies").ToString(), "")
                    Dim systolic As String = If(reader("Systolic") IsNot DBNull.Value, reader("Systolic").ToString(), "")
                    Dim diastolic As String = If(reader("Diastolic") IsNot DBNull.Value, reader("Diastolic").ToString(), "")
                    Dim heartRate As String = If(reader("heartbeat") IsNot DBNull.Value, reader("heartbeat").ToString(), "")
                    Dim temp As String = If(reader("Temp") IsNot DBNull.Value, reader("Temp").ToString(), "")

                    ' Calculate age if dob is available
                    Dim age As String = ""
                    If Not String.IsNullOrWhiteSpace(dob) Then
                        Dim birthdate As Date
                        If Date.TryParse(dob, birthdate) Then
                            age = (Date.Now.Year - birthdate.Year).ToString()
                        End If
                    End If

                    patientDetailsText.Text =
                        $"Name: {name}{Environment.NewLine}" &
                        $"Gender: {gender}{Environment.NewLine}" &
                        $"Age: {age}{Environment.NewLine}" &
                        $"Birthdate: {dob}{Environment.NewLine}" &
                        $"Symptoms: {symptoms}{Environment.NewLine}" &
                        $"Allergies: {allergies}{Environment.NewLine}" &
                        $"Blood Pressure: {systolic} / {diastolic}{Environment.NewLine}" &
                        $"Heart Rate: {heartRate}{Environment.NewLine}" &
                        $"Temperature: {temp}"

                    TextBoxPrescribe.Text = $"Name: {name}{Environment.NewLine}Prescription: "
                    TextBoxPrescribe.SelectionStart = TextBoxPrescribe.Text.Length

                    If Not IsDBNull(reader("AppointmentDate")) AndAlso reader("AppointmentDate") IsNot DBNull.Value Then
                        Dim apptDate As Date = Convert.ToDateTime(reader("AppointmentDate"))
                        MonthCalendar1.SetDate(apptDate)
                    Else
                        MonthCalendar1.SetDate(Date.Today)
                    End If
                Else
                    patientDetailsText.Text = "Patient not found."
                End If
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SigninForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim signupForm As New SignupnewNurseDoctor()
        signupForm.StartPosition = FormStartPosition.CenterParent
        signupForm.ShowDialog()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If patientList.SelectedValue Is Nothing OrElse Not TypeOf patientList.SelectedValue Is Integer Then
            MessageBox.Show("Please select a patient first.")
            Return
        End If

        Dim patientId As Integer = CInt(patientList.SelectedValue)
        Dim prescription As String = TextBoxPrescribe.Text.Replace($"Name: {patientList.Text}{Environment.NewLine}Prescription: ", "").Trim()
        Dim appointmentDate As Date = MonthCalendar1.SelectionStart

        Using conn As New SqlConnection(connStr)
            Dim cmd As New SqlCommand("UPDATE collab SET Symptoms = @symptoms, AppointmentDate = @appt WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@symptoms", prescription)
            cmd.Parameters.AddWithValue("@appt", appointmentDate)
            cmd.Parameters.AddWithValue("@id", patientId)
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Patient data and appointment saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save failed. No record updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub

    ' Show InformationForm as a dialog instead of in a panel
    Private Sub InfoTab_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles InfoTab.LinkClicked
        Dim infoForm As New InformationForm()
        infoForm.CurrentDoctorId = Me.CurrentDoctorId
        infoForm.FormBorderStyle = FormBorderStyle.None
        infoForm.StartPosition = FormStartPosition.Manual
        infoForm.Size = Panel3.ClientSize
        infoForm.Location = Panel3.PointToScreen(New Point(0, 0))
        infoForm.ShowDialog()
    End Sub
End Class
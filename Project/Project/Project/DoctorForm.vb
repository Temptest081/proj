Imports System.Data.SqlClient

Public Class DoctorForm

    Dim connStr As String = "Data Source=(localdb)\ProjectModels;Initial Catalog=New Database;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"

    Private Sub DoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatientList()
    End Sub

    Private Sub LoadPatientList()
        Using conn As New SqlConnection(connStr)
            Dim cmd As New SqlCommand("SELECT Id, Name FROM collab", conn)
            Dim dt As New DataTable()
            conn.Open()
            dt.Load(cmd.ExecuteReader())

            patientList.DisplayMember = "Name"
            patientList.ValueMember = "Id"
            patientList.DataSource = dt

            ' Attach event AFTER setting DataSource
            AddHandler patientList.SelectedIndexChanged, AddressOf PatientList_SelectedIndexChanged
        End Using
    End Sub

    Private Sub PatientList_SelectedIndexChanged(sender As Object, e As EventArgs)
        If TypeOf patientList.SelectedValue Is Integer Then
            Dim selectedId As Integer = CInt(patientList.SelectedValue)
            LoadPatientDetails(selectedId)
        End If
    End Sub

    Private Sub LoadPatientDetails(patientId As Integer)
        Using conn As New SqlConnection(connStr)
            Dim cmd As New SqlCommand("SELECT * FROM collab WHERE Id = @Id", conn)
            cmd.Parameters.AddWithValue("@Id", patientId)
            conn.Open()

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim name As String = reader("Name").ToString()
                    Dim gender As String = reader("Gender").ToString()
                    Dim dob As String = If(IsDBNull(reader("DateofBirth")), "", Convert.ToDateTime(reader("DateofBirth")).ToShortDateString())
                    Dim age As Integer = If(dob <> "", DateDiff(DateInterval.Year, Convert.ToDateTime(dob), Date.Now), 0)
                    Dim symptoms As String = reader("Symptoms").ToString()
                    Dim allergies As String = reader("Allergies").ToString()
                    Dim heartRate As String = reader("heartbeat").ToString()
                    Dim temp As String = reader("Temp").ToString()
                    Dim systolic As String = reader("Systolic").ToString()
                    Dim diastolic As String = reader("Diastolic").ToString()

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
        signupForm.ShowDialog() ' ✅ Modal form — safe inside button event
    End Sub
End Class

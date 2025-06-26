Imports System.Data.SqlClient

Public Class InformationForm
    ' This ID should be set before showing this form (from DoctorForm or after login)
    Public Property CurrentDoctorId As Integer

    Private connStr As String = "Data Source=(localdb)\ProjectModels;Initial Catalog=New Database;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"

    Private Sub InformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDoctorAndUserInfo()
        ' Enable drag-and-drop for PictureBox1
        PictureBox1.AllowDrop = True
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        ' Optionally set a placeholder image or background color here
    End Sub

    Private Sub LoadDoctorAndUserInfo()
        Using conn As New SqlConnection(connStr)
            Dim cmd As New SqlCommand("
                SELECT DoctorId, UserId, DateOfBirth, FirstName, LastName, Gender, ContactNumber,
                       Specialty, Qualifications, YearsExperience, Department, LicenseNumber,
                       MedicalSchool, DateJoined, Status
                FROM doctors
                WHERE DoctorId = @doctor_id", conn)
            cmd.Parameters.AddWithValue("@doctor_id", CurrentDoctorId)
            conn.Open()
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    DoctorIdTextBox.Text = reader("DoctorId").ToString()
                    UserIdTextBox.Text = reader("UserId").ToString()
                    If Not IsDBNull(reader("DateOfBirth")) Then DateOfBirthDateTimePicker.Value = CDate(reader("DateOfBirth"))
                    FirstNameTextBox.Text = reader("FirstName").ToString()
                    LastNameTextBox.Text = reader("LastName").ToString()
                    If Not IsDBNull(reader("Gender")) Then GenderComboBox.Text = reader("Gender").ToString()
                    ContactNumberTextBox.Text = reader("ContactNumber").ToString()
                    SpecialtyTextBox.Text = reader("Specialty").ToString()
                    QualificationsTextBox.Text = reader("Qualifications").ToString()
                    YearsExperienceTextBox.Text = reader("YearsExperience").ToString()
                    DepartmentTextBox.Text = reader("Department").ToString()
                    LicenseNumberTextBox.Text = reader("LicenseNumber").ToString()
                    MedicalSchoolTextBox.Text = reader("MedicalSchool").ToString()
                    If Not IsDBNull(reader("DateJoined")) Then DateJoinedDateTimePicker.Value = CDate(reader("DateJoined"))
                    StatusTextBox.Text = reader("Status").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            ' Update doctors table
            Dim updateDoctor As New SqlCommand("
                UPDATE doctors SET 
                    DateOfBirth=@dob,
                    FirstName=@first,
                    LastName=@last,
                    Gender=@gender,
                    ContactNumber=@contact,
                    Specialty=@specialty,
                    Qualifications=@qual,
                    YearsExperience=@years,
                    Department=@dept,
                    LicenseNumber=@license,
                    MedicalSchool=@medschool,
                    DateJoined=@datejoin,
                    Status=@status
                WHERE DoctorId=@doctor_id", conn)
            updateDoctor.Parameters.AddWithValue("@dob", DateOfBirthDateTimePicker.Value)
            updateDoctor.Parameters.AddWithValue("@first", FirstNameTextBox.Text)
            updateDoctor.Parameters.AddWithValue("@last", LastNameTextBox.Text)
            updateDoctor.Parameters.AddWithValue("@gender", GenderComboBox.Text)
            updateDoctor.Parameters.AddWithValue("@contact", ContactNumberTextBox.Text)
            updateDoctor.Parameters.AddWithValue("@specialty", SpecialtyTextBox.Text)
            updateDoctor.Parameters.AddWithValue("@qual", QualificationsTextBox.Text)
            updateDoctor.Parameters.AddWithValue("@years", YearsExperienceTextBox.Text)
            updateDoctor.Parameters.AddWithValue("@dept", DepartmentTextBox.Text)
            updateDoctor.Parameters.AddWithValue("@license", LicenseNumberTextBox.Text)
            updateDoctor.Parameters.AddWithValue("@medschool", MedicalSchoolTextBox.Text)
            updateDoctor.Parameters.AddWithValue("@datejoin", DateJoinedDateTimePicker.Value)
            updateDoctor.Parameters.AddWithValue("@status", StatusTextBox.Text)
            updateDoctor.Parameters.AddWithValue("@doctor_id", CurrentDoctorId)
            updateDoctor.ExecuteNonQuery()
            MessageBox.Show("Information saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ' --- PictureBox1 Click: Open file dialog to select image ---
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            If ofd.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    ' --- PictureBox1 DragEnter: Highlight if image file is being dragged ---
    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If files.Length > 0 AndAlso IsImageFile(files(0)) Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' --- PictureBox1 DragDrop: Load the dropped image file ---
    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length > 0 AndAlso IsImageFile(files(0)) Then
            PictureBox1.Image = Image.FromFile(files(0))
        End If
    End Sub

    ' --- Utility: Check if file is an image ---
    Private Function IsImageFile(filePath As String) As Boolean
        Dim allowedExtensions = New String() {".jpg", ".jpeg", ".png", ".bmp", ".gif"}
        Return allowedExtensions.Contains(System.IO.Path.GetExtension(filePath).ToLower())
    End Function
End Class
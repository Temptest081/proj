<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DoctorIdLabel As System.Windows.Forms.Label
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim SpecialtyLabel As System.Windows.Forms.Label
        Dim QualificationsLabel As System.Windows.Forms.Label
        Dim YearsExperienceLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim LicenseNumberLabel As System.Windows.Forms.Label
        Dim MedicalSchoolLabel As System.Windows.Forms.Label
        Dim DateJoinedLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.New_DatabaseDataSet = New Project.New_DatabaseDataSet()
        Me.DoctorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorsTableAdapter = New Project.New_DatabaseDataSetTableAdapters.doctorsTableAdapter()
        Me.TableAdapterManager = New Project.New_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DoctorIdTextBox = New System.Windows.Forms.TextBox()
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SpecialtyTextBox = New System.Windows.Forms.TextBox()
        Me.QualificationsTextBox = New System.Windows.Forms.TextBox()
        Me.YearsExperienceTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.LicenseNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MedicalSchoolTextBox = New System.Windows.Forms.TextBox()
        Me.DateJoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        DoctorIdLabel = New System.Windows.Forms.Label()
        UserIdLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        SpecialtyLabel = New System.Windows.Forms.Label()
        QualificationsLabel = New System.Windows.Forms.Label()
        YearsExperienceLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        LicenseNumberLabel = New System.Windows.Forms.Label()
        MedicalSchoolLabel = New System.Windows.Forms.Label()
        DateJoinedLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.New_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'New_DatabaseDataSet
        '
        Me.New_DatabaseDataSet.DataSetName = "New_DatabaseDataSet"
        Me.New_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoctorsBindingSource
        '
        Me.DoctorsBindingSource.DataMember = "doctors"
        Me.DoctorsBindingSource.DataSource = Me.New_DatabaseDataSet
        '
        'DoctorsTableAdapter
        '
        Me.DoctorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.collabTableAdapter = Nothing
        Me.TableAdapterManager.doctorsTableAdapter = Me.DoctorsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project.New_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(729, 414)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 24)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DoctorIdLabel
        '
        DoctorIdLabel.AutoSize = True
        DoctorIdLabel.Location = New System.Drawing.Point(12, 9)
        DoctorIdLabel.Name = "DoctorIdLabel"
        DoctorIdLabel.Size = New System.Drawing.Size(54, 13)
        DoctorIdLabel.TabIndex = 30
        DoctorIdLabel.Text = "Doctor Id:"
        '
        'DoctorIdTextBox
        '
        Me.DoctorIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "DoctorId", True))
        Me.DoctorIdTextBox.Location = New System.Drawing.Point(72, 6)
        Me.DoctorIdTextBox.Name = "DoctorIdTextBox"
        Me.DoctorIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DoctorIdTextBox.TabIndex = 31
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(192, 9)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(44, 13)
        UserIdLabel.TabIndex = 31
        UserIdLabel.Text = "User Id:"
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "UserId", True))
        Me.UserIdTextBox.Location = New System.Drawing.Point(242, 6)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserIdTextBox.TabIndex = 32
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(362, 9)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(71, 13)
        DateOfBirthLabel.TabIndex = 32
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DoctorsBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(439, 5)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfBirthDateTimePicker.TabIndex = 33
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(12, 39)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 33
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(78, 36)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 34
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(192, 39)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 34
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(259, 36)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 35
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(365, 39)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 35
        GenderLabel.Text = "Gender:"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(416, 36)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GenderComboBox.TabIndex = 36
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(12, 72)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(87, 13)
        ContactNumberLabel.TabIndex = 36
        ContactNumberLabel.Text = "Contact Number:"
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(105, 69)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactNumberTextBox.TabIndex = 37
        '
        'SpecialtyLabel
        '
        SpecialtyLabel.AutoSize = True
        SpecialtyLabel.Location = New System.Drawing.Point(220, 72)
        SpecialtyLabel.Name = "SpecialtyLabel"
        SpecialtyLabel.Size = New System.Drawing.Size(53, 13)
        SpecialtyLabel.TabIndex = 37
        SpecialtyLabel.Text = "Specialty:"
        '
        'SpecialtyTextBox
        '
        Me.SpecialtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "Specialty", True))
        Me.SpecialtyTextBox.Location = New System.Drawing.Point(279, 69)
        Me.SpecialtyTextBox.Name = "SpecialtyTextBox"
        Me.SpecialtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpecialtyTextBox.TabIndex = 38
        '
        'QualificationsLabel
        '
        QualificationsLabel.AutoSize = True
        QualificationsLabel.Location = New System.Drawing.Point(395, 72)
        QualificationsLabel.Name = "QualificationsLabel"
        QualificationsLabel.Size = New System.Drawing.Size(73, 13)
        QualificationsLabel.TabIndex = 38
        QualificationsLabel.Text = "Qualifications:"
        '
        'QualificationsTextBox
        '
        Me.QualificationsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "Qualifications", True))
        Me.QualificationsTextBox.Location = New System.Drawing.Point(474, 69)
        Me.QualificationsTextBox.Name = "QualificationsTextBox"
        Me.QualificationsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QualificationsTextBox.TabIndex = 39
        '
        'YearsExperienceLabel
        '
        YearsExperienceLabel.AutoSize = True
        YearsExperienceLabel.Location = New System.Drawing.Point(12, 106)
        YearsExperienceLabel.Name = "YearsExperienceLabel"
        YearsExperienceLabel.Size = New System.Drawing.Size(93, 13)
        YearsExperienceLabel.TabIndex = 39
        YearsExperienceLabel.Text = "Years Experience:"
        '
        'YearsExperienceTextBox
        '
        Me.YearsExperienceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "YearsExperience", True))
        Me.YearsExperienceTextBox.Location = New System.Drawing.Point(111, 103)
        Me.YearsExperienceTextBox.Name = "YearsExperienceTextBox"
        Me.YearsExperienceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YearsExperienceTextBox.TabIndex = 40
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(220, 106)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 40
        DepartmentLabel.Text = "Department:"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(291, 103)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DepartmentTextBox.TabIndex = 41
        '
        'LicenseNumberLabel
        '
        LicenseNumberLabel.AutoSize = True
        LicenseNumberLabel.Location = New System.Drawing.Point(413, 106)
        LicenseNumberLabel.Name = "LicenseNumberLabel"
        LicenseNumberLabel.Size = New System.Drawing.Size(87, 13)
        LicenseNumberLabel.TabIndex = 41
        LicenseNumberLabel.Text = "License Number:"
        '
        'LicenseNumberTextBox
        '
        Me.LicenseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "LicenseNumber", True))
        Me.LicenseNumberTextBox.Location = New System.Drawing.Point(506, 103)
        Me.LicenseNumberTextBox.Name = "LicenseNumberTextBox"
        Me.LicenseNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LicenseNumberTextBox.TabIndex = 42
        '
        'MedicalSchoolLabel
        '
        MedicalSchoolLabel.AutoSize = True
        MedicalSchoolLabel.Location = New System.Drawing.Point(12, 137)
        MedicalSchoolLabel.Name = "MedicalSchoolLabel"
        MedicalSchoolLabel.Size = New System.Drawing.Size(83, 13)
        MedicalSchoolLabel.TabIndex = 42
        MedicalSchoolLabel.Text = "Medical School:"
        '
        'MedicalSchoolTextBox
        '
        Me.MedicalSchoolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "MedicalSchool", True))
        Me.MedicalSchoolTextBox.Location = New System.Drawing.Point(101, 134)
        Me.MedicalSchoolTextBox.Name = "MedicalSchoolTextBox"
        Me.MedicalSchoolTextBox.Size = New System.Drawing.Size(505, 20)
        Me.MedicalSchoolTextBox.TabIndex = 43
        '
        'DateJoinedLabel
        '
        DateJoinedLabel.AutoSize = True
        DateJoinedLabel.Location = New System.Drawing.Point(12, 170)
        DateJoinedLabel.Name = "DateJoinedLabel"
        DateJoinedLabel.Size = New System.Drawing.Size(67, 13)
        DateJoinedLabel.TabIndex = 43
        DateJoinedLabel.Text = "Date Joined:"
        '
        'DateJoinedDateTimePicker
        '
        Me.DateJoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DoctorsBindingSource, "DateJoined", True))
        Me.DateJoinedDateTimePicker.Location = New System.Drawing.Point(85, 166)
        Me.DateJoinedDateTimePicker.Name = "DateJoinedDateTimePicker"
        Me.DateJoinedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateJoinedDateTimePicker.TabIndex = 44
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(302, 170)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 44
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(348, 167)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StatusTextBox.TabIndex = 45
        '
        'InformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 458)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(DateJoinedLabel)
        Me.Controls.Add(Me.DateJoinedDateTimePicker)
        Me.Controls.Add(MedicalSchoolLabel)
        Me.Controls.Add(Me.MedicalSchoolTextBox)
        Me.Controls.Add(LicenseNumberLabel)
        Me.Controls.Add(Me.LicenseNumberTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(YearsExperienceLabel)
        Me.Controls.Add(Me.YearsExperienceTextBox)
        Me.Controls.Add(QualificationsLabel)
        Me.Controls.Add(Me.QualificationsTextBox)
        Me.Controls.Add(SpecialtyLabel)
        Me.Controls.Add(Me.SpecialtyTextBox)
        Me.Controls.Add(ContactNumberLabel)
        Me.Controls.Add(Me.ContactNumberTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(DateOfBirthLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(UserIdLabel)
        Me.Controls.Add(Me.UserIdTextBox)
        Me.Controls.Add(DoctorIdLabel)
        Me.Controls.Add(Me.DoctorIdTextBox)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "InformationForm"
        Me.Text = "InformationForm"
        CType(Me.New_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents New_DatabaseDataSet As New_DatabaseDataSet
    Friend WithEvents DoctorsBindingSource As BindingSource
    Friend WithEvents DoctorsTableAdapter As New_DatabaseDataSetTableAdapters.doctorsTableAdapter
    Friend WithEvents TableAdapterManager As New_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnSave As Button
    Friend WithEvents DoctorIdTextBox As TextBox
    Friend WithEvents UserIdTextBox As TextBox
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents ContactNumberTextBox As TextBox
    Friend WithEvents SpecialtyTextBox As TextBox
    Friend WithEvents QualificationsTextBox As TextBox
    Friend WithEvents YearsExperienceTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents LicenseNumberTextBox As TextBox
    Friend WithEvents MedicalSchoolTextBox As TextBox
    Friend WithEvents DateJoinedDateTimePicker As DateTimePicker
    Friend WithEvents StatusTextBox As TextBox
End Class

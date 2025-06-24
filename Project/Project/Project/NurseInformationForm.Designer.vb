<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NurseInformationForm
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
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim NurseIdLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim QualificationsLabel As System.Windows.Forms.Label
        Dim YearsExperienceLabel As System.Windows.Forms.Label
        Dim LicenseNumberLabel As System.Windows.Forms.Label
        Dim NursingSchoolLabel As System.Windows.Forms.Label
        Dim DateJoinedLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.New_DatabaseDataSet = New Project.New_DatabaseDataSet()
        Me.NursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NursesTableAdapter = New Project.New_DatabaseDataSetTableAdapters.nursesTableAdapter()
        Me.TableAdapterManager = New Project.New_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.NurseIdTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.QualificationsTextBox = New System.Windows.Forms.TextBox()
        Me.YearsExperienceTextBox = New System.Windows.Forms.TextBox()
        Me.LicenseNumberTextBox = New System.Windows.Forms.TextBox()
        Me.NursingSchoolTextBox = New System.Windows.Forms.TextBox()
        Me.DateJoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        UserIdLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        NurseIdLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        QualificationsLabel = New System.Windows.Forms.Label()
        YearsExperienceLabel = New System.Windows.Forms.Label()
        LicenseNumberLabel = New System.Windows.Forms.Label()
        NursingSchoolLabel = New System.Windows.Forms.Label()
        DateJoinedLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.New_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(12, 9)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(44, 13)
        UserIdLabel.TabIndex = 1
        UserIdLabel.Text = "User Id:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(12, 39)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 2
        DepartmentLabel.Text = "Department:"
        '
        'NurseIdLabel
        '
        NurseIdLabel.AutoSize = True
        NurseIdLabel.Location = New System.Drawing.Point(12, 71)
        NurseIdLabel.Name = "NurseIdLabel"
        NurseIdLabel.Size = New System.Drawing.Size(50, 13)
        NurseIdLabel.TabIndex = 4
        NurseIdLabel.Text = "Nurse Id:"
        '
        'New_DatabaseDataSet
        '
        Me.New_DatabaseDataSet.DataSetName = "New_DatabaseDataSet"
        Me.New_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NursesBindingSource
        '
        Me.NursesBindingSource.DataMember = "nurses"
        Me.NursesBindingSource.DataSource = Me.New_DatabaseDataSet
        '
        'NursesTableAdapter
        '
        Me.NursesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.collabTableAdapter = Nothing
        Me.TableAdapterManager.doctorsTableAdapter = Nothing
        Me.TableAdapterManager.nursesTableAdapter = Me.NursesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project.New_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "UserId", True))
        Me.UserIdTextBox.Location = New System.Drawing.Point(62, 6)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserIdTextBox.TabIndex = 2
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(83, 36)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DepartmentTextBox.TabIndex = 3
        '
        'NurseIdTextBox
        '
        Me.NurseIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "NurseId", True))
        Me.NurseIdTextBox.Location = New System.Drawing.Point(68, 68)
        Me.NurseIdTextBox.Name = "NurseIdTextBox"
        Me.NurseIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NurseIdTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(601, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(202, 9)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(71, 13)
        DateOfBirthLabel.TabIndex = 8
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NursesBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(279, 5)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfBirthDateTimePicker.TabIndex = 9
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(12, 101)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 10
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(78, 98)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 11
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(12, 132)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 12
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(79, 129)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 13
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(202, 39)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 14
        GenderLabel.Text = "Gender:"
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(253, 36)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 15
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(186, 71)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(87, 13)
        ContactNumberLabel.TabIndex = 16
        ContactNumberLabel.Text = "Contact Number:"
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(279, 68)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactNumberTextBox.TabIndex = 17
        '
        'QualificationsLabel
        '
        QualificationsLabel.AutoSize = True
        QualificationsLabel.Location = New System.Drawing.Point(12, 165)
        QualificationsLabel.Name = "QualificationsLabel"
        QualificationsLabel.Size = New System.Drawing.Size(73, 13)
        QualificationsLabel.TabIndex = 18
        QualificationsLabel.Text = "Qualifications:"
        '
        'QualificationsTextBox
        '
        Me.QualificationsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "Qualifications", True))
        Me.QualificationsTextBox.Location = New System.Drawing.Point(91, 162)
        Me.QualificationsTextBox.Name = "QualificationsTextBox"
        Me.QualificationsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QualificationsTextBox.TabIndex = 19
        '
        'YearsExperienceLabel
        '
        YearsExperienceLabel.AutoSize = True
        YearsExperienceLabel.Location = New System.Drawing.Point(186, 101)
        YearsExperienceLabel.Name = "YearsExperienceLabel"
        YearsExperienceLabel.Size = New System.Drawing.Size(93, 13)
        YearsExperienceLabel.TabIndex = 20
        YearsExperienceLabel.Text = "Years Experience:"
        '
        'YearsExperienceTextBox
        '
        Me.YearsExperienceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "YearsExperience", True))
        Me.YearsExperienceTextBox.Location = New System.Drawing.Point(285, 98)
        Me.YearsExperienceTextBox.Name = "YearsExperienceTextBox"
        Me.YearsExperienceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YearsExperienceTextBox.TabIndex = 21
        '
        'LicenseNumberLabel
        '
        LicenseNumberLabel.AutoSize = True
        LicenseNumberLabel.Location = New System.Drawing.Point(186, 132)
        LicenseNumberLabel.Name = "LicenseNumberLabel"
        LicenseNumberLabel.Size = New System.Drawing.Size(87, 13)
        LicenseNumberLabel.TabIndex = 22
        LicenseNumberLabel.Text = "License Number:"
        '
        'LicenseNumberTextBox
        '
        Me.LicenseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "LicenseNumber", True))
        Me.LicenseNumberTextBox.Location = New System.Drawing.Point(279, 129)
        Me.LicenseNumberTextBox.Name = "LicenseNumberTextBox"
        Me.LicenseNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LicenseNumberTextBox.TabIndex = 23
        '
        'NursingSchoolLabel
        '
        NursingSchoolLabel.AutoSize = True
        NursingSchoolLabel.Location = New System.Drawing.Point(12, 196)
        NursingSchoolLabel.Name = "NursingSchoolLabel"
        NursingSchoolLabel.Size = New System.Drawing.Size(82, 13)
        NursingSchoolLabel.TabIndex = 24
        NursingSchoolLabel.Text = "Nursing School:"
        '
        'NursingSchoolTextBox
        '
        Me.NursingSchoolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "NursingSchool", True))
        Me.NursingSchoolTextBox.Location = New System.Drawing.Point(100, 193)
        Me.NursingSchoolTextBox.Name = "NursingSchoolTextBox"
        Me.NursingSchoolTextBox.Size = New System.Drawing.Size(379, 20)
        Me.NursingSchoolTextBox.TabIndex = 25
        '
        'DateJoinedLabel
        '
        DateJoinedLabel.AutoSize = True
        DateJoinedLabel.Location = New System.Drawing.Point(206, 165)
        DateJoinedLabel.Name = "DateJoinedLabel"
        DateJoinedLabel.Size = New System.Drawing.Size(67, 13)
        DateJoinedLabel.TabIndex = 26
        DateJoinedLabel.Text = "Date Joined:"
        '
        'DateJoinedDateTimePicker
        '
        Me.DateJoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NursesBindingSource, "DateJoined", True))
        Me.DateJoinedDateTimePicker.Location = New System.Drawing.Point(279, 161)
        Me.DateJoinedDateTimePicker.Name = "DateJoinedDateTimePicker"
        Me.DateJoinedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateJoinedDateTimePicker.TabIndex = 27
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(12, 225)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 28
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NursesBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(58, 222)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StatusTextBox.TabIndex = 29
        '
        'NurseInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 458)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(DateJoinedLabel)
        Me.Controls.Add(Me.DateJoinedDateTimePicker)
        Me.Controls.Add(NursingSchoolLabel)
        Me.Controls.Add(Me.NursingSchoolTextBox)
        Me.Controls.Add(LicenseNumberLabel)
        Me.Controls.Add(Me.LicenseNumberTextBox)
        Me.Controls.Add(YearsExperienceLabel)
        Me.Controls.Add(Me.YearsExperienceTextBox)
        Me.Controls.Add(QualificationsLabel)
        Me.Controls.Add(Me.QualificationsTextBox)
        Me.Controls.Add(ContactNumberLabel)
        Me.Controls.Add(Me.ContactNumberTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(DateOfBirthLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NurseIdLabel)
        Me.Controls.Add(Me.NurseIdTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(UserIdLabel)
        Me.Controls.Add(Me.UserIdTextBox)
        Me.Name = "NurseInformationForm"
        Me.Text = "NurseInformationForm"
        CType(Me.New_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents New_DatabaseDataSet As New_DatabaseDataSet
    Friend WithEvents NursesBindingSource As BindingSource
    Friend WithEvents NursesTableAdapter As New_DatabaseDataSetTableAdapters.nursesTableAdapter
    Friend WithEvents TableAdapterManager As New_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserIdTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents NurseIdTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents ContactNumberTextBox As TextBox
    Friend WithEvents QualificationsTextBox As TextBox
    Friend WithEvents YearsExperienceTextBox As TextBox
    Friend WithEvents LicenseNumberTextBox As TextBox
    Friend WithEvents NursingSchoolTextBox As TextBox
    Friend WithEvents DateJoinedDateTimePicker As DateTimePicker
    Friend WithEvents StatusTextBox As TextBox
End Class

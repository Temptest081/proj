<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class txtRelationship
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
        Dim TimeLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(txtRelationship))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.patientList = New System.Windows.Forms.ListBox()
        Me.txtSurgeries = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.InfoTab = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelUserName = New System.Windows.Forms.Label()
        Me.labelUserId = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.LabelBloodPressure = New System.Windows.Forms.Label()
        Me.txtSystolic = New System.Windows.Forms.TextBox()
        Me.CollabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.New_DatabaseDataSet = New Project.New_DatabaseDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiastolic = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHeartBeat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRespiratoryRate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmergencyContact = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtSymptoms = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPastMedical = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.comboPainScale = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtLastMenstrualPeriod = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TimeTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VapeSmokeDrinkComboBox = New System.Windows.Forms.ComboBox()
        Me.Pregnant = New System.Windows.Forms.ComboBox()
        Me.Vaccine = New System.Windows.Forms.ComboBox()
        Me.Ability = New System.Windows.Forms.ComboBox()
        Me.Inherit = New System.Windows.Forms.ComboBox()
        Me.Symptoms = New System.Windows.Forms.ComboBox()
        Me.Surgeries = New System.Windows.Forms.ComboBox()
        Me.Medication = New System.Windows.Forms.ComboBox()
        Me.CollabTableAdapter = New Project.New_DatabaseDataSetTableAdapters.collabTableAdapter()
        Me.TableAdapterManager = New Project.New_DatabaseDataSetTableAdapters.TableAdapterManager()
        TimeLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Me.txtSurgeries.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimeLabel
        '
        TimeLabel.AutoSize = True
        TimeLabel.Location = New System.Drawing.Point(6, 10)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New System.Drawing.Size(33, 13)
        TimeLabel.TabIndex = 76
        TimeLabel.Text = "Time:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(156, 10)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(59, 13)
        IdLabel.TabIndex = 77
        IdLabel.Text = "ID number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Patients:"
        '
        'patientList
        '
        Me.patientList.BackColor = System.Drawing.SystemColors.ControlLight
        Me.patientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.patientList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientList.FormattingEnabled = True
        Me.patientList.ItemHeight = 21
        Me.patientList.Location = New System.Drawing.Point(7, 52)
        Me.patientList.Name = "patientList"
        Me.patientList.Size = New System.Drawing.Size(197, 401)
        Me.patientList.TabIndex = 9
        '
        'txtSurgeries
        '
        Me.txtSurgeries.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtSurgeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSurgeries.Controls.Add(Me.LinkLabel2)
        Me.txtSurgeries.Controls.Add(Me.InfoTab)
        Me.txtSurgeries.Controls.Add(Me.PictureBox1)
        Me.txtSurgeries.Controls.Add(Me.labelUserName)
        Me.txtSurgeries.Controls.Add(Me.labelUserId)
        Me.txtSurgeries.Controls.Add(Me.Button4)
        Me.txtSurgeries.Controls.Add(Me.Button5)
        Me.txtSurgeries.Controls.Add(Me.ButtonSave)
        Me.txtSurgeries.Location = New System.Drawing.Point(950, 53)
        Me.txtSurgeries.Name = "txtSurgeries"
        Me.txtSurgeries.Size = New System.Drawing.Size(213, 400)
        Me.txtSurgeries.TabIndex = 101
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(80, 214)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel2.TabIndex = 105
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Home"
        '
        'InfoTab
        '
        Me.InfoTab.AutoSize = True
        Me.InfoTab.LinkColor = System.Drawing.Color.Black
        Me.InfoTab.Location = New System.Drawing.Point(67, 248)
        Me.InfoTab.Name = "InfoTab"
        Me.InfoTab.Size = New System.Drawing.Size(59, 13)
        Me.InfoTab.TabIndex = 104
        Me.InfoTab.TabStop = True
        Me.InfoTab.Text = "Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(51, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 91)
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'labelUserName
        '
        Me.labelUserName.AutoSize = True
        Me.labelUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.labelUserName.Location = New System.Drawing.Point(47, 125)
        Me.labelUserName.Name = "labelUserName"
        Me.labelUserName.Size = New System.Drawing.Size(48, 21)
        Me.labelUserName.TabIndex = 101
        Me.labelUserName.Text = "Role:"
        '
        'labelUserId
        '
        Me.labelUserId.AutoSize = True
        Me.labelUserId.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.labelUserId.Location = New System.Drawing.Point(116, 128)
        Me.labelUserId.Name = "labelUserId"
        Me.labelUserId.Size = New System.Drawing.Size(24, 20)
        Me.labelUserId.TabIndex = 102
        Me.labelUserId.Text = "ID"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(83, 362)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 33)
        Me.Button4.TabIndex = 19
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(168, 363)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(44, 32)
        Me.Button5.TabIndex = 0
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackgroundImage = CType(resources.GetObject("ButtonSave.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSave.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonSave.Location = New System.Drawing.Point(-1, 363)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(44, 33)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'LabelBloodPressure
        '
        Me.LabelBloodPressure.AutoSize = True
        Me.LabelBloodPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBloodPressure.Location = New System.Drawing.Point(3, 29)
        Me.LabelBloodPressure.Name = "LabelBloodPressure"
        Me.LabelBloodPressure.Size = New System.Drawing.Size(118, 16)
        Me.LabelBloodPressure.TabIndex = 15
        Me.LabelBloodPressure.Text = "Blood Pressure:"
        '
        'txtSystolic
        '
        Me.txtSystolic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Systolic", True))
        Me.txtSystolic.Location = New System.Drawing.Point(60, 48)
        Me.txtSystolic.Name = "txtSystolic"
        Me.txtSystolic.Size = New System.Drawing.Size(45, 20)
        Me.txtSystolic.TabIndex = 16
        '
        'CollabBindingSource
        '
        Me.CollabBindingSource.DataMember = "collab"
        Me.CollabBindingSource.DataSource = Me.New_DatabaseDataSet
        '
        'New_DatabaseDataSet
        '
        Me.New_DatabaseDataSet.DataSetName = "New_DatabaseDataSet"
        Me.New_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(111, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "mm Hg"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Systolic:"
        '
        'txtDiastolic
        '
        Me.txtDiastolic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Diastolic", True))
        Me.txtDiastolic.Location = New System.Drawing.Point(233, 48)
        Me.txtDiastolic.Name = "txtDiastolic"
        Me.txtDiastolic.Size = New System.Drawing.Size(45, 20)
        Me.txtDiastolic.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(170, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Diastolic:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(284, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "mm Hg"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Heart Beat:"
        '
        'txtHeartBeat
        '
        Me.txtHeartBeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "heartbeat", True))
        Me.txtHeartBeat.Location = New System.Drawing.Point(70, 77)
        Me.txtHeartBeat.Name = "txtHeartBeat"
        Me.txtHeartBeat.Size = New System.Drawing.Size(45, 20)
        Me.txtHeartBeat.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(121, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "bpm"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(170, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Temperature:"
        '
        'txtTemperature
        '
        Me.txtTemperature.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Temp", True))
        Me.txtTemperature.Location = New System.Drawing.Point(246, 77)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(41, 20)
        Me.txtTemperature.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(293, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Celsius"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Respiratory Rate:"
        '
        'txtRespiratoryRate
        '
        Me.txtRespiratoryRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "RespiratoryRate", True))
        Me.txtRespiratoryRate.Location = New System.Drawing.Point(99, 104)
        Me.txtRespiratoryRate.Name = "txtRespiratoryRate"
        Me.txtRespiratoryRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRespiratoryRate.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(205, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Breath/m"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 16)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Questions"
        '
        'txtEmergencyContact
        '
        Me.txtEmergencyContact.AutoSize = True
        Me.txtEmergencyContact.Location = New System.Drawing.Point(4, 134)
        Me.txtEmergencyContact.Name = "txtEmergencyContact"
        Me.txtEmergencyContact.Size = New System.Drawing.Size(103, 13)
        Me.txtEmergencyContact.TabIndex = 36
        Me.txtEmergencyContact.Text = "Emergency Contact:"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "EmergencyContact", True))
        Me.TextBox7.Location = New System.Drawing.Point(113, 131)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Symptoms:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 159)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Name", True))
        Me.txtName.Location = New System.Drawing.Point(48, 156)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(162, 159)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Relationship:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Relationship", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mother", "Father", "GrandFather", "GrandMother", "Sister", "Brother", "Cousin", "Others"})
        Me.ComboBox1.Location = New System.Drawing.Point(233, 156)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox1.TabIndex = 42
        '
        'txtSymptoms
        '
        Me.txtSymptoms.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Symptoms", True))
        Me.txtSymptoms.Location = New System.Drawing.Point(7, 224)
        Me.txtSymptoms.Multiline = True
        Me.txtSymptoms.Name = "txtSymptoms"
        Me.txtSymptoms.Size = New System.Drawing.Size(326, 37)
        Me.txtSymptoms.TabIndex = 43
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 264)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Allergies:"
        '
        'txtAllergies
        '
        Me.txtAllergies.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Allergies", True))
        Me.txtAllergies.Location = New System.Drawing.Point(9, 280)
        Me.txtAllergies.Multiline = True
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.Size = New System.Drawing.Size(326, 37)
        Me.txtAllergies.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 320)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 13)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Past Medical Conditions:"
        '
        'txtPastMedical
        '
        Me.txtPastMedical.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "PastMedicalCondition", True))
        Me.txtPastMedical.Location = New System.Drawing.Point(7, 336)
        Me.txtPastMedical.Multiline = True
        Me.txtPastMedical.Name = "txtPastMedical"
        Me.txtPastMedical.Size = New System.Drawing.Size(326, 37)
        Me.txtPastMedical.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(344, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 16)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Follow ups:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(344, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(156, 13)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Taking any type of Medication?"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(344, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(131, 13)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "Had any surgeries before?"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(344, 113)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(163, 13)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "Smoke, Drink Alcohol or Vaping?"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(344, 363)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(107, 13)
        Me.Label24.TabIndex = 58
        Me.Label24.Text = "Rate the pain 1 to 10"
        '
        'comboPainScale
        '
        Me.comboPainScale.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Pain", True))
        Me.comboPainScale.FormattingEnabled = True
        Me.comboPainScale.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.comboPainScale.Location = New System.Drawing.Point(457, 360)
        Me.comboPainScale.Name = "comboPainScale"
        Me.comboPainScale.Size = New System.Drawing.Size(121, 21)
        Me.comboPainScale.TabIndex = 59
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(344, 156)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(139, 13)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "did symptoms gotten better?"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(344, 195)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(217, 13)
        Me.Label26.TabIndex = 63
        Me.Label26.Text = "Any side of the family have the same Illness?"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(344, 231)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(346, 13)
        Me.Label27.TabIndex = 66
        Me.Label27.Text = "Have your symptoms affected your ability to eat, sleep, or move around?"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(344, 267)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(279, 13)
        Me.Label28.TabIndex = 69
        Me.Label28.Text = "Did you get any Vaccination?( Boosters, Covid Vaccines )"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(344, 304)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(269, 13)
        Me.Label29.TabIndex = 72
        Me.Label29.Text = "( for Female only ) when was your last menstrual period?"
        '
        'txtLastMenstrualPeriod
        '
        Me.txtLastMenstrualPeriod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "FonlylastPeriod", True))
        Me.txtLastMenstrualPeriod.Location = New System.Drawing.Point(619, 301)
        Me.txtLastMenstrualPeriod.Name = "txtLastMenstrualPeriod"
        Me.txtLastMenstrualPeriod.Size = New System.Drawing.Size(60, 20)
        Me.txtLastMenstrualPeriod.TabIndex = 73
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(344, 320)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(175, 13)
        Me.Label30.TabIndex = 74
        Me.Label30.Text = "Are you pregnant or think might be?"
        '
        'TimeTextBox
        '
        Me.TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Time", True))
        Me.TimeTextBox.Location = New System.Drawing.Point(45, 7)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TimeTextBox.TabIndex = 77
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(221, 7)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 78
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.VapeSmokeDrinkComboBox)
        Me.Panel1.Controls.Add(Me.Pregnant)
        Me.Panel1.Controls.Add(Me.Vaccine)
        Me.Panel1.Controls.Add(Me.Ability)
        Me.Panel1.Controls.Add(Me.Inherit)
        Me.Panel1.Controls.Add(Me.Symptoms)
        Me.Panel1.Controls.Add(Me.Surgeries)
        Me.Panel1.Controls.Add(Me.Medication)
        Me.Panel1.Controls.Add(IdLabel)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(TimeLabel)
        Me.Panel1.Controls.Add(Me.TimeTextBox)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.txtLastMenstrualPeriod)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.comboPainScale)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtPastMedical)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.txtAllergies)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtSymptoms)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.txtEmergencyContact)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtRespiratoryRate)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtTemperature)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtHeartBeat)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtDiastolic)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSystolic)
        Me.Panel1.Controls.Add(Me.LabelBloodPressure)
        Me.Panel1.Location = New System.Drawing.Point(210, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 401)
        Me.Panel1.TabIndex = 25
        '
        'VapeSmokeDrinkComboBox
        '
        Me.VapeSmokeDrinkComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "VapeSmokeDrink", True))
        Me.VapeSmokeDrinkComboBox.FormattingEnabled = True
        Me.VapeSmokeDrinkComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.VapeSmokeDrinkComboBox.Location = New System.Drawing.Point(347, 130)
        Me.VapeSmokeDrinkComboBox.Name = "VapeSmokeDrinkComboBox"
        Me.VapeSmokeDrinkComboBox.Size = New System.Drawing.Size(121, 21)
        Me.VapeSmokeDrinkComboBox.TabIndex = 87
        '
        'Pregnant
        '
        Me.Pregnant.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Thinkmightbepregnant", True))
        Me.Pregnant.FormattingEnabled = True
        Me.Pregnant.Items.AddRange(New Object() {"Yes", "No"})
        Me.Pregnant.Location = New System.Drawing.Point(347, 336)
        Me.Pregnant.Name = "Pregnant"
        Me.Pregnant.Size = New System.Drawing.Size(121, 21)
        Me.Pregnant.TabIndex = 86
        '
        'Vaccine
        '
        Me.Vaccine.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Vaccination", True))
        Me.Vaccine.FormattingEnabled = True
        Me.Vaccine.Items.AddRange(New Object() {"Yes", "No"})
        Me.Vaccine.Location = New System.Drawing.Point(347, 280)
        Me.Vaccine.Name = "Vaccine"
        Me.Vaccine.Size = New System.Drawing.Size(121, 21)
        Me.Vaccine.TabIndex = 85
        '
        'Ability
        '
        Me.Ability.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "affectbody", True))
        Me.Ability.FormattingEnabled = True
        Me.Ability.Items.AddRange(New Object() {"Yes", "No"})
        Me.Ability.Location = New System.Drawing.Point(347, 246)
        Me.Ability.Name = "Ability"
        Me.Ability.Size = New System.Drawing.Size(121, 21)
        Me.Ability.TabIndex = 84
        '
        'Inherit
        '
        Me.Inherit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Inheritable", True))
        Me.Inherit.FormattingEnabled = True
        Me.Inherit.Items.AddRange(New Object() {"Yes", "No"})
        Me.Inherit.Location = New System.Drawing.Point(347, 211)
        Me.Inherit.Name = "Inherit"
        Me.Inherit.Size = New System.Drawing.Size(121, 21)
        Me.Inherit.TabIndex = 83
        '
        'Symptoms
        '
        Me.Symptoms.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "gottenbetter", True))
        Me.Symptoms.FormattingEnabled = True
        Me.Symptoms.Items.AddRange(New Object() {"Yes", "No"})
        Me.Symptoms.Location = New System.Drawing.Point(347, 171)
        Me.Symptoms.Name = "Symptoms"
        Me.Symptoms.Size = New System.Drawing.Size(121, 21)
        Me.Symptoms.TabIndex = 82
        '
        'Surgeries
        '
        Me.Surgeries.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "Surgeries", True))
        Me.Surgeries.FormattingEnabled = True
        Me.Surgeries.Items.AddRange(New Object() {"Yes", "No"})
        Me.Surgeries.Location = New System.Drawing.Point(347, 93)
        Me.Surgeries.Name = "Surgeries"
        Me.Surgeries.Size = New System.Drawing.Size(121, 21)
        Me.Surgeries.TabIndex = 80
        '
        'Medication
        '
        Me.Medication.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollabBindingSource, "TakingMedication", True))
        Me.Medication.FormattingEnabled = True
        Me.Medication.Items.AddRange(New Object() {"Yes", "No"})
        Me.Medication.Location = New System.Drawing.Point(347, 53)
        Me.Medication.Name = "Medication"
        Me.Medication.Size = New System.Drawing.Size(121, 21)
        Me.Medication.TabIndex = 79
        '
        'CollabTableAdapter
        '
        Me.CollabTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.collabTableAdapter = Me.CollabTableAdapter
        Me.TableAdapterManager.doctorsTableAdapter = Nothing
        Me.TableAdapterManager.nursesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project.New_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'txtRelationship
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 460)
        Me.Controls.Add(Me.txtSurgeries)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.patientList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "txtRelationship"
        Me.Text = "NurseForm"
        Me.txtSurgeries.ResumeLayout(False)
        Me.txtSurgeries.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents patientList As ListBox
    Friend WithEvents txtSurgeries As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents InfoTab As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelUserName As Label
    Friend WithEvents labelUserId As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents LabelBloodPressure As Label
    Friend WithEvents txtSystolic As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiastolic As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHeartBeat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRespiratoryRate As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEmergencyContact As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtSymptoms As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPastMedical As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents comboPainScale As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtLastMenstrualPeriod As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TimeTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Ability As ComboBox
    Friend WithEvents Inherit As ComboBox
    Friend WithEvents Symptoms As ComboBox
    Friend WithEvents Surgeries As ComboBox
    Friend WithEvents Medication As ComboBox
    Friend WithEvents Vaccine As ComboBox
    Friend WithEvents Pregnant As ComboBox
    Friend WithEvents New_DatabaseDataSet As New_DatabaseDataSet
    Friend WithEvents CollabBindingSource As BindingSource
    Friend WithEvents CollabTableAdapter As New_DatabaseDataSetTableAdapters.collabTableAdapter
    Friend WithEvents TableAdapterManager As New_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VapeSmokeDrinkComboBox As ComboBox
End Class

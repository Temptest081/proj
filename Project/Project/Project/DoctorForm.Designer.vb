<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoctorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CollabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.New_DatabaseDataSet = New Project.New_DatabaseDataSet()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.CollabTableAdapter = New Project.New_DatabaseDataSetTableAdapters.collabTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.panelUserInfo = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.InfoTab = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelUserName = New System.Windows.Forms.Label()
        Me.labelUserId = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.XrayPictureBox = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.labelPatientDetails = New System.Windows.Forms.Label()
        Me.patientList = New System.Windows.Forms.ListBox()
        Me.TextBoxDiagnosis = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.patientDetailsText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelComment = New System.Windows.Forms.Label()
        Me.labelXray = New System.Windows.Forms.Label()
        Me.TextBoxPrescribe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelAppointment = New System.Windows.Forms.Label()
        Me.LabelDiagnosis = New System.Windows.Forms.Label()
        CType(Me.CollabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelUserInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.XrayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(168, 636)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
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
        'ButtonSave
        '
        Me.ButtonSave.BackgroundImage = CType(resources.GetObject("ButtonSave.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSave.Location = New System.Drawing.Point(-1, 636)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(44, 33)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'CollabTableAdapter
        '
        Me.CollabTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(83, 635)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 33)
        Me.Button2.TabIndex = 19
        Me.Button2.UseVisualStyleBackColor = False
        '
        'panelUserInfo
        '
        Me.panelUserInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panelUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelUserInfo.Controls.Add(Me.LinkLabel2)
        Me.panelUserInfo.Controls.Add(Me.InfoTab)
        Me.panelUserInfo.Controls.Add(Me.PictureBox1)
        Me.panelUserInfo.Controls.Add(Me.labelUserName)
        Me.panelUserInfo.Controls.Add(Me.labelUserId)
        Me.panelUserInfo.Controls.Add(Me.Button2)
        Me.panelUserInfo.Controls.Add(Me.Button1)
        Me.panelUserInfo.Controls.Add(Me.ButtonSave)
        Me.panelUserInfo.Location = New System.Drawing.Point(1034, 12)
        Me.panelUserInfo.Name = "panelUserInfo"
        Me.panelUserInfo.Size = New System.Drawing.Size(213, 672)
        Me.panelUserInfo.TabIndex = 100
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(80, 214)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(37, 13)
        Me.LinkLabel2.TabIndex = 105
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Home"
        '
        'InfoTab
        '
        Me.InfoTab.AutoSize = True
        Me.InfoTab.LinkColor = System.Drawing.Color.Black
        Me.InfoTab.Location = New System.Drawing.Point(67, 259)
        Me.InfoTab.Name = "InfoTab"
        Me.InfoTab.Size = New System.Drawing.Size(68, 13)
        Me.InfoTab.TabIndex = 104
        Me.InfoTab.TabStop = True
        Me.InfoTab.Text = "Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(45, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 91)
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'labelUserName
        '
        Me.labelUserName.AutoSize = True
        Me.labelUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.labelUserName.Location = New System.Drawing.Point(79, 118)
        Me.labelUserName.Name = "labelUserName"
        Me.labelUserName.Size = New System.Drawing.Size(48, 21)
        Me.labelUserName.TabIndex = 101
        Me.labelUserName.Text = "Role:"
        '
        'labelUserId
        '
        Me.labelUserId.AutoSize = True
        Me.labelUserId.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.labelUserId.Location = New System.Drawing.Point(79, 149)
        Me.labelUserId.Name = "labelUserId"
        Me.labelUserId.Size = New System.Drawing.Size(114, 20)
        Me.labelUserId.TabIndex = 102
        Me.labelUserId.Text = "ID: [ID Number]"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.XrayPictureBox)
        Me.Panel3.Controls.Add(Me.RichTextBox1)
        Me.Panel3.Controls.Add(Me.labelPatientDetails)
        Me.Panel3.Controls.Add(Me.patientList)
        Me.Panel3.Controls.Add(Me.TextBoxDiagnosis)
        Me.Panel3.Controls.Add(Me.MonthCalendar1)
        Me.Panel3.Controls.Add(Me.patientDetailsText)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.LabelComment)
        Me.Panel3.Controls.Add(Me.labelXray)
        Me.Panel3.Controls.Add(Me.TextBoxPrescribe)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LabelAppointment)
        Me.Panel3.Controls.Add(Me.LabelDiagnosis)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1002, 667)
        Me.Panel3.TabIndex = 21
        '
        'XrayPictureBox
        '
        Me.XrayPictureBox.BackColor = System.Drawing.Color.LightGray
        Me.XrayPictureBox.Image = Global.Project.My.Resources.Resources.xray
        Me.XrayPictureBox.InitialImage = Nothing
        Me.XrayPictureBox.Location = New System.Drawing.Point(333, 61)
        Me.XrayPictureBox.Name = "XrayPictureBox"
        Me.XrayPictureBox.Size = New System.Drawing.Size(300, 401)
        Me.XrayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.XrayPictureBox.TabIndex = 6
        Me.XrayPictureBox.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox1.Location = New System.Drawing.Point(333, 500)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(667, 162)
        Me.RichTextBox1.TabIndex = 20
        Me.RichTextBox1.Text = ""
        '
        'labelPatientDetails
        '
        Me.labelPatientDetails.AutoSize = True
        Me.labelPatientDetails.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPatientDetails.Location = New System.Drawing.Point(4, 241)
        Me.labelPatientDetails.Name = "labelPatientDetails"
        Me.labelPatientDetails.Size = New System.Drawing.Size(160, 30)
        Me.labelPatientDetails.TabIndex = 4
        Me.labelPatientDetails.Text = "Patient Details:"
        '
        'patientList
        '
        Me.patientList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.patientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.patientList.DataSource = Me.CollabBindingSource
        Me.patientList.DisplayMember = "Name"
        Me.patientList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientList.FormattingEnabled = True
        Me.patientList.ItemHeight = 21
        Me.patientList.Location = New System.Drawing.Point(1, 45)
        Me.patientList.Name = "patientList"
        Me.patientList.Size = New System.Drawing.Size(300, 170)
        Me.patientList.TabIndex = 1
        '
        'TextBoxDiagnosis
        '
        Me.TextBoxDiagnosis.Location = New System.Drawing.Point(679, 61)
        Me.TextBoxDiagnosis.Multiline = True
        Me.TextBoxDiagnosis.Name = "TextBoxDiagnosis"
        Me.TextBoxDiagnosis.ReadOnly = True
        Me.TextBoxDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDiagnosis.Size = New System.Drawing.Size(300, 165)
        Me.TextBoxDiagnosis.TabIndex = 8
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MonthCalendar1.Location = New System.Drawing.Point(43, 500)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 17
        '
        'patientDetailsText
        '
        Me.patientDetailsText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.patientDetailsText.Location = New System.Drawing.Point(1, 274)
        Me.patientDetailsText.Multiline = True
        Me.patientDetailsText.Name = "patientDetailsText"
        Me.patientDetailsText.ReadOnly = True
        Me.patientDetailsText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.patientDetailsText.Size = New System.Drawing.Size(300, 165)
        Me.patientDetailsText.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Patients:"
        '
        'LabelComment
        '
        Me.LabelComment.AutoSize = True
        Me.LabelComment.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComment.Location = New System.Drawing.Point(674, 241)
        Me.LabelComment.Name = "LabelComment"
        Me.LabelComment.Size = New System.Drawing.Size(137, 30)
        Me.LabelComment.TabIndex = 9
        Me.LabelComment.Text = "Prescription:"
        '
        'labelXray
        '
        Me.labelXray.AutoSize = True
        Me.labelXray.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelXray.Location = New System.Drawing.Point(328, 12)
        Me.labelXray.Name = "labelXray"
        Me.labelXray.Size = New System.Drawing.Size(77, 30)
        Me.labelXray.TabIndex = 5
        Me.labelXray.Text = "X-Ray:"
        '
        'TextBoxPrescribe
        '
        Me.TextBoxPrescribe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxPrescribe.Location = New System.Drawing.Point(679, 292)
        Me.TextBoxPrescribe.Multiline = True
        Me.TextBoxPrescribe.Name = "TextBoxPrescribe"
        Me.TextBoxPrescribe.Size = New System.Drawing.Size(300, 170)
        Me.TextBoxPrescribe.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 467)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 30)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Logs:"
        '
        'LabelAppointment
        '
        Me.LabelAppointment.AutoSize = True
        Me.LabelAppointment.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAppointment.Location = New System.Drawing.Point(28, 466)
        Me.LabelAppointment.Name = "LabelAppointment"
        Me.LabelAppointment.Size = New System.Drawing.Size(255, 30)
        Me.LabelAppointment.TabIndex = 12
        Me.LabelAppointment.Text = "Following Appointment:"
        '
        'LabelDiagnosis
        '
        Me.LabelDiagnosis.AutoSize = True
        Me.LabelDiagnosis.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDiagnosis.Location = New System.Drawing.Point(724, 12)
        Me.LabelDiagnosis.Name = "LabelDiagnosis"
        Me.LabelDiagnosis.Size = New System.Drawing.Size(114, 30)
        Me.LabelDiagnosis.TabIndex = 7
        Me.LabelDiagnosis.Text = "Diagnosis:"
        '
        'DoctorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1271, 693)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panelUserInfo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "DoctorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoctorForm"
        CType(Me.CollabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelUserInfo.ResumeLayout(False)
        Me.panelUserInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.XrayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents New_DatabaseDataSet As New_DatabaseDataSet
    Friend WithEvents CollabBindingSource As BindingSource
    Friend WithEvents CollabTableAdapter As New_DatabaseDataSetTableAdapters.collabTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents panelUserInfo As Panel
    Friend WithEvents labelUserName As Label
    Friend WithEvents labelUserId As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents InfoTab As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents XrayPictureBox As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents labelPatientDetails As Label
    Friend WithEvents patientList As ListBox
    Friend WithEvents TextBoxDiagnosis As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents patientDetailsText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelComment As Label
    Friend WithEvents labelXray As Label
    Friend WithEvents TextBoxPrescribe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelAppointment As Label
    Friend WithEvents LabelDiagnosis As Label
End Class

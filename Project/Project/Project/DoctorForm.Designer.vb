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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.patientList = New System.Windows.Forms.ListBox()
        Me.CollabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.New_DatabaseDataSet = New Project.New_DatabaseDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.patientDetailsText = New System.Windows.Forms.TextBox()
        Me.labelPatientDetails = New System.Windows.Forms.Label()
        Me.labelXray = New System.Windows.Forms.Label()
        Me.XrayPictureBox = New System.Windows.Forms.PictureBox()
        Me.LabelDiagnosis = New System.Windows.Forms.Label()
        Me.TextBoxDiagnosis = New System.Windows.Forms.TextBox()
        Me.LabelComment = New System.Windows.Forms.Label()
        Me.TextBoxPrescribe = New System.Windows.Forms.TextBox()
        Me.LabelAppointment = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CollabTableAdapter = New Project.New_DatabaseDataSetTableAdapters.collabTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.CollabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1176, 719)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'patientList
        '
        Me.patientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.patientList.DataSource = Me.CollabBindingSource
        Me.patientList.DisplayMember = "Name"
        Me.patientList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientList.FormattingEnabled = True
        Me.patientList.ItemHeight = 21
        Me.patientList.Location = New System.Drawing.Point(26, 69)
        Me.patientList.Name = "patientList"
        Me.patientList.Size = New System.Drawing.Size(197, 401)
        Me.patientList.TabIndex = 1
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Patients:"
        '
        'patientDetailsText
        '
        Me.patientDetailsText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.patientDetailsText.Location = New System.Drawing.Point(244, 69)
        Me.patientDetailsText.Multiline = True
        Me.patientDetailsText.Name = "patientDetailsText"
        Me.patientDetailsText.ReadOnly = True
        Me.patientDetailsText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.patientDetailsText.Size = New System.Drawing.Size(300, 399)
        Me.patientDetailsText.TabIndex = 3
        '
        'labelPatientDetails
        '
        Me.labelPatientDetails.AutoSize = True
        Me.labelPatientDetails.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPatientDetails.Location = New System.Drawing.Point(239, 21)
        Me.labelPatientDetails.Name = "labelPatientDetails"
        Me.labelPatientDetails.Size = New System.Drawing.Size(160, 30)
        Me.labelPatientDetails.TabIndex = 4
        Me.labelPatientDetails.Text = "Patient Details:"
        '
        'labelXray
        '
        Me.labelXray.AutoSize = True
        Me.labelXray.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelXray.Location = New System.Drawing.Point(579, 25)
        Me.labelXray.Name = "labelXray"
        Me.labelXray.Size = New System.Drawing.Size(77, 30)
        Me.labelXray.TabIndex = 5
        Me.labelXray.Text = "X-Ray:"
        '
        'XrayPictureBox
        '
        Me.XrayPictureBox.BackColor = System.Drawing.Color.LightGray
        Me.XrayPictureBox.Image = Global.Project.My.Resources.Resources.xray
        Me.XrayPictureBox.InitialImage = Nothing
        Me.XrayPictureBox.Location = New System.Drawing.Point(584, 69)
        Me.XrayPictureBox.Name = "XrayPictureBox"
        Me.XrayPictureBox.Size = New System.Drawing.Size(300, 401)
        Me.XrayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.XrayPictureBox.TabIndex = 6
        Me.XrayPictureBox.TabStop = False
        '
        'LabelDiagnosis
        '
        Me.LabelDiagnosis.AutoSize = True
        Me.LabelDiagnosis.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDiagnosis.Location = New System.Drawing.Point(946, 21)
        Me.LabelDiagnosis.Name = "LabelDiagnosis"
        Me.LabelDiagnosis.Size = New System.Drawing.Size(114, 30)
        Me.LabelDiagnosis.TabIndex = 7
        Me.LabelDiagnosis.Text = "Diagnosis:"
        '
        'TextBoxDiagnosis
        '
        Me.TextBoxDiagnosis.Location = New System.Drawing.Point(951, 69)
        Me.TextBoxDiagnosis.Multiline = True
        Me.TextBoxDiagnosis.Name = "TextBoxDiagnosis"
        Me.TextBoxDiagnosis.ReadOnly = True
        Me.TextBoxDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDiagnosis.Size = New System.Drawing.Size(300, 165)
        Me.TextBoxDiagnosis.TabIndex = 8
        '
        'LabelComment
        '
        Me.LabelComment.AutoSize = True
        Me.LabelComment.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComment.Location = New System.Drawing.Point(946, 256)
        Me.LabelComment.Name = "LabelComment"
        Me.LabelComment.Size = New System.Drawing.Size(137, 30)
        Me.LabelComment.TabIndex = 9
        Me.LabelComment.Text = "Prescription:"
        '
        'TextBoxPrescribe
        '
        Me.TextBoxPrescribe.Location = New System.Drawing.Point(951, 300)
        Me.TextBoxPrescribe.Multiline = True
        Me.TextBoxPrescribe.Name = "TextBoxPrescribe"
        Me.TextBoxPrescribe.Size = New System.Drawing.Size(300, 168)
        Me.TextBoxPrescribe.TabIndex = 10
        '
        'LabelAppointment
        '
        Me.LabelAppointment.AutoSize = True
        Me.LabelAppointment.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAppointment.Location = New System.Drawing.Point(21, 493)
        Me.LabelAppointment.Name = "LabelAppointment"
        Me.LabelAppointment.Size = New System.Drawing.Size(255, 30)
        Me.LabelAppointment.TabIndex = 12
        Me.LabelAppointment.Text = "Following Appointment:"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(1054, 719)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(295, 493)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 30)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Logs:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(36, 535)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(300, 535)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(951, 162)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'CollabTableAdapter
        '
        Me.CollabTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(926, 719)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DoctorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 754)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.LabelAppointment)
        Me.Controls.Add(Me.TextBoxPrescribe)
        Me.Controls.Add(Me.LabelComment)
        Me.Controls.Add(Me.TextBoxDiagnosis)
        Me.Controls.Add(Me.LabelDiagnosis)
        Me.Controls.Add(Me.XrayPictureBox)
        Me.Controls.Add(Me.labelXray)
        Me.Controls.Add(Me.labelPatientDetails)
        Me.Controls.Add(Me.patientDetailsText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.patientList)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "DoctorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoctorForm"
        CType(Me.CollabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents patientList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents patientDetailsText As TextBox
    Friend WithEvents labelPatientDetails As Label
    Friend WithEvents labelXray As Label
    Friend WithEvents XrayPictureBox As PictureBox
    Friend WithEvents LabelDiagnosis As Label
    Friend WithEvents TextBoxDiagnosis As TextBox
    Friend WithEvents LabelComment As Label
    Friend WithEvents TextBoxPrescribe As TextBox
    Friend WithEvents LabelAppointment As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents New_DatabaseDataSet As New_DatabaseDataSet
    Friend WithEvents CollabBindingSource As BindingSource
    Friend WithEvents CollabTableAdapter As New_DatabaseDataSetTableAdapters.collabTableAdapter
    Friend WithEvents Button2 As Button
End Class

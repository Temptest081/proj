<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupnewNurseDoctor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxAdminKey = New System.Windows.Forms.TextBox()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelAdminKey = New System.Windows.Forms.Label()
        Me.ComboBoxRole = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Location = New System.Drawing.Point(104, 199)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCreate.TabIndex = 0
        Me.ButtonCreate.Text = "Create"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sign Up"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(123, 93)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxID.TabIndex = 2
        '
        'TextBoxAdminKey
        '
        Me.TextBoxAdminKey.Location = New System.Drawing.Point(123, 173)
        Me.TextBoxAdminKey.Name = "TextBoxAdminKey"
        Me.TextBoxAdminKey.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxAdminKey.TabIndex = 3
        Me.TextBoxAdminKey.UseSystemPasswordChar = True
        Me.TextBoxAdminKey.Visible = False
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(123, 119)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxPass.TabIndex = 4
        Me.TextBoxPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password:"
        '
        'LabelAdminKey
        '
        Me.LabelAdminKey.AutoSize = True
        Me.LabelAdminKey.Location = New System.Drawing.Point(19, 176)
        Me.LabelAdminKey.Name = "LabelAdminKey"
        Me.LabelAdminKey.Size = New System.Drawing.Size(88, 13)
        Me.LabelAdminKey.TabIndex = 7
        Me.LabelAdminKey.Text = "Admin Password:"
        Me.LabelAdminKey.Visible = False
        '
        'ComboBoxRole
        '
        Me.ComboBoxRole.FormattingEnabled = True
        Me.ComboBoxRole.Location = New System.Drawing.Point(123, 145)
        Me.ComboBoxRole.Name = "ComboBoxRole"
        Me.ComboBoxRole.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxRole.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Role:"
        '
        'SignupnewNurseDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 242)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxRole)
        Me.Controls.Add(Me.LabelAdminKey)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.TextBoxAdminKey)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Name = "SignupnewNurseDoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignupnewNurseDoctor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCreate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxAdminKey As TextBox
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelAdminKey As Label
    Friend WithEvents ComboBoxRole As ComboBox
    Friend WithEvents Label5 As Label
End Class

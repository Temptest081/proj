<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SigninForm
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
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.labelSubtitle = New System.Windows.Forms.Label()
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.textUsername = New System.Windows.Forms.TextBox()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.buttonSignin = New System.Windows.Forms.Button()
        Me.labelMessage = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.SystemColors.Desktop
        Me.labelTitle.Location = New System.Drawing.Point(72, 18)
        Me.labelTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(432, 51)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Medical Records Portal"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelSubtitle
        '
        Me.labelSubtitle.AutoSize = True
        Me.labelSubtitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSubtitle.ForeColor = System.Drawing.SystemColors.GrayText
        Me.labelSubtitle.Location = New System.Drawing.Point(180, 80)
        Me.labelSubtitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelSubtitle.Name = "labelSubtitle"
        Me.labelSubtitle.Size = New System.Drawing.Size(216, 21)
        Me.labelSubtitle.TabIndex = 1
        Me.labelSubtitle.Text = "Please sign in to your account"
        Me.labelSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelUsername
        '
        Me.labelUsername.AutoSize = True
        Me.labelUsername.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsername.ForeColor = System.Drawing.SystemColors.GrayText
        Me.labelUsername.Location = New System.Drawing.Point(30, 20)
        Me.labelUsername.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(104, 25)
        Me.labelUsername.TabIndex = 2
        Me.labelUsername.Text = "ID Number"
        '
        'textUsername
        '
        Me.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textUsername.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textUsername.Location = New System.Drawing.Point(30, 50)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.Size = New System.Drawing.Size(340, 33)
        Me.textUsername.TabIndex = 3
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPassword.ForeColor = System.Drawing.SystemColors.GrayText
        Me.labelPassword.Location = New System.Drawing.Point(30, 95)
        Me.labelPassword.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(91, 25)
        Me.labelPassword.TabIndex = 4
        Me.labelPassword.Text = "Password"
        '
        'textPassword
        '
        Me.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.Location = New System.Drawing.Point(30, 125)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.Size = New System.Drawing.Size(340, 33)
        Me.textPassword.TabIndex = 5
        Me.textPassword.UseSystemPasswordChar = True
        '
        'buttonSignin
        '
        Me.buttonSignin.AutoSize = True
        Me.buttonSignin.BackColor = System.Drawing.Color.Black
        Me.buttonSignin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonSignin.FlatAppearance.BorderSize = 0
        Me.buttonSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSignin.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSignin.ForeColor = System.Drawing.Color.White
        Me.buttonSignin.Location = New System.Drawing.Point(30, 180)
        Me.buttonSignin.Name = "buttonSignin"
        Me.buttonSignin.Size = New System.Drawing.Size(340, 42)
        Me.buttonSignin.TabIndex = 6
        Me.buttonSignin.Text = "Sign In"
        Me.buttonSignin.UseVisualStyleBackColor = False
        '
        'labelMessage
        '
        Me.labelMessage.AutoSize = True
        Me.labelMessage.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMessage.ForeColor = System.Drawing.Color.Red
        Me.labelMessage.Location = New System.Drawing.Point(30, 230)
        Me.labelMessage.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelMessage.Name = "labelMessage"
        Me.labelMessage.Size = New System.Drawing.Size(0, 19)
        Me.labelMessage.TabIndex = 7
        Me.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(316, 242)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(54, 20)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Patient"
        '
        'panelMain
        '
        Me.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMain.Controls.Add(Me.labelUsername)
        Me.panelMain.Controls.Add(Me.textUsername)
        Me.panelMain.Controls.Add(Me.labelPassword)
        Me.panelMain.Controls.Add(Me.textPassword)
        Me.panelMain.Controls.Add(Me.buttonSignin)
        Me.panelMain.Controls.Add(Me.labelMessage)
        Me.panelMain.Controls.Add(Me.LinkLabel1)
        Me.panelMain.Location = New System.Drawing.Point(90, 120)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(400, 280)
        Me.panelMain.TabIndex = 0
        '
        'SigninForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(584, 465)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.labelSubtitle)
        Me.Controls.Add(Me.labelTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MaximizeBox = False
        Me.Name = "SigninForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Records Portal - Sign In"
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelTitle As Label
    Friend WithEvents labelSubtitle As Label
    Friend WithEvents labelUsername As Label
    Friend WithEvents textUsername As TextBox
    Friend WithEvents labelPassword As Label
    Friend WithEvents textPassword As TextBox
    Friend WithEvents buttonSignin As Button
    Friend WithEvents labelMessage As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents panelMain As Panel
End Class

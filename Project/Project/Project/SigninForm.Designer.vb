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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SigninForm))
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panelMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.SystemColors.Desktop
        Me.labelTitle.Location = New System.Drawing.Point(87, 180)
        Me.labelTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(318, 100)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Medical Records " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Portal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelSubtitle
        '
        Me.labelSubtitle.AutoSize = True
        Me.labelSubtitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSubtitle.ForeColor = System.Drawing.SystemColors.GrayText
        Me.labelSubtitle.Location = New System.Drawing.Point(101, 280)
        Me.labelSubtitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelSubtitle.Name = "labelSubtitle"
        Me.labelSubtitle.Size = New System.Drawing.Size(271, 28)
        Me.labelSubtitle.TabIndex = 1
        Me.labelSubtitle.Text = "Please sign in to your account"
        Me.labelSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelUsername
        '
        Me.labelUsername.AutoSize = True
        Me.labelUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsername.ForeColor = System.Drawing.SystemColors.GrayText
        Me.labelUsername.Location = New System.Drawing.Point(157, 340)
        Me.labelUsername.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(95, 23)
        Me.labelUsername.TabIndex = 2
        Me.labelUsername.Text = "ID Number"
        '
        'textUsername
        '
        Me.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textUsername.Location = New System.Drawing.Point(80, 14)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.Size = New System.Drawing.Size(228, 27)
        Me.textUsername.TabIndex = 3
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPassword.ForeColor = System.Drawing.SystemColors.GrayText
        Me.labelPassword.Location = New System.Drawing.Point(156, 413)
        Me.labelPassword.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(80, 23)
        Me.labelPassword.TabIndex = 4
        Me.labelPassword.Text = "Password"
        '
        'textPassword
        '
        Me.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.Location = New System.Drawing.Point(81, 13)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.Size = New System.Drawing.Size(228, 32)
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
        Me.buttonSignin.Location = New System.Drawing.Point(65, 527)
        Me.buttonSignin.Name = "buttonSignin"
        Me.buttonSignin.Size = New System.Drawing.Size(340, 51)
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
        Me.labelMessage.Size = New System.Drawing.Size(0, 23)
        Me.labelMessage.TabIndex = 7
        Me.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(335, 484)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(70, 25)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Patient"
        '
        'panelMain
        '
        Me.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelMain.BackColor = System.Drawing.SystemColors.Window
        Me.panelMain.Controls.Add(Me.PictureBox2)
        Me.panelMain.Controls.Add(Me.textUsername)
        Me.panelMain.Controls.Add(Me.labelMessage)
        Me.panelMain.Location = New System.Drawing.Point(80, 351)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(325, 55)
        Me.panelMain.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(160, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.textPassword)
        Me.Panel1.Location = New System.Drawing.Point(80, 426)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 55)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'SigninForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(485, 644)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.labelUsername)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.labelSubtitle)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.labelTitle)
        Me.Controls.Add(Me.buttonSignin)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SigninForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Records Portal - Sign In"
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
End Class

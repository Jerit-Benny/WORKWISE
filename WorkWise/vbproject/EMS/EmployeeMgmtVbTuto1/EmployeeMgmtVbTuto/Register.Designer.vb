<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.EmpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmpEdCb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PosCb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GendCb = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmpPhoneTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmpAdd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmpNameTb = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EmpUsername = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EmpPassword = New System.Windows.Forms.TextBox()
        Me.cpassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpDOB
        '
        Me.EmpDOB.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDOB.Location = New System.Drawing.Point(445, 572)
        Me.EmpDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpDOB.Name = "EmpDOB"
        Me.EmpDOB.Size = New System.Drawing.Size(265, 32)
        Me.EmpDOB.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(102, 577)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 26)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Employee DOB "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(102, 511)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 26)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Employee Education"
        '
        'EmpEdCb
        '
        Me.EmpEdCb.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEdCb.FormattingEnabled = True
        Me.EmpEdCb.Items.AddRange(New Object() {"Diploma", "UG", "PG"})
        Me.EmpEdCb.Location = New System.Drawing.Point(445, 504)
        Me.EmpEdCb.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpEdCb.Name = "EmpEdCb"
        Me.EmpEdCb.Size = New System.Drawing.Size(269, 34)
        Me.EmpEdCb.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(102, 389)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 26)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Employee Position"
        '
        'PosCb
        '
        Me.PosCb.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PosCb.FormattingEnabled = True
        Me.PosCb.Items.AddRange(New Object() {"Manager", "Security", "Cleaner", "Accountant", "IT"})
        Me.PosCb.Location = New System.Drawing.Point(445, 382)
        Me.PosCb.Margin = New System.Windows.Forms.Padding(4)
        Me.PosCb.Name = "PosCb"
        Me.PosCb.Size = New System.Drawing.Size(269, 34)
        Me.PosCb.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(102, 322)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 26)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Employee Gender"
        '
        'GendCb
        '
        Me.GendCb.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GendCb.FormattingEnabled = True
        Me.GendCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GendCb.Location = New System.Drawing.Point(445, 319)
        Me.GendCb.Margin = New System.Windows.Forms.Padding(4)
        Me.GendCb.Name = "GendCb"
        Me.GendCb.Size = New System.Drawing.Size(269, 34)
        Me.GendCb.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(102, 448)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 26)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Employee Phone"
        '
        'EmpPhoneTb
        '
        Me.EmpPhoneTb.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPhoneTb.Location = New System.Drawing.Point(445, 448)
        Me.EmpPhoneTb.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpPhoneTb.Name = "EmpPhoneTb"
        Me.EmpPhoneTb.Size = New System.Drawing.Size(268, 32)
        Me.EmpPhoneTb.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(102, 255)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 26)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Employee Address"
        '
        'EmpAdd
        '
        Me.EmpAdd.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAdd.Location = New System.Drawing.Point(445, 252)
        Me.EmpAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpAdd.Name = "EmpAdd"
        Me.EmpAdd.Size = New System.Drawing.Size(268, 32)
        Me.EmpAdd.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(102, 190)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Employee Name"
        '
        'EmpNameTb
        '
        Me.EmpNameTb.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpNameTb.Location = New System.Drawing.Point(445, 187)
        Me.EmpNameTb.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpNameTb.Name = "EmpNameTb"
        Me.EmpNameTb.Size = New System.Drawing.Size(268, 32)
        Me.EmpNameTb.TabIndex = 24
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Home"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.SpringGreen
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton24.Location = New System.Drawing.Point(731, 671)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(152, 50)
        Me.BunifuThinButton24.TabIndex = 39
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Add"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SpringGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.Location = New System.Drawing.Point(292, 671)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(152, 50)
        Me.BunifuThinButton21.TabIndex = 38
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Reset"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SpringGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton22.Location = New System.Drawing.Point(512, 671)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(152, 50)
        Me.BunifuThinButton22.TabIndex = 40
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(827, 187)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 26)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(830, 315)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 26)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Password"
        '
        'EmpUsername
        '
        Me.EmpUsername.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpUsername.Location = New System.Drawing.Point(828, 235)
        Me.EmpUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpUsername.Name = "EmpUsername"
        Me.EmpUsername.Size = New System.Drawing.Size(268, 32)
        Me.EmpUsername.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(830, 431)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 26)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Confirm Password"
        '
        'EmpPassword
        '
        Me.EmpPassword.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPassword.Location = New System.Drawing.Point(828, 361)
        Me.EmpPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpPassword.Name = "EmpPassword"
        Me.EmpPassword.Size = New System.Drawing.Size(268, 32)
        Me.EmpPassword.TabIndex = 46
        '
        'cpassword
        '
        Me.cpassword.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpassword.Location = New System.Drawing.Point(828, 484)
        Me.cpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.cpassword.Name = "cpassword"
        Me.cpassword.Size = New System.Drawing.Size(268, 32)
        Me.cpassword.TabIndex = 47
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EmployeeMgmtVbTuto.My.Resources.Resources.register
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(38, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 93)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(158, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 35)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "REGISTER"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EmployeeMgmtVbTuto.My.Resources.Resources.ems2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1197, 816)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cpassword)
        Me.Controls.Add(Me.EmpPassword)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.EmpUsername)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.BunifuThinButton24)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.EmpDOB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.EmpEdCb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PosCb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GendCb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EmpPhoneTb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmpAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmpNameTb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmpDOB As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EmpEdCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PosCb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GendCb As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmpPhoneTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EmpAdd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EmpNameTb As TextBox
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents EmpUsername As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents EmpPassword As TextBox
    Friend WithEvents cpassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
End Class

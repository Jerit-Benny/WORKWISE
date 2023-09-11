<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UidTb = New System.Windows.Forms.TextBox()
        Me.PassTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GradientTileButton1 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2GradientTileButton3 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2GradientTileButton4 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(185, 209)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(52, 153)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'UidTb
        '
        Me.UidTb.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UidTb.ForeColor = System.Drawing.Color.Black
        Me.UidTb.Location = New System.Drawing.Point(307, 150)
        Me.UidTb.Margin = New System.Windows.Forms.Padding(4)
        Me.UidTb.Name = "UidTb"
        Me.UidTb.Size = New System.Drawing.Size(229, 32)
        Me.UidTb.TabIndex = 5
        Me.UidTb.Text = "ad"
        '
        'PassTb
        '
        Me.PassTb.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTb.ForeColor = System.Drawing.Color.Black
        Me.PassTb.Location = New System.Drawing.Point(307, 206)
        Me.PassTb.Margin = New System.Windows.Forms.Padding(4)
        Me.PassTb.Name = "PassTb"
        Me.PassTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTb.Size = New System.Drawing.Size(229, 32)
        Me.PassTb.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(169, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Management System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(664, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(185, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User Id"
        '
        'Guna2GradientTileButton1
        '
        Me.Guna2GradientTileButton1.Animated = True
        Me.Guna2GradientTileButton1.AutoRoundedCorners = True
        Me.Guna2GradientTileButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientTileButton1.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientTileButton1.BorderRadius = 23
        Me.Guna2GradientTileButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GradientTileButton1.BorderThickness = 1
        Me.Guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientTileButton1.FillColor = System.Drawing.Color.PaleTurquoise
        Me.Guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Aqua
        Me.Guna2GradientTileButton1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientTileButton1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2GradientTileButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientTileButton1.IndicateFocus = True
        Me.Guna2GradientTileButton1.Location = New System.Drawing.Point(435, 305)
        Me.Guna2GradientTileButton1.Name = "Guna2GradientTileButton1"
        Me.Guna2GradientTileButton1.Size = New System.Drawing.Size(163, 49)
        Me.Guna2GradientTileButton1.TabIndex = 17
        Me.Guna2GradientTileButton1.Text = "Admin Login"
        Me.Guna2GradientTileButton1.UseTransparentBackground = True
        '
        'Guna2GradientTileButton3
        '
        Me.Guna2GradientTileButton3.Animated = True
        Me.Guna2GradientTileButton3.AutoRoundedCorners = True
        Me.Guna2GradientTileButton3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientTileButton3.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientTileButton3.BorderRadius = 23
        Me.Guna2GradientTileButton3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GradientTileButton3.BorderThickness = 1
        Me.Guna2GradientTileButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientTileButton3.FillColor = System.Drawing.Color.PaleTurquoise
        Me.Guna2GradientTileButton3.FillColor2 = System.Drawing.Color.Aqua
        Me.Guna2GradientTileButton3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientTileButton3.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2GradientTileButton3.IndicateFocus = True
        Me.Guna2GradientTileButton3.Location = New System.Drawing.Point(284, 305)
        Me.Guna2GradientTileButton3.Name = "Guna2GradientTileButton3"
        Me.Guna2GradientTileButton3.Size = New System.Drawing.Size(122, 49)
        Me.Guna2GradientTileButton3.TabIndex = 19
        Me.Guna2GradientTileButton3.Text = "Reset"
        Me.Guna2GradientTileButton3.UseTransparentBackground = True
        '
        'Guna2GradientTileButton4
        '
        Me.Guna2GradientTileButton4.Animated = True
        Me.Guna2GradientTileButton4.AutoRoundedCorners = True
        Me.Guna2GradientTileButton4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientTileButton4.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientTileButton4.BorderRadius = 23
        Me.Guna2GradientTileButton4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GradientTileButton4.BorderThickness = 1
        Me.Guna2GradientTileButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientTileButton4.FillColor = System.Drawing.Color.PaleTurquoise
        Me.Guna2GradientTileButton4.FillColor2 = System.Drawing.Color.Aqua
        Me.Guna2GradientTileButton4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientTileButton4.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2GradientTileButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientTileButton4.IndicateFocus = True
        Me.Guna2GradientTileButton4.Location = New System.Drawing.Point(85, 305)
        Me.Guna2GradientTileButton4.Name = "Guna2GradientTileButton4"
        Me.Guna2GradientTileButton4.Size = New System.Drawing.Size(163, 49)
        Me.Guna2GradientTileButton4.TabIndex = 20
        Me.Guna2GradientTileButton4.Text = "User Login"
        Me.Guna2GradientTileButton4.UseTransparentBackground = True
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(289, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 33)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "WORKWISE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.EmployeeMgmtVbTuto.My.Resources.Resources.ems3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 416)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2GradientTileButton4)
        Me.Controls.Add(Me.Guna2GradientTileButton3)
        Me.Controls.Add(Me.Guna2GradientTileButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PassTb)
        Me.Controls.Add(Me.UidTb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UidTb As TextBox
    Friend WithEvents PassTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2GradientTileButton1 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2GradientTileButton3 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2GradientTileButton4 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Label5 As Label
End Class

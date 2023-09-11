<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmpEdulbl = New System.Windows.Forms.Label()
        Me.EmpPosLbl = New System.Windows.Forms.Label()
        Me.EmpAddlbl = New System.Windows.Forms.Label()
        Me.EmpDobLbl = New System.Windows.Forms.Label()
        Me.EmpPhone = New System.Windows.Forms.Label()
        Me.EmpGender = New System.Windows.Forms.Label()
        Me.EmpNamelbl = New System.Windows.Forms.Label()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(94, 53)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(286, 33)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Employee Details"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BackgroundImage = Global.EmployeeMgmtVbTuto.My.Resources.Resources.ems2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.EmpEdulbl)
        Me.Panel1.Controls.Add(Me.EmpPosLbl)
        Me.Panel1.Controls.Add(Me.EmpAddlbl)
        Me.Panel1.Controls.Add(Me.EmpDobLbl)
        Me.Panel1.Controls.Add(Me.EmpPhone)
        Me.Panel1.Controls.Add(Me.EmpGender)
        Me.Panel1.Controls.Add(Me.EmpNamelbl)
        Me.Panel1.Controls.Add(Me.BunifuThinButton24)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 94)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1465, 663)
        Me.Panel1.TabIndex = 1
        '
        'EmpEdulbl
        '
        Me.EmpEdulbl.AutoSize = True
        Me.EmpEdulbl.BackColor = System.Drawing.Color.Transparent
        Me.EmpEdulbl.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEdulbl.ForeColor = System.Drawing.Color.White
        Me.EmpEdulbl.Location = New System.Drawing.Point(1083, 293)
        Me.EmpEdulbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpEdulbl.Name = "EmpEdulbl"
        Me.EmpEdulbl.Size = New System.Drawing.Size(203, 27)
        Me.EmpEdulbl.TabIndex = 37
        Me.EmpEdulbl.Text = "Employee Education"
        Me.EmpEdulbl.Visible = False
        '
        'EmpPosLbl
        '
        Me.EmpPosLbl.AutoSize = True
        Me.EmpPosLbl.BackColor = System.Drawing.Color.Transparent
        Me.EmpPosLbl.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPosLbl.ForeColor = System.Drawing.Color.White
        Me.EmpPosLbl.Location = New System.Drawing.Point(1083, 221)
        Me.EmpPosLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpPosLbl.Name = "EmpPosLbl"
        Me.EmpPosLbl.Size = New System.Drawing.Size(187, 27)
        Me.EmpPosLbl.TabIndex = 36
        Me.EmpPosLbl.Text = "Employee Position"
        Me.EmpPosLbl.Visible = False
        '
        'EmpAddlbl
        '
        Me.EmpAddlbl.AutoSize = True
        Me.EmpAddlbl.BackColor = System.Drawing.Color.Transparent
        Me.EmpAddlbl.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAddlbl.ForeColor = System.Drawing.Color.White
        Me.EmpAddlbl.Location = New System.Drawing.Point(1083, 150)
        Me.EmpAddlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpAddlbl.Name = "EmpAddlbl"
        Me.EmpAddlbl.Size = New System.Drawing.Size(189, 27)
        Me.EmpAddlbl.TabIndex = 35
        Me.EmpAddlbl.Text = "Employee Address"
        Me.EmpAddlbl.Visible = False
        '
        'EmpDobLbl
        '
        Me.EmpDobLbl.AutoSize = True
        Me.EmpDobLbl.BackColor = System.Drawing.Color.Transparent
        Me.EmpDobLbl.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDobLbl.ForeColor = System.Drawing.Color.White
        Me.EmpDobLbl.Location = New System.Drawing.Point(704, 401)
        Me.EmpDobLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpDobLbl.Name = "EmpDobLbl"
        Me.EmpDobLbl.Size = New System.Drawing.Size(161, 27)
        Me.EmpDobLbl.TabIndex = 34
        Me.EmpDobLbl.Text = "Employee DOB "
        Me.EmpDobLbl.Visible = False
        '
        'EmpPhone
        '
        Me.EmpPhone.AutoSize = True
        Me.EmpPhone.BackColor = System.Drawing.Color.Transparent
        Me.EmpPhone.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPhone.ForeColor = System.Drawing.Color.White
        Me.EmpPhone.Location = New System.Drawing.Point(346, 293)
        Me.EmpPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpPhone.Name = "EmpPhone"
        Me.EmpPhone.Size = New System.Drawing.Size(170, 27)
        Me.EmpPhone.TabIndex = 33
        Me.EmpPhone.Text = "Employee Phone"
        Me.EmpPhone.Visible = False
        '
        'EmpGender
        '
        Me.EmpGender.AutoSize = True
        Me.EmpGender.BackColor = System.Drawing.Color.Transparent
        Me.EmpGender.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpGender.ForeColor = System.Drawing.Color.White
        Me.EmpGender.Location = New System.Drawing.Point(346, 221)
        Me.EmpGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpGender.Name = "EmpGender"
        Me.EmpGender.Size = New System.Drawing.Size(180, 27)
        Me.EmpGender.TabIndex = 32
        Me.EmpGender.Text = "Employee Gender"
        Me.EmpGender.Visible = False
        '
        'EmpNamelbl
        '
        Me.EmpNamelbl.AutoSize = True
        Me.EmpNamelbl.BackColor = System.Drawing.Color.Transparent
        Me.EmpNamelbl.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpNamelbl.ForeColor = System.Drawing.Color.White
        Me.EmpNamelbl.Location = New System.Drawing.Point(346, 150)
        Me.EmpNamelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpNamelbl.Name = "EmpNamelbl"
        Me.EmpNamelbl.Size = New System.Drawing.Size(168, 27)
        Me.EmpNamelbl.TabIndex = 31
        Me.EmpNamelbl.Text = "Employee Name"
        Me.EmpNamelbl.Visible = False
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.BackColor = System.Drawing.SystemColors.Window
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
        Me.BunifuThinButton24.Location = New System.Drawing.Point(834, 574)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(152, 50)
        Me.BunifuThinButton24.TabIndex = 27
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Window
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Print"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SpringGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.Location = New System.Drawing.Point(405, 574)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(152, 50)
        Me.BunifuThinButton21.TabIndex = 24
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(460, 401)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 27)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Employee DOB "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(820, 293)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 27)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Employee Education"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(820, 221)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 27)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Employee Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(95, 221)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 27)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Employee Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(95, 293)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 27)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Employee Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(820, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 27)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Employee Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(95, 150)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 27)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Employee Name"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Bernard MT Condensed", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(418, 53)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(316, 33)
        Me.Guna2HtmlLabel1.TabIndex = 38
        Me.Guna2HtmlLabel1.Text = "EMPLOYEE ID"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1465, 801)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EmpEdulbl As Label
    Friend WithEvents EmpPosLbl As Label
    Friend WithEvents EmpAddlbl As Label
    Friend WithEvents EmpDobLbl As Label
    Friend WithEvents EmpPhone As Label
    Friend WithEvents EmpGender As Label
    Friend WithEvents EmpNamelbl As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class

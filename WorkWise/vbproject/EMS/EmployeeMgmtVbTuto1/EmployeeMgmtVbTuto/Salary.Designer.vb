<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salary))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SalaryTb = New System.Windows.Forms.RichTextBox()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.WorkedTb = New System.Windows.Forms.TextBox()
        Me.EmpPosLbl = New System.Windows.Forms.Label()
        Me.EmpNameLbl = New System.Windows.Forms.Label()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.EmpIdTb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.EmployeeMgmtVbTuto.My.Resources.Resources.ems2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.SalaryTb)
        Me.Panel1.Controls.Add(Me.BunifuThinButton23)
        Me.Panel1.Controls.Add(Me.WorkedTb)
        Me.Panel1.Controls.Add(Me.EmpPosLbl)
        Me.Panel1.Controls.Add(Me.EmpNameLbl)
        Me.Panel1.Controls.Add(Me.BunifuThinButton22)
        Me.Panel1.Controls.Add(Me.EmpIdTb)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.BunifuThinButton24)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 95)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1465, 663)
        Me.Panel1.TabIndex = 2
        '
        'SalaryTb
        '
        Me.SalaryTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaryTb.Location = New System.Drawing.Point(530, 105)
        Me.SalaryTb.Margin = New System.Windows.Forms.Padding(4)
        Me.SalaryTb.Name = "SalaryTb"
        Me.SalaryTb.Size = New System.Drawing.Size(680, 426)
        Me.SalaryTb.TabIndex = 40
        Me.SalaryTb.Text = ""
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Print"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SpringGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton23.Location = New System.Drawing.Point(812, 576)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(152, 50)
        Me.BunifuThinButton23.TabIndex = 39
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WorkedTb
        '
        Me.WorkedTb.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkedTb.Location = New System.Drawing.Point(36, 400)
        Me.WorkedTb.Margin = New System.Windows.Forms.Padding(4)
        Me.WorkedTb.Name = "WorkedTb"
        Me.WorkedTb.Size = New System.Drawing.Size(217, 32)
        Me.WorkedTb.TabIndex = 38
        '
        'EmpPosLbl
        '
        Me.EmpPosLbl.AutoSize = True
        Me.EmpPosLbl.BackColor = System.Drawing.Color.Transparent
        Me.EmpPosLbl.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPosLbl.ForeColor = System.Drawing.Color.White
        Me.EmpPosLbl.Location = New System.Drawing.Point(41, 310)
        Me.EmpPosLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpPosLbl.Name = "EmpPosLbl"
        Me.EmpPosLbl.Size = New System.Drawing.Size(0, 26)
        Me.EmpPosLbl.TabIndex = 36
        '
        'EmpNameLbl
        '
        Me.EmpNameLbl.AutoSize = True
        Me.EmpNameLbl.BackColor = System.Drawing.Color.Transparent
        Me.EmpNameLbl.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpNameLbl.ForeColor = System.Drawing.Color.White
        Me.EmpNameLbl.Location = New System.Drawing.Point(41, 212)
        Me.EmpNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpNameLbl.Name = "EmpNameLbl"
        Me.EmpNameLbl.Size = New System.Drawing.Size(0, 26)
        Me.EmpNameLbl.TabIndex = 31
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Fetch Data"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SpringGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton22.Location = New System.Drawing.Point(299, 105)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(124, 32)
        Me.BunifuThinButton22.TabIndex = 30
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpIdTb
        '
        Me.EmpIdTb.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpIdTb.Location = New System.Drawing.Point(36, 105)
        Me.EmpIdTb.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpIdTb.Name = "EmpIdTb"
        Me.EmpIdTb.Size = New System.Drawing.Size(217, 32)
        Me.EmpIdTb.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(41, 58)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 26)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Employee Id"
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.White
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
        Me.BunifuThinButton24.Location = New System.Drawing.Point(19, 481)
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
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "View"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SpringGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.Location = New System.Drawing.Point(271, 481)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(152, 50)
        Me.BunifuThinButton21.TabIndex = 24
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(41, 261)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 26)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Employee Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(41, 352)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Worked Days"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(41, 162)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Employee Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(99, 48)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 33)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Salary"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1423, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 31)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "X"
        '
        'Salary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1465, 801)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Salary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmpPosLbl As Label
    Friend WithEvents EmpNameLbl As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents EmpIdTb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SalaryTb As RichTextBox
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents WorkedTb As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label10 As Label
End Class

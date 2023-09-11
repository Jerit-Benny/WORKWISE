<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(96, 46)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 33)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Manage Employee"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1416, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 31)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "X"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.EmployeeMgmtVbTuto.My.Resources.Resources.ems2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.EmployeeDGV)
        Me.Panel1.Controls.Add(Me.BunifuThinButton24)
        Me.Panel1.Controls.Add(Me.BunifuThinButton23)
        Me.Panel1.Controls.Add(Me.BunifuThinButton22)
        Me.Panel1.Controls.Add(Me.EmpDOB)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.EmpEdCb)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PosCb)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GendCb)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.EmpPhoneTb)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.EmpAdd)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.EmpNameTb)
        Me.Panel1.Location = New System.Drawing.Point(3, 105)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1465, 663)
        Me.Panel1.TabIndex = 0
        '
        'EmployeeDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.EmployeeDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeDGV.BackgroundColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeeDGV.ColumnHeadersHeight = 25
        Me.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeeDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeeDGV.Location = New System.Drawing.Point(610, 33)
        Me.EmployeeDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.RowHeadersVisible = False
        Me.EmployeeDGV.RowHeadersWidth = 51
        Me.EmployeeDGV.Size = New System.Drawing.Size(815, 554)
        Me.EmployeeDGV.TabIndex = 28
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.EmployeeDGV.ThemeStyle.BackColor = System.Drawing.Color.LightGray
        Me.EmployeeDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.EmployeeDGV.ThemeStyle.HeaderStyle.Height = 25
        Me.EmployeeDGV.ThemeStyle.ReadOnly = False
        Me.EmployeeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.EmployeeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EmployeeDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.EmployeeDGV.ThemeStyle.RowsStyle.Height = 22
        Me.EmployeeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson
        Me.EmployeeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        Me.BunifuThinButton24.Location = New System.Drawing.Point(14, 537)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(152, 50)
        Me.BunifuThinButton24.TabIndex = 27
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BunifuThinButton23.ButtonText = "Delete"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SpringGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton23.Location = New System.Drawing.Point(352, 537)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(152, 50)
        Me.BunifuThinButton23.TabIndex = 26
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BunifuThinButton22.ButtonText = "Edit"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SpringGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton22.Location = New System.Drawing.Point(187, 537)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(152, 50)
        Me.BunifuThinButton22.TabIndex = 25
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpDOB
        '
        Me.EmpDOB.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDOB.Location = New System.Drawing.Point(175, 428)
        Me.EmpDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpDOB.Name = "EmpDOB"
        Me.EmpDOB.Size = New System.Drawing.Size(265, 32)
        Me.EmpDOB.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(243, 398)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 26)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Employee DOB "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(323, 285)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 26)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Employee Education"
        '
        'EmpEdCb
        '
        Me.EmpEdCb.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEdCb.FormattingEnabled = True
        Me.EmpEdCb.Items.AddRange(New Object() {"Diploma", "UG", "PG"})
        Me.EmpEdCb.Location = New System.Drawing.Point(328, 324)
        Me.EmpEdCb.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpEdCb.Name = "EmpEdCb"
        Me.EmpEdCb.Size = New System.Drawing.Size(269, 35)
        Me.EmpEdCb.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(323, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 26)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Employee Position"
        '
        'PosCb
        '
        Me.PosCb.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PosCb.FormattingEnabled = True
        Me.PosCb.Items.AddRange(New Object() {"Manager", "Security", "Cleaner", "Accountant", "IT"})
        Me.PosCb.Location = New System.Drawing.Point(328, 218)
        Me.PosCb.Margin = New System.Windows.Forms.Padding(4)
        Me.PosCb.Name = "PosCb"
        Me.PosCb.Size = New System.Drawing.Size(269, 35)
        Me.PosCb.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 26)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Employee Gender"
        '
        'GendCb
        '
        Me.GendCb.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GendCb.FormattingEnabled = True
        Me.GendCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GendCb.Location = New System.Drawing.Point(21, 218)
        Me.GendCb.Margin = New System.Windows.Forms.Padding(4)
        Me.GendCb.Name = "GendCb"
        Me.GendCb.Size = New System.Drawing.Size(269, 35)
        Me.GendCb.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 285)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Employee Phone"
        '
        'EmpPhoneTb
        '
        Me.EmpPhoneTb.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPhoneTb.Location = New System.Drawing.Point(22, 327)
        Me.EmpPhoneTb.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpPhoneTb.Name = "EmpPhoneTb"
        Me.EmpPhoneTb.Size = New System.Drawing.Size(268, 32)
        Me.EmpPhoneTb.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(323, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Employee Address"
        '
        'EmpAdd
        '
        Me.EmpAdd.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAdd.Location = New System.Drawing.Point(328, 117)
        Me.EmpAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpAdd.Name = "EmpAdd"
        Me.EmpAdd.Size = New System.Drawing.Size(268, 32)
        Me.EmpAdd.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Employee Name"
        '
        'EmpNameTb
        '
        Me.EmpNameTb.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpNameTb.Location = New System.Drawing.Point(21, 117)
        Me.EmpNameTb.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpNameTb.Name = "EmpNameTb"
        Me.EmpNameTb.Size = New System.Drawing.Size(268, 32)
        Me.EmpNameTb.TabIndex = 6
        '
        'Employee
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
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
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
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents EmployeeDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label10 As Label
End Class

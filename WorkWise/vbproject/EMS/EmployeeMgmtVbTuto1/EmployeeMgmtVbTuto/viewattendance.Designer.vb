<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewattendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewattendance))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SalaryTb = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateFrom = New System.Windows.Forms.DateTimePicker()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMP ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(44, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(44, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To Date"
        '
        'SalaryTb
        '
        Me.SalaryTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaryTb.Location = New System.Drawing.Point(375, 104)
        Me.SalaryTb.Margin = New System.Windows.Forms.Padding(4)
        Me.SalaryTb.Name = "SalaryTb"
        Me.SalaryTb.Size = New System.Drawing.Size(400, 265)
        Me.SalaryTb.TabIndex = 41
        Me.SalaryTb.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(300, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 33)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "LEAVE DETAILS"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(210, 367)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(105, 31)
        Me.BunifuThinButton21.TabIndex = 43
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(206, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 24)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "EmpID"
        '
        'DateFrom
        '
        Me.DateFrom.Location = New System.Drawing.Point(163, 203)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(166, 22)
        Me.DateFrom.TabIndex = 45
        '
        'DateTo
        '
        Me.DateTo.Location = New System.Drawing.Point(163, 280)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(166, 22)
        Me.DateTo.TabIndex = 46
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
        Me.BunifuThinButton24.Location = New System.Drawing.Point(48, 367)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(105, 31)
        Me.BunifuThinButton24.TabIndex = 47
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'viewattendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EmployeeMgmtVbTuto.My.Resources.Resources.ems2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BunifuThinButton24)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.DateFrom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SalaryTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "viewattendance"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SalaryTb As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label5 As Label
    Friend WithEvents DateFrom As DateTimePicker
    Friend WithEvents DateTo As DateTimePicker
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
End Class

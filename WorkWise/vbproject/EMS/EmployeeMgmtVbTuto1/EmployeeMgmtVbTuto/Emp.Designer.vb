<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EmployeeDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.EmployeeDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeDGV.BackgroundColor = System.Drawing.Color.Gray
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
        Me.EmployeeDGV.Location = New System.Drawing.Point(39, 29)
        Me.EmployeeDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.RowHeadersVisible = False
        Me.EmployeeDGV.RowHeadersWidth = 51
        Me.EmployeeDGV.Size = New System.Drawing.Size(1201, 615)
        Me.EmployeeDGV.TabIndex = 29
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.EmployeeDGV.ThemeStyle.BackColor = System.Drawing.Color.Gray
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SpringGreen
        Me.Button1.Location = New System.Drawing.Point(602, 676)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 44)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Emp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EmployeeMgmtVbTuto.My.Resources.Resources.ems2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1271, 782)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EmployeeDGV)
        Me.Name = "Emp"
        Me.Text = "Emp"
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmployeeDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Button1 As Button
End Class

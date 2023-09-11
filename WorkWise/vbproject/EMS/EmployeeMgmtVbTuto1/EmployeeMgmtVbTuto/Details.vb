Imports System.Data.SqlClient
Imports System.Reflection

Public Class Details

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jisto\Desktop\New folder\back3\vbproject\EMS\EmployeeMgmtVbTuto1\EmployeVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empId As String = My.Settings.EmpID
        Guna2HtmlLabel1.Text = empId
        If empId IsNot Nothing Then
            FetchEmployeeData()
        Else
            MsgBox("UNNABLE TO FETCH USER ID")
        End If

    End Sub


    Private Sub FetchEmployeeData()
        Dim empId As String = My.Settings.EmpID
        Con.Open()
        Dim Query = "select * from EmployeeTbl where EmpId=" & empId & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        Dim dt As DataTable
        dt = New DataTable
        Dim sda As SqlDataAdapter
        sda = New SqlDataAdapter(cmd)
        sda.Fill(dt)
        For Each dr As DataRow In dt.Rows
            EmpNamelbl.Text = dr(1).ToString()
            EmpAddlbl.Text = dr(2).ToString()
            EmpPosLbl.Text = dr(3).ToString()
            EmpDobLbl.Text = dr(4).ToString()
            EmpPhone.Text = dr(5).ToString()
            EmpEdulbl.Text = dr(6).ToString()
            EmpGender.Text = dr(7).ToString()
            EmpNamelbl.Visible = True
            EmpPhone.Visible = True
            EmpAddlbl.Visible = True
            EmpDobLbl.Visible = True
            EmpEdulbl.Visible = True
            EmpGender.Visible = True
            EmpPosLbl.Visible = True

        Next
        Con.Close()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Me.Hide()
        Dim Main = MainForm
        Main.Show()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("WORK WISE", New Font("Century gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("***EMPLOYEE DETAILS***", New Font("Arial", 20), Brushes.Crimson, 250, 100)
        e.Graphics.DrawString("Name:   " + EmpNamelbl.Text + vbTab + "Address:   " + EmpAddlbl.Text, New Font("Century Gothic", 22), Brushes.Black, 140, 205)
        e.Graphics.DrawString("Position:   " + EmpPosLbl.Text + vbTab + "Education:   " + EmpEdulbl.Text, New Font("Century Gothic", 22), Brushes.Black, 140, 260)
        e.Graphics.DrawString("Phone:   " + EmpPhone.Text + vbTab + "Gender:   " + EmpGender.Text, New Font("Century Gothic", 22), Brushes.Black, 140, 325)
        e.Graphics.DrawString("DOB:   " + EmpDobLbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 200, 385)
        e.Graphics.DrawString("=========EMPLOYEE MANAGEMENT SYSTEM============", New Font("Century gothic", 15), Brushes.DarkGreen, 150, 550)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub EmpNamelbl_Click(sender As Object, e As EventArgs) Handles EmpNamelbl.Click

    End Sub

    Private Sub EmpIdTb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)

    End Sub
End Class
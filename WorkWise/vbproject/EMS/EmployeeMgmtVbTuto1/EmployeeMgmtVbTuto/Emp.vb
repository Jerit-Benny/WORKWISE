Imports System.Data.SqlClient
Public Class Emp
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\jisto\Desktop\New folder\back3\vbproject\EMS\EmployeeMgmtVbTuto\EmployeeMgmtVbTuto\EmployeeVbDb.mdf';Integrated Security=True;Connect Timeout=30")

    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from EmployeeTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        EmployeeDGV.DataSource = ds.Tables(0)
        EmployeeDGV.Columns(9).Visible = False
        Con.Close()
    End Sub
    Private Sub Emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim Emp = New MainForm
        Emp.Show()
    End Sub
End Class
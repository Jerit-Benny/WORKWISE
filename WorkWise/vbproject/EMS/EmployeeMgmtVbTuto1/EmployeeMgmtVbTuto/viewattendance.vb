﻿Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class viewattendance
    Private Sub viewattendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empId As String = My.Settings.EmpID
        Label5.Text = empId
    End Sub

    Private Sub viewattendance_Load()
        Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jisto\Desktop\New folder\back3\vbproject\EMS\EmployeeMgmtVbTuto1\EmployeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
        Con.Open()
        Dim cmd As New SqlCommand("", Con)
        Dim txtName As String
        Dim empId As String = My.Settings.EmpID
        If empId IsNot Nothing Then
            cmd.CommandText = "SELECT sum(noofDays) FROM leave  WHERE Emp_Id ='" & empId & "' and START between '" & DateFrom.Value & "' and '" & DateTo.Value & "' "
            txtName = IIf(IsDBNull(cmd.ExecuteScalar), "", cmd.ExecuteScalar)
            If txtName <> "" Then
                SalaryTb.Text = ""
                SalaryTb.Text = txtName
            Else
                MsgBox("No Record Found!", MsgBoxStyle.Information, "INFO.")
            End If
        End If
        Con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles SalaryTb.TextChanged

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        viewattendance_Load()
    End Sub

    Private Sub SalaryTb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DateFrom_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateFrom.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTo.ValueChanged

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub
End Class
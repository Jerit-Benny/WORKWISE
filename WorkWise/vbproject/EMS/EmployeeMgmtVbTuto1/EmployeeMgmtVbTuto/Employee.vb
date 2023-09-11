Imports System.Data.SqlClient
Public Class Employee
    Dim Com As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jisto\Desktop\New folder\back3\vbproject\EMS\EmployeeMgmtVbTuto1\EmployeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Private Sub Populate()
        Com.Open()
        Dim sql = "select * from EmployeeTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Com)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        EmployeeDGV.DataSource = ds.Tables(0)
        Com.Close()
    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Com.Open()
        Dim Query As String
        Query = "insert into EmployeeTbl values('" & EmpNameTb.Text & "','" & EmpAdd.Text & "', '" & PosCb.SelectedItem.ToString() & "','" & EmpDOB.Value & "','" & EmpPhoneTb.Text & "', '" & EmpEdCb.SelectedItem.ToString() & "','" & GendCb.SelectedItem.ToString() & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Com)
        cmd.ExecuteNonQuery()
        MsgBox("Employee Added")
        Com.Close()
        Populate()
    End Sub
    Dim key = 0
    Private Sub Clear()
        EmpNameTb.Clear()
        PosCb.Text = ""
        GendCb.Text = ""
        EmpAdd.Text = ""
        key = 0
        EmpEdCb.Text = ""
        EmpPhoneTb.Text = ""

    End Sub
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click

        If key = 0 Then
            MsgBox("Select The Employee To Delete")
        Else
            Try
                Com.Open()
                Dim Query As String
                Query = "Delete from EmployeeTbl where EmpId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Com)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Deleted Successfully")
                Com.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If



    End Sub

    Private Sub EmployeeDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeDGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeeDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        EmpNameTb.Text = row.Cells(1).Value.ToString()
        EmpAdd.Text = row.Cells(2).Value.ToString()
        PosCb.Text = row.Cells(3).Value.ToString()
        EmpDOB.Value = row.Cells(4).Value.ToString()
        EmpPhoneTb.Text = row.Cells(5).Value.ToString()
        EmpEdCb.Text = row.Cells(6).Value.ToString()
        GendCb.Text = row.Cells(7).Value.ToString()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If EmpNameTb.Text = "" Or EmpPhoneTb.Text = "" Or EmpAdd.Text = "" Then
            MsgBox("Missing Information")
        Else
            Com.Open()
            Dim Query As String
            Query = "Update EmployeeTbl set EmpName='" & EmpNameTb.Text & "', EmpAdd='" & EmpAdd.Text & "', EmpPos='" & PosCb.SelectedItem.ToString() & "',EmpDob='" & EmpDOB.Value & "',EmpPhone='" & EmpPhoneTb.Text & "',EmpEdu='" & EmpEdCb.SelectedItem.ToString() & "',EmpGend='" & GendCb.SelectedItem.ToString() & "' where EmpId=" & key & ""
            Dim cmd As New SqlCommand(Query, Com)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Updated")
            Com.Close()
            Populate()
            Clear()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Me.Hide()
        Dim Main = adminvb
        Main.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class
Imports System.Data.SqlClient
Imports System.Web
Imports System.Web.SessionState

Public Class Login
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jisto\Desktop\New folder\back3\vbproject\EMS\EmployeeMgmtVbTuto1\EmployeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim Query As String
    Dim cmd As SqlCommand


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Register.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Con.Open()
        cmd = New SqlCommand(Query, Con)
        Dim str As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jisto\Desktop\New folder\back3\vbproject\EMS\EmployeeMgmtVbTuto1\EmployeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
        Dim sql As String = "select count(*) from EmployeeTbl where EmpUsername=@EmpUsername and EmpPassword=@EmpPassword"
        Using Con As New SqlConnection()
            Using cmd As New SqlCommand(sql, Con)
                Con.Open()
                cmd.Parameters.AddWithValue("@EmpUsername", UidTb.Text)
                cmd.Parameters.AddWithValue("@EmpPassword", PassTb.Text)
                Dim value = cmd.ExecuteScalar()
                If value > 0 Then
                    MessageBox.Show("Login sucessfully!")
                    MainForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Incorrect Email or Password")
                End If
            End Using
        End Using

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        UidTb.Clear()
        PassTb.Clear()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        If UidTb.Text = "admin" And PassTb.Text = "admin" Then
            adminvb.Show()
        End If
    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        If UidTb.Text = "admin" And PassTb.Text = "admin" Then
            adminvb.Show()
        End If
    End Sub


    Private Sub Guna2GradientTileButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton4.Click
        Dim str As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jisto\Desktop\New folder\back3\vbproject\EMS\EmployeeMgmtVbTuto1\EmployeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
        Dim sql As String = ("select EmpId from EmployeeTbl where EmpUsername=@EmpUsername and EmpPassword=@EmpPassword")
        Using Con As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Con)
                Con.Open()
                cmd.Parameters.AddWithValue("@EmpUsername", UidTb.Text)
                cmd.Parameters.AddWithValue("@EmpPassword", PassTb.Text)
                Dim empId = cmd.ExecuteScalar()
                If empId IsNot Nothing Then
                    MessageBox.Show("Login successfully!")
                    My.Settings.EmpID = empId.ToString
                    My.Settings.Save()
                    MainForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Incorrect Email or Password")

                End If
            End Using
        End Using
    End Sub


    Private Sub Guna2GradientTileButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton3.Click
        UidTb.Clear()
        PassTb.Clear()
    End Sub

    Private Sub UidTb_TextChanged(sender As Object, e As EventArgs) Handles UidTb.TextChanged

    End Sub
End Class
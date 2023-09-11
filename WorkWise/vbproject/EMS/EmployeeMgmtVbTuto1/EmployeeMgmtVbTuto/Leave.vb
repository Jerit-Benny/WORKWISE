Imports System.Data.SqlClient
Public Class Leave

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jisto\Desktop\New folder\back3\vbproject\EMS\EmployeeMgmtVbTuto1\EmployeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand
        ' con.Open()
        'cmd.Connection = con
        Dim query As String = "Insert into Leave(Emp_Id,reason,start,noofDays) values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Value & "','" & TextBox3.Text & "')"
        'cmd = New SqlCommand(query, con)
        'MsgBox("Department added successfully")

        Using conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jisto\Desktop\New folder\back3\vbproject\EMS\EmployeeMgmtVbTuto1\EmployeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
            Using command As SqlCommand = New SqlCommand(query, conn)
                command.Parameters.AddWithValue("@Emp_Id", TextBox1.Text)
                command.Parameters.AddWithValue("@reason", ComboBox1.Text)
                command.Parameters.AddWithValue("@start", DateTimePicker1.Value)
                command.Parameters.AddWithValue("@noofDays", TextBox3.Text)
                conn.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("SUCCESSFULLY UPDATED")
            End Using
        End Using
        con.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Leave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Sick")
        ComboBox1.Items.Add("vacation")
        ComboBox1.Items.Add("Funeral")
        ComboBox1.Items.Add("Maternity")
        ComboBox1.Items.Add("Paternity")
        ComboBox1.Items.Add("Accident on duty")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim Main = New adminvb
        Main.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
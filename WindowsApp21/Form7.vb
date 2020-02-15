Imports MySql.Data.MySqlClient
Public Class Form7
    Dim MySqlconn As MySqlConnection
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlconn = New MySqlConnection
        MySqlconn.ConnectionString = "server=remotemysql.com;userid=blCXim0ri2;password=ZG7W42VPVS;database=blCXim0ri2"

        Label1.Text = "Add/Update/Delete Book"
        Label2.Text = "ID"
        Label3.Text = "Name"
        Label4.Text = "Author"
        Label5.Text = "Published Date(dd/mm/yyyy)"
        Button1.Text = "Back"
        Button2.Text = "Add"
        Button3.Text = "Update"
        Button4.Text = "Delete"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Reader As MySqlDataReader
        Try
            MySqlconn.Open()


            Dim Query As String
            Dim Command As MySqlCommand



            Query = " insert into blCXim0ri2.book (id,name,author,publishdate) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            Command = New MySqlCommand(Query, MySqlconn)


            Reader = Command.ExecuteReader

            MsgBox("Data Saved")

            MySqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MySqlconn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Reader As MySqlDataReader
        Try
            MySqlconn.Open()


            Dim Query As String
            Dim Command As MySqlCommand


            Query = " update blCXim0ri2.book set id='" & TextBox1.Text & "',Name='" & TextBox2.Text & "',Author='" & TextBox3.Text & "',PublishDate='" & TextBox4.Text & "'where id='" & TextBox1.Text & "' "
            Command = New MySqlCommand(Query, MySqlconn)


            Reader = Command.ExecuteReader

            MsgBox("Data Updated")

            MySqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MySqlconn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Reader As MySqlDataReader
        Try
            MySqlconn.Open()


            Dim Query As String
            Dim Command As MySqlCommand



            Query = "Delete from blCXim0ri2.book where id='" & TextBox1.Text & "' "
            Command = New MySqlCommand(Query, MySqlconn)


            Reader = Command.ExecuteReader

            MsgBox("Data Deleted")

            MySqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MySqlconn.Close()
    End Sub
End Class
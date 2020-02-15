Imports MySql.Data.MySqlClient
Public Class Form4
    Dim MySqlconn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Text = "Home"
        Label1.Text = "Library Management-Admin Panel"
        Label2.Text = "Users"
        Label3.Text = "Books"
        Button2.Text = "Add User"
        Button3.Text = "Add Book"
        Button4.Text = "Load"
        Button5.Text = "Load"
        Button6.Text = "Assign Books to User"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MySqlconn = New MySqlConnection
        MySqlconn.ConnectionString = "server=remotemysql.com;userid=blCXim0ri2;password=ZG7W42VPVS;database=blCXim0ri2"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource





        Try
            MySqlconn.Open()
            Dim Query As String

            Query = "select * from blCXim0ri2.user "

            Command = New MySqlCommand(Query, MySqlconn)
            SDA.SelectCommand = Command


            SDA.Fill(dbDataSet)

            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlconn.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MySqlconn.Close()








    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MySqlconn = New MySqlConnection
        MySqlconn.ConnectionString = "server=remotemysql.com;userid=blCXim0ri2;password=ZG7W42VPVS;database=blCXim0ri2"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource





        Try
            MySqlconn.Open()
            Dim Query As String

            Query = "select * from blCXim0ri2.book "

            Command = New MySqlCommand(Query, MySqlconn)
            SDA.SelectCommand = Command


            SDA.Fill(dbDataSet)

            bSource.DataSource = dbDataSet
            DataGridView2.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlconn.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MySqlconn.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form8.Show()
        Me.Hide()
    End Sub
End Class
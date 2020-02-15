Imports MySql.Data.MySqlClient
Public Class Form3
    Dim MySqlconn As MySqlConnection
    Dim Command As MySqlCommand
    Public Shared Property a As Double

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "Home"
        Label1.Text = "Library Management-User Panel"
        Label3.Text = "Welcome"
        Label4.Text = "Your Profile Details"
        Button2.Text = "Show"
        Label5.Text = "Available Books"
        Dim a As Integer = Val(Form1.TextBox1.Text)
        MsgBox("Welcome! Roll NO. " & a)

        MySqlconn = New MySqlConnection
        MySqlconn.ConnectionString = "server=remotemysql.com;userid=blCXim0ri2;password=ZG7W42VPVS;database=blCXim0ri2"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try
            MySqlconn.Open()
            Dim Query As String

            Query = "select * from coRsbSI9PB.user where Roll='" & a & "' "

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
End Class
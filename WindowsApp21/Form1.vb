Imports MySql.Data.MySqlClient

Public Class Form1
    Dim MySqlconn As MySqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlconn = New MySqlConnection
        MySqlconn.ConnectionString = "server=remotemysql.com;userid=blCXim0ri2;password=ZG7W42VPVS;database=blCXim0ri2"
        Label1.Text = "Roll No."
        Label2.Text = "Password"
        Label5.Text = "Login Page"
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("User")
        Label7.Text = "Library Management System"
        Button1.Text = "Test Connection"
        Button2.Text = "Login"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            MySqlconn.Open()
            MsgBox("Connected", "0")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MySqlconn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As String = ComboBox1.SelectedItem
        If a = "User" Then


            Dim Query As String
            Dim Command As MySqlCommand
            Dim Reader As MySqlDataReader

            Query = "select * from blCXim0ri2.user where Roll='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'"
            Command = New MySqlCommand(Query, MySqlconn)
            MySqlconn.Open()
            Reader = Command.ExecuteReader
            Dim c As Integer

            While Reader.Read
                c = c + 1
            End While
            If c = 1 Then
                MsgBox("Login Success", "0")
                Form3.Show()
                Form3.Label2.Text = TextBox1.Text
                MySqlconn.Close()
                Me.Hide()

            Else
                MsgBox("Login Failed", "0")
            End If
            MySqlconn.Close()

        ElseIf a = "Admin" Then
            Dim Query As String
            Dim Command As MySqlCommand
            Dim Reader As MySqlDataReader

            Query = "select * from blCXim0ri2.admin where Roll='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'"
            Command = New MySqlCommand(Query, MySqlconn)
            MySqlconn.Open()
            Reader = Command.ExecuteReader
            Dim c As Integer

            While Reader.Read
                c = c + 1
            End While
            If c = 1 Then
                MsgBox("Login Success", "0")
                Form4.Show()
                Me.Hide()
            Else
                MsgBox("Login Failed", "0")
                MySqlconn.Close()
            End If
        Else
            MsgBox("Select User or Admin", "0")
            MySqlconn.Close()
        End If
    End Sub


End Class

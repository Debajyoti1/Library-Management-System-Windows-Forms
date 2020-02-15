Imports MySql.Data.MySqlClient
Public Class Form8
    Dim MySqlconn As MySqlConnection
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlconn = New MySqlConnection
        MySqlconn.ConnectionString = "server=remotemysql.com;userid=blCXim0ri2;password=ZG7W42VPVS;database=blCXim0ri2"
        Button1.Text = "Home"
        Button2.Text = "Assign"
        Label1.Text = "Assign Books to User"
        Label2.Text = "Select User"
        Label3.Text = "Select Book to Assign"



        Dim Reader As MySqlDataReader
        Try
            MySqlconn.Open()


            Dim Query As String
            Dim Command As MySqlCommand



            Query = "Select * from blCXim0ri2.user"
            Command = New MySqlCommand(Query, MySqlconn)


            Reader = Command.ExecuteReader

            While Reader.Read
                Dim sName = Reader.GetString("Roll")
                ComboBox1.Items.Add(sName)
            End While

            MySqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MySqlconn.Close()



        Try
            MySqlconn.Open()


            Dim Query As String
            Dim Command As MySqlCommand



            Query = "Select * from blCXim0ri2.book"
            Command = New MySqlCommand(Query, MySqlconn)


            Reader = Command.ExecuteReader

            While Reader.Read
                Dim sName = Reader.GetString("Name")
                ComboBox2.Items.Add(sName)
            End While

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim Reader As MySqlDataReader

        MySqlconn.Open()


            Dim Query As String
            Dim Command As MySqlCommand
        Dim p As String

        Query = "select books from blCXim0ri2.user where Roll='" & ComboBox1.SelectedItem & "' "

        Command = New MySqlCommand(Query, MySqlconn)


        Reader = Command.ExecuteReader

        While Reader.Read
            Dim sName As String = Reader.GetString("Books")
            p = sName

        End While


        MySqlconn.Close()








            Try
            MySqlconn.Open()





            Query = " update blCXim0ri2.user set Books='" & p & " " & ComboBox2.SelectedItem & "'where Roll='" & ComboBox1.SelectedItem & "' "
            Command = New MySqlCommand(Query, MySqlconn)


            Reader = Command.ExecuteReader

            MsgBox("Book inserted")

            MySqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MySqlconn.Close()

    End Sub
End Class
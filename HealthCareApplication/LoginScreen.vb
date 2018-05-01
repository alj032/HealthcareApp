Imports System.Data.SqlClient
Public Class LoginScreen
    ''Place to store the #USERID we will use this in the next form to retrieve information about the user 
    Public UserID As Int16
    Public Username As String

    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles ButtonSignUp.Click
        UserSignUp.Show()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        ' connects to xanadu databse and looks at the credentials table
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=xanadu;Trusted_Connection=yes")
        Dim command As New SqlCommand("Select * from credentials where username = @Username and password = @Password", connection)
        ' looks to see if the database username and password match the databse
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        'if there isnt a match error message else authenticate and show buttons
        If table.Rows.Count() <= 0 Then
            MsgBox("Credentials don't match!", MsgBoxStyle.OkOnly, "Error!")
        Else
            Username = TextBox1.Text
            UserID = table.Rows.Item(0).Item("userID")
            MainForm.Show()
            Me.Close()
        End If
    End Sub
End Class
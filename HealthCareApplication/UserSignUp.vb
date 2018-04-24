Imports System.Data.SqlClient
Public Class UserSignUp
    Protected db As New db 'call db.vb to connect to database.
    Private Sub ButtonCancelSignUp_Click(sender As Object, e As EventArgs) Handles ButtonCancelSignUp.Click
        LoginScreen.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'connects to xanadu databse and looks at the credentials table
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=xanadu;Trusted_Connection=yes")
        Dim command As New SqlCommand("Select * from credentials where username = @Username", connection)
        ' looks to see if the username is already in the database
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        'if there isnt a match error message continue with user creation
        If table.Rows.Count() <= 0 Then
            Dim x As String
            x = TextBox3.Text 'saves textbox 3 for value comparison
            If x = TextBox2.Text Then 'Verifies passwords match
                If TextBox1.Text = "" Or TextBox2.Text = "" Then 'looks to see if login or password is empty
                    MsgBox("Please enter username and password", vbOK)
                Else
                    db.sql = "Insert into Credentials (username, password) Values (@username, @password)" 'creates user
                    db.bind("@username", TextBox1.Text)
                    db.bind("@password", TextBox2.Text)
                    db.execute()
                    MsgBox("New User Created", MsgBoxStyle.OkOnly)
                    Me.Close()
                End If
            Else
                MsgBox("Passwords must match", vbOK) 'alerts user passwords don't match

            End If
        Else
            MsgBox("User already exists", MsgBoxStyle.OkOnly, "Duplicate Values!")
        End If
    End Sub
End Class
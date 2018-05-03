Imports System.Data.SqlClient
Public Class UserSignUp
    Protected db As New db 'call db.vb to connect to database.
    Private Sub UserSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        weighttextbox.PromptChar = " "
        txtBirthday1.PromptChar = " "

    End Sub
    Private Sub ButtonCancelSignUp_Click(sender As Object, e As EventArgs) Handles ButtonCancelSignUp.Click
        LoginScreen.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim feet As Integer
        Dim inch As Integer
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
                Dim tbx = {TextBox1, TextBox2, FirstnameTextBox, LastNameTextbox, txtBirthday1, weighttextbox} 'for each checks that all textbox are not null
                For Each tb In tbx
                    If tb.Text = "" Or GoalCombobox.Text = String.Empty Or fttxtbox.Text = String.Empty AndAlso inchtxtbox.Text = String.Empty Then 'checks to see if one of the height boxes and the combobox is filled
                        MsgBox("All Fields Are Required", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Next
                If fttxtbox.Text.Trim.Length > 0 Then 'checks if box has text
                    Int32.TryParse(fttxtbox.Text, feet) 'converts to integer
                End If
                If inchtxtbox.Text.Trim.Length > 0 Then 'checks if box has text
                    Int32.TryParse(inchtxtbox.Text, inch) 'converts to integer
                End If
                inch = inch + feet * 12 'converts height to inches

                db.sql = "Insert into Credentials (username, password, firstname, lastname, birthdate, weight, height, goal) Values (@username, @password, @firstname, @lastname, @birthdate, @weight, @height, @goal)" 'creates user
                db.bind("@username", TextBox1.Text)
                db.bind("@password", TextBox2.Text)
                db.bind("@firstname", FirstnameTextBox.Text)
                db.bind("@lastname", LastNameTextbox.Text)
                db.bind("@weight", weighttextbox.Text)
                db.bind("@height", inch)
                db.bind("@birthdate", txtBirthday1.Text)
                db.bind("@goal", GoalCombobox.Text)
                db.execute()
                MsgBox("New User Created", MsgBoxStyle.OkOnly)
                Me.Close()
            Else
                    MsgBox("Passwords must match", vbOK) 'alerts user passwords don't match
                Exit Sub
            End If
        Else
            MsgBox("User already exists", MsgBoxStyle.OkOnly, "Duplicate Values!")
            Exit Sub
        End If
    End Sub
    Private Sub GoalCombobox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GoalCombobox.KeyPress
        e.Handled = True
    End Sub

    Private Sub weighttextbox_MouseClick(sender As Object, e As MouseEventArgs) Handles weighttextbox.MouseClick
        weighttextbox.SelectionStart = 0
    End Sub
    Private Sub txtbirthday1_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBirthday1.MouseClick
        txtBirthday1.SelectionStart = 0
    End Sub

    Private Sub fttxtbox_MouseClick(sender As Object, e As MouseEventArgs) Handles fttxtbox.MouseClick
        fttxtbox.SelectionStart = 0
    End Sub
    Private Sub inchtxtbox_MouseClick(sender As Object, e As MouseEventArgs) Handles inchtxtbox.MouseClick
        inchtxtbox.SelectionStart = 0
    End Sub
End Class
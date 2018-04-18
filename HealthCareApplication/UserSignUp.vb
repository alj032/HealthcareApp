Public Class UserSignUp
    Private Sub ButtonCancelSignUp_Click(sender As Object, e As EventArgs) Handles ButtonCancelSignUp.Click
        LoginScreen.Show()
        Me.Close()
    End Sub
End Class
Public Class Meal
    Protected db As New db
    Private Sub ButtonCancelSignUp_Click(sender As Object, e As EventArgs) Handles ButtonCancelSignUp.Click
        Me.Dispose()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mealtype.Text = "" Then
            MsgBox("Please enter a meal type", MsgBoxStyle.OkOnly) 'checks for nulls
            Exit Sub
        End If
        If ingredients.Text = "" Then
            MsgBox("Please enter an ingredient", MsgBoxStyle.OkOnly) 'checks for nulls
            Exit Sub
        End If
        If Instructions.Text = "" Then
            MsgBox("Please enter some instructions", MsgBoxStyle.OkOnly) 'checks for nulls
            Exit Sub
        End If
        db.sql = "Insert Into meals (typeofmeal, ingredients, instructions) Values (@typeofmeal, @ingredients, @instructions)" 'inserts into database
        db.bind("@typeofmeal", mealtype.Text)
        db.bind("@ingredients", ingredients.Text)
        db.bind("@instructions", Instructions.Text)
        db.execute()
        MsgBox("Meal entered sucessfully", MsgBoxStyle.OkOnly)
        ''Filling breakfast datagridview
        db.sql = "Select * from Meals where typeofmeal = 'Breakfast'"
        db.fill(MainForm.DataGridViewAvailableBreakfast)

        ''filling lunch datagrid view
        db.sql = "Select * from Meals where typeofmeal = 'Lunch'"
        db.fill(MainForm.DataGridViewAvailableLunch)

        ''filling dinner datagridview
        db.sql = "Select * from Meals where typeofmeal = 'Dinner'"
        db.fill(MainForm.DataGridViewAvailableDinner)
        'clears selection
        mealtype.Text = ""
        ingredients.Text = ""
        Instructions.Text = ""

    End Sub
    Private Sub mealtype_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mealtype.KeyPress
        If Asc(e.KeyChar) <> -1 Then
            e.Handled = True
        End If

    End Sub
End Class
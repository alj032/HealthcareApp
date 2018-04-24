Public Class MainForm
    ''Calling the database
    Protected db As New db

    ''When the form loads
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Setting to full row selection mode
        DataGridViewAvailableBreakfast.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewAvailableLunch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewAvailableDinner.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewSteps.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        ''Filling Datagridviews


        ''Filling breakfast datagridview
        db.sql = "Select * from Meals where [Type of Meal] = 'Breakfast'"
        db.fill(DataGridViewAvailableBreakfast)

        ''filling lunch datagrid view
        db.sql = "Select * from Meals where [Type of Meal] = 'Lunch'"
        db.fill(DataGridViewAvailableLunch)

        ''filling dinner datagridview
        db.sql = "Select * from Meals where [Type of Meal] = 'Dinner'"
        db.fill(DataGridViewAvailableDinner)

        ''Filling Steps datagridview
        db.sql = "SELECT [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSteps)

        ''Filling Events DataGridView
        db.sql = "SELECT Event_ID, Event_Name, Event_Date, Event_Location FROM [Events]"
        db.fill(DataGridViewEvents)




    End Sub

    ''When a user clicks the last day buttons we select the top row from their steps and display it in the datagridview
    Private Sub ButtonLastDay_Click(sender As Object, e As EventArgs) Handles ButtonLastDay.Click
        db.sql = "SELECT Top 1 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSteps)
    End Sub
    ''When a user clicks the last 30 day buttons we select the top 30 row from their steps and display it in the datagridview
    Private Sub ButtonLast30Days_Click(sender As Object, e As EventArgs) Handles ButtonLast30Days.Click
        db.sql = "SELECT Top 30 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSteps)
    End Sub
    ''When a user clicks the all days button we select all rows from their steps and display it in the datagridview
    Private Sub ButtonAllDays_Click(sender As Object, e As EventArgs) Handles ButtonAllDays.Click
        db.sql = "SELECT [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSteps)
    End Sub

    ''AddEvent Button Click
    Private Sub ButtonAddEvent_Click(sender As Object, e As EventArgs) Handles ButtonAddEvent.Click
        AddEvent.Show()
    End Sub
End Class

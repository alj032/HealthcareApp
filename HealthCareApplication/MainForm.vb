﻿Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class MainForm
    ''Calling the database
    Protected db As New db
    Public UserID
    Public Username As String
    Public EventID = 0
    Dim selecteddate As Int32

    ''When the form loads
    Public Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Getting the value of the user ID so we can use it for queries in this form.
        UserID = LoginScreen.UserID
        Username = LoginScreen.Username

        ''Changing the label text to show their username and a friendly message
        LabelWelcome.Text = "Hello " & Username & "! Stay healthy!"

        ''Setting to full row selection mode
        DataGridViewAvailableBreakfast.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewAvailableLunch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewAvailableDinner.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewSteps.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect


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
        db.sql = "declare @yesterday datetime declare @now datetime set @now = getdate() set @yesterday = dateadd(day,-1,@now) SELECT Event_ID, Event_Name, Event_Date, Event_Location FROM [Events] where event_date >=@yesterday order by event_date "
        db.fill(DataGridViewEvents)

        ''Filling EventRegistration DataGridView
        db.sql = "declare @yesterday datetime declare @now datetime set @now = getdate() set @yesterday = dateadd(day,-1,@now) Select Event_Name, Event_Location, Event_Date, Event_Description From [Events] Join EventRegistration ER ON Events.Event_ID = ER.EventId Where UserID = @userid and [EVENT_DATE] >=@yesterday order by Event_Date"
        db.bind("@userid", UserID)
        db.fill(DataGridViewEventRegister)

        ''Filling EventRegistration DataGridView
        db.sql = "SELECT [Start],[Time in Bed] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSleepStats)

    End Sub

    ''When a user clicks the last day buttons we select the top row from their steps and display it in the datagridview
    Private Sub ButtonLastDay_Click(sender As Object, e As EventArgs) Handles ButtonLastDay.Click
        db.sql = "SELECT Top 1 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSteps)

    End Sub
    Private Sub ButtonLastDayStepsGraph_Click(sender As Object, e As EventArgs) Handles ButtonLastDayStepsGraph.Click
        ''Open Graph
        StepStatsLast.ShowDialog()
    End Sub
    ''When a user clicks the last 30 day buttons we select the top 30 row from their steps and display it in the datagridview
    Private Sub ButtonLast30Days_Click(sender As Object, e As EventArgs) Handles ButtonLast30Days.Click
        db.sql = "SELECT Top 30 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSteps)
    End Sub

    Private Sub ButtonLast30StepsGraph_Click(sender As Object, e As EventArgs) Handles ButtonLast30StepsGraph.Click
        ''Open Steps graph for last 30 days
        SleepStats30Days.ShowDialog()
    End Sub

    ''When a user clicks the all days button we select all rows from their steps and display it in the datagridview
    Private Sub ButtonAllDays_Click(sender As Object, e As EventArgs) Handles ButtonAllDays.Click
        db.sql = "SELECT [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSteps)
    End Sub

    Private Sub ButtonAllStepsGraph_Click(sender As Object, e As EventArgs) Handles ButtonAllStepsGraph.Click
        ''Open sleep graph for all days
        StepStatsAll.ShowDialog()
    End Sub

    ''AddEvent Button Click
    Private Sub ButtonAddEvent_Click(sender As Object, e As EventArgs) Handles ButtonAddEvent.Click
        AddEvent.Show()
    End Sub

    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles ButtonSignUp.Click
        EventID = DataGridViewEvents.SelectedRows(0).Cells(0).Value
        If EventID = 0 Then
            MsgBox("Please select an event!", MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        End If
        'connects to xanadu databse and looks at the event registration table
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=xanadu;Trusted_Connection=yes")
        Dim command As New SqlCommand("Select * from EventRegistration where UserID = @UserID and EventID = @EventID", connection)
        ' looks to see if the username is already in the database
        command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID
        command.Parameters.Add("@EventID", SqlDbType.Int).Value = EventID
        Dim adapter As New SqlDataAdapter(command)
        Dim table2 As New DataTable()
        adapter.Fill(table2)
        'if there isnt a match error message continue with event registration
        If table2.Rows.Count() > 0 Then
            MsgBox("You have already registered for this event", MsgBoxStyle.OkOnly, "Error!")
        Else
            ''Registering a user for an event
            db.sql = "Insert Into EventRegistration (UserID, EventID) Values (@UserID, @EventID)"
            db.bind("@UserID", UserID)
            db.bind("@EventID", EventID)
            db.execute()
            MsgBox("Sucessfully registered for event!", MsgBoxStyle.OkOnly)
            db.sql = "declare @yesterday datetime declare @now datetime set @now = getdate() set @yesterday = dateadd(day,-1,@now) Select Event_Name, Event_Location, Event_Date, Event_Description From [Events] Join EventRegistration ER ON Events.Event_ID = ER.EventId Where UserID = @userid and [EVENT_DATE] >=@yesterday order by Event_Date"
            db.bind("@userid", UserID)
            db.fill(DataGridViewEventRegister)
        End If
    End Sub

    Private Sub DataGridViewSteps_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSteps.CellClick
        ''If a cell is clicked 
        If (DataGridViewSteps.SelectedRows.Count > 0) Then ''make Then sure user Select at least 1 row 
            ''Declare steps
            Dim Steps As Int32
            Dim TargetSteps As Int32

            ''Setting variable = to the value in the datagrid view
            TextBoxActualSteps.Text = DataGridViewSteps.SelectedRows(0).Cells(1).Value
            Steps = Convert.ToInt32(TextBoxActualSteps.Text)
            TextBoxActualCalories.Text = Steps \ 20
            TextBoxActualDistance.Text = (Steps * 2.5) / (5280)
            
            db.sql = "Select targetsteps from Credentials Where UserID = @UserID"
            db.bind("@UserID", UserID)
            db.fill(DataGridViewTargetSteps)

            DataGridViewTargetSteps.Rows(0).Selected = True

            TextBoxTargetSteps.Text = DataGridViewTargetSteps.SelectedRows(0).Cells(0).Value
            TargetSteps = Convert.ToInt32(TextBoxTargetSteps.Text)
            TextBoxTargetCalories.Text = TargetSteps \ 20
            TextBoxTargetDistance.Text = (TargetSteps * 2.5) / (5280)
        End If
    End Sub

    Private Sub ButtonLastSleepDay_Click(sender As Object, e As EventArgs) Handles ButtonLastSleepDay.Click
        ''Filling datagrid view witht the most recent record
        db.sql = "SELECT Top 1 [Start], [Time in bed] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSleepStats)
    End Sub

    Private Sub ButtonLast30_Click(sender As Object, e As EventArgs) Handles ButtonLast30.Click
        db.sql = "SELECT Top 30 [Start], [Time in bed] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSleepStats)
    End Sub

    Private Sub ButtonAllRecords_Click(sender As Object, e As EventArgs) Handles ButtonAllRecords.Click
        db.sql = "SELECT [Start], [Time in bed] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSleepStats)
    End Sub

    Private Sub ButtonSleepLast_Click(sender As Object, e As EventArgs) Handles ButtonSleepLast.Click
        ''Show Graph
        SleepStatsLast.ShowDialog()
    End Sub

    Private Sub ButtonSleep30_Click(sender As Object, e As EventArgs) Handles ButtonSleep30.Click
        ''Show Graph
        SleepStats30.ShowDialog()
    End Sub

    Private Sub ButtonSleepAllRecord_Click(sender As Object, e As EventArgs) Handles ButtonSleepAllRecord.Click
        ''Show Graph
        SleepStatsAll.ShowDialog()
    End Sub

    Private Sub ButtonDashboardSteps_Click(sender As Object, e As EventArgs) Handles ButtonDashboardSteps.Click
        ''Open Steps graph for last 30 days
        SleepStats30Days.ShowDialog()

    End Sub

    Private Sub ButtonDashboardSleep_Click(sender As Object, e As EventArgs) Handles ButtonDashboardSleep.Click
        ''Show Graph
        SleepStats30.ShowDialog()
    End Sub


    'Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
    '    'sunday = 0 Monday = 1 Tuesday = 2 Wednesday = 3 Thursday = 4 Friday = 5 Saturday = 6 
    '    selecteddate = MonthCalendar2.SelectionStart.DayOfWeek
    '    TextBox3.Text = MonthCalendar2.SelectionRange.Start.ToShortDateString()
    '    db.sql = ""
    'End Sub
End Class

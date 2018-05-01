Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class MainForm

    ''Calling the database
    Protected db As New db
    Public UserID
    Public Username As String
    Public EventID = 0



    ''When the form loads
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ''Filling EventRegistration DataGridView
        db.sql = "Select Event_Name, Event_Location, Event_Date, Event_Description From [Events] Join EventRegistration ER ON Events.Event_ID = ER.EventId Where UserID = @userid"
        db.bind("@userid", UserID)
        db.fill(DataGridViewEventRegister)

        ''Filling EventRegistration DataGridView
        db.sql = "SELECT [Start],[Time in Bed] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSleepStats)




        ''Dashboard GRAHPS
        ''Sleep Graph
        ''Graph
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=Xanadu;Trusted_Connection=yes;"}
        'prepare a query
        Dim command As New SqlCommand With {.Connection = connection}


        Dim sqlSleepAll As String = "SELECT Top 30 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"

        Dim adapter As New SqlDataAdapter(sqlSleepAll, connection)
        Dim dataset As New DataSet()
        adapter.Fill(dataset, "Steps30Dash")

        Dim chartarea1 As ChartArea = New ChartArea()
        Dim legend1 As Legend = New Legend()
        Dim series1 As Series = New Series()
        Dim chartStepDashboard = New Chart()
        Me.Controls.Add(chartStepDashboard)
        chartarea1.Name = "ChartArea"
        chartStepDashboard.ChartAreas.Add(chartarea1)
        legend1.Name = "Legend"
        chartStepDashboard.Legends.Add(legend1)
        chartStepDashboard.Location = New System.Drawing.Point(962, 63)
        chartStepDashboard.Name = "Hours_of_Sleep"
        chartStepDashboard.Titles.Add("Number of Steps for 30 Records")
        series1.ChartArea = "ChartArea"
        series1.Legend = "Legend"
        series1.Name = "series1"
        chartStepDashboard.Series.Add(series1)
        chartStepDashboard.Size = New System.Drawing.Size(395, 279)
        chartStepDashboard.TabIndex = 0
        chartStepDashboard.Text = "chart1"
        chartStepDashboard.Series("series1").XValueMember = "Start"
        chartStepDashboard.Series("series1").YValueMembers = "Activity (steps)"
        chartStepDashboard.ChartAreas(0).AxisX.Title = "Day"
        chartStepDashboard.ChartAreas(0).AxisY.Title = "Number of Steps"



        chartStepDashboard.DataSource = dataset.Tables("Steps30Dash")
        chartStepDashboard.BringToFront()


        ''Sleep Graph
        ''Graph
        Dim connection1 As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=Xanadu;Trusted_Connection=yes;"}
        'prepare a query
        Dim command1 As New SqlCommand With {.Connection = connection1}


        Dim sqlSleepAll1 As String = "SELECT Top 30 [Start],[Sleep Quality] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"

        Dim adapter1 As New SqlDataAdapter(sqlSleepAll1, connection1)
        Dim dataset1 As New DataSet()
        adapter1.Fill(dataset1, "Sleep30Dash")

        Dim chartarea11 As ChartArea = New ChartArea()
        Dim legend11 As Legend = New Legend()
        Dim series11 As Series = New Series()
        Dim chartSleepDashboard = New Chart()
        Me.Controls.Add(chartSleepDashboard)
        chartarea11.Name = "ChartArea"
        chartSleepDashboard.ChartAreas.Add(chartarea11)
        legend11.Name = "Legend"
        chartSleepDashboard.Legends.Add(legend11)
        chartSleepDashboard.Location = New System.Drawing.Point(962, 409)
        chartSleepDashboard.Name = "Hours_of_Sleep"
        chartSleepDashboard.Titles.Add("Quality of Sleep for 30 Records")
        series11.ChartArea = "ChartArea"
        series11.Legend = "Legend"
        series11.Name = "series1"
        chartSleepDashboard.Series.Add(series11)
        chartSleepDashboard.Size = New System.Drawing.Size(395, 279)
        chartSleepDashboard.TabIndex = 0
        chartSleepDashboard.Text = "chart1"
        chartSleepDashboard.Series("series1").XValueMember = "Start"
        chartSleepDashboard.Series("series1").YValueMembers = "Sleep Quality"
        chartSleepDashboard.ChartAreas(0).AxisX.Title = "Day"
        chartSleepDashboard.ChartAreas(0).AxisY.Title = "Sleep Quality (0-100)"



        chartSleepDashboard.DataSource = dataset1.Tables("Sleep30Dash")
        chartSleepDashboard.BringToFront()



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
        ''Open sleep graph for last 30 days
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
            db.sql = "Select Event_Name, Event_Location, Event_Date, Event_Description From [Events] Join EventRegistration ER ON Events.Event_ID = ER.EventId Where UserID = @userid"
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
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class MainForm

    ''Calling the database
    Protected db As New db
    Public UserID
    Public Username As String
    Public EventID



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
        db.sql = "SELECT * FROM [EventRegistration] where userid = @userid"
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

        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=Xanadu;Trusted_Connection=yes;"}
        'prepare a query
        Dim command As New SqlCommand With {.Connection = connection}


        Dim sqlsteps1day As String = "SELECT Top 1 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"

        Dim adapter As New SqlDataAdapter(sqlsteps1day, connection)
        Dim dataset As New DataSet()
        dataset.Clear()
        adapter.Fill(dataset, "Steps")

        Dim chartarea1 As ChartArea = New ChartArea()
        Dim legend1 As Legend = New Legend()
        Dim series1 As Series = New Series()
        Dim chart1 = New Chart()
        Me.Controls.Add(chart1)
        chartarea1.Name = "ChartArea"
        chart1.ChartAreas.Add(chartarea1)
        legend1.Name = "Legend"
        chart1.Legends.Add(legend1)
        chart1.Location = New System.Drawing.Point(13, 13)
        chart1.Name = "Sales by Year"
        chart1.Titles.Add("Sales By Year")
        series1.ChartArea = "ChartArea"
        series1.Legend = "Legend"
        series1.Name = "series1"
        chart1.Series.Add(series1)
        chart1.Size = New System.Drawing.Size(1000, 400)
        chart1.TabIndex = 0
        chart1.Text = "chart1"
        chart1.Series("series1").XValueMember = "Start"
        chart1.Series("series1").YValueMembers = "Activity (steps)"
        chart1.ChartAreas(0).AxisX.Title = "Day"
        chart1.ChartAreas(0).AxisY.Title = "Steps"



        chart1.DataSource = dataset.Tables("Steps")







    End Sub

    ''When a user clicks the last 30 day buttons we select the top 30 row from their steps and display it in the datagridview
    Private Sub ButtonLast30Days_Click(sender As Object, e As EventArgs) Handles ButtonLast30Days.Click
        db.sql = "SELECT Top 30 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSteps)


        db.sql = "SELECT Top 30 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSteps)

        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=Xanadu;Trusted_Connection=yes;"}
        'prepare a query
        Dim command As New SqlCommand With {.Connection = connection}


        Dim sqlsteps1day As String = "SELECT Top 30 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"

        Dim adapter As New SqlDataAdapter(sqlsteps1day, connection)
        Dim dataset As New DataSet()
        dataset.Clear()
        adapter.Fill(dataset, "Steps")

        Dim chartarea1 As ChartArea = New ChartArea()

        Dim legend1 As Legend = New Legend()
        Dim series1 As Series = New Series()
        Dim chart1 = New Chart()
        Me.Controls.Add(chart1)
        chartarea1.Name = "ChartArea"
        chart1.ChartAreas.Add(chartarea1)
        legend1.Name = "Legend"
        chart1.Legends.Add(legend1)
        chart1.Location = New System.Drawing.Point(13, 13)
        chart1.Name = "Sales by Year"
        chart1.Titles.Add("Sales By Year")
        series1.ChartArea = "ChartArea"
        series1.Legend = "Legend"
        series1.Name = "series1"
        chart1.Series.Add(series1)
        chart1.Size = New System.Drawing.Size(1000, 400)
        chart1.TabIndex = 0
        chart1.Text = "chart1"
        chart1.Series("series1").XValueMember = "Start"
        chart1.Series("series1").YValueMembers = "Activity (steps)"
        chart1.ChartAreas(0).AxisX.Title = "Day"
        chart1.ChartAreas(0).AxisY.Title = "Steps"



        chart1.DataSource = dataset.Tables("Steps")




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
    Private Sub DataGridViewEvents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEvents.CellClick
        usertextbox.Text = UserID
        EventID = DataGridViewEvents.SelectedRows(0).Cells(0).Value
        eventtextbox.Text = EventID
    End Sub
    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles ButtonSignUp.Click
        MessageBox.Show(UserID)
        MessageBox.Show(EventID)

        'connects to xanadu databse and looks at the eventregistration table
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=xanadu;Trusted_Connection=yes")
        Dim command As New SqlCommand("Select * from EventRegistration where UserID = @UserID AND EventID = @EventID", connection)
        ' looks to see if the username is already in the database
        command.Parameters.Add("@UserID", SqlDbType.VarChar).Value = usertextbox.Text
        command.Parameters.Add("@EventID", SqlDbType.VarChar).Value = eventtextbox.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        'if there isnt a match error message continue with user creation
        If table.Rows.Count() <= 0 Then
            MsgBox("You have already registered for this event", MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        Else
            If (DataGridViewEvents.SelectedRows.Count > 0) Then ''make Then sure user Select at least 1 row 
                ''Registering a user for an event
                db.sql = "Insert Into EventRegistration (UserID, EventID) Values (@UserID, @EventID)"
                db.bind("@UserID", UserID)
                db.bind("@EventID", EventID)
                db.execute()
                db.fill(DataGridViewEventRegister)

            End If
        End If




    End Sub

    Private Sub DataGridViewSteps_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSteps.CellClick

        If (DataGridViewSteps.SelectedRows.Count > 0) Then ''make Then sure user Select at least 1 row 
            Dim Steps As Int32



            ''Setting variable = to the value in the datagrid view
            TextBoxActualSteps.Text = DataGridViewSteps.SelectedRows(0).Cells(1).Value
            Steps = Convert.ToInt32(TextBoxActualSteps.Text)
            TextBoxActualCalories.Text = Steps \ 20
            TextBoxActualDistance.Text = (Steps * 2.5) / (5280)







        End If
    End Sub
    ''Filling the sleep chart when the button is clicked
    Private Sub ButtonLastSleepDay_Click(sender As Object, e As EventArgs) Handles ButtonLastSleepDay.Click


        db.sql = "SELECT Top 30 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"
        db.fill(DataGridViewSteps)

        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=Xanadu;Trusted_Connection=yes;"}
        'prepare a query
        Dim command As New SqlCommand With {.Connection = connection}


        Dim sqlsteps1day As String = "SELECT Top 30 [Start],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"

        Dim adapter As New SqlDataAdapter(sqlsteps1day, connection)
        Dim dataset As New DataSet()
        dataset.Clear()
        adapter.Fill(dataset, "Steps")



        Dim legend1 As Legend = New Legend()
        Dim series1 As Series = New Series()

        Me.Controls.Add(ChartAverageSleep)


        legend1.Name = "Legend"
        ChartAverageSleep.Legends.Add(legend1)

        ChartAverageSleep.Name = "Sales by Year"
        ChartAverageSleep.Titles.Add("Sales By Year")
        series1.ChartArea = "ChartArea"
        series1.Legend = "Legend"
        series1.Name = "series1"
        ChartAverageSleep.Series.Add(series1)
        ChartAverageSleep.TabIndex = 0
        ChartAverageSleep.Text = "chart1"
        ChartAverageSleep.Series("series1").XValueMember = "Start"
        ChartAverageSleep.Series("series1").YValueMembers = "Activity (steps)"
        ChartAverageSleep.ChartAreas(0).AxisX.Title = "Day"
        ChartAverageSleep.ChartAreas(0).AxisY.Title = "Steps"
        rttt


        ChartAverageSleep.DataSource = dataset.Tables("Steps")

    End Sub
End Class

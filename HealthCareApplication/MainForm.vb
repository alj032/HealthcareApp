Public Class MainForm
    ''Calling the database
    Protected db As New db

    ''When the form loads
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'XanaduDataSet.sleepdata' table. You can move, or remove it, as needed.
        Me.SleepdataTableAdapter.Fill(Me.XanaduDataSet.sleepdata)

        ''Setting to full row selection mode
        DataGridViewAvailableBreakfast.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewAvailableLunch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewAvailableDinner.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        ''Filling Datagridviews


        ''Filling breakfast datagridview
        db.sql = "Select * from Meals where [Type of Meal] = 'Breakfast'"
        db.fill(DatagridviewAvailableBreakfast)

        ''filling lunch datagrid view
        db.sql = "Select * from Meals where [Type of Meal] = 'Lunch'"
        db.fill(DataGridViewAvailableLunch)

        ''filling dinner datagridview
        db.sql = "Select * from Meals where [Type of Meal] = 'Dinner'"
        db.fill(DataGridViewAvailableDinner)

        ''Filling Steps datagridview
        db.sql = "SELECT [End],[Activity (steps)] FROM [Xanadu].[dbo].[sleepdata]"
        db.fill(DataGridViewSteps)




    End Sub


End Class

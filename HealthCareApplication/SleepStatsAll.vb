Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class SleepStatsAll
    Private Sub SleepStatsAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Graph
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=Xanadu;Trusted_Connection=yes;"}
        'prepare a query
        Dim command As New SqlCommand With {.Connection = connection}


        Dim sqlSleepAll As String = "SELECT [Start],[Sleep Quality] FROM [Xanadu].[dbo].[sleepdata] Order by [Start] Desc"

        Dim adapter As New SqlDataAdapter(sqlSleepAll, connection)
        Dim dataset As New DataSet()
        adapter.Fill(dataset, "SleepAll")

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
        chart1.Name = "Hours of Sleep"
        chart1.Titles.Add("Quality of Sleep for All Records")
        series1.ChartArea = "ChartArea"
        series1.Legend = "Legend"
        series1.Name = "series1"
        chart1.Series.Add(series1)
        chart1.Size = New System.Drawing.Size(1000, 400)
        chart1.TabIndex = 0
        chart1.Text = "chart1"
        chart1.Series("series1").XValueMember = "Start"
        chart1.Series("series1").YValueMembers = "Sleep Quality"
        chart1.ChartAreas(0).AxisX.Title = "Day"
        chart1.ChartAreas(0).AxisY.Title = "Sleep Quality (0-100)"



        chart1.DataSource = dataset.Tables("SleepAll")

    End Sub

End Class
Public Class AddEvent
    ''Calling the database
    Protected db As New db

    Private Sub ButtonAddEvent_Click(sender As Object, e As EventArgs) Handles ButtonAddEvent.Click
        If TextBoxEventName.TextLength <= 0 Then
            Dim confirmed As Integer = MsgBox("Please enter an event name to continue", vbOK, "Add Event") 'make sure the user puts an event name
        ElseIf TextBoxEventDate.TextLength <= 0 Then
            Dim confirmed As Integer = MsgBox("Please enter an event date to continue", vbOK, "Add Event") 'make sure the user puts an event date
        ElseIf TextBoxEventLocation.TextLength <= 0 Then
            Dim confirmed As Integer = MsgBox("Please enter an event location to continue", vbOK, "Add Event") 'make sure the user puts an event Location
        ElseIf TextBoxEventDescription.TextLength <= 0 Then
            Dim confirmed As Integer = MsgBox("Please enter an event description to continue", vbOK, "Add Event") 'make sure the user puts an event description

        Else

            Dim Answer As MsgBoxResult = MsgBox("Are you sure you want to do this?", vbYesNo, "Add Event") 'ask if they want to proceed with the event addition
            Select Case Answer
                Case MsgBoxResult.Yes
                    'inserts the textbox information into the database
                    db.sql = "Insert into [Events] (Event_Name, Event_Date, Event_Location, Event_Description) Values (@EventName, @EventDate, @EventLocation, @EventDescription)"
                    db.bind("@EventName", TextBoxEventName.Text)
                    db.bind("@EventDate", TextBoxEventDate.Text)
                    db.bind("@EventLocation", TextBoxEventLocation.Text)
                    db.bind("@EventDescription", TextBoxEventDescription.Text)
                    db.execute()
                    MsgBox("Action Completed", vbOK)
                    db.sql = "SELECT Event_ID, Event_Name, Event_Date, Event_Location FROM [Events]"
                    db.fill(MainForm.DataGridViewEvents)
                    Me.Dispose()
                Case MsgBoxResult.No
                    Exit Sub
            End Select

        End If
    End Sub

    Private Sub MonthCalendarAddEvent_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarAddEvent.DateChanged
        TextBoxEventDate.Text = CalendarAddEvent.SelectionRange.Start.ToShortDateString()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEvent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEvent))
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEventName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxEventDate = New System.Windows.Forms.TextBox()
        Me.TextBoxEventDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxEventLocation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalendarAddEvent = New System.Windows.Forms.MonthCalendar()
        Me.ButtonAddEvent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(339, 338)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(205, 74)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Event Name:"
        '
        'TextBoxEventName
        '
        Me.TextBoxEventName.Location = New System.Drawing.Point(87, 6)
        Me.TextBoxEventName.Name = "TextBoxEventName"
        Me.TextBoxEventName.Size = New System.Drawing.Size(218, 20)
        Me.TextBoxEventName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Event Date:"
        '
        'TextBoxEventDate
        '
        Me.TextBoxEventDate.Location = New System.Drawing.Point(87, 48)
        Me.TextBoxEventDate.Name = "TextBoxEventDate"
        Me.TextBoxEventDate.ReadOnly = True
        Me.TextBoxEventDate.Size = New System.Drawing.Size(218, 20)
        Me.TextBoxEventDate.TabIndex = 5
        '
        'TextBoxEventDescription
        '
        Me.TextBoxEventDescription.Location = New System.Drawing.Point(87, 180)
        Me.TextBoxEventDescription.Multiline = True
        Me.TextBoxEventDescription.Name = "TextBoxEventDescription"
        Me.TextBoxEventDescription.Size = New System.Drawing.Size(457, 148)
        Me.TextBoxEventDescription.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-1, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Event Description:"
        '
        'TextBoxEventLocation
        '
        Me.TextBoxEventLocation.Location = New System.Drawing.Point(87, 93)
        Me.TextBoxEventLocation.Name = "TextBoxEventLocation"
        Me.TextBoxEventLocation.Size = New System.Drawing.Size(218, 20)
        Me.TextBoxEventLocation.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-1, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Event Location:"
        '
        'CalendarAddEvent
        '
        Me.CalendarAddEvent.Location = New System.Drawing.Point(317, 6)
        Me.CalendarAddEvent.Name = "CalendarAddEvent"
        Me.CalendarAddEvent.TabIndex = 10
        '
        'ButtonAddEvent
        '
        Me.ButtonAddEvent.Location = New System.Drawing.Point(87, 338)
        Me.ButtonAddEvent.Name = "ButtonAddEvent"
        Me.ButtonAddEvent.Size = New System.Drawing.Size(205, 74)
        Me.ButtonAddEvent.TabIndex = 11
        Me.ButtonAddEvent.Text = "Add Event"
        Me.ButtonAddEvent.UseVisualStyleBackColor = True
        '
        'AddEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 450)
        Me.Controls.Add(Me.ButtonAddEvent)
        Me.Controls.Add(Me.CalendarAddEvent)
        Me.Controls.Add(Me.TextBoxEventDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxEventLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxEventDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxEventName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddEvent"
        Me.Text = "Add Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxEventName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxEventDate As TextBox
    Friend WithEvents TextBoxEventDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxEventLocation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CalendarAddEvent As MonthCalendar
    Friend WithEvents ButtonAddEvent As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserSignUp))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonCancelSignUp = New System.Windows.Forms.Button()
        Me.Goal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LastNameTextbox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.GoalCombobox = New System.Windows.Forms.ComboBox()
        Me.txtBirthday1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblBirthdayFormat = New System.Windows.Forms.Label()
        Me.weighttextbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fttxtbox = New System.Windows.Forms.MaskedTextBox()
        Me.inchtxtbox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(163, 242)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 20)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(163, 277)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(234, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm Password"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(163, 312)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(234, 20)
        Me.TextBox3.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(255, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 56)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonCancelSignUp
        '
        Me.ButtonCancelSignUp.BackColor = System.Drawing.Color.White
        Me.ButtonCancelSignUp.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelSignUp.Location = New System.Drawing.Point(49, 349)
        Me.ButtonCancelSignUp.Name = "ButtonCancelSignUp"
        Me.ButtonCancelSignUp.Size = New System.Drawing.Size(178, 56)
        Me.ButtonCancelSignUp.TabIndex = 16
        Me.ButtonCancelSignUp.Text = "Cancel"
        Me.ButtonCancelSignUp.UseVisualStyleBackColor = False
        '
        'Goal
        '
        Me.Goal.AutoSize = True
        Me.Goal.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Goal.Location = New System.Drawing.Point(57, 212)
        Me.Goal.Name = "Goal"
        Me.Goal.Size = New System.Drawing.Size(101, 19)
        Me.Goal.TabIndex = 22
        Me.Goal.Text = "Primary Goal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Birthdate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Weight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(100, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Height"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(73, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 19)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Last Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(70, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 19)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "First Name"
        '
        'LastNameTextbox
        '
        Me.LastNameTextbox.Location = New System.Drawing.Point(163, 65)
        Me.LastNameTextbox.Name = "LastNameTextbox"
        Me.LastNameTextbox.Size = New System.Drawing.Size(234, 20)
        Me.LastNameTextbox.TabIndex = 2
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Location = New System.Drawing.Point(163, 30)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(234, 20)
        Me.FirstnameTextBox.TabIndex = 1
        '
        'GoalCombobox
        '
        Me.GoalCombobox.FormattingEnabled = True
        Me.GoalCombobox.Items.AddRange(New Object() {"Lose weight", "Gain weight", "Maintain weight", "Increase quality of sleep ", "Track fitness progress"})
        Me.GoalCombobox.Location = New System.Drawing.Point(163, 208)
        Me.GoalCombobox.Name = "GoalCombobox"
        Me.GoalCombobox.Size = New System.Drawing.Size(234, 21)
        Me.GoalCombobox.TabIndex = 7
        '
        'txtBirthday1
        '
        Me.txtBirthday1.Location = New System.Drawing.Point(163, 102)
        Me.txtBirthday1.Mask = "0000/00/00"
        Me.txtBirthday1.Name = "txtBirthday1"
        Me.txtBirthday1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtBirthday1.Size = New System.Drawing.Size(234, 20)
        Me.txtBirthday1.TabIndex = 3
        Me.txtBirthday1.ValidatingType = GetType(Date)
        '
        'lblBirthdayFormat
        '
        Me.lblBirthdayFormat.AutoSize = True
        Me.lblBirthdayFormat.Font = New System.Drawing.Font("Times New Roman", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdayFormat.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBirthdayFormat.Location = New System.Drawing.Point(166, 124)
        Me.lblBirthdayFormat.Name = "lblBirthdayFormat"
        Me.lblBirthdayFormat.Size = New System.Drawing.Size(60, 10)
        Me.lblBirthdayFormat.TabIndex = 320
        Me.lblBirthdayFormat.Text = "YYYY-MM-DD"
        '
        'weighttextbox
        '
        Me.weighttextbox.Location = New System.Drawing.Point(163, 138)
        Me.weighttextbox.Mask = "000"
        Me.weighttextbox.Name = "weighttextbox"
        Me.weighttextbox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.weighttextbox.Size = New System.Drawing.Size(234, 20)
        Me.weighttextbox.TabIndex = 4
        Me.weighttextbox.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(243, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 19)
        Me.Label4.TabIndex = 323
        Me.Label4.Text = "Feet"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(376, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 19)
        Me.Label10.TabIndex = 324
        Me.Label10.Text = "Inches"
        '
        'fttxtbox
        '
        Me.fttxtbox.Location = New System.Drawing.Point(163, 172)
        Me.fttxtbox.Mask = "0"
        Me.fttxtbox.Name = "fttxtbox"
        Me.fttxtbox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.fttxtbox.Size = New System.Drawing.Size(66, 20)
        Me.fttxtbox.TabIndex = 5
        Me.fttxtbox.ValidatingType = GetType(Date)
        '
        'inchtxtbox
        '
        Me.inchtxtbox.Location = New System.Drawing.Point(304, 172)
        Me.inchtxtbox.Mask = "00"
        Me.inchtxtbox.Name = "inchtxtbox"
        Me.inchtxtbox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.inchtxtbox.Size = New System.Drawing.Size(66, 20)
        Me.inchtxtbox.TabIndex = 6
        Me.inchtxtbox.ValidatingType = GetType(Date)
        '
        'UserSignUp
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(498, 410)
        Me.Controls.Add(Me.inchtxtbox)
        Me.Controls.Add(Me.fttxtbox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.weighttextbox)
        Me.Controls.Add(Me.lblBirthdayFormat)
        Me.Controls.Add(Me.txtBirthday1)
        Me.Controls.Add(Me.GoalCombobox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LastNameTextbox)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(Me.Goal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonCancelSignUp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonCancelSignUp As Button
    Friend WithEvents Goal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LastNameTextbox As TextBox
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents GoalCombobox As ComboBox
    Friend WithEvents txtBirthday1 As MaskedTextBox
    Friend WithEvents lblBirthdayFormat As Label
    Friend WithEvents weighttextbox As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents fttxtbox As MaskedTextBox
    Friend WithEvents inchtxtbox As MaskedTextBox
End Class

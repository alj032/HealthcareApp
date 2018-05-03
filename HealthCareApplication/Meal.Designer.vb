<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meal
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
        Me.mealtype = New System.Windows.Forms.ComboBox()
        Me.Goal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Instructions = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ingredients = New System.Windows.Forms.TextBox()
        Me.ButtonCancelSignUp = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mealtype
        '
        Me.mealtype.FormattingEnabled = True
        Me.mealtype.Items.AddRange(New Object() {"Breakfast", "Lunch", "Dinner"})
        Me.mealtype.Location = New System.Drawing.Point(128, 39)
        Me.mealtype.Name = "mealtype"
        Me.mealtype.Size = New System.Drawing.Size(234, 21)
        Me.mealtype.TabIndex = 1
        '
        'Goal
        '
        Me.Goal.AutoSize = True
        Me.Goal.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Goal.Location = New System.Drawing.Point(22, 40)
        Me.Goal.Name = "Goal"
        Me.Goal.Size = New System.Drawing.Size(80, 19)
        Me.Goal.TabIndex = 24
        Me.Goal.Text = "Meal Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 19)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Instructions"
        '
        'Instructions
        '
        Me.Instructions.Location = New System.Drawing.Point(128, 112)
        Me.Instructions.MaxLength = 254
        Me.Instructions.Multiline = True
        Me.Instructions.Name = "Instructions"
        Me.Instructions.Size = New System.Drawing.Size(234, 176)
        Me.Instructions.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Ingredients"
        '
        'ingredients
        '
        Me.ingredients.Location = New System.Drawing.Point(128, 76)
        Me.ingredients.Name = "ingredients"
        Me.ingredients.Size = New System.Drawing.Size(234, 20)
        Me.ingredients.TabIndex = 2
        '
        'ButtonCancelSignUp
        '
        Me.ButtonCancelSignUp.BackColor = System.Drawing.Color.White
        Me.ButtonCancelSignUp.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelSignUp.Location = New System.Drawing.Point(29, 294)
        Me.ButtonCancelSignUp.Name = "ButtonCancelSignUp"
        Me.ButtonCancelSignUp.Size = New System.Drawing.Size(178, 56)
        Me.ButtonCancelSignUp.TabIndex = 4
        Me.ButtonCancelSignUp.Text = "Cancel"
        Me.ButtonCancelSignUp.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(235, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 56)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Meal
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(442, 377)
        Me.Controls.Add(Me.ButtonCancelSignUp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ingredients)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Instructions)
        Me.Controls.Add(Me.mealtype)
        Me.Controls.Add(Me.Goal)
        Me.Name = "Meal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add meal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mealtype As ComboBox
    Friend WithEvents Goal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Instructions As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ingredients As TextBox
    Friend WithEvents ButtonCancelSignUp As Button
    Friend WithEvents Button1 As Button
End Class

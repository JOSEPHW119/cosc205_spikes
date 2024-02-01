<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.addMealsBTN = New System.Windows.Forms.Button()
        Me.fitnessBTN = New System.Windows.Forms.Button()
        Me.suggestionBTN = New System.Windows.Forms.Button()
        Me.addExerciseBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'addMealsBTN
        '
        Me.addMealsBTN.Location = New System.Drawing.Point(100, 262)
        Me.addMealsBTN.Name = "addMealsBTN"
        Me.addMealsBTN.Size = New System.Drawing.Size(230, 40)
        Me.addMealsBTN.TabIndex = 0
        Me.addMealsBTN.Text = "Add Meals"
        Me.addMealsBTN.UseVisualStyleBackColor = True
        '
        'fitnessBTN
        '
        Me.fitnessBTN.Location = New System.Drawing.Point(100, 127)
        Me.fitnessBTN.Name = "fitnessBTN"
        Me.fitnessBTN.Size = New System.Drawing.Size(230, 43)
        Me.fitnessBTN.TabIndex = 1
        Me.fitnessBTN.Text = "Fitness Info"
        Me.fitnessBTN.UseVisualStyleBackColor = True
        '
        'suggestionBTN
        '
        Me.suggestionBTN.Location = New System.Drawing.Point(532, 131)
        Me.suggestionBTN.Name = "suggestionBTN"
        Me.suggestionBTN.Size = New System.Drawing.Size(218, 39)
        Me.suggestionBTN.TabIndex = 2
        Me.suggestionBTN.Text = "Suggestions"
        Me.suggestionBTN.UseVisualStyleBackColor = True
        '
        'addExerciseBTN
        '
        Me.addExerciseBTN.Location = New System.Drawing.Point(532, 262)
        Me.addExerciseBTN.Name = "addExerciseBTN"
        Me.addExerciseBTN.Size = New System.Drawing.Size(218, 40)
        Me.addExerciseBTN.TabIndex = 3
        Me.addExerciseBTN.Text = "Add Exercise"
        Me.addExerciseBTN.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 544)
        Me.Controls.Add(Me.addExerciseBTN)
        Me.Controls.Add(Me.suggestionBTN)
        Me.Controls.Add(Me.fitnessBTN)
        Me.Controls.Add(Me.addMealsBTN)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addMealsBTN As Button
    Friend WithEvents fitnessBTN As Button
    Friend WithEvents suggestionBTN As Button
    Friend WithEvents addExerciseBTN As Button
End Class

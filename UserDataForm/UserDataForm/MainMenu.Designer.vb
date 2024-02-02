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
        Me.addMealsBTN.BackColor = System.Drawing.Color.Bisque
        Me.addMealsBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMealsBTN.Location = New System.Drawing.Point(30, 158)
        Me.addMealsBTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addMealsBTN.Name = "addMealsBTN"
        Me.addMealsBTN.Size = New System.Drawing.Size(184, 85)
        Me.addMealsBTN.TabIndex = 0
        Me.addMealsBTN.Text = "Add Meals"
        Me.addMealsBTN.UseVisualStyleBackColor = False
        '
        'fitnessBTN
        '
        Me.fitnessBTN.BackColor = System.Drawing.Color.Bisque
        Me.fitnessBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fitnessBTN.Location = New System.Drawing.Point(30, 43)
        Me.fitnessBTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.fitnessBTN.Name = "fitnessBTN"
        Me.fitnessBTN.Size = New System.Drawing.Size(184, 87)
        Me.fitnessBTN.TabIndex = 1
        Me.fitnessBTN.Text = "Fitness Info"
        Me.fitnessBTN.UseVisualStyleBackColor = False
        '
        'suggestionBTN
        '
        Me.suggestionBTN.BackColor = System.Drawing.Color.Bisque
        Me.suggestionBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suggestionBTN.Location = New System.Drawing.Point(229, 45)
        Me.suggestionBTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.suggestionBTN.Name = "suggestionBTN"
        Me.suggestionBTN.Size = New System.Drawing.Size(184, 85)
        Me.suggestionBTN.TabIndex = 2
        Me.suggestionBTN.Text = "Suggestions"
        Me.suggestionBTN.UseVisualStyleBackColor = False
        '
        'addExerciseBTN
        '
        Me.addExerciseBTN.BackColor = System.Drawing.Color.Bisque
        Me.addExerciseBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addExerciseBTN.Location = New System.Drawing.Point(229, 158)
        Me.addExerciseBTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addExerciseBTN.Name = "addExerciseBTN"
        Me.addExerciseBTN.Size = New System.Drawing.Size(184, 85)
        Me.addExerciseBTN.TabIndex = 3
        Me.addExerciseBTN.Text = "Add Exercise"
        Me.addExerciseBTN.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(442, 286)
        Me.Controls.Add(Me.addExerciseBTN)
        Me.Controls.Add(Me.suggestionBTN)
        Me.Controls.Add(Me.fitnessBTN)
        Me.Controls.Add(Me.addMealsBTN)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addMealsBTN As Button
    Friend WithEvents fitnessBTN As Button
    Friend WithEvents suggestionBTN As Button
    Friend WithEvents addExerciseBTN As Button
End Class

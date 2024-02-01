<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Suggestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Title_LBL = New System.Windows.Forms.Label()
        Me.Age_LBL = New System.Windows.Forms.Label()
        Me.BMI_TBX = New System.Windows.Forms.TextBox()
        Me.Goal_TBX = New System.Windows.Forms.TextBox()
        Me.Goal_LBL = New System.Windows.Forms.Label()
        Me.BMI_LBL = New System.Windows.Forms.Label()
        Me.Age_TBX = New System.Windows.Forms.TextBox()
        Me.InTake_LBL = New System.Windows.Forms.Label()
        Me.CalBurned_LBL = New System.Windows.Forms.Label()
        Me.CalBurned_TBX = New System.Windows.Forms.TextBox()
        Me.InTake_TBX = New System.Windows.Forms.TextBox()
        Me.Submit_BTN = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title_LBL
        '
        Me.Title_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_LBL.Location = New System.Drawing.Point(-3, 43)
        Me.Title_LBL.Name = "Title_LBL"
        Me.Title_LBL.Size = New System.Drawing.Size(410, 57)
        Me.Title_LBL.TabIndex = 1
        Me.Title_LBL.Text = "Hello! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Here are some suggestions for you:"
        Me.Title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Age_LBL
        '
        Me.Age_LBL.AutoSize = True
        Me.Age_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age_LBL.Location = New System.Drawing.Point(74, 130)
        Me.Age_LBL.Name = "Age_LBL"
        Me.Age_LBL.Size = New System.Drawing.Size(91, 18)
        Me.Age_LBL.TabIndex = 2
        Me.Age_LBL.Text = "Your Age is: "
        '
        'BMI_TBX
        '
        Me.BMI_TBX.BackColor = System.Drawing.Color.AliceBlue
        Me.BMI_TBX.Location = New System.Drawing.Point(238, 166)
        Me.BMI_TBX.Name = "BMI_TBX"
        Me.BMI_TBX.Size = New System.Drawing.Size(100, 24)
        Me.BMI_TBX.TabIndex = 4
        '
        'Goal_TBX
        '
        Me.Goal_TBX.BackColor = System.Drawing.Color.AliceBlue
        Me.Goal_TBX.Location = New System.Drawing.Point(238, 210)
        Me.Goal_TBX.Name = "Goal_TBX"
        Me.Goal_TBX.Size = New System.Drawing.Size(100, 24)
        Me.Goal_TBX.TabIndex = 5
        '
        'Goal_LBL
        '
        Me.Goal_LBL.AutoSize = True
        Me.Goal_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Goal_LBL.Location = New System.Drawing.Point(74, 213)
        Me.Goal_LBL.Name = "Goal_LBL"
        Me.Goal_LBL.Size = New System.Drawing.Size(98, 18)
        Me.Goal_LBL.TabIndex = 6
        Me.Goal_LBL.Text = "Your Goal is: "
        '
        'BMI_LBL
        '
        Me.BMI_LBL.AutoSize = True
        Me.BMI_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMI_LBL.Location = New System.Drawing.Point(74, 169)
        Me.BMI_LBL.Name = "BMI_LBL"
        Me.BMI_LBL.Size = New System.Drawing.Size(92, 18)
        Me.BMI_LBL.TabIndex = 7
        Me.BMI_LBL.Text = "Your BMI is: "
        '
        'Age_TBX
        '
        Me.Age_TBX.BackColor = System.Drawing.Color.AliceBlue
        Me.Age_TBX.Location = New System.Drawing.Point(238, 127)
        Me.Age_TBX.Name = "Age_TBX"
        Me.Age_TBX.Size = New System.Drawing.Size(100, 24)
        Me.Age_TBX.TabIndex = 3
        '
        'InTake_LBL
        '
        Me.InTake_LBL.AutoSize = True
        Me.InTake_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InTake_LBL.Location = New System.Drawing.Point(74, 261)
        Me.InTake_LBL.Name = "InTake_LBL"
        Me.InTake_LBL.Size = New System.Drawing.Size(126, 18)
        Me.InTake_LBL.TabIndex = 11
        Me.InTake_LBL.Text = "Today's intake is: "
        '
        'CalBurned_LBL
        '
        Me.CalBurned_LBL.AutoSize = True
        Me.CalBurned_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalBurned_LBL.Location = New System.Drawing.Point(74, 303)
        Me.CalBurned_LBL.Name = "CalBurned_LBL"
        Me.CalBurned_LBL.Size = New System.Drawing.Size(122, 18)
        Me.CalBurned_LBL.TabIndex = 10
        Me.CalBurned_LBL.Text = "Calories Burned: "
        '
        'CalBurned_TBX
        '
        Me.CalBurned_TBX.BackColor = System.Drawing.Color.AliceBlue
        Me.CalBurned_TBX.Location = New System.Drawing.Point(238, 300)
        Me.CalBurned_TBX.Name = "CalBurned_TBX"
        Me.CalBurned_TBX.Size = New System.Drawing.Size(100, 24)
        Me.CalBurned_TBX.TabIndex = 9
        '
        'InTake_TBX
        '
        Me.InTake_TBX.BackColor = System.Drawing.Color.AliceBlue
        Me.InTake_TBX.Location = New System.Drawing.Point(238, 255)
        Me.InTake_TBX.Name = "InTake_TBX"
        Me.InTake_TBX.Size = New System.Drawing.Size(100, 24)
        Me.InTake_TBX.TabIndex = 8
        '
        'Submit_BTN
        '
        Me.Submit_BTN.BackColor = System.Drawing.Color.Bisque
        Me.Submit_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit_BTN.Location = New System.Drawing.Point(74, 354)
        Me.Submit_BTN.Name = "Submit_BTN"
        Me.Submit_BTN.Size = New System.Drawing.Size(264, 54)
        Me.Submit_BTN.TabIndex = 12
        Me.Submit_BTN.Text = "Submit"
        Me.Submit_BTN.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Bisque
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 40)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form_Suggestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(405, 432)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Submit_BTN)
        Me.Controls.Add(Me.InTake_LBL)
        Me.Controls.Add(Me.CalBurned_LBL)
        Me.Controls.Add(Me.CalBurned_TBX)
        Me.Controls.Add(Me.InTake_TBX)
        Me.Controls.Add(Me.BMI_LBL)
        Me.Controls.Add(Me.Goal_LBL)
        Me.Controls.Add(Me.Goal_TBX)
        Me.Controls.Add(Me.BMI_TBX)
        Me.Controls.Add(Me.Age_TBX)
        Me.Controls.Add(Me.Age_LBL)
        Me.Controls.Add(Me.Title_LBL)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form_Suggestion"
        Me.Text = " Suggestions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_LBL As Label
    Friend WithEvents Age_LBL As Label
    Friend WithEvents BMI_TBX As TextBox
    Friend WithEvents Goal_TBX As TextBox
    Friend WithEvents Goal_LBL As Label
    Friend WithEvents BMI_LBL As Label
    Friend WithEvents Age_TBX As TextBox
    Friend WithEvents InTake_LBL As Label
    Friend WithEvents CalBurned_LBL As Label
    Friend WithEvents CalBurned_TBX As TextBox
    Friend WithEvents InTake_TBX As TextBox
    Friend WithEvents Submit_BTN As Button
    Friend WithEvents Button1 As Button
End Class

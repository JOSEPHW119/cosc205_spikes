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
        Me.Title_LBL.AutoSize = True
        Me.Title_LBL.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Title_LBL.Location = New System.Drawing.Point(22, 31)
        Me.Title_LBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Title_LBL.Name = "Title_LBL"
        Me.Title_LBL.Size = New System.Drawing.Size(269, 20)
        Me.Title_LBL.TabIndex = 1
        Me.Title_LBL.Text = "Hello, here are some suggestions for you:"
        '
        'Age_LBL
        '
        Me.Age_LBL.AutoSize = True
        Me.Age_LBL.Location = New System.Drawing.Point(24, 86)
        Me.Age_LBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Age_LBL.Name = "Age_LBL"
        Me.Age_LBL.Size = New System.Drawing.Size(67, 13)
        Me.Age_LBL.TabIndex = 2
        Me.Age_LBL.Text = "Your Age is: "
        '
        'BMI_TBX
        '
        Me.BMI_TBX.Location = New System.Drawing.Point(116, 112)
        Me.BMI_TBX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BMI_TBX.Name = "BMI_TBX"
        Me.BMI_TBX.Size = New System.Drawing.Size(68, 20)
        Me.BMI_TBX.TabIndex = 4
        '
        'Goal_TBX
        '
        Me.Goal_TBX.Location = New System.Drawing.Point(116, 144)
        Me.Goal_TBX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Goal_TBX.Name = "Goal_TBX"
        Me.Goal_TBX.Size = New System.Drawing.Size(68, 20)
        Me.Goal_TBX.TabIndex = 5
        '
        'Goal_LBL
        '
        Me.Goal_LBL.AutoSize = True
        Me.Goal_LBL.Location = New System.Drawing.Point(24, 146)
        Me.Goal_LBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Goal_LBL.Name = "Goal_LBL"
        Me.Goal_LBL.Size = New System.Drawing.Size(70, 13)
        Me.Goal_LBL.TabIndex = 6
        Me.Goal_LBL.Text = "Your Goal is: "
        '
        'BMI_LBL
        '
        Me.BMI_LBL.AutoSize = True
        Me.BMI_LBL.Location = New System.Drawing.Point(24, 114)
        Me.BMI_LBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BMI_LBL.Name = "BMI_LBL"
        Me.BMI_LBL.Size = New System.Drawing.Size(67, 13)
        Me.BMI_LBL.TabIndex = 7
        Me.BMI_LBL.Text = "Your BMI is: "
        '
        'Age_TBX
        '
        Me.Age_TBX.Location = New System.Drawing.Point(116, 84)
        Me.Age_TBX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Age_TBX.Name = "Age_TBX"
        Me.Age_TBX.Size = New System.Drawing.Size(68, 20)
        Me.Age_TBX.TabIndex = 3
        '
        'InTake_LBL
        '
        Me.InTake_LBL.AutoSize = True
        Me.InTake_LBL.Location = New System.Drawing.Point(23, 178)
        Me.InTake_LBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InTake_LBL.Name = "InTake_LBL"
        Me.InTake_LBL.Size = New System.Drawing.Size(92, 13)
        Me.InTake_LBL.TabIndex = 11
        Me.InTake_LBL.Text = "Today's intake is: "
        '
        'CalBurned_LBL
        '
        Me.CalBurned_LBL.AutoSize = True
        Me.CalBurned_LBL.Location = New System.Drawing.Point(24, 211)
        Me.CalBurned_LBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CalBurned_LBL.Name = "CalBurned_LBL"
        Me.CalBurned_LBL.Size = New System.Drawing.Size(87, 13)
        Me.CalBurned_LBL.TabIndex = 10
        Me.CalBurned_LBL.Text = "Calories Burned: "
        '
        'CalBurned_TBX
        '
        Me.CalBurned_TBX.Location = New System.Drawing.Point(116, 209)
        Me.CalBurned_TBX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CalBurned_TBX.Name = "CalBurned_TBX"
        Me.CalBurned_TBX.Size = New System.Drawing.Size(68, 20)
        Me.CalBurned_TBX.TabIndex = 9
        '
        'InTake_TBX
        '
        Me.InTake_TBX.Location = New System.Drawing.Point(116, 176)
        Me.InTake_TBX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.InTake_TBX.Name = "InTake_TBX"
        Me.InTake_TBX.Size = New System.Drawing.Size(68, 20)
        Me.InTake_TBX.TabIndex = 8
        '
        'Submit_BTN
        '
        Me.Submit_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Submit_BTN.Location = New System.Drawing.Point(26, 245)
        Me.Submit_BTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Submit_BTN.Name = "Submit_BTN"
        Me.Submit_BTN.Size = New System.Drawing.Size(157, 38)
        Me.Submit_BTN.TabIndex = 12
        Me.Submit_BTN.Text = "SUBMIT"
        Me.Submit_BTN.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 8)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 21)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form_Suggestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 325)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddExerciseForm
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
        Me.titleLBL = New System.Windows.Forms.Label()
        Me.addCardioLBL = New System.Windows.Forms.Label()
        Me.addCardioCBX = New System.Windows.Forms.ComboBox()
        Me.addAerobicsLBL = New System.Windows.Forms.Label()
        Me.addAerobicsCBX = New System.Windows.Forms.ComboBox()
        Me.addAnaerobicLBL = New System.Windows.Forms.Label()
        Me.addAnaerobicCBX = New System.Windows.Forms.ComboBox()
        Me.timeCardioLBL = New System.Windows.Forms.Label()
        Me.addTimeCardioNBX = New System.Windows.Forms.NumericUpDown()
        Me.timeAerobicsLBL = New System.Windows.Forms.Label()
        Me.timeAnaerobicsLBL = New System.Windows.Forms.Label()
        Me.addTimeAerobicsNBX = New System.Windows.Forms.NumericUpDown()
        Me.addTimeAnaerobicsNBX = New System.Windows.Forms.NumericUpDown()
        Me.addTimeCardioBTN = New System.Windows.Forms.Button()
        Me.addTimeAerobicsBTN = New System.Windows.Forms.Button()
        Me.summaryTBX = New System.Windows.Forms.TextBox()
        Me.submitBTN = New System.Windows.Forms.Button()
        Me.addTimeAnaerobicsBTN = New System.Windows.Forms.Button()
        Me.exerciseBackBTN = New System.Windows.Forms.Button()
        CType(Me.addTimeCardioNBX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addTimeAerobicsNBX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addTimeAnaerobicsNBX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleLBL
        '
        Me.titleLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLBL.Location = New System.Drawing.Point(181, 26)
        Me.titleLBL.Name = "titleLBL"
        Me.titleLBL.Size = New System.Drawing.Size(248, 37)
        Me.titleLBL.TabIndex = 2
        Me.titleLBL.Text = "Add Exercise"
        Me.titleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addCardioLBL
        '
        Me.addCardioLBL.AutoSize = True
        Me.addCardioLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCardioLBL.Location = New System.Drawing.Point(17, 104)
        Me.addCardioLBL.Name = "addCardioLBL"
        Me.addCardioLBL.Size = New System.Drawing.Size(75, 25)
        Me.addCardioLBL.TabIndex = 3
        Me.addCardioLBL.Text = "Cardio"
        '
        'addCardioCBX
        '
        Me.addCardioCBX.BackColor = System.Drawing.Color.AliceBlue
        Me.addCardioCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCardioCBX.FormattingEnabled = True
        Me.addCardioCBX.Items.AddRange(New Object() {"Running", "Cycling"})
        Me.addCardioCBX.Location = New System.Drawing.Point(140, 102)
        Me.addCardioCBX.Name = "addCardioCBX"
        Me.addCardioCBX.Size = New System.Drawing.Size(121, 32)
        Me.addCardioCBX.TabIndex = 5
        '
        'addAerobicsLBL
        '
        Me.addAerobicsLBL.AutoSize = True
        Me.addAerobicsLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addAerobicsLBL.Location = New System.Drawing.Point(17, 189)
        Me.addAerobicsLBL.Name = "addAerobicsLBL"
        Me.addAerobicsLBL.Size = New System.Drawing.Size(96, 25)
        Me.addAerobicsLBL.TabIndex = 6
        Me.addAerobicsLBL.Text = "Aerobics"
        '
        'addAerobicsCBX
        '
        Me.addAerobicsCBX.BackColor = System.Drawing.Color.AliceBlue
        Me.addAerobicsCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addAerobicsCBX.FormattingEnabled = True
        Me.addAerobicsCBX.Items.AddRange(New Object() {"Swimming", "Jump Rope", "Elliptical", "Walking", "Hiking"})
        Me.addAerobicsCBX.Location = New System.Drawing.Point(140, 187)
        Me.addAerobicsCBX.Name = "addAerobicsCBX"
        Me.addAerobicsCBX.Size = New System.Drawing.Size(121, 32)
        Me.addAerobicsCBX.TabIndex = 7
        '
        'addAnaerobicLBL
        '
        Me.addAnaerobicLBL.AutoSize = True
        Me.addAnaerobicLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addAnaerobicLBL.Location = New System.Drawing.Point(17, 275)
        Me.addAnaerobicLBL.Name = "addAnaerobicLBL"
        Me.addAnaerobicLBL.Size = New System.Drawing.Size(120, 25)
        Me.addAnaerobicLBL.TabIndex = 8
        Me.addAnaerobicLBL.Text = "Anaerobics"
        '
        'addAnaerobicCBX
        '
        Me.addAnaerobicCBX.BackColor = System.Drawing.Color.AliceBlue
        Me.addAnaerobicCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addAnaerobicCBX.FormattingEnabled = True
        Me.addAnaerobicCBX.Items.AddRange(New Object() {"Weightlifting", "Sprinting", "HIIT training"})
        Me.addAnaerobicCBX.Location = New System.Drawing.Point(140, 273)
        Me.addAnaerobicCBX.Name = "addAnaerobicCBX"
        Me.addAnaerobicCBX.Size = New System.Drawing.Size(121, 32)
        Me.addAnaerobicCBX.TabIndex = 9
        '
        'timeCardioLBL
        '
        Me.timeCardioLBL.AutoSize = True
        Me.timeCardioLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeCardioLBL.Location = New System.Drawing.Point(277, 104)
        Me.timeCardioLBL.Name = "timeCardioLBL"
        Me.timeCardioLBL.Size = New System.Drawing.Size(119, 25)
        Me.timeCardioLBL.TabIndex = 10
        Me.timeCardioLBL.Text = "Time (min):"
        '
        'addTimeCardioNBX
        '
        Me.addTimeCardioNBX.BackColor = System.Drawing.Color.AliceBlue
        Me.addTimeCardioNBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTimeCardioNBX.Location = New System.Drawing.Point(402, 103)
        Me.addTimeCardioNBX.Name = "addTimeCardioNBX"
        Me.addTimeCardioNBX.Size = New System.Drawing.Size(73, 29)
        Me.addTimeCardioNBX.TabIndex = 13
        '
        'timeAerobicsLBL
        '
        Me.timeAerobicsLBL.AutoSize = True
        Me.timeAerobicsLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeAerobicsLBL.Location = New System.Drawing.Point(277, 189)
        Me.timeAerobicsLBL.Name = "timeAerobicsLBL"
        Me.timeAerobicsLBL.Size = New System.Drawing.Size(119, 25)
        Me.timeAerobicsLBL.TabIndex = 14
        Me.timeAerobicsLBL.Text = "Time (min):"
        '
        'timeAnaerobicsLBL
        '
        Me.timeAnaerobicsLBL.AutoSize = True
        Me.timeAnaerobicsLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeAnaerobicsLBL.Location = New System.Drawing.Point(277, 275)
        Me.timeAnaerobicsLBL.Name = "timeAnaerobicsLBL"
        Me.timeAnaerobicsLBL.Size = New System.Drawing.Size(119, 25)
        Me.timeAnaerobicsLBL.TabIndex = 15
        Me.timeAnaerobicsLBL.Text = "Time (min):"
        '
        'addTimeAerobicsNBX
        '
        Me.addTimeAerobicsNBX.BackColor = System.Drawing.Color.AliceBlue
        Me.addTimeAerobicsNBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTimeAerobicsNBX.Location = New System.Drawing.Point(402, 188)
        Me.addTimeAerobicsNBX.Name = "addTimeAerobicsNBX"
        Me.addTimeAerobicsNBX.Size = New System.Drawing.Size(73, 29)
        Me.addTimeAerobicsNBX.TabIndex = 16
        '
        'addTimeAnaerobicsNBX
        '
        Me.addTimeAnaerobicsNBX.BackColor = System.Drawing.Color.AliceBlue
        Me.addTimeAnaerobicsNBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTimeAnaerobicsNBX.Location = New System.Drawing.Point(402, 274)
        Me.addTimeAnaerobicsNBX.Name = "addTimeAnaerobicsNBX"
        Me.addTimeAnaerobicsNBX.Size = New System.Drawing.Size(73, 29)
        Me.addTimeAnaerobicsNBX.TabIndex = 17
        '
        'addTimeCardioBTN
        '
        Me.addTimeCardioBTN.BackColor = System.Drawing.Color.Bisque
        Me.addTimeCardioBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTimeCardioBTN.Location = New System.Drawing.Point(492, 102)
        Me.addTimeCardioBTN.Name = "addTimeCardioBTN"
        Me.addTimeCardioBTN.Size = New System.Drawing.Size(90, 30)
        Me.addTimeCardioBTN.TabIndex = 18
        Me.addTimeCardioBTN.Text = "Add"
        Me.addTimeCardioBTN.UseVisualStyleBackColor = False
        '
        'addTimeAerobicsBTN
        '
        Me.addTimeAerobicsBTN.BackColor = System.Drawing.Color.Bisque
        Me.addTimeAerobicsBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTimeAerobicsBTN.Location = New System.Drawing.Point(492, 187)
        Me.addTimeAerobicsBTN.Name = "addTimeAerobicsBTN"
        Me.addTimeAerobicsBTN.Size = New System.Drawing.Size(90, 30)
        Me.addTimeAerobicsBTN.TabIndex = 19
        Me.addTimeAerobicsBTN.Text = "Add"
        Me.addTimeAerobicsBTN.UseVisualStyleBackColor = False
        '
        'summaryTBX
        '
        Me.summaryTBX.BackColor = System.Drawing.Color.AliceBlue
        Me.summaryTBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryTBX.Location = New System.Drawing.Point(22, 330)
        Me.summaryTBX.Multiline = True
        Me.summaryTBX.Name = "summaryTBX"
        Me.summaryTBX.Size = New System.Drawing.Size(560, 148)
        Me.summaryTBX.TabIndex = 21
        '
        'submitBTN
        '
        Me.submitBTN.BackColor = System.Drawing.Color.Bisque
        Me.submitBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitBTN.Location = New System.Drawing.Point(340, 498)
        Me.submitBTN.Name = "submitBTN"
        Me.submitBTN.Size = New System.Drawing.Size(242, 59)
        Me.submitBTN.TabIndex = 22
        Me.submitBTN.Text = "Submit"
        Me.submitBTN.UseVisualStyleBackColor = False
        '
        'addTimeAnaerobicsBTN
        '
        Me.addTimeAnaerobicsBTN.BackColor = System.Drawing.Color.Bisque
        Me.addTimeAnaerobicsBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTimeAnaerobicsBTN.Location = New System.Drawing.Point(492, 273)
        Me.addTimeAnaerobicsBTN.Name = "addTimeAnaerobicsBTN"
        Me.addTimeAnaerobicsBTN.Size = New System.Drawing.Size(90, 30)
        Me.addTimeAnaerobicsBTN.TabIndex = 20
        Me.addTimeAnaerobicsBTN.Text = "Add"
        Me.addTimeAnaerobicsBTN.UseVisualStyleBackColor = False
        '
        'exerciseBackBTN
        '
        Me.exerciseBackBTN.BackColor = System.Drawing.Color.Bisque
        Me.exerciseBackBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exerciseBackBTN.Location = New System.Drawing.Point(11, 10)
        Me.exerciseBackBTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.exerciseBackBTN.Name = "exerciseBackBTN"
        Me.exerciseBackBTN.Size = New System.Drawing.Size(102, 53)
        Me.exerciseBackBTN.TabIndex = 23
        Me.exerciseBackBTN.Text = "Back"
        Me.exerciseBackBTN.UseVisualStyleBackColor = False
        '
        'AddExerciseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(596, 567)
        Me.Controls.Add(Me.exerciseBackBTN)
        Me.Controls.Add(Me.submitBTN)
        Me.Controls.Add(Me.summaryTBX)
        Me.Controls.Add(Me.addTimeAnaerobicsBTN)
        Me.Controls.Add(Me.addTimeAerobicsBTN)
        Me.Controls.Add(Me.addTimeCardioBTN)
        Me.Controls.Add(Me.addTimeAnaerobicsNBX)
        Me.Controls.Add(Me.addTimeAerobicsNBX)
        Me.Controls.Add(Me.timeAnaerobicsLBL)
        Me.Controls.Add(Me.timeAerobicsLBL)
        Me.Controls.Add(Me.addTimeCardioNBX)
        Me.Controls.Add(Me.timeCardioLBL)
        Me.Controls.Add(Me.addAnaerobicCBX)
        Me.Controls.Add(Me.addAnaerobicLBL)
        Me.Controls.Add(Me.addAerobicsCBX)
        Me.Controls.Add(Me.addAerobicsLBL)
        Me.Controls.Add(Me.addCardioCBX)
        Me.Controls.Add(Me.addCardioLBL)
        Me.Controls.Add(Me.titleLBL)
        Me.Name = "AddExerciseForm"
        Me.Text = "Add Exercise"
        CType(Me.addTimeCardioNBX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addTimeAerobicsNBX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addTimeAnaerobicsNBX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleLBL As Label
    Friend WithEvents addCardioLBL As Label
    Friend WithEvents addCardioCBX As ComboBox
    Friend WithEvents addAerobicsLBL As Label
    Friend WithEvents addAerobicsCBX As ComboBox
    Friend WithEvents addAnaerobicLBL As Label
    Friend WithEvents addAnaerobicCBX As ComboBox
    Friend WithEvents timeCardioLBL As Label
    Friend WithEvents addTimeCardioNBX As NumericUpDown
    Friend WithEvents timeAerobicsLBL As Label
    Friend WithEvents timeAnaerobicsLBL As Label
    Friend WithEvents addTimeAerobicsNBX As NumericUpDown
    Friend WithEvents addTimeAnaerobicsNBX As NumericUpDown
    Friend WithEvents addTimeCardioBTN As Button
    Friend WithEvents addTimeAerobicsBTN As Button
    Friend WithEvents summaryTBX As TextBox
    Friend WithEvents submitBTN As Button
    Friend WithEvents addTimeAnaerobicsBTN As Button
    Friend WithEvents exerciseBackBTN As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddExerciseForm
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
        Me.titleLBL = New System.Windows.Forms.Label()
        Me.addCardioLBL = New System.Windows.Forms.Label()
        Me.addCardioCBX = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'titleLBL
        '
        Me.titleLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLBL.Location = New System.Drawing.Point(173, 9)
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
        Me.addCardioLBL.Location = New System.Drawing.Point(26, 63)
        Me.addCardioLBL.Name = "addCardioLBL"
        Me.addCardioLBL.Size = New System.Drawing.Size(75, 25)
        Me.addCardioLBL.TabIndex = 3
        Me.addCardioLBL.Text = "Cardio"
        '
        'addCardioCBX
        '
        Me.addCardioCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCardioCBX.FormattingEnabled = True
        Me.addCardioCBX.Items.AddRange(New Object() {"Running", "Cycling"})
        Me.addCardioCBX.Location = New System.Drawing.Point(117, 61)
        Me.addCardioCBX.Name = "addCardioCBX"
        Me.addCardioCBX.Size = New System.Drawing.Size(121, 32)
        Me.addCardioCBX.TabIndex = 5
        '
        'AddExerciseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 470)
        Me.Controls.Add(Me.addCardioCBX)
        Me.Controls.Add(Me.addCardioLBL)
        Me.Controls.Add(Me.titleLBL)
        Me.Name = "AddExerciseForm"
        Me.Text = "Add Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleLBL As Label
    Friend WithEvents addCardioLBL As Label
    Friend WithEvents addCardioCBX As ComboBox
End Class

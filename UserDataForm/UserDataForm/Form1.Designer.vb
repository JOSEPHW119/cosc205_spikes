<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.submitBTN = New System.Windows.Forms.Button()
        Me.infoLBL = New System.Windows.Forms.Label()
        Me.fitnessLBL = New System.Windows.Forms.Label()
        Me.goalsCBX = New System.Windows.Forms.ComboBox()
        Me.goalsLBL = New System.Windows.Forms.Label()
        Me.ageTBX = New System.Windows.Forms.TextBox()
        Me.ageLBL = New System.Windows.Forms.Label()
        Me.weightTBX = New System.Windows.Forms.TextBox()
        Me.weightLBL = New System.Windows.Forms.Label()
        Me.heightTBX = New System.Windows.Forms.TextBox()
        Me.heightLBL = New System.Windows.Forms.Label()
        Me.genderCBX = New System.Windows.Forms.ComboBox()
        Me.genderLBL = New System.Windows.Forms.Label()
        Me.emailTBX = New System.Windows.Forms.TextBox()
        Me.emailLBL = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FitnessAppDBDataSet = New UserDataForm.FitnessAppDBDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New UserDataForm.FitnessAppDBDataSetTableAdapters.UsersTableAdapter()
        CType(Me.FitnessAppDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'submitBTN
        '
        Me.submitBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitBTN.Location = New System.Drawing.Point(499, 622)
        Me.submitBTN.Name = "submitBTN"
        Me.submitBTN.Size = New System.Drawing.Size(214, 63)
        Me.submitBTN.TabIndex = 7
        Me.submitBTN.Text = "Submit"
        Me.submitBTN.UseVisualStyleBackColor = True
        '
        'infoLBL
        '
        Me.infoLBL.AutoSize = True
        Me.infoLBL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.infoLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoLBL.Location = New System.Drawing.Point(75, 129)
        Me.infoLBL.Name = "infoLBL"
        Me.infoLBL.Size = New System.Drawing.Size(591, 24)
        Me.infoLBL.TabIndex = 30
        Me.infoLBL.Text = "Please fill out the following fields. When you are finished, click Submit."
        '
        'fitnessLBL
        '
        Me.fitnessLBL.AutoSize = True
        Me.fitnessLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fitnessLBL.Location = New System.Drawing.Point(69, 67)
        Me.fitnessLBL.Name = "fitnessLBL"
        Me.fitnessLBL.Size = New System.Drawing.Size(289, 39)
        Me.fitnessLBL.TabIndex = 29
        Me.fitnessLBL.Text = "User Fitness Data"
        '
        'goalsCBX
        '
        Me.goalsCBX.FormattingEnabled = True
        Me.goalsCBX.Items.AddRange(New Object() {"Weight Loss", "Muscle Gain"})
        Me.goalsCBX.Location = New System.Drawing.Point(275, 584)
        Me.goalsCBX.Name = "goalsCBX"
        Me.goalsCBX.Size = New System.Drawing.Size(181, 37)
        Me.goalsCBX.TabIndex = 6
        '
        'goalsLBL
        '
        Me.goalsLBL.AutoSize = True
        Me.goalsLBL.Location = New System.Drawing.Point(100, 587)
        Me.goalsLBL.Name = "goalsLBL"
        Me.goalsLBL.Size = New System.Drawing.Size(207, 29)
        Me.goalsLBL.TabIndex = 27
        Me.goalsLBL.Text = "Goals (Choose 1):"
        '
        'ageTBX
        '
        Me.ageTBX.Location = New System.Drawing.Point(275, 268)
        Me.ageTBX.Name = "ageTBX"
        Me.ageTBX.Size = New System.Drawing.Size(181, 34)
        Me.ageTBX.TabIndex = 2
        '
        'ageLBL
        '
        Me.ageLBL.AutoSize = True
        Me.ageLBL.Location = New System.Drawing.Point(100, 271)
        Me.ageLBL.Name = "ageLBL"
        Me.ageLBL.Size = New System.Drawing.Size(62, 29)
        Me.ageLBL.TabIndex = 25
        Me.ageLBL.Text = "Age:"
        '
        'weightTBX
        '
        Me.weightTBX.Location = New System.Drawing.Point(275, 420)
        Me.weightTBX.Name = "weightTBX"
        Me.weightTBX.Size = New System.Drawing.Size(181, 34)
        Me.weightTBX.TabIndex = 4
        '
        'weightLBL
        '
        Me.weightLBL.AutoSize = True
        Me.weightLBL.Location = New System.Drawing.Point(100, 423)
        Me.weightLBL.Name = "weightLBL"
        Me.weightLBL.Size = New System.Drawing.Size(94, 29)
        Me.weightLBL.TabIndex = 23
        Me.weightLBL.Text = "Weight:"
        '
        'heightTBX
        '
        Me.heightTBX.Location = New System.Drawing.Point(275, 343)
        Me.heightTBX.Name = "heightTBX"
        Me.heightTBX.Size = New System.Drawing.Size(181, 34)
        Me.heightTBX.TabIndex = 3
        '
        'heightLBL
        '
        Me.heightLBL.AutoSize = True
        Me.heightLBL.Location = New System.Drawing.Point(100, 346)
        Me.heightLBL.Name = "heightLBL"
        Me.heightLBL.Size = New System.Drawing.Size(89, 29)
        Me.heightLBL.TabIndex = 21
        Me.heightLBL.Text = "Height:"
        '
        'genderCBX
        '
        Me.genderCBX.FormattingEnabled = True
        Me.genderCBX.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.genderCBX.Location = New System.Drawing.Point(275, 499)
        Me.genderCBX.Name = "genderCBX"
        Me.genderCBX.Size = New System.Drawing.Size(181, 37)
        Me.genderCBX.TabIndex = 5
        '
        'genderLBL
        '
        Me.genderLBL.AutoSize = True
        Me.genderLBL.Location = New System.Drawing.Point(100, 502)
        Me.genderLBL.Name = "genderLBL"
        Me.genderLBL.Size = New System.Drawing.Size(100, 29)
        Me.genderLBL.TabIndex = 19
        Me.genderLBL.Text = "Gender:"
        '
        'emailTBX
        '
        Me.emailTBX.Location = New System.Drawing.Point(275, 191)
        Me.emailTBX.Name = "emailTBX"
        Me.emailTBX.Size = New System.Drawing.Size(299, 34)
        Me.emailTBX.TabIndex = 1
        '
        'emailLBL
        '
        Me.emailLBL.AutoSize = True
        Me.emailLBL.Location = New System.Drawing.Point(100, 194)
        Me.emailLBL.Name = "emailLBL"
        Me.emailLBL.Size = New System.Drawing.Size(80, 29)
        Me.emailLBL.TabIndex = 17
        Me.emailLBL.Text = "Email:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.UsersBindingSource
        Me.ComboBox1.DisplayMember = "email"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(574, 268)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 37)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.TabStop = False
        Me.ComboBox1.ValueMember = "weight_kg"
        '
        'FitnessAppDBDataSet
        '
        Me.FitnessAppDBDataSet.DataSetName = "FitnessAppDBDataSet"
        Me.FitnessAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.FitnessAppDBDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 753)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.submitBTN)
        Me.Controls.Add(Me.infoLBL)
        Me.Controls.Add(Me.fitnessLBL)
        Me.Controls.Add(Me.goalsCBX)
        Me.Controls.Add(Me.goalsLBL)
        Me.Controls.Add(Me.ageTBX)
        Me.Controls.Add(Me.ageLBL)
        Me.Controls.Add(Me.weightTBX)
        Me.Controls.Add(Me.weightLBL)
        Me.Controls.Add(Me.heightTBX)
        Me.Controls.Add(Me.heightLBL)
        Me.Controls.Add(Me.genderCBX)
        Me.Controls.Add(Me.genderLBL)
        Me.Controls.Add(Me.emailTBX)
        Me.Controls.Add(Me.emailLBL)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.FitnessAppDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submitBTN As Button
    Friend WithEvents infoLBL As Label
    Friend WithEvents fitnessLBL As Label
    Friend WithEvents goalsCBX As ComboBox
    Friend WithEvents goalsLBL As Label
    Friend WithEvents ageTBX As TextBox
    Friend WithEvents ageLBL As Label
    Friend WithEvents weightTBX As TextBox
    Friend WithEvents weightLBL As Label
    Friend WithEvents heightTBX As TextBox
    Friend WithEvents heightLBL As Label
    Friend WithEvents genderCBX As ComboBox
    Friend WithEvents genderLBL As Label
    Friend WithEvents emailTBX As TextBox
    Friend WithEvents emailLBL As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FitnessAppDBDataSet As FitnessAppDBDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As FitnessAppDBDataSetTableAdapters.UsersTableAdapter
End Class

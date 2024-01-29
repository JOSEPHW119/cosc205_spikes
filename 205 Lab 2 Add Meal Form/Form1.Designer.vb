<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.proteinLBL = New System.Windows.Forms.Label()
        Me.MealsTBX = New System.Windows.Forms.TextBox()
        Me.ProtienCBX = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VegCBX = New System.Windows.Forms.ComboBox()
        Me.vegLBL = New System.Windows.Forms.Label()
        Me.grainLBL = New System.Windows.Forms.Label()
        Me.fruitsLBL = New System.Windows.Forms.Label()
        Me.dairyLBL = New System.Windows.Forms.Label()
        Me.fatsLBL = New System.Windows.Forms.Label()
        Me.GrainCBX = New System.Windows.Forms.ComboBox()
        Me.DairyCBX = New System.Windows.Forms.ComboBox()
        Me.FatsCBX = New System.Windows.Forms.ComboBox()
        Me.FruitCBX = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'proteinLBL
        '
        Me.proteinLBL.AutoSize = True
        Me.proteinLBL.Location = New System.Drawing.Point(80, 92)
        Me.proteinLBL.Name = "proteinLBL"
        Me.proteinLBL.Size = New System.Drawing.Size(107, 33)
        Me.proteinLBL.TabIndex = 0
        Me.proteinLBL.Text = "Protein"
        '
        'MealsTBX
        '
        Me.MealsTBX.Location = New System.Drawing.Point(498, 92)
        Me.MealsTBX.Multiline = True
        Me.MealsTBX.Name = "MealsTBX"
        Me.MealsTBX.Size = New System.Drawing.Size(287, 326)
        Me.MealsTBX.TabIndex = 1
        '
        'ProtienCBX
        '
        Me.ProtienCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProtienCBX.FormattingEnabled = True
        Me.ProtienCBX.Items.AddRange(New Object() {"Chicken", "Salmon", "Tofu", "Lentils", "Turkey", "Shrimp", "Eggs", "Greek Yogurt", "Quinoa", "Beef"})
        Me.ProtienCBX.Location = New System.Drawing.Point(77, 128)
        Me.ProtienCBX.Name = "ProtienCBX"
        Me.ProtienCBX.Size = New System.Drawing.Size(105, 37)
        Me.ProtienCBX.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(513, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Meals to be Added"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select Ingredients"
        '
        'VegCBX
        '
        Me.VegCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VegCBX.FormattingEnabled = True
        Me.VegCBX.Items.AddRange(New Object() {"Broccoli", "Spinach", "Bell peppers (red, green, yellow)", "Zucchini", "Carrots", "Kale", "Asparagus", "Brussels sprouts", "Cauliflower", "Tomatoes"})
        Me.VegCBX.Location = New System.Drawing.Point(288, 128)
        Me.VegCBX.Name = "VegCBX"
        Me.VegCBX.Size = New System.Drawing.Size(105, 37)
        Me.VegCBX.TabIndex = 5
        '
        'vegLBL
        '
        Me.vegLBL.AutoSize = True
        Me.vegLBL.Location = New System.Drawing.Point(264, 92)
        Me.vegLBL.Name = "vegLBL"
        Me.vegLBL.Size = New System.Drawing.Size(160, 33)
        Me.vegLBL.TabIndex = 6
        Me.vegLBL.Text = "Vegetables"
        '
        'grainLBL
        '
        Me.grainLBL.AutoSize = True
        Me.grainLBL.Location = New System.Drawing.Point(80, 199)
        Me.grainLBL.Name = "grainLBL"
        Me.grainLBL.Size = New System.Drawing.Size(102, 33)
        Me.grainLBL.TabIndex = 7
        Me.grainLBL.Text = "Grains"
        '
        'fruitsLBL
        '
        Me.fruitsLBL.AutoSize = True
        Me.fruitsLBL.Location = New System.Drawing.Point(295, 199)
        Me.fruitsLBL.Name = "fruitsLBL"
        Me.fruitsLBL.Size = New System.Drawing.Size(89, 33)
        Me.fruitsLBL.TabIndex = 8
        Me.fruitsLBL.Text = "Fruits"
        '
        'dairyLBL
        '
        Me.dairyLBL.AutoSize = True
        Me.dairyLBL.Location = New System.Drawing.Point(83, 338)
        Me.dairyLBL.Name = "dairyLBL"
        Me.dairyLBL.Size = New System.Drawing.Size(84, 33)
        Me.dairyLBL.TabIndex = 9
        Me.dairyLBL.Text = "Dairy"
        '
        'fatsLBL
        '
        Me.fatsLBL.AutoSize = True
        Me.fatsLBL.Location = New System.Drawing.Point(264, 338)
        Me.fatsLBL.Name = "fatsLBL"
        Me.fatsLBL.Size = New System.Drawing.Size(179, 33)
        Me.fatsLBL.TabIndex = 10
        Me.fatsLBL.Text = "Healthy Fats"
        '
        'GrainCBX
        '
        Me.GrainCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainCBX.FormattingEnabled = True
        Me.GrainCBX.Items.AddRange(New Object() {"Brown rice", "Quinoa", "Whole wheat pasta", "Barley", "Oats", "Buckwheat", "Couscous"})
        Me.GrainCBX.Location = New System.Drawing.Point(77, 252)
        Me.GrainCBX.Name = "GrainCBX"
        Me.GrainCBX.Size = New System.Drawing.Size(105, 37)
        Me.GrainCBX.TabIndex = 11
        '
        'DairyCBX
        '
        Me.DairyCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DairyCBX.FormattingEnabled = True
        Me.DairyCBX.Items.AddRange(New Object() {"Greek yogurt", "Cottage cheese", "Milk (dairy or plant-based)", "Cheese (feta, mozzarella, parmesan)", "Soy milk", "Almond milk", "Coconut milk", "Yogurt alternatives (almond yogurt, coconut yogurt)"})
        Me.DairyCBX.Location = New System.Drawing.Point(77, 392)
        Me.DairyCBX.Name = "DairyCBX"
        Me.DairyCBX.Size = New System.Drawing.Size(105, 37)
        Me.DairyCBX.TabIndex = 13
        '
        'FatsCBX
        '
        Me.FatsCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatsCBX.FormattingEnabled = True
        Me.FatsCBX.Items.AddRange(New Object() {"Avocado", "Olive oil", "Nuts (almonds, walnuts, pistachios)", "Seeds (chia seeds, flaxseeds, sunflower seeds)", "Coconut oil", "Fatty fish (salmon, mackerel)", "Nut butters (peanut butter, almond butter)", "Olives"})
        Me.FatsCBX.Location = New System.Drawing.Point(288, 392)
        Me.FatsCBX.Name = "FatsCBX"
        Me.FatsCBX.Size = New System.Drawing.Size(105, 37)
        Me.FatsCBX.TabIndex = 14
        '
        'FruitCBX
        '
        Me.FruitCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FruitCBX.FormattingEnabled = True
        Me.FruitCBX.Items.AddRange(New Object() {"Berries (strawberries, blueberries, raspberries)", "Apples", "Bananas", "Oranges", "Mango", "Pineapple", "Grapes", "Kiwi", "Pomegranate seeds", "Watermelon"})
        Me.FruitCBX.Location = New System.Drawing.Point(288, 252)
        Me.FruitCBX.Name = "FruitCBX"
        Me.FruitCBX.Size = New System.Drawing.Size(105, 37)
        Me.FruitCBX.TabIndex = 15
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.FruitCBX)
        Me.Controls.Add(Me.FatsCBX)
        Me.Controls.Add(Me.DairyCBX)
        Me.Controls.Add(Me.GrainCBX)
        Me.Controls.Add(Me.fatsLBL)
        Me.Controls.Add(Me.dairyLBL)
        Me.Controls.Add(Me.fruitsLBL)
        Me.Controls.Add(Me.grainLBL)
        Me.Controls.Add(Me.vegLBL)
        Me.Controls.Add(Me.VegCBX)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProtienCBX)
        Me.Controls.Add(Me.MealsTBX)
        Me.Controls.Add(Me.proteinLBL)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "form1"
        Me.Text = "Meal Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents proteinLBL As Label
    Friend WithEvents MealsTBX As TextBox
    Friend WithEvents ProtienCBX As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents VegCBX As ComboBox
    Friend WithEvents vegLBL As Label
    Friend WithEvents grainLBL As Label
    Friend WithEvents fruitsLBL As Label
    Friend WithEvents dairyLBL As Label
    Friend WithEvents fatsLBL As Label
    Friend WithEvents GrainCBX As ComboBox
    Friend WithEvents DairyCBX As ComboBox
    Friend WithEvents FatsCBX As ComboBox
    Friend WithEvents FruitCBX As ComboBox
End Class

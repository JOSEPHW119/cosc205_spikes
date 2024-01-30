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
        Me.ProteinCBX = New System.Windows.Forms.ComboBox()
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
        Me.FatCBX = New System.Windows.Forms.ComboBox()
        Me.FruitCBX = New System.Windows.Forms.ComboBox()
        Me.submitBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'proteinLBL
        '
        Me.proteinLBL.AutoSize = True
        Me.proteinLBL.Location = New System.Drawing.Point(111, 89)
        Me.proteinLBL.Name = "proteinLBL"
        Me.proteinLBL.Size = New System.Drawing.Size(107, 33)
        Me.proteinLBL.TabIndex = 0
        Me.proteinLBL.Text = "Protein"
        '
        'MealsTBX
        '
        Me.MealsTBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MealsTBX.Location = New System.Drawing.Point(538, 92)
        Me.MealsTBX.Multiline = True
        Me.MealsTBX.Name = "MealsTBX"
        Me.MealsTBX.Size = New System.Drawing.Size(287, 279)
        Me.MealsTBX.TabIndex = 1
        '
        'ProteinCBX
        '
        Me.ProteinCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProteinCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProteinCBX.FormattingEnabled = True
        Me.ProteinCBX.Items.AddRange(New Object() {"Chicken", "Salmon", "Tofu", "Lentils", "Turkey", "Shrimp", "Eggs", "Greek Yogurt", "Quinoa", "Beef"})
        Me.ProteinCBX.Location = New System.Drawing.Point(47, 128)
        Me.ProteinCBX.Name = "ProteinCBX"
        Me.ProteinCBX.Size = New System.Drawing.Size(200, 37)
        Me.ProteinCBX.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(595, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Meals to be Added"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select Ingredients"
        '
        'VegCBX
        '
        Me.VegCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VegCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VegCBX.FormattingEnabled = True
        Me.VegCBX.Items.AddRange(New Object() {"Broccoli", "Spinach", "Bell peppers", "Zucchini", "Carrots", "Kale", "Asparagus", "Brussels sprouts", "Cauliflower", "Tomatoes"})
        Me.VegCBX.Location = New System.Drawing.Point(288, 128)
        Me.VegCBX.Name = "VegCBX"
        Me.VegCBX.Size = New System.Drawing.Size(200, 37)
        Me.VegCBX.TabIndex = 5
        '
        'vegLBL
        '
        Me.vegLBL.AutoSize = True
        Me.vegLBL.Location = New System.Drawing.Point(337, 89)
        Me.vegLBL.Name = "vegLBL"
        Me.vegLBL.Size = New System.Drawing.Size(160, 33)
        Me.vegLBL.TabIndex = 6
        Me.vegLBL.Text = "Vegetables"
        '
        'grainLBL
        '
        Me.grainLBL.AutoSize = True
        Me.grainLBL.Location = New System.Drawing.Point(116, 206)
        Me.grainLBL.Name = "grainLBL"
        Me.grainLBL.Size = New System.Drawing.Size(102, 33)
        Me.grainLBL.TabIndex = 7
        Me.grainLBL.Text = "Grains"
        '
        'fruitsLBL
        '
        Me.fruitsLBL.AutoSize = True
        Me.fruitsLBL.Location = New System.Drawing.Point(359, 206)
        Me.fruitsLBL.Name = "fruitsLBL"
        Me.fruitsLBL.Size = New System.Drawing.Size(89, 33)
        Me.fruitsLBL.TabIndex = 8
        Me.fruitsLBL.Text = "Fruits"
        '
        'dairyLBL
        '
        Me.dairyLBL.AutoSize = True
        Me.dairyLBL.Location = New System.Drawing.Point(123, 344)
        Me.dairyLBL.Name = "dairyLBL"
        Me.dairyLBL.Size = New System.Drawing.Size(84, 33)
        Me.dairyLBL.TabIndex = 9
        Me.dairyLBL.Text = "Dairy"
        '
        'fatsLBL
        '
        Me.fatsLBL.AutoSize = True
        Me.fatsLBL.Location = New System.Drawing.Point(329, 344)
        Me.fatsLBL.Name = "fatsLBL"
        Me.fatsLBL.Size = New System.Drawing.Size(179, 33)
        Me.fatsLBL.TabIndex = 10
        Me.fatsLBL.Text = "Healthy Fats"
        '
        'GrainCBX
        '
        Me.GrainCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GrainCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainCBX.FormattingEnabled = True
        Me.GrainCBX.Items.AddRange(New Object() {"Brown rice", "Quinoa", "Whole wheat pasta", "Barley", "Oats", "Buckwheat", "Couscous"})
        Me.GrainCBX.Location = New System.Drawing.Point(47, 252)
        Me.GrainCBX.Name = "GrainCBX"
        Me.GrainCBX.Size = New System.Drawing.Size(200, 37)
        Me.GrainCBX.TabIndex = 11
        '
        'DairyCBX
        '
        Me.DairyCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DairyCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DairyCBX.FormattingEnabled = True
        Me.DairyCBX.Items.AddRange(New Object() {"Greek yogurt", "Cottage cheese", "Milk (dairy or plant-based)", "Cheese (feta, mozzarella, parmesan)", "Soy milk", "Almond milk", "Coconut milk", "Yogurt alternatives (almond yogurt, coconut yogurt)"})
        Me.DairyCBX.Location = New System.Drawing.Point(47, 392)
        Me.DairyCBX.Name = "DairyCBX"
        Me.DairyCBX.Size = New System.Drawing.Size(200, 37)
        Me.DairyCBX.TabIndex = 13
        '
        'FatCBX
        '
        Me.FatCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FatCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatCBX.FormattingEnabled = True
        Me.FatCBX.Items.AddRange(New Object() {"Avocado", "Olive oil", "Nuts (almonds, walnuts, pistachios)", "Seeds (chia seeds, flaxseeds, sunflower seeds)", "Coconut oil", "Fatty fish (salmon, mackerel)", "Nut butters (peanut butter, almond butter)", "Olives"})
        Me.FatCBX.Location = New System.Drawing.Point(288, 392)
        Me.FatCBX.Name = "FatCBX"
        Me.FatCBX.Size = New System.Drawing.Size(200, 37)
        Me.FatCBX.TabIndex = 14
        '
        'FruitCBX
        '
        Me.FruitCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FruitCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FruitCBX.FormattingEnabled = True
        Me.FruitCBX.Items.AddRange(New Object() {"Berries (strawberries, blueberries, raspberries)", "Apples", "Bananas", "Oranges", "Mango", "Pineapple", "Grapes", "Kiwi", "Pomegranate seeds", "Watermelon"})
        Me.FruitCBX.Location = New System.Drawing.Point(288, 252)
        Me.FruitCBX.Name = "FruitCBX"
        Me.FruitCBX.Size = New System.Drawing.Size(200, 37)
        Me.FruitCBX.TabIndex = 15
        '
        'submitBTN
        '
        Me.submitBTN.Location = New System.Drawing.Point(577, 392)
        Me.submitBTN.Name = "submitBTN"
        Me.submitBTN.Size = New System.Drawing.Size(216, 37)
        Me.submitBTN.TabIndex = 16
        Me.submitBTN.Text = "Submit"
        Me.submitBTN.UseVisualStyleBackColor = True
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.submitBTN)
        Me.Controls.Add(Me.FruitCBX)
        Me.Controls.Add(Me.FatCBX)
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
        Me.Controls.Add(Me.ProteinCBX)
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
    Friend WithEvents ProteinCBX As ComboBox
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
    Friend WithEvents FatCBX As ComboBox
    Friend WithEvents FruitCBX As ComboBox
    Friend WithEvents submitBTN As Button
End Class

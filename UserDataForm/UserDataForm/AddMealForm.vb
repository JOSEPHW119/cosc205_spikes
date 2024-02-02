Public Class AddMealForm
    Private Sub AddMealForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create a form that adds meals to the user's profile. (2 hours) Amol
    End Sub

    Private Sub submitBTN_Click(sender As Object, e As EventArgs) Handles submitBTN.Click
        ' Create a list to store selected items
        Dim selectedItems As New List(Of String)

        ' Get selected items from each ComboBox and add them to the list
        AddSelectedItem(selectedItems, ProteinCBX)
        AddSelectedItem(selectedItems, VegCBX)
        AddSelectedItem(selectedItems, GrainCBX)
        AddSelectedItem(selectedItems, FruitCBX)
        AddSelectedItem(selectedItems, DairyCBX)
        AddSelectedItem(selectedItems, FatCBX)

        ' Check if any item is selected
        If selectedItems.Count > 0 Then
            ' Display selected items in TextBox
            MealsTBX.Text = $"Meal: {String.Join(", ", selectedItems)}"

            ' Insert into the database
            InsertIntoDatabase(String.Join(", ", selectedItems))

            ' Disable the button for 5 seconds
            submitBTN.Enabled = False

            Dim timer As New Timer()
            timer.Interval = 5000 ' 5 seconds in milliseconds
            AddHandler timer.Tick, Sub()
                                       submitBTN.Enabled = True
                                       Reset()
                                       timer.Stop()
                                   End Sub
            timer.Start()

        Else
            ' Display message if nothing was selected
            MessageBox.Show("Please select at least one item.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub AddSelectedItem(selectedItems As List(Of String), comboBox As ComboBox)
        If comboBox.SelectedItem IsNot Nothing Then
            selectedItems.Add(comboBox.SelectedItem.ToString())
        End If
    End Sub

    Private Sub InsertIntoDatabase(ingredients As String)
        ' Create a new instance of FitnessAppDBDataContext
        Dim path As String = Environment.CurrentDirectory
        path = path.Replace("\bin\Debug", "\FitnessAppDB.mdf;Integrated Security=True")
        path = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & path
        Dim db As New FitnessAppDBDataContext(path)

        ' Create a new Meal entity
        Dim newMeal As New Meal()

        ' Set the Ingredients property
        newMeal.Ingredients = ingredients

        ' Add the newMeal to the Meals table
        db.Meals.InsertOnSubmit(newMeal)

        ' Submit changes to the database
        db.SubmitChanges()
    End Sub

    Public Sub Reset()
        MealsTBX.Text = ""
        ' Reset all ComboBoxes
        ProteinCBX.SelectedIndex = -1
        VegCBX.SelectedIndex = -1
        GrainCBX.SelectedIndex = -1
        FruitCBX.SelectedIndex = -1
        DairyCBX.SelectedIndex = -1
        FatCBX.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Hide addMeal  
        Me.Close()

    End Sub

    ' Handle the FormClosed event
    Private Sub AddMealForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Show MainMenu when AddMealForm is closed
        Dim mainMenu As New MainMenu()
        mainMenu.Show()
    End Sub
End Class

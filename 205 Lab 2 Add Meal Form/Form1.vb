Public Class form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create a form that adds meals to the user's profile. (2 hours) Amol
    End Sub

    Private Sub submitBTN_Click(sender As Object, e As EventArgs) Handles submitBTN.Click
        ' Get selected items from each ComboBox
        Dim protein As String = If(ProteinCBX.SelectedItem IsNot Nothing, ProteinCBX.SelectedItem.ToString(), "No Protein selected")
        Dim veg As String = If(VegCBX.SelectedItem IsNot Nothing, VegCBX.SelectedItem.ToString(), "No Veg selected")
        Dim grain As String = If(GrainCBX.SelectedItem IsNot Nothing, GrainCBX.SelectedItem.ToString(), "No Grain selected")
        Dim fruit As String = If(FruitCBX.SelectedItem IsNot Nothing, FruitCBX.SelectedItem.ToString(), "No Fruit selected")
        Dim dairy As String = If(DairyCBX.SelectedItem IsNot Nothing, DairyCBX.SelectedItem.ToString(), "No Dairy selected")
        Dim fat As String = If(FatCBX.SelectedItem IsNot Nothing, FatCBX.SelectedItem.ToString(), "No Fat selected")

        ' Display the selected items in the MealsTBX TextBox, each on its own line
        MealsTBX.Text = $"Protein: {protein}{Environment.NewLine}Veg: {veg}{Environment.NewLine}Grain: {grain}{Environment.NewLine}Fruit: {fruit}{Environment.NewLine}Dairy: {dairy}{Environment.NewLine}Fat: {fat}"
    End Sub


End Class

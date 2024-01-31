Public Class AddMealForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub submitBTN_Click(sender As Object, e As EventArgs) Handles submitBTN.Click
        ' Get selected items from each ComboBox
        Dim protein As String = If(ProteinCBX.SelectedItem IsNot Nothing, ProteinCBX.SelectedItem.ToString(), vbNullString)
        Dim veg As String = If(VegCBX.SelectedItem IsNot Nothing, VegCBX.SelectedItem.ToString(), vbNullString)
        Dim grain As String = If(GrainCBX.SelectedItem IsNot Nothing, GrainCBX.SelectedItem.ToString(), vbNullString)
        Dim fruit As String = If(FruitCBX.SelectedItem IsNot Nothing, FruitCBX.SelectedItem.ToString(), vbNullString)
        Dim dairy As String = If(DairyCBX.SelectedItem IsNot Nothing, DairyCBX.SelectedItem.ToString(), vbNullString)
        Dim fat As String = If(FatCBX.SelectedItem IsNot Nothing, FatCBX.SelectedItem.ToString(), vbNullString)

        ' Create a list to store non-null values along with their labels
        Dim selectedItems As New List(Of String)

        ' Check and add non-null values with labels to the list
        If Not String.IsNullOrEmpty(protein) Then selectedItems.Add($"Protein: {protein}")
        If Not String.IsNullOrEmpty(veg) Then selectedItems.Add($"Veg: {veg}")
        If Not String.IsNullOrEmpty(grain) Then selectedItems.Add($"Grain: {grain}")
        If Not String.IsNullOrEmpty(fruit) Then selectedItems.Add($"Fruit: {fruit}")
        If Not String.IsNullOrEmpty(dairy) Then selectedItems.Add($"Dairy: {dairy}")
        If Not String.IsNullOrEmpty(fat) Then selectedItems.Add($"Fat: {fat}")

        ' Display the selected items in the MealsTBX TextBox, each on its own line
        MealsTBX.Text = String.Join(Environment.NewLine, selectedItems)
    End Sub
End Class

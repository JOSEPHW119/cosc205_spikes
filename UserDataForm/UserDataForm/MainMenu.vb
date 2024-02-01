Option Strict On
Public Class MainMenu
    Private Sub addMealBTN(sender As Object, e As EventArgs) Handles addMealsBTN.Click
        ' Create an instance of AddMealForm
        Dim addMealForm As New AddMealForm()

        ' Hide Form1
        Me.Hide()

        ' Show AddMealForm
        addMealForm.Show()
    End Sub

    Private Sub fitnessBTN_Click(sender As Object, e As EventArgs) Handles fitnessBTN.Click
        ' Create an instance of FitnessData
        Dim addFitness As New FitnessData()

        ' Hide MainMenu
        Me.Hide()

        ' Show FitnessData Form
        FitnessData.Show()
    End Sub

    Private Sub suggestionBTN_Click(sender As Object, e As EventArgs) Handles suggestionBTN.Click
        ' Create an instance of Suggestions
        Dim suggestions As New Form_Suggestion()

        ' Hide MainMenu
        Me.Hide()

        ' Show Form_Suggestions
        Form_Suggestion.Show()
    End Sub

    Private Sub addExerciseBTN_Click(sender As Object, e As EventArgs) Handles addExerciseBTN.Click
        ' Create an instance of AddExercise
        Dim addExercise As New AddExerciseForm()

        ' Hide MainMenu
        Me.Hide()

        ' Show AddExercise
        AddExerciseForm.Show()
    End Sub
End Class
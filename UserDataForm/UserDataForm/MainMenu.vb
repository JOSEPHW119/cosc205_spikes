Public Class MainMenu
    Private Sub addMealBTN(sender As Object, e As EventArgs) Handles addMealsBTN.Click
        ' Create an instance of AddMealForm
        Dim addMealForm As New AddMealForm()

        ' Show AddMealForm
        addMealForm.Show()

        ' Hide Form1
        Me.Hide()

    End Sub

    Private Sub fitnessBTN_Click(sender As Object, e As EventArgs) Handles fitnessBTN.Click
        ' Create an instance of FitnessData
        Dim FitnessData As New FitnessData()

        ' Show FitnessData Form
        FitnessData.Show()

        ' Hide MainMenu
        Me.Hide()

    End Sub

    Private Sub suggestionBTN_Click(sender As Object, e As EventArgs) Handles suggestionBTN.Click
        ' Create an instance of Suggestions
        Dim suggestions As New Form_Suggestion()

        ' Show Form_Suggestions
        Form_Suggestion.Show()

        ' Hide MainMenu
        Me.Hide()

    End Sub

    Private Sub addExerciseBTN_Click(sender As Object, e As EventArgs) Handles addExerciseBTN.Click
        ' Create an instance of AddExercise
        Dim addExercise As New AddExerciseForm()

        ' Show AddExercise
        AddExerciseForm.Show()

        ' Hide MainMenu
        Me.Hide()

    End Sub

    Private Sub MainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
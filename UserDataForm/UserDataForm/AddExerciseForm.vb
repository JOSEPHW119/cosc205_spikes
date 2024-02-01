Public Class AddExerciseForm
    Dim loadData(5, 2) As String
    Dim counter As Integer = 0
    Private Sub AddExerciseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submitBTN.Enabled = False
    End Sub

    Private Sub addTimeCardioBTN_Click(sender As Object, e As EventArgs) Handles addTimeCardioBTN.Click
        Dim time As Integer = addTimeCardioNBX.Value
        Dim exercise As String = addCardioCBX.Text
        addExercise(exercise, time)
        addCardioCBX.Text = ""
        addTimeCardioNBX.Value = 0
    End Sub
    Sub addExercise(exercise As String, time As Integer)
        Dim timeStr As String
        If time = 1 Then
            timeStr = "minute"
        Else
            timeStr = "minutes"
        End If
        Dim data As String = "You added " & exercise & " - Time: " & time & " " & timeStr
        If time = 0 Or exercise = "" Then
            MessageBox.Show("Please enter an exercise and a time greater than 0")
        Else
            If counter >= loadData.GetUpperBound(0) Then
                MessageBox.Show("You have reached the maximum number of exercises. Please submit to add more exercises.")
            Else
                loadData(counter, 0) = exercise
                loadData(counter, 1) = time
                counter += 1
                summaryTBX.Text &= data & vbNewLine
                submitBTN.Enabled = True
            End If
        End If
    End Sub

    Private Sub addTimeAerobicsBTN_Click(sender As Object, e As EventArgs) Handles addTimeAerobicsBTN.Click
        Dim exercise As String = addAerobicsCBX.Text
        Dim time As Integer = addTimeAerobicsNBX.Value
        addExercise(exercise, time)
        addAerobicsCBX.Text = ""
        addTimeAerobicsNBX.Value = 0
    End Sub

    Private Sub addTimeAnaerobicsBTN_Click(sender As Object, e As EventArgs) Handles addTimeAnaerobicsBTN.Click
        Dim exercise As String = addAnaerobicCBX.Text
        Dim time As Integer = addTimeAnaerobicsNBX.Value
        addExercise(exercise, time)
        addAnaerobicCBX.Text = ""
        addTimeAnaerobicsNBX.Value = 0
    End Sub
    Sub reset()
        addAerobicsCBX.Text = ""
        addAnaerobicCBX.Text = ""
        addCardioCBX.Text = ""
        addTimeAerobicsNBX.Value = 0
        addTimeAnaerobicsNBX.Value = 0
        addTimeCardioNBX.Value = 0
        summaryTBX.Text = ""
        submitBTN.Enabled = False
        counter = 0
        For i = 0 To loadData.GetUpperBound(0)
            For j = 0 To loadData.GetUpperBound(1)
                loadData(i, j) = ""
            Next
        Next
    End Sub

    Private Sub submitBTN_Click(sender As Object, e As EventArgs) Handles submitBTN.Click
        reset()
    End Sub

    Private Sub exerciseBackBTN_Click(sender As Object, e As EventArgs) Handles exerciseBackBTN.Click
        ' Create an instance of MainMenu
        Dim addFitness As New MainMenu()

        ' Hide addExercise
        Me.Hide()

        ' Show MainMenu
        MainMenu.Show()
    End Sub
End Class
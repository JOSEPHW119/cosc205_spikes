Public Class AddExerciseForm
    Dim loadData(5, 2) As String
    Dim counter As Integer = 0
    Dim exercise As String
    Dim time As Integer
    Dim exerciseList As New List(Of Exercise)

    Private Sub AddExerciseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submitBTN.Enabled = False
    End Sub

    Sub addExercise(exerciseName As String, exerciseTime As Integer)
        Dim timeStr As String
        If exerciseTime = 1 Then
            timeStr = "minute"
        Else
            timeStr = "minutes"
        End If
        Dim data As String = "You added " & exerciseName & " - Time: " & exerciseTime & " " & timeStr
        If exerciseTime = 0 Or exerciseName = "" Then
            MessageBox.Show("Please enter an exercise and a time greater than 0")
        Else
            If counter >= loadData.GetUpperBound(0) Then
                MessageBox.Show("You have reached the maximum number of exercises. Please submit to add more exercises.")
            Else
                loadData(counter, 0) = exerciseName
                loadData(counter, 1) = exerciseTime
                counter += 1
                summaryTBX.Text &= data & vbNewLine
                submitBTN.Enabled = True

                ' Add exercise to the list
                Dim newExercise As New Exercise With {
                    .Exercise = exerciseName,
                    .Minutes = exerciseTime
                }
                exerciseList.Add(newExercise)
            End If
        End If
    End Sub

    Private Sub addTimeCardioBTN_Click(sender As Object, e As EventArgs) Handles addTimeCardioBTN.Click
        time = addTimeCardioNBX.Value
        exercise = addCardioCBX.Text
        addExercise(exercise, time)
        addCardioCBX.Text = ""
        addTimeCardioNBX.Value = 0
    End Sub

    Private Sub addTimeAerobicsBTN_Click(sender As Object, e As EventArgs) Handles addTimeAerobicsBTN.Click
        exercise = addAerobicsCBX.Text
        time = addTimeAerobicsNBX.Value
        addExercise(exercise, time)
        addAerobicsCBX.Text = ""
        addTimeAerobicsNBX.Value = 0
    End Sub

    Private Sub addTimeAnaerobicsBTN_Click(sender As Object, e As EventArgs) Handles addTimeAnaerobicsBTN.Click
        exercise = addAnaerobicCBX.Text
        time = addTimeAnaerobicsNBX.Value
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

        ' Clear the exercise list
        exerciseList.Clear()
    End Sub

    Private Sub submitBTN_Click(sender As Object, e As EventArgs) Handles submitBTN.Click
        ' Check if fields have been filled out
        If exerciseList.Count = 0 Then
            MessageBox.Show("Please add at least one exercise before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Dim path As String = Environment.CurrentDirectory
            path = path.Replace("\bin\Debug", "\FitnessAppDB.mdf;Integrated Security=True")
            path = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & path
            Dim db As New FitnessAppDBDataContext(path)

            ' Insert all exercises into the database
            db.Exercises.InsertAllOnSubmit(exerciseList)
            db.SubmitChanges()

            ' Reset form fields
            reset()
        End If
    End Sub

    Private Sub exerciseBackBTN_Click(sender As Object, e As EventArgs) Handles exerciseBackBTN.Click

        ' Hide addExercise
        Me.Close()

    End Sub

    Private Sub AddExerciseForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Show MainMenu when AddExerciseForm is closed
        Dim mainMenu As New MainMenu()
        mainMenu.Show()
    End Sub

End Class

Option Strict On
Public Class Form_Suggestion
    Private Sub Submit_BTN_Click(sender As Object, e As EventArgs) Handles Submit_BTN.Click
        ' Declare variables to store user input
        Dim age As Integer
        Dim bmi As Integer
        Dim goal As String
        Dim inTake As Integer
        Dim calBurned As Integer
        Dim calNeeded As Integer
        Dim calcuCal As Integer

        ' Validate and parse user inputs
        If Integer.TryParse(Age_TBX.Text, age) AndAlso
           Integer.TryParse(BMI_TBX.Text, bmi) AndAlso
           Not String.IsNullOrEmpty(Goal_TBX.Text) AndAlso
           (Goal_TBX.Text = "gain" OrElse Goal_TBX.Text = "lose") AndAlso
           Integer.TryParse(InTake_TBX.Text, inTake) AndAlso
           Integer.TryParse(CalBurned_TBX.Text, calBurned) Then

            ' Check age range
            If age >= 18 AndAlso age <= 80 Then
                ' Calculate remaining calorie intake
                calNeeded = 2000
                calcuCal = inTake - calBurned - calNeeded

                ' Provide suggestions based on calorie balance
                If calcuCal = 0 Then
                    MsgBox("Congratulations! You are on the right path!")
                ElseIf calcuCal > 0 Then
                    MsgBox("Consider going jogging for 30 minutes to help meet your goal.")
                Else
                    MsgBox("You need some more calories! How about some tofu salads?")
                End If
            Else
                MsgBox("Please enter an age between 18 and 80.")
            End If
        Else
            MsgBox("Please ensure all inputs are valid and not empty. Goal should be 'gain' or 'lose'.")
        End If
    End Sub

    Private Sub Age_TBX_TextChanged(sender As Object, e As EventArgs) Handles Age_TBX.TextChanged

    End Sub

    Private Sub Form_Suggestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create an instance of MainMenu
        Dim addFitness As New MainMenu()

        ' Hide Suggestions
        Me.Hide()

        ' Show MainMenu
        MainMenu.Show()
    End Sub
End Class

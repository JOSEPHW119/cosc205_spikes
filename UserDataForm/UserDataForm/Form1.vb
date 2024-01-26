Option Strict On
Public Class Form1

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit(sender As Object, e As EventArgs) Handles submitBTN.Click
        If emailTBX.Text.Equals("") Or ageTBX.Text.Equals("") Or heightTBX.Text.Equals("") Or weightTBX.Text.Equals("") _
            Or genderCBX.Text.Equals("") Or goalsCBX.Text.Equals("") Then
            MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Dim email As String = emailTBX.Text
            Dim age As Integer = CInt(ageTBX.Text)
            Dim height As Integer = CInt(heightTBX.Text)
            Dim weight As Integer = CInt(weightTBX.Text)
            Dim gender As String = genderCBX.Text
            Dim goal As String = goalsCBX.Text

            ' Insert data into database
        End If
    End Sub
End Class

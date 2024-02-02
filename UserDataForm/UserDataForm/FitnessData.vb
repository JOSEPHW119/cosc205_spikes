Option Strict On

Public Class FitnessData

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Submit(sender As Object, e As EventArgs) Handles submitBTN.Click
        ' Check if fields have been filled out

        If emailTBX.Text.Equals("") Or ageTBX.Text.Equals("") Or heightTBX.Text.Equals("") Or weightTBX.Text.Equals("") _
            Or genderCBX.Text.Equals("") Or goalsCBX.Text.Equals("") Then
            MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Dim path As String = Environment.CurrentDirectory
            path = path.Replace("\bin\Debug", "\FitnessAppDB.mdf;Integrated Security=True")
            path = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & path
            Dim db As New FitnessAppDBDataContext(path)

            Dim user As New User With {
                .email = emailTBX.Text,
                .age = CInt(ageTBX.Text),
                .height_cm = CInt(heightTBX.Text),
                .weight_kg = CInt(weightTBX.Text),
                .gender = genderCBX.Text,
                .goal = goalsCBX.Text
            }

            ' Insert data into database

            db.Users.InsertOnSubmit(user)
            db.SubmitChanges()
            ClearFields()
        End If
    End Sub

    Public Sub ClearFields()
        emailTBX.Text = ""
        ageTBX.Text = ""
        heightTBX.Text = ""
        weightTBX.Text = ""
        genderCBX.Text = ""
        goalsCBX.Text = ""
    End Sub

    Private Sub Back(sender As Object, e As EventArgs) Handles backBTN.Click, submitBTN.Click
        ' Create an instance of MainMenu
        Dim addFitness As New MainMenu()

        ' Hide FitnessData
        Me.Hide()

        ' Show MainMenu
        MainMenu.Show()
    End Sub
End Class

Imports System.Data.SqlClient
Public Class Form1
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit(sender As Object, e As EventArgs) Handles submitBTN.Click
        Dim name As String = emailTBX.Text
        Dim age As Integer
        Dim height As Integer
        Dim weight As Integer
        Dim gender As String = genderCBX.Text
        Dim goal As String = goalsCBX.Text

        If Integer.TryParse(ageTBX.Text, age) AndAlso
            Integer.TryParse(heightTBX.Text, height) AndAlso
            Integer.TryParse(weightTBX.Text, weight) Then
            Me.UsersTableAdapter.Insert(name, age, height, weight, gender, goal)
        Else
            ' Handle the error when the conversion fails
            MessageBox.Show("Please enter valid numbers for age, height, and weight.")
        End If



        emailTBX.Text = ""
        ageTBX.Text = ""
        heightTBX.Text = ""
        weightTBX.Text = ""
        genderCBX.Text = ""
        goalsCBX.Text = ""

        Me.UsersTableAdapter.Fill(Me.FitnessAppDBDataSet.Users)
        WriteToDatabase(Me.FitnessAppDBDataSet) 'this line is not correctly updating fitnessappdb.mdf

    End Sub

    Public Sub WriteToDatabase(myDataSet As DataSet)
        ' Connection string to your database.
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\close\OneDrive - Okanagan College\Documents\okCollege2024\andrewJohnson\cosc205\spike\cosc_205spikes\UserDataForm\UserDataForm\FitnessAppDB.mdf"";Integrated Security=True"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create a new SqlDataAdapter
            Dim adapter As New SqlDataAdapter()
            Dim numRows = 0
            ' For each table in the DataSet write the data to the database
            For Each table As DataTable In myDataSet.Tables
                ' Create a new command builder
                Dim builder As New SqlCommandBuilder(adapter)

                ' Set the SelectCommand of the adapter to a new SqlCommand using the table's name
                adapter.SelectCommand = New SqlCommand("SELECT * FROM " & table.TableName, connection)

                ' Update the database with the data in the DataSet
                numRows += adapter.Update(table)
            Next
            MessageBox.Show(numRows)
        End Using
    End Sub
End Class

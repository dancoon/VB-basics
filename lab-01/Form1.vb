Public Class Form1


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = InputBox("Please enter your first name: ")
        stLastName = InputBox("Please enter your last name: ")
        MessageBox.Show("My name is " & stFirstName & " My last name is " & stLastName)

    End Sub

    Private Sub btnDataType_Click(sender As Object, e As EventArgs) Handles btnDataType.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = " Audi "
        stModel = " R6 Turbo "
        iDoors = 4
        stColor = " Red "
        bTaxed = True
        iEngineSize = 1200
        decPrice = 5363.789
        dtDateRegistered = #11/2/2020#
        MsgBox("The car is " & stMake & vbNewLine &
               stModel & vbNewLine & iDoors & vbNewLine &
               stColor & vbNewLine & bTaxed & vbNewLine & iEngineSize & vbNewLine &
               decPrice & vbNewLine & dtDateRegistered)


    End Sub

    Private Sub btnNameGo_Click(sender As Object, e As EventArgs) Handles btnNameGo.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text
        stOccupation = lstOccupation.SelectedItem

        MsgBox("Hello " & stFirstName & " " &
               stLastName & " You are a " & stGender & " :" &
               stOccupation)

    End Sub
End Class

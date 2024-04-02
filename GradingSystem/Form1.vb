Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mk1 As Integer = Integer.Parse(SubjectOneTxt.Text)
        Dim mk2 As Integer = Integer.Parse(SubjectTwoTxt.Text)
        Dim mk3 As Integer = Integer.Parse(SubjectThreeTxt.Text)
        Dim mk4 As Integer = Integer.Parse(SubjectFourTxt.Text)
        Dim avg As Decimal = (mk1 + mk2 + mk3 + mk4) / 4
        Dim grade As String

        If avg < 50 And avg >= 0 Then
            grade = "Fail"
        ElseIf avg < 65 Then
            grade = "C"
        ElseIf avg < 75 Then
            grade = "B"
        ElseIf avg <= 100 Then
            grade = "A"
        Else
            MessageBox.Show("Marks can't be more than 100")
            Return
        End If

        Dim msg As String = String.Format("Your average marks is {0} and grade is {1}", avg, grade)
        MessageBox.Show(msg)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SubjectOneTxt.Text = ""
        SubjectTwoTxt.Text = ""
        SubjectThreeTxt.Text = ""
        SubjectFourTxt.Text = ""
    End Sub

    Private Sub SubjectOneTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SubjectOneTxt.Validating
        Dim maxValue As Integer = 100 ' Set your maximum value here
        Dim minValue As Integer = 0
        Dim input As Integer

        ' Attempt to parse the text entered in the TextBox to an Integer
        If Not Integer.TryParse(SubjectOneTxt.Text, input) Then
            MessageBox.Show("Please enter a valid integer value.")
            SubjectOneTxt.SelectAll()
            e.Cancel = True
            Return
        End If

        ' Check if the input exceeds the maximum value
        If input > maxValue Then
            MessageBox.Show("Value cannot exceed " & maxValue.ToString())
            SubjectOneTxt.SelectAll()
            e.Cancel = True
        ElseIf input < minValue Then
            MessageBox.Show("Value cannot be less than " & minValue.ToString())
            SubjectOneTxt.SelectAll()
            e.Cancel = True
        End If
    End Sub

    Private Sub SubjectTwoTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SubjectTwoTxt.Validating
        Dim maxValue As Integer = 100 ' Set your maximum value here
        Dim minValue As Integer = 0
        Dim input As Integer

        ' Attempt to parse the text entered in the TextBox to an Integer
        If Not Integer.TryParse(SubjectTwoTxt.Text, input) Then
            MessageBox.Show("Please enter a valid integer value.")
            SubjectTwoTxt.SelectAll()
            e.Cancel = True
            Return
        End If

        ' Check if the input exceeds the maximum value
        If input > maxValue Then
            MessageBox.Show("Value cannot exceed " & maxValue.ToString())
            SubjectTwoTxt.SelectAll()
            e.Cancel = True
        ElseIf input < minValue Then
            MessageBox.Show("Value cannot be less than " & minValue.ToString())
            SubjectTwoTxt.SelectAll()
            e.Cancel = True
        End If
    End Sub

    Private Sub SubjectThreeTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SubjectThreeTxt.Validating
        Dim maxValue As Integer = 100 ' Set your maximum value here
        Dim minValue As Integer = 0
        Dim input As Integer

        ' Attempt to parse the text entered in the TextBox to an Integer
        If Not Integer.TryParse(SubjectThreeTxt.Text, input) Then
            MessageBox.Show("Please enter a valid integer value.")
            SubjectThreeTxt.SelectAll()
            e.Cancel = True
            Return
        End If

        ' Check if the input exceeds the maximum value
        If input > maxValue Then
            MessageBox.Show("Value cannot exceed " & maxValue.ToString())
            SubjectThreeTxt.SelectAll()
            e.Cancel = True
        ElseIf input < minValue Then
            MessageBox.Show("Value cannot be less than " & minValue.ToString())
            SubjectThreeTxt.SelectAll()
            e.Cancel = True
        End If
    End Sub

    Private Sub SubjectFourTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SubjectFourTxt.Validating
        Dim maxValue As Integer = 100 ' Set your maximum value here
        Dim minValue As Integer = 0
        Dim input As Integer

        ' Attempt to parse the text entered in the TextBox to an Integer
        If Not Integer.TryParse(SubjectFourTxt.Text, input) Then
            MessageBox.Show("Please enter a valid integer value.")
            SubjectFourTxt.SelectAll()
            e.Cancel = True
            Return
        End If

        ' Check if the input exceeds the maximum value
        If input > maxValue Then
            MessageBox.Show("Value cannot exceed " & maxValue.ToString())
            SubjectFourTxt.SelectAll()
            e.Cancel = True
        ElseIf input < minValue Then
            MessageBox.Show("Value cannot be less than " & minValue.ToString())
            SubjectFourTxt.SelectAll()
            e.Cancel = True
        End If
    End Sub b
End Class

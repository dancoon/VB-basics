Public Class Form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mk1 As Integer = Integer.Parse(SubjectOneTxt.Text)
        Dim mk2 As Integer = Integer.Parse(SubjectTwoTxt.Text)
        Dim mk3 As Integer = Integer.Parse(SubjectThreeTxt.Text)
        Dim mk4 As Integer = Integer.Parse(SubjectFourTxt.Text)
        Dim avg As Decimal = (mk1 + mk2 + mk3 + mk4) / 4
        Dim grade As String

        If avg < 50 Then
            grade = "Fail"
        ElseIf avg < 65 Then
            grade = "C"
        ElseIf avg < 75 Then
            grade = "B"
        Else
            grade = "A"

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
End Class

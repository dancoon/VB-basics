Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btnExit, "Close the form")
        ToolTip1.SetToolTip(btnLoadObjectDemo, "Opens a new form Object Demonstrations")

    End Sub

    Private Sub btnLoadObjectDemo_Click(sender As Object, e As EventArgs) Handles btnLoadObjectDemo.Click
        Dim newForm As New Object_Demonstrations()
        newForm.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub
End Class

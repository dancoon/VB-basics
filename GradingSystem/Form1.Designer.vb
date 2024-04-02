<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Title = New Label()
        Panel4 = New Panel()
        SubjectOneTxt = New TextBox()
        Label2 = New Label()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Button3 = New Button()
        Button1 = New Button()
        Panel5 = New Panel()
        SubjectFourTxt = New TextBox()
        Label4 = New Label()
        Panel3 = New Panel()
        SubjectThreeTxt = New TextBox()
        Label3 = New Label()
        Panel2 = New Panel()
        SubjectTwoTxt = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Title)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(801, 103)
        Panel1.TabIndex = 0
        ' 
        ' Title
        ' 
        Title.Dock = DockStyle.Fill
        Title.Font = New Font("Segoe UI", 24F)
        Title.Location = New Point(0, 0)
        Title.Margin = New Padding(0)
        Title.Name = "Title"
        Title.Size = New Size(801, 103)
        Title.TabIndex = 0
        Title.Text = "Grading System"
        Title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(SubjectOneTxt)
        Panel4.Controls.Add(Label2)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(250, 50)
        Panel4.MaximumSize = New Size(0, 70)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(0, 10, 10, 0)
        Panel4.Size = New Size(301, 70)
        Panel4.TabIndex = 7
        ' 
        ' SubjectOneTxt
        ' 
        SubjectOneTxt.Dock = DockStyle.Right
        SubjectOneTxt.Font = New Font("Segoe UI", 12F)
        SubjectOneTxt.Location = New Point(166, 10)
        SubjectOneTxt.MinimumSize = New Size(125, 40)
        SubjectOneTxt.Name = "SubjectOneTxt"
        SubjectOneTxt.PlaceholderText = "0"
        SubjectOneTxt.Size = New Size(125, 40)
        SubjectOneTxt.TabIndex = 2
        SubjectOneTxt.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Dock = DockStyle.Left
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(0, 10)
        Label2.Margin = New Padding(3)
        Label2.MaximumSize = New Size(150, 40)
        Label2.MinimumSize = New Size(100, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 40)
        Label2.TabIndex = 1
        Label2.Text = "Subject One"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Panel7)
        Panel6.Controls.Add(Panel5)
        Panel6.Controls.Add(Panel3)
        Panel6.Controls.Add(Panel2)
        Panel6.Controls.Add(Panel4)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(0, 103)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(250, 50, 250, 50)
        Panel6.Size = New Size(801, 456)
        Panel6.TabIndex = 9
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Button3)
        Panel7.Controls.Add(Button1)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(250, 330)
        Panel7.MaximumSize = New Size(0, 70)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(0, 10, 10, 0)
        Panel7.Size = New Size(301, 70)
        Panel7.TabIndex = 14
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.Dock = DockStyle.Right
        Button3.Font = New Font("Segoe UI", 12F)
        Button3.Location = New Point(154, 10)
        Button3.Name = "Button3"
        Button3.Size = New Size(137, 60)
        Button3.TabIndex = 13
        Button3.Text = "Get Grade"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightCoral
        Button1.Dock = DockStyle.Left
        Button1.Location = New Point(0, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 60)
        Button1.TabIndex = 11
        Button1.Text = "Reset"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(SubjectFourTxt)
        Panel5.Controls.Add(Label4)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(250, 260)
        Panel5.MaximumSize = New Size(0, 70)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(0, 10, 10, 0)
        Panel5.Size = New Size(301, 70)
        Panel5.TabIndex = 10
        ' 
        ' SubjectFourTxt
        ' 
        SubjectFourTxt.Dock = DockStyle.Right
        SubjectFourTxt.Font = New Font("Segoe UI", 12F)
        SubjectFourTxt.Location = New Point(166, 10)
        SubjectFourTxt.MinimumSize = New Size(125, 40)
        SubjectFourTxt.Name = "SubjectFourTxt"
        SubjectFourTxt.PlaceholderText = "0"
        SubjectFourTxt.Size = New Size(125, 40)
        SubjectFourTxt.TabIndex = 2
        SubjectFourTxt.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label4
        ' 
        Label4.BackColor = SystemColors.ActiveBorder
        Label4.Dock = DockStyle.Left
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(0, 10)
        Label4.Margin = New Padding(3)
        Label4.MaximumSize = New Size(150, 40)
        Label4.MinimumSize = New Size(100, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 40)
        Label4.TabIndex = 1
        Label4.Text = "Subject Four"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(SubjectThreeTxt)
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(250, 190)
        Panel3.MaximumSize = New Size(0, 70)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 10, 10, 0)
        Panel3.Size = New Size(301, 70)
        Panel3.TabIndex = 9
        ' 
        ' SubjectThreeTxt
        ' 
        SubjectThreeTxt.Dock = DockStyle.Right
        SubjectThreeTxt.Font = New Font("Segoe UI", 12F)
        SubjectThreeTxt.Location = New Point(166, 10)
        SubjectThreeTxt.MinimumSize = New Size(125, 40)
        SubjectThreeTxt.Name = "SubjectThreeTxt"
        SubjectThreeTxt.PlaceholderText = "0"
        SubjectThreeTxt.Size = New Size(125, 40)
        SubjectThreeTxt.TabIndex = 2
        SubjectThreeTxt.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ActiveBorder
        Label3.Dock = DockStyle.Left
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(0, 10)
        Label3.Margin = New Padding(3)
        Label3.MaximumSize = New Size(150, 40)
        Label3.MinimumSize = New Size(100, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 40)
        Label3.TabIndex = 1
        Label3.Text = "Subject Three"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(SubjectTwoTxt)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(250, 120)
        Panel2.MaximumSize = New Size(0, 70)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 10, 10, 0)
        Panel2.Size = New Size(301, 70)
        Panel2.TabIndex = 8
        ' 
        ' SubjectTwoTxt
        ' 
        SubjectTwoTxt.Dock = DockStyle.Right
        SubjectTwoTxt.Font = New Font("Segoe UI", 12F)
        SubjectTwoTxt.Location = New Point(166, 10)
        SubjectTwoTxt.MinimumSize = New Size(125, 40)
        SubjectTwoTxt.Name = "SubjectTwoTxt"
        SubjectTwoTxt.PlaceholderText = "0"
        SubjectTwoTxt.Size = New Size(125, 40)
        SubjectTwoTxt.TabIndex = 2
        SubjectTwoTxt.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(0, 10)
        Label1.Margin = New Padding(3)
        Label1.MaximumSize = New Size(150, 40)
        Label1.MinimumSize = New Size(100, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 40)
        Label1.TabIndex = 1
        Label1.Text = "Subject Two"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(801, 559)
        Controls.Add(Panel6)
        Controls.Add(Panel1)
        Name = "Form"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SubjectOneTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SubjectFourTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SubjectThreeTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SubjectTwoTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button

End Class

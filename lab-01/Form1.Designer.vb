<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnStart = New Button()
        btnDataType = New Button()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        lblGender = New Label()
        txtGender = New TextBox()
        btnNameGo = New Button()
        lstOccupation = New ListBox()
        lblOccupation = New Label()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.HotTrack
        btnStart.Location = New Point(89, 362)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(207, 66)
        btnStart.TabIndex = 0
        btnStart.Text = "Press here"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnDataType
        ' 
        btnDataType.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnDataType.Location = New Point(381, 362)
        btnDataType.Name = "btnDataType"
        btnDataType.Size = New Size(217, 61)
        btnDataType.TabIndex = 1
        btnDataType.Text = "datatype"
        btnDataType.UseVisualStyleBackColor = False
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(173, 35)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(316, 31)
        txtFirstName.TabIndex = 2
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(23, 35)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(97, 25)
        lblFirstName.TabIndex = 3
        lblFirstName.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(173, 80)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(316, 31)
        txtLastName.TabIndex = 4
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(23, 80)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(95, 25)
        lblLastName.TabIndex = 5
        lblLastName.Text = "Last Name"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(23, 129)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(69, 25)
        lblGender.TabIndex = 6
        lblGender.Text = "Gender"
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(173, 129)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(316, 31)
        txtGender.TabIndex = 7
        ' 
        ' btnNameGo
        ' 
        btnNameGo.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnNameGo.Location = New Point(706, 362)
        btnNameGo.Name = "btnNameGo"
        btnNameGo.Size = New Size(112, 66)
        btnNameGo.TabIndex = 8
        btnNameGo.Text = "Go"
        btnNameGo.UseVisualStyleBackColor = False
        ' 
        ' lstOccupation
        ' 
        lstOccupation.FormattingEnabled = True
        lstOccupation.ItemHeight = 25
        lstOccupation.Items.AddRange(New Object() {"Doctor", "Teacher", "Pilot", "Entrepreneur", "Athelete"})
        lstOccupation.Location = New Point(638, 37)
        lstOccupation.Name = "lstOccupation"
        lstOccupation.Size = New Size(180, 179)
        lstOccupation.TabIndex = 9
        ' 
        ' lblOccupation
        ' 
        lblOccupation.AutoSize = True
        lblOccupation.Location = New Point(638, 9)
        lblOccupation.Name = "lblOccupation"
        lblOccupation.Size = New Size(103, 25)
        lblOccupation.TabIndex = 10
        lblOccupation.Text = "Occupation"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(859, 450)
        Controls.Add(lblOccupation)
        Controls.Add(lstOccupation)
        Controls.Add(btnNameGo)
        Controls.Add(txtGender)
        Controls.Add(lblGender)
        Controls.Add(lblLastName)
        Controls.Add(txtLastName)
        Controls.Add(lblFirstName)
        Controls.Add(txtFirstName)
        Controls.Add(btnDataType)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnDataType As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnNameGo As Button
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label

End Class

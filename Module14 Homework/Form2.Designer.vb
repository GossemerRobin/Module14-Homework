<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudentNumber = New System.Windows.Forms.TextBox()
        Me.btnStudentCount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(439, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(204, 55)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(150, 31)
        Me.txtFirstName.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(592, 52)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(150, 31)
        Me.txtLastName.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(204, 116)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 31)
        Me.txtEmail.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(35, 198)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 34)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(35, 261)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(112, 34)
        Me.btnDisplay.TabIndex = 9
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(244, 182)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(526, 222)
        Me.txtOutput.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(439, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 100)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Student Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Location = New System.Drawing.Point(592, 122)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(150, 31)
        Me.txtStudentNumber.TabIndex = 12
        '
        'btnStudentCount
        '
        Me.btnStudentCount.Location = New System.Drawing.Point(35, 337)
        Me.btnStudentCount.Name = "btnStudentCount"
        Me.btnStudentCount.Size = New System.Drawing.Size(143, 34)
        Me.btnStudentCount.TabIndex = 13
        Me.btnStudentCount.Text = "Student Count"
        Me.btnStudentCount.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnStudentCount)
        Me.Controls.Add(Me.txtStudentNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Student Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStudentNumber As TextBox
    Friend WithEvents btnStudentCount As Button
End Class

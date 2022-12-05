<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOfficeNumber = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FirstName:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(165, 45)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(150, 31)
        Me.txtFirstName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LastName:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(522, 45)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(150, 31)
        Me.txtLastName.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(165, 113)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 31)
        Me.txtEmail.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(35, 211)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 34)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(35, 280)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(112, 34)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Office Number:"
        '
        'txtOfficeNumber
        '
        Me.txtOfficeNumber.Location = New System.Drawing.Point(539, 110)
        Me.txtOfficeNumber.Name = "txtOfficeNumber"
        Me.txtOfficeNumber.Size = New System.Drawing.Size(150, 31)
        Me.txtOfficeNumber.TabIndex = 10
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(293, 189)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(445, 203)
        Me.txtOutput.TabIndex = 11
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtOfficeNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Instructor Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOfficeNumber As TextBox
    Friend WithEvents txtOutput As TextBox
End Class

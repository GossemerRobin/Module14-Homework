<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtCourseNumber = New System.Windows.Forms.TextBox()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(493, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Units:"
        '
        'txtCourseNumber
        '
        Me.txtCourseNumber.Location = New System.Drawing.Point(286, 43)
        Me.txtCourseNumber.Name = "txtCourseNumber"
        Me.txtCourseNumber.Size = New System.Drawing.Size(150, 31)
        Me.txtCourseNumber.TabIndex = 3
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(638, 40)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(150, 31)
        Me.txtCourseName.TabIndex = 4
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(286, 100)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(150, 31)
        Me.txtUnits.TabIndex = 5
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(12, 268)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(112, 34)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 326)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(112, 34)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(181, 158)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(607, 256)
        Me.txtOutput.TabIndex = 8
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.txtCourseName)
        Me.Controls.Add(Me.txtCourseNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Course Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCourseNumber As TextBox
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtOutput As TextBox
End Class

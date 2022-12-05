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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnInstructor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(142, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select one of the following buttons"
        '
        'btnCourse
        '
        Me.btnCourse.Location = New System.Drawing.Point(142, 194)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(112, 34)
        Me.btnCourse.TabIndex = 1
        Me.btnCourse.Text = "Course"
        Me.btnCourse.UseVisualStyleBackColor = True
        '
        'btnStudent
        '
        Me.btnStudent.Location = New System.Drawing.Point(319, 194)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(112, 34)
        Me.btnStudent.TabIndex = 2
        Me.btnStudent.Text = "Student"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'btnInstructor
        '
        Me.btnInstructor.Location = New System.Drawing.Point(499, 194)
        Me.btnInstructor.Name = "btnInstructor"
        Me.btnInstructor.Size = New System.Drawing.Size(112, 34)
        Me.btnInstructor.TabIndex = 3
        Me.btnInstructor.Text = "Instructor"
        Me.btnInstructor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnInstructor)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.btnCourse)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "MainForm Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCourse As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnInstructor As Button
End Class

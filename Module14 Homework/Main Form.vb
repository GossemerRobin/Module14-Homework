Public Class Form1
    Dim MyCE As New Course_Enrollments

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim F1 As New Form2
        F1.MyCE = MyCE
        F1.Show()
    End Sub

    Private Sub btnInstructor_Click(sender As Object, e As EventArgs) Handles btnInstructor.Click
        Dim F1 As New Form4
        F1.MyCE = MyCE
        F1.Show()
    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        Dim F1 As New Form3
        F1.MyCE = MyCE
        F1.Show()
    End Sub

End Class

Public Class Form3
    Public MyCE As Course_Enrollments
    Dim SaveCourse As New Course

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SaveCourse.m_CourseNumber = txtCourseNumber.Text
        SaveCourse.m_CourseName = txtCourseName.Text
        SaveCourse.m_Units = txtUnits.Text
        MyCE.SaveCourse(SaveCourse)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        txtOutput.Text = SaveCourse.CSV
    End Sub
End Class
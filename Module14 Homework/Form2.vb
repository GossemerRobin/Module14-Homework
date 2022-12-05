Public Class Form2

    Public MyCE As Course_Enrollments
    Dim SaveStudent As New Student

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveStudent.m_FirstName = txtFirstName.Text
        SaveStudent.m_LastName = txtLastName.Text
        SaveStudent.m_Email = txtEmail.Text
        SaveStudent.m_StudentNumber = txtStudentNumber.Text
        MyCE.SaveStudents(SaveStudent)

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        txtOutput.Text = SaveStudent.CSV
    End Sub

    Private Sub btnStudentCount_Click(sender As Object, e As EventArgs) Handles btnStudentCount.Click
        MessageBox.Show(MyCE.m_StudentCount)
    End Sub
End Class
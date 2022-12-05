Public Class Form4

    Public MyCE As Course_Enrollments
    Dim SaveInstructor As New Instructor
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Creating the object for the Instructor Class
        SaveInstructor.m_FirstName = txtFirstName.Text
        SaveInstructor.m_LastName = txtLastName.Text
        SaveInstructor.m_Email = txtEmail.Text
        SaveInstructor.m_officeNumber = txtOfficeNumber.Text
        IO.File.AppendAllText("Intstructors.CSV", vbCrLf & SaveInstructor.CSV)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        txtOutput.Text = SaveInstructor.CSV
    End Sub
End Class
Public Class Course_Enrollments
    Public m_Course As Course
    Public m_Instructor As Instructor
    Public m_StudentCount As Integer

    Dim Max As Integer
    Public Sub New()
        'IO.File.Delete("Students.CSV")
        Dim AllLines As String() = IO.File.ReadAllLines("Students.CSV")
        Dim lineCount As Integer = AllLines.Length
        m_StudentCount = lineCount
    End Sub


    Dim Students As List(Of Student) = New List(Of Student)()

    Function AddStudent(AddingStudent As Student)

        Students.Add(AddingStudent)
        m_StudentCount += 1

    End Function

    Function SaveCourse(MyCourse As Course) As String
        IO.File.WriteAllText("Courses.CSV", MyCourse.CSV)
    End Function

    Function SaveInstructor(MyInstructor As Instructor) As String
        IO.File.WriteAllLines("Instructors.CSV", MyInstructor.CSV)
    End Function

    Function SaveStudents(MyStudent As Student) As String

        If m_StudentCount < 20 Then
            IO.File.AppendAllText("Students.CSV", MyStudent.CSV & vbCrLf)
            AddStudent(MyStudent)
        Else
            MessageBox.Show("You cannot enter more than 20 students.")
        End If

    End Function



End Class

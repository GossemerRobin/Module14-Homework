Public Class Course
    'Member variables
    Public m_CourseNumber As Integer
    Public m_CourseName As String
    Public m_Units As String


    Public Property CourseNumber() As String
        Get
            Return m_CourseNumber
        End Get
        Set(value As String)
            m_CourseNumber = value
        End Set

    End Property


    Public Property CourseName() As String
        Get
            Return m_CourseName
        End Get
        Set(value As String)
            m_CourseName = value
        End Set
    End Property


    Public Property units() As String
        Get
            Return m_Units
        End Get
        Set(value As String)
            m_Units = value
        End Set
    End Property


    Function CSV() As String
        Return m_CourseName & "," & m_CourseNumber & "," & m_Units
    End Function
End Class


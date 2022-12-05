Public Class Student
    Inherits Person

    Public m_StudentNumber As Integer

    Public Property StudentNumber() As Integer
        Get
            Return m_StudentNumber
        End Get
        Set(value As Integer)
            m_StudentNumber = value
        End Set
    End Property


    Function CSV() As String
        Return m_FirstName & "," & m_LastName & "," & m_Email & "," & m_StudentNumber
    End Function

End Class

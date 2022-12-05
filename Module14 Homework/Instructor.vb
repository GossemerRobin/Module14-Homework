Public Class Instructor
    Inherits Person

    Public m_officeNumber As Integer

    Public Property officeNumber() As Integer
        Get
            Return m_officeNumber
        End Get
        Set(value As Integer)
            m_officeNumber = value
        End Set
    End Property

    Function CSV() As String
        Return m_FirstName & "," & m_LastName & "," & m_Email & "," & m_officeNumber
    End Function
End Class

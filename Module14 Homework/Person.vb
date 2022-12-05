Public MustInherit Class Person

    Public m_FirstName As String
    Public m_LastName As String
    Public m_Email As String

    Public Property FirstName() As String
        Get
            Return m_FirstName
        End Get
        Set(value As String)
            m_FirstName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return m_LastName
        End Get
        Set(value As String)
            m_LastName = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return m_Email
        End Get
        Set(value As String)
            m_Email = value
        End Set
    End Property
End Class

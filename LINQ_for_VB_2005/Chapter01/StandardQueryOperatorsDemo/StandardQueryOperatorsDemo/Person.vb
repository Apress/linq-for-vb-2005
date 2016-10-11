Public Class Person
    Dim _id As Integer
    Dim _idRole As Integer
    Dim _lastName As String
    Dim _firstName As String

    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property IDRole() As Integer
        Get
            Return _idRole
        End Get
        Set(ByVal value As Integer)
            _idRole = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

End Class

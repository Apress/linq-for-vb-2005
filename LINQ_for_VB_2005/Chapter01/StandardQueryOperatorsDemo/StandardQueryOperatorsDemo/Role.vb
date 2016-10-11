Public Class Role
    Dim _id As Integer
    Dim _roleDescription As String

    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property RoleDescription() As String
        Get
            Return _roleDescription
        End Get
        Set(ByVal value As String)
            _roleDescription = value
        End Set
    End Property

End Class

Public Class Salary
    Dim _idPerson As Integer
    Dim _year As Integer
    Dim _salary As Double

    Public Property IDPerson() As Integer
        Get
            Return _idPerson
        End Get
        Set(ByVal value As Integer)
            _idPerson = value
        End Set
    End Property

    Public Property Year() As Integer
        Get
            Return _year
        End Get
        Set(ByVal value As Integer)
            _year = value
        End Set
    End Property

    Public Property SalaryYear() As Double
        Get
            Return _salary
        End Get
        Set(ByVal value As Double)
            _salary = value
        End Set
    End Property

End Class

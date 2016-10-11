Imports System
Imports System.Data.DLinq
Imports System.Expressions
Imports System.Query
Imports System.Reflection

Public Class PeopleDataContext
    Inherits DataContext

    ' Methods
    Public Sub New()
        MyBase.New("Data Source=.;Initial Catalog=People;Integrated Security=True")
    End Sub

    Public Sub New(ByVal connection As String)
        MyBase.New(connection)
    End Sub

    <DeleteMethod()> _
    Public Sub DeleteRole(ByVal r As Role)
        MyBase.ExecuteCommand("exec uspDeleteRole @id={0}", r.ID)
    End Sub

    <InsertMethod()> _
    Public Sub InsertRole(ByVal r As Role)
        MyBase.ExecuteCommand("exec uspInsertRole @description={0}", r.RoleDescription)
    End Sub

    <[Function](Name:="[dbo].[udfGetInitials]")> _
    Public Function UdfGetInitials(ByVal id As Nullable(Of Integer)) As String
        Dim info As MethodInfo = MethodInfo.GetCurrentMethod()
        Dim mc As MethodCallExpression = expression.Call(info, _
                                        expression.Constant(Me), _
                                        New Expression() {expression.Constant(id, _
                                        GetType(Nullable(Of Integer)))})
        Return Sequence.Single(Of String)(MyBase.CreateQuery(Of String)(mc))
    End Function

    <UpdateMethod()> _
    Public Sub UpdateRole(ByVal oldRole As Role, ByVal newRole As Role)
        If (Not oldRole.RoleDescription Is newRole.RoleDescription) Then
            Dim iRowsAffected As Integer = MyBase.ExecuteCommand("exec uspUpdateRole @id={0}, @description={1}", newRole.ID, newRole.RoleDescription)
            If (iRowsAffected < 1) Then
                Throw New OptimisticConcurrencyException
            End If
        End If
    End Sub

    <StoredProcedure(Name:="uspCountPerson")> _
    Public Function UspCountPerson() As Integer
        Dim info As MethodInfo = MethodBase.GetCurrentMethod
        Dim result As StoredProcedureResult = MyBase.ExecuteStoredProcedure(info)
        Return result.ReturnValue.Value
    End Function

    <StoredProcedure(Name:="uspGetRoleDescription")> _
    Public Function UspGetRoleDescription(<Parameter(DbType:="VarChar(50)")> ByVal description As String) As StoredProcedureResult(Of Role)
        Return MyBase.ExecuteStoredProcedure(Of Role)(MethodBase.GetCurrentMethod, description)
    End Function

    <StoredProcedure(Name:="uspGetRolesAndPeople")> _
    Public Function UspGetRolesAndPeople() As StoredProcedureMultipleResult
        Return MyBase.ExecuteStoredProcedure(MethodBase.GetCurrentMethod)
    End Function

    <StoredProcedure(Name:="uspGetTotalSalaryAmountPerYear")> _
    Public Function UspGetTotalSalaryAmountPerYear(<Parameter(DbType:="Int")> ByVal year As Nullable(Of Integer), <Parameter(DbType:="Money")> ByRef amount As Nullable(Of Decimal)) As Integer
        Dim info As MethodInfo = MethodBase.GetCurrentMethod
        Dim result As StoredProcedureResult = MyBase.ExecuteStoredProcedure(info, year, amount)
        amount = result.GetParameterValue(1)
        Return result.ReturnValue.Value
    End Function

    ' Fields
    Public People As Table(Of Person)
    Public Roles As Table(Of Role)
    Public Salaries As Table(Of Salary)
End Class

<Table(Name:="Role")> _
Public Class Role
    ' Methods
    Public Sub New()
        Me._People = New EntitySet(Of Person)(New Notification(Of Person)(AddressOf Me.Attach_Person), New Notification(Of Person)(AddressOf Me.Detach_Person))
    End Sub

    Private Sub Attach_Person(ByVal entity As Person)
        entity.Role = Me
    End Sub

    Private Sub Detach_Person(ByVal entity As Person)
        entity.Role = Nothing
    End Sub


    ' Properties
    <Column(Name:="ID", Storage:="_ID", DbType:="int NOT NULL IDENTITY", ID:=True, AutoGen:=True)> _
    Public Property ID() As Integer
        Get
            Return Me._ID
        End Get
        Set(ByVal value As Integer)
            Me._ID = value
        End Set
    End Property

    <Association(Name:="FK_Person_Role", Storage:="_People", OtherKey:="IDRole")> _
    Public Property People() As EntitySet(Of Person)
        Get
            Return Me._People
        End Get
        Set(ByVal value As EntitySet(Of Person))
            Me._People.Assign(value)
        End Set
    End Property

    <Column(Name:="RoleDescription", Storage:="_Description", DbType:="nvarchar NOT NULL")> _
    Public Property RoleDescription() As String
        Get
            Return Me._Description
        End Get
        Set(ByVal value As String)
            Me._Description = value
        End Set
    End Property


    ' Fields
    Private _Description As String
    Private _ID As Integer
    Private _People As EntitySet(Of Person)
End Class

<Table(Name:="Salary")> _
Public Class Salary
    ' Properties
    <Column(Name:="IDPerson", Storage:="_ID", DbType:="int NOT NULL")> _
    Public Property ID() As Integer
        Get
            Return Me._ID
        End Get
        Set(ByVal value As Integer)
            Me._ID = value
        End Set
    End Property

    <Column(Name:="SalaryYear", Storage:="_Salary", DbType:="money NOT NULL")> _
    Public Property SalaryYear() As Decimal
        Get
            Return Me._Salary
        End Get
        Set(ByVal value As Decimal)
            Me._Salary = value
        End Set
    End Property

    <Column(Name:="Year", Storage:="_Year", DbType:="int NOT NULL")> _
    Public Property Year() As Integer
        Get
            Return Me._Year
        End Get
        Set(ByVal value As Integer)
            Me._Year = value
        End Set
    End Property


    ' Fields
    Private _ID As Integer
    Private _Salary As Decimal
    Private _Year As Integer
End Class

<Table(Name:="Person")> _
Public Class Person
    ' Methods
    Public Sub New()
        Me._Role = New EntityRef(Of Role)
    End Sub


    ' Properties
    <Column(Name:="FirstName", Storage:="_firstName", DbType:="nvarchar NOT NULL")> _
    Public Property FirstName() As String
        Get
            Return Me._firstName
        End Get
        Set(ByVal value As String)
            Me._firstName = value
        End Set
    End Property

    <Column(Name:="ID", Storage:="_ID", DbType:="int NOT NULL IDENTITY", Id:=True, AutoGen:=True)> _
    Public Property ID() As Integer
        Get
            Return Me._ID
        End Get
        Set(ByVal value As Integer)
            Me._ID = value
        End Set
    End Property

    <Column(Name:="IDRole", Storage:="_IDRole", DbType:="int NOT NULL")> _
    Public Property IDRole() As Integer
        Get
            Return Me._IDRole
        End Get
        Set(ByVal value As Integer)
            Me._IDRole = value
        End Set
    End Property

    <Column(Name:="LastName", Storage:="_lastName", DbType:="nvarchar NOT NULL")> _
    Public Property LastName() As String
        Get
            Return Me._lastName
        End Get
        Set(ByVal value As String)
            Me._lastName = value
        End Set
    End Property

    <Association(Name:="FK_Person_Role", Storage:="_Role", ThisKey:="IDRole", IsParent:=True)> _
    Public Property Role() As Role
        Get
            Return Me._Role.Entity
        End Get
        Set(ByVal value As Role)
            Dim role1 As Role = Me._Role.Entity
            If (Not role1 Is value) Then
                If (Not role1 Is Nothing) Then
                    Me._Role.Entity = Nothing
                    role1.People.Remove(Me)
                End If
                Me._Role.Entity = value
                If (Not value Is Nothing) Then
                    value.People.Add(Me)
                End If
            End If
        End Set
    End Property


    ' Fields
    Private _firstName As String
    Private _ID As Integer
    Private _IDRole As Integer
    Private _lastName As String
    Private _Role As EntityRef(Of Role)
End Class

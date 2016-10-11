Imports System.Reflection

Module Module1
#Region "Data Source"
    Dim people As List(Of Person)
    Dim roles As List(Of Role)
    Dim salaries As List(Of Salary)
#End Region

    Sub Main()
        FillDataSource()

        ' Listing1_11()

        ' --- Listing 1-12
        'Dim p As New WhereWithIndex
        'p.Listing1_12(people)
        ' --- End of Listing 1-12

        ' Listing1_13()

        ' --- Listing 1-14
        'Dim p As New SelectWithIndex()
        'p.Listing1_14(people)
        ' --- End of Listing 1-14

        ' Listing1_15()

        ' --- Listing 1-16
        'Dim p As JoinExample = New JoinExample()
        'p.Listing1_16(people, roles)
        ' --- End of Listing 1-16

        ' --- Listing 1-17
        'Dim p As GroupJoinExample = New GroupJoinExample()
        'p.Listing1_17(people, roles)
        ' --- End of Listing 1-17

        ' Listing1_18()

        ' Listing1_19()

        ' --- Listing 1-20
        'Dim p As GroupByWithComparer = New GroupByWithComparer()
        'p.Listing1_20()
        ' --- End of Listing 1-20

        ' Listing1_21()

        ' Listing1_22()

        ' --- Listing 1-23
        'Dim p As OrderByWithComparer = New OrderByWithComparer()
        'p.Listing1_23()
        ' --- End of Listing 1-23

        ' Listing1_24()

        ' --- Listing 1-25
        'Dim p As SumExample = New SumExample()
        'p.Listing1_25(salaries)
        ' --- End of Listing 1-25

        ' Listing1_26()

        ' Listing1_27()

        ' --- Listing 1-28
        'Dim p As AggregateExample = New AggregateExample()
        'p.Listing1_28()
        ' --- End of Listing 1-28

        ' --- Listing 1-29
        'Dim p As AggregateExampleWithSeed = New AggregateExampleWithSeed()
        'p.Listing1_29()
        ' --- End of Listing 1-29

        ' Listing1_30()

        ' --- Listing 1-31
        'Dim p As TakeWhileExample = New TakeWhileExample()
        'p.Listing1_31()
        ' --- End of Listing 1-31

        ' Listing1_32()

        ' --- Listing 1-33
        'Dim p As FirstLastExample = New FirstLastExample()
        'p.Listing1_33()
        ' --- End of Listing 1-33

        ' --- Listing 1-34
        'Dim p As FirstLastOrDefaultExample = New FirstLastOrDefaultExample()
        'p.Listing1_34()
        ' --- End of Listing 1-34

        ' --- Listing 1-35
        'Dim p As SingleExample = New SingleExample()
        'p.Listing1_35()
        ' --- End of Listing 1-35

        ' --- Listing 1-36
        'Dim p As SingleOrDefaultExample = New SingleOrDefaultExample()
        'p.Listing1_36()
        ' --- End of Listing 1-36

        ' Listing1_37()

        ' Listing1_38()

        ' Listing1_39()

        ' Listing1_40()

        ' Listing1_41()

        ' --- Listing 1-42
        'Dim p As AllExample = New AllExample()
        'p.Listing1_42()
        ' --- End of Listing 1-42

        ' --- Listing 1-43
        'Dim p As AnyExample = New AnyExample()
        'p.Listing1_43()
        ' --- End of Listing 1-43

        ' Listing1_44()

        ' Listing1_45()

        ' Listing1_46()

        ' Listing1_47()

        ' Listing1_48()

        ' Listing1_49()

        ' Listing1_50()

        ' Listing1_51()

        ' Listing1_52()

        ' Listing1_53()

        ' --- Listing 1-54
        'Dim p As ToDictionaryExample = New ToDictionaryExample()
        'p.Listing1_54()
        ' --- End of Listing 1-54

        ' --- Listing 1-55
        'Dim p As ToLookupExample = New ToLookupExample()
        'p.Listing1_55(people, salaries)
        ' --- End of Listing 1-55
    End Sub

#Region "Data Source"
    Sub FillDataSource()
        people = New List(Of Person) { _
                   {ID := 1, IDRole := 1, LastName := "Anderson", FirstName := "Brad"}, _
                   {ID := 2, IDRole := 2, LastName := "Gray", FirstName := "Tom"}, _
                   {ID := 3, IDRole := 2, LastName := "Grant", FirstName := "Mary"}, _
                   {ID := 4, IDRole := 3, LastName := "Cops", FirstName := "Gary"} _
               }

        roles = New List(Of Role) { _
            {ID := 1, RoleDescription := "Manager"}, _
            {ID := 2, RoleDescription := "Developer"} _
        }

        salaries = New List(Of Salary) { _
                {IDPerson := 1, Year := 2004, SalaryYear := 10000.0}, _
                {IDPerson := 1, Year := 2005, SalaryYear := 15000.0}, _
                {IDPerson := 2, Year := 2005, SalaryYear := 15000.0} _
        }

    End Sub


#End Region

#Region "Listing 1-11"
    Sub Listing1_11()
        Dim query = From p In people _
            Where p.FirstName = "Brad" _
            Select p

        ObjectDumper.Write(query)

    End Sub
#End Region

#Region "Listing 1-13"
    Sub Listing1_13()

        Dim query = From p In people _
            Select p

        ObjectDumper.Write(query)
    End Sub
#End Region

#Region "Listing 1-15"
    Sub Listing1_15()
        Dim query = From p In people, r In roles _
            Where p.ID = 1 AndAlso r.ID = p.IDRole _
            Select New {p.FirstName, p.LastName, r.RoleDescription}

        ObjectDumper.Write(query)

    End Sub

#End Region

#Region "Listing 1-18"
    Sub Listing1_18()
        Dim query = From m In GetType(Integer).GetMethods() _
            Select m.Name

        ObjectDumper.Write(query)

        Console.WriteLine("-=-=-=-=-=-=-=-=-=")
        Console.WriteLine("After the GroupBy")
        Console.WriteLine("-=-=-=-=-=-=-=-=-=")

        Dim q = From m In GetType(Integer).GetMethods() _
            Group By m.Name _
            Select New {Name := it.Key}

        ObjectDumper.Write(q)

    End Sub
#End Region

#Region "Listing 1-19"
    Sub Listing1_19()
        Dim query = From m In GetType(Integer).GetMethods() _
            Group By m.Name _
            Select New {Name := it.Key, Overloads := it.Count}

        ObjectDumper.Write(query)
    End Sub
#End Region

#Region "Listing 1-21"
    Sub Listing1_21()
        Dim query = From m In GetType(Integer).GetMethods() _
            Group By m.Name _
            Select New {Name := it.Key} _
            Order By Name

        ObjectDumper.Write(query)
    End Sub
#End Region

#Region "Listing 1-22"
    Sub Listing1_22()
        Dim query = From p In people _
            Select p _
            Order By p.FirstName, p.LastName

        ObjectDumper.Write(query)
    End Sub
#End Region

#Region "Listing 1-24"
    Sub Listing1_24()
        Dim numbers As New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim query As Integer = numbers.Sum()
        ObjectDumper.Write(query)
    End Sub
#End Region

#Region "Listing 1-26"
    Sub Listing1_26()
        Dim query = From p In people, s In salaries _
            Where p.ID = 1 _
            Select s.SalaryYear

        Console.WriteLine("Minimum Salary:")
        Console.WriteLine(query.Min())

        Console.WriteLine("Maximum Salary:")
        Console.WriteLine(query.Max())

    End Sub
#End Region

#Region "Listing 1-27"
    Sub Listing1_27()
        Dim query = From p In people, s In salaries _
            Where p.ID = 1 AndAlso p.ID = s.IDPerson _
            Select s.SalaryYear

        Console.WriteLine("Average Salary:")
        Console.WriteLine(query.Average())

    End Sub
#End Region

#Region "Listing 1-30"
    Sub Listing1_30()
        Dim numbers As Integer() = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim query = numbers.Take(5)
        ObjectDumper.Write(query)
        Console.Write("Press Enter key to see the other elements...")
        Console.ReadLine()
        Dim query2 = numbers.Skip(5)
        ObjectDumper.Write(query2)
    End Sub
#End Region

#Region "Listing 1-32"
    Sub Listing1_32()
        Dim numbers As Integer() = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim moreNumbers As Integer() = New Integer() {10, 11, 12, 13}
        Dim query = numbers.Concat(moreNumbers)
        ObjectDumper.Write(query)
    End Sub
#End Region

#Region "Listing 1-37"
    Sub Listing1_37()
        Dim numbers As Integer() = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim query = numbers.ElementAt(4)
        ObjectDumper.Write(query)
    End Sub
#End Region

#Region "Listing 1-38"
    Sub Listing1_38()
        Dim numbers As Integer() = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim query = numbers.ElementAtOrDefault(9)
        ObjectDumper.Write(query)

    End Sub
#End Region

#Region "Listing 1-39"
    Sub Listing1_39()
        Dim p As IEnumerable(Of Person) = Sequence.Empty(Of Person)()
        ObjectDumper.Write(p)
    End Sub
#End Region

#Region "Listing 1-40"
    Sub Listing1_40()
        ObjectDumper.Write(Sequence.Range(1, 10))
    End Sub
#End Region

#Region "Listing 1-41"
    Sub Listing1_41()
        Dim p As IEnumerable(Of Person) = Sequence.Repeat(Of Person)(people(0), 10)
        ObjectDumper.Write(p)
    End Sub
#End Region

#Region "Listing 1-44"
    Sub Listing1_44()
        Dim numbers As Integer() = New Integer() {2, 6, 24, 56, 102}
        ObjectDumper.Write(IIf(numbers.Contains(102), "Yes, they are", "No, they aren't"))
    End Sub
#End Region

#Region "Listing 1-45"
    Sub Listing1_45()
        Dim sequence1 As Integer() = New Integer() {1, 2, 3, 4, 5}
        Dim sequence2 As Integer() = New Integer() {1, 2, 3, 4, 5}
        Console.WriteLine("Are those sequences equal?")
        ObjectDumper.Write(IIf(sequence1.EqualAll(sequence2), "Yes, they are", "No, they aren't"))
        Dim sequence3 As Integer() = New Integer() {5, 2, 3, 4, 1}
        Console.WriteLine("Are those sequences equal?")
        ObjectDumper.Write(IIf(sequence1.EqualAll(sequence3), "Yes, they are", "No, they aren't"))
    End Sub
#End Region

#Region "Listing 1-46"
    Sub Listing1_46()
        Dim numbers As Integer() = New Integer() {1, 1, 2, 3, 3}
        ObjectDumper.Write(numbers.Distinct())
    End Sub
#End Region

#Region "Listing 1-47"
    Sub Listing1_47()
        Dim numbers As Integer() = New Integer() {1, 1, 2, 3, 3}
        Dim numbers2 As Integer() = New Integer() {1, 3, 3, 4}
        ObjectDumper.Write(numbers.Intersect(numbers2))
    End Sub
#End Region

#Region "Listing 1-48"
    Sub Listing1_48()
        Dim numbers As Integer() = New Integer() {1, 1, 2, 3, 3}
        Dim numbers2 As Integer() = New Integer() {1, 3, 3, 4}
        ObjectDumper.Write(numbers.Union(numbers2))
    End Sub
#End Region

#Region "Listing 1-49"
    Sub Listing1_49()
        Dim numbers As Integer() = New Integer() {1, 2, 3, 4}
        Dim numbers2 As Integer() = New Integer() {1, 1, 3, 3}
        ObjectDumper.Write(numbers.Except(numbers2))
    End Sub
#End Region

#Region "Listing 1-50"
    Sub Listing1_50()
        Dim sequence As Object() = New Object() {1, "Hello", 2.0}

        ObjectDumper.Write(sequence.OfType(Of Double)())
    End Sub
#End Region

#Region "Listing 1-51"
    Sub Listing1_51()
        Dim doubles As Object() = New Object() {1.0, 2.0, 3.0}

        ObjectDumper.Write(doubles.Cast(Of Double)())
    End Sub
#End Region

#Region "Listing 1-52"
    Sub Listing1_52()
        Dim query = From p In people _
            Where p.LastName.Length = 4 _
            Select p.LastName

        Dim names As String() = query.ToArray()

        For Dim i As Integer = 0 To names.Length - 1
            Console.WriteLine(names(i))
        Next
    End Sub
#End Region

#Region "Listing 1-53"
    Sub Listing1_53()
        Dim query = From p In people _
            Where p.LastName.Length = 4 _
            Select p.LastName

        Dim names As List(Of String) = query.ToList(Of String)()
        ObjectDumper.Write(names)

    End Sub
#End Region

End Module

#Region "Listing 1-12"

Public Class WhereWithIndex
    Private Shared whereDelegate As Func(Of Person, Integer, Boolean)

    Private Shared Function whereCondition(ByVal p As Person, ByVal index As Integer) As Boolean
        Return (p.IDRole = index)
    End Function

    Public Sub Listing1_12(ByVal people As List(Of Person))
        whereDelegate = New Func(Of Person, Integer, Boolean)(AddressOf whereCondition)

        Dim result As IEnumerable(Of Person) = Sequence.Where(Of Person)(people, whereDelegate)

        ObjectDumper.Write(result)

    End Sub

End Class

#End Region

#Region "Listing 1-14"

Public NotInheritable Class Projection
    ' Methods
    Public Overrides Function Equals(ByVal obj1 As Object) As Boolean
        Dim f__1 As Projection = TryCast(obj1, Projection)
        If (f__1 Is Nothing) Then
            Return False
        End If
        If (Me.Position <> f__1.Position) Then
            Return False
        End If
        If Not (((Me.FirstName Is Nothing) AndAlso (f__1.FirstName Is Nothing)) OrElse Me.FirstName.Equals(f__1.FirstName)) Then
            Return False
        End If
        If Not (((Me.LastName Is Nothing) AndAlso (f__1.LastName Is Nothing)) OrElse Me.LastName.Equals(f__1.LastName)) Then
            Return False
        End If
        Return True
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim num1 As Integer = 0
        num1 = (num1 Xor Me.Position.GetHashCode)
        If (Not Me.FirstName Is Nothing) Then
            num1 = (num1 Xor Me.FirstName.GetHashCode)
        End If
        If (Not Me.LastName Is Nothing) Then
            num1 = (num1 Xor Me.LastName.GetHashCode)
        End If
        Return num1
    End Function

    Public Overrides Function ToString() As String
        Dim builder1 As New Text.StringBuilder
        builder1.Append("{")
        builder1.Append("Position")
        builder1.Append("=")
        builder1.Append(Me.Position)
        builder1.Append(", ")
        builder1.Append("FirstName")
        builder1.Append("=")
        builder1.Append(Me.FirstName)
        builder1.Append(", ")
        builder1.Append("LastName")
        builder1.Append("=")
        builder1.Append(Me.LastName)
        builder1.Append("}")
        Return builder1.ToString
    End Function


    ' Properties
    Public Property FirstName() As String
        Get
            Return Me._FirstName
        End Get
        Set(ByVal text1 As String)
            Me._FirstName = text1
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return Me._LastName
        End Get
        Set(ByVal text1 As String)
            Me._LastName = text1
        End Set
    End Property

    Public Property Position() As Integer
        Get
            Return Me._Position
        End Get
        Set(ByVal num1 As Integer)
            Me._Position = num1
        End Set
    End Property


    ' Fields
    Private _FirstName As String
    Private _LastName As String
    Private _Position As Integer
End Class

Public Class SelectWithIndex
    Private Shared selectDelegate As Func(Of Person, Integer, Projection)

    Private Shared Function selectProjection(ByVal p As Person, ByVal index As Integer) As Projection
        Dim proj As New Projection
        proj.Position = index
        proj.FirstName = p.FirstName
        proj.LastName = p.LastName

        Return proj
    End Function

    Public Sub Listing1_14(ByVal people As List(Of Person))
        selectDelegate = New Func(Of Person, Integer, Projection)(AddressOf selectProjection)

        Dim result As IEnumerable(Of Projection) = Sequence.Select(Of Person, Projection)(people, selectDelegate)

        ObjectDumper.Write(result)

    End Sub

End Class

#End Region

#Region "Listing 1-16"
Public Class JoinExample
    Private Shared Function outerDelegate(ByVal p As Person) As Integer
        Return p.IDRole
    End Function

    Private Shared Function innerDelegate(ByVal r As Role) As Integer
        Return r.ID
    End Function

    Private Shared Function resultDelegate(ByVal p As Person, ByVal r As Role) As Person
        Return p
    End Function


    Public Sub Listing1_16(ByVal people As List(Of Person), ByVal roles As List(Of Role))
        Dim outerKeySelector As New Func(Of Person, Integer)(AddressOf outerDelegate)
        Dim innerKeySelector As New Func(Of Role, Integer)(AddressOf innerDelegate)
        Dim resultSelector As New Func(Of Person, Role, Person)(AddressOf resultDelegate)

        Dim result As IEnumerable(Of Person) = Sequence.Join(Of Person, Role, Integer, Person) _
                (people, roles, outerKeySelector, innerKeySelector, resultSelector)

        ObjectDumper.Write(result)
    End Sub

End Class
#End Region

#Region "Listing 1-17"
Public Class GroupJoinExample
    Private Shared Function outerDelegate(ByVal p As Person) As Integer
        Return p.IDRole
    End Function

    Private Shared Function innerDelegate(ByVal r As Role) As Integer
        Return r.ID
    End Function

    Private Shared Function resultDelegate(ByVal p As Person, ByVal pr As IEnumerable(Of Role)) As IEnumerable(Of Role)
        Return pr
    End Function

    Public Sub Listing1_17(ByVal people As List(Of Person), ByVal roles As List(Of Role))
        Dim outerKeySelector As New Func(Of Person, Integer)(AddressOf outerDelegate)
        Dim innerKeySelector As New Func(Of Role, Integer)(AddressOf innerDelegate)
        Dim resultSelector As New Func(Of Person, IEnumerable(Of Role), IEnumerable(Of Role))(AddressOf resultDelegate)

        Dim result As IEnumerable(Of IEnumerable(Of Role)) = Sequence.GroupJoin(Of Person, Role, Integer, IEnumerable(Of Role))(people, roles, outerKeySelector, innerKeySelector, resultSelector)
        ObjectDumper.Write(result, 1)
    End Sub

End Class
#End Region

#Region "Listing 1-20"
Public Class GroupByWithComparer
    Private Shared Function comparer(ByVal d As String) As String
        Return d
    End Function

    Public Sub Listing1_20()
        Dim dictionary As String() = New String() _
            {"F:Apple", "F:Banana", _
            "T:House", "T:Phone", _
            "F:Cherry", "T:Computer"}

        Dim comparerDelegate As New Func(Of String, String)(AddressOf comparer)

        Dim query = Sequence.GroupBy(Of String, String)(dictionary, comparerDelegate, New MyComparer)

        ObjectDumper.Write(query, 1)

    End Sub
End Class
#End Region

#Region "Listing 1-23"
Public Class OrderByWithComparer
    Private Shared Function comparer(ByVal w As String) As String
        Return w
    End Function

    Public Sub Listing1_23()
        Dim dictionary As String() = New String() {"Apple", "_Banana", "Cherry"}

        Dim comparerDelegate As New Func(Of String, String)(AddressOf comparer)

        Dim query = Sequence.OrderBy(Of String, String)(dictionary, comparerDelegate, New MyOrderingComparer)

        ObjectDumper.Write(query)

    End Sub
End Class
#End Region

#Region "Listing 1-25"
Public Class SumExample
    Private Shared Function sumDelegate(ByVal s As Salary) As Double
        Return s.SalaryYear
    End Function

    Public Sub Listing1_25(ByVal salaries As List(Of Salary))
        Dim query = From s In salaries _
            Group By s.Year _
            Select it

        For Each Dim item In query
            Console.WriteLine("Year {0}: {1}", item.Key, Sequence.Sum(Of Salary)(item, New Func(Of Salary, Double)(AddressOf sumDelegate)))
        Next
    End Sub

End Class
#End Region

#Region "Listing 1-28"
Public Class AggregateExample
    Private Shared Function aggregateFunc(ByVal a As Integer, ByVal b As Integer) As Integer
        Return (a * b)
    End Function

    Public Sub Listing1_28()
        Dim numbers As Integer() = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim aggregateDelegate As New Func(Of Integer, Integer, Integer)(AddressOf aggregateFunc)
        Dim query = numbers.Aggregate(Of Integer)(aggregateDelegate)
        ObjectDumper.Write(query)
    End Sub
End Class
#End Region

#Region "Listing 1-29"
Public Class AggregateExampleWithSeed
    Private Shared Function aggregateFunc(ByVal a As Integer, ByVal b As Integer) As Integer
        Return IIf((a < b), (a * b), a)
    End Function


    Public Sub Listing1_29()
        Dim numbers As Integer() = New Integer() {9, 3, 5, 4, 2, 6, 7, 1, 8}
        Dim aggregateDelegate As New Func(Of Integer, Integer, Integer)(AddressOf aggregateFunc)
        Dim query = numbers.Aggregate(Of Integer, Integer)(5, aggregateDelegate)
        ObjectDumper.Write(query)
    End Sub
End Class
#End Region

#Region "Listing 1-31"
Public Class TakeWhileExample
    Private Shared Function takeFunc(ByVal n As Integer, ByVal index As Integer) As Boolean
        Return (n >= index)
    End Function

    Private Shared Function skipFunc(ByVal n As Integer, ByVal index As Integer) As Boolean
        Return (n >= index)
    End Function


    Public Sub Listing1_31()
        Dim numbers As Integer() = New Integer() {9, 3, 5, 4, 2, 6, 7, 1, 8}
        Dim takeDelegate As New Func(Of Integer, Integer, Boolean)(AddressOf takeFunc)
        Dim skipDelegate As New Func(Of Integer, Integer, Boolean)(AddressOf skipFunc)
        Dim query = numbers.TakeWhile(takeDelegate)
        ObjectDumper.Write(query)
        Console.Write("Press Enter key to see the other elements...")
        Console.ReadLine()
        Dim query2 = numbers.SkipWhile(skipDelegate)
        ObjectDumper.Write(query2)
    End Sub
End Class
#End Region

#Region "Listing 1-33"
Public Class FirstLastExample
    Private Shared Function firstFunc(ByVal n As Integer) As Boolean
        Return (n Mod 2 = 0)
    End Function

    Private Shared Function lastFunc(ByVal n As Integer) As Boolean
        Return (n Mod 2 = 0)
    End Function


    Public Sub Listing1_33()
        Dim numbers As Integer() = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim firstDelegate As New Func(Of Integer, Boolean)(AddressOf firstFunc)
        Dim lastDelegate As New Func(Of Integer, Boolean)(AddressOf lastFunc)

        Dim query = numbers.First()
        Console.WriteLine("The first element in the sequence")
        ObjectDumper.Write(query)
        query = numbers.Last()
        Console.WriteLine("The last element in the sequence")
        ObjectDumper.Write(query)
        Console.WriteLine("The first even element in the sequence")
        query = numbers.First(firstDelegate)
        ObjectDumper.Write(query)
        Console.WriteLine("The last even element in the sequence")
        query = numbers.Last(lastDelegate)
        ObjectDumper.Write(query)
    End Sub
End Class
#End Region

#Region "Listing 1-34"
Public Class FirstLastOrDefaultExample
    Private Shared Function firstFunc(ByVal n As Integer) As Boolean
        Return (n Mod 2 = 0)
    End Function

    Private Shared Function lastFunc(ByVal n As Integer) As Boolean
        Return (n Mod 2 = 1)
    End Function


    Public Sub Listing1_34()
        Dim numbers As Integer() = New Integer() {1, 3, 5, 7, 9}
        Dim firstDelegate As New Func(Of Integer, Boolean)(AddressOf firstFunc)
        Dim lastDelegate As New Func(Of Integer, Boolean)(AddressOf lastFunc)

        Dim query = numbers.FirstOrDefault(firstDelegate)
        Console.WriteLine("The first even element in the sequence")
        ObjectDumper.Write(query)
        Console.WriteLine("The last odd element in the sequence")
        query = numbers.LastOrDefault(lastDelegate)
        ObjectDumper.Write(query)
    End Sub
End Class
#End Region

#Region "Listing 1-35"
Public Class SingleExample
    Private Shared Function singleFunc(ByVal n As Integer) As Boolean
        Return (n > 8)
    End Function

    Public Sub Listing1_35()
        Dim numbers As Integer() = New Integer() {1, 3, 5, 7, 9}
        Dim singleDelegate As New Func(Of Integer, Boolean)(AddressOf singleFunc)

        Dim query = numbers.Single(singleDelegate)
        ObjectDumper.Write(query)
    End Sub
End Class
#End Region

#Region "Listing 1-36"
Public Class SingleOrDefaultExample
    Private Shared Function singleFunc(ByVal n As Integer) As Boolean
        Return (n > 9)
    End Function

    Public Sub Listing1_36()
        Dim numbers As Integer() = New Integer() {1, 3, 5, 7, 9}
        Dim singleDelegate As New Func(Of Integer, Boolean)(AddressOf singleFunc)

        Dim query = numbers.SingleOrDefault(singleDelegate)
        ObjectDumper.Write(query)
    End Sub
End Class
#End Region

#Region "Listing 1-42"
Public Class AllExample
    Private Shared Function allFunc(ByVal n As Integer) As Boolean
        Return (n Mod 2 = 0)
    End Function

    Public Sub Listing1_42()
        Dim numbers As Integer() = New Integer() {2, 6, 24, 56, 102}
        Dim allDelegate As New Func(Of Integer, Boolean)(AddressOf allFunc)

        ObjectDumper.Write(IIf(numbers.All(allDelegate), "Yes, they are", "No, they aren't"))
    End Sub
End Class
#End Region

#Region "Listing 1-43"
Public Class AnyExample
    Private Shared Function anyFunc(ByVal n As Integer) As Boolean
        Return (n Mod 2 = 1)
    End Function

    Public Sub Listing1_43()
        Dim numbers As Integer() = New Integer() {2, 6, 24, 56, 102}
        Dim allDelegate As New Func(Of Integer, Boolean)(AddressOf anyFunc)

        ObjectDumper.Write(IIf(numbers.Any(allDelegate), "Yes, they are", "No, they aren't"))
    End Sub
End Class
#End Region

#Region "Listing 1-54"
Public Class ToDictionaryExample
    Private Shared Function getKey(ByVal k As IGrouping(Of String, MethodInfo)) As String
        Return k.Key
    End Function

    Private Shared Function getCount(ByVal k As IGrouping(Of String, MethodInfo)) As Integer
        Return k.Count()
    End Function

    Public Sub Listing1_54()
        Dim keyDelegate As New Func(Of IGrouping(Of String, MethodInfo), String)(AddressOf getKey)
        Dim countDelegate As New Func(Of IGrouping(Of String, MethodInfo), Integer)(AddressOf getCount)

        Dim q = From m In GetType(Integer).GetMethods() _
            Group By m.Name _
            Select it

        Dim d As Dictionary(Of String, Integer) = Sequence.ToDictionary(Of IGrouping(Of String, MethodInfo), String, Integer)(q, keyDelegate, countDelegate)


    End Sub
End Class
#End Region

#Region "Listing 1-55"
Public Class ToLookupExample
    Private Shared Function yearKey(ByVal k As Salary) As String
        Return k.Year.ToString
    End Function

    Private Shared Function getSalary(ByVal k As Salary) As Salary
        Return k
    End Function


    Public Sub Listing1_55(ByVal people As List(Of Person), ByVal salaries As List(Of Salary))
        Dim yearDelegate As New Func(Of Salary, String)(AddressOf yearKey)
        Dim salaryDelegate As New Func(Of Salary, Salary)(AddressOf getSalary)

        Dim q As IEnumerable(Of Salary) = From p In people, s In salaries _
            Where p.ID = 1 AndAlso p.ID = s.IDPerson _
            Select s

        Dim d As Lookup(Of String, Salary) = Sequence.ToLookup(Of Salary, String, Salary)(q, yearDelegate, salaryDelegate)
    End Sub
End Class
#End Region

Imports System
Imports System.Collections.Generic

Public Class MyComparer
    Implements IEqualityComparer(Of String)

    ' Methods
    Public Function Equals(ByVal x As String, ByVal y As String) As Boolean Implements System.Collections.Generic.IEqualityComparer(Of String).Equals
        Return (x.Substring(0, 2) = y.Substring(0, 2))
    End Function

    Public Function GetHashCode(ByVal obj As String) As Integer Implements System.Collections.Generic.IEqualityComparer(Of String).GetHashCode
        Return obj.Substring(0, 2).GetHashCode
    End Function

End Class




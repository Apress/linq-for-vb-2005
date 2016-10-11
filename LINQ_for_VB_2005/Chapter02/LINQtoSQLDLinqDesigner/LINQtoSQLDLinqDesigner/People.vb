﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



Partial Public Class PeopleDataContext
    Inherits System.Data.DLinq.DataContext
    
    Public Roles As System.Data.DLinq.Table(Of Role)
    
    Public Persons As System.Data.DLinq.Table(Of Person)
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New(New System.Data.SqlClient.SqlConnection(Global.LINQtoSQLDLinqDesigner.Settings.Default.DataConnection))
    End Sub
End Class

<System.Data.DLinq.Table(Name:="Role")>  _
Partial Public Class Role
    Inherits Object
    Implements System.Data.DLinq.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    
    Private _ID As Integer
    
    Private _RoleDescription As String
    
    Private _Persons As System.Data.DLinq.EntitySet(Of Person)
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me._Persons = New System.Data.DLinq.EntitySet(Of Person)(AddressOf Me.Attach_Persons, AddressOf Me.Attach_Persons)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.Data.DLinq.Column(Name:="ID", Storage:="_ID", DBType:="int NOT NULL IDENTITY", Id:=true, AutoGen:=true)>  _
    Public Overridable Property ID() As Integer
        Get
            Return Me._ID
        End Get
        Set
            If (Me._ID.Equals(value) = false) Then
                Me.OnPropertyChanging("ID")
                Me._ID = value
                Me.OnPropertyChanged("ID")
            End If
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.Data.DLinq.Column(Name:="RoleDescription", Storage:="_RoleDescription", DBType:="nvarchar NOT NULL")>  _
    Public Overridable Property RoleDescription() As String
        Get
            Return Me._RoleDescription
        End Get
        Set
            If ((Me._RoleDescription Is value)  _
                        = false) Then
                Me.OnPropertyChanging("RoleDescription")
                Me._RoleDescription = value
                Me.OnPropertyChanged("RoleDescription")
            End If
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.Data.DLinq.Association(Name:="FK_Person_Role", Storage:="_Persons", OtherKey:="IDRole")>  _
    Public Overridable Property Persons() As System.Data.DLinq.EntitySet(Of Person)
        Get
            Return Me._Persons
        End Get
        Set
            Me._Persons.Assign(value)
        End Set
    End Property
    
    Public Event PropertyChanging As System.ComponentModel.PropertyChangedEventHandler Implements System.Data.DLinq.INotifyPropertyChanging.PropertyChanging
    
    Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overridable Sub OnPropertyChanging(ByVal propertyName As String)
        If (Not (Me.PropertyChangingEvent) Is Nothing) Then
            RaiseEvent PropertyChanging(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
        If (Not (Me.PropertyChangedEvent) Is Nothing) Then
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub Attach_Persons(ByVal entity As Person)
        Me.OnPropertyChanging(Nothing)
        entity.Role = Me
        Me.OnPropertyChanged(Nothing)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub Detach_Persons(ByVal entity As Person)
        Me.OnPropertyChanging(Nothing)
        entity.Role = Nothing
        Me.OnPropertyChanged(Nothing)
    End Sub
End Class

<System.Data.DLinq.Table(Name:="Person")>  _
Partial Public Class Person
    Inherits Object
    Implements System.Data.DLinq.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    
    Private _ID As Integer
    
    Private _IDRole As Integer
    
    Private _LastName As String
    
    Private _FirstName As String
    
    Private _Role As System.Data.DLinq.EntityRef(Of Role)
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me._Role = CType(Nothing, System.Data.DLinq.EntityRef(Of Role))
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.Data.DLinq.Column(Name:="ID", Storage:="_ID", DBType:="int NOT NULL IDENTITY", Id:=true, AutoGen:=true)>  _
    Public Overridable Property ID() As Integer
        Get
            Return Me._ID
        End Get
        Set
            If (Me._ID.Equals(value) = false) Then
                Me.OnPropertyChanging("ID")
                Me._ID = value
                Me.OnPropertyChanged("ID")
            End If
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.Data.DLinq.Column(Name:="IDRole", Storage:="_IDRole", DBType:="int NOT NULL")>  _
    Public Overridable Property IDRole() As Integer
        Get
            Return Me._IDRole
        End Get
        Set
            If (Me._IDRole.Equals(value) = false) Then
                Me.OnPropertyChanging("IDRole")
                Me._IDRole = value
                Me.OnPropertyChanged("IDRole")
            End If
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.Data.DLinq.Column(Name:="LastName", Storage:="_LastName", DBType:="nvarchar NOT NULL")>  _
    Public Overridable Property LastName() As String
        Get
            Return Me._LastName
        End Get
        Set
            If ((Me._LastName Is value)  _
                        = false) Then
                Me.OnPropertyChanging("LastName")
                Me._LastName = value
                Me.OnPropertyChanged("LastName")
            End If
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.Data.DLinq.Column(Name:="FirstName", Storage:="_FirstName", DBType:="nvarchar NOT NULL")>  _
    Public Overridable Property FirstName() As String
        Get
            Return Me._FirstName
        End Get
        Set
            If ((Me._FirstName Is value)  _
                        = false) Then
                Me.OnPropertyChanging("FirstName")
                Me._FirstName = value
                Me.OnPropertyChanged("FirstName")
            End If
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.Data.DLinq.Association(Name:="FK_Person_Role", Storage:="_Role", ThisKey:="IDRole", IsParent:=true)>  _
    Public Property Role() As Role
        Get
            Return Me._Role.Entity
        End Get
        Set
            If ((Me._Role.Entity Is value)  _
                        = false) Then
                Me.OnPropertyChanging("Role")
                If (Not (Me._Role.Entity) Is Nothing) Then
                    Me._Role.Entity = Nothing
                    Me._Role.Entity.Persons.Remove(Me)
                End If
                Me._Role.Entity = value
                If (Not (value) Is Nothing) Then
                    value.Persons.Add(Me)
                End If
                Me.OnPropertyChanged("Role")
            End If
        End Set
    End Property
    
    Public Event PropertyChanging As System.ComponentModel.PropertyChangedEventHandler Implements System.Data.DLinq.INotifyPropertyChanging.PropertyChanging
    
    Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overridable Sub OnPropertyChanging(ByVal propertyName As String)
        If (Not (Me.PropertyChangingEvent) Is Nothing) Then
            RaiseEvent PropertyChanging(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
        If (Not (Me.PropertyChangedEvent) Is Nothing) Then
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class

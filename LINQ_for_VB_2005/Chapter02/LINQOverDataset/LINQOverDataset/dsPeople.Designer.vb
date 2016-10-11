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

Imports System


<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
 Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.ComponentModel.ToolboxItem(true),  _
 System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 System.Xml.Serialization.XmlRootAttribute("dsPeople"),  _
 System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class dsPeople
    Inherits System.Data.DataSet
    
    Private tableRole As RoleDataTable
    
    Private _schemaSerializationMode As System.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Role")) Is Nothing) Then
                MyBase.Tables.Add(New RoleDataTable(ds.Tables("Role")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Role() As RoleDataTable
        Get
            Return Me.tableRole
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.BrowsableAttribute(true),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overrides Function Clone() As System.Data.DataSet
        Dim cln As dsPeople = CType(MyBase.Clone,dsPeople)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("Role")) Is Nothing) Then
                MyBase.Tables.Add(New RoleDataTable(ds.Tables("Role")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableRole = CType(MyBase.Tables("Role"),RoleDataTable)
        If (initTable = true) Then
            If (Not (Me.tableRole) Is Nothing) Then
                Me.tableRole.InitVars
            End If
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub InitClass()
        Me.DataSetName = "dsPeople"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dsPeople.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableRole = New RoleDataTable
        MyBase.Tables.Add(Me.tableRole)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Function ShouldSerializeRole() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
        Dim ds As dsPeople = New dsPeople
        Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
        xs.Add(ds.GetSchemaSerializable)
        Dim any As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Return type
    End Function
    
    Public Delegate Sub RoleRowChangeEventHandler(ByVal sender As Object, ByVal e As RoleRowChangeEvent)
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
     System.Serializable(),  _
     System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class RoleDataTable
        Inherits System.Data.TypedTableBase(Of RoleRow)
        
        Private columnID As System.Data.DataColumn
        
        Private columnRoleDescription As System.Data.DataColumn
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "Role"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal table As System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property IDColumn() As System.Data.DataColumn
            Get
                Return Me.columnID
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property RoleDescriptionColumn() As System.Data.DataColumn
            Get
                Return Me.columnRoleDescription
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As RoleRow
            Get
                Return CType(Me.Rows(index),RoleRow)
            End Get
        End Property
        
        Public Event RoleRowChanging As RoleRowChangeEventHandler
        
        Public Event RoleRowChanged As RoleRowChangeEventHandler
        
        Public Event RoleRowDeleting As RoleRowChangeEventHandler
        
        Public Event RoleRowDeleted As RoleRowChangeEventHandler
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Sub AddRoleRow(ByVal row As RoleRow)
            Me.Rows.Add(row)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Function AddRoleRow(ByVal RoleDescription As String) As RoleRow
            Dim rowRoleRow As RoleRow = CType(Me.NewRow,RoleRow)
            rowRoleRow.ItemArray = New Object() {Nothing, RoleDescription}
            Me.Rows.Add(rowRoleRow)
            Return rowRoleRow
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function FindByID(ByVal ID As Integer) As RoleRow
            Return CType(Me.Rows.Find(New Object() {ID}),RoleRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overrides Function Clone() As System.Data.DataTable
            Dim cln As RoleDataTable = CType(MyBase.Clone,RoleDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function CreateInstance() As System.Data.DataTable
            Return New RoleDataTable
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub InitVars()
            Me.columnID = MyBase.Columns("ID")
            Me.columnRoleDescription = MyBase.Columns("RoleDescription")
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitClass()
            Me.columnID = New System.Data.DataColumn("ID", GetType(Integer), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnID)
            Me.columnRoleDescription = New System.Data.DataColumn("RoleDescription", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnRoleDescription)
            Me.Constraints.Add(New System.Data.UniqueConstraint("Constraint1", New System.Data.DataColumn() {Me.columnID}, true))
            Me.columnID.AutoIncrement = true
            Me.columnID.AllowDBNull = false
            Me.columnID.ReadOnly = true
            Me.columnID.Unique = true
            Me.columnRoleDescription.AllowDBNull = false
            Me.columnRoleDescription.MaxLength = 50
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function NewRoleRow() As RoleRow
            Return CType(Me.NewRow,RoleRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As System.Data.DataRowBuilder) As System.Data.DataRow
            Return New RoleRow(builder)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(RoleRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanged(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.RoleRowChangedEvent) Is Nothing) Then
                RaiseEvent RoleRowChanged(Me, New RoleRowChangeEvent(CType(e.Row,RoleRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanging(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.RoleRowChangingEvent) Is Nothing) Then
                RaiseEvent RoleRowChanging(Me, New RoleRowChangeEvent(CType(e.Row,RoleRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.RoleRowDeletedEvent) Is Nothing) Then
                RaiseEvent RoleRowDeleted(Me, New RoleRowChangeEvent(CType(e.Row,RoleRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.RoleRowDeletingEvent) Is Nothing) Then
                RaiseEvent RoleRowDeleting(Me, New RoleRowChangeEvent(CType(e.Row,RoleRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub RemoveRoleRow(ByVal row As RoleRow)
            Me.Rows.Remove(row)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
            Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
            Dim ds As dsPeople = New dsPeople
            xs.Add(ds.GetSchemaSerializable)
            Dim any1 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "RoleDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Return type
        End Function
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Partial Public Class RoleRow
        Inherits System.Data.DataRow
        
        Private tableRole As RoleDataTable
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal rb As System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableRole = CType(Me.Table,RoleDataTable)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property ID() As Integer
            Get
                Return CType(Me(Me.tableRole.IDColumn),Integer)
            End Get
            Set
                Me(Me.tableRole.IDColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property RoleDescription() As String
            Get
                Return CType(Me(Me.tableRole.RoleDescriptionColumn),String)
            End Get
            Set
                Me(Me.tableRole.RoleDescriptionColumn) = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Public Class RoleRowChangeEvent
        Inherits System.EventArgs
        
        Private eventRow As RoleRow
        
        Private eventAction As System.Data.DataRowAction
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New(ByVal row As RoleRow, ByVal action As System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Row() As RoleRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Action() As System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class

Namespace dsPeopleTableAdapters
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.ComponentModel.ToolboxItem(true),  _
     System.ComponentModel.DataObjectAttribute(true),  _
     System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner"& _ 
        ", Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"),  _
     System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
    Partial Public Class RoleTableAdapter
        Inherits System.ComponentModel.Component
        
        Private WithEvents _adapter As System.Data.SqlClient.SqlDataAdapter
        
        Private _connection As System.Data.SqlClient.SqlConnection
        
        Private _commandCollection() As System.Data.SqlClient.SqlCommand
        
        Private _clearBeforeFill As Boolean
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New()
            MyBase.New
            Me.ClearBeforeFill = true
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private ReadOnly Property Adapter() As System.Data.SqlClient.SqlDataAdapter
            Get
                If (Me._adapter Is Nothing) Then
                    Me.InitAdapter
                End If
                Return Me._adapter
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Property Connection() As System.Data.SqlClient.SqlConnection
            Get
                If (Me._connection Is Nothing) Then
                    Me.InitConnection
                End If
                Return Me._connection
            End Get
            Set
                Me._connection = value
                If (Not (Me.Adapter.InsertCommand) Is Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Not (Me.Adapter.DeleteCommand) Is Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Not (Me.Adapter.UpdateCommand) Is Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                Do While (i < Me.CommandCollection.Length)
                    If (Not (Me.CommandCollection(i)) Is Nothing) Then
                        CType(Me.CommandCollection(i),System.Data.SqlClient.SqlCommand).Connection = value
                    End If
                    i = (i + 1)
                Loop
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected ReadOnly Property CommandCollection() As System.Data.SqlClient.SqlCommand()
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection
                End If
                Return Me._commandCollection
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me._clearBeforeFill
            End Get
            Set
                Me._clearBeforeFill = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter
            Dim tableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "Role"
            tableMapping.ColumnMappings.Add("ID", "ID")
            tableMapping.ColumnMappings.Add("RoleDescription", "RoleDescription")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[Role] WHERE (([ID] = @Original_ID) AND ([RoleDescription] = @O"& _ 
                "riginal_RoleDescription))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RoleDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "RoleDescription", System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Role] ([RoleDescription]) VALUES (@RoleDescription);"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"SELECT I"& _ 
                "D, RoleDescription FROM Role WHERE (ID = SCOPE_IDENTITY())"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RoleDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "RoleDescription", System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[Role] SET [RoleDescription] = @RoleDescription WHERE (([ID] = @Orig"& _ 
                "inal_ID) AND ([RoleDescription] = @Original_RoleDescription));"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"SELECT ID, RoleD"& _ 
                "escription FROM Role WHERE (ID = @ID)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RoleDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "RoleDescription", System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RoleDescription", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "RoleDescription", System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitConnection()
            Me._connection = New System.Data.SqlClient.SqlConnection
            Me._connection.ConnectionString = Global.LINQOverDataset.Settings.Default.PeopleConnectionString
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitCommandCollection()
            Me._commandCollection = New System.Data.SqlClient.SqlCommand(0) {}
            Me._commandCollection(0) = New System.Data.SqlClient.SqlCommand
            Me._commandCollection(0).Connection = Me.Connection
            Me._commandCollection(0).CommandText = "SELECT ID, RoleDescription FROM dbo.Role"
            Me._commandCollection(0).CommandType = System.Data.CommandType.Text
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
         System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, true)>  _
        Public Overloads Overridable Function Fill(ByVal dataTable As dsPeople.RoleDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = true) Then
                dataTable.Clear
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
         System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Overloads Overridable Function GetData() As dsPeople.RoleDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As dsPeople.RoleDataTable = New dsPeople.RoleDataTable
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
        Public Overloads Overridable Function Update(ByVal dataTable As dsPeople.RoleDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
        Public Overloads Overridable Function Update(ByVal dataSet As dsPeople) As Integer
            Return Me.Adapter.Update(dataSet, "Role")
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
        Public Overloads Overridable Function Update(ByVal dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow() {dataRow})
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
        Public Overloads Overridable Function Update(ByVal dataRows() As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
         System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overloads Overridable Function Delete(ByVal Original_ID As Integer, ByVal Original_RoleDescription As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_ID,Integer)
            If (Original_RoleDescription Is Nothing) Then
                Throw New System.ArgumentNullException("Original_RoleDescription")
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(Original_RoleDescription,String)
            End If
            Dim previousConnectionState As System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
            If ((Me.Adapter.DeleteCommand.Connection.State And System.Data.ConnectionState.Open)  _
                        <> System.Data.ConnectionState.Open) Then
                Me.Adapter.DeleteCommand.Connection.Open
            End If
            Try 
                Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery
                Return returnValue
            Finally
                If (previousConnectionState = System.Data.ConnectionState.Closed) Then
                    Me.Adapter.DeleteCommand.Connection.Close
                End If
            End Try
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
         System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overloads Overridable Function Insert(ByVal RoleDescription As String) As Integer
            If (RoleDescription Is Nothing) Then
                Throw New System.ArgumentNullException("RoleDescription")
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(RoleDescription,String)
            End If
            Dim previousConnectionState As System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And System.Data.ConnectionState.Open)  _
                        <> System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open
            End If
            Try 
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                Return returnValue
            Finally
                If (previousConnectionState = System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close
                End If
            End Try
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
         System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal RoleDescription As String, ByVal Original_ID As Integer, ByVal Original_RoleDescription As String, ByVal ID As Integer) As Integer
            If (RoleDescription Is Nothing) Then
                Throw New System.ArgumentNullException("RoleDescription")
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = CType(RoleDescription,String)
            End If
            Me.Adapter.UpdateCommand.Parameters(1).Value = CType(Original_ID,Integer)
            If (Original_RoleDescription Is Nothing) Then
                Throw New System.ArgumentNullException("Original_RoleDescription")
            Else
                Me.Adapter.UpdateCommand.Parameters(2).Value = CType(Original_RoleDescription,String)
            End If
            Me.Adapter.UpdateCommand.Parameters(3).Value = CType(ID,Integer)
            Dim previousConnectionState As System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
            If ((Me.Adapter.UpdateCommand.Connection.State And System.Data.ConnectionState.Open)  _
                        <> System.Data.ConnectionState.Open) Then
                Me.Adapter.UpdateCommand.Connection.Open
            End If
            Try 
                Dim returnValue As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery
                Return returnValue
            Finally
                If (previousConnectionState = System.Data.ConnectionState.Closed) Then
                    Me.Adapter.UpdateCommand.Connection.Close
                End If
            End Try
        End Function
    End Class
End Namespace

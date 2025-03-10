﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="db_VMS")>  _
Partial Public Class vmsdbDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Inserttbl_activity(instance As tbl_activity)
    End Sub
  Partial Private Sub Updatetbl_activity(instance As tbl_activity)
    End Sub
  Partial Private Sub Deletetbl_activity(instance As tbl_activity)
    End Sub
  Partial Private Sub Inserttbl_vessel(instance As tbl_vessel)
    End Sub
  Partial Private Sub Updatetbl_vessel(instance As tbl_vessel)
    End Sub
  Partial Private Sub Deletetbl_vessel(instance As tbl_vessel)
    End Sub
  Partial Private Sub Inserttbl_vesselAct(instance As tbl_vesselAct)
    End Sub
  Partial Private Sub Updatetbl_vesselAct(instance As tbl_vesselAct)
    End Sub
  Partial Private Sub Deletetbl_vesselAct(instance As tbl_vesselAct)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.DXApplication1.Settings.Default.db_VMSConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property tbl_activities() As System.Data.Linq.Table(Of tbl_activity)
		Get
			Return Me.GetTable(Of tbl_activity)
		End Get
	End Property
	
	Public ReadOnly Property tbl_vessels() As System.Data.Linq.Table(Of tbl_vessel)
		Get
			Return Me.GetTable(Of tbl_vessel)
		End Get
	End Property
	
	Public ReadOnly Property tbl_vesselActs() As System.Data.Linq.Table(Of tbl_vesselAct)
		Get
			Return Me.GetTable(Of tbl_vesselAct)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tbl_activities")>  _
Partial Public Class tbl_activity
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ActivityID As Integer
	
	Private _ActivityName As String
	
	Private _ActivityDes As String
	
	Private _DateCreated As Date
	
	Private _tbl_vesselActs As EntitySet(Of tbl_vesselAct)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnActivityIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnActivityIDChanged()
    End Sub
    Partial Private Sub OnActivityNameChanging(value As String)
    End Sub
    Partial Private Sub OnActivityNameChanged()
    End Sub
    Partial Private Sub OnActivityDesChanging(value As String)
    End Sub
    Partial Private Sub OnActivityDesChanged()
    End Sub
    Partial Private Sub OnDateCreatedChanging(value As Date)
    End Sub
    Partial Private Sub OnDateCreatedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._tbl_vesselActs = New EntitySet(Of tbl_vesselAct)(AddressOf Me.attach_tbl_vesselActs, AddressOf Me.detach_tbl_vesselActs)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ActivityID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ActivityID() As Integer
		Get
			Return Me._ActivityID
		End Get
		Set
			If ((Me._ActivityID = value)  _
						= false) Then
				Me.OnActivityIDChanging(value)
				Me.SendPropertyChanging
				Me._ActivityID = value
				Me.SendPropertyChanged("ActivityID")
				Me.OnActivityIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ActivityName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property ActivityName() As String
		Get
			Return Me._ActivityName
		End Get
		Set
			If (String.Equals(Me._ActivityName, value) = false) Then
				Me.OnActivityNameChanging(value)
				Me.SendPropertyChanging
				Me._ActivityName = value
				Me.SendPropertyChanged("ActivityName")
				Me.OnActivityNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ActivityDes", DbType:="VarChar(50)")>  _
	Public Property ActivityDes() As String
		Get
			Return Me._ActivityDes
		End Get
		Set
			If (String.Equals(Me._ActivityDes, value) = false) Then
				Me.OnActivityDesChanging(value)
				Me.SendPropertyChanging
				Me._ActivityDes = value
				Me.SendPropertyChanged("ActivityDes")
				Me.OnActivityDesChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DateCreated", DbType:="Date NOT NULL")>  _
	Public Property DateCreated() As Date
		Get
			Return Me._DateCreated
		End Get
		Set
			If ((Me._DateCreated = value)  _
						= false) Then
				Me.OnDateCreatedChanging(value)
				Me.SendPropertyChanging
				Me._DateCreated = value
				Me.SendPropertyChanged("DateCreated")
				Me.OnDateCreatedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tbl_activity_tbl_vesselAct", Storage:="_tbl_vesselActs", ThisKey:="ActivityID", OtherKey:="ActivityID")>  _
	Public Property tbl_vesselActs() As EntitySet(Of tbl_vesselAct)
		Get
			Return Me._tbl_vesselActs
		End Get
		Set
			Me._tbl_vesselActs.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_tbl_vesselActs(ByVal entity As tbl_vesselAct)
		Me.SendPropertyChanging
		entity.tbl_activity = Me
	End Sub
	
	Private Sub detach_tbl_vesselActs(ByVal entity As tbl_vesselAct)
		Me.SendPropertyChanging
		entity.tbl_activity = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tbl_vessels")>  _
Partial Public Class tbl_vessel
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _VesselID As Integer
	
	Private _VesselName As String
	
	Private _DateCreated As Date
	
	Private _tbl_vesselActs As EntitySet(Of tbl_vesselAct)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnVesselIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnVesselIDChanged()
    End Sub
    Partial Private Sub OnVesselNameChanging(value As String)
    End Sub
    Partial Private Sub OnVesselNameChanged()
    End Sub
    Partial Private Sub OnDateCreatedChanging(value As Date)
    End Sub
    Partial Private Sub OnDateCreatedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._tbl_vesselActs = New EntitySet(Of tbl_vesselAct)(AddressOf Me.attach_tbl_vesselActs, AddressOf Me.detach_tbl_vesselActs)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VesselID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property VesselID() As Integer
		Get
			Return Me._VesselID
		End Get
		Set
			If ((Me._VesselID = value)  _
						= false) Then
				Me.OnVesselIDChanging(value)
				Me.SendPropertyChanging
				Me._VesselID = value
				Me.SendPropertyChanged("VesselID")
				Me.OnVesselIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VesselName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property VesselName() As String
		Get
			Return Me._VesselName
		End Get
		Set
			If (String.Equals(Me._VesselName, value) = false) Then
				Me.OnVesselNameChanging(value)
				Me.SendPropertyChanging
				Me._VesselName = value
				Me.SendPropertyChanged("VesselName")
				Me.OnVesselNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DateCreated", DbType:="Date NOT NULL")>  _
	Public Property DateCreated() As Date
		Get
			Return Me._DateCreated
		End Get
		Set
			If ((Me._DateCreated = value)  _
						= false) Then
				Me.OnDateCreatedChanging(value)
				Me.SendPropertyChanging
				Me._DateCreated = value
				Me.SendPropertyChanged("DateCreated")
				Me.OnDateCreatedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tbl_vessel_tbl_vesselAct", Storage:="_tbl_vesselActs", ThisKey:="VesselID", OtherKey:="VesselID")>  _
	Public Property tbl_vesselActs() As EntitySet(Of tbl_vesselAct)
		Get
			Return Me._tbl_vesselActs
		End Get
		Set
			Me._tbl_vesselActs.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_tbl_vesselActs(ByVal entity As tbl_vesselAct)
		Me.SendPropertyChanging
		entity.tbl_vessel = Me
	End Sub
	
	Private Sub detach_tbl_vesselActs(ByVal entity As tbl_vesselAct)
		Me.SendPropertyChanging
		entity.tbl_vessel = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tbl_vesselAct")>  _
Partial Public Class tbl_vesselAct
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _VactsID As Integer
	
	Private _VesselID As Integer
	
	Private _Location As String
	
	Private _ActivityID As Integer
	
	Private _Latitude As System.Nullable(Of Decimal)
	
	Private _Longitude As System.Nullable(Of Decimal)
	
	Private _Repair As String
	
	Private _Description As String
	
	Private _DateCreated As Date
	
	Private _DateUpdated As Date
	
	Private _DateAct As Date
	
	Private _tbl_activity As EntityRef(Of tbl_activity)
	
	Private _tbl_vessel As EntityRef(Of tbl_vessel)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnVactsIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnVactsIDChanged()
    End Sub
    Partial Private Sub OnVesselIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnVesselIDChanged()
    End Sub
    Partial Private Sub OnLocationChanging(value As String)
    End Sub
    Partial Private Sub OnLocationChanged()
    End Sub
    Partial Private Sub OnActivityIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnActivityIDChanged()
    End Sub
    Partial Private Sub OnLatitudeChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnLatitudeChanged()
    End Sub
    Partial Private Sub OnLongitudeChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnLongitudeChanged()
    End Sub
    Partial Private Sub OnRepairChanging(value As String)
    End Sub
    Partial Private Sub OnRepairChanged()
    End Sub
    Partial Private Sub OnDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnDescriptionChanged()
    End Sub
    Partial Private Sub OnDateCreatedChanging(value As Date)
    End Sub
    Partial Private Sub OnDateCreatedChanged()
    End Sub
    Partial Private Sub OnDateUpdatedChanging(value As Date)
    End Sub
    Partial Private Sub OnDateUpdatedChanged()
    End Sub
    Partial Private Sub OnDateActChanging(value As Date)
    End Sub
    Partial Private Sub OnDateActChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._tbl_activity = CType(Nothing, EntityRef(Of tbl_activity))
		Me._tbl_vessel = CType(Nothing, EntityRef(Of tbl_vessel))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VactsID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property VactsID() As Integer
		Get
			Return Me._VactsID
		End Get
		Set
			If ((Me._VactsID = value)  _
						= false) Then
				Me.OnVactsIDChanging(value)
				Me.SendPropertyChanging
				Me._VactsID = value
				Me.SendPropertyChanged("VactsID")
				Me.OnVactsIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VesselID", DbType:="Int NOT NULL")>  _
	Public Property VesselID() As Integer
		Get
			Return Me._VesselID
		End Get
		Set
			If ((Me._VesselID = value)  _
						= false) Then
				If Me._tbl_vessel.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnVesselIDChanging(value)
				Me.SendPropertyChanging
				Me._VesselID = value
				Me.SendPropertyChanged("VesselID")
				Me.OnVesselIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Location", DbType:="VarChar(50)")>  _
	Public Property Location() As String
		Get
			Return Me._Location
		End Get
		Set
			If (String.Equals(Me._Location, value) = false) Then
				Me.OnLocationChanging(value)
				Me.SendPropertyChanging
				Me._Location = value
				Me.SendPropertyChanged("Location")
				Me.OnLocationChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ActivityID", DbType:="Int NOT NULL")>  _
	Public Property ActivityID() As Integer
		Get
			Return Me._ActivityID
		End Get
		Set
			If ((Me._ActivityID = value)  _
						= false) Then
				If Me._tbl_activity.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnActivityIDChanging(value)
				Me.SendPropertyChanging
				Me._ActivityID = value
				Me.SendPropertyChanged("ActivityID")
				Me.OnActivityIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Latitude", DbType:="Decimal(9,6)")>  _
	Public Property Latitude() As System.Nullable(Of Decimal)
		Get
			Return Me._Latitude
		End Get
		Set
			If (Me._Latitude.Equals(value) = false) Then
				Me.OnLatitudeChanging(value)
				Me.SendPropertyChanging
				Me._Latitude = value
				Me.SendPropertyChanged("Latitude")
				Me.OnLatitudeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Longitude", DbType:="Decimal(9,6)")>  _
	Public Property Longitude() As System.Nullable(Of Decimal)
		Get
			Return Me._Longitude
		End Get
		Set
			If (Me._Longitude.Equals(value) = false) Then
				Me.OnLongitudeChanging(value)
				Me.SendPropertyChanging
				Me._Longitude = value
				Me.SendPropertyChanged("Longitude")
				Me.OnLongitudeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Repair", DbType:="VarChar(100)")>  _
	Public Property Repair() As String
		Get
			Return Me._Repair
		End Get
		Set
			If (String.Equals(Me._Repair, value) = false) Then
				Me.OnRepairChanging(value)
				Me.SendPropertyChanging
				Me._Repair = value
				Me.SendPropertyChanged("Repair")
				Me.OnRepairChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Description", DbType:="VarChar(100)")>  _
	Public Property Description() As String
		Get
			Return Me._Description
		End Get
		Set
			If (String.Equals(Me._Description, value) = false) Then
				Me.OnDescriptionChanging(value)
				Me.SendPropertyChanging
				Me._Description = value
				Me.SendPropertyChanged("Description")
				Me.OnDescriptionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DateCreated", DbType:="Date NOT NULL", IsDbGenerated:=true)>  _
	Public Property DateCreated() As Date
		Get
			Return Me._DateCreated
		End Get
		Set
			If ((Me._DateCreated = value)  _
						= false) Then
				Me.OnDateCreatedChanging(value)
				Me.SendPropertyChanging
				Me._DateCreated = value
				Me.SendPropertyChanged("DateCreated")
				Me.OnDateCreatedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DateUpdated", DbType:="Date NOT NULL", IsDbGenerated:=true)>  _
	Public Property DateUpdated() As Date
		Get
			Return Me._DateUpdated
		End Get
		Set
			If ((Me._DateUpdated = value)  _
						= false) Then
				Me.OnDateUpdatedChanging(value)
				Me.SendPropertyChanging
				Me._DateUpdated = value
				Me.SendPropertyChanged("DateUpdated")
				Me.OnDateUpdatedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DateAct", DbType:="Date NOT NULL")>  _
	Public Property DateAct() As Date
		Get
			Return Me._DateAct
		End Get
		Set
			If ((Me._DateAct = value)  _
						= false) Then
				Me.OnDateActChanging(value)
				Me.SendPropertyChanging
				Me._DateAct = value
				Me.SendPropertyChanged("DateAct")
				Me.OnDateActChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tbl_activity_tbl_vesselAct", Storage:="_tbl_activity", ThisKey:="ActivityID", OtherKey:="ActivityID", IsForeignKey:=true)>  _
	Public Property tbl_activity() As tbl_activity
		Get
			Return Me._tbl_activity.Entity
		End Get
		Set
			Dim previousValue As tbl_activity = Me._tbl_activity.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._tbl_activity.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._tbl_activity.Entity = Nothing
					previousValue.tbl_vesselActs.Remove(Me)
				End If
				Me._tbl_activity.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.tbl_vesselActs.Add(Me)
					Me._ActivityID = value.ActivityID
				Else
					Me._ActivityID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("tbl_activity")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tbl_vessel_tbl_vesselAct", Storage:="_tbl_vessel", ThisKey:="VesselID", OtherKey:="VesselID", IsForeignKey:=true)>  _
	Public Property tbl_vessel() As tbl_vessel
		Get
			Return Me._tbl_vessel.Entity
		End Get
		Set
			Dim previousValue As tbl_vessel = Me._tbl_vessel.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._tbl_vessel.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._tbl_vessel.Entity = Nothing
					previousValue.tbl_vesselActs.Remove(Me)
				End If
				Me._tbl_vessel.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.tbl_vesselActs.Add(Me)
					Me._VesselID = value.VesselID
				Else
					Me._VesselID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("tbl_vessel")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

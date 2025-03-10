Public Class mdlVesselActivity
    'Vessel Activity Info
    Public VactsID, VesselID, ActivityID As Integer
    Public DateAct, DateCreated, DateUpdated As Date
    Public Location, Repair, Description As String
    Public Latitude, Longitude As Decimal?

    Private dc As vmsdbDataContext
    Private _act As tbl_vesselAct
    Private _dc As vmsdbDataContext

    Sub New(ByRef dc_ As vmsdbDataContext)
        dc = dc_
    End Sub

    ' Constructor
    Sub New(ByVal vesselActID As Integer, ByRef dc_ As vmsdbDataContext)
        dc = dc_

        ' Query the list to find the matching VactsID
        Dim vsslAct = From i In dc.tbl_vesselActs Where i.VactsID = vesselActID Select i

        ' Populate the properties of the class
        For Each i In vsslAct
            VactsID = vesselActID
            DateAct = CDate(i.DateAct)
            VesselID = CInt(i.VesselID)
            Location = i.Location
            ActivityID = CInt(i.ActivityID)
            Latitude = CDec(i.Latitude)
            Longitude = CDec(i.Longitude)
            Repair = i.Repair
            Description = i.Description
            DateCreated = CDate(i.DateCreated)
            DateUpdated = CDate(i.DateUpdated)
        Next
    End Sub

    Sub New(act As tbl_vesselAct, dc As vmsdbDataContext)
        _dc = dc

        Dim i = act

        Me.VactsID = i.VactsID
        VesselID = i.VesselID
        ActivityID = i.ActivityID
        Location = i.Location
        Longitude = i.Longitude
        Latitude = i.Latitude
        Description = i.Description
        DateAct = i.DateAct
        Repair = i.Repair
        DateCreated = i.DateCreated
        DateUpdated = i.DateUpdated
    End Sub

    Sub Add()
        Dim vact As New tbl_vesselAct

        With vact
            .DateAct = DateAct
            .VesselID = VesselID
            .Location = Location
            .ActivityID = ActivityID
            .Latitude = Latitude
            .Longitude = Longitude
            .Repair = Repair
            .Description = Description
            .DateCreated = DateCreated
            .DateUpdated = DateUpdated

        End With

        dc.tbl_vesselActs.InsertOnSubmit(vact)
        dc.SubmitChanges()
        VactsID = vact.VactsID
    End Sub

    Sub Save()
        Dim vsslAct = From i In dc.tbl_vesselActs Where i.VactsID = VactsID Select i

        For Each i In vsslAct
            i.VesselID = VesselID
            i.ActivityID = ActivityID
            i.Location = Location
            i.Latitude = Latitude
            i.Longitude = Longitude
            i.Description = Description
            i.DateAct = DateAct
            i.Repair = Repair
            dc.SubmitChanges()
        Next
    End Sub

    Function GetRows() As List(Of mdlVesselActivity)
        Dim vaList As New List(Of mdlVesselActivity)

        Dim acts = From va In dc.tbl_vesselActs Select va

        For Each act In acts
            vaList.Add(New mdlVesselActivity(act, dc))
        Next

        Return vaList
    End Function

    Function GetVessel(ByVal vs As List(Of tbl_vessel)) As tbl_vessel
        Return (From i In vs Where i.VesselID = VesselID Select i).FirstOrDefault()
    End Function

    Function GetActivity(ByVal vs As List(Of tbl_activity)) As tbl_activity
        Return (From i In vs Where i.ActivityID = ActivityID Select i).FirstOrDefault()
    End Function
End Class


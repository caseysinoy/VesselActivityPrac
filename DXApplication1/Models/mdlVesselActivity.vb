Public Class mdlVesselActivity
    'Vessel Activity Info
    Public VactsID As Integer
    Public DateAct As Date
    Public VesselID As Integer
    Public Location As String
    Public ActivityID As Integer
    Public Latitude As Decimal
    Public Longitude As Decimal
    Public Repair As String
    Public Description As String
    Public DateCreated As Date
    Public DateUpdated As Date

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
        ' TODO: Complete member initialization 
        _act = act
        _dc = dc
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
            dc.SubmitChanges()
        Next
    End Sub

End Class


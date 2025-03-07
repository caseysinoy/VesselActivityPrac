Public Class mdlVessel
    'Vessel Info
    Public VesselID As Integer
    Public VesselName As String

    Private dc As vmsdbDataContext

    Sub New(ByRef dc_ As vmsdbDataContext)
        dc = dc_
    End Sub

    Sub New(ByVal vesselID As Integer, ByRef dc_ As vmsdbDataContext)
        dc = dc_

        ' Query the list to find the matching VactsID
        Dim vssl = From i In dc.tbl_vessels Where i.VesselID = vesselID Select i

        ' Populate the properties of the class
        For Each i In vssl
            Me.VesselID = vesselID
            VesselName = i.VesselName

        Next
    End Sub

    Private Property DateCreated As Date

End Class

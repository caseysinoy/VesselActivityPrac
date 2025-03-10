Public Class ctrlReports
    Private mdlVAct As mdlVesselActivity
    Private mdlAct As mdlActivity
    Private mdlVes As mdlVessel

    Private frmREP As frmReport

    Private dc As vmsdbDataContext

    Sub New()
        dc = New vmsdbDataContext

        mdlVAct = New mdlVesselActivity(dc)
        mdlAct = New mdlActivity(dc)
        mdlVes = New mdlVessel(dc)

        frmREP = New frmReport(Me)

        populateGrid()

        With frmREP
            hideColumns(.GridView1)
            .GridView1.ShowCustomization()

            .Show()
        End With

    End Sub

    Sub populateGrid()
        Dim dc = New vmsdbDataContext()
        Dim vact = New mdlVesselActivity(dc).GetRows()
        Dim vssl = (From v In dc.tbl_vessels Select v).ToList()
        Dim act = (From a In dc.tbl_activities Select a).ToList()

        Dim vdata = From i In vact
                    Let vessel = vssl.FirstOrDefault(Function(v) v.VesselID = i.VesselID)
                    Let activity = act.FirstOrDefault(Function(a) a.ActivityID = i.ActivityID)
                    Select New With {
                        .ControlID = i.VesselID,
                        .DateActivity = i.DateAct,
                        .VesselName = If(vessel IsNot Nothing, vessel.VesselName, "Unknown Vessel"),
                        .Location = i.Location,
                        .ActivityName = If(activity IsNot Nothing, activity.ActivityName, "Unknown Activity"),
                        .Latitude = i.Latitude,
                        .Longitude = i.Longitude,
                        .Repair = i.Repair,
                        .Description = i.Description
                    }

        frmREP.GridControl1.DataSource = vdata.ToList()
    End Sub

    Sub hideColumns(ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
        For Each col As DevExpress.XtraGrid.Columns.GridColumn In gridView.Columns
            col.Visible = False
        Next
    End Sub
End Class

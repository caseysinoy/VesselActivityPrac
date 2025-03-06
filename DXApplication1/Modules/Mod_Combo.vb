Module Mod_Combo

    Public Sub LoadComboActivities(ByRef cmb As DevExpress.XtraEditors.LookUpEdit)
        Dim dc As New vmsdbDataContext

        Dim act = From i In dc.tbl_activities Select i.ActivityID, i.ActivityName

        With cmb.Properties
            .DataSource = act.ToList()
            .DisplayMember = "ActivityName"
            .ValueMember = "ActivityID"
            .NullText = ""

            .Columns.Clear()
            .Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActivityName", "Activity Name"))
            .ShowHeader = False
            .ShowFooter = False
            .PopupWidth = cmb.Width
        End With
    End Sub

    Public Sub LoadComboVessel(ByRef cmb As DevExpress.XtraEditors.LookUpEdit)
        Dim dc As New vmsdbDataContext

        Dim act = From i In dc.tbl_vessels Select i.VesselID, i.VesselName

        With cmb.Properties
            .DataSource = act.ToList()
            .DisplayMember = "VesselName"
            .ValueMember = "VesselID"
            .NullText = ""

            .Columns.Clear()
            .Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("VesselName", "Vessel Name"))
            .ShowHeader = False
            .ShowFooter = False
            .PopupWidth = cmb.Width
        End With
    End Sub

    Public Sub LoadComboLocation(ByRef cmb As DevExpress.XtraEditors.ComboBoxEdit)
        cmb.Properties.Items.Add("General City")
        cmb.Properties.Items.Add("Sarangani Province")
        cmb.Properties.Items.Add("Davao City")
    End Sub


End Module

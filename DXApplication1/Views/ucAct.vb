Imports DevExpress.XtraGrid.Views.Grid

Public Class ucAct
    Inherits ucBase

    Sub New(ByVal title As String)
        InitializeComponent()

        MyBase.title = title
        LabelControl1.Text = title
        MyBase.indexField = "VactsID"

        GridView1.OptionsView.ShowFooter = False

        dtFrom.EditValue = Nothing
        dtTo.EditValue = Nothing

    End Sub

    ' Override method to refresh data in the grid
    Public Overrides Sub refreshData()
        Try
            ' Initialize data context
            Dim dc As New vmsdbDataContext

            ' Fetch data from tbl_vesselActs with optional date filtering
            Dim query = From i In dc.tbl_vesselActs
                        Join j In dc.tbl_vessels On i.VesselID Equals j.VesselID
                        Join k In dc.tbl_activities On i.ActivityID Equals k.ActivityID
                        Select New With {
                            .VactsID = i.VactsID,
                            .DateAct = i.DateAct,
                            .VesselName = j.VesselName,
                            .Location = i.Location,
                            .ActivityName = k.ActivityName,
                            .Latitude = i.Latitude,
                            .Longitude = i.Longitude,
                            .Repair = i.Repair,
                            .Description = i.Description
                        }

            ' Apply date filtering only if dtFrom and dtTo have values
            If dtFrom.EditValue IsNot Nothing AndAlso dtTo.EditValue IsNot Nothing Then
                Dim fromDate As Date = CDate(dtFrom.EditValue).Date
                Dim toDate As Date = CDate(dtTo.EditValue).Date.AddDays(1)
                query = query.Where(Function(i) i.DateAct >= fromDate AndAlso i.DateAct < toDate)
            End If

            ' Convert the query to a list
            Dim ds_db = query.ToList()

            ' Bind data to the grid
            GridControl1.DataSource = ds_db

            ' Apply grid transformation
            gridTransMode(GridView1)

            ' Hide VactsID column if it exists
            If GridView1.Columns("VactsID") IsNot Nothing Then
                GridView1.Columns("VactsID").Visible = False
            End If

            ' Update grid count
            gvCount(GridView1)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Overrides Sub loadRecord(ByVal recordID As Integer)
        Dim rec As New ctlrVA(recordID)
    End Sub
End Class
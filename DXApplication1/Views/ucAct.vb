Imports DevExpress.XtraGrid.Views.Grid

Public Class ucAct
    Inherits ucBase

    ' Constructor
    Sub New(ByVal title As String)
        InitializeComponent()

        MyBase.title = title
        LabelControl1.Text = title
        MyBase.indexField = "VactsID"

        ' Disable footer in GridView
        GridView1.OptionsView.ShowFooter = False
    End Sub

    ' Override method to handle new record creation
    Public Overrides Sub newRecord()
        Dim crf As New ctlrVA
        refreshData()
    End Sub

    ' Override method to refresh data in the grid
    Public Overrides Sub refreshData()
        Try
            ' Initialize data context
            Dim dc As New vmsdbDataContext

            ' Fetch data from the database
            Dim ds_db = (From i In dc.tbl_vesselActs
                         Where i.DateAct >= CDate(dtFrom.EditValue).Date AndAlso
                               i.DateAct < CDate(dtTo.EditValue).Date.AddDays(1)
                         Select va_ID = i.VactsID,
                                i.DateAct,
                                i.VesselID,
                                i.Location,
                                i.ActivityID,
                                i.Latitude,
                                i.Longitude,
                                i.Repair,
                                i.Description).ToList()

            ' Join data with additional tables (tbl_vessels and tbl_activities)
            Dim ds = (From i In ds_db
                      Join j In dc.tbl_vessels On i.VesselID Equals j.VesselID
                      Join k In dc.tbl_activities On i.ActivityID Equals k.ActivityID
                      Select i).ToList()



            ' Clear existing columns and bind data to the grid
            GridView1.Columns.Clear()
            GridControl1.DataSource = ds

            ' Apply grid transformation (assuming gridTransMode is a method to format the grid)
            gridTransMode(GridView1)
        Catch ex As Exception
            ' Handle exceptions (e.g., log the error or show a message to the user)
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
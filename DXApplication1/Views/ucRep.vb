Imports DevExpress.XtraGrid
Imports DevExpress.XtraPivotGrid
Public Class ucRep
    Inherits ucBase

    Private pgc As PivotGridControl

    Sub New(ByVal title As String)
        InitializeComponent()

        MyBase.title = title
        LabelControl1.Text = title

        GridView1.OptionsView.ShowFooter = False
        removeLayout()
        convert2PGC()
    End Sub

    Private Sub removeLayout()

        LayoutControl1.Remove(LayoutControlItem2, True)
        LayoutControl1.Remove(LayoutControlItem4, True)
        LayoutControl1.Remove(LayoutControlItem3, True)
        LayoutControl1.Remove(EmptySpaceItem4, True)
    End Sub

    Private Sub convert2PGC()
        If GridControl1 IsNot Nothing Then
            LayoutControl1.Remove(LayoutControlItem5, True)

            GetVsslActData()


            pgc = New PivotGridControl() With {
                .DataSource = GetVsslActData()
            }

            pgc.OptionsView.ShowColumnGrandTotals = False
            pgc.OptionsView.ShowRowGrandTotals = False

            Dim pgfAct As New PivotGridField("Activities", PivotArea.RowArea)
            Dim pgfVssl As New PivotGridField("Vessels", PivotArea.ColumnArea)
            Dim pgfCount As New PivotGridField("VesselActivities", PivotArea.DataArea) With {
                .SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
            }

            pgc.Fields.AddRange(New PivotGridField() {pgfAct, pgfVssl, pgfCount})

            LayoutControl1.AddItem("test", pgc)
            LayoutControlItem6.Height = 30
            LayoutControl1.Refresh()

            AddHandler pgc.CustomCellDisplayText, AddressOf Pivot_CustomCellDisplayText
        End If
    End Sub

    Private Function GetVsslActData() As IEnumerable(Of Object)
        Dim dc = New vmsdbDataContext()
        Dim vact = New mdlVesselActivity(dc).GetRows()
        Dim vssl = dc.tbl_vessels.ToList()
        Dim acts = dc.tbl_activities.ToList()

        Return (From i In vact
                Select New With {
                    .VactsID = i.VactsID,
                    .Vessels = i.GetVessel(vssl).VesselName,
                    .Activities = i.GetActivity(acts).ActivityName,
                    .VesselActivities = i.VactsID
                }).ToList()
    End Function

    Private Sub Pivot_CustomCellDisplayText(sender As Object, e As PivotCellDisplayTextEventArgs)
        If e.Value Is Nothing OrElse IsDBNull(e.Value) Then
            e.DisplayText = "0"
        End If
    End Sub

    Public Overrides Sub refreshData()
        pgc.DataSource = GetVsslActData()
    End Sub


End Class

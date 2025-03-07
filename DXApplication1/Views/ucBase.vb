Public Class ucBase
    Public title As String
    Public indexField As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dateNow = getServerDate()
        dtFrom.EditValue = dateNow.AddDays(-30)
        dtTo.EditValue = dateNow
    End Sub

    Sub hideDate()
        LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Private Sub btn_Filter_Click(sender As Object, e As EventArgs) Handles btn_Filter.Click
        refreshData()
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        'newRecord()
        refreshData()
    End Sub

    Private Sub GridControl1_Load(sender As Object, e As EventArgs) Handles GridControl1.Load
        refreshData()
    End Sub

    Overridable Sub refreshData()

    End Sub
    Overridable Sub newRecord()

    End Sub
    Overridable Sub loadRecord(ByVal recordID As Integer)

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If GridView1.SelectedRowsCount > 0 Then
            Dim retVal As Integer = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, indexField))
            loadRecord(retVal)
        End If
    End Sub
End Class

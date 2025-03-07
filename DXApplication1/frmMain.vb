Imports System.ComponentModel
Imports System.Text


Partial Public Class frmMain
    Public ucList As New List(Of ucBase)

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub addTab(ByVal uc As ucBase)
        ucList.Add(uc)
        xtraTab.TabPages.Add(uc.title)
        uc.Parent = xtraTab.TabPages(xtraTab.TabPages.Count - 1)
        uc.Dock = DockStyle.Fill
        xtraTab.TabPages(ucList.IndexOf(uc)).Show()
    End Sub

    Private Function inTabs(ByVal title As String) As Integer
        If ucList.Count = 0 Then
            Return -1
        End If
        Dim thisTab = ucList.Where(Function(x) x.title = title)
        If thisTab.Count = 0 Then
            Return -1
        End If
        Return ucList.IndexOf(thisTab.First)
    End Function

    Private Sub bbtn_ActivityList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtn_ActivityList.ItemClick
        Dim title = "Vessel Activity"
        Dim intab = inTabs(title)
        If intab = -1 Then
            Dim uc As New ucAct(title)
            addTab(uc)
        Else
            xtraTab.TabPages(intab).Show()
        End If
    End Sub

    Private Sub bbtnCreateAct_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnCreateAct.ItemClick
        ' Create an instance of the form you want to redirect to
        Dim formAct As New ctlrVA()
    End Sub

    Private Sub xtraTab_CloseButtonClick(sender As Object, e As EventArgs) Handles xtraTab.CloseButtonClick
        Dim page As DevExpress.XtraTab.XtraTabPage = TryCast(xtraTab.SelectedTabPage, DevExpress.XtraTab.XtraTabPage)

        If page IsNot Nothing Then
            Dim ucToRemove = ucList.FirstOrDefault(Function(uc) uc.Parent Is page)

            If ucToRemove IsNot Nothing Then
                ucList.Remove(ucToRemove)
            End If

            xtraTab.TabPages.Remove(page)
        End If
    End Sub
End Class

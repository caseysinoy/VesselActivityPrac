Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks

Public Class frmReport

    Private ctrlRep As ctrlReports

    Sub New(ByRef ctrl As ctrlReports)
        InitializeComponent()
        ctrlRep = ctrl
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim printSystem As New PrintingSystem()
        Dim printLink As New PrintableComponentLink(printSystem)

        printLink.Component = GridControl1

        printLink.PaperKind = System.Drawing.Printing.PaperKind.A4
        printLink.Landscape = True

        AddHandler printLink.CreateReportHeaderArea, AddressOf PrintTitleHeader

        printLink.CreateDocument()
        printLink.ShowPreview()
    End Sub

    Private Sub PrintTitleHeader(sender As Object, e As CreateAreaEventArgs)
        ' Title
        Dim titleBrick As TextBrick = e.Graph.DrawString(
            "Vessel Activities Report",
            Color.Navy,
            New RectangleF(0, 0, 500, 100),
            BorderSide.None
        )
        titleBrick.Font = New Font("Segoe UI", 30, FontStyle.Bold)

        ' Subheader
        Dim subHeaderBrick As TextBrick = e.Graph.DrawString(
            "Detailed Overview as of " & DateTime.Now.ToString("MMMM dd, yyyy"),
            Color.Gray,
            New RectangleF(0, 100, 500, 50),
            BorderSide.None
        )
        subHeaderBrick.Font = New Font("Segoe UI", 18, FontStyle.Regular)

    End Sub

End Class
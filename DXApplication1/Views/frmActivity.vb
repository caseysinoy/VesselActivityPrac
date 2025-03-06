Imports System.Text
Public Class frmActivity
    Private ctrlACT As ctlrVA
    Public confirmClose As Boolean = True

    Sub New(ByRef ctrl As ctlrVA)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ctrlACT = ctrl

    End Sub

    Private Sub bbtn_saveAct_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtn_saveAct.ItemClick
        'Validate
        Dim actDate As Boolean = validateField(deActDate)
        Dim vsslName As Boolean = validateField(cbVessel)
        Dim vsslLoc As Boolean = validateField(cbLoc)
        Dim vsslAct As Boolean = validateField(cbAct)
        Dim vsslLat As Boolean = validateField(seLati)
        Dim vsslLong As Boolean = validateField(seLongi)
        Dim vsslRep As Boolean = validateField(teRep)
        Dim vsslDesc As Boolean = validateField(teDesc)

        If actDate AndAlso vsslName AndAlso vsslLoc AndAlso vsslAct AndAlso vsslLat AndAlso _
            vsslLong AndAlso vsslRep AndAlso vsslDesc Then
            'ctrlACT.save()
            If ctrlACT.save() Then
                ConfirmVerifyMessage()
                confirmClose = False
                Me.Close()
            End If
        Else
            Dim builder As New StringBuilder
            If Not actDate Then builder.Append("Activity Date").AppendLine()
            If Not vsslName Then builder.Append("Vessel Name").AppendLine()
            If Not vsslLoc Then builder.Append("Location").AppendLine()
            If Not vsslAct Then builder.Append("Activity").AppendLine()
            If Not vsslLat Then builder.Append("Latitude").AppendLine()
            If Not vsslLong Then builder.Append("Longitude").AppendLine()
            If Not vsslRep Then builder.Append("Repair").AppendLine()
            If Not vsslDesc Then builder.Append("Description").AppendLine()
            Dim fields As String = builder.ToString
            RequiredMessage(fields)
        End If
        'ctrlACT.save()
    End Sub

End Class
Imports DevExpress.XtraEditors
Imports System.Transactions

Public Class ctlrVA
    Private isNew As Boolean

    Private mdlVAct As mdlVesselActivity
    Private mdlAct As mdlActivity
    Private mdlVes As mdlVessel

    Private frmACT As frmActivity

    Private dc As vmsdbDataContext

    Sub New()
        isNew = True

        dc = New vmsdbDataContext


        ' Create an instance of mdlAcitivity
        mdlVAct = New mdlVesselActivity(dc)

        frmACT = New frmActivity(Me)

        loadCombo()

        With frmACT
            .Show()
        End With
    End Sub

    Sub New(ByVal VactsID As Integer)
        isNew = False

        dc = New vmsdbDataContext

        mdlVAct = New mdlVesselActivity(VactsID, dc)

        mdlAct = New mdlActivity(mdlVAct.ActivityID, dc)
        mdlVes = New mdlVessel(mdlVAct.VesselID, dc)

        frmACT = New frmActivity(Me)

        loadCombo()

        Debug.WriteLine(mdlAct.ActivityID)

        With frmACT
            .deActDate.EditValue = mdlVAct.DateAct
            .cbVessel.EditValue = mdlVes.VesselID
            .cbLoc.EditValue = mdlVAct.Location
            .cbAct.EditValue = mdlAct.ActivityID
            .seLati.EditValue = mdlVAct.Latitude
            .seLongi.EditValue = mdlVAct.Longitude
            .teRep.EditValue = mdlVAct.Repair
            .teDesc.EditValue = mdlVAct.Description
            .Text = "Edit Activity"
            '.LabelControl1.Text = "Save"
            '.bbtn_saveAct.Text = "Save"
            '.action = "Saved"
            .Show()
        End With

        Debug.WriteLine(mdlAct.ActivityID)
    End Sub

    Sub Save()
        Using ts As New TransactionScope()
            Try
                'add from Reference
                With mdlVAct
                    .DateAct = CDate(frmACT.deActDate.EditValue)
                    .VesselID = CInt(frmACT.cbVessel.EditValue)
                    .Location = frmACT.cbLoc.Text
                    .ActivityID = CInt(frmACT.cbAct.EditValue)
                    .Latitude = CDec(frmACT.seLati.EditValue)
                    .Longitude = CDec(frmACT.seLongi.EditValue)
                    .Repair = frmACT.teRep.Text
                    .Description = frmACT.teDesc.Text
                    If isNew Then
                        .Add()
                    Else
                        .Save()
                    End If
                End With

                ts.Complete()

            Catch ex As Exception
                ErrorMessage(ex, True)
                ErrorMessage("loadItem")
                'MessageBox("Error: " & ex.Message)
                'Return False
            End Try
        End Using
    End Sub

    Sub loadCombo()
        LoadComboActivities(frmACT.cbAct)
        LoadComboVessel(frmACT.cbVessel)
        LoadComboLocation(frmACT.cbLoc)
    End Sub

End Class
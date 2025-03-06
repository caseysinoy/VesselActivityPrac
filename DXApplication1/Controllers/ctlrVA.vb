Imports DevExpress.XtraEditors
Imports System.Transactions

Public Class ctlrVA
    Private isNew As Boolean
    Private mdlACT As mdlVesselActivity
    Private frmACT As frmActivity

    Private dc As vmsdbDataContext

    Sub New()
        isNew = True

        dc = New vmsdbDataContext


        ' Create an instance of mdlAcitivity
        mdlACT = New mdlVesselActivity(dc)

        frmACT = New frmActivity(Me)

        loadCombo()

        With frmACT
            .Show()
        End With
    End Sub

    Function save() As Boolean
        Try
            Using ts As New TransactionScope() 'add from Reference
                With mdlACT
                    .DateAct = CDate(frmACT.deActDate.EditValue)
                    .VesselID = CInt(frmACT.cbVessel.EditValue)
                    .Location = frmACT.cbVessel.Text
                    .ActivityID = CInt(frmACT.cbAct.EditValue)
                    .Latitude = CDec(frmACT.seLati.EditValue)
                    .Longitude = CDec(frmACT.seLongi.EditValue)
                    .Repair = frmACT.teRep.Text
                    .Description = frmACT.teDesc.Text
                    .Add()
                End With

                ts.Complete()

                Return True
            End Using
        Catch ex As Exception
            ErrorMessage(ex, True)
            ErrorMessage("loadItem")
            Return False
        End Try
    End Function

    Sub loadCombo()
        LoadComboActivities(frmACT.cbAct)
        LoadComboVessel(frmACT.cbVessel)
        LoadComboLocation(frmACT.cbLoc)
    End Sub

End Class
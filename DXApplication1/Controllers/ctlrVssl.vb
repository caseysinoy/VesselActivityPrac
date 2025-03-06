Imports DevExpress.XtraEditors
Imports System.Transactions
Public Class ctlrVssl
    Private isNew As Boolean
    Private mdlVssl As mdlVessel
    Private frmVssl As frmAddVssl

    Private dc As vmsdbDataContext

    Sub New()
        isNew = True

        dc = New vmsdbDataContext


        ' Create an instance of mdlAcitivity
        mdlVssl = New mdlVessel(dc)

        loadCombo()

        With frmVssl
            .Show()
        End With
    End Sub


    Sub loadCombo()
        'add here
    End Sub
End Class

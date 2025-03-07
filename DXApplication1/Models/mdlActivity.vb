Public Class mdlActivity
    'Activity Info
    Public ActivityID As Integer
    Public ActivityName As String
    Public ActivityDes As String

    Private dc As vmsdbDataContext

    Sub New(ByRef dc_ As vmsdbDataContext)
        dc = dc_
    End Sub

    Sub New(ByVal activityID As Integer, ByRef dc_ As vmsdbDataContext)
        dc = dc_

        ' Query the list to find the matching VactsID
        Dim act = From i In dc.tbl_activities Where i.ActivityID = activityID Select i

        ' Populate the properties of the class
        For Each i In act
            Me.ActivityID = activityID
            ActivityName = i.ActivityName
            ActivityDes = i.ActivityDes

        Next
    End Sub

End Class

'Implementation of Algorithm 24
Public Class TwoPointCrossover : Implements ICrossover

    Public Function DoCrossover(Parent_1 As BitArray, Parent_2 As BitArray) As List(Of BitArray) Implements ICrossover.DoCrossover
        Dim OffSprings As List(Of BitArray) = New List(Of BitArray)(2) From {
            Parent_1.Clone,
            Parent_2.Clone
        }
        Dim ParentLength = Parent_1.Length
        Dim r As New Random()

        Dim CrossOver_FrstPoint As Integer = r.Next(1, ParentLength)
        Dim CrossOver_SecPoint As Integer = r.Next(1, ParentLength)

        If CrossOver_FrstPoint > CrossOver_SecPoint Then
            SwapIndexes(CrossOver_FrstPoint, CrossOver_SecPoint)
        End If
        If CrossOver_FrstPoint <> CrossOver_SecPoint Then

            For i As Integer = CrossOver_FrstPoint To CrossOver_SecPoint - 1
                sawp(Parent_1, Parent_2, OffSprings, i)
            Next
        End If
        Return OffSprings
    End Function

    Private Shared Sub SwapIndexes(ByRef CrossOver_FrstPoint As Integer, ByRef CrossOver_SecPoint As Integer)
        Dim temp As Integer = CrossOver_FrstPoint
        CrossOver_FrstPoint = CrossOver_SecPoint
        CrossOver_SecPoint = temp
    End Sub

    Private Shared Sub sawp(Parent_1 As BitArray, Parent_2 As BitArray, OffSprings As List(Of BitArray), i As Integer)
        OffSprings(0).Set(i, Parent_2(i))
        OffSprings(1).Set(i, Parent_1(i))
    End Sub
End Class

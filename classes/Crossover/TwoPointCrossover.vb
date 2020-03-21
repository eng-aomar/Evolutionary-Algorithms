'Implementation of Algorithm 24
Public Class TwoPointCrossover : Implements ICrossover(Of ArrayList)

    Private Shared Sub SwapIndexes(ByRef CrossOver_FrstPoint As Integer, ByRef CrossOver_SecPoint As Integer)
        Dim temp As Integer = CrossOver_FrstPoint
        CrossOver_FrstPoint = CrossOver_SecPoint
        CrossOver_SecPoint = temp
    End Sub

    Private Shared Sub sawp(Parent_1 As ArrayList, Parent_2 As ArrayList, OffSprings As List(Of ArrayList), i As Integer)
        OffSprings(0)(i) = Parent_2(i)
        OffSprings(1)(i) = Parent_1(i)
    End Sub

    Private Function DoCrossover(Parent_1 As ArrayList, Parent_2 As ArrayList) As List(Of ArrayList) Implements ICrossover(Of ArrayList).DoCrossover
        Dim OffSprings As List(Of ArrayList) = New List(Of ArrayList)(2) From {
            Parent_1.Clone,
            Parent_2.Clone
        }
        Dim ParentLength = Parent_1.Count
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
End Class

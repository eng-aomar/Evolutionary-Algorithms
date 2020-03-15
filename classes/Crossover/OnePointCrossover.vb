Imports System.Text
'Implementation of Algorithm 23 Essetials Book
Public Class OnePointCrossover : Implements ICrossover
    Private OffSprings As List(Of BitArray)

    Public Function DoCrossover(Parent_1 As BitArray, Parent_2 As BitArray) As List(Of BitArray) Implements ICrossover.DoCrossover
       OffSprings = New List(Of BitArray)(2) From {
            Parent_1.Clone,
            Parent_2.Clone
        }
        Dim ParentLength = Parent_1.Length
        Dim r As New Random()

        Dim CrossOver_OnePoint As Integer = r.Next(1, ParentLength)
        If CrossOver_OnePoint <> 1 Then
            For i As Integer = CrossOver_OnePoint To ParentLength
                Swap(Parent_1, Parent_2, i)
            Next
        End If
        Return OffSprings
    End Function

    Private Sub Swap(Parent_1 As BitArray, Parent_2 As BitArray, i As Integer)
        OffSprings(0).Set(i, Parent_2(i))
        OffSprings(1).Set(i, Parent_1(i))
    End Sub

    Public Overrides Function ToString() As String
        Dim OffSprings0Builder As StringBuilder = New StringBuilder

        OffSprings0Builder.Append("OffSprings(0)")
        For Each bit In OffSprings(0).Cast(Of Boolean)()
            OffSprings0Builder.Append(If(bit, "1", "0"))
        Next
        OffSprings0Builder.Append(",")
        OffSprings0Builder.Append("OffSprings(1)")
        For Each bit In OffSprings(0).Cast(Of Boolean)()
            OffSprings0Builder.Append(If(bit, "1", "0"))
        Next
        Return OffSprings0Builder.ToString
    End Function
End Class

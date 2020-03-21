Imports System.Text
'Implementation of Algorithm 23 Essetials Book
Public Class OnePointCrossover : Implements ICrossover(Of ArrayList)
    Private OffSprings As List(Of ArrayList)

    Private Sub Swap(Parent_1 As ArrayList, Parent_2 As ArrayList, i As Integer)
        OffSprings(0)(i) = Parent_2(i)
        OffSprings(1)(i) = Parent_1(i)
        'OffSprings(0).set(i, Parent_2(i))
        'OffSprings(1).Set(i, Parent_1(i))
    End Sub

    'Public Overrides Function ToString() As String
    '    Dim OffSpringsBuilder As StringBuilder = New StringBuilder

    '    OffSpringsBuilder.Append("OffSprings(0)")
    '    For Each bit In OffSprings(0).Cast(Of Boolean)()
    '        OffSpringsBuilder.Append(If(bit, "1", "0"))
    '    Next
    '    OffSpringsBuilder.Append(",")
    '    OffSpringsBuilder.Append("OffSprings(1)")
    '    For Each bit In OffSprings(0).Cast(Of Boolean)()
    '        OffSpringsBuilder.Append(If(bit, "1", "0"))
    '    Next
    '    Return OffSpringsBuilder.ToString
    'End Function

    Public Function DoCrossover(Parent_1 As ArrayList, Parent_2 As ArrayList) As List(Of ArrayList) Implements ICrossover(Of ArrayList).DoCrossover
        OffSprings = New List(Of ArrayList)(2) From {
            Parent_1.Clone,
            Parent_2.Clone
        }
        Dim ParentLength = Parent_1.Count
        Dim r As New Random()

        Dim CrossOver_OnePoint As Integer = r.Next(1, ParentLength)
        If CrossOver_OnePoint <> 1 Then
            For i As Integer = CrossOver_OnePoint To ParentLength - 1
                Swap(Parent_1, Parent_2, i)
            Next
        End If
        Return OffSprings
    End Function
End Class

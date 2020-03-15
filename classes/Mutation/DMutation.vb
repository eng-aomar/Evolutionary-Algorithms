Public Class DMutation : Implements IMutation(Of ArrayList)
    'Displacment Mutation
    Public Function DoMutation(CrossedoverParent As ArrayList) As ArrayList Implements IMutation(Of ArrayList).DoMutation
        Dim MutatedChiled As ArrayList = New ArrayList(CrossedoverParent)
        ReomveSegmenet(MutatedChiled)
        Return InsertSegment(MutatedChiled)
    End Function
    Private Shared Sub ReomveSegmenet(MutatedChiled As ArrayList)
        Dim r As Random = Nothing
        Dim Segmenet As ArrayList = Nothing
        Dim FirstLoci As Integer = r.Next(MutatedChiled.Count)
        Dim SegmentLength As Integer = r.Next(MutatedChiled.Count - 1)
        Segmenet = MutatedChiled.GetRange(FirstLoci, SegmentLength)
        MutatedChiled.RemoveRange(FirstLoci, SegmentLength)
    End Sub
    Private Shared Function InsertSegment(MutatedChiled As ArrayList) As ArrayList
        Dim r As Random = Nothing
        Dim Segmenet As ArrayList = Nothing
        Dim SecondLloci As Integer = r.Next(MutatedChiled.Count)
        MutatedChiled.InsertRange(SecondLloci, Segmenet)
        Return MutatedChiled
    End Function
End Class

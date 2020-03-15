Public Class ISMutation : Implements IMutation(Of ArrayList)
    'Insert Mutation
    Public Function DoMutation(CrossedoverParent As ArrayList) As ArrayList Implements IMutation(Of ArrayList).DoMutation
        Dim MutatedChiled As ArrayList = New ArrayList(CrossedoverParent)
        DoInsertion(MutatedChiled)
    End Function

    Private Shared Sub DoInsertion(MutatedChiled As ArrayList)
        Dim r As New Random()
        Dim FirstLoci As Integer = r.Next(MutatedChiled.Count)
        Dim SecondLloci As Integer = r.Next(MutatedChiled.Count)
        MutatedChiled.Insert(SecondLloci, MutatedChiled(FirstLoci))
        MutatedChiled.Remove(MutatedChiled(FirstLoci))
    End Sub
End Class

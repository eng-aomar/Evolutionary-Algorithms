Public Class EMutation : Implements IMutation(Of ArrayList)

    Public Function DoMutation(CrossedoverParent As ArrayList) As ArrayList Implements IMutation(Of ArrayList).DoMutation
        Dim MutatedChiled As ArrayList = New ArrayList(CrossedoverParent)
        Return Swap(MutatedChiled)
    End Function

    Private Shared Function Swap(ByRef MutatedChiled As ArrayList) As ArrayList
        Dim r As New Random()
        Dim FirstLoci As Integer = r.Next(MutatedChiled.Count)
        Dim SecondLloci As Integer = r.Next(MutatedChiled.Count)
        Dim temp As String = MutatedChiled(FirstLoci)
        MutatedChiled(FirstLoci) = MutatedChiled(SecondLloci)
        MutatedChiled(SecondLloci) = temp
        Return MutatedChiled
    End Function
End Class

'Implementation is based on  Algorithm 8 Bounded Uniform Convolution
Public Class BUCMutation : Implements IMutation(Of ArrayList)

    Public Function DoMutation(CrossedoverParent As ArrayList) As ArrayList Implements IMutation(Of ArrayList).DoMutation
        Dim MutatedVector As ArrayList = CrossedoverParent.Clone

        ' to be done 
        Return MutatedVector
    End Function
End Class

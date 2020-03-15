Public Interface IMutation(Of T)
    Function DoMutation(ByVal CrossedoverParent As T) As T
End Interface

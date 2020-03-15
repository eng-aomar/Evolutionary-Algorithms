'implementation Of Algorthim number 2 pit-filp mutation
Public Class FilpMutation : Implements IMutation(Of BitArray)

    Private Mutation_Propablility As Double
    Private Const LOWER_BOUND As Integer = 0
    Private Const UPPER_BOUND As Integer = 1
    Public Sub New(mutation_Propablility As Double)
        Me.Mutation_Propablility = mutation_Propablility
    End Sub
    Public Property MutationPropablility() As Double
        Get
            Return Mutation_Propablility
        End Get
        Set(ByVal value As Double)
            Mutation_Propablility = value
        End Set
    End Property
    Public Function DoMutation(CrossedoverParent As BitArray) As BitArray Implements IMutation(Of BitArray).DoMutation
        Dim MutatedChiled As BitArray = New BitArray(CrossedoverParent)
        Dim r As New Random()
        For i As Integer = 1 To CrossedoverParent.Length
            Dim rand_num As Double = r.NextDouble() * Math.Abs(UPPER_BOUND - LOWER_BOUND) + LOWER_BOUND
            If Mutation_Propablility >= rand_num Then
                If MutatedChiled(i) Then
                    MutatedChiled(i) = False
                Else
                    MutatedChiled(i) = True
                End If
            End If
        Next
        Return MutatedChiled
    End Function
End Class

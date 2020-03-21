'Imlemetation of Algorithm number 25
Public Class UniformCrossover : Implements ICrossover(Of ArrayList)
    Private Crossover_probablity As Double
    Private Const LOWER_BOUND As Integer = 0
    Private Const UPPER_BOUND As Integer = 1
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
    Public Sub New(crossover_probablity As Double)
        Me.Crossover_probablity = crossover_probablity
    End Sub

    Public Property CrossoverProbablity() As Double
        Get
            Return Crossover_probablity
        End Get
        Set(ByVal value As Double)
            Crossover_probablity = value
        End Set
    End Property
    Private Shared Sub Swap(Parent_1 As ArrayList, Parent_2 As ArrayList, OffSprings As List(Of ArrayList), i As Integer)
        OffSprings(0)(i) = Parent_2(i)
        OffSprings(1)(i) = Parent_1(i)
    End Sub

    Private Shared Function GetRand_num() As Double
        Dim r As New Random()
        Return r.NextDouble() * Math.Abs(UPPER_BOUND - LOWER_BOUND) + LOWER_BOUND
    End Function

    Public Function DoCrossover(Parent_1 As ArrayList, Parent_2 As ArrayList) As List(Of ArrayList) Implements ICrossover(Of ArrayList).DoCrossover
        Dim OffSprings As List(Of ArrayList) = New List(Of ArrayList)(2) From {
           Parent_1.Clone,
           Parent_2.Clone
       }
        Dim ParentLength = Parent_1.Count

        For i As Integer = 1 To ParentLength - 1
            Dim rand_num As Double = GetRand_num()

            If CrossoverProbablity >= rand_num Then
                Swap(Parent_1, Parent_2, OffSprings, i)
            End If
        Next
        Return OffSprings
    End Function
End Class

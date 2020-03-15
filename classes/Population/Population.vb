Public Class Population
    Private popSize_local As Integer = 10
    Private indevidualSize_local As Integer = 10

    Public Sub New(popSize As Integer)
        Me.PopSize = popSize
    End Sub

    Public Sub New(popSize As Integer, indevidualSize As Integer)
        Me.PopSize = popSize
        Me.IndevidualSize = indevidualSize
    End Sub

    Private population_local As List(Of BitArray)
    Private ReadOnly LOWER_BOUND As Integer = 0
    Private ReadOnly UPPER_BOUND As Integer = 1
    Dim problem As MaxFx

    Public Property PopSize As Integer
        Get
            Return popSize_local
        End Get
        Set(value As Integer)
            popSize_local = value
        End Set
    End Property
    Public Property IndevidualSize As Integer
        Get
            Return indevidualSize_local
        End Get
        Set(value As Integer)
            indevidualSize_local = value
        End Set
    End Property

    Public Property PopulationList As List(Of BitArray)
        Get
            Return population_local
        End Get
        Set(value As List(Of BitArray))
            population_local = value
        End Set
    End Property

    Public Sub IntitlizePopulation()
        PopulationList = New List(Of BitArray)(PopSize)
        For i As Integer = 0 To PopSize - 1
            PopulationList.Add(InilizeIndividuale)
        Next

    End Sub
    'implemetation of alogorithm number 21 (Generate a random Bit-Vector)
    Private Function GetRandomBit() As Boolean
        ' Dim rng As Random = New Random()
        ' Dim randomBool As Boolean = rng.[Next](0, 2) > 0
        Dim r As New Random()
        Dim randomBool As Boolean
        Dim rand_num As Double = r.NextDouble() * Math.Abs(UPPER_BOUND - LOWER_BOUND) + LOWER_BOUND
        If 0.5 > rand_num Then
            randomBool = True
        Else
            randomBool = False
        End If
        Return randomBool
    End Function
    Public Function InilizeIndividuale() As BitArray
        Dim individual As BitArray = New BitArray(IndevidualSize)
        For i As Integer = 0 To IndevidualSize - 1
            individual(i) = GetRandomBit()
        Next
        Return individual
    End Function

    Public Function GetIndevidualByIndex(index As Integer) As BitArray
        Dim indevidual As BitArray
        indevidual = PopulationList(index)
        Return indevidual
    End Function
    Public Function GetPopulationIndividuals() As List(Of BitArray)
        Return PopulationList
    End Function
    Public Sub AddIndividual(ByVal individual As BitArray)
        PopulationList.Add(individual)
    End Sub
End Class

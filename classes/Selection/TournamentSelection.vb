'Impementation of Algorithm Number 32
'Oridinal Method
Public Class TournamentSelection : Implements ISelection(Of BitArray)
    Dim BestIndividual, NextIndivual As BitArray
    Private TournamentSize_local As Integer = 2
    Dim Problem As IProblem

    Public Property TournamentSize As Integer
        Get
            Return TournamentSize_local
        End Get
        Set(value As Integer)
            TournamentSize_local = value
        End Set
    End Property

    Public Sub New(tournamentSize_local As Integer)
        Me.TournamentSize = tournamentSize_local
    End Sub

    'Pick Random individual from Population
    Private Function Pick(population As Population) As BitArray

        Dim selected As BitArray = New BitArray(population.IndevidualSize)
        Dim rand As New Random
        Dim selectedIndex = rand.Next(1, population.PopSize)
        Return population.GetIndevidualByIndex(selectedIndex)
    End Function

    Public Function DoSelection(population As Population) As BitArray Implements ISelection(Of BitArray).DoSelection
        BestIndividual = Pick(population)
        NextIndivual = Pick(population)
        Problem = New OneMax
        Dim BestIndividual_Fitness As Integer = Problem.Evaluate(BestIndividual)
        Dim NextIndivual_Fitness As Integer = Problem.Evaluate(NextIndivual)
        For i As Integer = 2 To TournamentSize
            If NextIndivual_Fitness > BestIndividual_Fitness Then
                BestIndividual = NextIndivual
            End If

        Next
        Return BestIndividual
    End Function



    'implementation is based on Algorithm 32

End Class

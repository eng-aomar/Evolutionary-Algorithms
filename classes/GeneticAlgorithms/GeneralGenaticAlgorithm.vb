'Implement Algorithm Number 20
Imports System.Text

Public Class GeneralGenaticAlgorithm
    Private population As Population
    Private Q As Population
    Private crossove As ICrossover
    Private mutaion As FilpMutation
    Private Selection As ISelection
    Private Problem As IProblem
    Private popsize_local, indvidualSize_local, TournamentSize_local As Integer
    Private mutation_propablilty_local As Double = 1 / IndvidualSize  ' often p = 1/l where l is the length of the parent

    Private parenta As BitArray
    Private parentb As BitArray
    Public Sub New()
    End Sub

    Public Sub New(popSize As Integer, indvidualSize_local1 As Integer, tournamentSize As Integer, mutation_propablilty As Double)
        Me.PopSize = popSize
        Me.IndvidualSize = indvidualSize_local1
        Me.TournamentSize = tournamentSize
        Me.Mutation_propablilty = mutation_propablilty
    End Sub

    Public Property PopSize As Integer
        Get
            Return popsize_local
        End Get
        Set(value As Integer)
            popsize_local = value
        End Set
    End Property

    Public Property IndvidualSize As Integer
        Get
            Return indvidualSize_local
        End Get
        Set(value As Integer)
            indvidualSize_local = value
        End Set
    End Property

    Public Property Parenta1 As BitArray
        Get
            Return parenta
        End Get
        Set(value As BitArray)
            parenta = value
        End Set
    End Property

    Public Property Parentb1 As BitArray
        Get
            Return parentb
        End Get
        Set(value As BitArray)
            parentb = value
        End Set
    End Property

    Public Property TournamentSize As Integer
        Get
            Return TournamentSize_local
        End Get
        Set(value As Integer)
            TournamentSize_local = value
        End Set
    End Property

    Public Property Mutation_propablilty As Double
        Get
            Return mutation_propablilty_local
        End Get
        Set(value As Double)
            mutation_propablilty_local = value
        End Set
    End Property

    Public Property Q_population As Population
        Get
            Return Q
        End Get
        Set(value As Population)
            Q = value
        End Set
    End Property

    Public Sub BuildAlgorithm()
        'population = New Population(PopSize, IndvidualSize)
        'population.IntitlizePopulation()
        'Problem = New OneMax()
        'crossove = New OnePointCrossover()
        'mutaion = New Mutation(Mutation_propablilty)
        'Dim best As BitArray = population.InilizeIndividuale()
        'Selection = New TournamentSelection(TournamentSize)
        'For i As Integer = 1 To PopSize / 2
        '    Parenta1 = Selection.DoSelection(population)
        '    Parentb1 = Selection.DoSelection(population)
        '    Dim offsprings As List(Of BitArray) = crossove.DoCrossover(Parenta1, Parentb1)
        '    MsgBox(crossove.ToString)
        '    Q_population.AddIndividual(mutaion.BitFlipMutation(offsprings(0)))
        '    Q_population.AddIndividual(mutaion.BitFlipMutation(offsprings(1)))
        '    population.PopulationList.Add(Q_population.PopulationList(0))
        '    population.PopulationList.Add(Q_population.PopulationList(1))
        'Next
        Dim OffSpringsBuilder As StringBuilder = New StringBuilder
        Dim test As BitArray = New BitArray(10, 1)
        For Each bit In test.Cast(Of Boolean)()
            OffSpringsBuilder.Append(If(bit, "1", "0"))
        Next
        MsgBox(OffSpringsBuilder.ToString)

    End Sub
End Class

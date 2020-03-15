'Implementation of Algorithm Number 30 knows as Fitness-Proportionate Selection or SelectWithReplacement Techinque
'Fitness proportionate-based methods
Public Class RouletteSelection : Implements ISelection
    Dim _proplem As IProblem

    Public Sub New(proplem As IProblem)
        Me.Proplem = proplem
    End Sub

    Public Property Proplem As IProblem
        Get
            Return _proplem
        End Get
        Set(value As IProblem)
            _proplem = value
        End Set
    End Property

    Public Function DoSelection(population As Population) As BitArray Implements ISelection.DoSelection

        Dim indevidualSize As Integer = population.IndevidualSize
        Dim selectedParent As BitArray = New BitArray(indevidualSize)
        Dim fitnesses_values(indevidualSize) As Integer
        Dim sum As Integer = 0
        For i As Integer = 0 To population.PopSize - 1
            fitnesses_values(i) = Proplem.Evaluate(population.GetIndevidualByIndex(i))
            sum += fitnesses_values(i)
        Next
        Dim rand_num As Integer = GetRand_num(fitnesses_values(population.IndevidualSize))
        For index As Integer = 2 To indevidualSize

            If Search(fitnesses_values, rand_num, index) Then
                selectedParent = population.GetIndevidualByIndex(index)
            End If
        Next
        Return selectedParent
    End Function

    Private Shared Function Search(fitnesses_values() As Integer, rand_num As Integer, index As Integer) As Boolean
        Return fitnesses_values(index - 1) < rand_num <= fitnesses_values(index)
    End Function

    Private Function GetRand_num(ByVal max As Integer) As Integer
        Dim r As New Random()
        Return r.Next(0, max)
    End Function
End Class

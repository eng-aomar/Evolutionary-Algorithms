Public Class OneMax : Implements IProblem
    Private numberOfVariables As Integer = 0
    Private numberOfObjectives As Integer = 0
    Private numberOfConstraints As Integer = 0
    Private name As String = String.Empty

    Public Function GetNumberOfVariables() As Integer Implements IProblem.GetNumberOfVariables
        Return numberOfVariables
    End Function

    Public Function GetNumberOfObjectives() As Integer Implements IProblem.GetNumberOfObjectives
        Return numberOfObjectives
    End Function

    Public Function GetNumberOfConstataints() As Integer Implements IProblem.GetNumberOfConstataints
        Return numberOfConstraints
    End Function

    Public Function GetName() As String Implements IProblem.GetName
        Return name
    End Function

    Private Function IProblem_Evaluate(soltuion As BitArray) As Integer Implements IProblem.Evaluate
        Dim OnesCount As Integer
        For i As Integer = 0 To soltuion.Length
            If soltuion(i) Then
                OnesCount += OnesCount + 1
            End If
        Next
        Return OnesCount
    End Function
End Class

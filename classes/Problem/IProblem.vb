Public Interface IProblem
    Function GetNumberOfVariables() As Integer
    Function GetNumberOfObjectives() As Integer
    Function GetNumberOfConstataints() As Integer
    Function GetName() As String

    Function Evaluate(soltuion As BitArray) As Integer

End Interface

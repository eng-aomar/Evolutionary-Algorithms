Imports System.Text

Public Class MaxFx

    Private ReadOnly LOWER_BOUND As Integer = -1
    Private ReadOnly UPPER_BOUND As Integer = 2
    Private ReadOnly POP_SIZE = 10

    Public Function Claculate_X(chromosome() As Byte) As Decimal
        Dim sum As Integer = 0
        Dim TWO_TO_CHROMOSME_LENGETH_POWER As Integer = Math.Pow(2, chromosome.Length)
        Dim BOUNDSDIFF = (UPPER_BOUND - LOWER_BOUND) + LOWER_BOUND
        For index = 1 To chromosome.Length - 1
            sum += chromosome(index) * Math.Pow(2, index)
        Next
        Dim x As Decimal = sum / TWO_TO_CHROMOSME_LENGETH_POWER * BOUNDSDIFF
        Return x
    End Function
    Private Function Fitness(ByVal x As Decimal) As Decimal
        Dim objective_value As Decimal
        Dim constvalue = 10 * Math.PI * x
        objective_value = x + Math.Sin(constvalue) + 2
        Return objective_value
    End Function
    Private Function DecimalToBinary(DecimalNum As Long) As Char()
        Dim binaryArr As StringBuilder = New StringBuilder
        Dim n As Long

        n = DecimalNum

        binaryArr.Append(Trim(Str(n Mod 2)))
        n = n \ 2

        Do While n <> 0
            binaryArr.Append(Trim(Str(n Mod 2)))
            n = n \ 2
        Loop

        DecimalToBinary = binaryArr.ToString.ToCharArray
    End Function

    Public Function IntiaizePopulation() As String
        Dim populationArry As StringBuilder = New StringBuilder()

        Dim r As New Random()

        Dim individual() As Char
        For index As Integer = 0 To POP_SIZE - 1
            Dim i As Double = r.NextDouble() * Math.Abs(UPPER_BOUND - LOWER_BOUND) + LOWER_BOUND
            individual = DecimalToBinary(i)
            populationArry.Append(individual)
        Next
        Return populationArry.ToString()
    End Function


End Class

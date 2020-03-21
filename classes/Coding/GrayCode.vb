'implementation of algorithm number 40
Public Class GrayCode
    Protected Function DoGrayCode(ByVal Vector As BitArray) As BitArray
        Dim GrayCodeArry As BitArray = Vector.Clone

        Dim length As Integer = Vector.Length

        For index As Integer = 2 To length
            If GrayCodeArry(index) Then
                GrayCodeArry(index) = False
            End If
        Next
        Return GrayCodeArry
    End Function


End Class

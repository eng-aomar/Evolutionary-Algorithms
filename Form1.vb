Imports System.Text

Public Class Form1




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim p1 As BitArray = New BitArray(10, False)
        Dim p2 As BitArray = New BitArray(10, True)
        Dim offs As List(Of BitArray) = New List(Of BitArray)(2) From {
            p1.Clone,
            p2.Clone
        }
        Dim OffSprings0Builder As List(Of ArrayList) = New List(Of ArrayList)


        'ga = New GeneralGenaticAlgorithm(10, 10, 3, 0.1)
        'ga.BuildAlgorithm()
        ' ComboBox1.Items.AddRange([Enum].GetValues(GetType(EnumCrossover)))

        FillCrossoverCombo()
        FillSelectionCombo()
    End Sub
    Public Sub FillCrossoverCombo()
        For Each i In [Enum].GetValues(GetType(EnumCrossover))
            cmbCrossoverOperator.Items.Add(i)
        Next
    End Sub

    Public Sub FillSelectionCombo()
        For Each i In [Enum].GetValues(GetType(EnumSelection))
            cmbSelectionOperator.Items.Add(i)
        Next
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm As FrmCrossover = New FrmCrossover
        frm.ShowDialog()
    End Sub
End Class

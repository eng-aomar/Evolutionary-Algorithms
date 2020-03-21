Imports System.Text

Public Class FrmCrossover
    Dim crossover As ICrossover(Of ArrayList)
    Public Sub FillCrossoverCombo()
        For Each i In [Enum].GetValues(GetType(EnumCrossover))
            cmbCrossoverOperator.Items.Add(i)
        Next
    End Sub

    Private Sub FrmCrossover_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCrossoverCombo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbCrossoverOperator.SelectedIndex = 0 Then
            crossover = New OnePointCrossover()
        ElseIf cmbCrossoverOperator.SelectedIndex = 1 Then
            crossover = New TwoPointCrossover()
        ElseIf cmbCrossoverOperator.SelectedIndex = 2 Then
            crossover = New UniformCrossover(txtCrossover_pro.Text.Trim)
        End If

        Dim parent_b As ArrayList = New ArrayList()
        Dim parent_a As ArrayList = New ArrayList()
        parent_a = ToArrayList(txtParent_a.Text)
        parent_b = ToArrayList(txtParent_b.Text)

        Dim offsprings = crossover.DoCrossover(parent_a, parent_b)
        Dispaly(offsprings)
    End Sub

    Private Function ToArrayList(parent As String) As ArrayList
        Dim parent_local As ArrayList = New ArrayList()
        For i As Integer = 0 To parent.Length - 1
            parent_local.Add(txtParent_a.Text.ToList(i))
        Next
        Return parent_local
    End Function

    Private Sub Dispaly(offsprings As List(Of ArrayList))
        Dim childA As StringBuilder = New StringBuilder()
        For index As Integer = 0 To offsprings(0).Count - 1
            childA.Append(offsprings(0)(index))
        Next
        Dim childB As StringBuilder = New StringBuilder()
        For index As Integer = 0 To offsprings(1).Count - 1
            childB.Append(offsprings(1)(index))
        Next
        txtChild_a.Text = childA.ToString
        txtChild_b.Text = childB.ToString
    End Sub
End Class
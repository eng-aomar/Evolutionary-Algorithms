<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtIndividualSize = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMutationPropability = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPopSize = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSelectionOperator = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCrossover_pro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCrossoverOperator = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.66779!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.33221!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(689, 406)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtIndividualSize)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMutationPropability)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPopSize)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbSelectionOperator)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCrossover_pro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCrossoverOperator)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(685, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GA Parameters"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(576, 73)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtIndividualSize
        '
        Me.txtIndividualSize.Location = New System.Drawing.Point(403, 75)
        Me.txtIndividualSize.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIndividualSize.Name = "txtIndividualSize"
        Me.txtIndividualSize.Size = New System.Drawing.Size(149, 20)
        Me.txtIndividualSize.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Individual Size:"
        '
        'txtMutationPropability
        '
        Me.txtMutationPropability.Location = New System.Drawing.Point(403, 50)
        Me.txtMutationPropability.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMutationPropability.Name = "txtMutationPropability"
        Me.txtMutationPropability.Size = New System.Drawing.Size(149, 20)
        Me.txtMutationPropability.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mutation Propaplilty:"
        '
        'txtPopSize
        '
        Me.txtPopSize.Location = New System.Drawing.Point(142, 75)
        Me.txtPopSize.Name = "txtPopSize"
        Me.txtPopSize.Size = New System.Drawing.Size(148, 20)
        Me.txtPopSize.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Population Size:"
        '
        'cmbSelectionOperator
        '
        Me.cmbSelectionOperator.FormattingEnabled = True
        Me.cmbSelectionOperator.Location = New System.Drawing.Point(404, 25)
        Me.cmbSelectionOperator.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSelectionOperator.Name = "cmbSelectionOperator"
        Me.cmbSelectionOperator.Size = New System.Drawing.Size(149, 21)
        Me.cmbSelectionOperator.TabIndex = 5
        Me.cmbSelectionOperator.Text = "Choose selection method:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Selection Operator:"
        '
        'txtCrossover_pro
        '
        Me.txtCrossover_pro.Location = New System.Drawing.Point(142, 49)
        Me.txtCrossover_pro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCrossover_pro.Name = "txtCrossover_pro"
        Me.txtCrossover_pro.Size = New System.Drawing.Size(149, 20)
        Me.txtCrossover_pro.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Crossover Propaplilty:"
        '
        'cmbCrossoverOperator
        '
        Me.cmbCrossoverOperator.FormattingEnabled = True
        Me.cmbCrossoverOperator.Location = New System.Drawing.Point(141, 25)
        Me.cmbCrossoverOperator.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCrossoverOperator.Name = "cmbCrossoverOperator"
        Me.cmbCrossoverOperator.Size = New System.Drawing.Size(149, 21)
        Me.cmbCrossoverOperator.TabIndex = 1
        Me.cmbCrossoverOperator.Text = "choose crossover method"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crossover Operator:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(689, 406)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Genetaic Algorithms:"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbCrossoverOperator As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCrossover_pro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSelectionOperator As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIndividualSize As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMutationPropability As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPopSize As TextBox
    Friend WithEvents btnSearch As Button
End Class

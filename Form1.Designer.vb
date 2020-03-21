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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCrossoverOperator = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCrossover_pro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSelectionOperator = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPopSize = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMutationPropability = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIndividualSize = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.059022!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.94098!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1034, 593)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crossover Operator:"
        '
        'cmbCrossoverOperator
        '
        Me.cmbCrossoverOperator.FormattingEnabled = True
        Me.cmbCrossoverOperator.Location = New System.Drawing.Point(212, 37)
        Me.cmbCrossoverOperator.Name = "cmbCrossoverOperator"
        Me.cmbCrossoverOperator.Size = New System.Drawing.Size(222, 27)
        Me.cmbCrossoverOperator.TabIndex = 1
        Me.cmbCrossoverOperator.Text = "choose crossover method"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Crossover Propaplilty:"
        '
        'txtCrossover_pro
        '
        Me.txtCrossover_pro.Location = New System.Drawing.Point(213, 72)
        Me.txtCrossover_pro.Name = "txtCrossover_pro"
        Me.txtCrossover_pro.Size = New System.Drawing.Size(222, 27)
        Me.txtCrossover_pro.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(446, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Selection Operator:"
        '
        'cmbSelectionOperator
        '
        Me.cmbSelectionOperator.FormattingEnabled = True
        Me.cmbSelectionOperator.Location = New System.Drawing.Point(606, 37)
        Me.cmbSelectionOperator.Name = "cmbSelectionOperator"
        Me.cmbSelectionOperator.Size = New System.Drawing.Size(222, 27)
        Me.cmbSelectionOperator.TabIndex = 5
        Me.cmbSelectionOperator.Text = "Choose selection method:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Population Size:"
        '
        'txtPopSize
        '
        Me.txtPopSize.Location = New System.Drawing.Point(213, 110)
        Me.txtPopSize.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPopSize.Name = "txtPopSize"
        Me.txtPopSize.Size = New System.Drawing.Size(220, 27)
        Me.txtPopSize.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(442, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mutation Propaplilty:"
        '
        'txtMutationPropability
        '
        Me.txtMutationPropability.Location = New System.Drawing.Point(604, 73)
        Me.txtMutationPropability.Name = "txtMutationPropability"
        Me.txtMutationPropability.Size = New System.Drawing.Size(222, 27)
        Me.txtMutationPropability.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(480, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Individual Size:"
        '
        'txtIndividualSize
        '
        Me.txtIndividualSize.Location = New System.Drawing.Point(604, 110)
        Me.txtIndividualSize.Name = "txtIndividualSize"
        Me.txtIndividualSize.Size = New System.Drawing.Size(222, 27)
        Me.txtIndividualSize.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(864, 107)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 34)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1028, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GA Parameters"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1034, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.ToolStripMenuItem1.Text = "CrossOver"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1034, 593)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Genetaic Algorithms:"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtIndividualSize As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMutationPropability As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPopSize As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSelectionOperator As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCrossover_pro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCrossoverOperator As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class

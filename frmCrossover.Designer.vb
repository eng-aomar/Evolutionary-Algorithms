<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrossover
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtParent_b = New System.Windows.Forms.TextBox()
        Me.txtParent_a = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCrossover_pro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCrossoverOperator = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtChild_b = New System.Windows.Forms.TextBox()
        Me.txtChild_a = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtParent_b)
        Me.GroupBox1.Controls.Add(Me.txtParent_a)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCrossover_pro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCrossoverOperator)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crossover Parameters"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(530, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 39)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Perform Crossover"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(447, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Parent_b:"
        '
        'txtParent_b
        '
        Me.txtParent_b.Location = New System.Drawing.Point(530, 67)
        Me.txtParent_b.Margin = New System.Windows.Forms.Padding(4)
        Me.txtParent_b.Name = "txtParent_b"
        Me.txtParent_b.Size = New System.Drawing.Size(220, 27)
        Me.txtParent_b.TabIndex = 17
        '
        'txtParent_a
        '
        Me.txtParent_a.Location = New System.Drawing.Point(530, 30)
        Me.txtParent_a.Name = "txtParent_a"
        Me.txtParent_a.Size = New System.Drawing.Size(222, 27)
        Me.txtParent_a.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(447, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Parent_a:"
        '
        'txtCrossover_pro
        '
        Me.txtCrossover_pro.Location = New System.Drawing.Point(206, 67)
        Me.txtCrossover_pro.Name = "txtCrossover_pro"
        Me.txtCrossover_pro.Size = New System.Drawing.Size(222, 27)
        Me.txtCrossover_pro.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Crossover Propaplilty:"
        '
        'cmbCrossoverOperator
        '
        Me.cmbCrossoverOperator.FormattingEnabled = True
        Me.cmbCrossoverOperator.Location = New System.Drawing.Point(205, 28)
        Me.cmbCrossoverOperator.Name = "cmbCrossoverOperator"
        Me.cmbCrossoverOperator.Size = New System.Drawing.Size(222, 27)
        Me.cmbCrossoverOperator.TabIndex = 9
        Me.cmbCrossoverOperator.Text = "choose crossover method"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Crossover Operator:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtChild_b)
        Me.GroupBox2.Controls.Add(Me.txtChild_a)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(785, 133)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Crossover Results:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(368, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 19)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Child_b:"
        '
        'txtChild_b
        '
        Me.txtChild_b.BackColor = System.Drawing.Color.Beige
        Me.txtChild_b.Location = New System.Drawing.Point(437, 72)
        Me.txtChild_b.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChild_b.Name = "txtChild_b"
        Me.txtChild_b.ReadOnly = True
        Me.txtChild_b.Size = New System.Drawing.Size(220, 27)
        Me.txtChild_b.TabIndex = 27
        '
        'txtChild_a
        '
        Me.txtChild_a.BackColor = System.Drawing.Color.Beige
        Me.txtChild_a.Location = New System.Drawing.Point(436, 35)
        Me.txtChild_a.Name = "txtChild_a"
        Me.txtChild_a.ReadOnly = True
        Me.txtChild_a.Size = New System.Drawing.Size(222, 27)
        Me.txtChild_a.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(368, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Child_a:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Parent_b:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Parent_a:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Beige
        Me.TextBox3.Location = New System.Drawing.Point(112, 76)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 27)
        Me.TextBox3.TabIndex = 23
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Beige
        Me.TextBox4.Location = New System.Drawing.Point(112, 39)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(222, 27)
        Me.TextBox4.TabIndex = 22
        '
        'FrmCrossover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 309)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCrossover"
        Me.Text = "frmCrossover"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCrossover_pro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCrossoverOperator As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtParent_b As TextBox
    Friend WithEvents txtParent_a As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtChild_b As TextBox
    Friend WithEvents txtChild_a As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class

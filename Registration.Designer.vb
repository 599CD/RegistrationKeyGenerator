<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.lblF = New System.Windows.Forms.Label()
        Me.txtFormula = New System.Windows.Forms.TextBox()
        Me.txtKey1 = New System.Windows.Forms.TextBox()
        Me.txtKey2 = New System.Windows.Forms.TextBox()
        Me.lblKey1 = New System.Windows.Forms.Label()
        Me.lblKey2 = New System.Windows.Forms.Label()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbltssMainStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Location = New System.Drawing.Point(13, 13)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(47, 13)
        Me.lblF.TabIndex = 0
        Me.lblF.Text = "Formula:"
        '
        'txtFormula
        '
        Me.txtFormula.Enabled = False
        Me.txtFormula.Location = New System.Drawing.Point(66, 10)
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.Size = New System.Drawing.Size(173, 20)
        Me.txtFormula.TabIndex = 1
        Me.txtFormula.TabStop = False
        Me.txtFormula.Text = "Int(Key1 * 3 / 2) + 1701"
        '
        'txtKey1
        '
        Me.txtKey1.Location = New System.Drawing.Point(66, 45)
        Me.txtKey1.Name = "txtKey1"
        Me.txtKey1.Size = New System.Drawing.Size(100, 20)
        Me.txtKey1.TabIndex = 2
        '
        'txtKey2
        '
        Me.txtKey2.Location = New System.Drawing.Point(66, 72)
        Me.txtKey2.Name = "txtKey2"
        Me.txtKey2.Size = New System.Drawing.Size(100, 20)
        Me.txtKey2.TabIndex = 3
        '
        'lblKey1
        '
        Me.lblKey1.AutoSize = True
        Me.lblKey1.Location = New System.Drawing.Point(16, 45)
        Me.lblKey1.Name = "lblKey1"
        Me.lblKey1.Size = New System.Drawing.Size(34, 13)
        Me.lblKey1.TabIndex = 4
        Me.lblKey1.Text = "Key1:"
        '
        'lblKey2
        '
        Me.lblKey2.AutoSize = True
        Me.lblKey2.Location = New System.Drawing.Point(16, 75)
        Me.lblKey2.Name = "lblKey2"
        Me.lblKey2.Size = New System.Drawing.Size(34, 13)
        Me.lblKey2.TabIndex = 5
        Me.lblKey2.Text = "Key2:"
        '
        'cmdCopy
        '
        Me.cmdCopy.Location = New System.Drawing.Point(245, 72)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(58, 23)
        Me.cmdCopy.TabIndex = 6
        Me.cmdCopy.Text = "&Copy"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(172, 72)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(67, 23)
        Me.cmdCalculate.TabIndex = 7
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbltssMainStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 110)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(312, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbltssMainStatus
        '
        Me.lbltssMainStatus.Name = "lbltssMainStatus"
        Me.lbltssMainStatus.Size = New System.Drawing.Size(0, 17)
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Location = New System.Drawing.Point(172, 45)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(67, 23)
        Me.cmdGenerate.TabIndex = 9
        Me.cmdGenerate.Text = "Generate"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 132)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.cmdCopy)
        Me.Controls.Add(Me.lblKey2)
        Me.Controls.Add(Me.lblKey1)
        Me.Controls.Add(Me.txtKey2)
        Me.Controls.Add(Me.txtKey1)
        Me.Controls.Add(Me.txtFormula)
        Me.Controls.Add(Me.lblF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registration"
        Me.Text = "Registration"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblF As System.Windows.Forms.Label
    Friend WithEvents txtFormula As System.Windows.Forms.TextBox
    Friend WithEvents txtKey1 As System.Windows.Forms.TextBox
    Friend WithEvents txtKey2 As System.Windows.Forms.TextBox
    Friend WithEvents lblKey1 As System.Windows.Forms.Label
    Friend WithEvents lblKey2 As System.Windows.Forms.Label
    Friend WithEvents cmdCopy As System.Windows.Forms.Button
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbltssMainStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button

End Class

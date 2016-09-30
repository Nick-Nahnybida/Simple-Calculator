<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnMOD = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number 1:"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(167, 51)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Operator:"
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(142, 89)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(32, 33)
        Me.btnPlus.TabIndex = 3
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(167, 183)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(167, 252)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(120, 27)
        Me.lblResult.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(0, 221)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 14)
        Me.Panel1.TabIndex = 8
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(189, 89)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(33, 33)
        Me.btnMinus.TabIndex = 9
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMult.Location = New System.Drawing.Point(235, 89)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(32, 33)
        Me.btnMult.TabIndex = 10
        Me.btnMult.Text = "*"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.Location = New System.Drawing.Point(283, 89)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(32, 33)
        Me.btnDiv.TabIndex = 11
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Location = New System.Drawing.Point(332, 89)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(39, 33)
        Me.btnPower.TabIndex = 12
        Me.btnPower.Text = "^"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnMOD
        '
        Me.btnMOD.Location = New System.Drawing.Point(388, 89)
        Me.btnMOD.Name = "btnMOD"
        Me.btnMOD.Size = New System.Drawing.Size(48, 33)
        Me.btnMOD.TabIndex = 13
        Me.btnMOD.Text = "MOD"
        Me.btnMOD.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(332, 252)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(57, 35)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 367)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMOD)
        Me.Controls.Add(Me.btnPower)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnMult As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnPower As System.Windows.Forms.Button
    Friend WithEvents btnMOD As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class

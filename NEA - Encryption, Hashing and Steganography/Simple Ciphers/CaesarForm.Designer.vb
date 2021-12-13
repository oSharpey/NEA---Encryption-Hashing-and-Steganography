<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaesarForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaesarForm))
        Me.CaeserInputTB = New System.Windows.Forms.TextBox()
        Me.ShiftNumInputTB = New System.Windows.Forms.TextBox()
        Me.CaesarEncryptButton = New System.Windows.Forms.Button()
        Me.CaesarOutputTB = New System.Windows.Forms.TextBox()
        Me.CaesarDecryptButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CaeserInputTB
        '
        Me.CaeserInputTB.Location = New System.Drawing.Point(27, 63)
        Me.CaeserInputTB.Multiline = True
        Me.CaeserInputTB.Name = "CaeserInputTB"
        Me.CaeserInputTB.Size = New System.Drawing.Size(351, 115)
        Me.CaeserInputTB.TabIndex = 0
        '
        'ShiftNumInputTB
        '
        Me.ShiftNumInputTB.Location = New System.Drawing.Point(429, 100)
        Me.ShiftNumInputTB.Name = "ShiftNumInputTB"
        Me.ShiftNumInputTB.Size = New System.Drawing.Size(97, 22)
        Me.ShiftNumInputTB.TabIndex = 1
        '
        'CaesarEncryptButton
        '
        Me.CaesarEncryptButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CaesarEncryptButton.FlatAppearance.BorderSize = 0
        Me.CaesarEncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CaesarEncryptButton.Location = New System.Drawing.Point(27, 217)
        Me.CaesarEncryptButton.Name = "CaesarEncryptButton"
        Me.CaesarEncryptButton.Size = New System.Drawing.Size(123, 55)
        Me.CaesarEncryptButton.TabIndex = 2
        Me.CaesarEncryptButton.Text = "Encrypt"
        Me.CaesarEncryptButton.UseMnemonic = False
        Me.CaesarEncryptButton.UseVisualStyleBackColor = False
        '
        'CaesarOutputTB
        '
        Me.CaesarOutputTB.Location = New System.Drawing.Point(25, 326)
        Me.CaesarOutputTB.Multiline = True
        Me.CaesarOutputTB.Name = "CaesarOutputTB"
        Me.CaesarOutputTB.ReadOnly = True
        Me.CaesarOutputTB.Size = New System.Drawing.Size(351, 115)
        Me.CaesarOutputTB.TabIndex = 3
        '
        'CaesarDecryptButton
        '
        Me.CaesarDecryptButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CaesarDecryptButton.FlatAppearance.BorderSize = 0
        Me.CaesarDecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CaesarDecryptButton.Location = New System.Drawing.Point(253, 217)
        Me.CaesarDecryptButton.Name = "CaesarDecryptButton"
        Me.CaesarDecryptButton.Size = New System.Drawing.Size(123, 55)
        Me.CaesarDecryptButton.TabIndex = 4
        Me.CaesarDecryptButton.Text = "Decrypt"
        Me.CaesarDecryptButton.UseMnemonic = False
        Me.CaesarDecryptButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(29, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Input text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(431, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Shift Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(28, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Output text"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(425, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(533, 240)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'CaesarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(978, 514)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CaesarDecryptButton)
        Me.Controls.Add(Me.CaesarOutputTB)
        Me.Controls.Add(Me.CaesarEncryptButton)
        Me.Controls.Add(Me.ShiftNumInputTB)
        Me.Controls.Add(Me.CaeserInputTB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CaesarForm"
        Me.Text = "Caesar Cipher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CaeserInputTB As TextBox
    Friend WithEvents ShiftNumInputTB As TextBox
    Friend WithEvents CaesarEncryptButton As Button
    Friend WithEvents CaesarOutputTB As TextBox
    Friend WithEvents CaesarDecryptButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

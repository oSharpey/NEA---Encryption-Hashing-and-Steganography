<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HashForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HashForm))
        Me.HashInputTextBox = New System.Windows.Forms.TextBox()
        Me.HashOutputLabel = New System.Windows.Forms.Label()
        Me.HashEncodeButton = New System.Windows.Forms.Button()
        Me.HashOutput = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HashInputTextBox
        '
        Me.HashInputTextBox.Location = New System.Drawing.Point(27, 79)
        Me.HashInputTextBox.Multiline = True
        Me.HashInputTextBox.Name = "HashInputTextBox"
        Me.HashInputTextBox.Size = New System.Drawing.Size(360, 183)
        Me.HashInputTextBox.TabIndex = 2
        '
        'HashOutputLabel
        '
        Me.HashOutputLabel.AutoSize = True
        Me.HashOutputLabel.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HashOutputLabel.Location = New System.Drawing.Point(49, 474)
        Me.HashOutputLabel.Name = "HashOutputLabel"
        Me.HashOutputLabel.Size = New System.Drawing.Size(0, 17)
        Me.HashOutputLabel.TabIndex = 3
        Me.HashOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HashEncodeButton
        '
        Me.HashEncodeButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.HashEncodeButton.Location = New System.Drawing.Point(131, 288)
        Me.HashEncodeButton.Name = "HashEncodeButton"
        Me.HashEncodeButton.Size = New System.Drawing.Size(128, 57)
        Me.HashEncodeButton.TabIndex = 4
        Me.HashEncodeButton.Text = "Hash"
        Me.HashEncodeButton.UseVisualStyleBackColor = False
        '
        'HashOutput
        '
        Me.HashOutput.AutoSize = True
        Me.HashOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HashOutput.ForeColor = System.Drawing.Color.Gainsboro
        Me.HashOutput.Location = New System.Drawing.Point(23, 418)
        Me.HashOutput.Name = "HashOutput"
        Me.HashOutput.Size = New System.Drawing.Size(59, 20)
        Me.HashOutput.TabIndex = 6
        Me.HashOutput.Text = "Hash:"
        Me.HashOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(30, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Input Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(420, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(503, 240)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'HashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(956, 541)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HashOutput)
        Me.Controls.Add(Me.HashEncodeButton)
        Me.Controls.Add(Me.HashOutputLabel)
        Me.Controls.Add(Me.HashInputTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HashForm"
        Me.Text = "SHA256 Hash Function"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HashInputTextBox As TextBox
    Friend WithEvents HashOutputLabel As Label
    Friend WithEvents HashEncodeButton As Button
    Friend WithEvents HashOutput As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

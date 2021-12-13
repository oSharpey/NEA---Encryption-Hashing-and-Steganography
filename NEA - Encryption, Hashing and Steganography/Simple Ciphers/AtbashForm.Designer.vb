<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AtbashForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AtbashOutputTB = New System.Windows.Forms.TextBox()
        Me.AtbashEncryptButton = New System.Windows.Forms.Button()
        Me.AtbashInputTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(40, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Output text"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(42, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Input text"
        '
        'AtbashOutputTB
        '
        Me.AtbashOutputTB.Location = New System.Drawing.Point(37, 340)
        Me.AtbashOutputTB.Multiline = True
        Me.AtbashOutputTB.Name = "AtbashOutputTB"
        Me.AtbashOutputTB.ReadOnly = True
        Me.AtbashOutputTB.Size = New System.Drawing.Size(351, 115)
        Me.AtbashOutputTB.TabIndex = 10
        '
        'AtbashEncryptButton
        '
        Me.AtbashEncryptButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.AtbashEncryptButton.FlatAppearance.BorderSize = 0
        Me.AtbashEncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AtbashEncryptButton.Location = New System.Drawing.Point(39, 227)
        Me.AtbashEncryptButton.Name = "AtbashEncryptButton"
        Me.AtbashEncryptButton.Size = New System.Drawing.Size(123, 55)
        Me.AtbashEncryptButton.TabIndex = 9
        Me.AtbashEncryptButton.Text = "Encrypt"
        Me.AtbashEncryptButton.UseMnemonic = False
        Me.AtbashEncryptButton.UseVisualStyleBackColor = False
        '
        'AtbashInputTB
        '
        Me.AtbashInputTB.Location = New System.Drawing.Point(39, 71)
        Me.AtbashInputTB.Multiline = True
        Me.AtbashInputTB.Name = "AtbashInputTB"
        Me.AtbashInputTB.Size = New System.Drawing.Size(351, 115)
        Me.AtbashInputTB.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(456, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 120)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "How to use" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Enter the text you want to encrypt or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  decrypt into the input bo" &
    "x" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Ensure that you have only entered" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  English charcters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Press encrypt!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AtbashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(804, 497)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AtbashOutputTB)
        Me.Controls.Add(Me.AtbashEncryptButton)
        Me.Controls.Add(Me.AtbashInputTB)
        Me.Name = "AtbashForm"
        Me.Text = "Atbash Cipher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AtbashOutputTB As TextBox
    Friend WithEvents AtbashEncryptButton As Button
    Friend WithEvents AtbashInputTB As TextBox
    Friend WithEvents Label2 As Label
End Class

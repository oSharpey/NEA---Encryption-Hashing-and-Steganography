<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CryptEnigmaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CryptEnigmaForm))
        Me.EnigmaCryptInfoTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'EnigmaCryptInfoTB
        '
        Me.EnigmaCryptInfoTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.EnigmaCryptInfoTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EnigmaCryptInfoTB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.EnigmaCryptInfoTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnigmaCryptInfoTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnigmaCryptInfoTB.ForeColor = System.Drawing.Color.Gainsboro
        Me.EnigmaCryptInfoTB.Location = New System.Drawing.Point(0, 0)
        Me.EnigmaCryptInfoTB.Multiline = True
        Me.EnigmaCryptInfoTB.Name = "EnigmaCryptInfoTB"
        Me.EnigmaCryptInfoTB.ReadOnly = True
        Me.EnigmaCryptInfoTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EnigmaCryptInfoTB.Size = New System.Drawing.Size(800, 450)
        Me.EnigmaCryptInfoTB.TabIndex = 2
        Me.EnigmaCryptInfoTB.Text = resources.GetString("EnigmaCryptInfoTB.Text")
        '
        'CryptEnigmaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EnigmaCryptInfoTB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CryptEnigmaForm"
        Me.Text = "M3 Enigma Machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnigmaCryptInfoTB As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CryptCaesarForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CryptCaesarForm))
        Me.CaesarCryptInfoTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CaesarCryptInfoTB
        '
        Me.CaesarCryptInfoTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.CaesarCryptInfoTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CaesarCryptInfoTB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CaesarCryptInfoTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CaesarCryptInfoTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaesarCryptInfoTB.ForeColor = System.Drawing.Color.Gainsboro
        Me.CaesarCryptInfoTB.Location = New System.Drawing.Point(0, 0)
        Me.CaesarCryptInfoTB.Multiline = True
        Me.CaesarCryptInfoTB.Name = "CaesarCryptInfoTB"
        Me.CaesarCryptInfoTB.ReadOnly = True
        Me.CaesarCryptInfoTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CaesarCryptInfoTB.Size = New System.Drawing.Size(800, 450)
        Me.CaesarCryptInfoTB.TabIndex = 0
        Me.CaesarCryptInfoTB.Text = resources.GetString("CaesarCryptInfoTB.Text")
        '
        'CryptCaesarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CaesarCryptInfoTB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CryptCaesarForm"
        Me.Text = "Caeser Cipher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CaesarCryptInfoTB As TextBox
End Class

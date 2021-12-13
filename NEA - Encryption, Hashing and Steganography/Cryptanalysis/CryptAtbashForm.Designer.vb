<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CryptAtbashForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CryptAtbashForm))
        Me.AtbashCryptInfoTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AtbashCryptInfoTB
        '
        Me.AtbashCryptInfoTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.AtbashCryptInfoTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AtbashCryptInfoTB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AtbashCryptInfoTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AtbashCryptInfoTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtbashCryptInfoTB.ForeColor = System.Drawing.Color.Gainsboro
        Me.AtbashCryptInfoTB.Location = New System.Drawing.Point(0, 0)
        Me.AtbashCryptInfoTB.Multiline = True
        Me.AtbashCryptInfoTB.Name = "AtbashCryptInfoTB"
        Me.AtbashCryptInfoTB.ReadOnly = True
        Me.AtbashCryptInfoTB.Size = New System.Drawing.Size(800, 450)
        Me.AtbashCryptInfoTB.TabIndex = 1
        Me.AtbashCryptInfoTB.Text = resources.GetString("AtbashCryptInfoTB.Text")
        '
        'CryptAtbashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AtbashCryptInfoTB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CryptAtbashForm"
        Me.Text = "Atbash Cipher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AtbashCryptInfoTB As TextBox
End Class

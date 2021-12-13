<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CryptanalysisForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CryptanalysisForm))
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.CryptCaesarButton = New System.Windows.Forms.Button()
        Me.CryptStegButton = New System.Windows.Forms.Button()
        Me.CryptHashButton = New System.Windows.Forms.Button()
        Me.CryptEnigmaButton = New System.Windows.Forms.Button()
        Me.CryptAtbashButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CurrentFormLabel = New System.Windows.Forms.Label()
        Me.DesktopPanel = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.readMoreButton = New System.Windows.Forms.Button()
        Me.MenuPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.DesktopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.readMoreButton)
        Me.MenuPanel.Controls.Add(Me.CryptCaesarButton)
        Me.MenuPanel.Controls.Add(Me.CryptStegButton)
        Me.MenuPanel.Controls.Add(Me.CryptHashButton)
        Me.MenuPanel.Controls.Add(Me.CryptEnigmaButton)
        Me.MenuPanel.Controls.Add(Me.CryptAtbashButton)
        Me.MenuPanel.Controls.Add(Me.homeButton)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(220, 586)
        Me.MenuPanel.TabIndex = 0
        '
        'CryptCaesarButton
        '
        Me.CryptCaesarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.CryptCaesarButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CryptCaesarButton.FlatAppearance.BorderSize = 0
        Me.CryptCaesarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CryptCaesarButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.CryptCaesarButton.Location = New System.Drawing.Point(0, 300)
        Me.CryptCaesarButton.Name = "CryptCaesarButton"
        Me.CryptCaesarButton.Size = New System.Drawing.Size(220, 60)
        Me.CryptCaesarButton.TabIndex = 6
        Me.CryptCaesarButton.Text = "Caesar Cipher"
        Me.CryptCaesarButton.UseVisualStyleBackColor = False
        '
        'CryptStegButton
        '
        Me.CryptStegButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.CryptStegButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CryptStegButton.FlatAppearance.BorderSize = 0
        Me.CryptStegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CryptStegButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.CryptStegButton.Location = New System.Drawing.Point(0, 240)
        Me.CryptStegButton.Name = "CryptStegButton"
        Me.CryptStegButton.Size = New System.Drawing.Size(220, 60)
        Me.CryptStegButton.TabIndex = 5
        Me.CryptStegButton.Text = "LSB Steganography"
        Me.CryptStegButton.UseVisualStyleBackColor = False
        '
        'CryptHashButton
        '
        Me.CryptHashButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.CryptHashButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CryptHashButton.FlatAppearance.BorderSize = 0
        Me.CryptHashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CryptHashButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.CryptHashButton.Location = New System.Drawing.Point(0, 180)
        Me.CryptHashButton.Name = "CryptHashButton"
        Me.CryptHashButton.Size = New System.Drawing.Size(220, 60)
        Me.CryptHashButton.TabIndex = 4
        Me.CryptHashButton.Text = "SHA-2 Hash"
        Me.CryptHashButton.UseVisualStyleBackColor = False
        '
        'CryptEnigmaButton
        '
        Me.CryptEnigmaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.CryptEnigmaButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CryptEnigmaButton.FlatAppearance.BorderSize = 0
        Me.CryptEnigmaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CryptEnigmaButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.CryptEnigmaButton.Location = New System.Drawing.Point(0, 120)
        Me.CryptEnigmaButton.Name = "CryptEnigmaButton"
        Me.CryptEnigmaButton.Size = New System.Drawing.Size(220, 60)
        Me.CryptEnigmaButton.TabIndex = 3
        Me.CryptEnigmaButton.Text = "Enigma"
        Me.CryptEnigmaButton.UseVisualStyleBackColor = False
        '
        'CryptAtbashButton
        '
        Me.CryptAtbashButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.CryptAtbashButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CryptAtbashButton.FlatAppearance.BorderSize = 0
        Me.CryptAtbashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CryptAtbashButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.CryptAtbashButton.Location = New System.Drawing.Point(0, 60)
        Me.CryptAtbashButton.Name = "CryptAtbashButton"
        Me.CryptAtbashButton.Size = New System.Drawing.Size(220, 60)
        Me.CryptAtbashButton.TabIndex = 2
        Me.CryptAtbashButton.Text = "Atbash Cipher"
        Me.CryptAtbashButton.UseVisualStyleBackColor = False
        '
        'homeButton
        '
        Me.homeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.homeButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.homeButton.FlatAppearance.BorderSize = 0
        Me.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.homeButton.Location = New System.Drawing.Point(0, 0)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(220, 60)
        Me.homeButton.TabIndex = 1
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CurrentFormLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 61)
        Me.Panel1.TabIndex = 1
        '
        'CurrentFormLabel
        '
        Me.CurrentFormLabel.AutoSize = True
        Me.CurrentFormLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentFormLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.CurrentFormLabel.Location = New System.Drawing.Point(17, 18)
        Me.CurrentFormLabel.Name = "CurrentFormLabel"
        Me.CurrentFormLabel.Size = New System.Drawing.Size(53, 18)
        Me.CurrentFormLabel.TabIndex = 2
        Me.CurrentFormLabel.Text = "Home"
        '
        'DesktopPanel
        '
        Me.DesktopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.DesktopPanel.Controls.Add(Me.TextBox1)
        Me.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesktopPanel.Location = New System.Drawing.Point(220, 61)
        Me.DesktopPanel.Name = "DesktopPanel"
        Me.DesktopPanel.Size = New System.Drawing.Size(841, 525)
        Me.DesktopPanel.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.Location = New System.Drawing.Point(102, 59)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(627, 361)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'readMoreButton
        '
        Me.readMoreButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.readMoreButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.readMoreButton.FlatAppearance.BorderSize = 0
        Me.readMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.readMoreButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.readMoreButton.Location = New System.Drawing.Point(0, 360)
        Me.readMoreButton.Name = "readMoreButton"
        Me.readMoreButton.Size = New System.Drawing.Size(220, 60)
        Me.readMoreButton.TabIndex = 7
        Me.readMoreButton.Text = "Read More"
        Me.readMoreButton.UseVisualStyleBackColor = False
        '
        'CryptanalysisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 586)
        Me.Controls.Add(Me.DesktopPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CryptanalysisForm"
        Me.Text = "Cryptanalysis"
        Me.MenuPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.DesktopPanel.ResumeLayout(False)
        Me.DesktopPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents CryptStegButton As Button
    Friend WithEvents CryptHashButton As Button
    Friend WithEvents CryptEnigmaButton As Button
    Friend WithEvents CryptAtbashButton As Button
    Friend WithEvents homeButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CurrentFormLabel As Label
    Friend WithEvents DesktopPanel As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CryptCaesarButton As Button
    Friend WithEvents readMoreButton As Button
End Class

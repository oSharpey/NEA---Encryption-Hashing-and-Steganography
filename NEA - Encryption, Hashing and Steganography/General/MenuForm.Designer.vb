<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelTitlebar = New System.Windows.Forms.Panel()
        Me.formTitleLabel = New System.Windows.Forms.Label()
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.currentFormIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.hashButton = New FontAwesome.Sharp.IconButton()
        Me.atbashButton = New FontAwesome.Sharp.IconButton()
        Me.caesarButton = New FontAwesome.Sharp.IconButton()
        Me.stegButton = New FontAwesome.Sharp.IconButton()
        Me.enigmaButton = New FontAwesome.Sharp.IconButton()
        Me.cryptButton = New FontAwesome.Sharp.IconButton()
        Me.PictureBoxHome = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelTitlebar.SuspendLayout()
        Me.panelDesktop.SuspendLayout()
        CType(Me.currentFormIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.hashButton)
        Me.PanelMenu.Controls.Add(Me.atbashButton)
        Me.PanelMenu.Controls.Add(Me.caesarButton)
        Me.PanelMenu.Controls.Add(Me.stegButton)
        Me.PanelMenu.Controls.Add(Me.enigmaButton)
        Me.PanelMenu.Controls.Add(Me.cryptButton)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 712)
        Me.PanelMenu.TabIndex = 10
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBoxHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'PanelTitlebar
        '
        Me.PanelTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitlebar.Controls.Add(Me.formTitleLabel)
        Me.PanelTitlebar.Controls.Add(Me.currentFormIcon)
        Me.PanelTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitlebar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitlebar.Name = "PanelTitlebar"
        Me.PanelTitlebar.Size = New System.Drawing.Size(985, 75)
        Me.PanelTitlebar.TabIndex = 11
        '
        'formTitleLabel
        '
        Me.formTitleLabel.AutoSize = True
        Me.formTitleLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.formTitleLabel.Location = New System.Drawing.Point(57, 26)
        Me.formTitleLabel.Name = "formTitleLabel"
        Me.formTitleLabel.Size = New System.Drawing.Size(45, 17)
        Me.formTitleLabel.TabIndex = 1
        Me.formTitleLabel.Text = "Home"
        '
        'panelDesktop
        '
        Me.panelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.panelDesktop.Controls.Add(Me.Label1)
        Me.panelDesktop.Controls.Add(Me.PictureBox1)
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(220, 75)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(985, 637)
        Me.panelDesktop.TabIndex = 12
        '
        'currentFormIcon
        '
        Me.currentFormIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.currentFormIcon.ForeColor = System.Drawing.Color.MediumPurple
        Me.currentFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.currentFormIcon.IconColor = System.Drawing.Color.MediumPurple
        Me.currentFormIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.currentFormIcon.Location = New System.Drawing.Point(22, 19)
        Me.currentFormIcon.Name = "currentFormIcon"
        Me.currentFormIcon.Size = New System.Drawing.Size(32, 32)
        Me.currentFormIcon.TabIndex = 0
        Me.currentFormIcon.TabStop = False
        '
        'hashButton
        '
        Me.hashButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.hashButton.FlatAppearance.BorderSize = 0
        Me.hashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hashButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.hashButton.IconChar = FontAwesome.Sharp.IconChar.Fingerprint
        Me.hashButton.IconColor = System.Drawing.Color.Gainsboro
        Me.hashButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.hashButton.IconSize = 32
        Me.hashButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hashButton.Location = New System.Drawing.Point(0, 490)
        Me.hashButton.Name = "hashButton"
        Me.hashButton.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.hashButton.Size = New System.Drawing.Size(220, 70)
        Me.hashButton.TabIndex = 6
        Me.hashButton.Text = "SHA256 Hash"
        Me.hashButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hashButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.hashButton.UseVisualStyleBackColor = True
        '
        'atbashButton
        '
        Me.atbashButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.atbashButton.FlatAppearance.BorderSize = 0
        Me.atbashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.atbashButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.atbashButton.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt
        Me.atbashButton.IconColor = System.Drawing.Color.Gainsboro
        Me.atbashButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.atbashButton.IconSize = 32
        Me.atbashButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.atbashButton.Location = New System.Drawing.Point(0, 420)
        Me.atbashButton.Name = "atbashButton"
        Me.atbashButton.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.atbashButton.Size = New System.Drawing.Size(220, 70)
        Me.atbashButton.TabIndex = 5
        Me.atbashButton.Text = "Atbash Cipher"
        Me.atbashButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.atbashButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.atbashButton.UseVisualStyleBackColor = True
        '
        'caesarButton
        '
        Me.caesarButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.caesarButton.FlatAppearance.BorderSize = 0
        Me.caesarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.caesarButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.caesarButton.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt
        Me.caesarButton.IconColor = System.Drawing.Color.Gainsboro
        Me.caesarButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.caesarButton.IconSize = 32
        Me.caesarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.caesarButton.Location = New System.Drawing.Point(0, 350)
        Me.caesarButton.Name = "caesarButton"
        Me.caesarButton.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.caesarButton.Size = New System.Drawing.Size(220, 70)
        Me.caesarButton.TabIndex = 4
        Me.caesarButton.Text = "Caesar Cipher"
        Me.caesarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.caesarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.caesarButton.UseVisualStyleBackColor = True
        '
        'stegButton
        '
        Me.stegButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.stegButton.FlatAppearance.BorderSize = 0
        Me.stegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stegButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.stegButton.IconChar = FontAwesome.Sharp.IconChar.Images
        Me.stegButton.IconColor = System.Drawing.Color.Gainsboro
        Me.stegButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.stegButton.IconSize = 32
        Me.stegButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stegButton.Location = New System.Drawing.Point(0, 280)
        Me.stegButton.Name = "stegButton"
        Me.stegButton.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.stegButton.Size = New System.Drawing.Size(220, 70)
        Me.stegButton.TabIndex = 3
        Me.stegButton.Text = "Steganography"
        Me.stegButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stegButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.stegButton.UseVisualStyleBackColor = True
        '
        'enigmaButton
        '
        Me.enigmaButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.enigmaButton.FlatAppearance.BorderSize = 0
        Me.enigmaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enigmaButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.enigmaButton.IconChar = FontAwesome.Sharp.IconChar.Italic
        Me.enigmaButton.IconColor = System.Drawing.Color.Gainsboro
        Me.enigmaButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.enigmaButton.IconSize = 32
        Me.enigmaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.enigmaButton.Location = New System.Drawing.Point(0, 210)
        Me.enigmaButton.Name = "enigmaButton"
        Me.enigmaButton.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.enigmaButton.Size = New System.Drawing.Size(220, 70)
        Me.enigmaButton.TabIndex = 2
        Me.enigmaButton.Text = "Enigma"
        Me.enigmaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.enigmaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.enigmaButton.UseVisualStyleBackColor = True
        '
        'cryptButton
        '
        Me.cryptButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.cryptButton.FlatAppearance.BorderSize = 0
        Me.cryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cryptButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.cryptButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.cryptButton.IconColor = System.Drawing.Color.Gainsboro
        Me.cryptButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cryptButton.IconSize = 32
        Me.cryptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cryptButton.Location = New System.Drawing.Point(0, 140)
        Me.cryptButton.Name = "cryptButton"
        Me.cryptButton.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.cryptButton.Size = New System.Drawing.Size(220, 70)
        Me.cryptButton.TabIndex = 1
        Me.cryptButton.Text = "Cryptanalysis"
        Me.cryptButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cryptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cryptButton.UseVisualStyleBackColor = True
        '
        'PictureBoxHome
        '
        Me.PictureBoxHome.Image = Global.NEA_E_H_S.My.Resources.Resources.Symbolic_ShareX
        Me.PictureBoxHome.Location = New System.Drawing.Point(26, 25)
        Me.PictureBoxHome.Name = "PictureBoxHome"
        Me.PictureBoxHome.Size = New System.Drawing.Size(162, 89)
        Me.PictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxHome.TabIndex = 0
        Me.PictureBoxHome.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NEA_E_H_S.My.Resources.Resources.Symbolic_ShareX
        Me.PictureBox1.Location = New System.Drawing.Point(247, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(476, 315)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(96, 458)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(810, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NEA - Encryption, Hashing and Steganography"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1205, 712)
        Me.Controls.Add(Me.panelDesktop)
        Me.Controls.Add(Me.PanelTitlebar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MenuForm"
        Me.Text = "NEA - Encryption, Hashing and Steganography"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelTitlebar.ResumeLayout(False)
        Me.PanelTitlebar.PerformLayout()
        Me.panelDesktop.ResumeLayout(False)
        Me.panelDesktop.PerformLayout()
        CType(Me.currentFormIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBoxHome As PictureBox
    Friend WithEvents hashButton As FontAwesome.Sharp.IconButton
    Friend WithEvents atbashButton As FontAwesome.Sharp.IconButton
    Friend WithEvents caesarButton As FontAwesome.Sharp.IconButton
    Friend WithEvents stegButton As FontAwesome.Sharp.IconButton
    Friend WithEvents enigmaButton As FontAwesome.Sharp.IconButton
    Friend WithEvents cryptButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitlebar As Panel
    Friend WithEvents formTitleLabel As Label
    Friend WithEvents currentFormIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents panelDesktop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

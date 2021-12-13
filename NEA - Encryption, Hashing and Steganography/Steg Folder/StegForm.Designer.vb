<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StegForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StegForm))
        Me.clearButton = New System.Windows.Forms.Button()
        Me.openFileButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.outputBox = New System.Windows.Forms.TextBox()
        Me.decodeButton = New System.Windows.Forms.Button()
        Me.StegEncodeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MessageInputTB = New System.Windows.Forms.TextBox()
        Me.InputPicBox = New System.Windows.Forms.PictureBox()
        CType(Me.InputPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.clearButton.FlatAppearance.BorderSize = 0
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearButton.Location = New System.Drawing.Point(26, 492)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(135, 69)
        Me.clearButton.TabIndex = 19
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'openFileButton
        '
        Me.openFileButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.openFileButton.FlatAppearance.BorderSize = 0
        Me.openFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openFileButton.Location = New System.Drawing.Point(535, 491)
        Me.openFileButton.Margin = New System.Windows.Forms.Padding(4)
        Me.openFileButton.Name = "openFileButton"
        Me.openFileButton.Size = New System.Drawing.Size(135, 69)
        Me.openFileButton.TabIndex = 18
        Me.openFileButton.Text = "Open"
        Me.openFileButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(747, 247)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Message Output"
        '
        'outputBox
        '
        Me.outputBox.Location = New System.Drawing.Point(711, 271)
        Me.outputBox.Margin = New System.Windows.Forms.Padding(4)
        Me.outputBox.Multiline = True
        Me.outputBox.Name = "outputBox"
        Me.outputBox.ReadOnly = True
        Me.outputBox.Size = New System.Drawing.Size(221, 130)
        Me.outputBox.TabIndex = 16
        '
        'decodeButton
        '
        Me.decodeButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.decodeButton.FlatAppearance.BorderSize = 0
        Me.decodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.decodeButton.Location = New System.Drawing.Point(201, 492)
        Me.decodeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.decodeButton.Name = "decodeButton"
        Me.decodeButton.Size = New System.Drawing.Size(135, 69)
        Me.decodeButton.TabIndex = 15
        Me.decodeButton.Text = "Decode"
        Me.decodeButton.UseVisualStyleBackColor = False
        '
        'StegEncodeButton
        '
        Me.StegEncodeButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StegEncodeButton.FlatAppearance.BorderSize = 0
        Me.StegEncodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StegEncodeButton.Location = New System.Drawing.Point(370, 492)
        Me.StegEncodeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StegEncodeButton.Name = "StegEncodeButton"
        Me.StegEncodeButton.Size = New System.Drawing.Size(135, 68)
        Me.StegEncodeButton.TabIndex = 14
        Me.StegEncodeButton.Text = "Encode"
        Me.StegEncodeButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(753, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 40)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Enter the text" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " you want hide"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MessageInputTB
        '
        Me.MessageInputTB.Location = New System.Drawing.Point(711, 83)
        Me.MessageInputTB.Margin = New System.Windows.Forms.Padding(4)
        Me.MessageInputTB.Multiline = True
        Me.MessageInputTB.Name = "MessageInputTB"
        Me.MessageInputTB.Size = New System.Drawing.Size(221, 119)
        Me.MessageInputTB.TabIndex = 12
        '
        'InputPicBox
        '
        Me.InputPicBox.Location = New System.Drawing.Point(26, 26)
        Me.InputPicBox.Name = "InputPicBox"
        Me.InputPicBox.Size = New System.Drawing.Size(627, 427)
        Me.InputPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.InputPicBox.TabIndex = 21
        Me.InputPicBox.TabStop = False
        '
        'StegForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(986, 647)
        Me.Controls.Add(Me.InputPicBox)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.openFileButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.outputBox)
        Me.Controls.Add(Me.decodeButton)
        Me.Controls.Add(Me.StegEncodeButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MessageInputTB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StegForm"
        Me.Text = "Steganography"
        CType(Me.InputPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clearButton As Button
    Friend WithEvents openFileButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents outputBox As TextBox
    Friend WithEvents decodeButton As Button
    Friend WithEvents StegEncodeButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MessageInputTB As TextBox
    Friend WithEvents InputPicBox As PictureBox
End Class

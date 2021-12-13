<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EngimaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EngimaForm))
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.EncodeButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PlugBoardTextBox = New System.Windows.Forms.TextBox()
        Me.RposCB = New System.Windows.Forms.ComboBox()
        Me.MposCB = New System.Windows.Forms.ComboBox()
        Me.LposCB = New System.Windows.Forms.ComboBox()
        Me.RSettingCB = New System.Windows.Forms.ComboBox()
        Me.MSettingCB = New System.Windows.Forms.ComboBox()
        Me.LSettingCB = New System.Windows.Forms.ComboBox()
        Me.RotorRCB = New System.Windows.Forms.ComboBox()
        Me.RotorMCB = New System.Windows.Forms.ComboBox()
        Me.RotorLCB = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReflectorCB = New System.Windows.Forms.ComboBox()
        Me.ResetMachine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(864, 222)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(100, 28)
        Me.ClearButton.TabIndex = 49
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'EncodeButton
        '
        Me.EncodeButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.EncodeButton.FlatAppearance.BorderSize = 0
        Me.EncodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EncodeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncodeButton.ForeColor = System.Drawing.Color.Black
        Me.EncodeButton.Location = New System.Drawing.Point(636, 223)
        Me.EncodeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EncodeButton.Name = "EncodeButton"
        Me.EncodeButton.Size = New System.Drawing.Size(100, 28)
        Me.EncodeButton.TabIndex = 48
        Me.EncodeButton.Text = "Encode"
        Me.EncodeButton.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(626, 290)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Output"
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Location = New System.Drawing.Point(630, 313)
        Me.OutputTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(332, 127)
        Me.OutputTextBox.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(626, 45)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Input"
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(630, 67)
        Me.InputTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InputTextBox.Multiline = True
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(332, 127)
        Me.InputTextBox.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(11, 325)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Plugboard Pairs"
        '
        'PlugBoardTextBox
        '
        Me.PlugBoardTextBox.Location = New System.Drawing.Point(189, 322)
        Me.PlugBoardTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PlugBoardTextBox.Name = "PlugBoardTextBox"
        Me.PlugBoardTextBox.Size = New System.Drawing.Size(388, 22)
        Me.PlugBoardTextBox.TabIndex = 42
        '
        'RposCB
        '
        Me.RposCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RposCB.FormattingEnabled = True
        Me.RposCB.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.RposCB.Location = New System.Drawing.Point(472, 183)
        Me.RposCB.Margin = New System.Windows.Forms.Padding(4)
        Me.RposCB.Name = "RposCB"
        Me.RposCB.Size = New System.Drawing.Size(79, 24)
        Me.RposCB.TabIndex = 41
        '
        'MposCB
        '
        Me.MposCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MposCB.FormattingEnabled = True
        Me.MposCB.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.MposCB.Location = New System.Drawing.Point(326, 183)
        Me.MposCB.Margin = New System.Windows.Forms.Padding(4)
        Me.MposCB.Name = "MposCB"
        Me.MposCB.Size = New System.Drawing.Size(79, 24)
        Me.MposCB.TabIndex = 40
        '
        'LposCB
        '
        Me.LposCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LposCB.FormattingEnabled = True
        Me.LposCB.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.LposCB.Location = New System.Drawing.Point(176, 183)
        Me.LposCB.Margin = New System.Windows.Forms.Padding(4)
        Me.LposCB.Name = "LposCB"
        Me.LposCB.Size = New System.Drawing.Size(79, 24)
        Me.LposCB.TabIndex = 39
        '
        'RSettingCB
        '
        Me.RSettingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RSettingCB.FormattingEnabled = True
        Me.RSettingCB.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.RSettingCB.Location = New System.Drawing.Point(472, 133)
        Me.RSettingCB.Margin = New System.Windows.Forms.Padding(4)
        Me.RSettingCB.Name = "RSettingCB"
        Me.RSettingCB.Size = New System.Drawing.Size(79, 24)
        Me.RSettingCB.TabIndex = 38
        '
        'MSettingCB
        '
        Me.MSettingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MSettingCB.FormattingEnabled = True
        Me.MSettingCB.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.MSettingCB.Location = New System.Drawing.Point(326, 133)
        Me.MSettingCB.Margin = New System.Windows.Forms.Padding(4)
        Me.MSettingCB.Name = "MSettingCB"
        Me.MSettingCB.Size = New System.Drawing.Size(79, 24)
        Me.MSettingCB.TabIndex = 37
        '
        'LSettingCB
        '
        Me.LSettingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LSettingCB.FormattingEnabled = True
        Me.LSettingCB.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.LSettingCB.Location = New System.Drawing.Point(176, 133)
        Me.LSettingCB.Margin = New System.Windows.Forms.Padding(4)
        Me.LSettingCB.Name = "LSettingCB"
        Me.LSettingCB.Size = New System.Drawing.Size(79, 24)
        Me.LSettingCB.TabIndex = 36
        '
        'RotorRCB
        '
        Me.RotorRCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RotorRCB.FormattingEnabled = True
        Me.RotorRCB.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.RotorRCB.Location = New System.Drawing.Point(472, 85)
        Me.RotorRCB.Margin = New System.Windows.Forms.Padding(4)
        Me.RotorRCB.Name = "RotorRCB"
        Me.RotorRCB.Size = New System.Drawing.Size(79, 24)
        Me.RotorRCB.TabIndex = 35
        '
        'RotorMCB
        '
        Me.RotorMCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RotorMCB.FormattingEnabled = True
        Me.RotorMCB.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.RotorMCB.Location = New System.Drawing.Point(326, 85)
        Me.RotorMCB.Margin = New System.Windows.Forms.Padding(4)
        Me.RotorMCB.Name = "RotorMCB"
        Me.RotorMCB.Size = New System.Drawing.Size(79, 24)
        Me.RotorMCB.TabIndex = 34
        '
        'RotorLCB
        '
        Me.RotorLCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RotorLCB.FormattingEnabled = True
        Me.RotorLCB.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.RotorLCB.Location = New System.Drawing.Point(176, 85)
        Me.RotorLCB.Margin = New System.Windows.Forms.Padding(4)
        Me.RotorLCB.Name = "RotorLCB"
        Me.RotorLCB.Size = New System.Drawing.Size(79, 24)
        Me.RotorLCB.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(468, 47)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Rotor 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(322, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Rotor 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(172, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Rotor 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(11, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Initial Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(11, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Ring Setting"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(11, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Rotor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(11, 276)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Reflector"
        '
        'ReflectorCB
        '
        Me.ReflectorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReflectorCB.FormattingEnabled = True
        Me.ReflectorCB.Items.AddRange(New Object() {"UKW-B", "UKW-C"})
        Me.ReflectorCB.Location = New System.Drawing.Point(128, 269)
        Me.ReflectorCB.Margin = New System.Windows.Forms.Padding(4)
        Me.ReflectorCB.Name = "ReflectorCB"
        Me.ReflectorCB.Size = New System.Drawing.Size(97, 24)
        Me.ReflectorCB.TabIndex = 25
        '
        'ResetMachine
        '
        Me.ResetMachine.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ResetMachine.FlatAppearance.BorderSize = 0
        Me.ResetMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetMachine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetMachine.ForeColor = System.Drawing.Color.Black
        Me.ResetMachine.Location = New System.Drawing.Point(751, 223)
        Me.ResetMachine.Margin = New System.Windows.Forms.Padding(4)
        Me.ResetMachine.Name = "ResetMachine"
        Me.ResetMachine.Size = New System.Drawing.Size(100, 28)
        Me.ResetMachine.TabIndex = 50
        Me.ResetMachine.Text = "Reset"
        Me.ResetMachine.UseVisualStyleBackColor = False
        '
        'EngimaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 506)
        Me.Controls.Add(Me.ResetMachine)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.EncodeButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PlugBoardTextBox)
        Me.Controls.Add(Me.RposCB)
        Me.Controls.Add(Me.MposCB)
        Me.Controls.Add(Me.LposCB)
        Me.Controls.Add(Me.RSettingCB)
        Me.Controls.Add(Me.MSettingCB)
        Me.Controls.Add(Me.LSettingCB)
        Me.Controls.Add(Me.RotorRCB)
        Me.Controls.Add(Me.RotorMCB)
        Me.Controls.Add(Me.RotorLCB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReflectorCB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EngimaForm"
        Me.Text = "Engima Simulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClearButton As Button
    Friend WithEvents EncodeButton As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PlugBoardTextBox As TextBox
    Friend WithEvents RposCB As ComboBox
    Friend WithEvents MposCB As ComboBox
    Friend WithEvents LposCB As ComboBox
    Friend WithEvents RSettingCB As ComboBox
    Friend WithEvents MSettingCB As ComboBox
    Friend WithEvents LSettingCB As ComboBox
    Friend WithEvents RotorRCB As ComboBox
    Friend WithEvents RotorMCB As ComboBox
    Friend WithEvents RotorLCB As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReflectorCB As ComboBox
    Friend WithEvents ResetMachine As Button
End Class

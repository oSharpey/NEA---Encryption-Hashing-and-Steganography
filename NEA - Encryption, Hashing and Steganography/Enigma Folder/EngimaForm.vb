Imports System.Text.RegularExpressions
Imports System.IO
Public Class EngimaForm
    Private Function PlugboardValid(ByVal letterPairs As String) As Boolean
        'Function that ensures only letter pairs are in the plugboard field

        Dim plugboardArray() As String
        Dim valid As Boolean = True

        plugboardArray = Split(letterPairs, " ")

        For Each pair In plugboardArray
            If Len(pair) <> 2 Then
                valid = False
                Exit For
            End If
        Next

        Return valid

    End Function

    Private Sub EncodeButton_Click(sender As Object, e As EventArgs) Handles EncodeButton.Click
        Dim inputword As String
        Dim reflector As String = ReflectorCB.SelectedItem.ToString
        Dim rotors() As String = {RotorLCB.SelectedItem.ToString, RotorMCB.SelectedItem.ToString, RotorRCB.SelectedItem.ToString}
        Dim ringpos As String = LposCB.SelectedItem.ToString + MposCB.SelectedItem.ToString + RposCB.SelectedItem.ToString
        Dim ringsetting As String = LSettingCB.SelectedItem.ToString + MSettingCB.SelectedItem.ToString + RSettingCB.SelectedItem.ToString
        Dim plugboard As String
        Dim outputword As String
        Dim enigma As EnigmaMachine
        Dim utility As New Utilities
        Dim inputRestriction As New Regex("\A[A-Za-z]+\Z")
        Dim plugboardRestriction As New Regex("\A[A-Z]+\Z")


        inputword = InputTextBox.Text
        plugboard = UCase(PlugBoardTextBox.Text)


        'these if and switch statements make sure that the user can only input certain characters
        'uses regular expressions to validate the user input 
        'program will spit out an error messsage if the input is not valid 


        Select Case plugboard
            Case ""
                If utility.MatchRegEx(inputword, inputRestriction) Then
                    Try
                        enigma = New EnigmaMachine(inputword, reflector, rotors, ringpos, ringsetting, plugboard)
                        outputword = enigma.encode
                        OutputTextBox.Text = outputword
                        SaveToFile(inputword, reflector, rotors, ringpos, ringsetting, plugboard, outputword)
                    Catch
                        MessageBox.Show("Could not encode")
                    End Try
                Else
                    MessageBox.Show("Make sure you only using A-Z and a-z in the input field")
                End If

            Case Else

                Select Case PlugboardValid(plugboard)
                    Case True
                        If utility.MatchRegEx(inputword, inputRestriction) And utility.MatchRegEx(plugboard, plugboardRestriction) Then
                            Try
                                enigma = New EnigmaMachine(inputword, reflector, rotors, ringpos, ringsetting, plugboard)
                                outputword = enigma.encode
                                OutputTextBox.Text = outputword
                                SaveToFile(inputword, reflector, rotors, ringpos, ringsetting, plugboard, outputword)
                            Catch
                                MessageBox.Show("Could not encode")
                            End Try
                        Else
                            MessageBox.Show("Make sure you only using A-Z and a-z in the plugboard and input fields")
                        End If
                    Case Else
                        MessageBox.Show("You can only have letter pairs in the plugboard field")
                End Select

        End Select

    End Sub

    Private Sub EnigmaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sets all the combo boxes to the defualt value

        RotorLCB.SelectedIndex = 0
        RotorMCB.SelectedIndex = 0
        RotorRCB.SelectedIndex = 0

        LposCB.SelectedIndex = 0
        MposCB.SelectedIndex = 0
        RposCB.SelectedIndex = 0

        LSettingCB.SelectedIndex = 0
        MSettingCB.SelectedIndex = 0
        RSettingCB.SelectedIndex = 0

        ReflectorCB.SelectedIndex = 0
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        'removes any user inputed data from the input and output textboxes 

        InputTextBox.Clear()
        OutputTextBox.Clear()
    End Sub

    Private Sub ResetMachine_Click(sender As Object, e As EventArgs) Handles ResetMachine.Click

        'Sets all user changeable values back to the default when button is pressed

        RotorLCB.SelectedIndex = 0
        RotorMCB.SelectedIndex = 0
        RotorRCB.SelectedIndex = 0

        LposCB.SelectedIndex = 0
        MposCB.SelectedIndex = 0
        RposCB.SelectedIndex = 0

        LSettingCB.SelectedIndex = 0
        MSettingCB.SelectedIndex = 0
        RSettingCB.SelectedIndex = 0

        ReflectorCB.SelectedIndex = 0

        InputTextBox.Clear()
        OutputTextBox.Clear()
        PlugBoardTextBox.Clear()
    End Sub

    Private Sub SaveToFile(ByVal plainTextinput As String, ByVal reflectorinput As String, ByVal rotorsinput() As String, ByVal ringPosinput As String, ByVal ringSettinginput As String, ByVal plugboardinput As String, ByVal output As String)

        'saves the machine settings to a text file

        Dim filename As String = "EngimaTable.txt"
        Dim append As Boolean = True

        Using writer As New StreamWriter(filename, append)
            writer.WriteLine($"Rotor 1: {rotorsinput(0)}, Rotor 2: {rotorsinput(1)}, Rotor 3: {rotorsinput(2)}")
            writer.WriteLine($"Ring Setting: {ringSettinginput}")
            writer.WriteLine($"Inital Position: {ringPosinput}")
            writer.WriteLine($"Plugboard: {plugboardinput}")
            writer.WriteLine($"Relflector: {reflectorinput}")
            writer.WriteLine()
            writer.WriteLine($"Plaintext: {plainTextinput}")
            writer.WriteLine($"Encrypted Text: {output}")
            writer.WriteLine()
            writer.WriteLine()
            writer.WriteLine()
        End Using
    End Sub
End Class
Public Class EnigmaMachine
    Private ReadOnly reflectorsetting, ringpos, ringsetting, plugboardsetting As String
    Private plaintext, encryptedLetter, cipherText As String
    Private ReadOnly rotorsettings() As String

    Public Sub New(ByVal plainTextinput As String, ByVal reflectorinput As String, ByVal rotorsinput() As String, ByVal ringPosinput As String, ByVal ringSettinginput As String, ByVal plugboardinput As String)
        plaintext = plainTextinput
        reflectorsetting = reflectorinput
        ringpos = ringPosinput
        ringsetting = ringSettinginput
        plugboardsetting = plugboardinput
        rotorsettings = rotorsinput
    End Sub


    Public Function Encode() As String

        'Intantiates each aspect of the enigma and passes each letter of the message through the machine
        'returns the encrypted message 

        Dim plugboard As New Plugboard(plugboardsetting)
        Dim reflector As New Reflector(reflectorsetting)
        Dim rotors As New Rotors(rotorsettings, ringpos, ringsetting)

        plaintext = UCase(plaintext)

        For Each letter In plaintext
            If letter <> " " Then
                encryptedLetter = letter
                rotors.CheckShift()
                encryptedLetter = plugboard.PlugboardEncode(encryptedLetter)
                encryptedLetter = rotors.FirstPass(encryptedLetter)
                encryptedLetter = reflector.Encode(encryptedLetter)
                encryptedLetter = rotors.SecondPass(encryptedLetter)
                encryptedLetter = plugboard.PlugboardEncode(encryptedLetter)
                cipherText += encryptedLetter
            End If
        Next

        Return cipherText
    End Function
End Class

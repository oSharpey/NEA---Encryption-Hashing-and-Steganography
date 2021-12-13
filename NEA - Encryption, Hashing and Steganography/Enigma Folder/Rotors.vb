Public Class Rotors

    Private ReadOnly rotor1, rotor2, rotor3, rotor4, rotor5, rotor1notch, rotor2notch, rotor3notch, rotor4notch, rotor5notch, leftringsetting, middleringsetting, rightringsetting As String
    Private ReadOnly leftrotor, middlerotor, rightrotor, middlenotch, rightnotch As String
    Private ReadOnly rotorDictionary, rotorNotchDictionary As New Dictionary(Of String, String)
    Private ReadOnly leftOffsetSetting, middleOffsetSetting, rightOffsetSetting As Integer
    Private leftRotorOffset, middleRotorOffset, rightRotorOffset As Integer
    Private leftringpos, middleringpos, rightringpos As String
    Private rotationTrigger As Boolean
    Private ReadOnly alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private Function Shift(ByVal str As String, ByVal shiftnum As Integer)
        'Performs a caesar shift on the rotors,
        'this simulates setting the 'Ringstellung' on a real engima machine (changing the internal wiring)


        Dim output As String = ""
        Dim c As String
        Dim code As Integer

        For i = 0 To Len(str) - 1
            c = str(i)
            code = Asc(c)
            If code >= 65 And code <= 95 Then
                c = Chr(((code - 65 + shiftnum) Mod 26) + 65)
            End If
            output += c
        Next

        Return output
    End Function

    Public Sub New(ByVal rotors() As String, ByVal ringPos As String, ByVal ringSetting As String)

        rotor1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ"
        rotor2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE"
        rotor3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO"
        rotor4 = "ESOVPZJAYQUIRHXLNFTGKDCMWB"
        rotor5 = "VZBRGITYUPSDNHLXAWMJQOFECK"

        rotor1notch = "Q"
        rotor2notch = "E"
        rotor3notch = "V"
        rotor4notch = "J"
        rotor5notch = "Z"

        rotorDictionary.Add("I", rotor1)
        rotorDictionary.Add("II", rotor2)
        rotorDictionary.Add("III", rotor3)
        rotorDictionary.Add("IV", rotor4)
        rotorDictionary.Add("V", rotor5)


        rotorNotchDictionary.Add("I", rotor1notch)
        rotorNotchDictionary.Add("II", rotor2notch)
        rotorNotchDictionary.Add("III", rotor3notch)
        rotorNotchDictionary.Add("IV", rotor4notch)
        rotorNotchDictionary.Add("V", rotor5notch)


        leftringpos = ringPos(0)
        middleringpos = ringPos(1)
        rightringpos = ringPos(2)

        leftringsetting = ringSetting(0)
        middleringsetting = ringSetting(1)
        rightringsetting = ringSetting(2)

        leftrotor = rotorDictionary(rotors(0))
        middlerotor = rotorDictionary(rotors(1))
        rightrotor = rotorDictionary(rotors(2))

        middlenotch = rotorNotchDictionary(rotors(1))
        rightnotch = rotorNotchDictionary(rotors(2))

        leftOffsetSetting = alphabet.IndexOf(leftringsetting)
        middleOffsetSetting = alphabet.IndexOf(middleringsetting)
        rightOffsetSetting = alphabet.IndexOf(rightringsetting)


        leftrotor = Shift(leftrotor, leftOffsetSetting)
        middlerotor = Shift(middlerotor, middleOffsetSetting)
        rightrotor = Shift(rightrotor, rightOffsetSetting)


        If leftOffsetSetting > 0 Then
            leftrotor = leftrotor.Substring(26 - leftOffsetSetting) + leftrotor.Substring(0, 26 - leftOffsetSetting)
        End If
        If middleOffsetSetting > 0 Then
            middlerotor = middlerotor.Substring(26 - middleOffsetSetting) + middlerotor.Substring(0, 26 - middleOffsetSetting)
        End If
        If rightOffsetSetting > 0 Then
            rightrotor = rightrotor.Substring(26 - rightOffsetSetting) + rightrotor.Substring(0, 26 - rightOffsetSetting)
        End If


    End Sub


    Public Sub CheckShift()
        'Checks to see if the rotors need to be shifted if a notch is hit
        'does this by adding 1 to the index of the alphabet (mod 26 so value can wrap around)

        rotationTrigger = False

        If rightringpos = rightnotch Then
            rotationTrigger = True
        End If
        rightringpos = alphabet((alphabet.IndexOf(rightringpos) + 1) Mod 26)

        If rotationTrigger Then
            rotationTrigger = False
            If middleringpos = middlenotch Then
                rotationTrigger = True
            End If
            middleringpos = alphabet((alphabet.IndexOf(middleringpos) + 1) Mod 26)

            If rotationTrigger Then
                rotationTrigger = False
                leftringpos = alphabet((alphabet.IndexOf(leftringpos) + 1) Mod 26)
            End If


        Else
            If middleringpos = middlenotch Then
                middleringpos = alphabet((alphabet.IndexOf(middleringpos) + 1) Mod 26)
                leftringpos = alphabet((alphabet.IndexOf(leftringpos) + 1) Mod 26)
            End If
        End If

    End Sub

    Public Function FirstPass(ByVal encryptedletter As String)
        Dim position As Integer
        Dim templetter As String

        leftRotorOffset = alphabet.IndexOf(leftringpos)
        middleRotorOffset = alphabet.IndexOf(middleringpos)
        rightRotorOffset = alphabet.IndexOf(rightringpos)

        ''PASSING THE LETTER THROUGH THE THREE ROTORS''
        position = alphabet.IndexOf(encryptedletter)
        templetter = rightrotor((position + rightRotorOffset) Mod 26)
        position = alphabet.IndexOf(templetter)
        encryptedletter = alphabet((position - rightRotorOffset + 26) Mod 26)


        position = alphabet.IndexOf(encryptedletter)
        templetter = middlerotor((position + middleRotorOffset) Mod 26)
        position = alphabet.IndexOf(templetter)
        encryptedletter = alphabet((position - middleRotorOffset + 26) Mod 26)


        position = alphabet.IndexOf(encryptedletter)
        templetter = leftrotor((position + leftRotorOffset) Mod 26)
        position = alphabet.IndexOf(templetter)
        encryptedletter = alphabet((position - leftRotorOffset + 26) Mod 26)

        Return encryptedletter
    End Function

    Public Function SecondPass(ByVal encryptedletter As String)
        Dim position As Integer
        Dim templetter As String
        ''PASSING THE LETTER BACK THROUGH THE THREE ROTORS''
        position = alphabet.IndexOf(encryptedletter)
        templetter = alphabet((position + leftRotorOffset) Mod 26)
        position = leftrotor.IndexOf(templetter)
        encryptedletter = alphabet((position - leftRotorOffset + 26) Mod 26)


        position = alphabet.IndexOf(encryptedletter)
        templetter = alphabet((position + middleRotorOffset) Mod 26)
        position = middlerotor.IndexOf(templetter)
        encryptedletter = alphabet((position - middleRotorOffset + 26) Mod 26)


        position = alphabet.IndexOf(encryptedletter)
        templetter = alphabet((position + rightRotorOffset) Mod 26)
        position = rightrotor.IndexOf(templetter)
        encryptedletter = alphabet((position - rightRotorOffset + 26) Mod 26)


        Return encryptedletter
    End Function
End Class

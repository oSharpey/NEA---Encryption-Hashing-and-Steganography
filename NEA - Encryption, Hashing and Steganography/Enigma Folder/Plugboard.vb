Public Class Plugboard
    Private ReadOnly plugboardSettings() As String
    Private ReadOnly plugboardDictionary As New Dictionary(Of String, String)
    Public Sub New(ByVal letterpairsinput As String)

        'Constructor that sets up the dictionary for the plugboard to function

        plugboardSettings = letterpairsinput.ToUpper.Split(" ")
        For Each letterPair In plugboardSettings
            If Len(letterPair) = 2 Then
                plugboardDictionary.Add(letterPair(0), letterPair(1))
                plugboardDictionary.Add(letterPair(1), letterPair(0))
            End If
        Next

    End Sub



    Public Function PlugboardEncode(ByVal letterInput As String) As String
        Dim encryptedletter As String = letterInput

        'sets the encrypted letter to the plaintexts letter corresponding value in the dictionary
        '(used the inputted letter as the key)

        If plugboardDictionary.ContainsKey(letterInput) Then
            If plugboardDictionary(letterInput) <> "" Then
                encryptedletter = plugboardDictionary(letterInput)
            End If
        End If

        Return encryptedletter
    End Function
End Class

Public Class Reflector
    Private ReadOnly reflectorDictionary, reflectorB, reflectorC As New Dictionary(Of String, String)
    Private encryptedletter As String
    Public Sub New(ByVal reflectorInput As String)

#Region "REFELCTOR B"
        reflectorB.Add("A", "Y")
        reflectorB.Add("B", "R")
        reflectorB.Add("C", "U")
        reflectorB.Add("D", "H")
        reflectorB.Add("E", "Q")
        reflectorB.Add("F", "S")
        reflectorB.Add("G", "L")
        reflectorB.Add("I", "P")
        reflectorB.Add("J", "X")
        reflectorB.Add("K", "N")
        reflectorB.Add("M", "O")
        reflectorB.Add("T", "Z")
        reflectorB.Add("V", "W")
        reflectorB.Add("Y", "A")
        reflectorB.Add("R", "B")
        reflectorB.Add("U", "C")
        reflectorB.Add("H", "D")
        reflectorB.Add("Q", "E")
        reflectorB.Add("S", "F")
        reflectorB.Add("L", "G")
        reflectorB.Add("P", "I")
        reflectorB.Add("X", "J")
        reflectorB.Add("N", "K")
        reflectorB.Add("O", "M")
        reflectorB.Add("Z", "T")
        reflectorB.Add("W", "V")
#End Region

#Region "REFLECTOR C"
        reflectorC.Add("A", "F")
        reflectorC.Add("F", "A")
        reflectorC.Add("B", "V")
        reflectorC.Add("V", "B")
        reflectorC.Add("C", "P")
        reflectorC.Add("P", "C")
        reflectorC.Add("D", "J")
        reflectorC.Add("J", "D")
        reflectorC.Add("I", "E")
        reflectorC.Add("E", "I")
        reflectorC.Add("G", "O")
        reflectorC.Add("O", "G")
        reflectorC.Add("H", "Y")
        reflectorC.Add("Y", "H")
        reflectorC.Add("K", "R")
        reflectorC.Add("R", "K")
        reflectorC.Add("L", "Z")
        reflectorC.Add("Z", "L")
        reflectorC.Add("M", "X")
        reflectorC.Add("X", "M")
        reflectorC.Add("N", "W")
        reflectorC.Add("W", "N")
        reflectorC.Add("Q", "T")
        reflectorC.Add("T", "Q")
        reflectorC.Add("S", "U")
        reflectorC.Add("U", "S")
#End Region

        If reflectorInput = "UKW-B" Then
            reflectorDictionary = reflectorB
        Else
            reflectorDictionary = reflectorC
        End If
    End Sub

    Public Function Encode(ByVal encryptedletterinput As String)
        'sets the encrypted letter to the plaintexts letter corresponding value in the dictionary
        '(used the inputted letter as the key)

        encryptedletter = encryptedletterinput
        If reflectorDictionary.ContainsKey(encryptedletter) Then
            If reflectorDictionary(encryptedletter) <> "" Then
                'temp = reflectorDictionary.Keys.ToList.IndexOf(encryptedletter)
                ' templetter = reflectorDictionary.Keys(temp)
                encryptedletter = reflectorDictionary(encryptedletterinput)
            End If
        End If

        Return encryptedletter
    End Function
End Class

Imports System.Text.RegularExpressions

'This class conatins some general conversions that other clases inherit from 

Public Class Utilities


    'function for input validation 
    Public Function MatchRegEx(ByVal inputString As String, ByVal regexComp As Regex) As Boolean
        Dim stringArray() As String
        Dim comparisonString As String = ""

        stringArray = Split(inputString, " ")

        For Each word In stringArray
            comparisonString += word
        Next


        Return regexComp.IsMatch(comparisonString)

    End Function


    'Useful binary conversion operations 
    Public Function MessageToBinary(ByVal message As String) As String
        Dim asciiMessage As Integer
        Dim binmessage, tempbin As String
        binmessage = ""

        For i = 0 To Len(message) - 1
            asciiMessage = (Asc(message(i)))
            tempbin = Convert.ToString(asciiMessage, 2).PadLeft(8, "0"c)
            binmessage += tempbin
        Next
        Return binmessage

    End Function
    Protected Function BinToInt(ByVal binValue As String) As UInteger
        Dim intValue As UInt32
        Dim power As UInt64 = 1

        For i = Len(binValue) - 1 To 0 Step -1
            If binValue(i) = "1" Then
                intValue += 1 * power
            End If
            power *= 2
        Next
        Return intValue
    End Function
    Protected Function IntToBin(ByVal inputInt As UInt32, ByVal padAmount As Integer) As String
        Dim binOut As String
        binOut = Convert.ToString(inputInt, 2).PadLeft(padAmount, "0")
        Return binOut
    End Function
End Class
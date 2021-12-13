Imports System.Text.RegularExpressions
Public Class StegDecode
    Inherits Utilities
    Private ReadOnly errorTimer As New Stopwatch

    Public Function Decode(ByVal stegImage As Bitmap) As String

        Dim bytes As New List(Of String)
        Dim binaryData As String = ""
        Dim decodedChar As String = ""
        Dim decodedData As String = ""
        Dim pixel As Color
        Dim r, g, b As Integer
        Dim binR, binG, binB As String
        Dim outputtRestriction As New Regex("\A[\x00-\x7f]+\Z")

        errorTimer.Start()

        For i = 0 To stegImage.Width - 1
            For j = 0 To stegImage.Height - 1

                'Errors out if program doesnt respond 
                If errorTimer.ElapsedMilliseconds > 5000 Then
                    Return "error"
                End If

                pixel = stegImage.GetPixel(i, j)

                r = pixel.R
                g = pixel.G
                b = pixel.B

                binR = IntToBin(r, 8)
                binG = IntToBin(g, 8)
                binB = IntToBin(b, 8)

                'From lines 38 to 76 this extracts the LSB of each sub pixel in each pixel
                'and converts it back to a character
                binaryData += binR(binR.Length - 1)


                If Len(binaryData) = 8 Then
                    decodedChar = Chr(BinToInt(binaryData))
                    decodedData += decodedChar
                    binaryData = ""

                    If decodedChar = "~" Then
                        Exit For
                    End If

                End If

                binaryData += binG(binG.Length - 1)

                If Len(binaryData) = 8 Then
                    decodedChar = Chr(BinToInt(binaryData))
                    decodedData += decodedChar
                    binaryData = ""

                    If decodedChar = "~" Then
                        Exit For
                    End If

                End If

                binaryData += binB(binB.Length - 1)

                If Len(binaryData) = 8 Then
                    decodedChar = Chr(BinToInt(binaryData))
                    decodedData += decodedChar
                    binaryData = ""

                    If decodedChar = "~" Then
                        Exit For
                    End If

                End If
            Next

            If decodedChar = "~" Then
                Exit For
            End If
        Next


        If MatchRegEx(decodedData, outputtRestriction) Then 'IF THE STRING CONTAINS ONLY ASCII CHARACTERS
            Return decodedData
        Else
            Return "error" 'IF NO DELIMINER FOUND RETURN AN ERROR VALUE
        End If

    End Function

End Class

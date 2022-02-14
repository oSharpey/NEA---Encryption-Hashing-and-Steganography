Imports System.Text.RegularExpressions
Public Class CaesarForm
    Private Function CeaserEnocode(ByVal plaintext As String, ByVal shiftNum As Integer)

        'standard caeser algorithm, shits the letter a certain number of places down the alphabet 


        Dim cipherText As String = ""
        plaintext = plaintext.ToUpper
        For Each letter In plaintext
            If letter <> " " Then
                cipherText += Chr((Asc(letter) + shiftNum - 65) Mod 26 + 65)
            Else
                cipherText += " "
            End If
        Next
        Return cipherText
    End Function

    Private Sub CaesarEncryptButton_Click(sender As Object, e As EventArgs) Handles CaesarEncryptButton.Click

        'handles encrypting the message 

        Dim plaintext As String
        Dim cipherText As String
        Dim shiftNum As UInteger
        Dim utility As New Utilities
        Dim textRestriction As New Regex("\A[A-Za-z]+\Z")

        plaintext = CaeserInputTB.Text

        Try
            shiftNum = UInteger.Parse(ShiftNumInputTB.Text)
            If utility.MatchRegEx(plaintext, textRestriction) Then
                cipherText = CeaserEnocode(plaintext, shiftNum)
                CaesarOutputTB.Text = cipherText
            Else
                MessageBox.Show("You can only encode letters")
            End If

        Catch ex As Exception
            MessageBox.Show("Cannot encrypt, check what you have inputted into the fields")
        End Try

    End Sub

    Private Sub CaesarDecryptButton_Click(sender As Object, e As EventArgs) Handles CaesarDecryptButton.Click

        'handles decryption of the message 

        Dim plaintext As String
        Dim cipherText As String
        Dim shiftNum As UInteger
        Dim utility As New Utilities
        Dim textRestriction As New Regex("\A[A-Za-z]+\Z")

        plaintext = CaeserInputTB.Text

        Try
            shiftNum = UInteger.Parse(ShiftNumInputTB.Text)
            Select Case utility.MatchRegEx(plaintext, textRestriction)
                Case True
                    cipherText = CeaserEnocode(plaintext, 26 - shiftNum)
                    CaesarOutputTB.Text = cipherText
                Case Else
                    MessageBox.Show("You can only encode letters")
            End Select
        Catch ex As Exception
            MessageBox.Show("Cannot decrypt, check what you have inputted into the fields")
        End Try



    End Sub
End Class
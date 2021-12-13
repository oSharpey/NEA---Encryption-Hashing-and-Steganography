Imports System.Text.RegularExpressions
Public Class AtbashForm
    Private Function AtbashCipher(ByVal input As String)
        Dim N As Integer
        Dim output As String = ""
        N = Asc("Z") + Asc("A")
        For Each letter In input
            If letter = " " Then
                output += " "
            Else
                output += Chr(N - Asc(letter))
            End If
        Next
        Return output
    End Function


    Private Sub AtbashEncryptButton_Click(sender As Object, e As EventArgs) Handles AtbashEncryptButton.Click
        Dim atbashPlainText As String
        Dim atbashCipherText As String
        Dim utility As New Utilities
        Dim inputRestriction As New Regex("\A[A-Za-z]+\Z")

        atbashPlainText = UCase(AtbashInputTB.Text)

        Select Case utility.MatchRegEx(atbashPlainText, inputRestriction)
            Case True
                atbashCipherText = AtbashCipher(atbashPlainText)
                AtbashOutputTB.Text = atbashCipherText
            Case Else
                MessageBox.Show("You can only encode letters")
        End Select


    End Sub
End Class
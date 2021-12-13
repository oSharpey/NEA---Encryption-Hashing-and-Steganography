Imports System.IO
Public Class HashForm
    Private Sub HashEncodeButton_Click(sender As Object, e As EventArgs) Handles HashEncodeButton.Click
        Dim inputText, outputHash As String
        Dim hash As New HashingAlgorithm()
        inputText = HashInputTextBox.Text
        outputHash = LCase(hash.SHA256(inputText))
        HashOutput.Text = "Hash: " & outputHash
        SaveToFile(outputHash, inputText)
    End Sub



    Private Sub SaveToFile(ByVal hash As String, ByVal input As String)
        Dim filename As String = "HashTable.txt"
        Dim append As Boolean = True

        Using writer As New StreamWriter(filename, append)
            writer.WriteLine($"Input: {input}")
            writer.WriteLine($"Hash:  {hash}")
        End Using

    End Sub

End Class
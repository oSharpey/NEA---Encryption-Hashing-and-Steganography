Imports System.Text.RegularExpressions
Public Class StegForm

    Private Sub StegEncodeButton_Click(sender As Object, e As EventArgs) Handles StegEncodeButton.Click
        Dim newimage As Bitmap
        Dim stegImage As Bitmap
        Dim plainTextMessage, binaryMessage As String
        Dim maxBytes As Integer
        Dim converter As New Utilities
        Dim StegEncode As New StegEncode()
        Dim inputRestriction As New Regex("\A[\x00-\x7f]+\Z")

        InputPicBox.SizeMode = PictureBoxSizeMode.StretchImage
        stegImage = InputPicBox.Image

        If MessageInputTB.Text = "" Or InputPicBox.Image Is Nothing Then
            MessageBox.Show("Cannot decode, you have not entered all the data required")

        Else


            plainTextMessage = MessageInputTB.Text + "~" 'adding this on the end allows to find the end of the message when you decode

            Select Case converter.MatchRegEx(plainTextMessage, inputRestriction)

                Case True
                    maxBytes = stegImage.Height * stegImage.Width * 3 / 8

                    binaryMessage = converter.MessageToBinary(plainTextMessage)

                    If Len(binaryMessage) > maxBytes Then
                        MessageBox.Show("Your message is too long, either get a bigger image or shorten your message")
                    Else
                        newimage = StegEncode.HideMessage(binaryMessage, stegImage)
                        MessageBox.Show("Your steg image has been saved in your photos folder")

                    End If
                Case False
                    MessageBox.Show("You can only encode ASCII characters")
            End Select
        End If

    End Sub

    Private Sub DecodeButton_Click(sender As Object, e As EventArgs) Handles decodeButton.Click

        Dim stegImage As Bitmap
        Dim decoder As New StegDecode()
        Dim message As String = ""

        stegImage = InputPicBox.Image

        If InputPicBox.Image Is Nothing Then
            MessageBox.Show("Cannot decode, you have not entered all the data required")
        Else
            Try
                message = decoder.Decode(stegImage)
            Catch
                MessageBox.Show("ERROR")
            End Try


            Select Case message
                Case "error"
                    MessageBox.Show("Error cannot decode")
                Case Else
                    outputBox.Text = message.Substring(0, message.Length - 1)
            End Select
        End If

    End Sub

    Private Sub OpenFileButton_Click(sender As Object, e As EventArgs) Handles openFileButton.Click
        'Opens a file dialog to allow you to upload an image
        'restricted to image files only.
        Try
            Dim filepath As New OpenFileDialog With {
                .Filter = "Image Files|*.jpg;*.bmp"
            }
            If filepath.ShowDialog() = DialogResult.OK Then

                Dim originalImage As Bitmap

                originalImage = Image.FromFile(filepath.FileName)
            End If
            InputPicBox.Image = Image.FromFile(filepath.FileName)
            filepath.Dispose()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        MessageInputTB.Clear()
        outputBox.Clear()
    End Sub
End Class
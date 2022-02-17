Public Class StegEncode
    Inherits Utilities
    Public Function HideMessage(ByVal binaryMessage As String, ByVal stegImage As Bitmap) As Bitmap
        Dim r, g, b, newB, newG, newR As Integer
        Dim binR, binG, binB As String
        Dim newimage As Bitmap = stegImage
        Dim messageIndex As Integer = 0
        Dim messageLength As Integer = Len(binaryMessage)
        Dim pixel, encodedPixel As Color
        Dim fileSuffix As String


        For i = 0 To newimage.Width - 1
            For j = 0 To newimage.Height - 1

                pixel = newimage.GetPixel(i, j)


                'this code block hides 1 bit of the secret message in the LSB each sub pixel of the image
                If messageIndex < messageLength Then
                    r = pixel.R
                    binR = IntToBin(r, 8).Substring(0, 7) + binaryMessage(messageIndex)
                    newR = BinToInt(binR)
                    messageIndex += 1
                End If

                If messageIndex < messageLength Then
                    g = pixel.G
                    binG = IntToBin(g, 8).Substring(0, 7) + binaryMessage(messageIndex)
                    newG = BinToInt(binG)
                    messageIndex += 1
                End If

                If messageIndex < messageLength Then
                    b = pixel.B
                    binB = IntToBin(b, 8).Substring(0, 7) + binaryMessage(messageIndex)
                    newB = BinToInt(binB)
                    messageIndex += 1
                End If

                encodedPixel = Color.FromArgb(pixel.A, newR, newG, newB)
                newimage.SetPixel(i, j, encodedPixel)

                'end 

                'CHECKS TO SEE IF MESSAGE HAS BEEN FULLY ENCODED
                If messageIndex >= messageLength Then
                    Exit For
                End If
            Next
            If messageIndex >= messageLength Then
                Exit For
            End If
        Next

        fileSuffix = GenarateRandString()

        'SAVES THE IMAGE TO PICTURES FOLDER
        newimage.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyPictures, "stegimage_" & fileSuffix & ".bmp"), System.Drawing.Imaging.ImageFormat.Bmp)


        Return newimage

    End Function


    Private Function GenarateRandString() As String
        'This function creates a random string that allows each filename created to have a 
        'unique suffix so they do not overwrite eachother

        Randomize()
        Dim characters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim rndstring As String = ""
        Dim rndindex As Integer

        For i = 0 To 8
            rndindex = Int(Rnd() * 62)
            rndstring += characters(rndindex)
        Next

        Return rndstring
    End Function
End Class

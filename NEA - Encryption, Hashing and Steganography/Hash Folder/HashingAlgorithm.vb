Public Class HashingAlgorithm
    Private ReadOnly Kvalues() As UInteger = {
            &H428A2F98UI, &H71374491UI, &HB5C0FBCFUI, &HE9B5DBA5UI, &H3956C25BUI, &H59F111F1UI, &H923F82A4UI, &HAB1C5ED5UI,
            &HD807AA98UI, &H12835B01UI, &H243185BEUI, &H550C7DC3UI, &H72BE5D74UI, &H80DEB1FEUI, &H9BDC06A7UI, &HC19BF174UI,
            &HE49B69C1UI, &HEFBE4786UI, &HFC19DC6UI, &H240CA1CCUI, &H2DE92C6FUI, &H4A7484AAUI, &H5CB0A9DCUI, &H76F988DAUI,
            &H983E5152UI, &HA831C66DUI, &HB00327C8UI, &HBF597FC7UI, &HC6E00BF3UI, &HD5A79147UI, &H6CA6351UI, &H14292967UI,
            &H27B70A85UI, &H2E1B2138UI, &H4D2C6DFCUI, &H53380D13UI, &H650A7354UI, &H766A0ABBUI, &H81C2C92EUI, &H92722C85UI,
            &HA2BFE8A1UI, &HA81A664BUI, &HC24B8B70UI, &HC76C51A3UI, &HD192E819UI, &HD6990624UI, &HF40E3585UI, &H106AA070UI,
            &H19A4C116UI, &H1E376C08UI, &H2748774CUI, &H34B0BCB5UI, &H391C0CB3UI, &H4ED8AA4AUI, &H5B9CCA4FUI, &H682E6FF3UI,
            &H748F82EEUI, &H78A5636FUI, &H84C87814UI, &H8CC70208UI, &H90BEFFFAUI, &HA4506CEBUI, &HBEF9A3F7UI, &HC67178F2UI
    }

    Private ReadOnly Hvalues() As UInteger = {
     &H6A09E667UI, &HBB67AE85UI, &H3C6EF372UI, &HA54FF53AUI,
     &H510E527FUI, &H9B05688CUI, &H1F83D9ABUI, &H5BE0CD19UI
    }


    Private Function RR(ByVal x As UInteger, ByVal b As UInteger) As UInteger
        Dim w As Integer = 32
        Return ((x >> b) Or (x << (w - b)))
    End Function

    Private Function RShift(ByVal x As UInteger, ByVal n As UInteger) As UInteger
        Dim shifted As UInteger = x >> n
        Return shifted
    End Function


    Private Function Translate(ByVal w As String) As List(Of UInteger)
        Dim charcodes As New List(Of UInteger)
        Dim bytes As New List(Of String)
        Dim bits As New List(Of UInteger)

        For Each c In w
            charcodes.Add(Asc(c))
        Next

        For Each C In charcodes
            bytes.Add(Convert.ToString(C, 2).PadLeft(8, "0"))
        Next

        For Each b In bytes
            For Each bit In b
                bits.Add(Integer.Parse(bit))
            Next
        Next

        Return bits

    End Function


    Private Function B2toB16(ByVal value As List(Of UInteger)) As String
        Dim binstring As String = ""
        Dim binaries As New List(Of UInteger)
        Dim hexes As String = ""
        Dim tempbin As String

        For Each x In value
            binstring += x.ToString
        Next

        For d = 0 To Len(binstring) - 1 Step 4
            tempbin = Convert.ToUInt32(binstring.Substring(d, 4), 2)
            binaries.Add(tempbin)
        Next

        For Each b In binaries
            hexes += Hex(b)
        Next

        Return hexes
    End Function

    Private Function B16toB2(ByVal value As UInteger) As List(Of UInteger)
        Dim binstring As String
        Dim binarray As New List(Of UInteger)

        binstring = Convert.ToString(value, 2).PadLeft(32, "0")

        For Each b In binstring
            binarray.Add(Integer.Parse(b))
        Next

        Return binarray
    End Function

    Private Function Init(ByVal value As List(Of UInteger)) As List(Of IList(Of UInteger))
        Dim binstring As String
        Dim binarray(31) As UInteger
        Dim words As New List(Of IList(Of UInteger))

        For Each h In value

            binstring = Convert.ToString(h, 2).PadLeft(32, "0")
            For i = 0 To Len(binstring) - 1
                binarray(i) = Integer.Parse(binstring(i))
            Next
            words.Add(binarray.ToList)
            Array.Clear(binarray, 0, 32)
        Next


        Return words
    End Function


    Private Function FillZeros(ByVal bits As List(Of UInteger), ByVal length As UInteger, ByVal endian As String) As List(Of UInteger)
        Dim l As UInteger = bits.Count

        If endian = "LE" Then
            For i = l To length - 1
                bits.Add(0)
            Next
        Else
            While l < length
                bits.Insert(0, 0)
                l = bits.Count
            End While
        End If

        Return bits
    End Function

    Private Function Chunker(ByVal bits As List(Of UInteger), ByVal chunklength As UInteger) As List(Of IList(Of UInteger))

        Dim chunked As New List(Of IList(Of UInteger))
        Dim tempchunk As List(Of UInteger)

        For i As UInteger = 0 To bits.Count - 1 Step chunklength
            tempchunk = bits.GetRange(i, chunklength)
            chunked.Add(tempchunk)
        Next

        Return chunked
    End Function

    Private Function Preprocessing(ByVal message As String) As List(Of IList(Of UInteger))

        Dim bits As List(Of UInteger)
        Dim length As UInteger
        Dim messagelenTemp As String
        Dim messagelen As New List(Of UInteger)


        bits = Translate(message)
        length = bits.Count
        messagelenTemp = Convert.ToString(length, 2).PadLeft(64, "0")

        For m = 0 To Len(messagelenTemp) - 1
            messagelen.Add(Integer.Parse(messagelenTemp(m)))
        Next


        Select Case (length)
            Case < 448
                bits.Add(1)
                bits = FillZeros(bits, 448, "LE")
                bits.AddRange(messagelen)
                Return Chunker(bits, 512)
            Case 448
                bits.Add(1)
                bits = FillZeros(bits, 1024, "LE")
                For i = 0 To 63
                    bits.RemoveAt(bits.Count - 1)
                Next
                bits.AddRange(messagelen)
                Return Chunker(bits, 512)
            Case Else
                bits.Add(1)
                While bits.Count Mod 512 <> 0
                    bits.Add(0)
                End While
                For i = 0 To 63
                    bits.RemoveAt(bits.Count - 1)
                Next
                bits.AddRange(messagelen)
                Return Chunker(bits, 512)
        End Select
    End Function

    Public Function SHA256(ByVal message As String) As String
        Dim k As List(Of IList(Of UInteger))
        Dim hlist As List(Of IList(Of UInteger))
        Dim h0, h1, h2, h3, h4, h5, h6, h7 As List(Of UInteger)
        Dim a, b, c, d, e, f, g, h As List(Of UInteger)
        Dim chunks As List(Of IList(Of UInteger))
        Dim w As List(Of IList(Of UInteger))
        Dim templistW As New List(Of UInteger)
        Dim tempintW As ULong
        Dim ch As List(Of UInteger)
        Dim s0 As List(Of UInteger)
        Dim s1 As List(Of UInteger)
        Dim s2 As List(Of UInteger)
        Dim s3 As List(Of UInteger)
        Dim maj As List(Of UInteger)
        Dim t1 As List(Of UInteger)
        Dim t2 As List(Of UInteger)
        Dim digest As String

        k = Init(Kvalues.ToList)
        hlist = Init(Hvalues.ToList)

#Region "Assing contants values"
        h0 = hlist(0)
        h1 = hlist(1)
        h2 = hlist(2)
        h3 = hlist(3)
        h4 = hlist(4)
        h5 = hlist(5)
        h6 = hlist(6)
        h7 = hlist(7)
#End Region


        chunks = Preprocessing(message)

        For t = 0 To 31
            templistW.Add(0)
        Next

        For Each chunk In chunks
            w = Chunker(chunk, 32)
            For x = 0 To 47
                w.Add(templistW)
            Next

            For i = 16 To 63
                s0 = B16toB2(RR(Convert.ToUInt32(B2toB16(w(i - 15)), 16), 7) Xor RR(Convert.ToUInt32(B2toB16(w(i - 15)), 16), 18) Xor RShift(Convert.ToUInt32(B2toB16(w(i - 15)), 16), 3))
                s1 = B16toB2(RR(Convert.ToUInt32(B2toB16(w(i - 2)), 16), 17) Xor RR(Convert.ToUInt32(B2toB16(w(i - 2)), 16), 19) Xor RShift(Convert.ToUInt32(B2toB16(w(i - 2)), 16), 10))
                tempintW = (Convert.ToUInt64(B2toB16(w(i - 16)), 16) + Convert.ToUInt64(B2toB16(s0), 16) + Convert.ToUInt64(B2toB16(w(i - 7)), 16) + Convert.ToUInt64(B2toB16(s1), 16)) Mod 2 ^ 32
                w(i) = B16toB2(tempintW)
            Next

            a = h0
            b = h1
            c = h2
            d = h3
            e = h4
            f = h5
            g = h6
            h = h7

            For j = 0 To 63
                s2 = B16toB2(RR(Convert.ToUInt32(B2toB16(e), 16), 6) Xor RR(Convert.ToUInt32(B2toB16(e), 16), 11) Xor RR(Convert.ToUInt32(B2toB16(e), 16), 25))
                ch = B16toB2((Convert.ToUInt32(B2toB16(e), 16) And Convert.ToUInt32(B2toB16(f), 16)) Xor (Not (Convert.ToUInt32(B2toB16(e), 16)) And Convert.ToUInt32(B2toB16(g), 16)))
                t1 = B16toB2((Convert.ToUInt64(B2toB16(w(j)), 16) + Convert.ToUInt64(B2toB16(s2), 16) + Convert.ToUInt64(B2toB16(k(j)), 16) + Convert.ToUInt64(B2toB16(ch), 16) + Convert.ToUInt64(B2toB16(h), 16)) Mod 2 ^ 32)
                s3 = B16toB2(RR(Convert.ToUInt32(B2toB16(a), 16), 2) Xor RR(Convert.ToUInt32(B2toB16(a), 16), 13) Xor RR(Convert.ToUInt32(B2toB16(a), 16), 22))
                maj = B16toB2((Convert.ToUInt32(B2toB16(a), 16) And Convert.ToUInt32(B2toB16(b), 16)) Xor (Convert.ToUInt32(B2toB16(a), 16) And Convert.ToUInt32(B2toB16(c), 16)) Xor (Convert.ToUInt32(B2toB16(b), 16) And Convert.ToUInt32(B2toB16(c), 16)))
                t2 = B16toB2((Convert.ToUInt64(B2toB16(s3), 16) + Convert.ToUInt64(B2toB16(maj), 16)) Mod 2 ^ 32)


                h = g
                g = f
                f = e
                e = B16toB2((Convert.ToUInt64(B2toB16(d), 16) + Convert.ToUInt64(B2toB16(t1), 16)) Mod 2 ^ 32)
                d = c
                c = b
                b = a
                a = B16toB2((Convert.ToUInt64(B2toB16(t1), 16) + Convert.ToUInt64(B2toB16(t2), 16)) Mod 2 ^ 32)
            Next
            h0 = B16toB2((Convert.ToUInt64(B2toB16(h0), 16) + Convert.ToUInt64(B2toB16(a), 16)) Mod 2 ^ 32)
            h1 = B16toB2((Convert.ToUInt64(B2toB16(h1), 16) + Convert.ToUInt64(B2toB16(b), 16)) Mod 2 ^ 32)
            h2 = B16toB2((Convert.ToUInt64(B2toB16(h2), 16) + Convert.ToUInt64(B2toB16(c), 16)) Mod 2 ^ 32)
            h3 = B16toB2((Convert.ToUInt64(B2toB16(h3), 16) + Convert.ToUInt64(B2toB16(d), 16)) Mod 2 ^ 32)
            h4 = B16toB2((Convert.ToUInt64(B2toB16(h4), 16) + Convert.ToUInt64(B2toB16(e), 16)) Mod 2 ^ 32)
            h5 = B16toB2((Convert.ToUInt64(B2toB16(h5), 16) + Convert.ToUInt64(B2toB16(f), 16)) Mod 2 ^ 32)
            h6 = B16toB2((Convert.ToUInt64(B2toB16(h6), 16) + Convert.ToUInt64(B2toB16(g), 16)) Mod 2 ^ 32)
            h7 = B16toB2((Convert.ToUInt64(B2toB16(h7), 16) + Convert.ToUInt64(B2toB16(h), 16)) Mod 2 ^ 32)

        Next

        digest = B2toB16(h0) + B2toB16(h1) + B2toB16(h2) + B2toB16(h3) + B2toB16(h4) + B2toB16(h5) + B2toB16(h6) + B2toB16(h7)

        Return digest

    End Function




End Class

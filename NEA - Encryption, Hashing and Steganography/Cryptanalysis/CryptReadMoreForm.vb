Public Class CryptReadMoreForm
    Private Sub CryptReadMoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        engimaLink1.Links.Add(0, Len(engimaLink1.Text), "www.101computing.net/tag/enigma")
        engimaLink2.Links.Add(0, Len(engimaLink2.Text), "www.practicalcryptography.com/ciphers/enigma-cipher/")
        CaesarLink.Links.Add(0, Len(CaesarLink.Text), "www.practicalcryptography.com/ciphers/caesar-cipher/")
        AtbashLink.Links.Add(0, Len(AtbashLink.Text), "www.practicalcryptography.com/ciphers/atbash-cipher-cipher/")
        StegLink.Links.Add(0, Len(StegLink.Text), "www.youtube.com/watch?v=TWEXCYQKyDc")
        SHALink1.Links.Add(0, Len(SHALink1.Text), "www.wikipedia.org/wiki/SHA-2")
        SHALink2.Links.Add(0, Len(SHALink2.Text), "www.youtube.com/watch?v=DMtFhACPnTY")
    End Sub

    Private Sub EngimaLink1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles engimaLink1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub EngimaLink2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles engimaLink2.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub CaesarLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CaesarLink.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub AtbashLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AtbashLink.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub StegLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles StegLink.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub SHALink1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SHALink1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub SHALink2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SHALink2.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub
End Class
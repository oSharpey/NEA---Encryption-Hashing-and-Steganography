''
' For the design of this form I used a youtube tutorial to help me 
''

Public Class CryptanalysisForm

    Private currentButton As Button
    Private currentSecondForm As Form
    Private Sub OpenSecondaryForm(secondaryForm As Form)
        If currentSecondForm IsNot Nothing Then
            currentSecondForm.Close()
        End If

        currentSecondForm = secondaryForm

        secondaryForm.TopLevel = False
        secondaryForm.FormBorderStyle = FormBorderStyle.None
        secondaryForm.Dock = DockStyle.Fill
        DesktopPanel.Controls.Add(secondaryForm)
        DesktopPanel.Tag = secondaryForm

        secondaryForm.BringToFront()
        secondaryForm.Show()

        CurrentFormLabel.Text = secondaryForm.Text

    End Sub

    Private Sub ActiveButton(senderbutton As Object)
        If senderbutton IsNot Nothing Then
            'Unhighlight previous button
            DisableButton()
            'Highlight Button
            currentButton = CType(senderbutton, Button)
            currentButton.BackColor = Color.FromArgb(33, 30, 60)
        End If
    End Sub

    Private Sub DisableButton()
        If currentButton IsNot Nothing Then
            currentButton.BackColor = Color.FromArgb(33, 34, 74)
        End If
    End Sub

    Private Sub CryptCaesarButton_Click(sender As Object, e As EventArgs) Handles CryptCaesarButton.Click
        ActiveButton(sender)
        OpenSecondaryForm(New CryptCaesarForm)
    End Sub

    Private Sub CryptAtbashButton_Click(sender As Object, e As EventArgs) Handles CryptAtbashButton.Click
        ActiveButton(sender)
        OpenSecondaryForm(New CryptAtbashForm)
    End Sub

    Private Sub CryptEnigmaButton_Click(sender As Object, e As EventArgs) Handles CryptEnigmaButton.Click
        ActiveButton(sender)
        OpenSecondaryForm(New CryptEnigmaForm)
    End Sub

    Private Sub CryptHashButton_Click(sender As Object, e As EventArgs) Handles CryptHashButton.Click
        ActiveButton(sender)
        OpenSecondaryForm(New CryptHashForm)
    End Sub

    Private Sub CryptStegButton_Click(sender As Object, e As EventArgs) Handles CryptStegButton.Click
        ActiveButton(sender)
        OpenSecondaryForm(New CryptStegForm)
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        If currentSecondForm IsNot Nothing Then
            currentSecondForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        DisableButton()
        CurrentFormLabel.Text = "Home"
    End Sub

    Private Sub ReadMoreButton_Click(sender As Object, e As EventArgs) Handles readMoreButton.Click
        ActiveButton(sender)
        OpenSecondaryForm(New CryptReadMoreForm)
    End Sub
End Class
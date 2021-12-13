Imports FontAwesome.Sharp

Public Class MenuForm

    Private currentButton As IconButton
    Private ReadOnly leftBorderButton As Panel
    Private currentChildForm As Form


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.



        leftBorderButton = New Panel With {
            .Size = New Size(7, 70)
        }
        PanelMenu.Controls.Add(leftBorderButton)
    End Sub


    Private Sub ActivateButton(senderBtn As Object, customColour As Color)
        If senderBtn IsNot Nothing Then
            'reverts the currently selected button
            DisableButton()
            'Changes button layout 
            currentButton = CType(senderBtn, IconButton)
            currentButton.BackColor = Color.FromArgb(37, 36, 81)
            currentButton.ForeColor = customColour
            currentButton.IconColor = customColour
            currentButton.TextAlign = ContentAlignment.MiddleCenter
            currentButton.TextAlign = ContentAlignment.MiddleRight
            currentButton.TextImageRelation = TextImageRelation.TextBeforeImage
            'Changes left border
            leftBorderButton.BackColor = customColour
            leftBorderButton.Location = New Point(0, currentButton.Location.Y)
            leftBorderButton.Visible = True
            leftBorderButton.BringToFront()
            'Changes current icon
            currentFormIcon.IconChar = currentButton.IconChar
            currentFormIcon.IconColor = customColour
        End If
    End Sub

    Private Sub OpenChildForm(childform As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        panelDesktop.Controls.Add(childform)
        panelDesktop.Tag = childform
        childform.BringToFront()
        childform.Show()
        formTitleLabel.Text = childform.Text
    End Sub

    Private Sub DisableButton()
        If currentButton IsNot Nothing Then
            'reverts to original button layout 
            currentButton.BackColor = Color.FromArgb(31, 30, 68)
            currentButton.ForeColor = Color.Gainsboro
            currentButton.IconColor = Color.Gainsboro
            currentButton.TextAlign = ContentAlignment.MiddleLeft
            currentButton.TextAlign = ContentAlignment.MiddleLeft
            currentButton.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub CryptButton_Click(sender As Object, e As EventArgs) Handles cryptButton.Click
        ActivateButton(sender, CustomColours.colour1)
        OpenChildForm(New CryptanalysisForm)
    End Sub

    Private Sub EnigmaButton_Click(sender As Object, e As EventArgs) Handles enigmaButton.Click
        ActivateButton(sender, CustomColours.colour2)
        OpenChildForm(New EngimaForm)
    End Sub

    Private Sub StegButton_Click(sender As Object, e As EventArgs) Handles stegButton.Click
        ActivateButton(sender, CustomColours.colour3)
        OpenChildForm(New StegForm)
    End Sub

    Private Sub CaesarButton_Click(sender As Object, e As EventArgs) Handles caesarButton.Click
        ActivateButton(sender, CustomColours.colour4)
        OpenChildForm(New CaesarForm)
    End Sub

    Private Sub StbashButton_Click(sender As Object, e As EventArgs) Handles atbashButton.Click
        ActivateButton(sender, CustomColours.colour5)
        OpenChildForm(New AtbashForm)
    End Sub

    Private Sub HashButton_Click(sender As Object, e As EventArgs) Handles hashButton.Click
        ActivateButton(sender, CustomColours.colour6)
        OpenChildForm(New HashForm)
    End Sub

    Private Sub PictureBoxHome_Click(sender As Object, e As EventArgs) Handles PictureBoxHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderButton.Visible = False
        currentFormIcon.IconChar = IconChar.Home
        currentFormIcon.IconColor = Color.MediumPurple
        formTitleLabel.Text = "Home"
    End Sub
End Class

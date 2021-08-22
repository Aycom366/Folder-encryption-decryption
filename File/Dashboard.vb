Imports System.Data.SqlClient
Public Class Dashboard
    Dim con As New SqlConnection("Data Source=.;Initial Catalog=Folder_lock;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlock.Click
        With lock
            .TopLevel = False
            Panel3.Controls.Add(lock)
            .BringToFront()
            .Show()
        End With

        Panel4.Top = btnlock.Top
        Panel4.Height = btnlock.Height
    End Sub

    Private Sub btunlock_Click(sender As Object, e As EventArgs) Handles btunlock.Click
        Panel4.Top = btunlock.Top
        Panel4.Height = btunlock.Height

        With unlock
            .TopLevel = False
            Panel3.Controls.Add(unlock)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnhide_Click(sender As Object, e As EventArgs) Handles btnhide.Click
        Panel4.Top = btnhide.Top
        Panel4.Height = btnhide.Height

        'calls the form showfolder
        With Hidefolder
            .TopLevel = False
            Panel3.Controls.Add(Hidefolder)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnshowfolder_Click(sender As Object, e As EventArgs) Handles btnshowfolder.Click
        Panel4.Top = btnshowfolder.Top
        Panel4.Height = btnshowfolder.Height

        'calls the form showfolder
        With showfolder
            .TopLevel = False
            Panel3.Controls.Add(showfolder)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnencrypt_Click(sender As Object, e As EventArgs) Handles btnencrypt.Click
        Panel4.Top = btnencrypt.Top
        Panel4.Height = btnencrypt.Height

        'calls the form showfolder
        With Encrypt
            .TopLevel = False
            Panel3.Controls.Add(Encrypt)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btndecrypt_Click(sender As Object, e As EventArgs) Handles btndecrypt.Click
        Panel4.Top = btndecrypt.Top
        Panel4.Height = btndecrypt.Height

        'calls the form showfolder
        With dencrypt
            .TopLevel = False
            Panel3.Controls.Add(dencrypt)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        Panel4.Top = btnabout.Top
        Panel4.Height = btnabout.Height


        'calls the form showfolder
        With about
            .TopLevel = False
            Panel3.Controls.Add(about)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Panel4.Top = btnhome.Top
        Panel4.Height = btnhome.Height


        'calls the form showfolder
        With Panel6
            '.TopLevel = False
            Panel3.Controls.Add(Panel6)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnhome1_Click(sender As Object, e As EventArgs) Handles btnhome1.Click
        Panel4.Top = btnhome.Top
        Panel4.Height = btnhome.Height


        'calls the form showfolder
        With Panel6
            '.TopLevel = False
            Panel3.Controls.Add(Panel6)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btnlock1.Click
        With lock
            .TopLevel = False
            Panel3.Controls.Add(lock)
            .BringToFront()
            .Show()
        End With

        Panel4.Top = btnlock.Top
        Panel4.Height = btnlock.Height
    End Sub

    Private Sub btnunlock1_Click(sender As Object, e As EventArgs) Handles btnunlock1.Click
        Panel4.Top = btunlock.Top
        Panel4.Height = btunlock.Height

        With unlock
            .TopLevel = False
            Panel3.Controls.Add(unlock)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnhide1_Click(sender As Object, e As EventArgs) Handles btnhide1.Click
        Panel4.Top = btnhide.Top
        Panel4.Height = btnhide.Height

        'calls the form showfolder
        With Hidefolder
            .TopLevel = False
            Panel3.Controls.Add(Hidefolder)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnshowfolder1_Click(sender As Object, e As EventArgs) Handles btnshowfolder1.Click
        Panel4.Top = btnshowfolder.Top
        Panel4.Height = btnshowfolder.Height

        'calls the form showfolder
        With showfolder
            .TopLevel = False
            Panel3.Controls.Add(showfolder)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnetn_Click(sender As Object, e As EventArgs) Handles btnetn.Click
        Panel4.Top = btnencrypt.Top
        Panel4.Height = btnencrypt.Height

        'calls the form showfolder
        With Encrypt
            .TopLevel = False
            Panel3.Controls.Add(Encrypt)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btndec_Click(sender As Object, e As EventArgs) Handles btndec.Click
        Panel4.Top = btndecrypt.Top
        Panel4.Height = btndecrypt.Height

        'calls the form showfolder
        With dencrypt
            .TopLevel = False
            Panel3.Controls.Add(dencrypt)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Panel4.Top = btnabout.Top
        Panel4.Height = btnabout.Height


        'calls the form showfolder
        With about
            .TopLevel = False
            Panel3.Controls.Add(about)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbtime.Text = DateAndTime.TimeOfDay
        Lbdate.Text = DateAndTime.Today
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButton1.Click
        If MsgBox("Are you sure you want to close this application", vbQuestion + vbYesNo) = vbYes Then
            End
        End If
    End Sub

End Class
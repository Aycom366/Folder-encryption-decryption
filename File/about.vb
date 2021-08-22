Public Class about

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dashboard.Panel4.Top = Dashboard.btnhome.Top
        Dashboard.Panel4.Height = Dashboard.btnhome.Height


        'calls the form showfolder
        With Dashboard.Panel6
            '.TopLevel = False
            Dashboard.Panel3.Controls.Add(Dashboard.Panel6)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub
End Class
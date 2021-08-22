Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hides progresbar at load and start timer1
        ProgressBar1.Hide()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'timer1 changing elements in form
        Timer1.Start()
        ProgressBar1.Increment(1)

        If ProgressBar1.Value = 10 Then
            Label4.Text = "Getting Reading Component..."
        End If
        If ProgressBar1.Value = 20 Then
            Label4.Text = "Loading Ready Components..."
        End If
        If ProgressBar1.Value = 30 Then
            Label4.Text = "Starting Ready Components..."
        End If
        If ProgressBar1.Value = 40 Then
            Label4.Text = "Gathering Ready Information..."
        End If
        If ProgressBar1.Value = 50 Then
            Label4.Text = "Loading Application Components..."
        End If
        If ProgressBar1.Value = 60 Then
            Label4.Text = "Starting Loaded Files..."
        End If
        If ProgressBar1.Value = 70 Then
            Label4.Text = "Starting Ready Components..."
        End If
        If ProgressBar1.Value = 90 Then
            Label4.Text = "Starting Application Software..."
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            login.Show()
        End If


        Label2.Text += 1
        If Label2.Text = 100 Then
            Login.Show()
            Me.Hide()
        End If
    End Sub
End Class

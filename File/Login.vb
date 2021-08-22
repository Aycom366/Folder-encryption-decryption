Imports System.Data.SqlClient
Public Class Login
    Dim con As New SqlConnection("Data Source=.;Initial Catalog=Folder_lock;Integrated Security=True")
    Private Sub btnsave_Click(sender As Object, e As EventArgs)
        Dashboard.Show()
        Me.Hide()
    End Sub


    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txtusername.Focus()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtpass.Focus()
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            If txtpass.UseSystemPasswordChar = True Then
                txtpass.UseSystemPasswordChar = False
            End If
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtusername.Text = "" And txtpass.Text = "" Then
            MessageBox.Show("Please fill in values to gain entry to the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ds As New SqlDataAdapter("SELECT * FROM Login WHERE UserName='" & txtusername.Text & "' and Password='" & txtpass.Text & "' ", con)
        Dim dt As New DataTable
        ds.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Password or username incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Clear()
            txtpass.Clear()
            txtusername.Focus()
        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            con.Open()
            Dim num As String = "SELECT COUNT(*) FROM Login "
            Dim cmd As New SqlCommand(num, con)
            Dim ns As Integer = cmd.ExecuteScalar
            cmd = Nothing
            If ns > 0 Then
                MessageBox.Show("This system can only be used by a particular user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("This system can only be used by a particular user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        With forgot
            .TopLevel = False
            Panel2.Controls.Add(forgot)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnexit_MouseLeave(sender As Object, e As EventArgs) Handles btnexit.MouseLeave
        btnexit.BackColor = Color.Maroon
        btnexit.ForeColor = Color.White
        btnexit.FlatAppearance.BorderSize = 0
        btnexit.FlatAppearance.BorderColor = Color.Maroon
    End Sub

    Private Sub btnexit_MouseHover(sender As Object, e As EventArgs) Handles btnexit.MouseHover
        btnexit.BackColor = Color.Transparent
        btnexit.ForeColor = Color.White
        btnexit.FlatAppearance.BorderSize = 3
        btnexit.FlatAppearance.BorderColor = Color.Maroon
    End Sub

    Private Sub btnsave_MouseHover(sender As Object, e As EventArgs) Handles btnsave.MouseHover
        btnsave.BackColor = Color.Transparent
        btnsave.ForeColor = Color.White
        btnsave.FlatAppearance.BorderSize = 3
        btnsave.FlatAppearance.BorderColor = Color.White
    End Sub

    Private Sub btnsave_MouseLeave(sender As Object, e As EventArgs) Handles btnsave.MouseLeave
        btnsave.BackColor = Color.White
        btnsave.ForeColor = DefaultForeColor
        btnsave.FlatAppearance.BorderSize = 0
        btnsave.FlatAppearance.BorderColor = Color.White
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If MsgBox("Are you sure you want to close this application", vbQuestion + vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        With forget
            .TopLevel = False
            Panel2.Controls.Add(forget)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
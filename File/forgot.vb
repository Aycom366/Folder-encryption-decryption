Imports System.Data.SqlClient
Public Class forgot
    Dim con As New SqlConnection("Data Source=.;Initial Catalog=Folder_lock;Integrated Security=True")
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            If txtconfirm.UseSystemPasswordChar = True Then
                txtconfirm.UseSystemPasswordChar = False
            End If
        Else
            txtconfirm.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            If txtpass.UseSystemPasswordChar = True Then
                txtpass.UseSystemPasswordChar = False
            End If
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txtusername.Focus()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtpass.Focus()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        txtsecu.Focus()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        txtconfirm.Focus()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Len(Trim(txtusername.Text)) = 0 Then
            MessageBox.Show("Please fill Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Clear()
            txtusername.Focus()
            Exit Sub
        End If

        If Len(Trim(txtsecu.Text)) = 0 Then
            MessageBox.Show("Please answer security question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtsecu.Clear()
            txtsecu.Focus()
            Exit Sub
        End If

        If Len(Trim(txtconfirm.Text)) = 0 Then
            MessageBox.Show("Please fill password to access the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtsecu.Clear()
            txtsecu.Focus()
            Exit Sub
        End If

        If Len(Trim(txtID.Text)) = 0 Then
            MessageBox.Show("Uses ID needed", "User can only be created once", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtsecu.Clear()
            txtsecu.Focus()
            Exit Sub
        End If

        If txtconfirm.Text <> txtpass.Text Then
            MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtconfirm.Clear()
            txtconfirm.Focus()
            Exit Sub
        End If

        Try
            con.Open()
            Dim s As String = "INSERT INTO Login VALUES('" & txtID.Text & "','" & txtusername.Text & "','" & txtconfirm.Text & "','" & txtsecu.Text & "')"
            Dim cmd As New SqlCommand(s, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("User Added", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtID.Clear()
            txtusername.Clear()
            txtconfirm.Clear()
            txtsecu.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function generate()
        Dim rmd As New Random
        Dim stfID As Integer
        stfID = rmd.Next(1, 100)
        txtID.Text = "St-" & stfID
    End Function

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub


    Private Sub forgot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generate()
    End Sub
End Class
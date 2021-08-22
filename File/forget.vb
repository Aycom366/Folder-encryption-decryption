Imports System.Data.SqlClient
Public Class forget
    Dim con As New SqlConnection("Data Source=.;Initial Catalog=Folder_lock;Integrated Security=True")
    Private Sub txtsecu_TextChanged(sender As Object, e As EventArgs) Handles txtsecu.TextChanged
        Try
            con.Open()
            Dim s As New SqlCommand("SELECT * FROM Login WHERE Security = '" & txtsecu.Text & "'", con)
            Dim dt As SqlDataReader = s.ExecuteReader
            While dt.Read
                txtusername.Text = dt(1).ToString
                txtpass.Text = dt(2).ToString
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Dispose()
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

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            If txtconfirm.UseSystemPasswordChar = True Then
                txtconfirm.UseSystemPasswordChar = False
            End If
        Else
            txtconfirm.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtconfirm.Text <> txtpass.Text Then
            MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtconfirm.Clear()
            txtconfirm.Focus()
            Exit Sub
        End If

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

        Try
            'checks whether the middle name types is the same with databse middle name
            Dim ds As New SqlDataAdapter("SELECT * FROM Login WHERE Security='" & txtsecu.Text & "'  ", con)
            Dim dt As New DataTable
            ds.Fill(dt)
            If (dt.Rows.Count <= 0) Then
                MessageBox.Show("Middle Name Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'updates the information retrived if the users wants to change some informations.
            con.Open()
            Dim upd As New SqlCommand("UPDATE Login SET UserName = '" & txtusername.Text & "', Password = '" & txtconfirm.Text & "', Security =  '" & txtsecu.Text & "' ", con)
            upd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Updated", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Clear()
            txtconfirm.Clear()
            txtsecu.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(Trim(txtsecu.Text)) = 0 Then
            MessageBox.Show("Please fill in security question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtsecu.Focus()
            Exit Sub
        End If

        'checks whether the middle name types is the same with databse middle name
        Dim de As New SqlDataAdapter("SELECT * FROM Login WHERE Security='" & txtsecu.Text & "'  ", con)
        Dim df As New DataTable
        de.Fill(df)
        If (df.Rows.Count <= 0) Then
            MessageBox.Show("Middle Name Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        con.Open()
        Dim cmd1 As New SqlCommand("DELETE FROM Login WHERE Security = '" & txtsecu.Text & "'", con)
        cmd1.ExecuteNonQuery()
        MessageBox.Show("Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
        txtusername.Clear()
        txtconfirm.Clear()
        txtpass.Clear()
        txtsecu.Clear()
    End Sub
End Class
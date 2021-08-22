Imports System.IO
Imports System.Drawing.Color
Imports System.Security.AccessControl
Imports System.Diagnostics.Process
Imports System.Data.SqlClient
Public Class dencrypt
    Dim hexcolor As String = "#0054fe"
    Dim con As New SqlConnection("Data Source=.;Initial Catalog=Folder_lock;Integrated Security=True")
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

    Dim Filee As String, SafeName As String
    Dim LanguageWrite As Boolean = True
    Dim PW As String = "@#$%^&"
    Dim DCfile As String, DcSafeFile As String

    Private Sub btndencrypt_Click(sender As Object, e As EventArgs) Handles btndencrypt.Click
        'validates textbox
        If txtdencrypt.TextLength > 0 And txtdecrypt1.TextLength > 0 Then
            MessageBox.Show("An Decryption Process is going on,sorry! it cant be interrupted!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtdencrypt.Text = "" Then
            lfile.Visible = True
            Exit Sub
        End If

        Try
            Dim ds As New SqlDataAdapter("SELECT * FROM Ecrypt_Decrypt WHERE  ID='" & TextBox2.Text & "'", con)
            Dim dt As New DataTable
            ds.Fill(dt)
            If (dt.Rows.Count <= 0) Then
                MessageBox.Show("Error with the ID selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'immediately deleting encrypt path from database
        Try
            con.Open()
            Dim s As String = "DELETE FROM Ecrypt_Decrypt WHERE ID = '" & TextBox2.Text & "'"
            Dim cmd3 As New SqlCommand(s, con)
            cmd3.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If txtdencrypt.Text = "OpenFileDialog1" Then
            lfile.Visible = True
            lfile.Text = "Error"
            txtdencrypt.Clear()
            Exit Sub
        End If



        'decryption process start
        DCfile = OpenFileDialog1.FileName
        DcSafeFile = OpenFileDialog1.FileName
        txtdencrypt.Text = DcSafeFile
        If Not BGWK2.IsBusy Then BGWK2.RunWorkerAsync()

        Dim cmd As New SqlCommand("SELECT * FROM Ecrypt_Decrypt", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        datagridview1.DataSource = table
        Encrypt.datagridview1.DataSource = table

        Encrypt.generate()
    End Sub

    Private Sub btnbrowsefile_Click(sender As Object, e As EventArgs) Handles btnbrowsefile.Click
        If txtdencrypt.TextLength > 0 And txtdecrypt1.TextLength > 0 Then
            MessageBox.Show("An Decryption Process is going on,sorry! it cant be interrupted!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        lfile.Visible = False
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Title = "Choose File"
        OpenFileDialog1.Filter = "All Files|*.*"
        txtdencrypt.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub BGWK2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWK2.DoWork
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Dim Tmpsrc As String = IO.File.ReadAllText(DCfile)
            ProgressBar1.Maximum = Convert.ToInt64(Tmpsrc.Length)
            For i As Integer = 1 To Tmpsrc.Length
                txtdecrypt1.Text = i & "/" & Tmpsrc.Length
                ProgressBar1.Value = Convert.ToInt64(i)
            Next
            MessageBox.Show("File Decryption Successful!!!", "File Decrypted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Value = 0
            txtdecrypt1.Clear()
            txtdencrypt.Clear()
            IO.File.WriteAllBytes(DCfile, Convert.FromBase64String(Tmpsrc.Replace(PW, String.Empty)))
        Catch : End Try
    End Sub

    Private Sub btnclearfile_Click(sender As Object, e As EventArgs) Handles btnclearfile.Click
        If txtdencrypt.TextLength > 0 And txtdecrypt1.TextLength > 0 Then
            MessageBox.Show("An Decryption Process is going on,sorry! it cant be interrupted!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        lfile.Visible = False
        txtdecrypt1.Clear()
        txtdencrypt.Clear()
    End Sub

    Private Sub dencrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Folder_lockDataSet3.Ecrypt_Decrypt' table. You can move, or remove it, as needed.
        Me.Ecrypt_DecryptTableAdapter.Fill(Me.Folder_lockDataSet3.Ecrypt_Decrypt)
        Dim cmd As New SqlCommand("SELECT * FROM Ecrypt_Decrypt", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        datagridview1.DataSource = table

        lfile.Visible = False
    End Sub

    Private Sub btndencrypt_MouseHover(sender As Object, e As EventArgs) Handles btndencrypt.MouseHover
        btndencrypt.BackColor = Color.Transparent
        btndencrypt.ForeColor = ColorTranslator.FromHtml(hexcolor)
        btndencrypt.FlatAppearance.BorderSize = 3
        btndencrypt.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btndencrypt_MouseLeave(sender As Object, e As EventArgs) Handles btndencrypt.MouseLeave
        btndencrypt.BackColor = ColorTranslator.FromHtml(hexcolor)
        btndencrypt.ForeColor = Color.White
        btndencrypt.FlatAppearance.BorderSize = 0
        btndencrypt.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btnclearfile_MouseHover(sender As Object, e As EventArgs) Handles btnclearfile.MouseHover
        btnclearfile.BackColor = Color.Transparent
        btnclearfile.ForeColor = Color.Maroon
        btnclearfile.FlatAppearance.BorderSize = 3
        btnclearfile.FlatAppearance.BorderColor = Color.Maroon
    End Sub

    Private Sub btnclearfile_MouseLeave(sender As Object, e As EventArgs) Handles btnclearfile.MouseLeave
        btnclearfile.BackColor = Color.Maroon
        btnclearfile.ForeColor = Color.White
        btnclearfile.FlatAppearance.BorderSize = 0
        btnclearfile.FlatAppearance.BorderColor = Color.Maroon
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        con.Open()
        Dim s As String = "SELECT * FROM Ecrypt_Decrypt WHERE ID ='" & TextBox2.Text & "' "
        Dim cmd As New SqlCommand(s, con)
        Dim dt As SqlDataReader = cmd.ExecuteReader
        While dt.Read
            txtdencrypt.Text = dt(1).ToString
        End While
        con.Close()
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        If TextBox2.Text = "ID here" Then
            TextBox2.Clear()
        End If
    End Sub

    Private Sub TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles TextBox2.MouseEnter
        If TextBox2.Text = "ID here" Then
            TextBox2.Clear()
        End If
    End Sub

    Private Sub TextBox2_MouseLeave(sender As Object, e As EventArgs) Handles TextBox2.MouseLeave
        If TextBox2.Text = "" Then
            TextBox2.Text = "ID here"
        End If
    End Sub
End Class
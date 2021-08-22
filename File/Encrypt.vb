Imports System.IO
Imports System.Security.AccessControl
Imports System.Diagnostics.Process
Imports System.Data.SqlClient
Public Class Encrypt
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

    Private Sub btnclearfile_Click(sender As Object, e As EventArgs) Handles btnclearfile.Click
        If txtencrypt.TextLength > 0 And txtencrypt1.TextLength > 0 Then
            MessageBox.Show("An Ecryption Process is going on,sorry! it cant be interrupted!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'clears textbox on click
        txtencrypt.Clear()
        txtencrypt1.Clear()
        lfile.Visible = False
    End Sub

    Private Sub btnencrypt_Click(sender As Object, e As EventArgs) Handles btnencrypt.Click
        If txtencrypt.TextLength > 0 And txtencrypt1.TextLength > 0 Then
            MessageBox.Show("An Ecryption Process is going on,sorry! it cant be interrupted!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'clears textbox on click



        'validates the encrypt button
        If txtencrypt.Text = "" Then
            lfile.Visible = True
            Timer1.Start()
            ProgressBar2.Increment(1)
            If ProgressBar2.Value = 10 Then
                lfile.Visible = False
                ProgressBar2.Value = 100
            End If
            Timer1.Stop()
            Exit Sub
        End If

     

        If txtencrypt.Text = "OpenFileDialog1" Then
            lfile.Show()
            lfile.Text = "Error"
            Exit Sub
        End If


        'checks if files to encry is already encrypted
        Try
            Dim ds As New SqlDataAdapter("SELECT * FROM Ecrypt_Decrypt WHERE  Paths='" & txtencrypt.Text & "'", con)
            Dim dt As New DataTable
            ds.Fill(dt)
            If (dt.Rows.Count > 0) Then
                MessageBox.Show("File is Encrypted already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtencrypt.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            con.Open()
            Dim s As String = "INSERT INTO Ecrypt_Decrypt VALUES('" & txtID.Text & "','" & txtencrypt.Text & "')"
            Dim cmd1 As New SqlCommand(s, con)
            cmd1.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Filee = OpenFileDialog1.FileName
        SafeName = OpenFileDialog1.SafeFileName
        If Not BGWK1.IsBusy Then BGWK1.RunWorkerAsync()

        Dim cmd As New SqlCommand("SELECT * FROM Ecrypt_Decrypt", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        datagridview1.DataSource = table
        dencrypt.datagridview1.DataSource = table

        generate()
    End Sub

    Private Sub Encrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Folder_lockDataSet2.Ecrypt_Decrypt' table. You can move, or remove it, as needed.
        Me.Ecrypt_DecryptTableAdapter.Fill(Me.Folder_lockDataSet2.Ecrypt_Decrypt)
        ProgressBar2.Hide()

        'hides lfile on load....Label prompting as Error
        lfile.Visible = False
        'loads path from database into datagridview 
        Dim cmd As New SqlCommand("SELECT * FROM Ecrypt_Decrypt", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        datagridview1.DataSource = table
        generate()
    End Sub

    Private Sub btnencrypt_MouseHover(sender As Object, e As EventArgs) Handles btnencrypt.MouseHover
        btnencrypt.BackColor = Color.Transparent
        btnencrypt.ForeColor = ColorTranslator.FromHtml(hexcolor)
        btnencrypt.FlatAppearance.BorderSize = 3
        btnencrypt.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml(hexcolor)
    End Sub


    Private Sub btnencrypt_MouseLeave(sender As Object, e As EventArgs) Handles btnencrypt.MouseLeave
        btnencrypt.BackColor = ColorTranslator.FromHtml(hexcolor)
        btnencrypt.ForeColor = Color.White
        btnencrypt.FlatAppearance.BorderSize = 0
        btnencrypt.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
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

    Private Sub btnbrowsefile_Click(sender As Object, e As EventArgs) Handles btnbrowsefile.Click
        lfile.Visible = False

        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Title = "Choose File"
        OpenFileDialog1.Filter = "All Files|*.*"
        txtencrypt.Text = OpenFileDialog1.FileName
    End Sub


    Dim Filee As String, SafeName As String
    Dim LanguageWrite As Boolean = True
    Dim PW As String = "@#$%^&"
    Dim DCfile As String, DcSafeFile As String

    Private Sub BGWK1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWK1.DoWork
        Control.CheckForIllegalCrossThreadCalls = False
        Dim Tmpsrc As String = Convert.ToBase64String(IO.File.ReadAllBytes(Filee))
        ProgressBar1.Maximum = Convert.ToInt32(Tmpsrc.Length)
        Dim Result As String = String.Empty
        For i As Integer = 1 To Tmpsrc.Length
            txtencrypt1.Text = i & "/" & Tmpsrc.Length
            txtencrypt.Text = SafeName
            Result &= ChrW(AscW(GetChar(Tmpsrc, i))) & PW
            Try
                ProgressBar1.Value = Convert.ToInt32(i)
            Catch : End Try
        Next
        MessageBox.Show("File Encryption Successful!!!", "File Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtID.Clear()
        txtencrypt.Clear()
        txtencrypt1.Clear()
        ProgressBar1.Value = 0
        IO.File.WriteAllText(Filee, Result)

        'loads hided file to database for retreiving

    End Sub

    Function generate()
        con.Open()
        Dim num As String = "SELECT COUNT(*) FROM Ecrypt_Decrypt "
        Dim cmd As New SqlCommand(num, con)
        Dim ns As Integer = cmd.ExecuteScalar
        cmd = Nothing
        con.Close()

        txtID.Text = "E-" & ns + 1
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'validates the encrypt button
     If txtencrypt.Text = "" Then
            lfile.Visible = True
            Timer1.Start()
            ProgressBar2.Increment(1)
            If ProgressBar2.Value = 10 Then
                lfile.Visible = False
                ProgressBar2.Value = 100
            End If
            Timer1.Stop()
            Exit Sub
        End If

       
    End Sub
End Class
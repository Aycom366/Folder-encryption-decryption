Imports System.IO
Imports System.Diagnostics.Process
Imports System.Security.AccessControl
Imports System.Data.SqlClient


Public Class Hidefolder
    Dim hexcolor As String = "#0054fe"
    Dim con As New SqlConnection("Data Source=.;Initial Catalog=Folder_lock;Integrated Security=True")

    Private Sub Hidefolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd3 As New SqlCommand("SELECT * FROM Hide_Show", con)
        Dim adapter As New SqlDataAdapter(cmd3)
        Dim table As New DataTable
        adapter.Fill(table)
        filegrid.DataSource = table
        showfolder.filegrid.DataSource = table


        Dim cmd4 As New SqlCommand("SELECT * FROM hide_folder", con)
        Dim adapter1 As New SqlDataAdapter(cmd4)
        Dim table1 As New DataTable
        adapter1.Fill(table1)
        foldergrid.DataSource = table1
        showfolder.foldergrid.DataSource = table1
        'TODO: This line of code loads data into the 'Folder_lockDataSet5.Hide_Show' table. You can move, or remove it, as needed.
        Me.Hide_ShowTableAdapter.Fill(Me.Folder_lockDataSet5.Hide_Show)
        'TODO: This line of code loads data into the 'Folder_lockDataSet4.hide_folder' table. You can move, or remove it, as needed.
        Me.Hide_folderTableAdapter.Fill(Me.Folder_lockDataSet4.hide_folder)
        lfile.Visible = False
        Lfolder.Visible = False
        generate1()
        generate()
    End Sub

    Private Sub btnhide_Click_(sender As Object, e As EventArgs) Handles btnhidefile.Click
        'validates textbiox
        If txthide.Text = "" Then
            lfile.Visible = True
            Exit Sub
        End If

        'checks if files to encry is already encrypted
        Try
            Dim ds As New SqlDataAdapter("SELECT * FROM Hide_Show WHERE  Paths='" & txthide.Text & "'", con)
            Dim dt As New DataTable
            ds.Fill(dt)
            If (dt.Rows.Count > 0) Then
                MessageBox.Show("File as been hidden already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txthide.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'show folder when clicked
        IO.File.SetAttributes(txthide.Text, FileAttributes.Hidden)

        'loads hided file to database for retreiving
        Try
            con.Open()
            Dim s As String = "INSERT INTO Hide_Show VALUES('" & TextBox1.Text & "','" & txthide.Text & "')"
            Dim cmd As New SqlCommand(s, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("File is Hidden", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            txthide.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'loads path from database into datagridview 
        Dim cmd3 As New SqlCommand("SELECT * FROM Hide_Show", con)
        Dim adapter As New SqlDataAdapter(cmd3)
        Dim table As New DataTable
        adapter.Fill(table)
        filegrid.DataSource = table
        showfolder.filegrid.DataSource = table
        generate()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Dispose()
    End Sub

    Private Sub btnbrowse_Click_1(sender As Object, e As EventArgs) Handles btnbrowsefile.Click
        lfile.Visible = False
        OpenFileDialog1.ShowDialog()
        txthide.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnclear_Click_1(sender As Object, e As EventArgs) Handles btnclearfile.Click
        lfile.Visible = False
        txthide.Text = ""
    End Sub

    Private Sub btnhide_MouseHover_1(sender As Object, e As EventArgs) Handles btnhidefile.MouseHover
        btnhidefile.BackColor = Color.Transparent
        btnhidefile.ForeColor = ColorTranslator.FromHtml(hexcolor)
        btnhidefile.FlatAppearance.BorderSize = 3
        btnhidefile.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btnhide_MouseLeave_1(sender As Object, e As EventArgs) Handles btnhidefile.MouseLeave
        btnhidefile.BackColor = ColorTranslator.FromHtml(hexcolor)
        btnhidefile.ForeColor = Color.White
        btnhidefile.FlatAppearance.BorderSize = 0
        btnhidefile.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btnclear_MouseHover_1(sender As Object, e As EventArgs) Handles btnclearfile.MouseHover
        btnclearfile.BackColor = Color.Transparent
        btnclearfile.ForeColor = Color.Maroon
        btnclearfile.FlatAppearance.BorderSize = 3
        btnclearfile.FlatAppearance.BorderColor = Color.Maroon
    End Sub

    Private Sub btnclear_MouseLeave_1(sender As Object, e As EventArgs) Handles btnclearfile.MouseLeave
        btnclearfile.BackColor = Color.Maroon
        btnclearfile.ForeColor = Color.White
        btnclearfile.FlatAppearance.BorderSize = 0
        btnclearfile.FlatAppearance.BorderColor = Color.Maroon
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnbrowsefolder.Click
        Lfolder.Visible = False
        FolderBrowserDialog1.ShowDialog()
        txtfold.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnclearfolder.Click
        Lfolder.Visible = False
        txthide.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnhidefold.Click

        'validates textbiox
        If txtfold.Text = "" Then
            Lfolder.Visible = True
            Exit Sub
        End If

        'checks if files to encry is already encrypted
        Try
            Dim ds As New SqlDataAdapter("SELECT * FROM hide_folder WHERE  Paths='" & txtfold.Text & "'", con)
            Dim dt As New DataTable
            ds.Fill(dt)
            If (dt.Rows.Count > 0) Then
                MessageBox.Show("Folder as been hidden already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtfold.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'show folder when clicked
        IO.File.SetAttributes(txtfold.Text, FileAttributes.Hidden)


        'saves path of hided folder to database for retreiving
        Try
            con.Open()
            Dim s As String = "INSERT INTO hide_folder VALUES('" & TextBox2.Text & "','" & txtfold.Text & "')"
            Dim cmd As New SqlCommand(s, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Folder is Hidden", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            txtfold.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim cmd3 As New SqlCommand("SELECT * FROM hide_folder", con)
        Dim adapter As New SqlDataAdapter(cmd3)
        Dim table1 As New DataTable
        adapter.Fill(table1)
        foldergrid.DataSource = table1
        showfolder.foldergrid.DataSource = table1

        generate1()
    End Sub

    Private Sub btnfold_MouseHover_1(sender As Object, e As EventArgs) Handles btnhidefold.MouseHover
        btnhidefold.BackColor = Color.Transparent
        btnhidefold.ForeColor = ColorTranslator.FromHtml(hexcolor)
        btnhidefold.FlatAppearance.BorderSize = 3
        btnhidefold.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btnfold_MouseLeave_1(sender As Object, e As EventArgs) Handles btnhidefold.MouseLeave
        btnhidefold.BackColor = ColorTranslator.FromHtml(hexcolor)
        btnhidefold.ForeColor = Color.White
        btnhidefold.FlatAppearance.BorderSize = 0
        btnhidefold.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btnclearfolder_MouseHover(sender As Object, e As EventArgs) Handles btnclearfolder.MouseHover
        btnclearfolder.BackColor = Color.Transparent
        btnclearfolder.ForeColor = Color.Maroon
        btnclearfolder.FlatAppearance.BorderSize = 3
        btnclearfolder.FlatAppearance.BorderColor = Color.Maroon


    End Sub

    Private Sub btnclearfolder_MouseLeave(sender As Object, e As EventArgs) Handles btnclearfolder.MouseLeave
        btnclearfolder.BackColor = Color.Maroon
        btnclearfolder.ForeColor = Color.White
        btnclearfolder.FlatAppearance.BorderSize = 0
        btnclearfolder.FlatAppearance.BorderColor = Color.Maroon
    End Sub


    Dim supnum As Integer
    Dim rnd As New Random
    Sub generate()
        con.Open()
        Dim num As String = "SELECT COUNT(*) FROM Hide_Show"
        Dim cmd As New SqlCommand(num, con)
        Dim ns As Integer = cmd.ExecuteScalar
        cmd = Nothing
        con.Close()

        TextBox1.Text = "Hi-" & ns + 1


    End Sub

    Sub generate1()
        con.Open()
        Dim num As String = "SELECT COUNT(*) FROM hide_folder"
        Dim cmd As New SqlCommand(num, con)
        Dim ns As Integer = cmd.ExecuteScalar
        cmd = Nothing
        con.Close()

        TextBox2.Text = "Hi-" & ns + 1
        con.Close()
    End Sub
End Class
Imports System.IO
Imports System.Security.AccessControl
Imports System.Diagnostics.Process
Imports System.Data.SqlClient

Public Class showfolder
    Dim hexcolor As String = "#0054fe"
    Dim con As New SqlConnection("Data Source=.;Initial Catalog=Folder_lock;Integrated Security=True")


    Private Sub btnbrowsefile_Click(sender As Object, e As EventArgs) Handles btnbrowsefile.Click
        lfile.Visible = False
        'browse file from desktop
        OpenFileDialog1.ShowDialog()
        txtshowfile.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnshowfile_Click(sender As Object, e As EventArgs) Handles btnshowfile.Click
        If txtshowfile.Text = "" Then
            lfile.Visible = True
            Exit Sub
        End If

        Try
            Dim ds As New SqlDataAdapter("SELECT * FROM Hide_Show WHERE  ID='" & TextBox2.Text & "'", con)
            Dim dt As New DataTable
            ds.Fill(dt)
            If (dt.Rows.Count <= 0) Then
                MessageBox.Show("Error with the ID selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtshowfile.Clear()
                TextBox2.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try


        'This button hides file when clicked
        IO.File.SetAttributes(txtshowfile.Text, FileAttributes.Normal)


        'deletes path from database
        con.Open()
        Dim s As String = "DELETE FROM Hide_Show WHERE ID = '" & TextBox2.Text & "' "
        Dim cmd As New SqlCommand(s, con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("File visibility is now true", "Operation sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtshowfile.Clear()
        btnbrowsefile.Focus()

        Dim cmd5 As New SqlCommand("SELECT * FROM Hide_Show", con)
        Dim adapter As New SqlDataAdapter(cmd5)
        Dim table As New DataTable
        adapter.Fill(table)
        filegrid.DataSource = table
        Hidefolder.filegrid.DataSource = table
        Hidefolder.generate()


    End Sub

    Private Sub btnclearfile_Click(sender As Object, e As EventArgs) Handles btnclearfile.Click
        txtshowfile.Clear()
        lfile.Visible = False
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Dispose()
    End Sub

    Private Sub btnbrowsefolder_Click(sender As Object, e As EventArgs) Handles btnbrowsefolder.Click
        'selects folder from desktop
        Lfolder.Visible = False
        FolderBrowserDialog1.ShowDialog()
        txtshowfold.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnshowfold_Click(sender As Object, e As EventArgs) Handles btnshowfold.Click
        'THIS VALIDATES FOLDER BEFORE SHOWING FOLDER
        If txtshowfold.Text = "" Then
            Lfolder.Visible = True
            Exit Sub
        End If

        Try
            Dim ds As New SqlDataAdapter("SELECT * FROM hide_folder WHERE  ID='" & TextBox1.Text & "'", con)
            Dim dt As New DataTable
            ds.Fill(dt)
            If (dt.Rows.Count <= 0) Then
                MessageBox.Show("Error with the ID selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Clear()
                txtshowfold.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try


        'This button hides folder when clicked
        IO.File.SetAttributes(txtshowfold.Text, FileAttributes.Normal)

        'delete path from database on showing folder
        con.Open()
        Dim s As String = "DELETE FROM hide_folder WHERE ID = '" & TextBox1.Text & "' "
        Dim cmd As New SqlCommand(s, con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Folder visibility is now true", "Operation sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtshowfold.Clear()
        btnbrowsefolder.Focus()
        con.Close()

        Dim cmd5 As New SqlCommand("SELECT * FROM hide_folder", con)
        Dim adapter As New SqlDataAdapter(cmd5)
        Dim table As New DataTable
        adapter.Fill(table)
        foldergrid.DataSource = table
        Hidefolder.foldergrid.DataSource = table
        Hidefolder.generate1()

    End Sub

    Private Sub showfolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd5 As New SqlCommand("SELECT * FROM hide_folder", con)
        Dim adapter As New SqlDataAdapter(cmd5)
        Dim table As New DataTable
        adapter.Fill(table)
        foldergrid.DataSource = table

        Dim cmd As New SqlCommand("SELECT * FROM Hide_Show", con)
        Dim adapter1 As New SqlDataAdapter(cmd)
        Dim table1 As New DataTable
        adapter1.Fill(table1)
        filegrid.DataSource = table1
        'TODO: This line of code loads data into the 'Folder_lockDataSet7.Hide_Show' table. You can move, or remove it, as needed.
        Me.Hide_ShowTableAdapter.Fill(Me.Folder_lockDataSet7.Hide_Show)
        'TODO: This line of code loads data into the 'Folder_lockDataSet6.hide_folder' table. You can move, or remove it, as needed.
        Me.Hide_folderTableAdapter.Fill(Me.Folder_lockDataSet6.hide_folder)
        Lfolder.Visible = False
        lfile.Visible = False
    End Sub

    Private Sub btnclearfolder_Click(sender As Object, e As EventArgs) Handles btnclearfolder.Click
        Lfolder.Visible = False
        txtshowfold.Clear()
    End Sub

    Private Sub btnshowfile_MouseHover(sender As Object, e As EventArgs) Handles btnshowfile.MouseHover
        btnshowfile.BackColor = Color.Transparent
        btnshowfile.ForeColor = ColorTranslator.FromHtml(hexcolor)
        btnshowfile.FlatAppearance.BorderSize = 3
        btnshowfile.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btnshowfile_MouseLeave(sender As Object, e As EventArgs) Handles btnshowfile.MouseLeave
        btnshowfile.BackColor = ColorTranslator.FromHtml(hexcolor)
        btnshowfile.ForeColor = Color.White
        btnshowfile.FlatAppearance.BorderSize = 0
        btnshowfile.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
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

    Private Sub btnshowfold_MouseHover(sender As Object, e As EventArgs) Handles btnshowfold.MouseHover
        btnshowfold.BackColor = Color.Transparent
        btnshowfold.ForeColor = ColorTranslator.FromHtml(hexcolor)
        btnshowfold.FlatAppearance.BorderSize = 3
        btnshowfold.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btnshowfold_MouseLeave(sender As Object, e As EventArgs) Handles btnshowfold.MouseLeave
        btnshowfold.BackColor = ColorTranslator.FromHtml(hexcolor)
        btnshowfold.ForeColor = Color.White
        btnshowfold.FlatAppearance.BorderSize = 0
        btnshowfold.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        con.Open()
        Dim s As String = "SELECT * FROM Hide_Show WHERE ID ='" & TextBox2.Text & "' "
        Dim cmd As New SqlCommand(s, con)
        Dim dt As SqlDataReader = cmd.ExecuteReader
        While dt.Read
            txtshowfile.Text = dt(1).ToString
        End While
        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        con.Open()
        Dim ss As String = "SELECT * FROM hide_folder WHERE ID ='" & TextBox1.Text & "' "
        Dim cmd2 As New SqlCommand(ss, con)
        Dim dt As SqlDataReader = cmd2.ExecuteReader
        While dt.Read
            txtshowfold.Text = dt(1).ToString
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

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        If TextBox1.Text = "ID here" Then
            TextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text = "ID here" Then
            TextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.Text = "" Then
            TextBox1.Text = "ID here"
        End If
    End Sub
End Class
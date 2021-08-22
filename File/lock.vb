
Imports System.Drawing.Color
Imports System.Security.AccessControl
'Imports System.Diagnostics.Process
Imports System.Data.SqlClient
Imports System.IO
Public Class lock
    Dim hexcolor As String = "#0054fe"
    Dim con As New SqlConnection("Data Source=.;Initial Catalog=Folder_lock;Integrated Security=True")
    'Public status As String
    'Public arr As String() = New String(5) {}

    'Private Function getstatus(ByVal stat As String) As String
    '    For i As Integer = 0 To 5
    '        If stat.LastIndexOf(arr(i)) <> -1 Then
    '            stat = stat.Substring(stat.LastIndexOf("."))
    '        End If
    '    Next i
    '    Return stat
    'End Function

    Private Sub lock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Folder_lockDataSet.Path' table. You can move, or remove it, as needed.
        Me.PathTableAdapter.Fill(Me.Folder_lockDataSet.Path)
        generate()
        'status = ""
        'arr(0) = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        'arr(1) = ".{21EC2020-3AEA-1069-AZDD-08002B30309D}"
        'arr(2) = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}"
        'arr(3) = ".{6455FF040-5081-1018-9F08-00AA002F954E}"
        'arr(4) = ".{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}"
        'arr(5) = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}"


        ''popluates datagrid
        'Dim cmd3 As New SqlCommand("SELECT * FROM Path", con)
        'Dim adapter As New SqlDataAdapter(cmd3)
        'Dim table As New DataTable
        'adapter.Fill(table)
        'datagridview1.DataSource = table
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        lberror.Text = ""
        FolderBrowserDialog1.ShowDialog()
        txtlock.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnlock_Click(sender As Object, e As EventArgs) Handles btnlock.Click
        'validate textbox
        If txtlock.Text = "" Then
            lberror.Text = "PLEASE SELECT FOLDER TO LOCK.."
            btnbrowse.Focus()
            Exit Sub
        End If

        'checks if files to encry is already encrypted
        Try
            Dim ds As New SqlDataAdapter("SELECT * FROM Path WHERE  Paths ='" & txtlock.Text & "'", con)
            Dim dt As New DataTable
            ds.Fill(dt)
            If (dt.Rows.Count > 0) Then
                MessageBox.Show("Folder is locked already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtlock.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'the cold locking the folder
        Try
            Dim fs As FileSystemSecurity = IO.File.GetAccessControl(txtlock.Text)
            fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            IO.File.SetAccessControl(txtlock.Text, fs)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'saves locked folder path to database
        Try
            con.Open()
            Dim ss As String = "INSERT INTO Path VALUES('" & txtrandom.Text & "', '" & txtlock.Text & "')"
            Dim cmd1 As New SqlCommand(ss, con)
            cmd1.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Folder Locked", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtlock.Text = ""
            txtrandom.Clear()

            Dim cmd5 As New SqlCommand("SELECT * FROM Path", con)
            Dim adapter As New SqlDataAdapter(cmd5)
            Dim table As New DataTable
            adapter.Fill(table)
            datagridview1.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        generate()

        'status = arr(0)
        'If Not txtlock.Text = "" Then
        '    Dim d As DirectoryInfo = New DirectoryInfo(txtlock.Text)
        '    Dim selectedpath As String = d.Parent.FullName + d.Name

        '    ProgressBar1.Value = 0
        '    If FolderBrowserDialog1.SelectedPath.LastIndexOf(".") = -1 Then
        '        If (Not d.Root.Equals(d.Parent.FullName)) Then
        '            d.MoveTo(d.Parent.FullName & "\" & d.Name & status)
        '        Else
        '            d.MoveTo(d.Parent.FullName + d.Name & status)
        '        End If
        '        txtlock.Text = FolderBrowserDialog1.SelectedPath
        '        ProgressBar1.Value = 100
        '        MessageBox.Show("Folder locked")
        '        ProgressBar1.Value = 0

        '    Else
        '        Try
        '            status = getstatus(status)
        '            d.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))
        '            txtlock.Text = FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf("."))
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message)
        '        End Try
        '    End If
        'End If


    End Sub

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

    Private Sub btnclear_MouseHover(sender As Object, e As EventArgs) Handles btnclear.MouseHover
        btnclear.BackColor = Color.Transparent
        btnclear.ForeColor = Color.Maroon
        btnclear.FlatAppearance.BorderSize = 3
        btnclear.FlatAppearance.BorderColor = Maroon
    End Sub

    Private Sub btnclear_MouseLeave(sender As Object, e As EventArgs) Handles btnclear.MouseLeave
        btnclear.BackColor = Color.Maroon
        btnclear.ForeColor = Color.White
        btnclear.FlatAppearance.BorderSize = 0
        btnclear.FlatAppearance.BorderColor = Maroon
    End Sub

    Private Sub btnlock_MouseHover(sender As Object, e As EventArgs) Handles btnlock.MouseHover
        btnlock.BackColor = Color.Transparent
        btnlock.ForeColor = ColorTranslator.FromHtml(hexcolor)
        btnlock.FlatAppearance.BorderSize = 3
        btnlock.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btnlock_MouseLeave(sender As Object, e As EventArgs) Handles btnlock.MouseLeave
        btnlock.BackColor = ColorTranslator.FromHtml(hexcolor)
        btnlock.ForeColor = Color.White
        btnlock.FlatAppearance.BorderSize = 0
        btnlock.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtlock.Clear()
        txtrandom.Clear()
        lberror.Text = ""
    End Sub
    Dim supnum As Integer
    Dim rnd As New Random
    Function generate()
        con.Open()
        Dim num As String = "SELECT COUNT(*) FROM Path"
        Dim cmd As New SqlCommand(num, con)
        Dim ns As Integer = cmd.ExecuteScalar
        cmd = Nothing
        con.Close()

        txtrandom.Text = "L-" & ns + 1


        'con.Open()
        'Dim snum As String = "SELECT  ID("")* FROM Path ORDER BY ID"
        'Dim cmd9 As New SqlCommand(snum, con)
        'Dim dtr As SqlDataReader = cmd9.ExecuteReader
        'While dtr.Read
        '    txtrandom.Text = dtr(0).ToString
        'End While
        'con.Close()

    End Function


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
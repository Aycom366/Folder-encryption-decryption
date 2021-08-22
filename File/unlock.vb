Imports System.IO
Imports System.Drawing.Color
Imports System.Security.AccessControl
Imports System.Diagnostics.Process
Imports System.Data.SqlClient
Public Class unlock
    Dim hexcolor As String = "#0054fe"
    'connection string to database
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

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        'enables selection of folder from the computer
        Label2.Text = ""
        FolderBrowserDialog1.ShowDialog()
        txtlock.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        'takes us back to the dashboard
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
        btnclear.FlatAppearance.BorderColor = Color.Maroon
    End Sub

    Private Sub btnclear_MouseLeave(sender As Object, e As EventArgs) Handles btnclear.MouseLeave
        btnclear.BackColor = Color.Maroon
        btnclear.ForeColor = Color.White
        btnclear.FlatAppearance.BorderSize = 0
        btnclear.FlatAppearance.BorderColor = Color.Maroon
    End Sub

    Private Sub btnlock_MouseHover(sender As Object, e As EventArgs) Handles btnunlock.MouseHover
        btnunlock.BackColor = Color.Transparent
        btnunlock.ForeColor = ColorTranslator.FromHtml(hexcolor)
        btnunlock.FlatAppearance.BorderSize = 3
        btnunlock.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub

    Private Sub btnlock_MouseLeave(sender As Object, e As EventArgs) Handles btnunlock.MouseLeave
        btnunlock.BackColor = ColorTranslator.FromHtml(hexcolor)
        btnunlock.ForeColor = Color.White
        btnunlock.FlatAppearance.BorderSize = 0
        btnunlock.FlatAppearance.BorderColor = ColorTranslator.FromHtml(hexcolor)
    End Sub


    Private Sub btnunlock_Click(sender As Object, e As EventArgs) Handles btnunlock.Click
        'validates textbox
        If txtlock.Text = "" Then
            Label2.Text = "PLEASE BROWSE FOLDER TO UNLOCK"
            Exit Sub
        End If

        Try
            Dim ds As New SqlDataAdapter("SELECT * FROM Path WHERE  ID='" & txtID.Text & "'", con)
            Dim dt As New DataTable
            ds.Fill(dt)
            If (dt.Rows.Count <= 0) Then
                MessageBox.Show("Error with the ID selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtID.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'unlocks folder
        Try
            Dim fs As FileSystemSecurity = IO.File.GetAccessControl(txtlock.Text)
            fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            IO.File.SetAccessControl(txtlock.Text, fs)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'deletes unlocked form database
        Try
            If txtID.Text = "" Then
                Label2.Show()
                Label2.Text = "Please select ID for folder"
                Exit Sub
            End If
            con.Open()
            Dim sss As String = "DELETE FROM Path WHERE ID = '" & txtID.Text & "'"
            Dim cmd As New SqlCommand(sss, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Folder Unlocked", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtlock.Text = ""
            txtID.Clear()
            'loads data into datagrid
            Dim cmd5 As New SqlCommand("SELECT * FROM Path", con)
            Dim adapter As New SqlDataAdapter(cmd5)
            Dim table As New DataTable
            adapter.Fill(table)
            datagridview1.DataSource = table
            lock.datagridview1.DataSource = table
            lock.generate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    '    'unlocks folder start
    '    status = arr(1)
    '    If Not txtlock.Text = "" Then
    '        Dim d As DirectoryInfo = New DirectoryInfo(txtlock.Text)
    '        Dim selectedpath As String = d.Parent.FullName + d.Name

    '        ProgressBar1.Value = 0
    '        If FolderBrowserDialog1.SelectedPath.LastIndexOf(".") = -1 Then
    '            If (Not d.Root.Equals(d.Parent.FullName)) Then
    '                d.MoveTo(d.Parent.FullName & "\" & d.Name & status)
    '            Else
    '                d.MoveTo(d.Parent.FullName + d.Name & status)
    '            End If
    '            txtlock.Text = FolderBrowserDialog1.SelectedPath
    '            ProgressBar1.Value = 100
    '        Else
    '            status = getstatus(status)
    '            d.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))
    '            txtlock.Text = FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf("."))
    '            MessageBox.Show("folder is unlocked")
    '            txtlock.Clear()
    '        End If
    '    End If
    'End Sub

    Private Sub unlock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Folder_lockDataSet1.Path' table. You can move, or remove it, as needed.
        Me.PathTableAdapter.Fill(Me.Folder_lockDataSet1.Path)
        'loads data from database on loads into datagriedveiw
        Dim cmd5 As New SqlCommand("SELECT * FROM Path", con)
        Dim adapter As New SqlDataAdapter(cmd5)
        Dim table As New DataTable
        adapter.Fill(table)
        datagridview1.DataSource = table
        lock.datagridview1.DataSource = table


        'status = ""
        'arr(0) = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        'arr(1) = ".{21EC2020-3AEA-1069-AZDD-08002B30309D}"
        'arr(2) = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}"
        'arr(3) = ".{6455FF040-5081-1018-9F08-00AA002F954E}"
        'arr(4) = ".{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}"
        'arr(5) = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}"
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        'clears textbox and set label2 to nothing
        txtlock.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        'select ID of file from database and loads into the avalaible textboxes
        con.Open()
        Dim s As String = "SELECT * FROM Path WHERE ID ='" & txtID.Text & "' "
        Dim cmd As New SqlCommand(s, con)
        Dim dt As SqlDataReader = cmd.ExecuteReader
        While dt.Read
            txtlock.Text = dt(1).ToString
        End While
        con.Close()
    End Sub

    Private Sub txtID_MouseEnter(sender As Object, e As EventArgs) Handles txtID.MouseEnter
        If txtID.Text = "ID here" Then
            txtID.Text = ""
        End If
    End Sub

    Private Sub txtID_MouseLeave(sender As Object, e As EventArgs) Handles txtID.MouseLeave
        If txtID.Text = "ID here" Then
            txtID.Text = ""
        End If
        If txtID.Text = "" Then
            txtID.Text = "ID here"
        End If
    End Sub

    Private Sub txtID_MouseClick(sender As Object, e As MouseEventArgs) Handles txtID.MouseClick
        If txtID.Text = "ID here" Then
            txtID.Text = ""
        End If
    End Sub

    Private Sub txtID_MouseHover(sender As Object, e As EventArgs) Handles txtID.MouseHover
        If txtID.Text = "ID here" Then
            txtID.Text = ""
        End If
    End Sub
End Class
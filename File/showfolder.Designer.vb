<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class showfolder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(showfolder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbchiding = New System.Windows.Forms.TabControl()
        Me.tbpfile = New System.Windows.Forms.TabPage()
        Me.filegrid = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HideShowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Folder_lockDataSet7 = New File.Folder_lockDataSet7()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lfile = New System.Windows.Forms.Label()
        Me.btnclearfile = New System.Windows.Forms.Button()
        Me.btnshowfile = New System.Windows.Forms.Button()
        Me.btnbrowsefile = New System.Windows.Forms.Button()
        Me.txtshowfile = New System.Windows.Forms.TextBox()
        Me.tbpfolder = New System.Windows.Forms.TabPage()
        Me.foldergrid = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HidefolderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Folder_lockDataSet6 = New File.Folder_lockDataSet6()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lfolder = New System.Windows.Forms.Label()
        Me.btnclearfolder = New System.Windows.Forms.Button()
        Me.btnshowfold = New System.Windows.Forms.Button()
        Me.btnbrowsefolder = New System.Windows.Forms.Button()
        Me.txtshowfold = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Hide_folderTableAdapter = New File.Folder_lockDataSet6TableAdapters.hide_folderTableAdapter()
        Me.Hide_ShowTableAdapter = New File.Folder_lockDataSet7TableAdapters.Hide_ShowTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.tbchiding.SuspendLayout()
        Me.tbpfile.SuspendLayout()
        CType(Me.filegrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HideShowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Folder_lockDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpfolder.SuspendLayout()
        CType(Me.foldergrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HidefolderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Folder_lockDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnback)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1009, 72)
        Me.Panel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(395, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Show Module"
        '
        'btnback
        '
        Me.btnback.AnimationHoverSpeed = 0.07!
        Me.btnback.AnimationSpeed = 0.03!
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.BaseColor = System.Drawing.SystemColors.Highlight
        Me.btnback.BorderColor = System.Drawing.Color.Black
        Me.btnback.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnback.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnback.CheckedForeColor = System.Drawing.Color.White
        Me.btnback.CheckedImage = CType(resources.GetObject("btnback.CheckedImage"), System.Drawing.Image)
        Me.btnback.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnback.FocusedColor = System.Drawing.Color.Empty
        Me.btnback.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Image = Nothing
        Me.btnback.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnback.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnback.Location = New System.Drawing.Point(944, 11)
        Me.btnback.Name = "btnback"
        Me.btnback.OnHoverBaseColor = System.Drawing.Color.SteelBlue
        Me.btnback.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnback.OnHoverForeColor = System.Drawing.Color.White
        Me.btnback.OnHoverImage = Nothing
        Me.btnback.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnback.OnPressedColor = System.Drawing.Color.Black
        Me.btnback.Radius = 10
        Me.btnback.Size = New System.Drawing.Size(53, 42)
        Me.btnback.TabIndex = 3
        Me.btnback.Text = "X"
        Me.btnback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 44)
        Me.Panel1.TabIndex = 3
        '
        'tbchiding
        '
        Me.tbchiding.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbchiding.Controls.Add(Me.tbpfile)
        Me.tbchiding.Controls.Add(Me.tbpfolder)
        Me.tbchiding.Location = New System.Drawing.Point(135, 140)
        Me.tbchiding.Name = "tbchiding"
        Me.tbchiding.SelectedIndex = 0
        Me.tbchiding.ShowToolTips = True
        Me.tbchiding.Size = New System.Drawing.Size(739, 570)
        Me.tbchiding.TabIndex = 21
        '
        'tbpfile
        '
        Me.tbpfile.Controls.Add(Me.filegrid)
        Me.tbpfile.Controls.Add(Me.Label3)
        Me.tbpfile.Controls.Add(Me.TextBox2)
        Me.tbpfile.Controls.Add(Me.lfile)
        Me.tbpfile.Controls.Add(Me.btnclearfile)
        Me.tbpfile.Controls.Add(Me.btnshowfile)
        Me.tbpfile.Controls.Add(Me.btnbrowsefile)
        Me.tbpfile.Controls.Add(Me.txtshowfile)
        Me.tbpfile.Location = New System.Drawing.Point(4, 28)
        Me.tbpfile.Name = "tbpfile"
        Me.tbpfile.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpfile.Size = New System.Drawing.Size(731, 538)
        Me.tbpfile.TabIndex = 0
        Me.tbpfile.Text = "File"
        Me.tbpfile.ToolTipText = "A Page for hiding"
        '
        'filegrid
        '
        Me.filegrid.AllowUserToAddRows = False
        Me.filegrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        Me.filegrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.filegrid.AutoGenerateColumns = False
        Me.filegrid.BackgroundColor = System.Drawing.Color.White
        Me.filegrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.filegrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.filegrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.filegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.filegrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.PathsDataGridViewTextBoxColumn1})
        Me.filegrid.DataSource = Me.HideShowBindingSource
        Me.filegrid.Location = New System.Drawing.Point(50, 270)
        Me.filegrid.Name = "filegrid"
        Me.filegrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Empty
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.filegrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.filegrid.RowTemplate.Height = 24
        Me.filegrid.Size = New System.Drawing.Size(631, 222)
        Me.filegrid.TabIndex = 33
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PathsDataGridViewTextBoxColumn1
        '
        Me.PathsDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PathsDataGridViewTextBoxColumn1.DataPropertyName = "paths"
        Me.PathsDataGridViewTextBoxColumn1.HeaderText = "paths"
        Me.PathsDataGridViewTextBoxColumn1.Name = "PathsDataGridViewTextBoxColumn1"
        Me.PathsDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'HideShowBindingSource
        '
        Me.HideShowBindingSource.DataMember = "Hide_Show"
        Me.HideShowBindingSource.DataSource = Me.Folder_lockDataSet7
        '
        'Folder_lockDataSet7
        '
        Me.Folder_lockDataSet7.DataSetName = "Folder_lockDataSet7"
        Me.Folder_lockDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(26, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "ID:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(63, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 28)
        Me.TextBox2.TabIndex = 31
        Me.TextBox2.Text = "ID here"
        '
        'lfile
        '
        Me.lfile.AutoSize = True
        Me.lfile.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lfile.ForeColor = System.Drawing.Color.Maroon
        Me.lfile.Location = New System.Drawing.Point(154, 24)
        Me.lfile.Name = "lfile"
        Me.lfile.Size = New System.Drawing.Size(379, 24)
        Me.lfile.TabIndex = 24
        Me.lfile.Text = "PLEASE BROWSE FOR FILE TO SHOW"
        '
        'btnclearfile
        '
        Me.btnclearfile.BackColor = System.Drawing.Color.Maroon
        Me.btnclearfile.FlatAppearance.BorderSize = 0
        Me.btnclearfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnclearfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnclearfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclearfile.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclearfile.ForeColor = System.Drawing.Color.White
        Me.btnclearfile.Image = CType(resources.GetObject("btnclearfile.Image"), System.Drawing.Image)
        Me.btnclearfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclearfile.Location = New System.Drawing.Point(368, 168)
        Me.btnclearfile.Name = "btnclearfile"
        Me.btnclearfile.Size = New System.Drawing.Size(160, 55)
        Me.btnclearfile.TabIndex = 23
        Me.btnclearfile.Text = "Clear"
        Me.btnclearfile.UseVisualStyleBackColor = False
        '
        'btnshowfile
        '
        Me.btnshowfile.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnshowfile.FlatAppearance.BorderSize = 0
        Me.btnshowfile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnshowfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnshowfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnshowfile.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshowfile.ForeColor = System.Drawing.Color.White
        Me.btnshowfile.Image = CType(resources.GetObject("btnshowfile.Image"), System.Drawing.Image)
        Me.btnshowfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnshowfile.Location = New System.Drawing.Point(202, 168)
        Me.btnshowfile.Name = "btnshowfile"
        Me.btnshowfile.Size = New System.Drawing.Size(160, 55)
        Me.btnshowfile.TabIndex = 22
        Me.btnshowfile.Text = "Show File"
        Me.btnshowfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnshowfile.UseVisualStyleBackColor = False
        '
        'btnbrowsefile
        '
        Me.btnbrowsefile.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnbrowsefile.FlatAppearance.BorderSize = 0
        Me.btnbrowsefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowsefile.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowsefile.ForeColor = System.Drawing.Color.White
        Me.btnbrowsefile.Image = CType(resources.GetObject("btnbrowsefile.Image"), System.Drawing.Image)
        Me.btnbrowsefile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbrowsefile.Location = New System.Drawing.Point(560, 104)
        Me.btnbrowsefile.Name = "btnbrowsefile"
        Me.btnbrowsefile.Size = New System.Drawing.Size(136, 44)
        Me.btnbrowsefile.TabIndex = 21
        Me.btnbrowsefile.Text = "Browse"
        Me.btnbrowsefile.UseVisualStyleBackColor = False
        '
        'txtshowfile
        '
        Me.txtshowfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshowfile.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtshowfile.Location = New System.Drawing.Point(30, 111)
        Me.txtshowfile.Name = "txtshowfile"
        Me.txtshowfile.ReadOnly = True
        Me.txtshowfile.Size = New System.Drawing.Size(524, 30)
        Me.txtshowfile.TabIndex = 20
        '
        'tbpfolder
        '
        Me.tbpfolder.Controls.Add(Me.foldergrid)
        Me.tbpfolder.Controls.Add(Me.Label2)
        Me.tbpfolder.Controls.Add(Me.TextBox1)
        Me.tbpfolder.Controls.Add(Me.Lfolder)
        Me.tbpfolder.Controls.Add(Me.btnclearfolder)
        Me.tbpfolder.Controls.Add(Me.btnshowfold)
        Me.tbpfolder.Controls.Add(Me.btnbrowsefolder)
        Me.tbpfolder.Controls.Add(Me.txtshowfold)
        Me.tbpfolder.Location = New System.Drawing.Point(4, 28)
        Me.tbpfolder.Name = "tbpfolder"
        Me.tbpfolder.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpfolder.Size = New System.Drawing.Size(731, 538)
        Me.tbpfolder.TabIndex = 1
        Me.tbpfolder.Text = "Folder"
        Me.tbpfolder.ToolTipText = "A page meant for hiding folders"
        '
        'foldergrid
        '
        Me.foldergrid.AllowUserToAddRows = False
        Me.foldergrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        Me.foldergrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.foldergrid.AutoGenerateColumns = False
        Me.foldergrid.BackgroundColor = System.Drawing.Color.White
        Me.foldergrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.foldergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.foldergrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PathsDataGridViewTextBoxColumn})
        Me.foldergrid.DataSource = Me.HidefolderBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.foldergrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.foldergrid.Location = New System.Drawing.Point(50, 274)
        Me.foldergrid.Name = "foldergrid"
        Me.foldergrid.ReadOnly = True
        Me.foldergrid.RowTemplate.Height = 24
        Me.foldergrid.Size = New System.Drawing.Size(631, 222)
        Me.foldergrid.TabIndex = 35
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PathsDataGridViewTextBoxColumn
        '
        Me.PathsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PathsDataGridViewTextBoxColumn.DataPropertyName = "paths"
        Me.PathsDataGridViewTextBoxColumn.HeaderText = "paths"
        Me.PathsDataGridViewTextBoxColumn.Name = "PathsDataGridViewTextBoxColumn"
        Me.PathsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HidefolderBindingSource
        '
        Me.HidefolderBindingSource.DataMember = "hide_folder"
        Me.HidefolderBindingSource.DataSource = Me.Folder_lockDataSet6
        '
        'Folder_lockDataSet6
        '
        Me.Folder_lockDataSet6.DataSetName = "Folder_lockDataSet6"
        Me.Folder_lockDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(26, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(63, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 28)
        Me.TextBox1.TabIndex = 33
        Me.TextBox1.Text = "ID here"
        '
        'Lfolder
        '
        Me.Lfolder.AutoSize = True
        Me.Lfolder.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lfolder.ForeColor = System.Drawing.Color.Maroon
        Me.Lfolder.Location = New System.Drawing.Point(154, 24)
        Me.Lfolder.Name = "Lfolder"
        Me.Lfolder.Size = New System.Drawing.Size(420, 24)
        Me.Lfolder.TabIndex = 28
        Me.Lfolder.Text = "PLEASE BROWSE FOR FOLDER TO SHOW"
        '
        'btnclearfolder
        '
        Me.btnclearfolder.BackColor = System.Drawing.Color.Maroon
        Me.btnclearfolder.FlatAppearance.BorderSize = 0
        Me.btnclearfolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnclearfolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnclearfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclearfolder.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclearfolder.ForeColor = System.Drawing.Color.White
        Me.btnclearfolder.Image = CType(resources.GetObject("btnclearfolder.Image"), System.Drawing.Image)
        Me.btnclearfolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclearfolder.Location = New System.Drawing.Point(368, 168)
        Me.btnclearfolder.Name = "btnclearfolder"
        Me.btnclearfolder.Size = New System.Drawing.Size(160, 55)
        Me.btnclearfolder.TabIndex = 27
        Me.btnclearfolder.Text = "Clear"
        Me.btnclearfolder.UseVisualStyleBackColor = False
        '
        'btnshowfold
        '
        Me.btnshowfold.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnshowfold.FlatAppearance.BorderSize = 0
        Me.btnshowfold.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnshowfold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnshowfold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnshowfold.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshowfold.ForeColor = System.Drawing.Color.White
        Me.btnshowfold.Image = CType(resources.GetObject("btnshowfold.Image"), System.Drawing.Image)
        Me.btnshowfold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnshowfold.Location = New System.Drawing.Point(202, 168)
        Me.btnshowfold.Name = "btnshowfold"
        Me.btnshowfold.Size = New System.Drawing.Size(160, 55)
        Me.btnshowfold.TabIndex = 26
        Me.btnshowfold.Text = "Show Folder"
        Me.btnshowfold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnshowfold.UseVisualStyleBackColor = False
        '
        'btnbrowsefolder
        '
        Me.btnbrowsefolder.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnbrowsefolder.FlatAppearance.BorderSize = 0
        Me.btnbrowsefolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowsefolder.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowsefolder.ForeColor = System.Drawing.Color.White
        Me.btnbrowsefolder.Image = CType(resources.GetObject("btnbrowsefolder.Image"), System.Drawing.Image)
        Me.btnbrowsefolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbrowsefolder.Location = New System.Drawing.Point(560, 104)
        Me.btnbrowsefolder.Name = "btnbrowsefolder"
        Me.btnbrowsefolder.Size = New System.Drawing.Size(136, 44)
        Me.btnbrowsefolder.TabIndex = 25
        Me.btnbrowsefolder.Text = "Browse"
        Me.btnbrowsefolder.UseVisualStyleBackColor = False
        '
        'txtshowfold
        '
        Me.txtshowfold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshowfold.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtshowfold.Location = New System.Drawing.Point(30, 111)
        Me.txtshowfold.Name = "txtshowfold"
        Me.txtshowfold.ReadOnly = True
        Me.txtshowfold.Size = New System.Drawing.Size(524, 30)
        Me.txtshowfold.TabIndex = 24
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Hide_folderTableAdapter
        '
        Me.Hide_folderTableAdapter.ClearBeforeFill = True
        '
        'Hide_ShowTableAdapter
        '
        Me.Hide_ShowTableAdapter.ClearBeforeFill = True
        '
        'showfolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 722)
        Me.Controls.Add(Me.tbchiding)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "showfolder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "show"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tbchiding.ResumeLayout(False)
        Me.tbpfile.ResumeLayout(False)
        Me.tbpfile.PerformLayout()
        CType(Me.filegrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HideShowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Folder_lockDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpfolder.ResumeLayout(False)
        Me.tbpfolder.PerformLayout()
        CType(Me.foldergrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HidefolderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Folder_lockDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tbchiding As System.Windows.Forms.TabControl
    Friend WithEvents tbpfile As System.Windows.Forms.TabPage
    Friend WithEvents lfile As System.Windows.Forms.Label
    Friend WithEvents btnclearfile As System.Windows.Forms.Button
    Friend WithEvents btnshowfile As System.Windows.Forms.Button
    Friend WithEvents btnbrowsefile As System.Windows.Forms.Button
    Friend WithEvents txtshowfile As System.Windows.Forms.TextBox
    Friend WithEvents tbpfolder As System.Windows.Forms.TabPage
    Friend WithEvents Lfolder As System.Windows.Forms.Label
    Friend WithEvents btnclearfolder As System.Windows.Forms.Button
    Friend WithEvents btnshowfold As System.Windows.Forms.Button
    Friend WithEvents btnbrowsefolder As System.Windows.Forms.Button
    Friend WithEvents txtshowfold As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents filegrid As System.Windows.Forms.DataGridView
    Friend WithEvents foldergrid As System.Windows.Forms.DataGridView
    Friend WithEvents Folder_lockDataSet6 As File.Folder_lockDataSet6
    Friend WithEvents HidefolderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Hide_folderTableAdapter As File.Folder_lockDataSet6TableAdapters.hide_folderTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Folder_lockDataSet7 As File.Folder_lockDataSet7
    Friend WithEvents HideShowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Hide_ShowTableAdapter As File.Folder_lockDataSet7TableAdapters.Hide_ShowTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathsDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

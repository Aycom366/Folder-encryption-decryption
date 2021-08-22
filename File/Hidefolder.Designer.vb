<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hidefolder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hidefolder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.tbchiding = New System.Windows.Forms.TabControl()
        Me.tbpfile = New System.Windows.Forms.TabPage()
        Me.filegrid = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HideShowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Folder_lockDataSet5 = New File.Folder_lockDataSet5()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lfile = New System.Windows.Forms.Label()
        Me.btnclearfile = New System.Windows.Forms.Button()
        Me.btnhidefile = New System.Windows.Forms.Button()
        Me.btnbrowsefile = New System.Windows.Forms.Button()
        Me.txthide = New System.Windows.Forms.TextBox()
        Me.tbpfolder = New System.Windows.Forms.TabPage()
        Me.foldergrid = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HidefolderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Folder_lockDataSet4 = New File.Folder_lockDataSet4()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Lfolder = New System.Windows.Forms.Label()
        Me.btnclearfolder = New System.Windows.Forms.Button()
        Me.btnhidefold = New System.Windows.Forms.Button()
        Me.btnbrowsefolder = New System.Windows.Forms.Button()
        Me.txtfold = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Hide_folderTableAdapter = New File.Folder_lockDataSet4TableAdapters.hide_folderTableAdapter()
        Me.Hide_ShowTableAdapter = New File.Folder_lockDataSet5TableAdapters.Hide_ShowTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.tbchiding.SuspendLayout()
        Me.tbpfile.SuspendLayout()
        CType(Me.filegrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HideShowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Folder_lockDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpfolder.SuspendLayout()
        CType(Me.foldergrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HidefolderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Folder_lockDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(400, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hide Module"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.tbchiding.Size = New System.Drawing.Size(739, 533)
        Me.tbchiding.TabIndex = 20
        '
        'tbpfile
        '
        Me.tbpfile.Controls.Add(Me.filegrid)
        Me.tbpfile.Controls.Add(Me.Label2)
        Me.tbpfile.Controls.Add(Me.TextBox1)
        Me.tbpfile.Controls.Add(Me.lfile)
        Me.tbpfile.Controls.Add(Me.btnclearfile)
        Me.tbpfile.Controls.Add(Me.btnhidefile)
        Me.tbpfile.Controls.Add(Me.btnbrowsefile)
        Me.tbpfile.Controls.Add(Me.txthide)
        Me.tbpfile.Location = New System.Drawing.Point(4, 28)
        Me.tbpfile.Name = "tbpfile"
        Me.tbpfile.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpfile.Size = New System.Drawing.Size(731, 501)
        Me.tbpfile.TabIndex = 0
        Me.tbpfile.Text = "File"
        Me.tbpfile.ToolTipText = "A Page for hiding"
        '
        'filegrid
        '
        Me.filegrid.AllowUserToAddRows = False
        Me.filegrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        Me.filegrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.filegrid.AutoGenerateColumns = False
        Me.filegrid.BackgroundColor = System.Drawing.Color.White
        Me.filegrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Empty
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.filegrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.filegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.filegrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.PathsDataGridViewTextBoxColumn1})
        Me.filegrid.DataSource = Me.HideShowBindingSource
        Me.filegrid.Location = New System.Drawing.Point(50, 249)
        Me.filegrid.Name = "filegrid"
        Me.filegrid.ReadOnly = True
        Me.filegrid.RowTemplate.Height = 24
        Me.filegrid.Size = New System.Drawing.Size(631, 222)
        Me.filegrid.TabIndex = 35
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
        Me.HideShowBindingSource.DataSource = Me.Folder_lockDataSet5
        '
        'Folder_lockDataSet5
        '
        Me.Folder_lockDataSet5.DataSetName = "Folder_lockDataSet5"
        Me.Folder_lockDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(26, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(63, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(156, 28)
        Me.TextBox1.TabIndex = 25
        '
        'lfile
        '
        Me.lfile.AutoSize = True
        Me.lfile.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lfile.ForeColor = System.Drawing.Color.Maroon
        Me.lfile.Location = New System.Drawing.Point(136, 24)
        Me.lfile.Name = "lfile"
        Me.lfile.Size = New System.Drawing.Size(362, 24)
        Me.lfile.TabIndex = 24
        Me.lfile.Text = "PLEASE BROWSE THE FILE TO HIDE"
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
        Me.btnclearfile.Location = New System.Drawing.Point(362, 166)
        Me.btnclearfile.Name = "btnclearfile"
        Me.btnclearfile.Size = New System.Drawing.Size(154, 55)
        Me.btnclearfile.TabIndex = 23
        Me.btnclearfile.Text = "Clear"
        Me.btnclearfile.UseVisualStyleBackColor = False
        '
        'btnhidefile
        '
        Me.btnhidefile.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnhidefile.FlatAppearance.BorderSize = 0
        Me.btnhidefile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnhidefile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnhidefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhidefile.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhidefile.ForeColor = System.Drawing.Color.White
        Me.btnhidefile.Image = CType(resources.GetObject("btnhidefile.Image"), System.Drawing.Image)
        Me.btnhidefile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhidefile.Location = New System.Drawing.Point(202, 166)
        Me.btnhidefile.Name = "btnhidefile"
        Me.btnhidefile.Size = New System.Drawing.Size(154, 55)
        Me.btnhidefile.TabIndex = 22
        Me.btnhidefile.Text = "Hide File"
        Me.btnhidefile.UseVisualStyleBackColor = False
        '
        'btnbrowsefile
        '
        Me.btnbrowsefile.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnbrowsefile.FlatAppearance.BorderSize = 0
        Me.btnbrowsefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowsefile.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowsefile.ForeColor = System.Drawing.Color.White
        Me.btnbrowsefile.Image = CType(resources.GetObject("btnbrowsefile.Image"), System.Drawing.Image)
        Me.btnbrowsefile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbrowsefile.Location = New System.Drawing.Point(560, 103)
        Me.btnbrowsefile.Name = "btnbrowsefile"
        Me.btnbrowsefile.Size = New System.Drawing.Size(128, 44)
        Me.btnbrowsefile.TabIndex = 21
        Me.btnbrowsefile.Text = "Browse"
        Me.btnbrowsefile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbrowsefile.UseVisualStyleBackColor = False
        '
        'txthide
        '
        Me.txthide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthide.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txthide.Location = New System.Drawing.Point(30, 110)
        Me.txthide.Name = "txthide"
        Me.txthide.ReadOnly = True
        Me.txthide.Size = New System.Drawing.Size(524, 30)
        Me.txthide.TabIndex = 20
        '
        'tbpfolder
        '
        Me.tbpfolder.Controls.Add(Me.foldergrid)
        Me.tbpfolder.Controls.Add(Me.Label3)
        Me.tbpfolder.Controls.Add(Me.TextBox2)
        Me.tbpfolder.Controls.Add(Me.Lfolder)
        Me.tbpfolder.Controls.Add(Me.btnclearfolder)
        Me.tbpfolder.Controls.Add(Me.btnhidefold)
        Me.tbpfolder.Controls.Add(Me.btnbrowsefolder)
        Me.tbpfolder.Controls.Add(Me.txtfold)
        Me.tbpfolder.Location = New System.Drawing.Point(4, 28)
        Me.tbpfolder.Name = "tbpfolder"
        Me.tbpfolder.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpfolder.Size = New System.Drawing.Size(731, 501)
        Me.tbpfolder.TabIndex = 1
        Me.tbpfolder.Text = "Folder"
        Me.tbpfolder.ToolTipText = "A page meant for hiding folders"
        '
        'foldergrid
        '
        Me.foldergrid.AllowUserToAddRows = False
        Me.foldergrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        Me.foldergrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.foldergrid.AutoGenerateColumns = False
        Me.foldergrid.BackgroundColor = System.Drawing.Color.White
        Me.foldergrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.foldergrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.foldergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.foldergrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PathsDataGridViewTextBoxColumn})
        Me.foldergrid.DataSource = Me.HidefolderBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.foldergrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.foldergrid.Location = New System.Drawing.Point(50, 249)
        Me.foldergrid.Name = "foldergrid"
        Me.foldergrid.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.foldergrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.foldergrid.RowTemplate.Height = 24
        Me.foldergrid.Size = New System.Drawing.Size(631, 222)
        Me.foldergrid.TabIndex = 34
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
        Me.HidefolderBindingSource.DataSource = Me.Folder_lockDataSet4
        '
        'Folder_lockDataSet4
        '
        Me.Folder_lockDataSet4.DataSetName = "Folder_lockDataSet4"
        Me.Folder_lockDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(26, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "ID:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(63, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(156, 28)
        Me.TextBox2.TabIndex = 29
        '
        'Lfolder
        '
        Me.Lfolder.AutoSize = True
        Me.Lfolder.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lfolder.ForeColor = System.Drawing.Color.Maroon
        Me.Lfolder.Location = New System.Drawing.Point(136, 24)
        Me.Lfolder.Name = "Lfolder"
        Me.Lfolder.Size = New System.Drawing.Size(403, 24)
        Me.Lfolder.TabIndex = 28
        Me.Lfolder.Text = "PLEASE BROWSE THE FOLDER TO HIDE"
        '
        'btnclearfolder
        '
        Me.btnclearfolder.BackColor = System.Drawing.Color.Maroon
        Me.btnclearfolder.FlatAppearance.BorderSize = 0
        Me.btnclearfolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnclearfolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnclearfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclearfolder.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclearfolder.ForeColor = System.Drawing.Color.White
        Me.btnclearfolder.Image = CType(resources.GetObject("btnclearfolder.Image"), System.Drawing.Image)
        Me.btnclearfolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclearfolder.Location = New System.Drawing.Point(362, 166)
        Me.btnclearfolder.Name = "btnclearfolder"
        Me.btnclearfolder.Size = New System.Drawing.Size(154, 55)
        Me.btnclearfolder.TabIndex = 27
        Me.btnclearfolder.Text = "Clear"
        Me.btnclearfolder.UseVisualStyleBackColor = False
        '
        'btnhidefold
        '
        Me.btnhidefold.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnhidefold.FlatAppearance.BorderSize = 0
        Me.btnhidefold.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnhidefold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnhidefold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhidefold.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhidefold.ForeColor = System.Drawing.Color.White
        Me.btnhidefold.Image = CType(resources.GetObject("btnhidefold.Image"), System.Drawing.Image)
        Me.btnhidefold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhidefold.Location = New System.Drawing.Point(200, 166)
        Me.btnhidefold.Name = "btnhidefold"
        Me.btnhidefold.Size = New System.Drawing.Size(156, 55)
        Me.btnhidefold.TabIndex = 26
        Me.btnhidefold.Text = "Hide Folder"
        Me.btnhidefold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhidefold.UseVisualStyleBackColor = False
        '
        'btnbrowsefolder
        '
        Me.btnbrowsefolder.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnbrowsefolder.FlatAppearance.BorderSize = 0
        Me.btnbrowsefolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowsefolder.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowsefolder.ForeColor = System.Drawing.Color.White
        Me.btnbrowsefolder.Image = CType(resources.GetObject("btnbrowsefolder.Image"), System.Drawing.Image)
        Me.btnbrowsefolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbrowsefolder.Location = New System.Drawing.Point(560, 103)
        Me.btnbrowsefolder.Name = "btnbrowsefolder"
        Me.btnbrowsefolder.Size = New System.Drawing.Size(128, 44)
        Me.btnbrowsefolder.TabIndex = 25
        Me.btnbrowsefolder.Text = "Browse"
        Me.btnbrowsefolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbrowsefolder.UseVisualStyleBackColor = False
        '
        'txtfold
        '
        Me.txtfold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfold.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtfold.Location = New System.Drawing.Point(30, 110)
        Me.txtfold.Name = "txtfold"
        Me.txtfold.ReadOnly = True
        Me.txtfold.Size = New System.Drawing.Size(524, 30)
        Me.txtfold.TabIndex = 24
        '
        'Hide_folderTableAdapter
        '
        Me.Hide_folderTableAdapter.ClearBeforeFill = True
        '
        'Hide_ShowTableAdapter
        '
        Me.Hide_ShowTableAdapter.ClearBeforeFill = True
        '
        'Hidefolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 705)
        Me.Controls.Add(Me.tbchiding)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Hidefolder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hide"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tbchiding.ResumeLayout(False)
        Me.tbpfile.ResumeLayout(False)
        Me.tbpfile.PerformLayout()
        CType(Me.filegrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HideShowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Folder_lockDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpfolder.ResumeLayout(False)
        Me.tbpfolder.PerformLayout()
        CType(Me.foldergrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HidefolderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Folder_lockDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tbchiding As System.Windows.Forms.TabControl
    Friend WithEvents tbpfile As System.Windows.Forms.TabPage
    Friend WithEvents btnclearfile As System.Windows.Forms.Button
    Friend WithEvents btnhidefile As System.Windows.Forms.Button
    Friend WithEvents btnbrowsefile As System.Windows.Forms.Button
    Friend WithEvents txthide As System.Windows.Forms.TextBox
    Friend WithEvents tbpfolder As System.Windows.Forms.TabPage
    Friend WithEvents btnclearfolder As System.Windows.Forms.Button
    Friend WithEvents btnhidefold As System.Windows.Forms.Button
    Friend WithEvents btnbrowsefolder As System.Windows.Forms.Button
    Friend WithEvents txtfold As System.Windows.Forms.TextBox
    Friend WithEvents lfile As System.Windows.Forms.Label
    Friend WithEvents Lfolder As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents foldergrid As System.Windows.Forms.DataGridView
    Friend WithEvents filegrid As System.Windows.Forms.DataGridView
    Friend WithEvents Folder_lockDataSet4 As File.Folder_lockDataSet4
    Friend WithEvents HidefolderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Hide_folderTableAdapter As File.Folder_lockDataSet4TableAdapters.hide_folderTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Folder_lockDataSet5 As File.Folder_lockDataSet5
    Friend WithEvents HideShowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Hide_ShowTableAdapter As File.Folder_lockDataSet5TableAdapters.Hide_ShowTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathsDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

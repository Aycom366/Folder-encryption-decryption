<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class unlock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(unlock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnunlock = New System.Windows.Forms.Button()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.txtlock = New System.Windows.Forms.TextBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Folder_lockDataSet = New File.Folder_lockDataSet()
        Me.FolderlockDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Folder_lockDataSet1 = New File.Folder_lockDataSet1()
        Me.PathBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PathTableAdapter = New File.Folder_lockDataSet1TableAdapters.PathTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Folder_lockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FolderlockDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Folder_lockDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PathBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(345, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unlock Folder Module"
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
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(189, 333)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(631, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'btnunlock
        '
        Me.btnunlock.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnunlock.FlatAppearance.BorderSize = 0
        Me.btnunlock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnunlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnunlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnunlock.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnunlock.ForeColor = System.Drawing.Color.White
        Me.btnunlock.Image = CType(resources.GetObject("btnunlock.Image"), System.Drawing.Image)
        Me.btnunlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnunlock.Location = New System.Drawing.Point(315, 248)
        Me.btnunlock.Name = "btnunlock"
        Me.btnunlock.Size = New System.Drawing.Size(186, 55)
        Me.btnunlock.TabIndex = 12
        Me.btnunlock.Text = "Unlock"
        Me.btnunlock.UseVisualStyleBackColor = False
        '
        'btnbrowse
        '
        Me.btnbrowse.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnbrowse.FlatAppearance.BorderSize = 0
        Me.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowse.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Image = CType(resources.GetObject("btnbrowse.Image"), System.Drawing.Image)
        Me.btnbrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbrowse.Location = New System.Drawing.Point(762, 171)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(164, 44)
        Me.btnbrowse.TabIndex = 11
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = False
        '
        'txtlock
        '
        Me.txtlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlock.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtlock.Location = New System.Drawing.Point(232, 178)
        Me.txtlock.Name = "txtlock"
        Me.txtlock.ReadOnly = True
        Me.txtlock.Size = New System.Drawing.Size(524, 30)
        Me.txtlock.TabIndex = 10
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Maroon
        Me.btnclear.FlatAppearance.BorderSize = 0
        Me.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(507, 248)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(186, 55)
        Me.btnclear.TabIndex = 14
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(366, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(82, 178)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(144, 27)
        Me.txtID.TabIndex = 16
        Me.txtID.Text = "ID here"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PathsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PathBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(189, 375)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(631, 222)
        Me.DataGridView1.TabIndex = 35
        '
        'Folder_lockDataSet
        '
        Me.Folder_lockDataSet.DataSetName = "Folder_lockDataSet"
        Me.Folder_lockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FolderlockDataSetBindingSource
        '
        Me.FolderlockDataSetBindingSource.DataSource = Me.Folder_lockDataSet
        Me.FolderlockDataSetBindingSource.Position = 0
        '
        'Folder_lockDataSet1
        '
        Me.Folder_lockDataSet1.DataSetName = "Folder_lockDataSet1"
        Me.Folder_lockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PathBindingSource
        '
        Me.PathBindingSource.DataMember = "Path"
        Me.PathBindingSource.DataSource = Me.Folder_lockDataSet1
        '
        'PathTableAdapter
        '
        Me.PathTableAdapter.ClearBeforeFill = True
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
        'unlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 722)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnunlock)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.txtlock)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "unlock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "unlock"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Folder_lockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FolderlockDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Folder_lockDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PathBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnunlock As System.Windows.Forms.Button
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents txtlock As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FolderlockDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Folder_lockDataSet As File.Folder_lockDataSet
    Friend WithEvents Folder_lockDataSet1 As File.Folder_lockDataSet1
    Friend WithEvents PathBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PathTableAdapter As File.Folder_lockDataSet1TableAdapters.PathTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

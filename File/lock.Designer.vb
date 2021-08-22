<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtlock = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.btnlock = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lberror = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.txtrandom = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Folder_lockDataSet = New File.Folder_lockDataSet()
        Me.PathTableAdapter = New File.Folder_lockDataSetTableAdapters.PathTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PathBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Folder_lockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 44)
        Me.Panel1.TabIndex = 1
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
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(345, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lock Folder Module"
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
        'txtlock
        '
        Me.txtlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlock.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtlock.Location = New System.Drawing.Point(232, 178)
        Me.txtlock.Name = "txtlock"
        Me.txtlock.ReadOnly = True
        Me.txtlock.Size = New System.Drawing.Size(524, 30)
        Me.txtlock.TabIndex = 4
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
        Me.btnbrowse.TabIndex = 6
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = False
        '
        'btnlock
        '
        Me.btnlock.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnlock.FlatAppearance.BorderSize = 0
        Me.btnlock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlock.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlock.ForeColor = System.Drawing.Color.White
        Me.btnlock.Image = CType(resources.GetObject("btnlock.Image"), System.Drawing.Image)
        Me.btnlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlock.Location = New System.Drawing.Point(315, 248)
        Me.btnlock.Name = "btnlock"
        Me.btnlock.Size = New System.Drawing.Size(186, 55)
        Me.btnlock.TabIndex = 7
        Me.btnlock.Text = "Lock"
        Me.btnlock.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(189, 333)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(631, 23)
        Me.ProgressBar1.TabIndex = 8
        '
        'lberror
        '
        Me.lberror.AutoSize = True
        Me.lberror.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lberror.ForeColor = System.Drawing.Color.Red
        Me.lberror.Location = New System.Drawing.Point(370, 134)
        Me.lberror.Name = "lberror"
        Me.lberror.Size = New System.Drawing.Size(0, 25)
        Me.lberror.TabIndex = 9
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
        Me.btnclear.TabIndex = 10
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'txtrandom
        '
        Me.txtrandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrandom.Location = New System.Drawing.Point(82, 178)
        Me.txtrandom.Name = "txtrandom"
        Me.txtrandom.ReadOnly = True
        Me.txtrandom.Size = New System.Drawing.Size(144, 27)
        Me.txtrandom.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
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
        'PathBindingSource
        '
        Me.PathBindingSource.DataMember = "Path"
        Me.PathBindingSource.DataSource = Me.Folder_lockDataSet
        '
        'Folder_lockDataSet
        '
        Me.Folder_lockDataSet.DataSetName = "Folder_lockDataSet"
        Me.Folder_lockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PathTableAdapter
        '
        Me.PathTableAdapter.ClearBeforeFill = True
        '
        'lock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 722)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtrandom)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.lberror)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnlock)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.txtlock)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "lock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lock"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PathBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Folder_lockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlock As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents btnlock As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lberror As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents txtrandom As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Folder_lockDataSet As File.Folder_lockDataSet
    Friend WithEvents PathBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PathTableAdapter As File.Folder_lockDataSetTableAdapters.PathTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dencrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dencrypt))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnback = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtdecrypt1 = New System.Windows.Forms.TextBox()
        Me.lfile = New System.Windows.Forms.Label()
        Me.btnclearfile = New System.Windows.Forms.Button()
        Me.btndencrypt = New System.Windows.Forms.Button()
        Me.btnbrowsefile = New System.Windows.Forms.Button()
        Me.txtdencrypt = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BGWK2 = New System.ComponentModel.BackgroundWorker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EcryptDecryptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Folder_lockDataSet3 = New File.Folder_lockDataSet3()
        Me.Ecrypt_DecryptTableAdapter = New File.Folder_lockDataSet3TableAdapters.Ecrypt_DecryptTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EcryptDecryptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Folder_lockDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(326, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "File Decrypting Module"
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
        Me.ProgressBar1.Location = New System.Drawing.Point(315, 393)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(378, 23)
        Me.ProgressBar1.TabIndex = 38
        '
        'txtdecrypt1
        '
        Me.txtdecrypt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdecrypt1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtdecrypt1.Location = New System.Drawing.Point(608, 235)
        Me.txtdecrypt1.Name = "txtdecrypt1"
        Me.txtdecrypt1.ReadOnly = True
        Me.txtdecrypt1.Size = New System.Drawing.Size(149, 30)
        Me.txtdecrypt1.TabIndex = 37
        '
        'lfile
        '
        Me.lfile.AutoSize = True
        Me.lfile.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lfile.ForeColor = System.Drawing.Color.Maroon
        Me.lfile.Location = New System.Drawing.Point(278, 141)
        Me.lfile.Name = "lfile"
        Me.lfile.Size = New System.Drawing.Size(388, 29)
        Me.lfile.TabIndex = 36
        Me.lfile.Text = "PLEASE BROWSE FILE TO DECRYPT"
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
        Me.btnclearfile.Location = New System.Drawing.Point(507, 304)
        Me.btnclearfile.Name = "btnclearfile"
        Me.btnclearfile.Size = New System.Drawing.Size(186, 55)
        Me.btnclearfile.TabIndex = 35
        Me.btnclearfile.Text = "Clear"
        Me.btnclearfile.UseVisualStyleBackColor = False
        '
        'btndencrypt
        '
        Me.btndencrypt.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btndencrypt.FlatAppearance.BorderSize = 0
        Me.btndencrypt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btndencrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btndencrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndencrypt.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndencrypt.ForeColor = System.Drawing.Color.White
        Me.btndencrypt.Image = CType(resources.GetObject("btndencrypt.Image"), System.Drawing.Image)
        Me.btndencrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndencrypt.Location = New System.Drawing.Point(315, 304)
        Me.btndencrypt.Name = "btndencrypt"
        Me.btndencrypt.Size = New System.Drawing.Size(186, 55)
        Me.btndencrypt.TabIndex = 34
        Me.btndencrypt.Text = "Decrypt File"
        Me.btndencrypt.UseVisualStyleBackColor = False
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
        Me.btnbrowsefile.Location = New System.Drawing.Point(779, 227)
        Me.btnbrowsefile.Name = "btnbrowsefile"
        Me.btnbrowsefile.Size = New System.Drawing.Size(164, 44)
        Me.btnbrowsefile.TabIndex = 33
        Me.btnbrowsefile.Text = "Browse"
        Me.btnbrowsefile.UseVisualStyleBackColor = False
        '
        'txtdencrypt
        '
        Me.txtdencrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdencrypt.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtdencrypt.Location = New System.Drawing.Point(65, 235)
        Me.txtdencrypt.Name = "txtdencrypt"
        Me.txtdencrypt.ReadOnly = True
        Me.txtdencrypt.Size = New System.Drawing.Size(524, 30)
        Me.txtdencrypt.TabIndex = 32
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BGWK2
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(63, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "ID:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(100, 191)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 28)
        Me.TextBox2.TabIndex = 40
        Me.TextBox2.Text = "ID here"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Maiandra GD", 10.2!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Empty
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PathsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EcryptDecryptBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(189, 441)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(631, 222)
        Me.DataGridView1.TabIndex = 42
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
        'EcryptDecryptBindingSource
        '
        Me.EcryptDecryptBindingSource.DataMember = "Ecrypt_Decrypt"
        Me.EcryptDecryptBindingSource.DataSource = Me.Folder_lockDataSet3
        '
        'Folder_lockDataSet3
        '
        Me.Folder_lockDataSet3.DataSetName = "Folder_lockDataSet3"
        Me.Folder_lockDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ecrypt_DecryptTableAdapter
        '
        Me.Ecrypt_DecryptTableAdapter.ClearBeforeFill = True
        '
        'dencrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 722)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtdecrypt1)
        Me.Controls.Add(Me.lfile)
        Me.Controls.Add(Me.btnclearfile)
        Me.Controls.Add(Me.btndencrypt)
        Me.Controls.Add(Me.btnbrowsefile)
        Me.Controls.Add(Me.txtdencrypt)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dencrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dencrypt"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EcryptDecryptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Folder_lockDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnback As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtdecrypt1 As System.Windows.Forms.TextBox
    Friend WithEvents lfile As System.Windows.Forms.Label
    Friend WithEvents btnclearfile As System.Windows.Forms.Button
    Friend WithEvents btndencrypt As System.Windows.Forms.Button
    Friend WithEvents btnbrowsefile As System.Windows.Forms.Button
    Friend WithEvents txtdencrypt As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BGWK2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Folder_lockDataSet3 As File.Folder_lockDataSet3
    Friend WithEvents EcryptDecryptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ecrypt_DecryptTableAdapter As File.Folder_lockDataSet3TableAdapters.Ecrypt_DecryptTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

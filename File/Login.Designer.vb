<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 100)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(179, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Application Login Page"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnexit)
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.GunaPictureBox1)
        Me.Panel2.Controls.Add(Me.txtpass)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 360)
        Me.Panel2.TabIndex = 2
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(156, 303)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(133, 20)
        Me.LinkLabel2.TabIndex = 24
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forgot Password"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(27, 303)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(106, 20)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create Access"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(38, 127)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(38, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Maroon
        Me.btnexit.FlatAppearance.BorderSize = 0
        Me.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Image = CType(resources.GetObject("btnexit.Image"), System.Drawing.Image)
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexit.Location = New System.Drawing.Point(212, 192)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(128, 47)
        Me.btnexit.TabIndex = 20
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.White
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(78, 192)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(128, 47)
        Me.btnsave.TabIndex = 19
        Me.btnsave.Text = "Login"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(338, 133)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(380, 37)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(259, 218)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 17
        Me.GunaPictureBox1.TabStop = False
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(62, 127)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(297, 28)
        Me.txtpass.TabIndex = 14
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(62, 64)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(297, 28)
        Me.txtusername.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(58, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(58, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "UserName:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(666, 460)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
End Class

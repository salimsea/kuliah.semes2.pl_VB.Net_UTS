<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeminjamBuku
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_level = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_pinjam = New System.Windows.Forms.Button()
        Me.txt_nama_peminjam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_nama_buku = New System.Windows.Forms.ComboBox()
        Me.dt_tgl_pinjam = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dt_tgl_kembali = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 50)
        Me.Panel1.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PEMINJAMAN BUKU"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication3.My.Resources.Resources.undraw_Co_workers_re_1i6i
        Me.PictureBox1.Location = New System.Drawing.Point(357, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(431, 323)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'txt_level
        '
        Me.txt_level.Enabled = False
        Me.txt_level.Location = New System.Drawing.Point(31, 147)
        Me.txt_level.Name = "txt_level"
        Me.txt_level.ReadOnly = True
        Me.txt_level.ShortcutsEnabled = False
        Me.txt_level.Size = New System.Drawing.Size(277, 20)
        Me.txt_level.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Jabatan"
        '
        'btn_pinjam
        '
        Me.btn_pinjam.Location = New System.Drawing.Point(24, 388)
        Me.btn_pinjam.Name = "btn_pinjam"
        Me.btn_pinjam.Size = New System.Drawing.Size(284, 30)
        Me.btn_pinjam.TabIndex = 21
        Me.btn_pinjam.Text = "Simpan Peminjaman Buku"
        Me.btn_pinjam.UseVisualStyleBackColor = True
        '
        'txt_nama_peminjam
        '
        Me.txt_nama_peminjam.Location = New System.Drawing.Point(31, 228)
        Me.txt_nama_peminjam.Name = "txt_nama_peminjam"
        Me.txt_nama_peminjam.Size = New System.Drawing.Size(277, 20)
        Me.txt_nama_peminjam.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama Peminjam"
        '
        'txt_username
        '
        Me.txt_username.Enabled = False
        Me.txt_username.Location = New System.Drawing.Point(31, 92)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.ReadOnly = True
        Me.txt_username.Size = New System.Drawing.Size(277, 20)
        Me.txt_username.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Username"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Location = New System.Drawing.Point(28, 189)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 2)
        Me.Panel2.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Nama Buku"
        '
        'cmb_nama_buku
        '
        Me.cmb_nama_buku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nama_buku.Location = New System.Drawing.Point(31, 284)
        Me.cmb_nama_buku.Name = "cmb_nama_buku"
        Me.cmb_nama_buku.Size = New System.Drawing.Size(277, 21)
        Me.cmb_nama_buku.TabIndex = 29
        '
        'dt_tgl_pinjam
        '
        Me.dt_tgl_pinjam.Location = New System.Drawing.Point(31, 341)
        Me.dt_tgl_pinjam.Name = "dt_tgl_pinjam"
        Me.dt_tgl_pinjam.Size = New System.Drawing.Size(115, 20)
        Me.dt_tgl_pinjam.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Tanggal Pinjam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(190, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Tanggal Kembalikan"
        '
        'dt_tgl_kembali
        '
        Me.dt_tgl_kembali.Location = New System.Drawing.Point(193, 341)
        Me.dt_tgl_kembali.Name = "dt_tgl_kembali"
        Me.dt_tgl_kembali.Size = New System.Drawing.Size(115, 20)
        Me.dt_tgl_kembali.TabIndex = 32
        '
        'PeminjamBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dt_tgl_kembali)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dt_tgl_pinjam)
        Me.Controls.Add(Me.cmb_nama_buku)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_level)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_pinjam)
        Me.Controls.Add(Me.txt_nama_peminjam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PeminjamBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PeminjamBuku"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_level As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_pinjam As Button
    Friend WithEvents txt_nama_peminjam As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_nama_buku As ComboBox
    Friend WithEvents dt_tgl_pinjam As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dt_tgl_kembali As DateTimePicker
End Class

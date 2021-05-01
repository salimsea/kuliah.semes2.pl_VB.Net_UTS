<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarBukuTamu
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
        Me.btn_buku_tamu = New System.Windows.Forms.Button()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 50)
        Me.Panel1.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BUKU TAMU"
        '
        'btn_buku_tamu
        '
        Me.btn_buku_tamu.Location = New System.Drawing.Point(20, 316)
        Me.btn_buku_tamu.Name = "btn_buku_tamu"
        Me.btn_buku_tamu.Size = New System.Drawing.Size(284, 30)
        Me.btn_buku_tamu.TabIndex = 18
        Me.btn_buku_tamu.Text = "Isi Buku Tamu"
        Me.btn_buku_tamu.UseVisualStyleBackColor = True
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(24, 141)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(280, 47)
        Me.txt_alamat.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Alamat"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(24, 89)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(280, 20)
        Me.txt_nama.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nama"
        '
        'txt_tanggal
        '
        Me.txt_tanggal.Enabled = False
        Me.txt_tanggal.Location = New System.Drawing.Point(24, 223)
        Me.txt_tanggal.MinDate = New Date(2021, 4, 20, 0, 0, 0, 0)
        Me.txt_tanggal.Name = "txt_tanggal"
        Me.txt_tanggal.Size = New System.Drawing.Size(280, 20)
        Me.txt_tanggal.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Tanggal"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication3.My.Resources.Resources.undraw_Wall_post_re_y78d
        Me.PictureBox1.Location = New System.Drawing.Point(342, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 257)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'DaftarBukuTamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(769, 374)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_tanggal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_buku_tamu)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DaftarBukuTamu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DaftarBukuTamu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_buku_tamu As Button
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_tanggal As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

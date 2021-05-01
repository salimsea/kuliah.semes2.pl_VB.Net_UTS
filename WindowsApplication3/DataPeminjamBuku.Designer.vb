<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataPeminjamBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_pencarian = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_kd_peminjam = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dg_data_peminjam = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama_peminjam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_tgl_pinjam = New System.Windows.Forms.DateTimePicker()
        Me.dt_tgl_kembali = New System.Windows.Forms.DateTimePicker()
        Me.cmb_nama_buku = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_data_peminjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Location = New System.Drawing.Point(529, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 255)
        Me.Panel2.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1174, 50)
        Me.Panel1.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "DATA PEMINJAMAN BUKU"
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Location = New System.Drawing.Point(633, 77)
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(208, 20)
        Me.txt_pencarian.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(544, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Nama Peminjam"
        '
        'txt_kd_peminjam
        '
        Me.txt_kd_peminjam.Location = New System.Drawing.Point(124, 77)
        Me.txt_kd_peminjam.Name = "txt_kd_peminjam"
        Me.txt_kd_peminjam.Size = New System.Drawing.Size(384, 20)
        Me.txt_kd_peminjam.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Kode"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(98, 282)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(65, 30)
        Me.btn_cancel.TabIndex = 37
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(454, 282)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(65, 30)
        Me.btn_delete.TabIndex = 36
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(383, 282)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(65, 30)
        Me.btn_update.TabIndex = 35
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(312, 282)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(65, 30)
        Me.btn_insert.TabIndex = 34
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(19, 282)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(65, 30)
        Me.btn_add.TabIndex = 33
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'dg_data_peminjam
        '
        Me.dg_data_peminjam.AllowUserToAddRows = False
        Me.dg_data_peminjam.AllowUserToDeleteRows = False
        Me.dg_data_peminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_data_peminjam.Location = New System.Drawing.Point(541, 108)
        Me.dg_data_peminjam.Name = "dg_data_peminjam"
        Me.dg_data_peminjam.ReadOnly = True
        Me.dg_data_peminjam.Size = New System.Drawing.Size(588, 204)
        Me.dg_data_peminjam.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Tanggal Kembali"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Tanggal Pinjam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nama Buku"
        '
        'txt_nama_peminjam
        '
        Me.txt_nama_peminjam.Location = New System.Drawing.Point(124, 108)
        Me.txt_nama_peminjam.Name = "txt_nama_peminjam"
        Me.txt_nama_peminjam.Size = New System.Drawing.Size(384, 20)
        Me.txt_nama_peminjam.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nama Peminjam"
        '
        'dt_tgl_pinjam
        '
        Me.dt_tgl_pinjam.Location = New System.Drawing.Point(124, 173)
        Me.dt_tgl_pinjam.Name = "dt_tgl_pinjam"
        Me.dt_tgl_pinjam.Size = New System.Drawing.Size(384, 20)
        Me.dt_tgl_pinjam.TabIndex = 44
        '
        'dt_tgl_kembali
        '
        Me.dt_tgl_kembali.Location = New System.Drawing.Point(124, 206)
        Me.dt_tgl_kembali.Name = "dt_tgl_kembali"
        Me.dt_tgl_kembali.Size = New System.Drawing.Size(384, 20)
        Me.dt_tgl_kembali.TabIndex = 45
        '
        'cmb_nama_buku
        '
        Me.cmb_nama_buku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nama_buku.FormattingEnabled = True
        Me.cmb_nama_buku.Location = New System.Drawing.Point(124, 139)
        Me.cmb_nama_buku.Name = "cmb_nama_buku"
        Me.cmb_nama_buku.Size = New System.Drawing.Size(384, 21)
        Me.cmb_nama_buku.TabIndex = 46
        '
        'DataPeminjamBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 350)
        Me.Controls.Add(Me.cmb_nama_buku)
        Me.Controls.Add(Me.dt_tgl_kembali)
        Me.Controls.Add(Me.dt_tgl_pinjam)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_pencarian)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_kd_peminjam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dg_data_peminjam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nama_peminjam)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DataPeminjamBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataPeminjamBuku"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_data_peminjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_pencarian As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_kd_peminjam As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents dg_data_peminjam As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama_peminjam As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dt_tgl_pinjam As DateTimePicker
    Friend WithEvents dt_tgl_kembali As DateTimePicker
    Friend WithEvents cmb_nama_buku As ComboBox
End Class

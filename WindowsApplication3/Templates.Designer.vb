<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Templates
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnu_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_file_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_file_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_file_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_anggota = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_anggota_pb = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_anggota_peminjam_buku = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_anggota_buku_tamu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_petugas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_petugas_buku = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_petugas_data_peminjam = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_petugas_data_anggota = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_kepala = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_kepala_lap_data_buku = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_kepala_lap_peminjam = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_umum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_umum_pb = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_umum_daftar_anggota = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_umum_buku_tamu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_file, Me.mnu_anggota, Me.mnu_petugas, Me.mnu_kepala, Me.mnu_umum})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnu_file
        '
        Me.mnu_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_file_login, Me.mnu_file_logout, Me.mnu_file_exit})
        Me.mnu_file.Name = "mnu_file"
        Me.mnu_file.Size = New System.Drawing.Size(37, 20)
        Me.mnu_file.Text = "File"
        '
        'mnu_file_login
        '
        Me.mnu_file_login.Name = "mnu_file_login"
        Me.mnu_file_login.Size = New System.Drawing.Size(112, 22)
        Me.mnu_file_login.Text = "Login"
        '
        'mnu_file_logout
        '
        Me.mnu_file_logout.Name = "mnu_file_logout"
        Me.mnu_file_logout.Size = New System.Drawing.Size(112, 22)
        Me.mnu_file_logout.Text = "Logout"
        '
        'mnu_file_exit
        '
        Me.mnu_file_exit.Name = "mnu_file_exit"
        Me.mnu_file_exit.Size = New System.Drawing.Size(112, 22)
        Me.mnu_file_exit.Text = "Exit"
        '
        'mnu_anggota
        '
        Me.mnu_anggota.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_anggota_pb, Me.mnu_anggota_peminjam_buku, Me.mnu_anggota_buku_tamu})
        Me.mnu_anggota.Name = "mnu_anggota"
        Me.mnu_anggota.Size = New System.Drawing.Size(65, 20)
        Me.mnu_anggota.Text = "Anggota"
        '
        'mnu_anggota_pb
        '
        Me.mnu_anggota_pb.Name = "mnu_anggota_pb"
        Me.mnu_anggota_pb.Size = New System.Drawing.Size(171, 22)
        Me.mnu_anggota_pb.Text = "Pencarian Buku"
        '
        'mnu_anggota_peminjam_buku
        '
        Me.mnu_anggota_peminjam_buku.Name = "mnu_anggota_peminjam_buku"
        Me.mnu_anggota_peminjam_buku.Size = New System.Drawing.Size(171, 22)
        Me.mnu_anggota_peminjam_buku.Text = "Peminjaman Buku"
        '
        'mnu_anggota_buku_tamu
        '
        Me.mnu_anggota_buku_tamu.Name = "mnu_anggota_buku_tamu"
        Me.mnu_anggota_buku_tamu.Size = New System.Drawing.Size(171, 22)
        Me.mnu_anggota_buku_tamu.Text = "Buku Tamu"
        '
        'mnu_petugas
        '
        Me.mnu_petugas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_petugas_buku, Me.mnu_petugas_data_peminjam, Me.mnu_petugas_data_anggota})
        Me.mnu_petugas.Name = "mnu_petugas"
        Me.mnu_petugas.Size = New System.Drawing.Size(61, 20)
        Me.mnu_petugas.Text = "Petugas"
        '
        'mnu_petugas_buku
        '
        Me.mnu_petugas_buku.Name = "mnu_petugas_buku"
        Me.mnu_petugas_buku.Size = New System.Drawing.Size(180, 22)
        Me.mnu_petugas_buku.Text = "Data Buku"
        '
        'mnu_petugas_data_peminjam
        '
        Me.mnu_petugas_data_peminjam.Name = "mnu_petugas_data_peminjam"
        Me.mnu_petugas_data_peminjam.Size = New System.Drawing.Size(180, 22)
        Me.mnu_petugas_data_peminjam.Text = "Data Peminjaman"
        '
        'mnu_petugas_data_anggota
        '
        Me.mnu_petugas_data_anggota.Name = "mnu_petugas_data_anggota"
        Me.mnu_petugas_data_anggota.Size = New System.Drawing.Size(180, 22)
        Me.mnu_petugas_data_anggota.Text = "Data Anggota"
        '
        'mnu_kepala
        '
        Me.mnu_kepala.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_kepala_lap_data_buku, Me.mnu_kepala_lap_peminjam})
        Me.mnu_kepala.Name = "mnu_kepala"
        Me.mnu_kepala.Size = New System.Drawing.Size(54, 20)
        Me.mnu_kepala.Text = "Kepala"
        '
        'mnu_kepala_lap_data_buku
        '
        Me.mnu_kepala_lap_data_buku.Name = "mnu_kepala_lap_data_buku"
        Me.mnu_kepala_lap_data_buku.Size = New System.Drawing.Size(187, 22)
        Me.mnu_kepala_lap_data_buku.Text = "Laporan Data Buku"
        '
        'mnu_kepala_lap_peminjam
        '
        Me.mnu_kepala_lap_peminjam.Name = "mnu_kepala_lap_peminjam"
        Me.mnu_kepala_lap_peminjam.Size = New System.Drawing.Size(187, 22)
        Me.mnu_kepala_lap_peminjam.Text = "Laporan Peminjaman"
        '
        'mnu_umum
        '
        Me.mnu_umum.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_umum_pb, Me.mnu_umum_daftar_anggota, Me.mnu_umum_buku_tamu})
        Me.mnu_umum.Name = "mnu_umum"
        Me.mnu_umum.Size = New System.Drawing.Size(56, 20)
        Me.mnu_umum.Text = "Umum"
        '
        'mnu_umum_pb
        '
        Me.mnu_umum_pb.Name = "mnu_umum_pb"
        Me.mnu_umum_pb.Size = New System.Drawing.Size(156, 22)
        Me.mnu_umum_pb.Text = "Pencarian Buku"
        '
        'mnu_umum_daftar_anggota
        '
        Me.mnu_umum_daftar_anggota.Name = "mnu_umum_daftar_anggota"
        Me.mnu_umum_daftar_anggota.Size = New System.Drawing.Size(156, 22)
        Me.mnu_umum_daftar_anggota.Text = "Daftar Anggota"
        '
        'mnu_umum_buku_tamu
        '
        Me.mnu_umum_buku_tamu.Name = "mnu_umum_buku_tamu"
        Me.mnu_umum_buku_tamu.Size = New System.Drawing.Size(156, 22)
        Me.mnu_umum_buku_tamu.Text = "Buku Tamu"
        '
        'Templates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1184, 511)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Templates"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Templates Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_file As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_file_login As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_file_logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_file_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_anggota As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_anggota_pb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_anggota_peminjam_buku As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_anggota_buku_tamu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_petugas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_petugas_buku As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_petugas_data_peminjam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_petugas_data_anggota As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_kepala As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_kepala_lap_data_buku As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_kepala_lap_peminjam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_umum As ToolStripMenuItem
    Friend WithEvents mnu_umum_daftar_anggota As ToolStripMenuItem
    Friend WithEvents mnu_umum_buku_tamu As ToolStripMenuItem
    Friend WithEvents mnu_umum_pb As ToolStripMenuItem
End Class

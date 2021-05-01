Public Class Templates

    Private Sub Templates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Menu
        mnu_file_logout.Visible = False
        mnu_anggota.Visible = False
        mnu_petugas.Visible = False
        mnu_kepala.Visible = False
        mnu_umum.Visible = False

        Login.MdiParent = Me
        Login.Show()
    End Sub

    Private Sub mnu_file_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_file_exit.Click
        Dispose()
    End Sub

    Private Sub mnu_file_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_file_login.Click
        Login.MdiParent = Me
        Login.Show()
    End Sub

    Private Sub mnu_file_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_file_logout.Click
        mnu_file_logout.Visible = False
        mnu_anggota.Visible = False
        mnu_petugas.Visible = False
        mnu_kepala.Visible = False
        mnu_umum.Visible = False


        mnu_file_exit.Visible = True
        mnu_file_login.Visible = True

        DaftarBukuTamu.Close()
        Dashboard.Close()
        PencarianBuku.Close()
        DaftarAnggota.Close()
        PeminjamBuku.Close()
        DataPeminjamBuku.Close()
        DataDaftarAnggota.Close()
        DataBuku.Close()
        LaporanDataBuku.Close()
        LaporanDataPeminjam.Close()
        Login.MdiParent = Me
        Login.Show()
    End Sub




#Region "MENU UMUM"
    Private Sub mnu_umum_daftar_anggota_Click(sender As Object, e As EventArgs) Handles mnu_umum_daftar_anggota.Click
        DaftarBukuTamu.Close()
        Dashboard.Close()
        PencarianBuku.Close()
        PeminjamBuku.Close()
        DaftarAnggota.MdiParent = Me
        DaftarAnggota.Show()
    End Sub
    Private Sub mnu_umum_buku_tamu_Click(sender As Object, e As EventArgs) Handles mnu_umum_buku_tamu.Click
        DaftarAnggota.Close()
        Dashboard.Close()
        PencarianBuku.Close()
        PeminjamBuku.Close()
        DaftarBukuTamu.MdiParent = Me
        DaftarBukuTamu.Show()
    End Sub
    Private Sub mnu_umum_pb_Click(sender As Object, e As EventArgs) Handles mnu_umum_pb.Click
        Dashboard.Close()
        DaftarAnggota.Close()
        DaftarBukuTamu.Close()
        PeminjamBuku.Close()
        PencarianBuku.MdiParent = Me
        PencarianBuku.Show()
    End Sub
#End Region

#Region "MENU ANGGOTA"
    Private Sub mnu_anggota_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_anggota_pb.Click
        Dashboard.Close()
        DaftarAnggota.Close()
        DaftarBukuTamu.Close()
        PeminjamBuku.Close()
        PencarianBuku.MdiParent = Me
        PencarianBuku.Show()
    End Sub
    Private Sub mnu_anggota_peminjam_buku_Click(sender As Object, e As EventArgs) Handles mnu_anggota_peminjam_buku.Click
        Dashboard.Close()
        DaftarAnggota.Close()
        DaftarBukuTamu.Close()
        PencarianBuku.Close()
        PeminjamBuku.MdiParent = Me
        PeminjamBuku.Show()
    End Sub
    Private Sub mnu_anggota_buku_tamu_Click(sender As Object, e As EventArgs) Handles mnu_anggota_buku_tamu.Click
        Dashboard.Close()
        DaftarAnggota.Close()
        PeminjamBuku.Close()
        PencarianBuku.Close()
        DaftarBukuTamu.MdiParent = Me
        DaftarBukuTamu.Show()
    End Sub


#End Region

#Region "MENU PETUGAS"
    Private Sub mnu_petugas_buku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_petugas_buku.Click
        Dashboard.Close()
        DaftarAnggota.Close()
        DaftarBukuTamu.Close()
        PeminjamBuku.Close()
        PencarianBuku.Close()
        DataPeminjamBuku.Close()
        DataDaftarAnggota.Close()
        DataBuku.MdiParent = Me
        DataBuku.Show()
    End Sub
    Private Sub mnu_petugas_data_peminjam_Click(sender As Object, e As EventArgs) Handles mnu_petugas_data_peminjam.Click
        Dashboard.Close()
        DaftarAnggota.Close()
        DaftarBukuTamu.Close()
        PeminjamBuku.Close()
        PencarianBuku.Close()
        DataBuku.Close()
        DataDaftarAnggota.Close()
        DataPeminjamBuku.MdiParent = Me
        DataPeminjamBuku.Show()
    End Sub

    Private Sub mnu_petugas_data_anggota_Click(sender As Object, e As EventArgs) Handles mnu_petugas_data_anggota.Click
        Dashboard.Close()
        DaftarAnggota.Close()
        DaftarBukuTamu.Close()
        PeminjamBuku.Close()
        PencarianBuku.Close()
        DataBuku.Close()
        DataPeminjamBuku.Close()
        DataDaftarAnggota.MdiParent = Me
        DataDaftarAnggota.Show()
    End Sub

    Private Sub mnu_kepala_lap_data_buku_Click(sender As Object, e As EventArgs) Handles mnu_kepala_lap_data_buku.Click
        Dashboard.Close()
        LaporanDataPeminjam.Close()
        LaporanDataBuku.MdiParent = Me
        LaporanDataBuku.Show()
    End Sub

    Private Sub mnu_kepala_lap_peminjam_Click(sender As Object, e As EventArgs) Handles mnu_kepala_lap_peminjam.Click
        Dashboard.Close()
        LaporanDataBuku.Close()
        LaporanDataPeminjam.MdiParent = Me
        LaporanDataPeminjam.Show()
    End Sub
#End Region

#Region "MENU KEPALA"

#End Region
End Class
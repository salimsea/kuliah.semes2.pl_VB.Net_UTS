Public Class PeminjamBuku
    Private Sub PeminjamBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka()
        rek.Open("select * from tbl_buku", kon, 3, 2)
        Do While Not rek.EOF
            cmb_nama_buku.Items.Add(rek.Fields("judul").Value)
            rek.MoveNext()
        Loop
        tutup()

        txt_username.Text = Login.User
        txt_level.Text = Login.Role
    End Sub
    Private Sub btn_pinjam_Click(sender As Object, e As EventArgs) Handles btn_pinjam.Click
        Dim sql, nama_peminjam, nama_buku, msg As String
        nama_peminjam = txt_nama_peminjam.Text
        nama_buku = cmb_nama_buku.Text
        Dim tgl_pinjam, tgl_kembali As Date
        tgl_pinjam = dt_tgl_pinjam.Value
        tgl_kembali = dt_tgl_kembali.Value

        If String.IsNullOrEmpty(nama_peminjam) Or String.IsNullOrEmpty(nama_buku) Then
            MsgBox("semua form wajib diisi", vbInformation, "Informasi")
            txt_nama_peminjam.Focus()
            Return
        End If

        buka()
        sql = String.Format("SELECT * FROM tbl_pinjam_buku WHERE nama_pinjam = '{0}'", nama_peminjam)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            msg = String.Format("Nama {0} sudah batas maksimal peminjaman, hanya bisa 1orang/1buku", rek.Fields("nama_pinjam").Value)
            MsgBox(msg, vbInformation, "Informasi")
        Else
            sql = String.Format("INSERT INTO `tbl_pinjam_buku`(`nama_pinjam`, `nama_buku`, `tgl_pinjam`, `tgl_kembali`) VALUES  ('{0}', '{1}', '{2}', '{3}')", nama_peminjam, nama_buku, tgl_pinjam.ToString("yyyy-MM-dd"), tgl_kembali.ToString("yyyy-MM-dd"))
            kon.Execute(sql)
            MsgBox("Selamat nama peminjam (" + nama_peminjam + ") berhasil di simpan ke database", vbInformation, "Informasi")
            txt_nama_peminjam.Text = ""
            txt_nama_peminjam.Focus()
        End If
        tutup()


    End Sub
End Class
Public Class DaftarBukuTamu
    Private Sub txt_nama_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nama.GotFocus
        txt_nama.BackColor = Color.Yellow
        txt_nama.ForeColor = Color.Red
    End Sub

    Private Sub txt_nama_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nama.LostFocus
        txt_nama.BackColor = Color.White
        txt_nama.ForeColor = Color.Black
    End Sub

    Private Sub txt_nama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar = Chr(13)) Then
            txt_alamat.Focus()
        End If
    End Sub
    Private Sub txt_alamat_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_alamat.GotFocus
        txt_alamat.BackColor = Color.Yellow
        txt_alamat.ForeColor = Color.Red
    End Sub

    Private Sub txt_alamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_alamat.KeyPress
        If (e.KeyChar = Chr(13)) Then
            btn_buku_tamu.Focus()
        End If
    End Sub

    Private Sub txt_alamat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_alamat.LostFocus
        txt_alamat.BackColor = Color.White
        txt_alamat.ForeColor = Color.Black
    End Sub

    Private Sub btn_buku_tamu_Click(sender As Object, e As EventArgs) Handles btn_buku_tamu.Click
        Dim sql, nama, alamat, msg As String
        nama = txt_nama.Text
        alamat = txt_alamat.Text

        Dim tanggal As Date
        tanggal = txt_tanggal.Value

        If String.IsNullOrEmpty(nama) Or String.IsNullOrEmpty(alamat) Then
            MsgBox("nama dan alamat tidak boleh kosong", vbInformation, "Informasi")
            txt_nama.Text = ""
            txt_alamat.Text = ""
            txt_nama.Focus()
            Return
        End If


        buka()
        sql = String.Format("SELECT * FROM tbl_buku_tamu WHERE nama = '{0}'", nama)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            msg = String.Format("nama {0} sudah pernah isi daftar buku", rek.Fields("nama").Value)
            MsgBox(msg, vbInformation, "Informasi")
            txt_nama.Text = ""
            txt_alamat.Text = ""
            txt_nama.Focus()

        Else
            sql = String.Format("INSERT INTO `tbl_buku_tamu`(`nama`, `alamat`, `tanggal`) VALUES  ('{0}', '{1}', '{2}')", nama, alamat, tanggal.ToString("yyyy-MM-dd"))
            kon.Execute(sql)
            MsgBox("Berhasil input buku tamu", vbInformation, "Informasi")

            txt_nama.Text = ""
            txt_alamat.Text = ""
            txt_nama.Focus()

        End If
        tutup()
    End Sub
End Class
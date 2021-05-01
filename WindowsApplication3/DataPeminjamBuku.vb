Public Class DataPeminjamBuku
    Sub ResetForm()
        txt_kd_peminjam.Text = ""
        txt_nama_peminjam.Text = ""
        cmb_nama_buku.ResetText()
        dt_tgl_pinjam.ResetText()
        dt_tgl_kembali.ResetText()
    End Sub
    Sub GetUserSearch(txt)
        dg_data_peminjam.Rows.Clear()
        Dim no As Integer
        buka()
        rek.Open("Select * from tbl_pinjam_buku where nama_pinjam like '%" & txt & "%' order by kd_pinjam desc", kon, 3, 2)
        no = 1
        Do While Not rek.EOF
            dg_data_peminjam.Rows.Add(rek.Fields("kd_pinjam").Value,
                                     rek.Fields("nama_pinjam").Value,
                                     rek.Fields("nama_buku").Value,
                                     rek.Fields("tgl_pinjam").Value,
                                     rek.Fields("tgl_kembali").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub
    Sub TampilGrid()
        Dim judul() As String = {"Kode", "Nama Peminjam", "Nama Buku", "Tgl. Pinjam", "Tgl. Kembali"}
        Dim lebar() As String = {60, 150, 130, 120, 120}
        Dim i As Integer
        dg_data_peminjam.RowHeadersVisible = False
        dg_data_peminjam.ColumnCount = 5
        dg_data_peminjam.RowCount = 1
        dg_data_peminjam.SelectionMode = DataGridViewSelectionMode.CellSelect
        dg_data_peminjam.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9)
        dg_data_peminjam.Rows.Clear()
        For i = 0 To dg_data_peminjam.ColumnCount - 1
            dg_data_peminjam.Columns(i).HeaderText = judul(i)
            dg_data_peminjam.Columns(i).Width = lebar(i)
            dg_data_peminjam.Columns(i).DefaultCellStyle.Font = New Font("Arial", 7)
            dg_data_peminjam.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next
        GetUserSearch(txt_pencarian.Text)
    End Sub
    Private Sub txt_pencarian_TextChanged(sender As Object, e As EventArgs) Handles txt_pencarian.TextChanged
        GetUserSearch(txt_pencarian.Text)
    End Sub
    Private Sub DataPeminjamBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_insert.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False

        txt_kd_peminjam.Enabled = False
        txt_nama_peminjam.Enabled = False
        cmb_nama_buku.Enabled = False
        dt_tgl_pinjam.Enabled = False
        dt_tgl_kembali.Enabled = False

        buka()
        rek.Open("select * from tbl_buku", kon, 3, 2)
        Do While Not rek.EOF
            cmb_nama_buku.Items.Add(rek.Fields("judul").Value)
            rek.MoveNext()
        Loop
        tutup()

        TampilGrid()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        btn_insert.Enabled = True
        btn_cancel.Enabled = True

        txt_nama_peminjam.Enabled = True
        cmb_nama_buku.Enabled = True
        dt_tgl_pinjam.Enabled = True
        dt_tgl_kembali.Enabled = True

        btn_add.Enabled = False
        txt_nama_peminjam.Focus()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        btn_insert.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False


        txt_nama_peminjam.Enabled = False
        cmb_nama_buku.Enabled = False
        dt_tgl_pinjam.Enabled = False
        dt_tgl_kembali.Enabled = False

        btn_add.Enabled = True

        ResetForm()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim sql, kd_pinjam, nama_pinjam, nama_buku, msg As String
        kd_pinjam = txt_kd_peminjam.Text
        nama_pinjam = txt_nama_peminjam.Text
        nama_buku = cmb_nama_buku.Text

        If String.IsNullOrEmpty(nama_pinjam) Or String.IsNullOrEmpty(nama_buku) Then
            MsgBox("Data tidak boleh kosong", vbInformation, "Informasi")
            Return
        End If

        buka()
        sql = String.Format("Select * FROM tbl_pinjam_buku WHERE nama_pinjam = '{0}'", nama_pinjam)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            msg = String.Format("Nama Peminjam {0} sudah tidak bisa meminjam buku lagi, hanya bisa 1orang/1buku", rek.Fields("nama_pinjam").Value)
            MsgBox(msg, vbInformation, "Informasi")
        Else
            sql = String.Format("INSERT INTO `tbl_pinjam_buku`(`nama_pinjam`, `nama_buku`, `tgl_pinjam`, `tgl_kembali`) VALUES  ('{0}', '{1}', '{2}', '{3}')", nama_pinjam, nama_buku, dt_tgl_pinjam.Value.ToString("yyyy-MM-dd"), dt_tgl_kembali.Value.ToString("yyyy-MM-dd"))
            kon.Execute(sql)
            MsgBox("Berhasil tambah nama peminjam buku (" + nama_pinjam + ")", vbInformation, "Informasi")
        End If
        tutup()

        ResetForm()
        TampilGrid()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        btn_insert.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False

        txt_nama_peminjam.Enabled = False
        cmb_nama_buku.Enabled = False
        dt_tgl_pinjam.Enabled = False
        dt_tgl_kembali.Enabled = False

        btn_add.Enabled = True

        Dim sql, kd_pinjam, nama_pinjam, nama_buku, msg As String
        kd_pinjam = txt_kd_peminjam.Text
        nama_pinjam = txt_nama_peminjam.Text
        nama_buku = cmb_nama_buku.Text

        If String.IsNullOrEmpty(nama_pinjam) Or String.IsNullOrEmpty(nama_buku) Then
            MsgBox("Data tidak boleh kosong", vbInformation, "Informasi")
            Return
        End If

        buka()
        sql = String.Format("Select * FROM tbl_pinjam_buku WHERE kd_pinjam = '{0}'", kd_pinjam)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            sql = String.Format("UPDATE tbl_pinjam_buku SET nama_pinjam = '{0}', nama_buku = '{1}', tgl_pinjam = '{2}', tgl_kembali = '{3}' WHERE kd_pinjam = '{4}' ", nama_pinjam, nama_buku, dt_tgl_pinjam.Value.ToString("yyyy-MM-dd"), dt_tgl_kembali.Value.ToString("yyyy-MM-dd"), kd_pinjam)
            kon.Execute(sql)
            MsgBox("Berhasil perbarui nama peminjam (" + nama_pinjam + ")", vbInformation, "Informasi")
        Else
            msg = String.Format("Nama Peminjam {0} tidak ada", rek.Fields("nama_pinjam").Value)
            MsgBox(msg, vbInformation, "Informasi")
        End If

        tutup()
        ResetForm()
        TampilGrid()
    End Sub



    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim sql, kd_pinjam, msg As String
        kd_pinjam = txt_kd_peminjam.Text
        If String.IsNullOrEmpty(kd_pinjam) Then
            MsgBox("Kode pinjam tidak boleh kosong", vbInformation, "Informasi")
            Return
        End If

        buka()
        sql = String.Format("SELECT * FROM tbl_pinjam_buku WHERE kd_pinjam = '{0}'", kd_pinjam)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            sql = String.Format("DELETE FROM tbl_pinjam_buku WHERE kd_pinjam = '{0}'", kd_pinjam)
            kon.Execute(sql)
            MsgBox("Berhasil Delete Pinjam Buku", vbInformation, "Informasi")
        Else
            msg = String.Format("Kode pinjam {0} tidak ada", rek.Fields("kd_pinjam").Value)
            MsgBox(msg, vbInformation, "Informasi")
        End If
        tutup()
        ResetForm()
        TampilGrid()
    End Sub

    Private Sub dg_data_peminjam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_data_peminjam.CellContentClick
        btn_update.Enabled = True
        btn_delete.Enabled = True
        btn_cancel.Enabled = True
        btn_insert.Enabled = False

        txt_nama_peminjam.Enabled = True
        cmb_nama_buku.Enabled = True
        dt_tgl_pinjam.Enabled = True
        dt_tgl_kembali.Enabled = True

        btn_add.Enabled = False
        txt_nama_peminjam.Focus()

        txt_kd_peminjam.Text = dg_data_peminjam.Rows(e.RowIndex).Cells(0).Value
        txt_nama_peminjam.Text = dg_data_peminjam.Rows(e.RowIndex).Cells(1).Value
        cmb_nama_buku.SelectedItem = dg_data_peminjam.Rows(e.RowIndex).Cells(2).Value
        dt_tgl_pinjam.Value = dg_data_peminjam.Rows(e.RowIndex).Cells(3).Value
        dt_tgl_kembali.Value = dg_data_peminjam.Rows(e.RowIndex).Cells(4).Value
    End Sub
End Class
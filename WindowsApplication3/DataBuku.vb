Public Class DataBuku
    Sub ResetForm()
        txt_judul.Text = ""
        txt_penerbit.Text = ""
        txt_pengarang.Text = ""
        txt_lokasi.Text = ""
        txt_stok.Text = 0
        txt_kd_buku.Text = ""
    End Sub
    Sub TampilGrid()
        ' Code untuk seting tampilan GridView
        Dim judul() As String = {"Kode", "Judul", "Pengarang", "Penerbit", "Stok", "Lokasi"}
        Dim lebar() As String = {50, 130, 130, 130, 40, 100}
        Dim i As Integer
        dg_data_buku.RowHeadersVisible = False
        dg_data_buku.ColumnCount = 6
        dg_data_buku.RowCount = 1
        dg_data_buku.SelectionMode = DataGridViewSelectionMode.CellSelect
        dg_data_buku.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9)

        For i = 0 To dg_data_buku.ColumnCount - 1
            dg_data_buku.Columns(i).HeaderText = judul(i)
            dg_data_buku.Columns(i).Width = lebar(i)
            dg_data_buku.Columns(i).DefaultCellStyle.Font = New Font("Arial", 7)
            dg_data_buku.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next


        ' Code untuk tampil data
        Dim no As Integer
        Me.dg_data_buku.Rows.Clear()
        buka()
        rek.Open("Select * from tbl_buku where judul like '%" & txt_pencarian.Text & "%' order by kd_buku desc", kon, 3, 2)
        no = 1
        Do While Not rek.EOF

            Me.dg_data_buku.Rows.Add(rek.Fields("kd_buku").Value, rek.Fields("judul").Value, rek.Fields("pengarang").Value, rek.Fields("penerbit").Value, rek.Fields("stok").Value, rek.Fields("lokasi").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()

    End Sub

    Private Sub Data_buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_insert.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False


        txt_judul.Enabled = False
        txt_pengarang.Enabled = False
        txt_penerbit.Enabled = False
        txt_lokasi.Enabled = False
        txt_stok.Enabled = False
        txt_kd_buku.Enabled = False


        TampilGrid()


    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        btn_insert.Enabled = True
        btn_cancel.Enabled = True

        txt_judul.Enabled = True
        txt_pengarang.Enabled = True
        txt_penerbit.Enabled = True
        txt_lokasi.Enabled = True
        txt_stok.Enabled = True

        btn_add.Enabled = False
        txt_judul.Focus()
    End Sub

    Private Sub txt_judul_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_judul.GotFocus
        txt_judul.BackColor = Color.Yellow
        txt_judul.ForeColor = Color.Red
    End Sub
    Private Sub txt_judul_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_judul.LostFocus
        txt_judul.BackColor = Color.White
        txt_judul.ForeColor = Color.Black
    End Sub
    Private Sub txt_penerbit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_penerbit.GotFocus
        txt_penerbit.BackColor = Color.Yellow
        txt_penerbit.ForeColor = Color.Red
    End Sub
    Private Sub txt_penerbit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_penerbit.LostFocus
        txt_penerbit.BackColor = Color.White
        txt_penerbit.ForeColor = Color.Black
    End Sub
    Private Sub txt_pengarang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pengarang.GotFocus
        txt_pengarang.BackColor = Color.Yellow
        txt_pengarang.ForeColor = Color.Red
    End Sub
    Private Sub txt_pengarang_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pengarang.LostFocus
        txt_pengarang.BackColor = Color.White
        txt_pengarang.ForeColor = Color.Black
    End Sub
    Private Sub txt_lokasi_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_lokasi.GotFocus
        txt_lokasi.BackColor = Color.Yellow
        txt_lokasi.ForeColor = Color.Red
    End Sub
    Private Sub txt_lokasi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_lokasi.LostFocus
        txt_lokasi.BackColor = Color.White
        txt_lokasi.ForeColor = Color.Black
    End Sub
    Private Sub txt_stok_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_stok.GotFocus
        txt_stok.BackColor = Color.Yellow
        txt_stok.ForeColor = Color.Red
    End Sub
    Private Sub txt_stok_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_stok.LostFocus
        txt_stok.BackColor = Color.White
        txt_stok.ForeColor = Color.Black
    End Sub


    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        btn_insert.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False


        txt_judul.Enabled = False
        txt_pengarang.Enabled = False
        txt_penerbit.Enabled = False
        txt_lokasi.Enabled = False
        txt_stok.Enabled = False
        txt_kd_buku.Enabled = False

        btn_add.Enabled = True

        ResetForm()
    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        btn_insert.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False


        txt_judul.Enabled = False
        txt_pengarang.Enabled = False
        txt_penerbit.Enabled = False
        txt_lokasi.Enabled = False
        txt_stok.Enabled = False
        txt_kd_buku.Enabled = False

        btn_add.Enabled = True

        Dim sql, judul, penerbit, pengarang, lokasi, msg As String
        Dim stok As Integer
        judul = txt_judul.Text
        penerbit = txt_penerbit.Text
        pengarang = txt_pengarang.Text
        lokasi = txt_lokasi.Text
        stok = txt_stok.Text

        If String.IsNullOrEmpty(judul) Or String.IsNullOrEmpty(penerbit) Or String.IsNullOrEmpty(pengarang) Or String.IsNullOrEmpty(lokasi) Or String.IsNullOrEmpty(stok) Then
            MsgBox("Data tidak boleh kosong", vbInformation, "Informasi")
            Return
        End If

        buka()
        sql = String.Format("SELECT * FROM tbl_buku WHERE judul = '{0}'", judul)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            msg = String.Format("Judul {0} sudah ada", rek.Fields("judul").Value)
            MsgBox(msg, vbInformation, "Informasi")
        Else
            sql = String.Format("INSERT INTO `tbl_buku`(`judul`, `pengarang`, `penerbit`, `lokasi`, `stok`) VALUES  ('{0}', '{1}', '{2}', '{3}', '{4}')", judul, pengarang, penerbit, lokasi, stok)
            kon.Execute(sql)
            MsgBox("Berhasil tambah buku", vbInformation, "Informasi")
        End If

        tutup()
        ResetForm()
        TampilGrid()
    End Sub

    Private Sub txt_pencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pencarian.TextChanged
        ' Code untuk tampil data
        Dim no As Integer
        Me.dg_data_buku.Rows.Clear()
        buka()
        rek.Open("Select * from tbl_buku where judul like '%" & txt_pencarian.Text & "%' order by judul", kon, 3, 2)
        no = 1
        Do While Not rek.EOF

            Me.dg_data_buku.Rows.Add(no, rek.Fields("judul").Value, rek.Fields("pengarang").Value, rek.Fields("penerbit").Value, rek.Fields("stok").Value, rek.Fields("lokasi").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        btn_insert.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False


        txt_judul.Enabled = False
        txt_pengarang.Enabled = False
        txt_penerbit.Enabled = False
        txt_lokasi.Enabled = False
        txt_stok.Enabled = False
        txt_kd_buku.Enabled = False

        btn_add.Enabled = True

        Dim sql, kd_buku, judul, penerbit, pengarang, lokasi, msg As String
        Dim stok As Integer
        kd_buku = txt_kd_buku.Text
        judul = txt_judul.Text
        penerbit = txt_penerbit.Text
        pengarang = txt_pengarang.Text
        lokasi = txt_lokasi.Text
        stok = txt_stok.Text

        If String.IsNullOrEmpty(kd_buku) Or String.IsNullOrEmpty(judul) Or String.IsNullOrEmpty(penerbit) Or String.IsNullOrEmpty(pengarang) Or String.IsNullOrEmpty(lokasi) Or String.IsNullOrEmpty(stok) Then
            MsgBox("Data tidak boleh kosong", vbInformation, "Informasi")
            Return
        End If

        buka()
        sql = String.Format("SELECT * FROM tbl_buku WHERE kd_buku = '{0}'", kd_buku)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            sql = String.Format("UPDATE tbl_buku SET judul = '{0}', pengarang = '{1}', penerbit = '{2}', lokasi = '{3}', stok = '{4}'  WHERE kd_buku = '{5}' ", judul, pengarang, penerbit, lokasi, stok, kd_buku)
            kon.Execute(sql)
            MsgBox("Berhasil Update Buku", vbInformation, "Informasi")
        Else
            msg = String.Format("Kode buku {0} tidak ada", rek.Fields("kd_buku").Value)
            MsgBox(msg, vbInformation, "Informasi")
        End If

        tutup()
        ResetForm()
        TampilGrid()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        btn_insert.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False


        txt_judul.Enabled = False
        txt_pengarang.Enabled = False
        txt_penerbit.Enabled = False
        txt_lokasi.Enabled = False
        txt_stok.Enabled = False
        txt_kd_buku.Enabled = False

        btn_add.Enabled = True

        Dim sql, kd_buku, msg As String
        kd_buku = txt_kd_buku.Text

        If String.IsNullOrEmpty(kd_buku) Then
            MsgBox("Kode buku tidak boleh kosong", vbInformation, "Informasi")
            Return
        End If

        buka()
        sql = String.Format("SELECT * FROM tbl_buku WHERE kd_buku = '{0}'", kd_buku)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            sql = String.Format("DELETE FROM tbl_buku WHERE kd_buku = '{0}'", kd_buku)
            kon.Execute(sql)
            MsgBox("Berhasil Delete Buku", vbInformation, "Informasi")
        Else
            msg = String.Format("Kode buku {0} tidak ada", rek.Fields("kd_buku").Value)
            MsgBox(msg, vbInformation, "Informasi")
        End If

        tutup()
        ResetForm()
        TampilGrid()
    End Sub

    Private Sub dg_data_buku_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_data_buku.CellContentClick
        btn_update.Enabled = True
        btn_delete.Enabled = True
        btn_cancel.Enabled = True
        btn_insert.Enabled = False

        txt_judul.Enabled = True
        txt_pengarang.Enabled = True
        txt_penerbit.Enabled = True
        txt_lokasi.Enabled = True
        txt_stok.Enabled = True

        btn_add.Enabled = False
        txt_judul.Focus()

        txt_kd_buku.Text = dg_data_buku.Rows(e.RowIndex).Cells(0).Value
        txt_judul.Text = dg_data_buku.Rows(e.RowIndex).Cells(1).Value
        txt_pengarang.Text = dg_data_buku.Rows(e.RowIndex).Cells(2).Value
        txt_penerbit.Text = dg_data_buku.Rows(e.RowIndex).Cells(3).Value
        txt_stok.Text = dg_data_buku.Rows(e.RowIndex).Cells(4).Value
        txt_lokasi.Text = dg_data_buku.Rows(e.RowIndex).Cells(5).Value

    End Sub
End Class
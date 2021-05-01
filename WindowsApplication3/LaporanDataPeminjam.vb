Public Class LaporanDataPeminjam

    Private Sub txt_pencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pencarian.TextChanged
        ' Code untuk tampil data
        Dim no As Integer
        Me.dg_lap_peminjam.Rows.Clear()
        buka()
        rek.Open("Select * from tbl_buku where judul like '%" & txt_pencarian.Text & "%' order by judul", kon, 3, 2)
        no = 1
        Do While Not rek.EOF

            Me.dg_lap_peminjam.Rows.Add(no, rek.Fields("judul").Value, rek.Fields("pengarang").Value, rek.Fields("penerbit").Value, rek.Fields("stok").Value, rek.Fields("lokasi").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub

    Private Sub LaporanDataPeminjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim judul() As String = {"No", "Judul Buku", "Pengarang", "Penerbit", "Stok", "Lokasi"}
        Dim lebar() As String = {50, 200, 200, 200, 50, 0}
        Dim i As Integer
        dg_lap_peminjam.RowHeadersVisible = False
        dg_lap_peminjam.ColumnCount = 6
        dg_lap_peminjam.RowCount = 1
        dg_lap_peminjam.SelectionMode = DataGridViewSelectionMode.CellSelect
        dg_lap_peminjam.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13)

        For i = 0 To dg_lap_peminjam.ColumnCount - 1
            dg_lap_peminjam.Columns(i).HeaderText = judul(i)
            dg_lap_peminjam.Columns(i).Width = lebar(i)
            dg_lap_peminjam.Columns(i).DefaultCellStyle.Font = New Font("Arial", 11)
            dg_lap_peminjam.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next

        ' Code untuk tampil data
        Dim no As Integer
        Me.dg_lap_peminjam.Rows.Clear()
        buka()
        rek.Open("Select * from tbl_buku where judul like '%" & txt_pencarian.Text & "%' order by judul", kon, 3, 2)
        no = 1
        Do While Not rek.EOF
            Me.dg_lap_peminjam.Rows.Add(no, rek.Fields("judul").Value, rek.Fields("pengarang").Value, rek.Fields("penerbit").Value, rek.Fields("stok").Value, rek.Fields("lokasi").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub
    Private Sub dg_lap_peminjam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_lap_peminjam.CellContentClick
        RakBuku.lbl_rak_buku.Text = dg_lap_peminjam.Rows(e.RowIndex).Cells(5).Value
        RakBuku.ShowDialog()
    End Sub
End Class
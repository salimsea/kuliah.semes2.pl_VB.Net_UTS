Public Class LaporanDataPeminjam

    Private Sub txt_pencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pencarian.TextChanged
        ' Code untuk tampil data
        Dim no As Integer
        Me.dg_lap_peminjam.Rows.Clear()
        buka()
        rek.Open("Select * from tbl_pinjam_buku where nama_pinjam like '%" & txt_pencarian.Text & "%' order by nama_pinjam", kon, 3, 2)
        no = 1
        Do While Not rek.EOF
            Me.dg_lap_peminjam.Rows.Add(no, rek.Fields("nama_pinjam").Value, rek.Fields("nama_buku").Value, rek.Fields("tgl_pinjam").Value, rek.Fields("tgl_kembali").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub

    Private Sub LaporanDataPeminjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim judul() As String = {"No", "Nama Peminjam", "Judul Buku", "Tgl. Pinjam", "Tgl. Kembali"}
        Dim lebar() As String = {30, 170, 200, 150, 150}
        Dim i As Integer
        dg_lap_peminjam.RowHeadersVisible = False
        dg_lap_peminjam.ColumnCount = 5
        dg_lap_peminjam.RowCount = 1
        dg_lap_peminjam.SelectionMode = DataGridViewSelectionMode.CellSelect
        dg_lap_peminjam.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 11)

        For i = 0 To dg_lap_peminjam.ColumnCount - 1
            dg_lap_peminjam.Columns(i).HeaderText = judul(i)
            dg_lap_peminjam.Columns(i).Width = lebar(i)
            dg_lap_peminjam.Columns(i).DefaultCellStyle.Font = New Font("Arial", 9)
            dg_lap_peminjam.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next

        ' Code untuk tampil data
        Dim no As Integer
        Me.dg_lap_peminjam.Rows.Clear()
        buka()
        rek.Open("Select * from tbl_pinjam_buku where nama_pinjam like '%" & txt_pencarian.Text & "%' order by nama_pinjam", kon, 3, 2)
        no = 1
        Do While Not rek.EOF
            Me.dg_lap_peminjam.Rows.Add(no, rek.Fields("nama_pinjam").Value, rek.Fields("nama_buku").Value, rek.Fields("tgl_pinjam").Value, rek.Fields("tgl_kembali").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub

End Class
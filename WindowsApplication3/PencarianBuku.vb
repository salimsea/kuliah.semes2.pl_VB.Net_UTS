Public Class PencarianBuku

    Private Sub Pencarian_buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Code untuk seting tampilan GridView
        Dim judul() As String = {"No", "Judul Buku", "Pengarang", "Penerbit", "Stok", "Lokasi"}
        Dim lebar() As String = {50, 200, 200, 200, 50, 0}
        Dim i As Integer
        dg_pencarian_buku.RowHeadersVisible = False
        dg_pencarian_buku.ColumnCount = 6
        dg_pencarian_buku.RowCount = 1
        dg_pencarian_buku.SelectionMode = DataGridViewSelectionMode.CellSelect
        dg_pencarian_buku.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13)

        For i = 0 To dg_pencarian_buku.ColumnCount - 1
            dg_pencarian_buku.Columns(i).HeaderText = judul(i)
            dg_pencarian_buku.Columns(i).Width = lebar(i)
            dg_pencarian_buku.Columns(i).DefaultCellStyle.Font = New Font("Arial", 11)
            dg_pencarian_buku.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next


        ' Code untuk tampil data
        Dim no As Integer
        Me.dg_pencarian_buku.Rows.Clear()
        buka()
        rek.Open("Select * from tbl_buku where judul like '%" & txt_pencarian.Text & "%' order by judul", kon, 3, 2)
        no = 1
        Do While Not rek.EOF

            Me.dg_pencarian_buku.Rows.Add(no, rek.Fields("judul").Value, rek.Fields("pengarang").Value, rek.Fields("penerbit").Value, rek.Fields("stok").Value, rek.Fields("lokasi").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()

    End Sub

    Private Sub txt_pencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pencarian.TextChanged
        ' Code untuk tampil data
        Dim no As Integer
        Me.dg_pencarian_buku.Rows.Clear()
        buka()
        rek.Open("Select * from tbl_buku where judul like '%" & txt_pencarian.Text & "%' order by judul", kon, 3, 2)
        no = 1
        Do While Not rek.EOF

            Me.dg_pencarian_buku.Rows.Add(no, rek.Fields("judul").Value, rek.Fields("pengarang").Value, rek.Fields("penerbit").Value, rek.Fields("stok").Value, rek.Fields("lokasi").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub

    Private Sub dg_pencarian_buku_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_pencarian_buku.CellContentClick
        RakBuku.lbl_rak_buku.Text = dg_pencarian_buku.Rows(e.RowIndex).Cells(5).Value
        RakBuku.ShowDialog()
    End Sub
End Class
Public Class DataDaftarAnggota
    Public Function ComboLevel(id) As String
        If id = 1 Then
            Return "Anggota"
        ElseIf id = 2 Then
            Return "Petugas"
        ElseIf id = 3 Then
            Return "Umum"
        ElseIf id = 4 Then
            Return "Kepala"
        End If
    End Function
    Public Function Status(id) As String
        If id = 1 Then
            Return "Aktif"
        ElseIf id = -1 Then
            Return "Tidak Aktif"
        End If
    End Function
    Sub ResetForm()
        txt_kd_user.Text = ""
        txt_username.Text = ""
        txt_password.Text = ""
        cmb_level.ResetText()
        rd_aktif.Checked = False
        rd_tidak_aktif.Checked = False
    End Sub
    Sub GetUserSearch(txt)
        dg_data_anggota.Rows.Clear()
        Dim no As Integer
        buka()
        rek.Open("Select * from tbl_user where username like '%" & txt & "%' order by kd_user desc", kon, 3, 2)
        no = 1
        Do While Not rek.EOF
            dg_data_anggota.Rows.Add(rek.Fields("kd_user").Value,
                                     rek.Fields("username").Value,
                                     rek.Fields("password").Value,
                                     ComboLevel(rek.Fields("level").Value),
                                     Status(rek.Fields("status").Value))
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub
    Sub TampilGrid()
        Dim judul() As String = {"Kode", "Username", "Password", "Level", "Status"}
        Dim lebar() As String = {80, 130, 130, 130, 100}
        Dim i As Integer
        dg_data_anggota.RowHeadersVisible = False
        dg_data_anggota.ColumnCount = 5
        dg_data_anggota.RowCount = 1
        dg_data_anggota.SelectionMode = DataGridViewSelectionMode.CellSelect
        dg_data_anggota.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9)
        dg_data_anggota.Rows.Clear()
        For i = 0 To dg_data_anggota.ColumnCount - 1
            dg_data_anggota.Columns(i).HeaderText = judul(i)
            dg_data_anggota.Columns(i).Width = lebar(i)
            dg_data_anggota.Columns(i).DefaultCellStyle.Font = New Font("Arial", 7)
            dg_data_anggota.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next
        GetUserSearch(txt_pencarian.Text)
    End Sub

    Private Sub DataDaftarAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_insert.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False

        txt_kd_user.Enabled = False
        txt_username.Enabled = False
        txt_password.Enabled = False
        rd_aktif.Enabled = False
        rd_tidak_aktif.Enabled = False
        cmb_level.Enabled = False
        TampilGrid()
    End Sub
    Private Sub txt_pencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pencarian.TextChanged
        GetUserSearch(txt_pencarian.Text)
    End Sub
    Private Sub dg_data_anggota_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_data_anggota.CellContentClick
        btn_update.Enabled = True
        btn_delete.Enabled = True
        btn_cancel.Enabled = True
        btn_insert.Enabled = False

        txt_username.Enabled = True
        txt_password.Enabled = True
        rd_aktif.Enabled = True
        rd_tidak_aktif.Enabled = True
        cmb_level.Enabled = True

        btn_add.Enabled = False
        txt_username.Focus()

        txt_kd_user.Text = dg_data_anggota.Rows(e.RowIndex).Cells(0).Value
        txt_username.Text = dg_data_anggota.Rows(e.RowIndex).Cells(1).Value
        txt_password.Text = dg_data_anggota.Rows(e.RowIndex).Cells(2).Value
        cmb_level.Text = dg_data_anggota.Rows(e.RowIndex).Cells(3).Value
        If dg_data_anggota.Rows(e.RowIndex).Cells(4).Value = "Aktif" Then
            rd_aktif.Checked = True
            rd_tidak_aktif.Checked = False
        Else
            rd_aktif.Checked = False
            rd_tidak_aktif.Checked = True
        End If
        cmb_level.SelectedItem = dg_data_anggota.Rows(e.RowIndex).Cells(3).Value


    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        btn_insert.Enabled = True
        btn_cancel.Enabled = True

        txt_username.Enabled = True
        txt_password.Enabled = True
        rd_aktif.Enabled = True
        rd_tidak_aktif.Enabled = True
        cmb_level.Enabled = True

        btn_add.Enabled = False
        txt_username.Focus()
    End Sub
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim sql, username, password, msg As String
        Dim status, level As Integer
        username = txt_username.Text
        password = txt_password.Text

        If rd_aktif.Checked = True Then
            status = 1
        ElseIf rd_tidak_aktif.Checked = True Then
            status = -1
        End If

        If cmb_level.SelectedItem = "Anggota" Then
            level = 1
        ElseIf cmb_level.SelectedItem = "Petugas" Then
            level = 2
        ElseIf cmb_level.SelectedItem = "Umum" Then
            level = 3
        ElseIf cmb_level.SelectedItem = "Kepala" Then
            level = 4
        End If


        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MsgBox("Data tidak boleh kosong", vbInformation, "Informasi")
            Return
        End If

        buka()
        sql = String.Format("Select * FROM tbl_user WHERE username = '{0}'", username)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            msg = String.Format("Username {0} sudah ada", rek.Fields("username").Value)
            MsgBox(msg, vbInformation, "Informasi")
        Else
            sql = String.Format("INSERT INTO `tbl_user`(`username`, `password`, `status`, `level`) VALUES  ('{0}', '{1}', '{2}', '{3}')", username, password, status, level)
            kon.Execute(sql)
            MsgBox("Berhasil tambah user", vbInformation, "Informasi")
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

        txt_username.Enabled = False
        txt_password.Enabled = False
        rd_aktif.Enabled = False
        rd_tidak_aktif.Enabled = False
        cmb_level.Enabled = False

        btn_add.Enabled = True

        Dim sql, kd_user, username, password, msg As String
        Dim status, level As Integer
        kd_user = txt_kd_user.Text
        username = txt_username.Text
        password = txt_password.Text

        If rd_aktif.Checked = True Then
            status = 1
        ElseIf rd_tidak_aktif.Checked = True Then
            status = -1
        End If

        If cmb_level.SelectedItem = "Anggota" Then
            level = 1
        ElseIf cmb_level.SelectedItem = "Petugas" Then
            level = 2
        ElseIf cmb_level.SelectedItem = "Umum" Then
            level = 3
        ElseIf cmb_level.SelectedItem = "Kepala" Then
            level = 4
        End If

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MsgBox("Data tidak boleh kosong", vbInformation, "Informasi")
            Return
        End If

        buka()
        sql = String.Format("SELECT * FROM tbl_user WHERE kd_user = '{0}'", kd_user)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            sql = String.Format("UPDATE tbl_user SET username = '{0}', password = '{1}', level = '{2}', status = '{3}' WHERE kd_user = '{4}' ", username, password, level, status, kd_user)
            kon.Execute(sql)
            MsgBox("Berhasil Update User", vbInformation, "Informasi")
        Else
            msg = String.Format("Username {0} tidak ada", rek.Fields("username").Value)
            MsgBox(msg, vbInformation, "Informasi")
        End If

        tutup()
        ResetForm()
        TampilGrid()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim sql, kd_user, msg As String
        kd_user = txt_kd_user.Text
        If String.IsNullOrEmpty(kd_user) Then
            MsgBox("Kode user tidak boleh kosong", vbInformation, "Informasi")
            Return
        End If

        buka()
        sql = String.Format("SELECT * FROM tbl_user WHERE kd_user = '{0}'", kd_user)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            sql = String.Format("DELETE FROM tbl_user WHERE kd_user = '{0}'", kd_user)
            kon.Execute(sql)
            MsgBox("Berhasil Delete User", vbInformation, "Informasi")
        Else
            msg = String.Format("Kode user {0} tidak ada", rek.Fields("kd_user").Value)
            MsgBox(msg, vbInformation, "Informasi")
        End If
        tutup()
        ResetForm()
        TampilGrid()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        btn_insert.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_cancel.Enabled = False


        txt_username.Enabled = False
        txt_password.Enabled = False
        rd_aktif.Enabled = False
        rd_tidak_aktif.Enabled = False
        cmb_level.Enabled = False

        btn_add.Enabled = True

        ResetForm()
    End Sub

End Class
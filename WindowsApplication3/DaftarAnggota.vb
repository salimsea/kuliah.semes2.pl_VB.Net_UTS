Public Class DaftarAnggota
    Private Sub txt_username_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_username.GotFocus
        txt_username.BackColor = Color.Yellow
        txt_username.ForeColor = Color.Red
    End Sub

    Private Sub txt_username_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_username.LostFocus
        txt_username.BackColor = Color.White
        txt_username.ForeColor = Color.Black
    End Sub

    Private Sub txt_username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar = Chr(13)) Then
            txt_password.Focus()
        End If
    End Sub
    Private Sub txt_password_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_password.GotFocus
        txt_password.BackColor = Color.Yellow
        txt_password.ForeColor = Color.Red
    End Sub

    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        If (e.KeyChar = Chr(13)) Then
            btn_daftar.Focus()
        End If
    End Sub

    Private Sub txt_password_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_password.LostFocus
        txt_password.BackColor = Color.White
        txt_password.ForeColor = Color.Black
    End Sub


    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        Dim sql, username, password, msg As String
        username = txt_username.Text
        password = txt_password.Text

        Dim status, level As Integer
        status = 1
        level = 1

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MsgBox("username dan password tidak boleh kosong", vbInformation, "Informasi")
            txt_username.Text = ""
            txt_password.Text = ""
            txt_username.Focus()
            Return
        End If

        buka()
        sql = String.Format("SELECT * FROM tbl_user WHERE username = '{0}'", username)
        rek.Open(sql, kon, 3, 2)
        If Not rek.EOF Then
            msg = String.Format("Username {0} sudah terpakai", rek.Fields("username").Value)
            MsgBox(msg, vbInformation, "Informasi")
            txt_username.Text = ""
            txt_password.Text = ""
            txt_username.Focus()

        Else
            sql = String.Format("INSERT INTO `tbl_user`(`username`, `password`, `status`, `level`) VALUES  ('{0}', '{1}', '{2}', '{3}')", username, password, status, level)
            kon.Execute(sql)
            MsgBox("Berhasil daftar menjadi anggota", vbInformation, "Informasi")

            txt_username.Text = ""
            txt_password.Text = ""
            txt_username.Focus()

        End If
        tutup()
    End Sub
End Class
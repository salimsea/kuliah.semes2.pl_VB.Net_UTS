Public Class Login
    Public Shared User, Role As String

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Dispose()
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        '1 anggota
        '2 petugas
        '3 umum
        '4 kepala
        Dim username, password, level As String
        username = txt_username.Text
        password = txt_password.Text
        level = String.Empty
        buka()
        rek.Open("select * from tbl_user where username='" & txt_username.Text & "' and password='" & txt_password.Text & "' and status='1'", kon, 3, 2)
        If Not rek.EOF Then
            If rek.Fields("level").Value = 1 Then
                Templates.mnu_anggota.Visible = True
                Templates.mnu_file_logout.Visible = True

                Templates.mnu_file_exit.Visible = False
                Templates.mnu_file_login.Visible = False
                level = "Anggota"
            ElseIf rek.Fields("level").Value = 2 Then
                Templates.mnu_petugas.Visible = True
                Templates.mnu_file_logout.Visible = True

                Templates.mnu_file_exit.Visible = False
                Templates.mnu_file_login.Visible = False
                level = "Petugas"
            ElseIf rek.Fields("level").Value = 3 Then
                Templates.mnu_umum.Visible = True
                Templates.mnu_file_logout.Visible = True

                Templates.mnu_file_exit.Visible = False
                Templates.mnu_file_login.Visible = False
                level = "Umum"
            ElseIf rek.Fields("level").Value = 4 Then
                Templates.mnu_kepala.Visible = True
                Templates.mnu_file_logout.Visible = True

                Templates.mnu_file_exit.Visible = False
                Templates.mnu_file_login.Visible = False
                level = "Kepala"
            End If
            Dispose()
            Dashboard.MdiParent = Templates
            Dashboard.Show()
            Dashboard.lbl_username.Text = username

            User = username
            Role = level
        Else
            MsgBox("Username dan Password Salah !!", vbInformation, "Informasi")
            txt_username.Text = ""
            txt_password.Text = ""
            txt_username.Focus()
        End If
        tutup()

    End Sub

    Private Sub txt_username_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_username.GotFocus
        txt_username.BackColor = Color.Yellow
        txt_username.ForeColor = Color.Red
    End Sub

    Private Sub txt_username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_username.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txt_password.Focus()
        End If
    End Sub

    Private Sub txt_username_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_username.LostFocus
        txt_username.BackColor = Color.White
        txt_username.ForeColor = Color.Black
    End Sub

    Private Sub txt_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub txt_password_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_password.GotFocus
        txt_password.BackColor = Color.Yellow
        txt_password.ForeColor = Color.Red
    End Sub

    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        If (e.KeyChar = Chr(13)) Then
            btn_login.Focus()
        End If
    End Sub

    Private Sub txt_password_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_password.LostFocus
        txt_password.BackColor = Color.White
        txt_password.ForeColor = Color.Black
    End Sub

    Private Sub txt_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_username.Focus()
    End Sub
End Class
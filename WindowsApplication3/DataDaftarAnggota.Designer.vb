<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataDaftarAnggota
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_pencarian = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dg_data_anggota = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rd_aktif = New System.Windows.Forms.RadioButton()
        Me.rd_tidak_aktif = New System.Windows.Forms.RadioButton()
        Me.cmb_level = New System.Windows.Forms.ComboBox()
        Me.txt_kd_user = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_data_anggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Location = New System.Drawing.Point(530, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 255)
        Me.Panel2.TabIndex = 65
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1174, 50)
        Me.Panel1.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "DATA ANGGOTA"
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Location = New System.Drawing.Point(611, 73)
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(208, 20)
        Me.txt_pencarian.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(545, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Username"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(99, 279)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(65, 30)
        Me.btn_cancel.TabIndex = 59
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(455, 279)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(65, 30)
        Me.btn_delete.TabIndex = 58
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(384, 279)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(65, 30)
        Me.btn_update.TabIndex = 57
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(313, 279)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(65, 30)
        Me.btn_insert.TabIndex = 56
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(20, 279)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(65, 30)
        Me.btn_add.TabIndex = 55
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'dg_data_anggota
        '
        Me.dg_data_anggota.AllowUserToAddRows = False
        Me.dg_data_anggota.AllowUserToDeleteRows = False
        Me.dg_data_anggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_data_anggota.Location = New System.Drawing.Point(542, 105)
        Me.dg_data_anggota.Name = "dg_data_anggota"
        Me.dg_data_anggota.ReadOnly = True
        Me.dg_data_anggota.Size = New System.Drawing.Size(588, 204)
        Me.dg_data_anggota.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Status"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(88, 136)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(432, 20)
        Me.txt_password.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(88, 101)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(432, 20)
        Me.txt_username.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Username"
        '
        'rd_aktif
        '
        Me.rd_aktif.AutoSize = True
        Me.rd_aktif.Location = New System.Drawing.Point(88, 202)
        Me.rd_aktif.Name = "rd_aktif"
        Me.rd_aktif.Size = New System.Drawing.Size(46, 17)
        Me.rd_aktif.TabIndex = 66
        Me.rd_aktif.TabStop = True
        Me.rd_aktif.Text = "Aktif"
        Me.rd_aktif.UseVisualStyleBackColor = True
        '
        'rd_tidak_aktif
        '
        Me.rd_tidak_aktif.AutoSize = True
        Me.rd_tidak_aktif.Location = New System.Drawing.Point(88, 225)
        Me.rd_tidak_aktif.Name = "rd_tidak_aktif"
        Me.rd_tidak_aktif.Size = New System.Drawing.Size(76, 17)
        Me.rd_tidak_aktif.TabIndex = 67
        Me.rd_tidak_aktif.TabStop = True
        Me.rd_tidak_aktif.Text = "Tidak Aktif"
        Me.rd_tidak_aktif.UseVisualStyleBackColor = True
        '
        'cmb_level
        '
        Me.cmb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_level.FormattingEnabled = True
        Me.cmb_level.Items.AddRange(New Object() {"Umum", "Anggota", "Petugas", "Kepala"})
        Me.cmb_level.Location = New System.Drawing.Point(88, 169)
        Me.cmb_level.Name = "cmb_level"
        Me.cmb_level.Size = New System.Drawing.Size(432, 21)
        Me.cmb_level.TabIndex = 68
        '
        'txt_kd_user
        '
        Me.txt_kd_user.Location = New System.Drawing.Point(88, 70)
        Me.txt_kd_user.Name = "txt_kd_user"
        Me.txt_kd_user.Size = New System.Drawing.Size(432, 20)
        Me.txt_kd_user.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Kode"
        '
        'DataDaftarAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 350)
        Me.Controls.Add(Me.txt_kd_user)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_level)
        Me.Controls.Add(Me.rd_tidak_aktif)
        Me.Controls.Add(Me.rd_aktif)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_pencarian)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dg_data_anggota)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DataDaftarAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataDaftarAnggota"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_data_anggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_pencarian As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents dg_data_anggota As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rd_aktif As RadioButton
    Friend WithEvents rd_tidak_aktif As RadioButton
    Friend WithEvents cmb_level As ComboBox
    Friend WithEvents txt_kd_user As TextBox
    Friend WithEvents Label5 As Label
End Class

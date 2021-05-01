<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataBuku
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_judul = New System.Windows.Forms.TextBox()
        Me.txt_pengarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_penerbit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_lokasi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dg_data_buku = New System.Windows.Forms.DataGridView()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_kd_buku = New System.Windows.Forms.TextBox()
        Me.txt_pencarian = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_stok = New System.Windows.Forms.NumericUpDown()
        CType(Me.dg_data_buku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_stok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Judul Buku"
        '
        'txt_judul
        '
        Me.txt_judul.Location = New System.Drawing.Point(87, 74)
        Me.txt_judul.Name = "txt_judul"
        Me.txt_judul.Size = New System.Drawing.Size(290, 20)
        Me.txt_judul.TabIndex = 1
        '
        'txt_pengarang
        '
        Me.txt_pengarang.Location = New System.Drawing.Point(87, 106)
        Me.txt_pengarang.Name = "txt_pengarang"
        Me.txt_pengarang.Size = New System.Drawing.Size(432, 20)
        Me.txt_pengarang.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pengarang"
        '
        'txt_penerbit
        '
        Me.txt_penerbit.Location = New System.Drawing.Point(87, 137)
        Me.txt_penerbit.Name = "txt_penerbit"
        Me.txt_penerbit.Size = New System.Drawing.Size(432, 20)
        Me.txt_penerbit.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Penerbit"
        '
        'txt_lokasi
        '
        Me.txt_lokasi.Location = New System.Drawing.Point(87, 168)
        Me.txt_lokasi.Name = "txt_lokasi"
        Me.txt_lokasi.Size = New System.Drawing.Size(432, 20)
        Me.txt_lokasi.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Lokasi Buku"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stok Buku"
        '
        'dg_data_buku
        '
        Me.dg_data_buku.AllowUserToAddRows = False
        Me.dg_data_buku.AllowUserToDeleteRows = False
        Me.dg_data_buku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_data_buku.Location = New System.Drawing.Point(541, 108)
        Me.dg_data_buku.Name = "dg_data_buku"
        Me.dg_data_buku.ReadOnly = True
        Me.dg_data_buku.Size = New System.Drawing.Size(588, 204)
        Me.dg_data_buku.TabIndex = 10
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(19, 282)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(65, 30)
        Me.btn_add.TabIndex = 11
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(312, 282)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(65, 30)
        Me.btn_insert.TabIndex = 12
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(383, 282)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(65, 30)
        Me.btn_update.TabIndex = 13
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(454, 282)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(65, 30)
        Me.btn_delete.TabIndex = 14
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(98, 282)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(65, 30)
        Me.btn_cancel.TabIndex = 15
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(391, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Kode"
        '
        'txt_kd_buku
        '
        Me.txt_kd_buku.Location = New System.Drawing.Point(428, 74)
        Me.txt_kd_buku.Name = "txt_kd_buku"
        Me.txt_kd_buku.Size = New System.Drawing.Size(91, 20)
        Me.txt_kd_buku.TabIndex = 17
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Location = New System.Drawing.Point(610, 76)
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(208, 20)
        Me.txt_pencarian.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(544, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Judul Buku"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1174, 50)
        Me.Panel1.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(14, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "DATA BUKU"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Location = New System.Drawing.Point(529, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 255)
        Me.Panel2.TabIndex = 21
        '
        'txt_stok
        '
        Me.txt_stok.Location = New System.Drawing.Point(87, 199)
        Me.txt_stok.Name = "txt_stok"
        Me.txt_stok.Size = New System.Drawing.Size(120, 20)
        Me.txt_stok.TabIndex = 22
        '
        'DataBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1155, 350)
        Me.Controls.Add(Me.txt_stok)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_pencarian)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_kd_buku)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dg_data_buku)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_lokasi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_penerbit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_pengarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_judul)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Buku"
        CType(Me.dg_data_buku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_stok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_judul As System.Windows.Forms.TextBox
    Friend WithEvents txt_pengarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_penerbit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_lokasi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dg_data_buku As System.Windows.Forms.DataGridView
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_kd_buku As System.Windows.Forms.TextBox
    Friend WithEvents txt_pencarian As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_stok As NumericUpDown
End Class

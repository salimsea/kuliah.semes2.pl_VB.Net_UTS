<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PencarianBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pencarian = New System.Windows.Forms.TextBox()
        Me.dg_pencarian_buku = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dg_pencarian_buku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Judul Buku"
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Location = New System.Drawing.Point(103, 75)
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(199, 20)
        Me.txt_pencarian.TabIndex = 1
        '
        'dg_pencarian_buku
        '
        Me.dg_pencarian_buku.AllowUserToAddRows = False
        Me.dg_pencarian_buku.AllowUserToDeleteRows = False
        Me.dg_pencarian_buku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pencarian_buku.Location = New System.Drawing.Point(30, 110)
        Me.dg_pencarian_buku.Name = "dg_pencarian_buku"
        Me.dg_pencarian_buku.ReadOnly = True
        Me.dg_pencarian_buku.Size = New System.Drawing.Size(709, 302)
        Me.dg_pencarian_buku.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PENCARIAN BUKU"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1211, 50)
        Me.Panel1.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication3.My.Resources.Resources.undraw_Location_search_re_ttoj
        Me.PictureBox1.Location = New System.Drawing.Point(757, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 247)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PencarianBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dg_pencarian_buku)
        Me.Controls.Add(Me.txt_pencarian)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PencarianBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian Data Buku Perpustakaan"
        CType(Me.dg_pencarian_buku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_pencarian As System.Windows.Forms.TextBox
    Friend WithEvents dg_pencarian_buku As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class

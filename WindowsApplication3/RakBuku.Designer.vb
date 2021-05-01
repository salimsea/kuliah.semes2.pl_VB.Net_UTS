<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RakBuku
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
        Me.lbl_rak_buku = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_rak_buku
        '
        Me.lbl_rak_buku.AutoSize = True
        Me.lbl_rak_buku.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_rak_buku.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rak_buku.ForeColor = System.Drawing.Color.White
        Me.lbl_rak_buku.Location = New System.Drawing.Point(0, 0)
        Me.lbl_rak_buku.Name = "lbl_rak_buku"
        Me.lbl_rak_buku.Size = New System.Drawing.Size(113, 39)
        Me.lbl_rak_buku.TabIndex = 0
        Me.lbl_rak_buku.Text = "Label1"
        '
        'RakBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(317, 79)
        Me.Controls.Add(Me.lbl_rak_buku)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RakBuku"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lokasi Rak Buku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_rak_buku As Label
End Class

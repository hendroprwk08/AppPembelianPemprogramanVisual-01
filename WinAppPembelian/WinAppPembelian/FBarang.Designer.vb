<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBarang
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.CariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tb_id_barang = New System.Windows.Forms.TextBox()
        Me.tb_barang = New System.Windows.Forms.TextBox()
        Me.tb_harga = New System.Windows.Forms.TextBox()
        Me.tb_keterangan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_bahan = New System.Windows.Forms.ComboBox()
        Me.cb_jenis = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem, Me.SimpanToolStripMenuItem, Me.HapusToolStripMenuItem, Me.ToolStripTextBox1, Me.CariToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(491, 27)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.UseWaitCursor = True
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(63, 23)
        Me.TambahToolStripMenuItem.Text = "Tambah"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(53, 23)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'CariToolStripMenuItem
        '
        Me.CariToolStripMenuItem.Name = "CariToolStripMenuItem"
        Me.CariToolStripMenuItem.Size = New System.Drawing.Size(40, 23)
        Me.CariToolStripMenuItem.Text = "Cari"
        '
        'tb_id_barang
        '
        Me.tb_id_barang.Location = New System.Drawing.Point(84, 60)
        Me.tb_id_barang.Name = "tb_id_barang"
        Me.tb_id_barang.Size = New System.Drawing.Size(100, 20)
        Me.tb_id_barang.TabIndex = 13
        '
        'tb_barang
        '
        Me.tb_barang.Location = New System.Drawing.Point(84, 86)
        Me.tb_barang.Name = "tb_barang"
        Me.tb_barang.Size = New System.Drawing.Size(173, 20)
        Me.tb_barang.TabIndex = 14
        '
        'tb_harga
        '
        Me.tb_harga.Location = New System.Drawing.Point(84, 110)
        Me.tb_harga.Name = "tb_harga"
        Me.tb_harga.Size = New System.Drawing.Size(100, 20)
        Me.tb_harga.TabIndex = 15
        '
        'tb_keterangan
        '
        Me.tb_keterangan.Location = New System.Drawing.Point(84, 136)
        Me.tb_keterangan.Multiline = True
        Me.tb_keterangan.Name = "tb_keterangan"
        Me.tb_keterangan.Size = New System.Drawing.Size(173, 47)
        Me.tb_keterangan.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Keterangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(284, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Jenis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Bahan"
        '
        'cb_bahan
        '
        Me.cb_bahan.FormattingEnabled = True
        Me.cb_bahan.Location = New System.Drawing.Point(342, 63)
        Me.cb_bahan.Name = "cb_bahan"
        Me.cb_bahan.Size = New System.Drawing.Size(121, 21)
        Me.cb_bahan.TabIndex = 23
        '
        'cb_jenis
        '
        Me.cb_jenis.FormattingEnabled = True
        Me.cb_jenis.Location = New System.Drawing.Point(342, 89)
        Me.cb_jenis.Name = "cb_jenis"
        Me.cb_jenis.Size = New System.Drawing.Size(121, 21)
        Me.cb_jenis.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 198)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(447, 150)
        Me.DataGridView1.TabIndex = 25
        '
        'FBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 363)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cb_jenis)
        Me.Controls.Add(Me.cb_bahan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_keterangan)
        Me.Controls.Add(Me.tb_harga)
        Me.Controls.Add(Me.tb_barang)
        Me.Controls.Add(Me.tb_id_barang)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FBarang"
        Me.Text = "FBarang"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TambahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HapusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CariToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tb_id_barang As System.Windows.Forms.TextBox
    Friend WithEvents tb_barang As System.Windows.Forms.TextBox
    Friend WithEvents tb_harga As System.Windows.Forms.TextBox
    Friend WithEvents tb_keterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_bahan As System.Windows.Forms.ComboBox
    Friend WithEvents cb_jenis As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class

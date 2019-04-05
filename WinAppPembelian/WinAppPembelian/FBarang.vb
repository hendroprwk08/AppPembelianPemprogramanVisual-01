Public Class FBarang

    Private Sub CariToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load bahan
        Dim sql As String = "select * from bahan order by id_bahan desc"
        Dim dt As New DataTable

        MDB.connOpen()
        dt = MDB.getAll(sql)

        With cb_bahan
            .DataSource = dt
            .ValueMember = "id_bahan"
            .DisplayMember = "bahan"
        End With

        'load jenis
        sql = "select * from jenis order by id_jenis desc"
        dt = New DataTable

        MDB.connOpen()
        dt = MDB.getAll(sql)

        With cb_jenis
            .DataSource = dt
            .ValueMember = "id_jenis"
            .DisplayMember = "jenis"
        End With

        showGrid() '<---------
    End Sub

    Private Sub TambahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahToolStripMenuItem.Click
        tb_id_barang.Text = "[otomatis]" : tb_id_barang.ReadOnly = False
        tb_harga.Text = ""
        tb_keterangan.Text = ""
        cb_bahan.SelectedIndex = -1 'kosongkan combobox
        cb_jenis.SelectedIndex = -1 'kosongkan combobox 
    End Sub

    Private Sub CariToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CariToolStripMenuItem.Click
        Dim sql As String = "select * from barang where " & _
                            "barang like '%" & ToolStripTextBox1.Text & "%'"
        Dim dt As New DataTable
        MDB.connOpen()
        dt = MDB.getAll(sql)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub HapusToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        If MsgBox("Hapus data " & tb_barang.Text & "?",
                  vbYesNo + vbCritical,
                  "Perhatian") = vbYes Then
            Try
                Dim sql As String
                sql = "delete from barang where id_barang = " & tb_id_barang.Text
                MDB.execute(sql)

                MsgBox("Data " & tb_barang.Text & " dihapus", vbCritical, "Pesan")

                'memanggil fungsi tambah 
                TambahToolStripMenuItem_Click(Nothing, Nothing)
                showGrid()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    Private Sub showGrid()
        Dim sql As String = "select * from barang order by id_barang desc"
        Dim dt As New DataTable

        MDB.connOpen()
        dt = MDB.getAll(sql)

        DataGridView1.DataSource = dt
    End Sub
End Class
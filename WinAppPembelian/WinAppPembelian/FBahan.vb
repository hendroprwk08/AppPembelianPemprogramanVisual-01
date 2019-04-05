Public Class FBahan

    Private Sub TambahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahToolStripMenuItem.Click
        tb_id_bahan.Text = ""
        tb_bahan.Text = ""
    End Sub

    Private Sub FJenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showGrid()
    End Sub

    Private Sub showGrid()
        'menampilkan data jenis
        Dim sql As String = "select * from bahan order by id_bahan desc"
        Dim dt As New DataTable

        MDB.connOpen()
        dt = MDB.getAll(sql)

        DataGridView1.DataSource = dt
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        If tb_id_bahan.TextLength = 0 And tb_bahan.TextLength = 0 Then
            Exit Sub
        End If

        Try
            Dim sql As String

            If tb_id_bahan.ReadOnly = True Then
                sql = "update bahan set bahan = '" & tb_bahan.Text & "' " & _
                    "where id_bahan = '" & tb_id_bahan.Text & "'"
            Else
                sql = "insert into bahan values ('" & tb_id_bahan.Text & "', " & _
                    "'" & tb_bahan.Text & "')"
            End If

            MDB.execute(sql)

            tb_id_bahan.Text = "" : tb_id_bahan.ReadOnly = False : tb_bahan.Text = ""

            showGrid()

            MsgBox("Data " & tb_bahan.Text & " tersimpan", , "Pesan")
        Catch ex As Exception
            Console.WriteLine()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'ambil index
        Dim idx As Integer = DataGridView1.CurrentRow.Index

        'tampilkan pada textbox
        tb_id_bahan.Text = DataGridView1.Rows(idx).Cells(0).Value.ToString
        tb_bahan.Text = DataGridView1.Rows(idx).Cells(1).Value.ToString

        'kunci id jenisnya biar ga bisa di ubah
        tb_id_bahan.ReadOnly = True
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        Try
            Dim sql As String
            sql = "delete from bahan where id_bahan = '" & tb_id_bahan.Text & "'"
            MDB.execute(sql)

            MsgBox("Data " & tb_bahan.Text & " dihapus", vbCritical, "Pesan")

            tb_id_bahan.Text = "" : tb_id_bahan.ReadOnly = False : tb_bahan.Text = ""
            showGrid()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub CariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CariToolStripMenuItem.Click
        Dim sql As String = "select * from bahan where id_bahan like '%" & ToolStripTextBox1.Text & "%' " &
                            "or bahan like '%" & ToolStripTextBox1.Text & "%' order by id_bahan desc"
        Dim dt As New DataTable

        MDB.connOpen()
        dt = MDB.getAll(sql)

        DataGridView1.DataSource = dt
    End Sub
End Class
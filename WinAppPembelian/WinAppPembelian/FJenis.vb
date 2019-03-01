Public Class FJenis

    Private Sub TambahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahToolStripMenuItem.Click
        tb_id_jenis.Text = ""
        tb_jenis.Text = ""
    End Sub

    Private Sub FJenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showGrid()
    End Sub

    Private Sub showGrid()
        'menampilkan data jenis
        Dim sql As String = "select * from jenis order by id_jenis desc"
        Dim dt As New DataTable

        MDB.connOpen()
        dt = MDB.getAll(sql)

        DataGridView1.DataSource = dt
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        If tb_id_jenis.TextLength = 0 And tb_jenis.TextLength = 0 Then
            Exit Sub
        End If

        Try
            Dim sql As String
            sql = "insert into jenis values ('" & tb_id_jenis.Text & "', " & _
                    "'" & tb_jenis.Text & "')"
            MDB.execute(sql)

            tb_id_jenis.Text = "" : tb_jenis.Text = ""

            showGrid()

            MsgBox("Data " & tb_jenis.Text & " tersimpan", , "Pesan")
        Catch ex As Exception
            Console.WriteLine()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'ambil index
        Dim idx As Integer = DataGridView1.CurrentRow.Index

        'tampilkan pada textbox
        tb_id_jenis.Text = DataGridView1.Rows(idx).Cells(0).Value.ToString
        tb_jenis.Text = DataGridView1.Rows(idx).Cells(1).Value.ToString

        'kunci id jenisnya biar ga bisa di ubah
        tb_id_jenis.ReadOnly = True
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        Try
            Dim sql As String
            sql = "delete from jenis where id_jenis = '" & tb_id_jenis.Text & "'"
            MDB.execute(sql)

            MsgBox("Data " & tb_jenis.Text & " dihapus", vbCritical, "Pesan")

            tb_id_jenis.Text = "" : tb_id_jenis.ReadOnly = False : tb_jenis.Text = ""
            showGrid()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
End Class
Public Class FMenu

    Private Sub JenisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisToolStripMenuItem.Click
        Dim f As FJenis = New FJenis()
        f.Show()

        f.MdiParent = Me
        'silakan lanjut form barang, bahan
    End Sub

    Private Sub BahanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BahanToolStripMenuItem.Click
        Dim f As FBahan = New FBahan()
        f.Show()

        f.MdiParent = Me
    End Sub

    Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.IsMdiContainer = True
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Dim f As FBarang = New FBarang()
        f.Show()

        f.MdiParent = Me
    End Sub
End Class
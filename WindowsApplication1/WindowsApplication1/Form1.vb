Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TextBox1.Text = "Belajar VB"
        TextBox1.Enabled = False
        Button1.Enabled = False
        ContextMenuStrip = ContextMenuStrip1
        IsMdiContainer = True
    End Sub

    Private Sub Coba1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Coba1ToolStripMenuItem.Click
        TextBox1.Enabled = True
        Button1.Enabled = True
    End Sub

    Private Sub Coba2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Coba2ToolStripMenuItem.Click
        TextBox1.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Form2.Show()
        Form2.MdiParent = Me
    End Sub

    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click
        Form3.Show()
        Form3.MdiParent = Me
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'kalimat = TextBox1.Text
        Form2.Label1.Text = TextBox1.Text
        Form2.Show()
        Form2.MdiParent = Me
        '192.168.123.30/aplikom excel 4 feb 2019
    End Sub
End Class

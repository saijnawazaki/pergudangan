Public Class main_menu

    Private Sub main_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = APP_TITLE
        Me.IsMdiContainer = True
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        product.MdiParent = Me
        product.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.MdiParent = Me
        about.Show()
    End Sub
End Class
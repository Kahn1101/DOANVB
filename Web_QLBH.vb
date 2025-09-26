Imports Microsoft.Office.Interop.PowerPoint
Imports System.IO

Public Class Web_QLBH
    Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DToolStripMenuItem.Click
        DangNhp.Show()
    End Sub

    Private Sub SảnPhẩm_Click(sender As Object, e As EventArgs) Handles SảnPhẩm.Click
        SanPham.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        KHACHHANG.Show()
    End Sub
End Class
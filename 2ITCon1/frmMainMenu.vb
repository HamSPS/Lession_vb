Public Class frmMainMenu
    Private Sub ອອກຈາກໂປຣແກຣມToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ອອກຈາກໂປຣແກຣມToolStripMenuItem.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນຫຼືບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub ຈດການຂມນToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຈດການຂມນToolStripMenuItem.Click
        frmMainData.MdiParent = Me
        frmMainData.Show()
        frmMainData.Dock = DockStyle.Fill
    End Sub

    Private Sub ການຂາຍToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ການຂາຍToolStripMenuItem.Click
        tbDepartment.MdiParent = Me
        tbDepartment.Show()
        tbDepartment.Dock = DockStyle.Fill
    End Sub

    Private Sub ການສງຊToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ການສງຊToolStripMenuItem.Click
        tbemployee.MdiParent = Me
        tbemployee.Show()
        tbemployee.Dock = DockStyle.Fill
    End Sub
End Class
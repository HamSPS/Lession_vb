Public Class frmMainData
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmMainData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub openForm(form As Form)
        form.MdiParent = frmMainMenu
        form.Show()
        form.Dock = DockStyle.Fill
        Me.Close()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        openForm(frmSuppliers)
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        openForm(frmEmployee)
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        openForm(frmCustomer)
    End Sub

    Private Sub btnUnit_Click(sender As Object, e As EventArgs) Handles btnUnit.Click
        openForm(frmUnit)
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        openForm(frmType)
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        openForm(frmProducts)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openForm(tbDepartment)
    End Sub
End Class
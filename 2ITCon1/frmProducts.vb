Imports System.IO

Public Class frmProducts
    Dim sqlP As New SQLProvider()
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim sql As String = "insert into tbProducts values(@id,@name,@qty,@price,@uid,@low,@tid,@img)"
        Dim val() As Object = {txtPID.Text, txtPName.Text, txtQty.Text, txtPrice.Text, cbounit.SelectedValue, txtInstock.Text, cboPType.SelectedValue, sqlP.getByteFromImg(PicProduct)}
        Dim pr() As String = {"@id", "@name", "@qty", "@price", "@uid", "@low", "@tid", "@img"}
        sqlP.InsertData(sql, pr, val)
        showData("")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmMainData.MdiParent = frmMainMenu
        frmMainData.Show()
        frmMainData.Dock = DockStyle.Fill
        Me.Close()
    End Sub

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData("")
        sqlP.cboBindingData(cbounit, "tbunit", "unitname", "unitid")
        sqlP.cboBindingData(cboPType, "tbtype", "typeName", "typeid")
    End Sub
    Private Sub showData(Str As String)
        Dim sqlstr = ""
        If Str <> "" Then
            sqlstr = " where proid like '" + Str + "%' OR proname like N'" + Str + "%'"
        End If
        dgvShow.DataSource = sqlP.LoadingData("select * from tbProducts")
        Dim strh() As String = {"ລະຫັດ", "ຊື່ສິນຄ້າ", "ຈຳນວນ", "ລາຄາ", "ລະຫັດຫົວໜ່ວຍ", "ຈຳນວນໜ້ອຍສຸດ", "ລະຫັດປະເພດ", "ຮູບພາບ"}
        sqlP.setHeaderText(dgvShow, strh)
    End Sub

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        Dim opfileDialog As New OpenFileDialog
        opfileDialog.Filter = "(image file *.png;*.gif;*.jpg)|*.png;*.gif;*.jpg"
        If opfileDialog.ShowDialog = DialogResult.OK Then
            PicProduct.Image = Image.FromFile(opfileDialog.FileName)
            PicProduct.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dgvShow_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvShow.CellMouseClick
        Dim cindex As Integer = dgvShow.CurrentRow.Index
        txtPID.Text = dgvShow.Item(0, cindex).Value.ToString
        txtPName.Text = dgvShow.Item(1, cindex).Value.ToString
        txtQty.Text = dgvShow.Item(2, cindex).Value.ToString
        txtPrice.Text = dgvShow.Item(3, cindex).Value.ToString
        cbounit.SelectedValue = dgvShow.Item(4, cindex).Value.ToString
        txtInstock.Text = dgvShow.Item(5, cindex).Value.ToString
        cboPType.SelectedValue = dgvShow.Item(6, cindex).Value.ToString
        Dim data As Byte() = dgvShow.Item(7, cindex).Value
        Dim ms As New MemoryStream(data)
        PicProduct.Image = Image.FromStream(ms)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim sql As String = "update tbProducts set proname=@name,qty=@qty,price=@price,unitid=@uid,lowqty=@low,typeid=@tid,proimg=@img where proid=@id"
        Dim val() As Object = {txtPID.Text, txtPName.Text, txtQty.Text, txtPrice.Text, cbounit.SelectedValue, txtInstock.Text, cboPType.SelectedValue, sqlP.getByteFromImg(PicProduct)}
        Dim pr() As String = {"@id", "@name", "@qty", "@price", "@uid", "@low", "@tid", "@img"}
        sqlP.UpdateData(sql, pr, val)
        showData("")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        sqlP.DeleteData("tbProducts", "proid", txtPID.Text)
        showData("")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        showData(txtSearch.Text)
    End Sub

    Private Sub txtPID_TextChanged(sender As Object, e As EventArgs) Handles txtPID.TextChanged

    End Sub

    Private Sub txtPName_TextChanged(sender As Object, e As EventArgs) Handles txtPName.TextChanged

    End Sub
End Class
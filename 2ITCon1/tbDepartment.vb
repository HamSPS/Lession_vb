Public Class tbDepartment
    Dim sqlP As New SQLProvider2()
    Private Sub tbDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub
    Private Sub showData()
        dgvshow.DataSource = sqlP.LoadingData("select * from tbDepartment")
        Dim strh() As String = {"ລະຫັດ", "ຊື່ພະແນກ", "ເບໂທ"}
        sqlP.setHeaderText(dgvshow, strh)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sql As String = "insert into tbDepartment values(@id,@name,@tel)"
        Dim val() As Object = {txtid.Text, txtname.Text, txttel.Text}
        Dim pr() As String = {"@id", "@name", "@tel"}
        sqlP.InsertData(sql, pr, val)
        showData()
    End Sub

    Private Sub dgvshow_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseClick
        Dim cindex As Integer = dgvshow.CurrentRow.Index
        txtid.Text = dgvshow.Item(0, cindex).Value.ToString
        txtname.Text = dgvshow.Item(1, cindex).Value.ToString
        txttel.Text = dgvshow.Item(2, cindex).Value.ToString

        txtid.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim sql As String = "update tbDepartment set deptName=@name,telephone=@tel where deptNO=@id"
        Dim val() As Object = {txtid.Text, txtname.Text, txttel.Text}
        Dim pr() As String = {"@id", "@name", "@tel"}
        sqlP.UpdateData(sql, pr, val)
        showData()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        sqlP.DeleteData("tbDepartment", "deptNO", txtid.Text)
        showData()
    End Sub
End Class
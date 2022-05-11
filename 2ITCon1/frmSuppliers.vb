Imports System.Data.SqlClient
Public Class frmSuppliers
    Dim conn As New SqlConnection()
    Dim cmd As New SqlCommand()
    Dim dr As SqlDataReader
    Dim strcon = "Data Source=DESKTOP-0S2K630;Initial Catalog=ITCon1;Integrated Security=True"
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            If MessageBox.Show("ຕ້ອງການເພີ່ມຂໍ້ມູນຫຼືບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim sql = "insert into tbsuppliers values(@id,@name,@contact,@address,@tel,@email)"
                cmd = New SqlCommand(sql, conn)
                With cmd.Parameters
                    .AddWithValue("@id", txtsupid.Text)
                    .AddWithValue("@name", txtsupname.Text)
                    .AddWithValue("@contact", txtcontact.Text)
                    .AddWithValue("@address", txtaddress.Text)
                    .AddWithValue("@tel", txtmobile.Text)
                    .AddWithValue("@email", txtemail.Text)
                End With
                cmd.ExecuteNonQuery()
                MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ")
                showData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(strcon)
        conn.Open()
        showData()
    End Sub
    Private Sub showData()
        Dim dt As New DataTable()
        cmd = New SqlCommand("select * from tbsuppliers", conn)
        dr = cmd.ExecuteReader
        dt.Load(dr)
        dgvshow.DataSource = dt
        With dgvshow
            .DataSource = dt
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ຊື່ບໍລິສັດ"
            .Columns(2).HeaderText = "ຊື່ຜູ້ຕິດຕໍ່"
            .Columns(3).HeaderText = "ທີ່ຢູ່"
            .Columns(4).HeaderText = "ເບີໂທ"
            .Columns(5).HeaderText = "ອີເມວ"
        End With
        ClearData()
        txtsupid.Enabled = True
    End Sub
    Private Sub ClearData()
        txtsupid.Clear()
        txtsupname.Clear()
        txtcontact.Clear()
        txtaddress.Clear()
        txtmobile.Clear()
        txtemail.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmMainData.MdiParent = frmMainMenu
        frmMainData.Show()
        frmMainData.Dock = DockStyle.Fill
        Me.Close()
    End Sub

    Private Sub dgvshow_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseClick
        Dim cindex As Integer = dgvshow.CurrentRow.Index
        txtsupid.Text = dgvshow.Item(0, cindex).Value.ToString
        txtsupname.Text = dgvshow.Item(1, cindex).Value.ToString
        txtcontact.Text = dgvshow.Item(2, cindex).Value.ToString
        txtaddress.Text = dgvshow.Item(3, cindex).Value.ToString
        txtmobile.Text = dgvshow.Item(4, cindex).Value.ToString
        txtemail.Text = dgvshow.Item(5, cindex).Value.ToString
        txtsupid.Enabled = False
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            If MessageBox.Show("ຕ້ອງການແກ້ໄຂຂໍ້ມູນຫຼືບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim sql = "update tbsuppliers set supname=@name,contactName=@contact,address=@address,telephone=@tel,email=@email where supid = @id"
                cmd = New SqlCommand(sql, conn)
                With cmd.Parameters
                    .AddWithValue("@id", txtsupid.Text)
                    .AddWithValue("@name", txtsupname.Text)
                    .AddWithValue("@contact", txtcontact.Text)
                    .AddWithValue("@address", txtaddress.Text)
                    .AddWithValue("@tel", txtmobile.Text)
                    .AddWithValue("@email", txtemail.Text)
                End With
                cmd.ExecuteNonQuery()
                MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສຳເລັດ")
                showData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Try
            If MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນຫຼືບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim sql = "delete from tbsuppliers where supid = @id"
                cmd = New SqlCommand(sql, conn)
                With cmd.Parameters
                    .AddWithValue("@id", txtsupid.Text)
                End With
                cmd.ExecuteNonQuery()
                MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສຳເລັດ")
                showData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
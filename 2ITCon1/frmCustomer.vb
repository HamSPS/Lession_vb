Imports System.Data.SqlClient
Public Class frmCustomer

    Dim conn As New SqlConnection()
    Dim cmd As New SqlCommand()
    Dim dr As SqlDataReader
    Dim strcon = "Data Source=DESKTOP-0S2K630;Initial Catalog=ITCon1;Integrated Security=True"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmMainData.MdiParent = frmMainMenu
        frmMainData.Show()
        frmMainData.Dock = DockStyle.Fill
        Me.Close()
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(strcon)
        conn.Open()
        showData()
    End Sub
    Private Sub showData()
        Dim dt As New DataTable()
        cmd = New SqlCommand("select * from tbcustomer", conn)
        dr = cmd.ExecuteReader
        dt.Load(dr)
        dgvshow.DataSource = dt
        clearData()

        With dgvshow
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ຊື່ ແລະ ນາມສະກຸນ"
            .Columns(2).HeaderText = "ທີ່ຢູ່"
            .Columns(3).HeaderText = "ເບີໂທຕິດຕໍ່"
            .Columns(4).HeaderText = "ອີເມວ"
            .Columns(5).HeaderText = "ເຟສບຸກ"
        End With
        txtid.Enabled = True
    End Sub
    Private Sub clearData()
        txtid.Clear()
        txtname.Clear()
        txtaddress.Clear()
        txtmobile.Clear()
        txtemail.Clear()
        txtfacebook.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim sql = "insert into tbcustomer values(@id,@name,@address,@mobile,@email,@facebook)"
            If MessageBox.Show("ທ່ານຕ້ອງການເພີ່ມຂໍ້ມູນ ຫຼື ບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New SqlCommand(sql, conn)
                With cmd
                    .Parameters.AddWithValue("@id", txtid.Text)
                    .Parameters.AddWithValue("@name", txtname.Text)
                    .Parameters.AddWithValue("@address", txtaddress.Text)
                    .Parameters.AddWithValue("@mobile", txtmobile.Text)
                    .Parameters.AddWithValue("@email", txtemail.Text)
                    .Parameters.AddWithValue("@facebook", txtfacebook.Text)

                    .ExecuteNonQuery()
                End With
                showData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim sql = "update tbcustomer set cusName = @name, cusaddress = @address,mobile = @mobile,email = @email,facebook = @facebook where cusid = @id"
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນ ຫຼື ບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New SqlCommand(sql, conn)
                With cmd
                    .Parameters.AddWithValue("@id", txtid.Text)
                    .Parameters.AddWithValue("@name", txtname.Text)
                    .Parameters.AddWithValue("@address", txtaddress.Text)
                    .Parameters.AddWithValue("@mobile", txtmobile.Text)
                    .Parameters.AddWithValue("@email", txtemail.Text)
                    .Parameters.AddWithValue("@facebook", txtfacebook.Text)

                    .ExecuteNonQuery()
                End With
                showData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Dim sql = "delete from tbcustomer where cusid = @id"
            If MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນ ຫຼື ບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New SqlCommand(sql, conn)
                With cmd
                    .Parameters.AddWithValue("@id", txtid.Text)

                    .ExecuteNonQuery()
                End With
                showData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvshow_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseClick
        Dim cindex As Integer = dgvshow.CurrentRow.Index
        txtid.Text = dgvshow.Item(0, cindex).Value.ToString
        txtname.Text = dgvshow.Item(1, cindex).Value.ToString
        txtaddress.Text = dgvshow.Item(2, cindex).Value.ToString
        txtmobile.Text = dgvshow.Item(3, cindex).Value.ToString
        txtemail.Text = dgvshow.Item(4, cindex).Value.ToString
        txtfacebook.Text = dgvshow.Item(5, cindex).Value.ToString

        txtid.Enabled = False
    End Sub
End Class
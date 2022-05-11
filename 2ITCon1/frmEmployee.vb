Imports System.Data.SqlClient
Public Class frmEmployee
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

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(strcon)
        conn.Open()
        showData()
    End Sub

    Private Sub showData()
        Dim dt As New DataTable()
        cmd = New SqlCommand("select * from tbemployees", conn)
        dr = cmd.ExecuteReader
        dt.Load(dr)
        dgvshow.DataSource = dt


        txtid.Enabled = True
        clearData()

        With dgvshow
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ຊື່ ແລະ ນາມສະກຸນ"
            .Columns(2).HeaderText = "ທີ່ຢູ່"
            .Columns(3).HeaderText = "ເລກບັດປະຈຳຕົວ"
            .Columns(4).HeaderText = "ເບີໂທ"
            .Columns(5).HeaderText = "ອີເມວ"
            .Columns(6).HeaderText = "ຊື່ຜູ້ຕິດຕໍ່"
            .Columns(7).HeaderText = "ເບີໂທຜູ້ຕິດຕໍ່"
        End With
    End Sub
    Private Sub clearData()
        txtid.Clear()
        txtname.Clear()
        txtpsNO.Clear()
        txtaddress.Clear()
        txtmobile.Clear()
        txtemail.Clear()
        txtcontact.Clear()
        txtTel.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim sql = "insert into tbemployees values(@id,@name,@address,@psNO,@mobile,@email,@contact,@tel)"
            If MessageBox.Show("ທ່ານຕ້ອງການເພີ່ມຂໍ້ມູນ ຫຼື ບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New SqlCommand(sql, conn)
                With cmd
                    .Parameters.AddWithValue("@id", txtid.Text)
                    .Parameters.AddWithValue("@name", txtname.Text)
                    .Parameters.AddWithValue("@address", txtaddress.Text)
                    .Parameters.AddWithValue("@psNO", txtpsNO.Text)
                    .Parameters.AddWithValue("@mobile", txtmobile.Text)
                    .Parameters.AddWithValue("@email", txtemail.Text)
                    .Parameters.AddWithValue("@contact", txtcontact.Text)
                    .Parameters.AddWithValue("@tel", txtTel.Text)

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
            Dim sql = "update tbemployees set empName = @name, empAddress = @address, personNo = @psNo, mobile = @mobile,email = @email,empContact = @contact,contact_tel = @tel where empid = @id"
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນ ຫຼື ບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New SqlCommand(sql, conn)
                With cmd
                    .Parameters.AddWithValue("@id", txtid.Text)
                    .Parameters.AddWithValue("@name", txtname.Text)
                    .Parameters.AddWithValue("@address", txtaddress.Text)
                    .Parameters.AddWithValue("@psNO", txtpsNO.Text)
                    .Parameters.AddWithValue("@mobile", txtmobile.Text)
                    .Parameters.AddWithValue("@email", txtemail.Text)
                    .Parameters.AddWithValue("@contact", txtcontact.Text)
                    .Parameters.AddWithValue("@tel", txtTel.Text)

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
            Dim sql = "delete from tbemployees where empid = @id"
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
        txtpsNO.Text = dgvshow.Item(3, cindex).Value.ToString
        txtmobile.Text = dgvshow.Item(4, cindex).Value.ToString
        txtemail.Text = dgvshow.Item(5, cindex).Value.ToString
        txtcontact.Text = dgvshow.Item(6, cindex).Value.ToString
        txtTel.Text = dgvshow.Item(7, cindex).Value.ToString


        txtid.Enabled = False
    End Sub
End Class
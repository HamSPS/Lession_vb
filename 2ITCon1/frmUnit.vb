Imports System.Data.SqlClient
Public Class frmUnit
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

    Private Sub frmUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(strcon)
        conn.Open()
        showData()
    End Sub
    Private Sub showData()
        Dim dt As New DataTable()
        cmd = New SqlCommand("select * from tbunit", conn)
        dr = cmd.ExecuteReader
        dt.Load(dr)
        dgvshow.DataSource = dt

        dgvshow.Columns(0).HeaderText = "ລະຫັດຫົວໜ່ວຍ"
        dgvshow.Columns(1).HeaderText = "ຊື່ຫົວໜ່ວຍ"

        txtid.Clear()
        txtname.Clear()
        txtid.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim sql = "insert into tbunit values(@id,@name)"
            If MessageBox.Show("ທ່ານຕ້ອງການເພີ່ມຂໍ້ມູນ ຫຼື ບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New SqlCommand(sql, conn)
                With cmd
                    .Parameters.AddWithValue("@id", txtid.Text)
                    .Parameters.AddWithValue("@name", txtname.Text)

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
            Dim sql = "update tbunit set unitname = @name where unitid = @id"
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນ ຫຼື ບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New SqlCommand(sql, conn)
                With cmd
                    .Parameters.AddWithValue("@id", txtid.Text)
                    .Parameters.AddWithValue("@name", txtname.Text)

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
            Dim sql = "delete from tbunit where unitid = @id"
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນ ຫຼື ບໍ່", "Warnning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
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

        txtid.Enabled = False
    End Sub
End Class
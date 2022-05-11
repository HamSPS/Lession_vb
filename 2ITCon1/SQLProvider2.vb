Imports System.Data.SqlClient
Imports System.IO
Public Class SQLProvider2
    Dim conn As New SqlConnection()
    Dim cmd As New SqlCommand()
    Dim dr As SqlDataReader
    Dim strcon = "Data Source=DESKTOP-0S2K630;Initial Catalog=HRDb;Integrated Security=True"

    Private Sub checkConnection()
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strcon
            .Open()
        End With
    End Sub
    Friend Function LoadingData(sql As String) As DataTable
        checkConnection()
        Dim dt As New DataTable()
        Try
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            dt.Load(dr)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function
    Friend Sub InsertData(sql As String, para() As String, val() As Object)
        checkConnection()
        Try
            cmd = New SqlCommand(sql, conn)
            For i = 0 To para.Length - 1
                cmd.Parameters.AddWithValue(para(i), val(i))
            Next
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Friend Sub DeleteData(tb As String, id As String, val As String)
        checkConnection()
        Try
            If MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນຫຼືບໍ່", "Question",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New SqlCommand("delete from " + tb + " where " + id + "=@id", conn)
                cmd.Parameters.AddWithValue("@id", val)
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Friend Sub UpdateData(sql As String, para() As String, val() As Object)
        checkConnection()
        Try
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນຫຼືບໍ່", "Question",
                         MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New SqlCommand(sql, conn)
                For i = 0 To para.Length - 1
                    cmd.Parameters.AddWithValue(para(i), val(i))
                Next
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Friend Function getByteFromImg(pic As PictureBox) As Byte()
        Dim ms As New MemoryStream()
        pic.Image.Save(ms, pic.Image.RawFormat)
        Dim bt() As Byte = ms.GetBuffer()
        Return bt
    End Function
    Friend Sub cboBindingData(cbo As ComboBox,
                tbn As String, cold As String, colVa As String)
        cbo.DataSource = LoadingData("select * from " + tbn)
        cbo.DisplayMember = cold
        cbo.ValueMember = colVa
    End Sub
    Friend Sub setHeaderText(dgv As DataGridView, strh() As String)
        For i = 0 To strh.Length - 1
            dgv.Columns(i).HeaderText = strh(i)
        Next
    End Sub
End Class

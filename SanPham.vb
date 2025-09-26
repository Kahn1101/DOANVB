Imports Microsoft.Data.SqlClient
Public Class SanPham
    Dim ket_noi As SqlConnection
    Dim viTriHienTai As Integer = 0
    Private Sub SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ket_noi = New SqlConnection("Data Source=DESKTOP-BOVI4K2;Initial Catalog=QLBHTH;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")
        ket_noi.Open()
        Dim Adapter As New SqlDataAdapter("Select * From SANPHAM", ket_noi)
        Dim DataSet As New DataSet()
        Adapter.Fill(DataSet, "SANPHAM")
        Data_MH.DataSource = DataSet.Tables("SANPHAM")


        viTriHienTai = 0

    End Sub

    Private Sub Load_dulieu()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter("Select * From SANPHAM", ket_noi)
        da.Fill(dt)
        Data_MH.DataSource = dt
    End Sub

    Private Sub CapNhatDataGridView()
        If Data_MH.Rows.Count > 0 AndAlso viTriHienTai >= 0 AndAlso viTriHienTai < Data_MH.Rows.Count Then
            Data_MH.Rows(viTriHienTai).Selected = True
            Data_MH.CurrentCell = Data_MH.Rows(viTriHienTai).Cells(0)
        End If
    End Sub

    Private Sub Thêm_Click(sender As Object, e As EventArgs) Handles Thêm.Click

        If TxtMSP.Text.Trim() = "" Then
            MsgBox("Khóa chính không được để trống", vbYes, "Chú ý...")
            TxtMSP.Focus()
            Exit Sub
        End If

        Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM SANPHAM WHERE MÃ_Sản_Phẩm=@MÃ_Sản_Phẩm", ket_noi)
        SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@MÃ_Sản_Phẩm", TxtMSP.Text.Trim())
        Dim Db_Check As New DataTable
        SQL_KiemTra.Fill(Db_Check)
        If Db_Check.Rows.Count > 0 Then
            MsgBox("Mã  này đã có!", vbYes, "Nhập lại.")

            TxtMSP.Clear()
            TxtTSP.Clear()
            TxtDG.Clear()
            TxtSL.Clear()

            TxtMSP.Focus()

            Exit Sub
        End If

        Try

            If ket_noi.State = ConnectionState.Closed Then
                ket_noi.Open()
            End If

            Dim SQL_DangKy As New SqlCommand("INSERT INTO SANPHAM (MÃ_Sản_Phẩm , Tên_Sản_Phẩm, Đơn_Giá, Số_Lượng) VALUES (@MÃ_Sản_Phẩm,@Tên_Sản_Phẩm, @Đơn_Giá, @Số_Lượng)", ket_noi)
            SQL_DangKy.Parameters.AddWithValue("@MÃ_Sản_Phẩm", TxtMSP.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@Tên_Sản_Phẩm", TxtTSP.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@Đơn_Giá", TxtDG.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@Số_Lượng", TxtSL.Text.Trim())

            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Thêm thành công!", vbYes, "Chúc mừng.")

            Load_dulieu()


            TxtMSP.Clear()
            TxtTSP.Clear()
            TxtDG.Clear()
            TxtSL.Clear()

            TxtMSP.Focus()

        Catch ex As SqlException
            MsgBox("Lỗi SQL: " & ex.Message, vbYes, "Lỗi")
        Finally
            ket_noi.Close()
        End Try
    End Sub
    Private Sub xoa_Click(sender As Object, e As EventArgs) Handles xoa.Click
        Dim masanpham As String = InputBox("Nhập mã sản phẩm:", "Xóa sản phẩm")

        If masanpham = "" Then
            MessageBox.Show("Bạn chưa nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa sản phẩm  này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM SANPHAM WHERE MÃ_Sản_Phẩm = @MÃ_Sản_Phẩm"
                Dim command As New SqlCommand(query, ket_noi)
                command.Parameters.AddWithValue("@MÃ_Sản_Phẩm", masanpham)


                If ket_noi.State = ConnectionState.Open Then
                    ket_noi.Close()
                End If

                ket_noi.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                ket_noi.Close()

                If rowsAffected > 0 Then
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_dulieu()
                Else
                    MessageBox.Show("Không tìm thấy sản phẩm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MessageBox.Show("Lỗi khi xóa: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally

                If ket_noi.State = ConnectionState.Open Then
                    ket_noi.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub Sua_Click(sender As Object, e As EventArgs) Handles Sua.Click
        Dim masanpham As String = InputBox("Nhập mã khách hàng cần sửa:", "Sửa Khách Hàng")
        If masanpham = "" Then
            MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM SANPHAM WHERE MÃ_Sản_Phẩm = @MÃ_Sản_Phẩm"
        Dim command As New SqlCommand(query, ket_noi)
        command.Parameters.AddWithValue("@MÃ_Sản_Phẩm", masanpham)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            TxtMSP.Text = table.Rows(0)("MÃ_Sản_Phẩm").ToString()
            TxtTSP.Text = table.Rows(0)("Tên_Sản_Phẩm").ToString()
            TxtDG.Text = table.Rows(0)("Đơn_Giá").ToString()
            TxtSL.Text = table.Rows(0)("Số_Lượng").ToString()


            TxtMSP.Enabled = True
            TxtTSP.Enabled = True
            TxtDG.Enabled = True
            TxtSL.Enabled = True



        Else
            MessageBox.Show("Mã khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub luu_Click(sender As Object, e As EventArgs) Handles luu.Click
        Try

            If ket_noi.State = ConnectionState.Closed Then
                ket_noi.Open()
            End If

            Dim Sql As String = "UPDATE SANPHAM SET Tên_Sản_Phẩm=@Tên_Sản_Phẩm , Đơn_Giá=@Đơn_Giá, Số_Lượng=@Số_Lượng WHERE MÃ_Sản_Phẩm=@MÃ_Sản_Phẩm "
            Using Cmd As New SqlCommand(Sql, ket_noi)
                Cmd.Parameters.AddWithValue("@MÃ_Sản_Phẩm", TxtMSP.Text)
                Cmd.Parameters.AddWithValue("@Tên_Sản_Phẩm", TxtTSP.Text)
                Cmd.Parameters.AddWithValue("@Đơn_Giá", TxtDG.Text)
                Cmd.Parameters.AddWithValue("@Số_Lượng", TxtSL.Text)

                txtMSP.Clear()
                TxtTSP.Clear()
                TxtSL.Clear()
                TxtDG.Clear()

                TxtMSP.Focus()

                Dim result As Integer = Cmd.ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Cập nhật thành công!", vbYes, "Thông báo")
                    Load_dulieu()
                Else
                    MsgBox("Không thể lưu, có thể mã Sản tồn tại!", vbYes, "Lỗi")
                End If
            End Using

            ket_noi.Close()
        Catch ex As Exception
            MsgBox("Lỗi SQL: " & ex.Message, vbYes, "Lỗi")
        End Try
    End Sub
End Class
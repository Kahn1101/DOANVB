Imports Microsoft.Data.SqlClient
Public Class KHACHHANG
    Dim ket_noi As SqlConnection
    Dim viTriHienTai As Integer = 0

    Private Sub KHACHHANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ket_noi = New SqlConnection("Data Source=DESKTOP-BOVI4K2;Initial Catalog=QLBHTH;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")
        ket_noi.Open()
        Dim Adapter As New SqlDataAdapter("Select * From FKHACHHANG", ket_noi)
        Dim DataSet As New DataSet()
        Adapter.Fill(DataSet, "FKHACHHANG")
        Data_DS.DataSource = DataSet.Tables("FKHACHHANG")
    End Sub

    Private Sub Load_dulieu()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter("Select * From FKHACHHANG", ket_noi)
        da.Fill(dt)
        Data_DS.DataSource = dt
    End Sub
    Private Sub CapNhatDataGridView()
        If Data_DS.Rows.Count > 0 AndAlso viTriHienTai >= 0 AndAlso viTriHienTai < Data_DS.Rows.Count Then
            Data_DS.Rows(viTriHienTai).Selected = True
            Data_DS.CurrentCell = Data_DS.Rows(viTriHienTai).Cells(0)
        End If
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mKhachHang As String = InputBox("Nhập mã khách hàng cần tìm:", "Tìm Kiếm Khách Hàng")

        If mKhachHang = "" Then
            MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim query As String = "SELECT * FROM FKHACHHANG WHERE MaKhachHang = @MaKhachHang"
        Dim command As New SqlCommand(query, ket_noi)
        command.Parameters.AddWithValue("@MaKhachHang", mKhachHang)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            MKH.Text = table.Rows(0)("MaKhachHang").ToString()
            TKH.Text = table.Rows(0)("TenKhachHang").ToString()
            DCKH.Text = table.Rows(0)("ĐiaChi").ToString()
            SDT.Text = table.Rows(0)("SDT").ToString()


            For Each row As DataGridViewRow In Data_DS.Rows
                If row.Cells("MaKhachHang").Value.ToString() = mKhachHang Then
                    row.Selected = True
                    Data_DS.CurrentCell = row.Cells(0)
                    Exit For
                End If
            Next
        Else
            MessageBox.Show("Không tìm thấy khách hàng có mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Themm_Click(sender As Object, e As EventArgs) Handles Themm.Click
        If MKH.Text.Trim() = "" Then
            MsgBox("Khóa chính không được để trống", vbYes, "Chú ý...")
            MKH.Focus()
            Exit Sub
        End If

        Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM FKHACHHANG WHERE MaKhachHang=@MaKhachHang", ket_noi)
        SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@MaKhachHang", MKH.Text.Trim())
        Dim Db_Check As New DataTable
        SQL_KiemTra.Fill(Db_Check)
        If Db_Check.Rows.Count > 0 Then
            MsgBox("Mã khách này đã có!", vbYes, "Nhập lại đi.")

            MKH.Clear()
            TKH.Clear()
            DCKH.Clear()
            SDT.Clear()

            MKH.Focus()

            Exit Sub
        End If

        Try
            If ket_noi.State = ConnectionState.Closed Then
                ket_noi.Open()
            End If

            Dim SQL_DangKy As New SqlCommand("INSERT INTO FKHACHHANG (MaKhachHang, TenKhachHang, ĐiaChi, SDT) VALUES (@MaKhachHang,@TenKhachHang, @ĐiaChi, @SDT)", ket_noi)
            SQL_DangKy.Parameters.AddWithValue("@MaKhachHang", MKH.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@TenKhachHang", TKH.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@ĐiaChi", DCKH.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@SDT", SDT.Text.Trim())

            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Thêm thành công!", vbYes, "Chúc mừng.")

            Load_dulieu()

            MKH.Clear()
            TKH.Clear()
            DCKH.Clear()
            SDT.Clear()

            MKH.Focus()

        Catch ex As SqlException
            MsgBox("Lỗi SQL: " & ex.Message, vbYes, "Lỗi")
        Finally
            ket_noi.Close()
        End Try
    End Sub

    Private Sub sua_Click(sender As Object, e As EventArgs) Handles sua.Click
        Dim maKhachHang As String = InputBox("Nhập mã khách hàng cần sửa:", "Sửa Khách Hàng")
        If maKhachHang = "" Then
            MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim query As String = "SELECT * FROM FKHACHHANG  WHERE MaKhachHang = @MaKhachHang"
        Dim command As New SqlCommand(query, ket_noi)
        command.Parameters.AddWithValue("@MaKhachHang", maKhachHang)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            MKH.Text = table.Rows(0)("MaKhachHang").ToString()
            TKH.Text = table.Rows(0)("TenKhachHang").ToString()
            DCKH.Text = table.Rows(0)("ĐiaChi").ToString()
            SDT.Text = table.Rows(0)("SDT").ToString()


            TKH.Enabled = True
            DCKH.Enabled = True
            SDT.Enabled = True


        Else
            MessageBox.Show("Mã khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Luu_Click(sender As Object, e As EventArgs) Handles Luu.Click
        Try

            If ket_noi.State = ConnectionState.Closed Then
                ket_noi.Open()
            End If

            Dim Sql As String = "UPDATE FKHACHHANG SET TenKhachHang=@TenKhachHang,ĐiaChi=@ĐiaChi, SDT=@SDT WHERE MaKhachHang=@MaKhachHang"
            Using Cmd As New SqlCommand(Sql, ket_noi)
                Cmd.Parameters.AddWithValue("@MaKhachHang", MKH.Text)
                Cmd.Parameters.AddWithValue("@TenKhachHang", TKH.Text)
                Cmd.Parameters.AddWithValue("@ĐiaChi", DCKH.Text)
                Cmd.Parameters.AddWithValue("@SDT", SDT.Text)

                MKH.Clear()
                TKH.Clear()
                DCKH.Clear()
                SDT.Clear()

                MKH.Focus()

                Dim result As Integer = Cmd.ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Cập nhật thành công!", vbYes, "Thông báo")
                    Load_dulieu() ' Làm mới DataGridView
                Else
                    MsgBox("Không thể lưu, có thể mã khách không tồn tại!", vbYes, "Lỗi")
                End If
            End Using

            ket_noi.Close()
        Catch ex As Exception
            MsgBox("Lỗi SQL: " & ex.Message, vbYes, "Lỗi")
        End Try
    End Sub

    Private Sub xoa_Click(sender As Object, e As EventArgs) Handles xoa.Click
        Dim mKhachHang As String = InputBox("Nhập mã khách hàng cần xóa:", "Xóa Khách Hàng")

        If mKhachHang = "" Then
            MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Xác nhận xóa
        If MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM FKHACHHANG WHERE MaKhachHang =@MaKhachHang"
                Dim command As New SqlCommand(query, ket_noi)
                command.Parameters.AddWithValue("@MaKhachHang", mKhachHang)

                ' Kiểm tra trạng thái kết nối trước khi mở
                If ket_noi.State = ConnectionState.Open Then
                    ket_noi.Close()
                End If

                ket_noi.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                ket_noi.Close()

                If rowsAffected > 0 Then
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_dulieu() ' Cập nhật lại danh sách
                Else
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
End Class
Imports Microsoft.Data.SqlClient
Public Class DangNhp
    Dim ket_noi As SqlConnection
    Private Sub DangNhp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ket_noi = New SqlConnection("Data Source=DESKTOP-BOVI4K2;Initial Catalog=QLBHTH;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")
        ket_noi.Open()
    End Sub
    Private Sub DN_Click(sender As Object, e As EventArgs) Handles DN.Click
        If TxtTenDN.Text.Trim() = "" Then
            MsgBox("Khong de chong")
            Exit Sub
        End If
        Dim SQL As New SqlDataAdapter("SELECT * FROM TaiKhoan WHERE TDN=@TDN AND MatKhau=@MatKhau", ket_noi)
        SQL.SelectCommand.Parameters.AddWithValue("@TDN", TxtTenDN.Text.Trim())
        SQL.SelectCommand.Parameters.AddWithValue("@MatKhau", TxtMatkhau.Text)

        Dim Db As New DataTable
        SQL.Fill(Db)
        If Db.Rows.Count > 0 Then
            MsgBox("Đã Đăng Nhập Thành Công!")
            Dim Lienket As SanPham = New SanPham
            Lienket.Show()
            Me.Hide()
        Else
            MsgBox("Sai Tài Khoản Hoặc Mật  Khẩu")
        End If
    End Sub


End Class

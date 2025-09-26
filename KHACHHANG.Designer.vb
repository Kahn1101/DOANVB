<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KHACHHANG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Data_DS = New DataGridView()
        xoa = New Button()
        Button1 = New Button()
        sua = New Button()
        Thoat = New Button()
        MKH = New TextBox()
        TKH = New TextBox()
        SDT = New TextBox()
        DCKH = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Themm = New Button()
        Luu = New Button()
        CType(Data_DS, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Data_DS
        ' 
        Data_DS.BackgroundColor = Color.White
        Data_DS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_DS.Location = New Point(164, 47)
        Data_DS.Name = "Data_DS"
        Data_DS.RowHeadersWidth = 51
        Data_DS.Size = New Size(785, 280)
        Data_DS.TabIndex = 0
        ' 
        ' xoa
        ' 
        xoa.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        xoa.ForeColor = Color.Blue
        xoa.Location = New Point(696, 419)
        xoa.Name = "xoa"
        xoa.Size = New Size(128, 31)
        xoa.TabIndex = 1
        xoa.Text = "Xóa"
        xoa.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Blue
        Button1.Location = New Point(696, 468)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 31)
        Button1.TabIndex = 2
        Button1.Text = "Tìm Kiếm"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' sua
        ' 
        sua.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sua.ForeColor = Color.Blue
        sua.Location = New Point(868, 365)
        sua.Name = "sua"
        sua.Size = New Size(128, 31)
        sua.TabIndex = 3
        sua.Text = "Sửa"
        sua.UseVisualStyleBackColor = True
        ' 
        ' Thoat
        ' 
        Thoat.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Thoat.ForeColor = Color.Blue
        Thoat.Location = New Point(868, 468)
        Thoat.Name = "Thoat"
        Thoat.Size = New Size(128, 31)
        Thoat.TabIndex = 4
        Thoat.Text = "Thoát"
        Thoat.UseVisualStyleBackColor = True
        ' 
        ' MKH
        ' 
        MKH.Location = New Point(153, 368)
        MKH.Name = "MKH"
        MKH.Size = New Size(161, 27)
        MKH.TabIndex = 5
        ' 
        ' TKH
        ' 
        TKH.Location = New Point(470, 365)
        TKH.Name = "TKH"
        TKH.Size = New Size(161, 27)
        TKH.TabIndex = 6
        ' 
        ' SDT
        ' 
        SDT.Location = New Point(470, 439)
        SDT.Name = "SDT"
        SDT.Size = New Size(161, 27)
        SDT.TabIndex = 7
        ' 
        ' DCKH
        ' 
        DCKH.Location = New Point(153, 439)
        DCKH.Name = "DCKH"
        DCKH.Size = New Size(161, 27)
        DCKH.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 367)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 25)
        Label1.TabIndex = 9
        Label1.Text = "Mã Khách Hàng"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(316, 367)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 25)
        Label2.TabIndex = 10
        Label2.Text = "Tên Khách Hàng"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(10, 439)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 25)
        Label3.TabIndex = 11
        Label3.Text = "Địa Chỉ"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(320, 441)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 25)
        Label4.TabIndex = 12
        Label4.Text = "Số Điện Thoại"
        ' 
        ' Themm
        ' 
        Themm.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Themm.ForeColor = Color.Blue
        Themm.Location = New Point(696, 368)
        Themm.Name = "Themm"
        Themm.Size = New Size(128, 31)
        Themm.TabIndex = 13
        Themm.Text = "Thêm"
        Themm.UseVisualStyleBackColor = True
        ' 
        ' Luu
        ' 
        Luu.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Luu.ForeColor = Color.Blue
        Luu.Location = New Point(868, 419)
        Luu.Name = "Luu"
        Luu.Size = New Size(128, 31)
        Luu.TabIndex = 14
        Luu.Text = "LUU"
        Luu.UseVisualStyleBackColor = True
        ' 
        ' KHACHHANG
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1135, 520)
        Controls.Add(Luu)
        Controls.Add(Themm)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DCKH)
        Controls.Add(SDT)
        Controls.Add(TKH)
        Controls.Add(MKH)
        Controls.Add(Thoat)
        Controls.Add(sua)
        Controls.Add(Button1)
        Controls.Add(xoa)
        Controls.Add(Data_DS)
        Name = "KHACHHANG"
        Text = "KHACHHANG"
        CType(Data_DS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Data_DS As DataGridView
    Friend WithEvents xoa As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents sua As Button
    Friend WithEvents Thoat As Button
    Friend WithEvents MKH As TextBox
    Friend WithEvents TKH As TextBox
    Friend WithEvents SDT As TextBox
    Friend WithEvents DCKH As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Themm As Button
    Friend WithEvents Luu As Button
End Class

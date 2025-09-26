<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanPham
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
        Data_MH = New DataGridView()
        Thêm = New Button()
        Sua = New Button()
        xoa = New Button()
        TxtMSP = New TextBox()
        TxtTSP = New TextBox()
        TxtSL = New TextBox()
        TxtDG = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        luu = New Button()
        CType(Data_MH, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Data_MH
        ' 
        Data_MH.BackgroundColor = SystemColors.ButtonHighlight
        Data_MH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_MH.Location = New Point(128, 24)
        Data_MH.Name = "Data_MH"
        Data_MH.RowHeadersWidth = 51
        Data_MH.Size = New Size(628, 310)
        Data_MH.TabIndex = 0
        ' 
        ' Thêm
        ' 
        Thêm.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Thêm.ForeColor = Color.Blue
        Thêm.Location = New Point(145, 377)
        Thêm.Name = "Thêm"
        Thêm.Size = New Size(129, 31)
        Thêm.TabIndex = 1
        Thêm.Text = "Thêm SP"
        Thêm.UseVisualStyleBackColor = True
        ' 
        ' Sua
        ' 
        Sua.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Sua.ForeColor = Color.Blue
        Sua.Location = New Point(321, 377)
        Sua.Name = "Sua"
        Sua.Size = New Size(129, 31)
        Sua.TabIndex = 2
        Sua.Text = "Sửa SP"
        Sua.UseVisualStyleBackColor = True
        ' 
        ' xoa
        ' 
        xoa.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        xoa.ForeColor = Color.Blue
        xoa.Location = New Point(499, 377)
        xoa.Name = "xoa"
        xoa.Size = New Size(129, 31)
        xoa.TabIndex = 3
        xoa.Text = "Xóa SP"
        xoa.UseVisualStyleBackColor = True
        ' 
        ' TxtMSP
        ' 
        TxtMSP.Location = New Point(145, 427)
        TxtMSP.Name = "TxtMSP"
        TxtMSP.Size = New Size(160, 27)
        TxtMSP.TabIndex = 4
        ' 
        ' TxtTSP
        ' 
        TxtTSP.Location = New Point(468, 427)
        TxtTSP.Name = "TxtTSP"
        TxtTSP.Size = New Size(160, 27)
        TxtTSP.TabIndex = 5
        ' 
        ' TxtSL
        ' 
        TxtSL.Location = New Point(145, 485)
        TxtSL.Name = "TxtSL"
        TxtSL.Size = New Size(160, 27)
        TxtSL.TabIndex = 6
        ' 
        ' TxtDG
        ' 
        TxtDG.Location = New Point(468, 485)
        TxtDG.Name = "TxtDG"
        TxtDG.Size = New Size(160, 27)
        TxtDG.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(12, 426)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 25)
        Label1.TabIndex = 8
        Label1.Text = "Mã Sản Phẩm"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(321, 429)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 25)
        Label2.TabIndex = 9
        Label2.Text = "Tên Sản  Phẩm"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(11, 487)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 25)
        Label3.TabIndex = 10
        Label3.Text = "Số Lượng"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Blue
        Label4.Location = New Point(321, 487)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 25)
        Label4.TabIndex = 11
        Label4.Text = "Đơn Giá"
        ' 
        ' luu
        ' 
        luu.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        luu.ForeColor = Color.Blue
        luu.Location = New Point(11, 377)
        luu.Name = "luu"
        luu.Size = New Size(129, 31)
        luu.TabIndex = 12
        luu.Text = "Luu"
        luu.UseVisualStyleBackColor = True
        ' 
        ' SanPham
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(897, 550)
        Controls.Add(luu)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtDG)
        Controls.Add(TxtSL)
        Controls.Add(TxtTSP)
        Controls.Add(TxtMSP)
        Controls.Add(xoa)
        Controls.Add(Sua)
        Controls.Add(Thêm)
        Controls.Add(Data_MH)
        Name = "SanPham"
        Text = "SanPham"
        CType(Data_MH, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Data_MH As DataGridView
    Friend WithEvents Thêm As Button
    Friend WithEvents Sua As Button
    Friend WithEvents xoa As Button
    Friend WithEvents TxtMSP As TextBox
    Friend WithEvents TxtTSP As TextBox
    Friend WithEvents TxtSL As TextBox
    Friend WithEvents TxtDG As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents luu As Button
End Class

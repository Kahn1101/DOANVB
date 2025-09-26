<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DangNhp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DangNhp))
        DN = New Button()
        Button2 = New Button()
        TxtTenDN = New TextBox()
        TxtMatkhau = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' DN
        ' 
        DN.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        DN.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DN.ForeColor = Color.Blue
        DN.Location = New Point(188, 317)
        DN.Name = "DN"
        DN.Size = New Size(151, 39)
        DN.TabIndex = 0
        DN.Text = "Đăng Nhập"
        DN.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Blue
        Button2.Location = New Point(433, 317)
        Button2.Name = "Button2"
        Button2.Size = New Size(151, 39)
        Button2.TabIndex = 1
        Button2.Text = "Đăng Ký"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TxtTenDN
        ' 
        TxtTenDN.BackColor = Color.White
        TxtTenDN.Location = New Point(305, 119)
        TxtTenDN.Name = "TxtTenDN"
        TxtTenDN.Size = New Size(229, 27)
        TxtTenDN.TabIndex = 2
        ' 
        ' TxtMatkhau
        ' 
        TxtMatkhau.Location = New Point(305, 193)
        TxtMatkhau.Name = "TxtMatkhau"
        TxtMatkhau.Size = New Size(229, 27)
        TxtMatkhau.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(167, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 4
        Label1.Text = "Tài Khoản"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(167, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 5
        Label2.Text = "Mật Khẩu"
        ' 
        ' DangNhp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtMatkhau)
        Controls.Add(TxtTenDN)
        Controls.Add(Button2)
        Controls.Add(DN)
        Name = "DangNhp"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DN As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtTenDN As TextBox
    Friend WithEvents TxtMatkhau As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class

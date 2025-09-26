<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Web_QLBH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Web_QLBH))
        MenuStrip1 = New MenuStrip()
        DToolStripMenuItem = New ToolStripMenuItem()
        SảnPhẩm = New ToolStripMenuItem()
        KháchHàngToolStripMenuItem = New ToolStripMenuItem()
        ThoátToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DToolStripMenuItem, SảnPhẩm, KháchHàngToolStripMenuItem, ThoátToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1088, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DToolStripMenuItem
        ' 
        DToolStripMenuItem.Name = "DToolStripMenuItem"
        DToolStripMenuItem.Size = New Size(99, 24)
        DToolStripMenuItem.Text = "Đăng Nhập"
        ' 
        ' SảnPhẩm
        ' 
        SảnPhẩm.Name = "SảnPhẩm"
        SảnPhẩm.Size = New Size(88, 24)
        SảnPhẩm.Text = "Sản Phẩm"
        ' 
        ' KháchHàngToolStripMenuItem
        ' 
        KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        KháchHàngToolStripMenuItem.Size = New Size(103, 24)
        KháchHàngToolStripMenuItem.Text = "Khách Hàng"
        ' 
        ' ThoátToolStripMenuItem
        ' 
        ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        ThoátToolStripMenuItem.Size = New Size(61, 24)
        ThoátToolStripMenuItem.Text = "Thoát"
        ' 
        ' Web_QLBH
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1088, 460)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Web_QLBH"
        Text = "Web_QLBH"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SảnPhẩm As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
End Class

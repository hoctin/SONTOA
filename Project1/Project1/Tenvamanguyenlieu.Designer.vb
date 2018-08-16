<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tenvamanguyenlieu
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvtenvama = New System.Windows.Forms.DataGridView()
        Me.NlnhapBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaNL = New System.Windows.Forms.TextBox()
        Me.txtTenNL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGhichu = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New CButtonLib.CButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New CButtonLib.CButton()
        Me.btnDelete = New CButtonLib.CButton()
        CType(Me.dgvtenvama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NlnhapBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvtenvama
        '
        Me.dgvtenvama.AllowUserToAddRows = False
        Me.dgvtenvama.AllowUserToDeleteRows = False
        Me.dgvtenvama.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvtenvama.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvtenvama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtenvama.EnableHeadersVisualStyles = False
        Me.dgvtenvama.Location = New System.Drawing.Point(67, 290)
        Me.dgvtenvama.Name = "dgvtenvama"
        Me.dgvtenvama.ReadOnly = True
        Me.dgvtenvama.RowHeadersVisible = False
        Me.dgvtenvama.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvtenvama.Size = New System.Drawing.Size(857, 150)
        Me.dgvtenvama.TabIndex = 0
        '
        'NlnhapBindingSource
        '
        Me.NlnhapBindingSource.DataMember = "Nlnhap"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(302, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chương Trình Quản Lý Nguyên Liệu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã nguyên liệu"
        '
        'txtMaNL
        '
        Me.txtMaNL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNL.Location = New System.Drawing.Point(190, 29)
        Me.txtMaNL.Name = "txtMaNL"
        Me.txtMaNL.Size = New System.Drawing.Size(190, 26)
        Me.txtMaNL.TabIndex = 3
        '
        'txtTenNL
        '
        Me.txtTenNL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenNL.Location = New System.Drawing.Point(612, 27)
        Me.txtTenNL.Name = "txtTenNL"
        Me.txtTenNL.Size = New System.Drawing.Size(190, 26)
        Me.txtTenNL.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ghi chú"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(474, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tên nguyên liệu"
        '
        'txtGhichu
        '
        Me.txtGhichu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhichu.Location = New System.Drawing.Point(190, 67)
        Me.txtGhichu.Name = "txtGhichu"
        Me.txtGhichu.Size = New System.Drawing.Size(612, 26)
        Me.txtGhichu.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 34)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Location = New System.Drawing.Point(1, 530)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(991, 34)
        Me.Panel2.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMaNL)
        Me.GroupBox1.Controls.Add(Me.txtTenNL)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGhichu)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 186)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnAdd.Corners.All = 8
        Me.btnAdd.Corners.LowerLeft = 8
        Me.btnAdd.Corners.LowerRight = 8
        Me.btnAdd.Corners.UpperLeft = 8
        Me.btnAdd.Corners.UpperRight = 8
        Me.btnAdd.DesignerSelected = False
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ImageIndex = 0
        Me.btnAdd.Location = New System.Drawing.Point(400, 20)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Size = New System.Drawing.Size(112, 33)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Lưu"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.TextShadow = System.Drawing.Color.Black
        Me.btnAdd.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 456)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(857, 68)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnExit.Corners.All = 8
        Me.btnExit.Corners.LowerLeft = 8
        Me.btnExit.Corners.LowerRight = 8
        Me.btnExit.Corners.UpperLeft = 8
        Me.btnExit.Corners.UpperRight = 8
        Me.btnExit.DesignerSelected = False
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageIndex = 0
        Me.btnExit.Location = New System.Drawing.Point(690, 20)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExit.Size = New System.Drawing.Size(112, 33)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "Thoát"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btnExit.TextShadow = System.Drawing.Color.Black
        Me.btnExit.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'btnDelete
        '
        Me.btnDelete.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnDelete.Corners.All = 8
        Me.btnDelete.Corners.LowerLeft = 8
        Me.btnDelete.Corners.LowerRight = 8
        Me.btnDelete.Corners.UpperLeft = 8
        Me.btnDelete.Corners.UpperRight = 8
        Me.btnDelete.DesignerSelected = False
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ImageIndex = 0
        Me.btnDelete.Location = New System.Drawing.Point(550, 20)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDelete.Size = New System.Drawing.Size(112, 33)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.TextShadow = System.Drawing.Color.Black
        Me.btnDelete.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Tenvamanguyenlieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvtenvama)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 600)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "Tenvamanguyenlieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUẢN LÝ NGUYÊN LIỆU"
        CType(Me.dgvtenvama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NlnhapBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvtenvama As System.Windows.Forms.DataGridView
    Friend WithEvents NlnhapBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaNL As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGhichu As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As CButtonLib.CButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As CButtonLib.CButton
    Friend WithEvents btnDelete As CButtonLib.CButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Thongke
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
        Me.rbtHangnhap = New System.Windows.Forms.RadioButton()
        Me.rbtHangxuat = New System.Windows.Forms.RadioButton()
        Me.cbXemhangton = New System.Windows.Forms.CheckBox()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbbSopieu = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New CButtonLib.CButton()
        Me.btnView = New CButtonLib.CButton()
        Me.btnPrintExcel = New CButtonLib.CButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbHangnhap = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbHangnhap.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtHangnhap
        '
        Me.rbtHangnhap.AutoSize = True
        Me.rbtHangnhap.Checked = True
        Me.rbtHangnhap.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtHangnhap.Location = New System.Drawing.Point(63, 19)
        Me.rbtHangnhap.Name = "rbtHangnhap"
        Me.rbtHangnhap.Size = New System.Drawing.Size(99, 23)
        Me.rbtHangnhap.TabIndex = 0
        Me.rbtHangnhap.TabStop = True
        Me.rbtHangnhap.Text = "Hàng nhập"
        Me.rbtHangnhap.UseVisualStyleBackColor = True
        '
        'rbtHangxuat
        '
        Me.rbtHangxuat.AutoSize = True
        Me.rbtHangxuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtHangxuat.Location = New System.Drawing.Point(266, 19)
        Me.rbtHangxuat.Name = "rbtHangxuat"
        Me.rbtHangxuat.Size = New System.Drawing.Size(96, 23)
        Me.rbtHangxuat.TabIndex = 1
        Me.rbtHangxuat.Text = "Hàng xuất"
        Me.rbtHangxuat.UseVisualStyleBackColor = True
        '
        'cbXemhangton
        '
        Me.cbXemhangton.AutoSize = True
        Me.cbXemhangton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbXemhangton.Location = New System.Drawing.Point(69, 167)
        Me.cbXemhangton.Name = "cbXemhangton"
        Me.cbXemhangton.Size = New System.Drawing.Size(120, 23)
        Me.cbXemhangton.TabIndex = 13
        Me.cbXemhangton.Text = "Xem hàng tồn"
        Me.cbXemhangton.UseVisualStyleBackColor = True
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(210, 113)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(152, 26)
        Me.dtpTo.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(65, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 19)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Đến ngày"
        '
        'dtpfrom
        '
        Me.dtpfrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpfrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfrom.Location = New System.Drawing.Point(210, 67)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(152, 26)
        Me.dtpfrom.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Từ ngày"
        '
        'cbbSopieu
        '
        Me.cbbSopieu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbSopieu.FormattingEnabled = True
        Me.cbbSopieu.Location = New System.Drawing.Point(210, 23)
        Me.cbbSopieu.Name = "cbbSopieu"
        Me.cbbSopieu.Size = New System.Drawing.Size(152, 27)
        Me.cbbSopieu.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Số phiếu"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Location = New System.Drawing.Point(-1, 377)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 34)
        Me.Panel1.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtHangnhap)
        Me.GroupBox2.Controls.Add(Me.rbtHangxuat)
        Me.GroupBox2.Location = New System.Drawing.Point(70, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 60)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Controls.Add(Me.btnView)
        Me.GroupBox3.Controls.Add(Me.btnPrintExcel)
        Me.GroupBox3.Location = New System.Drawing.Point(70, 312)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 55)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
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
        Me.btnExit.Location = New System.Drawing.Point(328, 16)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExit.Size = New System.Drawing.Size(112, 33)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Thoát"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btnExit.TextShadow = System.Drawing.Color.Black
        Me.btnExit.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'btnView
        '
        Me.btnView.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnView.Corners.All = 8
        Me.btnView.Corners.LowerLeft = 8
        Me.btnView.Corners.LowerRight = 8
        Me.btnView.Corners.UpperLeft = 8
        Me.btnView.Corners.UpperRight = 8
        Me.btnView.DesignerSelected = False
        Me.btnView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ImageIndex = 0
        Me.btnView.Location = New System.Drawing.Point(50, 16)
        Me.btnView.Margin = New System.Windows.Forms.Padding(0)
        Me.btnView.Name = "btnView"
        Me.btnView.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnView.Size = New System.Drawing.Size(112, 35)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "Xem"
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnView.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btnView.TextShadow = System.Drawing.Color.Black
        Me.btnView.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'btnPrintExcel
        '
        Me.btnPrintExcel.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnPrintExcel.Corners.All = 8
        Me.btnPrintExcel.Corners.LowerLeft = 8
        Me.btnPrintExcel.Corners.LowerRight = 8
        Me.btnPrintExcel.Corners.UpperLeft = 8
        Me.btnPrintExcel.Corners.UpperRight = 8
        Me.btnPrintExcel.DesignerSelected = False
        Me.btnPrintExcel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintExcel.ImageIndex = 0
        Me.btnPrintExcel.Location = New System.Drawing.Point(190, 16)
        Me.btnPrintExcel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPrintExcel.Name = "btnPrintExcel"
        Me.btnPrintExcel.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPrintExcel.Size = New System.Drawing.Size(112, 33)
        Me.btnPrintExcel.TabIndex = 5
        Me.btnPrintExcel.Text = "Xuất Excel "
        Me.btnPrintExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintExcel.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btnPrintExcel.TextShadow = System.Drawing.Color.Black
        Me.btnPrintExcel.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Location = New System.Drawing.Point(-3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 28)
        Me.Panel2.TabIndex = 14
        '
        'gbHangnhap
        '
        Me.gbHangnhap.Controls.Add(Me.cbXemhangton)
        Me.gbHangnhap.Controls.Add(Me.dtpTo)
        Me.gbHangnhap.Controls.Add(Me.Label9)
        Me.gbHangnhap.Controls.Add(Me.dtpfrom)
        Me.gbHangnhap.Controls.Add(Me.Label8)
        Me.gbHangnhap.Controls.Add(Me.cbbSopieu)
        Me.gbHangnhap.Controls.Add(Me.Label5)
        Me.gbHangnhap.Location = New System.Drawing.Point(70, 110)
        Me.gbHangnhap.Name = "gbHangnhap"
        Me.gbHangnhap.Size = New System.Drawing.Size(488, 196)
        Me.gbHangnhap.TabIndex = 10
        Me.gbHangnhap.TabStop = False
        '
        'Thongke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 411)
        Me.Controls.Add(Me.gbHangnhap)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(651, 450)
        Me.MinimumSize = New System.Drawing.Size(651, 450)
        Me.Name = "Thongke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHƯƠNG TRÌNH THỐNG KÊ"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.gbHangnhap.ResumeLayout(False)
        Me.gbHangnhap.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbtHangnhap As System.Windows.Forms.RadioButton
    Friend WithEvents rbtHangxuat As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As CButtonLib.CButton
    Friend WithEvents btnPrintExcel As CButtonLib.CButton
    Friend WithEvents btnView As CButtonLib.CButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbbSopieu As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbXemhangton As System.Windows.Forms.CheckBox
    Friend WithEvents gbHangnhap As System.Windows.Forms.GroupBox
End Class

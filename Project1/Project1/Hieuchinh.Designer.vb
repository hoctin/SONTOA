<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hieuchinh
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabNhap = New System.Windows.Forms.TabPage()
        Me.txtGhichun = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKLn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbbSophieunhap = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTennln = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbbManln = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThoatn = New CButtonLib.CButton()
        Me.btnLuun = New CButtonLib.CButton()
        Me.TabXuat = New System.Windows.Forms.TabPage()
        Me.txtGhichux = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKLx = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbbSophieuxuat = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTennlx = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbbManlx = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnThoatx = New CButtonLib.CButton()
        Me.btnLuux = New CButtonLib.CButton()
        Me.TabControl1.SuspendLayout()
        Me.TabNhap.SuspendLayout()
        Me.TabXuat.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(254, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "CHƯƠNG TRÌNH HIỆU CHỈNH"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.CausesValidation = False
        Me.TabControl1.Controls.Add(Me.TabNhap)
        Me.TabControl1.Controls.Add(Me.TabXuat)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(240, 26)
        Me.TabControl1.Location = New System.Drawing.Point(30, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(6, 4)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(760, 264)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 15
        '
        'TabNhap
        '
        Me.TabNhap.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabNhap.Controls.Add(Me.txtGhichun)
        Me.TabNhap.Controls.Add(Me.Label7)
        Me.TabNhap.Controls.Add(Me.txtKLn)
        Me.TabNhap.Controls.Add(Me.Label4)
        Me.TabNhap.Controls.Add(Me.cbbSophieunhap)
        Me.TabNhap.Controls.Add(Me.Label3)
        Me.TabNhap.Controls.Add(Me.txtTennln)
        Me.TabNhap.Controls.Add(Me.Label6)
        Me.TabNhap.Controls.Add(Me.cbbManln)
        Me.TabNhap.Controls.Add(Me.Label2)
        Me.TabNhap.Controls.Add(Me.btnThoatn)
        Me.TabNhap.Controls.Add(Me.btnLuun)
        Me.TabNhap.Location = New System.Drawing.Point(4, 30)
        Me.TabNhap.Name = "TabNhap"
        Me.TabNhap.Padding = New System.Windows.Forms.Padding(3)
        Me.TabNhap.Size = New System.Drawing.Size(752, 230)
        Me.TabNhap.TabIndex = 0
        Me.TabNhap.Text = "Nhập nguyên liệu"
        '
        'txtGhichun
        '
        Me.txtGhichun.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhichun.Location = New System.Drawing.Point(176, 110)
        Me.txtGhichun.Name = "txtGhichun"
        Me.txtGhichun.Size = New System.Drawing.Size(525, 26)
        Me.txtGhichun.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Ghi chú"
        '
        'txtKLn
        '
        Me.txtKLn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKLn.Location = New System.Drawing.Point(507, 64)
        Me.txtKLn.Name = "txtKLn"
        Me.txtKLn.Size = New System.Drawing.Size(194, 26)
        Me.txtKLn.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(377, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "KL nhập"
        '
        'cbbSophieunhap
        '
        Me.cbbSophieunhap.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbSophieunhap.FormattingEnabled = True
        Me.cbbSophieunhap.Location = New System.Drawing.Point(176, 63)
        Me.cbbSophieunhap.Name = "cbbSophieunhap"
        Me.cbbSophieunhap.Size = New System.Drawing.Size(163, 27)
        Me.cbbSophieunhap.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Số phiếu nhập"
        '
        'txtTennln
        '
        Me.txtTennln.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTennln.Location = New System.Drawing.Point(507, 20)
        Me.txtTennln.Name = "txtTennln"
        Me.txtTennln.ReadOnly = True
        Me.txtTennln.Size = New System.Drawing.Size(194, 26)
        Me.txtTennln.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(377, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Tên nguyên liệu"
        '
        'cbbManln
        '
        Me.cbbManln.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbManln.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbManln.FormattingEnabled = True
        Me.cbbManln.Location = New System.Drawing.Point(176, 19)
        Me.cbbManln.Name = "cbbManln"
        Me.cbbManln.Size = New System.Drawing.Size(163, 27)
        Me.cbbManln.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mã nguyên liệu"
        '
        'btnThoatn
        '
        Me.btnThoatn.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnThoatn.Corners.All = 8
        Me.btnThoatn.Corners.LowerLeft = 8
        Me.btnThoatn.Corners.LowerRight = 8
        Me.btnThoatn.Corners.UpperLeft = 8
        Me.btnThoatn.Corners.UpperRight = 8
        Me.btnThoatn.DesignerSelected = False
        Me.btnThoatn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoatn.ImageIndex = 0
        Me.btnThoatn.Location = New System.Drawing.Point(573, 174)
        Me.btnThoatn.Margin = New System.Windows.Forms.Padding(0)
        Me.btnThoatn.Name = "btnThoatn"
        Me.btnThoatn.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThoatn.Size = New System.Drawing.Size(108, 33)
        Me.btnThoatn.TabIndex = 4
        Me.btnThoatn.Text = "Thoát"
        Me.btnThoatn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnThoatn.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btnThoatn.TextShadow = System.Drawing.Color.Black
        Me.btnThoatn.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'btnLuun
        '
        Me.btnLuun.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnLuun.Corners.All = 8
        Me.btnLuun.Corners.LowerLeft = 8
        Me.btnLuun.Corners.LowerRight = 8
        Me.btnLuun.Corners.UpperLeft = 8
        Me.btnLuun.Corners.UpperRight = 8
        Me.btnLuun.DesignerSelected = False
        Me.btnLuun.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuun.ImageIndex = 0
        Me.btnLuun.Location = New System.Drawing.Point(419, 174)
        Me.btnLuun.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLuun.Name = "btnLuun"
        Me.btnLuun.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuun.Size = New System.Drawing.Size(108, 33)
        Me.btnLuun.TabIndex = 3
        Me.btnLuun.Text = "Lưu"
        Me.btnLuun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLuun.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btnLuun.TextShadow = System.Drawing.Color.Black
        Me.btnLuun.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'TabXuat
        '
        Me.TabXuat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabXuat.Controls.Add(Me.txtGhichux)
        Me.TabXuat.Controls.Add(Me.Label11)
        Me.TabXuat.Controls.Add(Me.txtKLx)
        Me.TabXuat.Controls.Add(Me.Label10)
        Me.TabXuat.Controls.Add(Me.cbbSophieuxuat)
        Me.TabXuat.Controls.Add(Me.Label9)
        Me.TabXuat.Controls.Add(Me.txtTennlx)
        Me.TabXuat.Controls.Add(Me.Label8)
        Me.TabXuat.Controls.Add(Me.cbbManlx)
        Me.TabXuat.Controls.Add(Me.Label5)
        Me.TabXuat.Controls.Add(Me.btnThoatx)
        Me.TabXuat.Controls.Add(Me.btnLuux)
        Me.TabXuat.Location = New System.Drawing.Point(4, 30)
        Me.TabXuat.Name = "TabXuat"
        Me.TabXuat.Padding = New System.Windows.Forms.Padding(3)
        Me.TabXuat.Size = New System.Drawing.Size(752, 230)
        Me.TabXuat.TabIndex = 1
        Me.TabXuat.Text = "Xuất nguyên liệu"
        '
        'txtGhichux
        '
        Me.txtGhichux.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhichux.Location = New System.Drawing.Point(176, 110)
        Me.txtGhichux.Name = "txtGhichux"
        Me.txtGhichux.Size = New System.Drawing.Size(525, 26)
        Me.txtGhichux.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 19)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Ghi chú"
        '
        'txtKLx
        '
        Me.txtKLx.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKLx.Location = New System.Drawing.Point(507, 64)
        Me.txtKLx.Name = "txtKLx"
        Me.txtKLx.Size = New System.Drawing.Size(194, 26)
        Me.txtKLx.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(377, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 19)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "KL xuất"
        '
        'cbbSophieuxuat
        '
        Me.cbbSophieuxuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbSophieuxuat.FormattingEnabled = True
        Me.cbbSophieuxuat.Location = New System.Drawing.Point(176, 63)
        Me.cbbSophieuxuat.Name = "cbbSophieuxuat"
        Me.cbbSophieuxuat.Size = New System.Drawing.Size(163, 27)
        Me.cbbSophieuxuat.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Số phiếu nhập"
        '
        'txtTennlx
        '
        Me.txtTennlx.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTennlx.Location = New System.Drawing.Point(507, 20)
        Me.txtTennlx.Name = "txtTennlx"
        Me.txtTennlx.ReadOnly = True
        Me.txtTennlx.Size = New System.Drawing.Size(194, 26)
        Me.txtTennlx.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(377, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 19)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Tên nguyên liệu"
        '
        'cbbManlx
        '
        Me.cbbManlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbManlx.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbManlx.FormattingEnabled = True
        Me.cbbManlx.Location = New System.Drawing.Point(176, 19)
        Me.cbbManlx.Name = "cbbManlx"
        Me.cbbManlx.Size = New System.Drawing.Size(163, 27)
        Me.cbbManlx.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Mã nguyên liệu"
        '
        'btnThoatx
        '
        Me.btnThoatx.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnThoatx.Corners.All = 8
        Me.btnThoatx.Corners.LowerLeft = 8
        Me.btnThoatx.Corners.LowerRight = 8
        Me.btnThoatx.Corners.UpperLeft = 8
        Me.btnThoatx.Corners.UpperRight = 8
        Me.btnThoatx.DesignerSelected = False
        Me.btnThoatx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoatx.ImageIndex = 0
        Me.btnThoatx.Location = New System.Drawing.Point(573, 174)
        Me.btnThoatx.Margin = New System.Windows.Forms.Padding(0)
        Me.btnThoatx.Name = "btnThoatx"
        Me.btnThoatx.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThoatx.Size = New System.Drawing.Size(108, 33)
        Me.btnThoatx.TabIndex = 15
        Me.btnThoatx.Text = "Thoát"
        Me.btnThoatx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnThoatx.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btnThoatx.TextShadow = System.Drawing.Color.Black
        Me.btnThoatx.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'btnLuux
        '
        Me.btnLuux.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnLuux.Corners.All = 8
        Me.btnLuux.Corners.LowerLeft = 8
        Me.btnLuux.Corners.LowerRight = 8
        Me.btnLuux.Corners.UpperLeft = 8
        Me.btnLuux.Corners.UpperRight = 8
        Me.btnLuux.DesignerSelected = False
        Me.btnLuux.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuux.ImageIndex = 0
        Me.btnLuux.Location = New System.Drawing.Point(419, 174)
        Me.btnLuux.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLuux.Name = "btnLuux"
        Me.btnLuux.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuux.Size = New System.Drawing.Size(108, 33)
        Me.btnLuux.TabIndex = 14
        Me.btnLuux.Text = "Lưu"
        Me.btnLuux.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLuux.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btnLuux.TextShadow = System.Drawing.Color.Black
        Me.btnLuux.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Hieuchinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 386)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(834, 425)
        Me.MinimumSize = New System.Drawing.Size(834, 425)
        Me.Name = "Hieuchinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl1.ResumeLayout(False)
        Me.TabNhap.ResumeLayout(False)
        Me.TabNhap.PerformLayout()
        Me.TabXuat.ResumeLayout(False)
        Me.TabXuat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem

        'Firstly we'll define some parameters.
        Dim CurrentTab As TabPage = TabControl1.TabPages(e.Index)
        Dim ItemRect As Rectangle = TabControl1.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.WhiteSmoke)
        Dim TextBrush As New SolidBrush(Color.Red)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        'If CBool(e.State And DrawItemState.Selected) Then
        '    FillBrush.Color = ColorTranslator.FromHtml("#00107c")
        '    ItemRect.Inflate(1, 1)
        'End If

        'Set up rotation for left and right aligned tabs
        If TabControl1.Alignment = TabAlignment.Left Or TabControl1.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If TabControl1.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(ItemRect.Left + (ItemRect.Width \ 2), ItemRect.Top + (ItemRect.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            ItemRect = New Rectangle(-(ItemRect.Height \ 2), -(ItemRect.Width \ 2), ItemRect.Height, ItemRect.Width)
        End If

        'Next we'll paint the TabItem with our Fill Brush
        e.Graphics.FillRectangle(FillBrush, ItemRect)

        'Now draw the text.
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)

        'Reset any Graphics rotation
        e.Graphics.ResetTransform()

        'Finally, we should Dispose of our brushes.
        FillBrush.Dispose()
        TextBrush.Dispose()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnThoatn As CButtonLib.CButton
    Friend WithEvents btnLuun As CButtonLib.CButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabNhap As System.Windows.Forms.TabPage
    Friend WithEvents TabXuat As System.Windows.Forms.TabPage
    Friend WithEvents btnThoatx As CButtonLib.CButton
    Friend WithEvents btnLuux As CButtonLib.CButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbbManln As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTennln As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbbSophieunhap As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKLn As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGhichun As System.Windows.Forms.TextBox
    Friend WithEvents txtGhichux As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKLx As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbbSophieuxuat As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTennlx As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbbManlx As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

Imports System.Data.OleDb
Public Class Xemhang

    Private Sub Xemhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Thongke.GetdataView()
        If hangton = False Then
            If flag = True Then
                Me.Label1.Text = "BẢN THỐNG KÊ NHẬP HÀNG HÓA"
            ElseIf flag = False Then
                Me.Label1.Text = "BẢN THỐNG KÊ XUẤT HÀNG HÓA"
            End If
            Me.lbFrom.Text = Format(timeFrom, "dd/MM/yyyy")
            Me.lbTo.Text = Format(timeTo, "dd/MM/yyyy")
            Me.dgvView.DataSource = Thongke.GetdataView
            With dgvView
                .Columns(0).Width = 90
                .Columns(1).Width = 40
                .Columns(2).Width = 90
                .Columns(3).Width = 90
                .Columns(4).Width = 70
                .Columns(5).Width = 70
                .Columns(6).Width = 70
                .Columns(7).Width = 70
                .Columns(8).Width = 90
                .Columns(9).Width = 100
                .Columns(10).Width = 180
            End With
        ElseIf hangton = True Then
            Me.Label1.Text = "BẢN TỔNG KẾT HÀNG TỒN"
            Me.lbFrom.Text = Format(timeFrom, "dd/MM/yyyy")
            Me.lbTo.Text = Format(timeTo, "dd/MM/yyyy")
            Me.dgvView.DataSource = Thongke.GetdataHangton
            With dgvView
                .Columns(0).Width = 240
                .Columns(1).Width = 240
                .Columns(2).Width = 240
                .Columns(3).Width = 240
            End With
        End If
    End Sub
    
End Class
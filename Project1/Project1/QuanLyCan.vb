Public Class QuanLyCan
    Private Sub btnHieuchinh_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnHieuchinh.ClickButtonArea
        Dim frm As New Login
        frm.ShowDialog()
    End Sub

    Private Sub btnQuanlyxuatnhap_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnQuanlyxuatnhap.ClickButtonArea
        Dim frm As New Quanlyxuatnhap
        frm.ShowDialog()
    End Sub

    Private Sub btnTenvamanguyenlieu_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnTenvamanguyenlieu.ClickButtonArea
        Dim frm As New Tenvamanguyenlieu
        frm.ShowDialog()
    End Sub

    Private Sub btnThongke_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnThongke.ClickButtonArea
        Dim frm As New Thongke
        frm.ShowDialog()
    End Sub

    Private Sub btnThoat_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnThoat.ClickButtonArea
        Dim result As Integer = MessageBox.Show("Bạn muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Close()
        ElseIf result = DialogResult.No Then
            Exit Sub
        End If
    End Sub

End Class
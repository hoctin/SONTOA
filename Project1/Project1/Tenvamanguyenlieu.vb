Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Tenvamanguyenlieu
    Private Sub Tenvamanguyenlieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.Nlnhap' table. You can move, or remove it, as needed.
        btnDelete.Enabled = False
        Getdata()
    End Sub


    Private Sub dgvtenvama_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtenvama.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim selectRow As DataGridViewRow
        If Index >= 0 Then
            selectRow = dgvtenvama.Rows(Index)
            If selectRow.Cells(0).Value.ToString() <> "" Then
                txtMaNL.Enabled = False
                btnAdd.Enabled = False
                btnDelete.Enabled = True
                txtMaNL.Text = selectRow.Cells(0).Value.ToString()
                txtTenNL.Text = selectRow.Cells(1).Value.ToString()
                txtGhichu.Text = selectRow.Cells(2).Value.ToString()
            End If
        End If
    End Sub

    Public Function Getdata() As System.Data.DataTable
        connectdb()
        Dim da As New OleDb.OleDbDataAdapter("SELECT MaNL As [Mã nguyên liệu], TenNL As [Tên nguyên liệu],Ghichu As [Ghi chú] FROM Nlnhap WHERE MaNL Is Not Null", con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvtenvama.DataSource = dt
        With dgvtenvama
            .Columns(0).Width = 200
            .Columns(1).Width = 200
            .Columns(2).Width = 457
        End With
        disconnectdb()
        Return dt
    End Function
    Private Sub Cleartextbox()
        Me.txtMaNL.Text = ""
        Me.txtTenNL.Text = ""
        Me.txtGhichu.Text = ""
    End Sub


    Private Sub btnExit_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnExit.ClickButtonArea
        Me.Close()
    End Sub

    Private Sub btnDelete_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnDelete.ClickButtonArea
        Dim cmd As New OleDbCommand
        connectdb()
        cmd.Connection = con
        cmd.CommandText = "DELETE FROM Nlnhap WHERE [MaNL] = '" & txtMaNL.Text & "'"
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            disconnectdb()
            txtMaNL.Enabled = True
            btnDelete.Enabled = False
            btnAdd.Enabled = True
            Cleartextbox()
        Catch ex As Exception
            logerrors(ex.ToString)
            MessageBox.Show("Xóa dữ liệu thất bại.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        Dim dt As System.Data.DataTable = Getdata()
        dgvtenvama.DataSource = dt
    End Sub

    Private Sub btnClear_ClickButtonArea(Sender As Object, e As MouseEventArgs)
        txtMaNL.Enabled = True
        Cleartextbox()
        btnAdd.Enabled = True
        btnDelete.Enabled = False
    End Sub

    Private Sub btnAdd_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnAdd.ClickButtonArea
        Dim cmd As New OleDbCommand
        connectdb()
        cmd.Connection = con

        If txtMaNL.Text = "" Then
            MessageBox.Show("Vui lòng nhập Mã nguyên liệu")
            txtMaNL.Focus()
            Exit Sub
        ElseIf txtTenNL.Text = "" Then
            MessageBox.Show("Vui lòng nhập tên nguyên liệu")
            txtTenNL.Focus()
            Exit Sub
        Else
            cmd.CommandText = "INSERT INTO Nlnhap([MaNL],[TenNL],[Ghichu]) values ('" & txtMaNL.Text & "','" & txtTenNL.Text & "','" & txtGhichu.Text & "')"
        End If
        Try
            cmd.ExecuteNonQuery()
            txtMaNL.Text = ""
            txtTenNL.Text = ""
            txtGhichu.Text = ""
            cmd.Dispose()
            disconnectdb()
        Catch ex As Exception
            logerrors(ex.ToString)
            MessageBox.Show("Thêm mới nguyên liệu thất bại.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        Cleartextbox()
        Dim dt As System.Data.DataTable = Getdata()
        dgvtenvama.DataSource = dt
    End Sub

End Class
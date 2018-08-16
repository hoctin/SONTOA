Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.IO.Ports
Imports System.Threading


Public Class Quanlyxuatnhap
    Dim WithEvents _Serial As mySerial
    Private Sub Quanlyxuatnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getManl()
        getTimeNhap()
        getTimeXuat()
    End Sub
    'FUNCTION XU LY PORT 
    
    Private Sub Quanlyxuatnhap_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        _Serial = New mySerial("COM3", 9600)
        _Serial.OpenPort()
    End Sub
    Private Sub _Serial_DataReceived(Sender As Object, e As dataReceivedEventArgs) Handles _Serial.DataReceived
        'Get chuỗi cân
        txtPortn.Text = e.value1
        txtportx.Text = e.value1
    End Sub
    Private Sub Quanlyxuatnhap_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        value1 = "0"
        _Serial.ClosePort()
    End Sub

    Private Sub btnThoat_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnThoatn.ClickButtonArea
        Try
            _Serial.ClosePort()
            Me.Close()
        Catch ex As Exception
            logerrors(ex.ToString)
        End Try
    End Sub
    Private Sub getManl()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Try
            connectdb()
            cmd.Connection = con
            cmd.CommandText = "SELECT MaNL FROM Nlnhap WHERE MaNL Is Not Null"
            dr = cmd.ExecuteReader
            While dr.Read
                cbbManln.Items.Add(dr.GetString(0))
                cbbManlx.Items.Add(dr.GetString(0))
            End While
            disconnectdb()
            cbbManln.SelectedIndex = 0
            cbbManlx.SelectedIndex = 0
        Catch ex As Exception
            logerrors(ex.ToString)
        End Try
    End Sub
    Private Sub cbbManln_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbManln.SelectedIndexChanged
        Dim da As OleDbDataAdapter
        value = Me.cbbManln.SelectedItem.ToString()
        Dim cmd As New OleDbCommand
        connectdb()
        da = New OleDbDataAdapter("SELECT TenNL FROM Nlnhap WHERE MaNL = '" & value & "'", con)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Me.txtTennln.Text = dt.Rows(0).Item(0).ToString()
        Else
            Me.txtTennln.Text = ""
        End If
        disconnectdb()
    End Sub
    Private Sub cbbManlx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbManlx.SelectedIndexChanged
        Dim da As OleDbDataAdapter
        value = Me.cbbManlx.SelectedItem.ToString()
        Dim cmd As New OleDbCommand
        connectdb()
        da = New OleDbDataAdapter("SELECT TenNL FROM Nlnhap WHERE MaNL = '" & value & "'", con)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Me.txtTennlx.Text = dt.Rows(0).Item(0).ToString()
        Else
            Me.txtTennlx.Text = ""
        End If
        disconnectdb()
    End Sub

    Private Sub btThoatx_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnThoatx.ClickButtonArea
        _Serial.ClosePort()
        Me.Close()
    End Sub
    Private Sub getTimeNhap()
        Me.txtNgaycan.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Me.txtGiocan.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Me.cbbSophieunhap.Text = ""
        Me.txtKL.Text = ""
        Me.txtGhichu.Text = ""
        Me.btnLuun.Enabled = False
    End Sub
    Private Sub getTimeXuat()
        Me.txtNgayxuat.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Me.txtGioxuat.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Me.cbbSophieuxuat.Text = ""
        Me.txtKLxuat.Text = ""
        Me.txtGhichuxuat.Text = ""
        Me.btnLuux.Enabled = False
    End Sub
   
    Private Sub dgvNhap_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhap.CellContentClick

    End Sub

    Private Sub btnBatdaucann_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnBatdaucann.ClickButtonArea
        If dgvNhap.Rows.Count > 0 And btnLuun.Enabled = False Then
            dgvNhap.Rows.Clear()
        End If

        If cbbSophieunhap.Text = "" Or txtKL.Text = "" Or txtPortn.Text = "" Then
            MessageBox.Show("Vui lòng nhập đủ các trường", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try

                dgvNhap.Rows.Add(1)
                Dim index As Integer = dgvNhap.Rows.Count - 1
                With dgvNhap
                    .Rows(index).Cells("Sophieu").Value = cbbSophieunhap.Text()
                    .Rows(index).Cells("Sttme").Value = index + 1
                    .Rows(index).Cells("Mahhn").Value = cbbManln.SelectedItem.ToString
                    .Rows(index).Cells("Tenhhn").Value = txtTennln.Text
                    .Rows(index).Cells("Klndau").Value = CDbl(txtPortn.Text)
                    .Rows(index).Cells("Klncuoi").Value = CDbl(txtPortn.Text)
                    .Rows(index).Cells("KlNln").Value = .Rows(index).Cells("Klncuoi").Value - .Rows(index).Cells("Klndau").Value
                    .Rows(index).Cells("Kllt").Value = CDbl(txtKL.Text)
                    .Rows(index).Cells("Ngayn").Value = txtNgaycan.Text()
                    .Rows(index).Cells("Gion").Value = txtGiocan.Text()
                    .Rows(index).Cells("Ghichu").Value = txtGhichu.Text()
                End With
                dgvNhap.Rows(index).ReadOnly = True
                dgvNhap.Rows(index).Cells("Sophieu").ReadOnly = False
                dgvNhap.Rows(index).Cells("Kllt").ReadOnly = False
                dgvNhap.Rows(index).Cells("Ghichu").ReadOnly = False
            Catch ex As Exception
                logerrors(ex.ToString)
                MessageBox.Show("Xảy ra lỗi khi bắt đầu cân.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
        If dgvNhap.Rows.Count > 0 Then
            getTimeNhap()
            Me.btnLuun.Enabled = True
        End If

    End Sub

    Private Sub txtKL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKL.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKL_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKL.TextChanged
        Dim digitsOnly As Regex = New Regex("[^.\d]")
        txtKL.Text = digitsOnly.Replace(txtKL.Text, "")
    End Sub


    Private Sub txtKLxuat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKLxuat.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKLxuat_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKLxuat.TextChanged
        Dim digitsOnly As Regex = New Regex("[^.\d]")
        txtKLxuat.Text = digitsOnly.Replace(txtKLxuat.Text, "")
    End Sub


    Private Sub btnBatdaucanx_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnBatdaucanx.ClickButtonArea
        If dgvXuat.Rows.Count > 0 And btnLuux.Enabled = False Then
            dgvXuat.Rows.Clear()
        End If
        If cbbSophieuxuat.Text = "" Or txtKLxuat.Text = "" Or txtportx.Text = "" Then
            MessageBox.Show("Vui lòng nhập đủ các trường", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                dgvXuat.Rows.Add(1)
                Dim index As Integer = dgvXuat.Rows.Count - 1
                With dgvXuat
                    .Rows(index).Cells("Sophieux").Value = cbbSophieuxuat.Text()
                    .Rows(index).Cells("Sttmex").Value = index + 1
                    .Rows(index).Cells("Mahhx").Value = cbbManlx.SelectedItem.ToString
                    .Rows(index).Cells("Tenhhx").Value = txtTennlx.Text
                    .Rows(index).Cells("Klxdau").Value = CDbl(txtportx.Text)
                    .Rows(index).Cells("Klxcuoi").Value = CDbl(txtportx.Text)
                    .Rows(index).Cells("KlNlx").Value = .Rows(index).Cells("Klxdau").Value - .Rows(index).Cells("Klxcuoi").Value
                    .Rows(index).Cells("Klltx").Value = CDbl(txtKLxuat.Text)
                    .Rows(index).Cells("Ngayx").Value = txtNgayxuat.Text()
                    .Rows(index).Cells("Giox").Value = txtGioxuat.Text()
                    .Rows(index).Cells("Ghichux").Value = txtGhichuxuat.Text()
                End With
                dgvXuat.Rows(index).ReadOnly = True
                dgvXuat.Rows(index).Cells("Sophieux").ReadOnly = False
                dgvXuat.Rows(index).Cells("Klltx").ReadOnly = False
                dgvXuat.Rows(index).Cells("Ghichux").ReadOnly = False
            Catch ex As Exception
                logerrors(ex.ToString)
                MessageBox.Show("Xảy ra lỗi khi bắt đầu cân.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
        If dgvXuat.Rows.Count > 0 Then
            getTimeXuat()
            Me.btnLuux.Enabled = True
        End If
    End Sub

    Private Sub TabNhap_Enter(sender As System.Object, e As System.EventArgs) Handles TabNhap.Enter
        getTimeNhap()

    End Sub
    Private Sub TabXuat_Enter(sender As System.Object, e As System.EventArgs) Handles TabXuat.Enter
        getTimeXuat()
    End Sub

    Private Sub TabControl1_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting
        'Check row dgvNhap > 0 and click event tabXuat
        If dgvNhap.Rows.Count <> 0 And TabControl1.SelectedIndex = 1 And btnLuun.Enabled = True Then
            MessageBox.Show("Dữ liệu chưa được lưu vào database.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
            ''Check row dgvXuat > 0 and click event tabNhap
        ElseIf dgvXuat.Rows.Count <> 0 And TabControl1.SelectedIndex = 0 And btnLuux.Enabled = True Then
            MessageBox.Show("Dữ liệu chưa được lưu vào database.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End If
    End Sub
    ''' <summary>
    ''' event click button Save datagirdview into database access (TabNhap)
    ''' </summary>
    ''' <param name="Sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLuun_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnLuun.ClickButtonArea

        Dim rowinsert As Integer = 0
        If (dgvNhap.Rows.Count > 0) Then
            Try
                Dim cmd As New OleDbCommand
                connectdb()
                cmd.Connection = con
                Dim sophieu As String
                Dim stt As Integer
                Dim mahh As String
                Dim tenhh As String
                Dim kldau As Double
                Dim klcuoi As Double
                Dim klnl As Double
                Dim khlt As Double
                Dim Ngay As Date
                Date.TryParseExact(DateString, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, Ngay)
                Dim Gio As String
                Dim Ghichu As String
                Dim str As String
                For i As Integer = 0 To dgvNhap.Rows.Count - 1
                    With dgvNhap
                        sophieu = .Rows(i).Cells(0).Value
                        stt = .Rows(i).Cells(1).Value
                        mahh = .Rows(i).Cells(2).Value
                        tenhh = .Rows(i).Cells(3).Value
                        kldau = .Rows(i).Cells(4).Value
                        .Rows(i).Cells(5).Value = CDbl(txtPortn.Text)
                        klcuoi = .Rows(i).Cells(5).Value
                        .Rows(i).Cells(6).Value = .Rows(i).Cells(5).Value - .Rows(i).Cells(4).Value
                        klnl = .Rows(i).Cells(6).Value
                        khlt = .Rows(i).Cells(7).Value
                        Ngay = DateTime.ParseExact(.Rows(i).Cells(8).Value, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                        Gio = .Rows(i).Cells(9).Value
                        Ghichu = .Rows(i).Cells(10).Value
                    End With
                    str = "INSERT INTO Phieunhap(Sophieu,Sttme,Mahhn,Tenhhn,Klndau,Klncuoi,KlNln,Kllt,Ngayn,Gion,Ghichu) " +
                          "VALUES (@Sophieu,@Sttme,@Mahhn,@Tenhhn,@Klndau,@Klncuoi,@KlNln,@Kllt,@Ngayn,@Gion,@Ghichu)"
                    Dim com As New OleDb.OleDbCommand(str, con)
                    com.Parameters.AddWithValue("@Sophieu", sophieu)
                    com.Parameters.AddWithValue("@Sttme", stt)
                    com.Parameters.AddWithValue("@Mahhn", mahh)
                    com.Parameters.AddWithValue("@Tenhhn", tenhh)
                    com.Parameters.AddWithValue("@Klndau", kldau)
                    com.Parameters.AddWithValue("@Klncuoi", klcuoi)
                    com.Parameters.AddWithValue("@KlNln", klnl)
                    com.Parameters.AddWithValue("@Kllt", khlt)
                    com.Parameters.AddWithValue("@Ngayn", Ngay)
                    com.Parameters.AddWithValue("@Gion", Gio)
                    com.Parameters.AddWithValue("@Ghichu", Ghichu)
                    rowinsert = rowinsert + com.ExecuteNonQuery()
                    com.Dispose()
                Next
                cmd.Dispose()
                disconnectdb()
            Catch ex As Exception
                logerrors(ex.ToString)
                MessageBox.Show("Dữ liệu thêm vào database thất bại .", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            If rowinsert > 0 Then
                MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'dgvNhap.Rows.Clear()
                btnLuun.Enabled = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' event click button Save datagirdview into database access(TabXuat)
    ''' </summary>
    ''' <param name="Sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLuux_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnLuux.ClickButtonArea
        Dim rowinsert As Integer = 0
        If (dgvXuat.Rows.Count > 0) Then
            Try
                Dim cmd As New OleDbCommand
                connectdb()
                cmd.Connection = con
                Dim sophieu As String
                Dim stt As Integer
                Dim mahh As String
                Dim tenhh As String
                Dim kldau As Double
                Dim klcuoi As Double
                Dim klnl As Double
                Dim khlt As Double
                Dim Ngay As Date
                Date.TryParseExact(DateString, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, Ngay)
                Dim Gio As String
                Dim Ghichu As String
                Dim str As String
                For i As Integer = 0 To dgvXuat.Rows.Count - 1
                    With dgvXuat
                        sophieu = .Rows(i).Cells(0).Value
                        stt = .Rows(i).Cells(1).Value
                        mahh = .Rows(i).Cells(2).Value
                        tenhh = .Rows(i).Cells(3).Value
                        kldau = .Rows(i).Cells(4).Value
                        .Rows(i).Cells(5).Value = CDbl(txtportx.Text)
                        klcuoi = .Rows(i).Cells(5).Value
                        .Rows(i).Cells(6).Value = .Rows(i).Cells(4).Value - .Rows(i).Cells(5).Value
                        klnl = .Rows(i).Cells(6).Value
                        khlt = .Rows(i).Cells(7).Value
                        Ngay = DateTime.ParseExact(.Rows(i).Cells(8).Value, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                        Gio = .Rows(i).Cells(9).Value
                        Ghichu = .Rows(i).Cells(10).Value
                    End With
                    str = "INSERT INTO Phieuxa(Sophieu,Sttmex,Mahhx,Tenhhx,Klxdau,Klxcuoi,KlNl,Kllt,Ngayx,Giox,Ghichu) " +
                          "VALUES (@Sophieu,@Sttmex,@Mahhx,@Tenhhx,@Klxdau,@Klxcuoi,@KlNl,@Kllt,@Ngayx,@Giox,@Ghichu)"
                    Dim com As New OleDb.OleDbCommand(str, con)
                    com.Parameters.AddWithValue("@Sophieu", sophieu)
                    com.Parameters.AddWithValue("@Sttmex", stt)
                    com.Parameters.AddWithValue("@Mahhx", mahh)
                    com.Parameters.AddWithValue("@Tenhhx", tenhh)
                    com.Parameters.AddWithValue("@Klxdau", kldau)
                    com.Parameters.AddWithValue("@Klxcuoi", klcuoi)
                    com.Parameters.AddWithValue("@KlNl", klnl)
                    com.Parameters.AddWithValue("@Kllt", khlt)
                    com.Parameters.AddWithValue("@Ngayx", Ngay)
                    com.Parameters.AddWithValue("@Giox", Gio)
                    com.Parameters.AddWithValue("@Ghichu", Ghichu)
                    rowinsert = rowinsert + com.ExecuteNonQuery()
                    com.Dispose()
                Next
                cmd.Dispose()
                disconnectdb()
            Catch ex As Exception
                logerrors(ex.ToString)
                MessageBox.Show("Dữ liệu thêm vào database thất bại .", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            If rowinsert > 0 Then
                MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnLuux.Enabled = False
            End If
        End If
    End Sub

End Class
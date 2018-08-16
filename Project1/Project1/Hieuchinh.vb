Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.Globalization

Public Class Hieuchinh

    Private Sub Hieuchinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Close()
        getManl()
    End Sub

    Private Sub btnThoatn_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnThoatn.ClickButtonArea
        Me.Close()
    End Sub

    Private Sub btnThoatx_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnThoatx.ClickButtonArea
        Me.Close()
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
    Private Sub txtKLn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKLn.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKLn_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKLn.TextChanged
        Dim digitsOnly As Regex = New Regex("[^.\d]")
        txtKLn.Text = digitsOnly.Replace(txtKLn.Text, "")
    End Sub


    Private Sub txtKLx_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKLx.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKLx_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKLx.TextChanged
        Dim digitsOnly As Regex = New Regex("[^.\d]")
        txtKLx.Text = digitsOnly.Replace(txtKLx.Text, "")
    End Sub
   
    Private Sub btnLuun_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnLuun.ClickButtonArea
        Dim rowinsert As Integer = 0

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
            Dim Flag As Integer
            Dim str As String
            sophieu = cbbSophieunhap.Text()
            stt = 1
            mahh = cbbManln.SelectedItem.ToString
            tenhh = txtTennln.Text
            kldau = 0
            klcuoi = 0
            klnl = CDbl(txtKLn.Text)
            khlt = 0
            Ngay = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Gio = DateTime.Now.ToString("hh:mm:ss tt")
            Ghichu = txtGhichun.Text
            Flag = 1
            If Not sophieu Is Nothing And Not klnl = 0 And Not Ghichu Is Nothing Then
                str = "INSERT INTO Phieunhap(Sophieu,Sttme,Mahhn,Tenhhn,Klndau,Klncuoi,KlNln,Kllt,Ngayn,Gion,Ghichu,Flag) " +
                      "VALUES (@Sophieu,@Sttme,@Mahhn,@Tenhhn,@Klndau,@Klncuoi,@KlNln,@Kllt,@Ngayn,@Gion,@Ghichu,@Flag)"
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
                com.Parameters.AddWithValue("@Flag", Flag)
                rowinsert = rowinsert + com.ExecuteNonQuery()
                com.Dispose()
            Else
                MessageBox.Show("Vui lòng nhập đủ các trường", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

            cmd.Dispose()
            disconnectdb()
        Catch
            MessageBox.Show("Dữ liệu thêm vào database thất bại.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        If rowinsert > 0 Then
            MessageBox.Show("Dữ liệu thêm vào database thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKLn.Text = ""
            txtGhichun.Text = ""
            cbbSophieunhap.Text = ""
        End If
    End Sub

    Private Sub btnLuux_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnLuux.ClickButtonArea
        Dim rowinsert As Integer = 0
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
            'Date.TryParseExact(DateString, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, Ngay)
            Dim Gio As String
            Dim Ghichu As String
            Dim Flag As Integer
            Dim str As String
            sophieu = cbbSophieuxuat.Text()
            stt = 1
            mahh = cbbManlx.SelectedItem.ToString
            tenhh = txtTennlx.Text
            kldau = 0
            klcuoi = 0
            klnl = CDbl(txtKLx.Text)
            khlt = 0
            Ngay = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Gio = DateTime.Now.ToString("hh:mm:ss tt")
            Ghichu = txtGhichux.Text
            Flag = 1
            If Not sophieu Is Nothing And Not klnl = 0 And Not Ghichu Is Nothing Then
                str = "INSERT INTO Phieuxa(Sophieu,Sttmex,Mahhx,Tenhhx,Klxdau,Klxcuoi,KlNl,Kllt,Ngayx,Giox,Ghichu,Flag) " +
                      "VALUES (@Sophieu,@Sttmex,@Mahhx,@Tenhhx,@Klxdau,@Klxcuoi,@KlNl,@Kllt,@Ngayx,@Giox,@Ghichu,@Flag)"
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
                com.Parameters.AddWithValue("@Flag", Flag)
                rowinsert = rowinsert + com.ExecuteNonQuery()
                com.Dispose()
            Else
                MessageBox.Show("Vui lòng nhập đủ các trường", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
            cmd.Dispose()
            disconnectdb()
        Catch
            MessageBox.Show("Dữ liệu thêm vào database thất bại .", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        If rowinsert > 0 Then
            MessageBox.Show("Dữ liệu thêm vào database thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKLx.Text = ""
            txtGhichux.Text = ""
            cbbSophieuxuat.Text = ""
        End If
    End Sub
End Class
Imports System.IO
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnDangnhap_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnDangnhap.ClickButtonArea
        Dim Arr() As String
        Dim flag As Boolean = False
        'Khai báo biến Stream Reader để đọc file "Login.txt" 
        Dim sr As StreamReader = My.Computer.FileSystem.OpenTextFileReader("E:\Quan ly can\Sys\Login.txt")
        'Đọc file
        If txtUsername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu")
        Else
            Try
                While Not sr.EndOfStream
                    Dim line As String = sr.ReadLine()
                    Arr = line.Split(",")
                    If txtUsername.Text = Arr(0) And txtpassword.Text = Arr(1) Then
                        Me.Close()
                        Dim frm As New Hieuchinh
                        frm.ShowDialog()
                        Exit Sub
                    End If
                End While
                If flag = False Then
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng")
                    txtUsername.Text = ""
                    txtpassword.Text = ""
                End If
                sr.Close()
            Catch
                MessageBox.Show("Đã xảy lỗi hệ thống. Vui lòng liên lạc với đội ngũ kỹ thuật", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtUsername.Text = ""
                txtpassword.Text = ""
                Exit Sub
                Throw
            End Try
        End If
        
    End Sub

    Private Sub btnThoat_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnThoat.ClickButtonArea
        Me.Close()
    End Sub

End Class
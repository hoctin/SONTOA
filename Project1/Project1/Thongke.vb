Imports System.Data.OleDb
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Globalization

Public Class Thongke
    Dim directory As String = My.Application.Info.DirectoryPath
    Private Sub Thongke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Date.TryParseExact(DateString, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, timeFrom)
        Date.TryParseExact(DateString, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, timeTo)
    End Sub

    Private Sub getSophieu()
        cbbSopieu.Items.Clear()
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        connectdb()
        cmd.Connection = con
        If rbtHangnhap.Checked = True Then
            cmd.CommandText = "SELECT DISTINCT Sophieu FROM Phieunhap WHERE Sophieu Is Not Null"
        End If
        If rbtHangxuat.Checked = True Then
            cmd.CommandText = "SELECT DISTINCT Sophieu FROM Phieuxa WHERE Sophieu Is Not Null"
        End If

        dr = cmd.ExecuteReader
        While dr.Read
            cbbSopieu.Items.Add(dr.GetString(0))
        End While
        disconnectdb()
    End Sub
    Private Sub btnPrintExcel_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnPrintExcel.ClickButtonArea
        value = cbbSopieu.Text()
        timeFrom = DateTime.ParseExact(dtpfrom.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
        timeTo = DateTime.ParseExact(dtpTo.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
        If rbtHangnhap.Checked Then
            flag = True
        ElseIf rbtHangxuat.Checked Then
            flag = False
        End If
        DatatableToExcel(GetdataView())

    End Sub
    Private Sub DatatableToExcel(ByVal dtTemp As DataTable)
        'Print excel nhap
        If rbtHangnhap.Checked = True Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim sourcePath As String = "E:\Quan ly can\Templae\Templatenhap.xls"
            xlApp = New Excel.Application()
            xlWorkBook = xlApp.Workbooks.Add(sourcePath)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet.Range("F2").Value = Format(timeFrom, "dd/MM/yyyy")
            xlWorkSheet.Range("H2").Value = Format(timeTo, "dd/MM/yyyy")
            Dim dt As System.Data.DataTable = dtTemp
            Dim dc As DataColumn
            Dim dr As DataRow
            Dim colIndex As Integer = 1
            Dim rowIndex As Integer = 3
            Dim stt As Integer = 0
            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    If colIndex = 1 Then
                        xlWorkSheet.Cells(rowIndex + 1, colIndex) = "'" & dr(dc.ColumnName)
                    Else
                        xlWorkSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    End If
                Next
            Next
            If dt.Rows.Count > 0 Then
                xlWorkSheet.Range("a5", "k" + (dt.Rows.Count + 4).ToString).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("a5", "k" + (dt.Rows.Count + 4).ToString).Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                xlWorkSheet.Range("a5", "k" + (dt.Rows.Count + 4).ToString).Borders.Weight = 2D
            End If
            xlWorkSheet.Range("a" + (dt.Rows.Count + 5).ToString, "f" + (dt.Rows.Count + 5).ToString).Merge()
            xlWorkSheet.Range("a" + (dt.Rows.Count + 5).ToString, "f" + (dt.Rows.Count + 5).ToString).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range("a" + (dt.Rows.Count + 5).ToString, "f" + (dt.Rows.Count + 5).ToString).Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
            xlWorkSheet.Range("a" + (dt.Rows.Count + 5).ToString, "f" + (dt.Rows.Count + 5).ToString).Borders.Weight = 2D
            xlWorkSheet.Cells(dt.Rows.Count + 5, 1) = "Tổng lượng nguyên liệu nhập"
            xlWorkSheet.Cells(dt.Rows.Count + 5, 1).Font.Bold = True
            xlWorkSheet.Cells(dt.Rows.Count + 5, 1).Font.Italic = True
            If dt.Rows.Count > 0 Then
                xlWorkSheet.Cells(dt.Rows.Count + 5, "g").Formula = "=Sum(g5:g" + (dt.Rows.Count + 4).ToString + ")"
                xlWorkSheet.Cells(dt.Rows.Count + 5, "h").Formula = "=Sum(h5:h" + (dt.Rows.Count + 4).ToString + ")"
            Else
                xlWorkSheet.Cells(dt.Rows.Count + 5, "g").Formula = "0"
                xlWorkSheet.Cells(dt.Rows.Count + 5, "h").Formula = "0"
            End If
            xlWorkSheet.Range("g" + (dt.Rows.Count + 5).ToString).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range("g" + (dt.Rows.Count + 5).ToString).Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
            xlWorkSheet.Range("g" + (dt.Rows.Count + 5).ToString).Borders.Weight = 2D
            xlWorkSheet.Range("h" + (dt.Rows.Count + 5).ToString).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range("h" + (dt.Rows.Count + 5).ToString).Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
            xlWorkSheet.Range("h" + (dt.Rows.Count + 5).ToString).Borders.Weight = 2D
            Dim destinationPath As String = "E:\Quan ly can\Excel\Hangnhap\Tkhangnhap" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xlsx"
            xlWorkBook.SaveAs(destinationPath)
            xlWorkBook.Close(False)
            xlApp.Workbooks.Close()
            xlApp.Quit()
            Process.Start(destinationPath)
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)

            'Print excel xuat
        ElseIf rbtHangxuat.Checked = True Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim sourcePath As String = "E:\Quan ly can\Templae\Templatexuat.xls"
            xlApp = New Excel.Application()
            xlWorkBook = xlApp.Workbooks.Add(sourcePath)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet.Range("F2").Value = Format(timeFrom, "dd/MM/yyyy")
            xlWorkSheet.Range("H2").Value = Format(timeTo, "dd/MM/yyyy")
            Dim dt As System.Data.DataTable = dtTemp
            Dim dc As DataColumn
            Dim dr As DataRow
            Dim colIndex As Integer = 1
            Dim rowIndex As Integer = 3
            Dim stt As Integer = 0
            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    If colIndex = 1 Then
                        xlWorkSheet.Cells(rowIndex + 1, colIndex) = "'" & dr(dc.ColumnName)
                    Else
                        xlWorkSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    End If
                Next
            Next
            If dt.Rows.Count > 0 Then
                xlWorkSheet.Range("a5", "k" + (dt.Rows.Count + 4).ToString).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("a5", "k" + (dt.Rows.Count + 4).ToString).Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                xlWorkSheet.Range("a5", "k" + (dt.Rows.Count + 4).ToString).Borders.Weight = 2D
            End If
            xlWorkSheet.Range("a" + (dt.Rows.Count + 5).ToString, "f" + (dt.Rows.Count + 5).ToString).Merge()
            xlWorkSheet.Range("a" + (dt.Rows.Count + 5).ToString, "f" + (dt.Rows.Count + 5).ToString).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range("a" + (dt.Rows.Count + 5).ToString, "f" + (dt.Rows.Count + 5).ToString).Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
            xlWorkSheet.Range("a" + (dt.Rows.Count + 5).ToString, "f" + (dt.Rows.Count + 5).ToString).Borders.Weight = 2D
            xlWorkSheet.Cells(dt.Rows.Count + 5, 1) = "Tổng lượng nguyên liệu xuất"
            xlWorkSheet.Cells(dt.Rows.Count + 5, 1).Font.Italic = True
            xlWorkSheet.Cells(dt.Rows.Count + 5, 1).Font.Bold = True
            If dt.Rows.Count > 0 Then
                xlWorkSheet.Cells(dt.Rows.Count + 5, "g").Formula = "=Sum(g5:g" + (dt.Rows.Count + 4).ToString + ")"
                xlWorkSheet.Cells(dt.Rows.Count + 5, "h").Formula = "=Sum(h5:h" + (dt.Rows.Count + 4).ToString + ")"
            Else
                xlWorkSheet.Cells(dt.Rows.Count + 5, "g").Formula = "0"
                xlWorkSheet.Cells(dt.Rows.Count + 5, "h").Formula = "0"
            End If
            xlWorkSheet.Range("g" + (dt.Rows.Count + 5).ToString).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range("g" + (dt.Rows.Count + 5).ToString).Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
            xlWorkSheet.Range("g" + (dt.Rows.Count + 5).ToString).Borders.Weight = 2D
            xlWorkSheet.Range("h" + (dt.Rows.Count + 5).ToString).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range("h" + (dt.Rows.Count + 5).ToString).Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
            xlWorkSheet.Range("h" + (dt.Rows.Count + 5).ToString).Borders.Weight = 2D
            Dim destinationPath As String = "E:\Quan ly can\Excel\Hangxuat\Tkhangxuat" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xlsx"
            xlWorkBook.SaveAs(destinationPath)
            xlWorkBook.Close(False)
            xlApp.Workbooks.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
            Process.Start(destinationPath)
        End If
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub btnExit_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnExit.ClickButtonArea
        Me.Close()
    End Sub


    Private Sub btnView_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnView.ClickButtonArea
        Dim frm As New Xemhang
        value = cbbSopieu.Text()
        timeFrom = DateTime.ParseExact(dtpfrom.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
        timeTo = DateTime.ParseExact(dtpTo.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
        If cbXemhangton.Checked = False Then
            hangton = False
            If rbtHangnhap.Checked Then
                flag = True
            ElseIf rbtHangxuat.Checked Then
                flag = False
            End If
        ElseIf cbXemhangton.Checked = True Then
            hangton = True
        End If
        frm.ShowDialog()
    End Sub
    Public Function GetdataView() As DataTable
        Dim da As OleDbDataAdapter
        Dim sql As String
        connectdb()
        If flag = True Then
            sql = "SELECT Sophieu As [Số phiếu], Sttme As [Số thứ tự], Mahhn As [Mã hàng nhập], Tenhhn As [Tên hàng nhập], " _
                        & "Klndau As [KL đầu (Kg)], Klncuoi As [KL cuối (Kg)], KlNln As [KL nhập (Kg)],  Kllt As [KL nhập lt (Kg)], " _
                        & "Format(Ngayn,'dd/mm/yyyy') As [Ngày nhập], Format(Gion,'hh:mm:ss AM/PM') As [Giờ nhập], Ghichu As [Ghi chú] " _
                & " FROM Phieunhap " _
                & " WHERE 1 = 1" _
                      & " AND Ngayn BETWEEN #" & timeFrom & "# AND #" & timeTo & "#"
            If value <> "" Then
                sql = sql & " AND [Sophieu] = '" & value & "'"
            End If
            sql = sql & " ORDER BY Ngayn, Sophieu "
            da = New OleDbDataAdapter(sql, con)
        Else
            sql = "SELECT Sophieu As [Số phiếu], Sttmex As [Số thứ tự], Mahhx As [Mã hàng xuất], Tenhhx As [Tên hàng xuất], " _
                        & "Klxdau As [KL đầu (Kg)], Klxcuoi As [KL cuối (Kg)], KlNl As [KL xuất (Kg)],  Kllt As [KL xuất lt (Kg)], " _
                        & "Format(Ngayx,'dd/mm/yyyy') As [Ngày xuất], Format(Giox,'hh:mm:ss AM/PM') As [Giờ xuất], Ghichu As [Ghi chú] " _
                & " FROM Phieuxa " _
                & " WHERE 1 = 1 " _
                      & " AND Ngayx BETWEEN #" & timeFrom & "# AND #" & timeTo & "#"
            If value <> "" Then
                sql = sql & " AND [Sophieu] = '" & value & "'"
            End If
            sql = sql & " ORDER BY Ngayx, Sophieu "
            da = New OleDbDataAdapter(sql, con)
        End If
        Dim dt As New DataTable
        da.Fill(dt)
        disconnectdb()
        Return dt
    End Function
    Private Function getfromtimeHangnhap() As DataTable
        Dim da As OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        sql = "SELECT Format(Ngayn,'dd/mm/yyyy'), Format(Gion,'hh:mm:ss AM/PM') " _
            & "  FROM Phieunhap " _
            & "  WHERE Ngayn < #" & timeFrom & "#" _
            & "  ORDER BY Ngayn DESC, Gion DESC"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt)
        Return dt
    End Function
    Private Function gettimeHangnhap() As DataTable
        Dim da As OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        sql = "SELECT Format(Ngayn,'dd/mm/yyyy'), Format(Gion,'hh:mm:ss AM/PM') " _
            & "  FROM Phieunhap " _
            & "  WHERE Ngayn <= #" & timeTo & "#" _
            & "  ORDER BY Ngayn DESC, Gion DESC"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt)
        Return dt
    End Function
    Private Function getfromtimeHangxuat() As DataTable
        Dim da As OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String = ""
        sql = "SELECT Format(Ngayx,'dd/mm/yyyy'), Format(Giox,'hh:mm:ss AM/PM')  " _
            & "  FROM Phieuxa " _
            & "  WHERE Ngayx < #" & timeFrom & "#" _
            & "  ORDER BY Ngayx DESC, Giox DESC"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt)
        Return dt
    End Function
    Private Function gettimeHangxuat() As DataTable
        Dim da As OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String = ""
        sql = "SELECT Format(Ngayx,'dd/mm/yyyy'), Format(Giox,'hh:mm:ss AM/PM')  " _
            & "  FROM Phieuxa " _
            & "  WHERE Ngayx <= #" & timeTo & "#" _
            & "  ORDER BY Ngayx DESC, Giox DESC"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt)
        Return dt
    End Function
    Public Function GetdataHangton() As DataTable
        Dim da As OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        connectdb()
        If System.DateTime.Equals(timeFrom, timeTo) = True Then

            sql = "SELECT TOP 1 Klxdau As [TỒN ĐẦU KỲ (kg)], " _
                        & "( SELECT sum(KlNln)  " _
                        & "  FROM Phieunhap " _
                        & "  WHERE (IsNull(Flag) OR Flag = 0) AND Ngayn BETWEEN #" & timeFrom & "# AND #" & timeTo & "#" _
                        & ") As [TỔNG NHẬP (kg)], " _
                        & "( SELECT sum(klnl) " _
                        & "  FROM Phieuxa " _
                        & "  WHERE (IsNull(Flag) OR Flag = 0) AND Ngayx BETWEEN #" & timeFrom & "# AND #" & timeTo & "#" _
                        & ") As [TỔNG XUẤT (kg)], Klxcuoi As [TỒN (kg)] " _
                & "  FROM Phieuxa " _
                & "  WHERE (IsNull(Flag) OR Flag = 0) " _
                & "  ORDER BY Ngayx DESC,Giox DESC "
        ElseIf System.DateTime.Equals(timeFrom, timeTo) = False Then
            Dim timenhap As DataTable = gettimeHangnhap()
            If timenhap.Rows.Count = 0 Then
                MessageBox.Show("Dữ liệu không có trong db.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return Nothing
            End If
            Dim timexuat As DataTable = gettimeHangxuat()
            If timexuat.Rows.Count = 0 Then
                MessageBox.Show("Dữ liệu không có trong db.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return Nothing
            End If
            Dim timefromnhap As DataTable = getfromtimeHangnhap()
            Dim timefromxuat As DataTable = getfromtimeHangxuat()
            If timenhap(0)(0).ToString > timexuat(0)(0).ToString Or (timenhap(0)(0).ToString = timexuat(0)(0).ToString And timenhap(0)(1).ToString > timexuat(0)(1).ToString) Then

                If timefromnhap.Rows.Count = 0 Then
                    sql = "SELECT DISTINCT 0 As [TỒN ĐẦU KỲ (kg)], " _
                        & "( SELECT SUM(KlNln) " _
                        & "  FROM Phieunhap " _
                        & "  WHERE Ngayn BETWEEN #" & timeFrom & "# AND #" & timeTo & "#" _
                        & ") As [TỔNG NHẬP (kg)], " _
                        & "( SELECT SUM(KlNl) " _
                        & "  FROM Phieuxa " _
                        & "  WHERE Ngayx BETWEEN #" & timeFrom & "# AND #" & timeTo & "#" _
                        & ") As [TỔNG XUẤT (kg)], " _
                        & "([TỒN ĐẦU KỲ (kg)] + IIF(ISNULL([TỔNG NHẬP (kg)]),0,[TỔNG NHẬP (kg)]) - IIF(ISNULL([TỔNG XUẤT (kg)]),0,[TỔNG XUẤT (kg)])) As [TỒN (kg)] " _
                        & "  FROM Phieunhau "
                Else
                    sql = "SELECT TOP 1 Klncuoi As [TỒN ĐẦU KỲ (kg)], " _
                        & "( SELECT SUM(KlNln) " _
                        & "  FROM Phieunhap " _
                        & "  WHERE Ngayn BETWEEN #" & timeFrom & "# AND #" & timeTo & "#" _
                        & ") As [TỔNG NHẬP (kg)], " _
                        & "( SELECT SUM(KlNl) " _
                        & "  FROM Phieuxa " _
                        & "  WHERE Ngayx BETWEEN #" & timeFrom & "# AND #" & timeTo & "#" _
                        & ") As [TỔNG XUẤT (kg)], " _
                        & "([TỒN ĐẦU KỲ (kg)] + IIF(ISNULL([TỔNG NHẬP (kg)]),0,[TỔNG NHẬP (kg)]) - IIF(ISNULL([TỔNG XUẤT (kg)]),0,[TỔNG XUẤT (kg)])) As [TỒN (kg)] " _
                        & "  FROM Phieunhau " _
                        & "  WHERE Ngayn < #" & timeFrom & "#" _
                        & "  ORDER BY Ngayn DESC, Gion DESC"
                End If
            ElseIf timenhap(0)(0).ToString < timexuat(0)(0).ToString Or (timenhap(0)(0).ToString = timexuat(0)(0).ToString And timenhap(0)(1).ToString < timexuat(0)(1).ToString) Then
                If timefromxuat.Rows.Count = 0 Then
                    sql = "SELECT DISTINCT 0 As [TỒN ĐẦU KỲ (kg)], " _
                        & "( SELECT SUM(KlNln) " _
                        & "  FROM Phieunhap " _
                        & "  WHERE Ngayn BETWEEN #" & timeFrom & "# AND #" & timeTo & "#" _
                        & ") As [TỔNG NHẬP (kg)], " _
                        & "( SELECT SUM(KlNl) " _
                        & "  FROM Phieuxa " _
                        & "  WHERE Ngayx BETWEEN #" & timeFrom & "# AND #" & timeTo & "#" _
                        & ") As [TỔNG XUẤT (kg)], " _
                        & "([TỒN ĐẦU KỲ (kg)] + IIF(ISNULL([TỔNG NHẬP (kg)]),0,[TỔNG NHẬP (kg)]) - IIF(ISNULL([TỔNG XUẤT (kg)]),0,[TỔNG XUẤT (kg)])) As [TỒN (kg)] " _
                        & "  FROM Phieuxa "
                Else
                    sql = "SELECT TOP 1 Klxcuoi As [TỒN ĐẦU KỲ (kg)], " _
                        & "( SELECT SUM(KlNln) " _
                        & "  FROM Phieunhap " _
                        & "  WHERE Ngayn BETWEEN #" & timeFrom & "# AND #" & timeTo & "#" _
                        & ") As [TỔNG NHẬP (kg)], " _
                        & "( SELECT SUM(KlNl) " _
                        & "  FROM Phieuxa " _
                        & "  WHERE Ngayx BETWEEN #" & timeFrom & "# AND #" & timeTo & "#" _
                        & ") As [TỔNG XUẤT (kg)], " _
                        & "([TỒN ĐẦU KỲ (kg)] + IIF(ISNULL([TỔNG NHẬP (kg)]),0,[TỔNG NHẬP (kg)]) - IIF(ISNULL([TỔNG XUẤT (kg)]),0,[TỔNG XUẤT (kg)])) As [TỒN (kg)] " _
                        & "  FROM Phieuxa " _
                        & "  WHERE Ngayx < #" & timeFrom & "#" _
                        & "  ORDER BY Ngayx DESC, Giox DESC"
                End If
                
            End If
        End If
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt)
        disconnectdb()
        Return dt
    End Function
    Private Sub rbtHangnhap_CheckedChanged(sender As Object, e As EventArgs) Handles rbtHangnhap.CheckedChanged
        getSophieu()
    End Sub
    Private Sub rbtHangxuat_CheckedChanged(sender As Object, e As EventArgs) Handles rbtHangxuat.CheckedChanged
        getSophieu()
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class KasirNavigationForm
    Dim PD As PrintDocument
    Dim PDD As New PrintPreviewDialog

    Sub kosong()
        cbtipe.Text = ""
        txtnorsp.Text = ""
        txtnamapasien.Text = ""
        txtnamadokter.Text = ""
        txtnamaobat.Text = ""
        txtharga.Text = ""
        txtquantity.Text = ""
        txtkembali.Text = ""
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub KasirNavigationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim jml As Integer
        dgvtransaksi.Rows.Add(cbtipe.Text, txtnorsp.Text, dttglresep.Value, txtnamapasien.Text, txtnamadokter.Text, txtnamaobat.Text, txtharga.Text, txtquantity.Text)
        For baris As Integer = 0 To dgvtransaksi.Rows.Count - 1
            jml = jml + ((dgvtransaksi.Rows(baris).Cells(6).Value) * (dgvtransaksi.Rows(baris).Cells(7).Value))
        Next
        Label4.Text = jml
        kosong()
    End Sub
    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Then
            MsgBox("Pastikan hanya angka yg di inputkan")
            e.Handled = True
        End If
    End Sub
    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan hanya angka yg di input")
            e.Handled = True
        End If
    End Sub

    Private Sub txtkembali_TextChanged(sender As Object, e As EventArgs) Handles txtkembali.TextChanged
        Label2.Text = Val(txtkembali.Text) - Val(Label4.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        connect()
        For baris1 As Integer = 0 To dgvtransaksi.Rows.Count - 2
            sql = "SELECT * FROM Tbl_Transaksi WHERE no_transaksi in(SELECT max(no_transaksi)FROM Tbl_Transaksi)"
            cmd = New SqlCommand(sql, con)
            Dim notransaksi As String
            Dim hit As Long
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                notransaksi = Format(Now, "yyMMdd") + "0001"
            Else
                hit = Microsoft.VisualBasic.Right(rd.GetInt32(0), 11) + 1
                notransaksi = Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hit, 4)
            End If
            rd.Close()

            sql = "INSERT into Tbl_Transaksi(no_transaksi, tgl_transaksi, total_bayar, id_user, id_obat, id_resep) VALUES ('" & notransaksi & "', '" & Format(dttglresep.Value, "yyyy-MM-dd") & "', '" & Label4.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Next
        MsgBox("sukses tambah data")
        dgvtransaksi.Rows.Clear()
        kosong()
    End Sub
    Private Sub txtnamaobat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnamaobat.KeyPress
        connect()
        sql = "SELECT id_obat,harga FROM Tbl_Obat WHERE nama_obat = '" & Trim(txtnamaobat.Text) & "' "
        cmd = New SqlCommand(sql, con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtharga.Text = rd.Item("harga")
            TextBox2.Text = rd.Item("id_obat")
        End If
    End Sub
    Private Sub txtnorsp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnorsp.KeyPress
        connect()
        sql = "SELECT id_resep FROM Tbl_Resep WHERE no_resep = '" & Trim(txtnorsp.Text) & "'"
        cmd = New SqlCommand(sql, con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox3.Text = rd.Item("id_resep")
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        printPD()
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim tinggi As Integer
        e.Graphics.DrawString("APOTIK XYZ", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("No Tlp: 0812", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Jl.Sukamulya", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 20
        e.Graphics.DrawString("--------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Barang" & vbTab & vbTab & "QTY" & vbTab & "total", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        For Each data As DataGridViewRow In dgvtransaksi.Rows
            tinggi = tinggi + 10
            e.Graphics.DrawString(data.Cells(5).Value, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

            tinggi = tinggi + 10
            e.Graphics.DrawString(vbTab & vbTab & data.Cells(6).Value & vbTab & data.Cells(7).Value, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
        Next


        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)


        tinggi = tinggi + 10
        e.Graphics.DrawString("Total" & vbTab & vbTab & ":" & Label4.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Tunai" & vbTab & vbTab & ":" & txtkembali.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Kembali" & vbTab & ":" & Label2.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Terimakasih...!!!", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
    End Sub

    Sub printPD()
        PrintDoc.PrinterSettings.PrinterName = "Adobe PDF"
        PrintDoc.Print()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgvtransaksi.CurrentRow.Index <> dgvtransaksi.NewRowIndex Then
            dgvtransaksi.Rows.RemoveAt(dgvtransaksi.CurrentRow.Index)
        End If
    End Sub

    Private Sub PrintDoc_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDoc.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 250, 300)
        PrintDoc.DefaultPageSettings = pagesetup
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ExcelApp As Object, Excelbook As Object
        Dim ExcelSheet As Object
        ExcelApp = CreateObject("Excel.Application")
        Excelbook = ExcelApp.Workbooks.Add
        ExcelSheet = Excelbook.worksheets(1)
        With ExcelSheet

            For a = 0 To dgvtransaksi.RowCount - 2
                For b = 0 To dgvtransaksi.ColumnCount - 1
                    For c As Integer = 1 To dgvtransaksi.Columns.Count
                        ExcelSheet.cells(1, c) = dgvtransaksi.Columns(c - 1).HeaderText
                        ExcelSheet.cells(a + 2, b + 1) = dgvtransaksi(b, a).Value.ToString()
                    Next
                Next
            Next

        End With
        ExcelApp.visible = True
        ExcelSheet = Nothing
        Excelbook = Nothing
        ExcelApp = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged

    End Sub
End Class
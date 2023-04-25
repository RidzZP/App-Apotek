Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class KelolaObatForm
    Sub aturdgv()
        sql = "SELECT * FROM Tbl_Obat"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "Tbl_Obat")
        dgv_obat.DataSource = ds.Tables("Tbl_Obat")
    End Sub

    Sub kosong()
        txtkodeobat.Text = ""
        txtnamaobat.Text = ""
        txtjumlah.Text = ""
        txtharga.Text = ""
        txtcari.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KelolaUserForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If txtkodeobat.Text = "" And txtnamaobat.Text = "" And txtjumlah.Text = "" And txtharga.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "Insert into Tbl_Obat(kode_obat, nama_obat, expired_date, jumlah, harga) VALUES ('" & txtkodeobat.Text & "', '" & txtnamaobat.Text & "', '" & Format(dtexpired.Value, "yyyy-MM-dd") & "', '" & txtjumlah.Text & "', '" & txtharga.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub KelolaObatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        connect()
        If txtkodeobat.Text = "" And txtnamaobat.Text = "" And txtjumlah.Text = "" And txtharga.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "UPDATE Tbl_Obat set kode_obat='" & txtkodeobat.Text & "', nama_obat='" & txtnamaobat.Text & "', expired_date='" & Format(dtexpired.Value, "yyyy-MM-dd") & "', jumlah='" & txtjumlah.Text & "', harga='" & txtharga.Text & "' WHERE id_obat='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        connect()
        If txtkodeobat.Text = "" And txtnamaobat.Text = "" And txtjumlah.Text = "" And txtharga.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = " DELETE FROM Tbl_Obat WHERE id_obat='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Hapus Data")
            aturdgv()
            kosong()
        End If
    End Sub
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * FROM Tbl_Obat Where(nama_obat like '%" & txtcari.Text & "%') "
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "Tbl_Obat")
        dgv_obat.DataSource = ds.Tables("Tbl_Obat")
    End Sub
    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka yang di inputkan")
            e.Handled = True
        End If
    End Sub
    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan hanya angka yang di input")
            e.Handled = True
        End If
    End Sub
    Private Sub dgv_obat_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_obat.MouseClick
        txtid.Text = dgv_obat.Rows(dgv_obat.CurrentRow.Index).Cells(0).Value
        txtkodeobat.Text = dgv_obat.Rows(dgv_obat.CurrentRow.Index).Cells(1).Value
        txtnamaobat.Text = dgv_obat.Rows(dgv_obat.CurrentRow.Index).Cells(2).Value
        dtexpired.Value = dgv_obat.Rows(dgv_obat.CurrentRow.Index).Cells(3).Value
        txtjumlah.Text = dgv_obat.Rows(dgv_obat.CurrentRow.Index).Cells(4).Value
        txtharga.Text = dgv_obat.Rows(dgv_obat.CurrentRow.Index).Cells(5).Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KelolaLaporanForm.Show()
        Me.Hide()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Export.Click
        Dim ExcelApp As Object, Excelbook As Object
        Dim ExcelSheet As Object
        ExcelApp = CreateObject("Excel.Application")
        Excelbook = ExcelApp.Workbooks.Add
        ExcelSheet = Excelbook.worksheets(1)
        With ExcelSheet

            For a = 0 To dgv_obat.RowCount - 2
                For b = 0 To dgv_obat.ColumnCount - 1
                    For c As Integer = 1 To dgv_obat.Columns.Count
                        ExcelSheet.cells(1, c) = dgv_obat.Columns(c - 1).HeaderText
                        ExcelSheet.cells(a + 2, b + 1) = dgv_obat(b, a).Value.ToString()
                    Next
                Next
            Next

        End With
        ExcelApp.visible = True
        ExcelSheet = Nothing
        Excelbook = Nothing
        ExcelApp = Nothing
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class
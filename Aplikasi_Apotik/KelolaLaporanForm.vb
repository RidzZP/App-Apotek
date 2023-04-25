Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class KelolaLaporanForm
    Private Sub KelolaLaporanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KelolaUserForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KelolaObatForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sql = "SELECT tgl_transaksi, total_bayar from Tbl_Transaksi WHERE tgl_transaksi between '" & dtdari.Value.Date.ToString("MM/dd/yyyy") & "' and '" & dtsampai.Value.Date.ToString("MM/dd/yyyy") & "'"

        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "Tbl_Transaksi")
        dgv_laporan.DataSource = ds.Tables("Tbl_Transaksi")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sql = "SELECT tgl_transaksi, total_bayar from Tbl_Transaksi WHERE tgl_transaksi between '" & dtdari.Value.Date.ToString("MM/dd/yyyy") & "' and '" & dtsampai.Value.Date.ToString("MM/dd/yyyy") & "'"
        cmd = New SqlCommand(sql, con)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ChartLaporan.Series("omset").Points.AddXY(Microsoft.VisualBasic.Left(rd("tgl_transaksi").ToString, 10), rd("total_bayar").ToString)
        Loop
        rd.Close()
    End Sub
End Class
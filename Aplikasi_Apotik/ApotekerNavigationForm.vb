Imports System.Data.SqlClient
Public Class ApotekerNavigationForm
    Sub aturgdv()
        sql = "SELECT * FROM Tbl_Resep"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "Tbl_Resep")
        dgv_resep.DataSource = ds.Tables("Tbl_Resep")
    End Sub
    Sub kosong()
        txtnoresep.Text = ""
        txtnamapasien.Text = ""
        txtnamadokter.Text = ""
        txtnamaobat.Text = ""
        txtquantity.Text = ""
        txtcari.Text = ""
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtnamadokter.TextChanged

    End Sub

    Private Sub ApotekerNavigationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturgdv()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect()

        If txtnoresep.Text = "" And txtnamapasien.Text = "" And txtnamadokter.Text = "" And txtnamaobat.Text = "" And txtquantity.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "INSERT into Tbl_Resep (no_resep, tgl_resep, nama_pasien, nama_dokter, nama_obatdibeli, jumlah_obatdibeli) values ('" & txtnoresep.Text & "', '" & Format(dttglresep.Value, "yyyy-MM-dd") & "', '" & txtnamapasien.Text & "', '" & txtnamadokter.Text & "', '" & txtnamaobat.Text & "', '" & txtquantity.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturgdv()
            kosong()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()

        If txtnoresep.Text = "" And txtnamapasien.Text = "" And txtnamadokter.Text = "" And txtnamaobat.Text = "" And txtquantity.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "UPDATE Tbl_Resep set no_resep='" & txtnoresep.Text & "', tgl_resep='" & Format(dttglresep.Value, "yyyy-MM-dd") & "', nama_pasien='" & txtnamapasien.Text & "', nama_dokter='" & txtnamadokter.Text & "', nama_obatdibeli='" & txtnamaobat.Text & "', jumlah_obatdibeli='" & txtquantity.Text & "'WHERE id_resep='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturgdv()
            kosong()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()

        If txtnoresep.Text = "" And txtnamapasien.Text = "" And txtnamadokter.Text = "" And txtnamaobat.Text = "" And txtquantity.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "DELETE FROM Tbl_Resep WHERE id_resep='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil hapus Data")
            aturgdv()
            kosong()
        End If
    End Sub
    Private Sub dgv_resep_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_resep.MouseClick
        txtid.Text = dgv_resep.Rows(dgv_resep.CurrentRow.Index).Cells(0).Value
        txtnoresep.Text = dgv_resep.Rows(dgv_resep.CurrentRow.Index).Cells(1).Value
        dttglresep.Value = dgv_resep.Rows(dgv_resep.CurrentRow.Index).Cells(2).Value
        txtnamapasien.Text = dgv_resep.Rows(dgv_resep.CurrentRow.Index).Cells(3).Value
        txtnamadokter.Text = dgv_resep.Rows(dgv_resep.CurrentRow.Index).Cells(4).Value
        txtnamaobat.Text = dgv_resep.Rows(dgv_resep.CurrentRow.Index).Cells(5).Value
        txtquantity.Text = dgv_resep.Rows(dgv_resep.CurrentRow.Index).Cells(6).Value
    End Sub
End Class
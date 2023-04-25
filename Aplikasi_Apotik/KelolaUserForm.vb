Imports System.Data.SqlClient
Public Class KelolaUserForm
    Sub aturdgv()
        sql = "SELECT * FROM Tbl_User"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "Tbl_User")
        dgv_user.DataSource = ds.Tables("Tbl_User")
    End Sub

    Sub kosong()
        cbtipe.Text = ""
        txtnama.Text = ""
        txttelepon.Text = ""
        txtalamat.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtcari.Text = ""
    End Sub
    Private Sub KelolaUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If cbtipe.Text = "" And txtnama.Text = "" And txttelepon.Text = "" And txtalamat.Text = "" And txtusername.Text = "" And txtpassword.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "INSERT into Tbl_User (tipe_user, nama_user, alamat, telepon, username, password) VALUES ('" & cbtipe.Text & "', '" & txtnama.Text & "','" & txtalamat.Text & "', '" & txttelepon.Text & "', '" & txtusername.Text & "', '" & txtpassword.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil tambah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        connect()
        If cbtipe.Text = "" And txtnama.Text = "" And txttelepon.Text = "" And txtalamat.Text = "" And txtusername.Text = "" And txtpassword.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "UPDATE Tbl_User set tipe_user='" & cbtipe.Text & "',nama_user= '" & txtnama.Text & "',alamat='" & txtalamat.Text & "', telepon='" & txttelepon.Text & "', username='" & txtusername.Text & "', password='" & txtpassword.Text & "' where id_user='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil edit data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        connect()
        If cbtipe.Text = "" And txtnama.Text = "" And txttelepon.Text = "" And txtalamat.Text = "" And txtusername.Text = "" And txtpassword.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "DELETE FROM Tbl_User where id_user='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil hapus data")
            aturdgv()
            kosong()
        End If
    End Sub
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * From Tbl_User Where (nama_user like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "Tbl_user")
        dgv_user.DataSource = ds.Tables("Tbl_User")
    End Sub
    Private Sub dgv_user_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_user.MouseClick
        txtid.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        cbtipe.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtnama.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
        txtalamat.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(3).Value
        txttelepon.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(4).Value
        txtusername.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(5).Value
        txtpassword.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(6).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KelolaObatForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KelolaLaporanForm.Show()
        Me.Hide()
    End Sub

    Private Sub dgv_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_user.CellContentClick

    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged

    End Sub
End Class
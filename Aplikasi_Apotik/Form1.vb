Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect()
        If txtusnm.Text = "" And txtpass.Text = "" Then
            MsgBox("Pastikan Mengisi Semua Field")
        Else
            sql = "SELECT id_user, tipe_user, nama_user, username, password FROM Tbl_User WHERE username='" & Trim(txtusnm.Text) & "' and password='" & Trim(txtpass.Text) & "'"
            cmd = New SqlCommand(sql, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If rd.Item("tipe_user").Equals("Admin") Then
                    AdminNavigationForm.Show()
                    Me.Hide()
                ElseIf rd.Item("tipe_user").Equals("Kasir") Then
                    KasirNavigationForm.Show()
                    Me.Hide()
                    KasirNavigationForm.Label13.Text = rd.Item("nama_user")
                    KasirNavigationForm.TextBox1.Text = rd.Item("id_user")
                ElseIf rd.Item("tipe_user").Equals("Apoteker") Then
                    ApotekerNavigationForm.Show()
                    Me.Hide()
                Else
                    MsgBox("Username atau password yang anda masukan tidak sesuai")
                    rd.Close()
                End If
            Else
                MsgBox("Username atau password yang anda masukan tidak sesuai")
                rd.Close()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

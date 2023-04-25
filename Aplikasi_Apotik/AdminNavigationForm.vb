Imports System.Data.SqlClient
Public Class AdminNavigationForm
    Sub aturdgv()
        sql = "SELECT * FROM Tbl_Log"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "Tbl_Log")
        dgvadmin.DataSource = ds.Tables("Tbl_Log")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sql = "SELECT * FROM Tbl_Log WHERE waktu = '" & dtadmin.Value & "'"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "Tbl_Log")
        dgvadmin.DataSource = ds.Tables("Tbl_Log")
    End Sub

    Private Sub AdminNavigationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub
End Class
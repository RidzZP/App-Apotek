<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KelolaObatForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.dgv_obat = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtnamaobat = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtkodeobat = New System.Windows.Forms.TextBox()
        Me.dtexpired = New System.Windows.Forms.DateTimePicker()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Export = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_obat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 446)
        Me.Panel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(0, 370)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(185, 43)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(0, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(185, 45)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Kelola Laporan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 46)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Kelola Obat"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Kelola User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Apotik.My.Resources.Resources.admin1
        Me.PictureBox1.Location = New System.Drawing.Point(40, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(433, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kelola Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(538, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Harga Per Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(538, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Expired Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nama Obat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Kode Obat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(552, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "cari"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(287, 216)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Tambah"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(368, 216)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Edit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(449, 216)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Hapus"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'dgv_obat
        '
        Me.dgv_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_obat.Location = New System.Drawing.Point(241, 261)
        Me.dgv_obat.Name = "dgv_obat"
        Me.dgv_obat.Size = New System.Drawing.Size(511, 167)
        Me.dgv_obat.TabIndex = 12
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(597, 213)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(100, 20)
        Me.txtcari.TabIndex = 13
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(541, 122)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(156, 20)
        Me.txtharga.TabIndex = 14
        '
        'txtnamaobat
        '
        Me.txtnamaobat.Location = New System.Drawing.Point(288, 122)
        Me.txtnamaobat.Name = "txtnamaobat"
        Me.txtnamaobat.Size = New System.Drawing.Size(155, 20)
        Me.txtnamaobat.TabIndex = 15
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(541, 71)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(156, 20)
        Me.txtjumlah.TabIndex = 16
        '
        'txtkodeobat
        '
        Me.txtkodeobat.Location = New System.Drawing.Point(288, 71)
        Me.txtkodeobat.Name = "txtkodeobat"
        Me.txtkodeobat.Size = New System.Drawing.Size(155, 20)
        Me.txtkodeobat.TabIndex = 17
        '
        'dtexpired
        '
        Me.dtexpired.Location = New System.Drawing.Point(288, 171)
        Me.dtexpired.Name = "dtexpired"
        Me.dtexpired.Size = New System.Drawing.Size(155, 20)
        Me.dtexpired.TabIndex = 18
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(929, 202)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 19
        '
        'Export
        '
        Me.Export.Location = New System.Drawing.Point(772, 343)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(96, 23)
        Me.Export.TabIndex = 20
        Me.Export.Text = "Export to excel"
        Me.Export.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(772, 382)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 23)
        Me.Button9.TabIndex = 21
        Me.Button9.Text = "import"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(772, 303)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 23)
        Me.Button8.TabIndex = 22
        Me.Button8.Text = "Export to pdf"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'KelolaObatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(890, 450)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.dtexpired)
        Me.Controls.Add(Me.txtkodeobat)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtnamaobat)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.dgv_obat)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KelolaObatForm"
        Me.Text = "KelolaObatForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_obat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents dgv_obat As DataGridView
    Friend WithEvents txtcari As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtnamaobat As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtkodeobat As TextBox
    Friend WithEvents dtexpired As DateTimePicker
    Friend WithEvents txtid As TextBox
    Friend WithEvents Export As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button8 As Button
End Class

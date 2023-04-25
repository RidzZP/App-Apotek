<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApotekerNavigationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dttglresep = New System.Windows.Forms.DateTimePicker()
        Me.txtnoresep = New System.Windows.Forms.TextBox()
        Me.txtnamapasien = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtnamaobat = New System.Windows.Forms.TextBox()
        Me.txtnamadokter = New System.Windows.Forms.TextBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgv_resep = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_resep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 452)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "APOTEKER"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 48)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(471, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "cari"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(471, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(471, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nama Obat"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(471, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nama Dokter"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(268, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nama Pasien"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(268, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tgl Resep"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(268, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "No Resep"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(171, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 24)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Kelola Resep"
        '
        'dttglresep
        '
        Me.dttglresep.Location = New System.Drawing.Point(340, 144)
        Me.dttglresep.Name = "dttglresep"
        Me.dttglresep.Size = New System.Drawing.Size(100, 20)
        Me.dttglresep.TabIndex = 11
        '
        'txtnoresep
        '
        Me.txtnoresep.Location = New System.Drawing.Point(340, 89)
        Me.txtnoresep.Name = "txtnoresep"
        Me.txtnoresep.Size = New System.Drawing.Size(100, 20)
        Me.txtnoresep.TabIndex = 12
        '
        'txtnamapasien
        '
        Me.txtnamapasien.Location = New System.Drawing.Point(340, 193)
        Me.txtnamapasien.Name = "txtnamapasien"
        Me.txtnamapasien.Size = New System.Drawing.Size(100, 20)
        Me.txtnamapasien.TabIndex = 13
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(545, 193)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(100, 20)
        Me.txtquantity.TabIndex = 14
        '
        'txtnamaobat
        '
        Me.txtnamaobat.Location = New System.Drawing.Point(545, 142)
        Me.txtnamaobat.Name = "txtnamaobat"
        Me.txtnamaobat.Size = New System.Drawing.Size(100, 20)
        Me.txtnamaobat.TabIndex = 15
        '
        'txtnamadokter
        '
        Me.txtnamadokter.Location = New System.Drawing.Point(545, 92)
        Me.txtnamadokter.Name = "txtnamadokter"
        Me.txtnamadokter.Size = New System.Drawing.Size(100, 20)
        Me.txtnamadokter.TabIndex = 16
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(545, 242)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(100, 20)
        Me.txtcari.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(216, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(297, 237)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(378, 237)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dgv_resep
        '
        Me.dgv_resep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_resep.Location = New System.Drawing.Point(216, 288)
        Me.dgv_resep.Name = "dgv_resep"
        Me.dgv_resep.Size = New System.Drawing.Size(529, 150)
        Me.dgv_resep.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Apotik.My.Resources.Resources.apoteker
        Me.PictureBox1.Location = New System.Drawing.Point(27, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 54)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "KELOLA RESEP"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(930, 196)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 22
        '
        'ApotekerNavigationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(886, 450)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.dgv_resep)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtnamadokter)
        Me.Controls.Add(Me.txtnamaobat)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtnamapasien)
        Me.Controls.Add(Me.txtnoresep)
        Me.Controls.Add(Me.dttglresep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ApotekerNavigationForm"
        Me.Text = "ApotekerNavigationForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_resep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dttglresep As DateTimePicker
    Friend WithEvents txtnoresep As TextBox
    Friend WithEvents txtnamapasien As TextBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtnamaobat As TextBox
    Friend WithEvents txtnamadokter As TextBox
    Friend WithEvents txtcari As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgv_resep As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txtid As TextBox
End Class

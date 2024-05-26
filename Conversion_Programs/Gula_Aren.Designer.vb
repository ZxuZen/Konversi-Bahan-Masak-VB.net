<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gula_Aren
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtMasukan = New System.Windows.Forms.TextBox()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.cbKe = New System.Windows.Forms.ComboBox()
        Me.cbDari = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtHistori = New System.Windows.Forms.TextBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.txtMasukan)
        Me.Panel5.Controls.Add(Me.txtHasil)
        Me.Panel5.Controls.Add(Me.btnHapus)
        Me.Panel5.Controls.Add(Me.cbKe)
        Me.Panel5.Controls.Add(Me.cbDari)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Location = New System.Drawing.Point(225, 78)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(648, 423)
        Me.Panel5.TabIndex = 27
        '
        'txtMasukan
        '
        Me.txtMasukan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMasukan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMasukan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMasukan.Location = New System.Drawing.Point(227, 165)
        Me.txtMasukan.Multiline = True
        Me.txtMasukan.Name = "txtMasukan"
        Me.txtMasukan.Size = New System.Drawing.Size(387, 46)
        Me.txtMasukan.TabIndex = 12
        '
        'txtHasil
        '
        Me.txtHasil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasil.Location = New System.Drawing.Point(227, 285)
        Me.txtHasil.Multiline = True
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(387, 45)
        Me.txtHasil.TabIndex = 11
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(36, 290)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(158, 35)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'cbKe
        '
        Me.cbKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKe.Items.AddRange(New Object() {"glasses [250 mL]", "grams (g)", "kilogram (kg)", "liters (L)", "milliliters (mL)", "ounces (oz)", "pounds (lb)", "tablespoons [15 mL] (tbsp)", "teaspoons [5 mL] (tsp)", "uk cups (UK cup)", "us cups (US cup)"})
        Me.cbKe.Location = New System.Drawing.Point(373, 87)
        Me.cbKe.Name = "cbKe"
        Me.cbKe.Size = New System.Drawing.Size(259, 33)
        Me.cbKe.TabIndex = 8
        '
        'cbDari
        '
        Me.cbDari.BackColor = System.Drawing.SystemColors.Window
        Me.cbDari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDari.Items.AddRange(New Object() {"glasses [250 mL]", "grams (g)", "kilogram (kg)", "liters (L)", "milliliters (mL)", "ounces (oz)", "pounds (lb)", "tablespoons [15 mL] (tbsp)", "teaspoons [5 mL] (tsp)", "uk cups (UK cup)", "us cups (US cup)"})
        Me.cbDari.Location = New System.Drawing.Point(27, 87)
        Me.cbDari.Name = "cbDari"
        Me.cbDari.Size = New System.Drawing.Size(259, 33)
        Me.cbDari.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label4.Location = New System.Drawing.Point(308, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ke"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label3.Location = New System.Drawing.Point(12, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Masukkan Angka"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(648, 42)
        Me.Panel4.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(0, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 26)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "GULA AREN"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(8, 225)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(632, 39)
        Me.Panel6.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label5.Location = New System.Drawing.Point(226, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hasil Konversi"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Panel7.Controls.Add(Me.txtHistori)
        Me.Panel7.Controls.Add(Me.btnCopy)
        Me.Panel7.Location = New System.Drawing.Point(8, 344)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(632, 58)
        Me.Panel7.TabIndex = 6
        '
        'txtHistori
        '
        Me.txtHistori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistori.Location = New System.Drawing.Point(171, 7)
        Me.txtHistori.Multiline = True
        Me.txtHistori.Name = "txtHistori"
        Me.txtHistori.Size = New System.Drawing.Size(453, 45)
        Me.txtHistori.TabIndex = 13
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopy.Location = New System.Drawing.Point(19, 12)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(105, 35)
        Me.btnCopy.TabIndex = 9
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(16, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(188, 42)
        Me.Panel3.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(0, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "INGREDIENT'S "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Location = New System.Drawing.Point(16, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 425)
        Me.Panel2.TabIndex = 25
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"Air", "Beras", "Cabai Bubuk", "Garam Kasar", "Garam Meja/Halus", "Gula Aren", "Gula Pasir", "Heavy Cream", "Mentega", "Minyak Sayur", "Sirup Jagung", "Soda Kue", "Susu Kental Manis", "Tepung Roti", "Yoghurt"})
        Me.ListBox1.Location = New System.Drawing.Point(10, 55)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(167, 342)
        Me.ListBox1.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(336, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 50)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conversion"
        '
        'Gula_Aren
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(889, 513)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Gula_Aren"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversion"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtMasukan As TextBox
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents cbKe As ComboBox
    Friend WithEvents cbDari As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtHistori As TextBox
    Friend WithEvents btnCopy As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class

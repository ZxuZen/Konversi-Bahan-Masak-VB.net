Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class Utama
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem.ToString()
            Case "Air"
                Dim Banyu As New Air()
                Banyu.Show()
                Me.Hide()
            Case "Beras"
                Dim Upo As New Beras()
                Upo.Show()
                Me.Hide()
            Case "Cabai Bubuk"
                Dim Cabai As New Cabai_Bubuk()
                Cabai.Show()
                Me.Hide()
            Case "Garam Kasar"
                Dim UyaKasar As New Garam_Kasar()
                UyaKasar.Show()
                Me.Hide()
            Case "Garam Meja/Halus"
                Dim UyaAlus As New Garam_Meja()
                UyaAlus.Show()
                Me.Hide()
            Case "Gula Aren"
                Dim Aren As New Gula_Aren()
                Aren.Show()
                Me.Hide()
            Case "Gula Pasir"
                Dim Gula As New Gula_Pasir()
                Gula.Show()
                Me.Hide()
            Case "Heavy Cream"
                Dim Cream As New Heavy_Cream()
                Cream.Show()
                Me.Hide()
            Case "Mentega"
                Dim Mentega As New Mentega()
                Mentega.Show()
                Me.Hide()
            Case "Minyak Sayur"
                Dim Minyak As New Minyak_Sayur()
                Minyak.Show()
                Me.Hide()
            Case "Sirup Jagung"
                Dim Sirup As New Sirup_Jagung()
                Sirup.Show()
                Me.Hide()
            Case "Soda Kue"
                Dim Soda As New Soda_Kue()
                Soda.Show()
                Me.Hide()
            Case "Susu Kental Manis"
                Dim skm As New SKM()
                skm.Show()
                Me.Hide()
            Case "Tepung Roti"
                Dim Tepung As New Tepung_Roti()
                Tepung.Show()
                Me.Hide()
            Case "Yoghurt"
                Dim Yoghurt As New Yoghurt()
                Yoghurt.Show()
                Me.Hide()
        End Select
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDari.SelectedIndexChanged

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        MessageBox.Show("Silahkan pilih bahan yang akan dikonversikan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        MessageBox.Show("Silahkan pilih bahan yang akan dikonversikan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
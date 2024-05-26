Imports System.Globalization
Public Class Sirup_Jagung
    Public Function RoundDecimal(value As Double, decimalPlaces As Integer) As Double
        Dim multiplier As Double = Math.Pow(10, decimalPlaces)
        Dim roundedValue As Double = Math.Round(value * multiplier) / multiplier
        Dim decimalPart As Double = roundedValue - Math.Floor(roundedValue)
        Dim lastDigit As Integer = CInt((decimalPart * 10) Mod 10)

        If lastDigit = 1 OrElse lastDigit = 2 Then
            roundedValue = Math.Floor(roundedValue)
        ElseIf lastDigit = 3 OrElse lastDigit = 4 Then
            roundedValue = Math.Floor(roundedValue) + 0.5
        ElseIf lastDigit = 5 OrElse lastDigit = 6 Then
            roundedValue = Math.Floor(roundedValue) + 0.5
        ElseIf lastDigit = 8 OrElse lastDigit = 9 Then
            roundedValue = Math.Floor(roundedValue) + 1
        End If

        Return roundedValue
    End Function
    Private Sub Sirup_Jagung_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
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
                Dim Lombok As New Cabai_Bubuk()
                Lombok.Show()
                Me.Hide()
            Case "Garam Kasar"
                Dim Uya As New Garam_Kasar()
                Uya.Show()
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
                MessageBox.Show("Anda telah memasuki program tersebut.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Private Sub txtMasukan_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMasukan.KeyUp
        Dim awal As String = cbDari.SelectedItem.ToString()
        Dim akhir As String = cbKe.SelectedItem.ToString()

        If String.IsNullOrEmpty(txtMasukan.Text) Then
            MessageBox.Show("Masukkan nilai konversi", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim input As String = txtMasukan.Text
            Dim value As Double
            Dim valid As Boolean = Double.TryParse(input, value)

            If Not valid Then
                MessageBox.Show("Masukkan angka yang valid", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            'Gram
            If String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke gram adalah " & result & " g")
            ElseIf String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGram As Double = value
                Dim valueInKilogram As Double = valueInGram * 0.001
                Dim roundedValueInKilogram As Double = Math.Round(valueInKilogram, 3)
                Dim result As String = roundedValueInKilogram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGram As Double = value
                Dim valueInOz As Double = valueInGram * 0.035
                Dim roundedValueInOz As Double = Math.Round(valueInOz, 3)
                Dim result As String = roundedValueInOz.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGram As Double = value
                Dim valueInLb As Double = valueInGram * 0.0022
                Dim roundedValueInLb As Double = Math.Round(valueInLb, 3)
                Dim result As String = roundedValueInLb.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGram As Double = value
                Dim valueInmL As Double = valueInGram * 0.758
                Dim roundedValueInML As Double = Math.Round(valueInmL, 3)
                Dim result As String = roundedValueInML.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGram As Double = value
                Dim valueInL As Double = valueInGram * 0.00076
                Dim roundedValueInL As Double = Math.Round(valueInL, 3)
                Dim result As String = roundedValueInL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGram As Double = value
                Dim valueInTSP As Double = valueInGram * 0.152
                Dim roundedValueInTSP As Double = Math.Round(valueInTSP, 3)
                Dim result As String = roundedValueInTSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGram As Double = value
                Dim valueInTBSP As Double = valueInGram * 0.051
                Dim roundedValueInTBSP As Double = Math.Round(valueInTBSP, 3)
                Dim result As String = roundedValueInTBSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGram As Double = value
                Dim valueInUK As Double = valueInGram * 0.0027
                Dim roundedValueInUK As Double = Math.Round(valueInUK, 3)
                Dim result As String = roundedValueInUK.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke uk cups (UK cup) adalah " & result & " UK cup")
            ElseIf String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGram As Double = value
                Dim valueInUS As Double = valueInGram * 0.0032
                Dim roundedValueInUS As Double = Math.Round(valueInUS, 3)
                Dim result As String = roundedValueInUS.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke us cups (US cup) adalah " & result & " US cup")
            ElseIf String.Equals(awal, "grams (g)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGram As Double = value
                Dim valueInGlasses As Double = valueInGram * 0.003
                Dim roundedValueInGlasses As Double = Math.Round(valueInGlasses, 3)
                Dim result As String = roundedValueInGlasses.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " gram ke glasses [250 mL] adalah " & result & " glasses")

                'Kilogram
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInKilogram As Double = value
                Dim valueInGram As Double = valueInKilogram * 1000
                Dim roundedValueInGram As Double = Math.Round(valueInGram, 3)
                Dim result As String = roundedValueInGram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke grams (g) adalah " & result & " g")
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInKilogram As Double = value
                Dim valueInOZ As Double = valueInKilogram * 35.3
                Dim roundedValueInOZ As Double = Math.Round(valueInOZ, 3)
                Dim result As String = roundedValueInOZ.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInKilogram As Double = value
                Dim valueInLB As Double = valueInKilogram * 2.2
                Dim roundedValueInLB As Double = Math.Round(valueInLB, 3)
                Dim result As String = roundedValueInLB.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInKilogram As Double = value
                Dim valueInML As Double = valueInKilogram * 758.3
                Dim roundedValueInML As Double = Math.Round(valueInML, 3)
                Dim result As String = roundedValueInML.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInKilogram As Double = value
                Dim valueInL As Double = valueInKilogram * 0.758
                Dim roundedValueInL As Double = Math.Round(valueInL, 3)
                Dim result As String = roundedValueInL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInKilogram As Double = value
                Dim valueInTSP As Double = valueInKilogram * 151.7
                Dim roundedValueInTSP As Double = Math.Round(valueInTSP, 3)
                Dim result As String = roundedValueInTSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInKilogram As Double = value
                Dim valueInTBSP As Double = valueInKilogram * 51.3
                Dim roundedValueInTBSP As Double = Math.Round(valueInTBSP, 3)
                Dim result As String = roundedValueInTBSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInKilogram As Double = value
                Dim valueInUK As Double = valueInKilogram * 2.67
                Dim roundedValueInUK As Double = Math.Round(valueInUK, 3)
                Dim result As String = roundedValueInUK.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke uk cups (UK cup) adalah " & result & " UK cup")
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInKilogram As Double = value
                Dim valueInUS As Double = valueInKilogram * 3.21
                Dim roundedValueInUS As Double = Math.Round(valueInUS, 3)
                Dim result As String = roundedValueInUS.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke us cups (US cup) adalah " & result & " US cup")
            ElseIf String.Equals(awal, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInKilogram As Double = value
                Dim valueInGlasses As Double = valueInKilogram * 3.03
                Dim roundedValueInGlasses As Double = Math.Round(valueInGlasses, 3)
                Dim result As String = roundedValueInGlasses.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " kilogram (kg) ke glasses [250 mL] adalah " & result & " glasses")

                'ounces (oz)
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInOZ As Double = value
                Dim valueInGram As Double = valueInOZ * 28.3
                Dim roundedValueInGram As Double = Math.Round(valueInGram, 3)
                Dim result As String = roundedValueInGram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke grams (g) adalah " & result & " g")
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInOZ As Double = value
                Dim valueInKG As Double = valueInOZ * 0.028
                Dim roundedValueInKG As Double = Math.Round(valueInKG, 3)
                Dim result As String = roundedValueInKG.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInOZ As Double = value
                Dim valueInLB As Double = valueInOZ * 0.063
                Dim roundedValueInLB As Double = Math.Round(valueInLB, 3)
                Dim result As String = roundedValueInLB.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInOZ As Double = value
                Dim valueInmL As Double = valueInOZ * 21.5
                Dim roundedValueInmL As Double = Math.Round(valueInmL, 3)
                Dim result As String = roundedValueInmL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInOZ As Double = value
                Dim valueInL As Double = valueInOZ * 0.021
                Dim roundedValueInL As Double = Math.Round(valueInL, 3)
                Dim result As String = roundedValueInL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInOZ As Double = value
                Dim valueInTSP As Double = valueInOZ * 4.3
                Dim roundedValueInTSP As Double = Math.Round(valueInTSP, 3)
                Dim result As String = roundedValueInTSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInOZ As Double = value
                Dim valueInTBSP As Double = valueInOZ * 1.45
                Dim roundedValueInTBSP As Double = Math.Round(valueInTBSP, 3)
                Dim result As String = roundedValueInTBSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInOZ As Double = value
                Dim valueInUK As Double = valueInOZ * 0.076
                Dim roundedValueInUK As Double = Math.Round(valueInUK, 3)
                Dim result As String = roundedValueInUK.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke uk cups (UK cup) adalah " & result & " UK cup")
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInOZ As Double = value
                Dim valueInUS As Double = valueInOZ * 0.091
                Dim roundedValueInUS As Double = Math.Round(valueInUS, 3)
                Dim result As String = roundedValueInUS.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke us cups (US cup) adalah " & result & " US cup")
            ElseIf String.Equals(awal, "ounces (oz)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInOZ As Double = value
                Dim valueInGlasses As Double = valueInOZ * 0.086
                Dim roundedValueInGlasses As Double = Math.Round(valueInGlasses, 3)
                Dim result As String = roundedValueInGlasses.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " ounces (oz) ke glasses [250 mL] adalah " & result & " glasses")

                'pounds (lb)
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInLB As Double = value
                Dim valueInGram As Double = valueInLB * 453.6
                Dim roundedValueInGram As Double = Math.Round(valueInGram, 3)
                Dim result As String = roundedValueInGram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke grams (g) adalah " & result & " g")
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInLB As Double = value
                Dim valueInKilogram As Double = valueInLB * 0.454
                Dim roundedValueInKilogram As Double = Math.Round(valueInKilogram, 3)
                Dim result As String = roundedValueInKilogram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInLB As Double = value
                Dim valueInOZ As Double = valueInLB * 16
                Dim roundedValueInOZ As Double = Math.Round(valueInOZ, 3)
                Dim result As String = roundedValueInOZ.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInLB As Double = value
                Dim valueInML As Double = valueInLB * 344
                Dim roundedValueInML As Double = Math.Round(valueInML, 3)
                Dim result As String = roundedValueInML.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInLB As Double = value
                Dim valueInL As Double = valueInLB * 0.344
                Dim roundedValueInL As Double = Math.Round(valueInL, 3)
                Dim result As String = roundedValueInL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInLB As Double = value
                Dim valueInTSP As Double = valueInLB * 68.8
                Dim roundedValueInTSP As Double = Math.Round(valueInTSP, 3)
                Dim result As String = roundedValueInTSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInLB As Double = value
                Dim valueInTBSP As Double = valueInLB * 23.3
                Dim roundedValueInTBSP As Double = Math.Round(valueInTBSP, 3)
                Dim result As String = roundedValueInTBSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInLB As Double = value
                Dim valueInUK As Double = valueInLB * 1.21
                Dim roundedValueInUK As Double = Math.Round(valueInUK, 3)
                Dim result As String = roundedValueInUK.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke uk cups (UK cup) adalah " & result & " uk cup")
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInLB As Double = value
                Dim valueInUS As Double = valueInLB * 1.45
                Dim roundedValueInUS As Double = Math.Round(valueInUS, 3)
                Dim result As String = roundedValueInUS.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke us cups (US cup) adalah " & result & " us cup")
            ElseIf String.Equals(awal, "pounds (lb)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInLB As Double = value
                Dim valueInGlasses As Double = valueInLB * 1.38
                Dim roundedValueInGlasses As Double = Math.Round(valueInGlasses, 3)
                Dim result As String = roundedValueInGlasses.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " pounds (lb) ke glasses [250 mL] adalah " & result & " glasses")

                'milliliters (mL)
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInML As Double = value
                Dim valueInGram As Double = valueInML * 1.32
                Dim roundedValueInGram As Double = Math.Round(valueInGram, 3)
                Dim result As String = roundedValueInGram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke grams (g) adalah " & result & " g")
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInML As Double = value
                Dim valueInKilogram As Double = valueInML * 0.0013
                Dim roundedValueInKilogram As Double = Math.Round(valueInKilogram, 3)
                Dim result As String = roundedValueInKilogram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInML As Double = value
                Dim valueInOZ As Double = valueInML * 0.047
                Dim roundedValueInOZ As Double = Math.Round(valueInOZ, 3)
                Dim result As String = roundedValueInOZ.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInML As Double = value
                Dim valueInLB As Double = valueInML * 0.0029
                Dim roundedValueInLB As Double = Math.Round(valueInLB, 3)
                Dim result As String = roundedValueInLB.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInML As Double = value
                Dim valueInL As Double = valueInML * 0.001
                Dim roundedValueInL As Double = Math.Round(valueInL, 3)
                Dim result As String = roundedValueInL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInML As Double = value
                Dim valueInTSP As Double = valueInML * 0.2
                Dim roundedValueInTSP As Double = Math.Round(valueInTSP, 3)
                Dim result As String = roundedValueInTSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInML As Double = value
                Dim valueInTBSP As Double = valueInML * 0.068
                Dim roundedValueInTBSP As Double = Math.Round(valueInTBSP, 3)
                Dim result As String = roundedValueInTBSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInML As Double = value
                Dim valueInUK As Double = valueInML * 0.0035
                Dim roundedValueInUK As Double = Math.Round(valueInUK, 3)
                Dim result As String = roundedValueInUK.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke uk cups (UK cup) adalah " & result & " uk cup")
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInML As Double = value
                Dim valueInUS As Double = valueInML * 0.0042
                Dim roundedValueInUS As Double = Math.Round(valueInUS, 3)
                Dim result As String = roundedValueInUS.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke us cups (US cup) adalah " & result & " us cup")
            ElseIf String.Equals(awal, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInML As Double = value
                Dim valueInGlasses As Double = valueInML * 0.004
                Dim roundedValueInGlasses As Double = Math.Round(valueInGlasses, 3)
                Dim result As String = roundedValueInGlasses.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " milliliters (mL) ke glasses [250 mL] adalah " & result & " glasses")

                'liters (L)
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInL As Double = value
                Dim valueInGram As Double = valueInL * 1318.7
                Dim roundedValueInGram As Double = Math.Round(valueInGram, 3)
                Dim result As String = roundedValueInGram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke grams (g) adalah " & result & " g")
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInL As Double = value
                Dim valueInKilogram As Double = valueInL * 1.32
                Dim roundedValueInKilogram As Double = Math.Round(valueInKilogram, 3)
                Dim result As String = roundedValueInKilogram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInL As Double = value
                Dim valueInOZ As Double = valueInL * 46.5
                Dim roundedValueInOZ As Double = Math.Round(valueInOZ, 3)
                Dim result As String = roundedValueInOZ.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInL As Double = value
                Dim valueInLB As Double = valueInL * 2.91
                Dim roundedValueInLB As Double = Math.Round(valueInLB, 3)
                Dim result As String = roundedValueInLB.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInL As Double = value
                Dim valueInML As Double = valueInL * 1000
                Dim roundedValueInML As Double = Math.Round(valueInML, 3)
                Dim result As String = roundedValueInML.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInL As Double = value
                Dim valueInTSP As Double = valueInL * 200
                Dim roundedValueInTSP As Double = Math.Round(valueInTSP, 3)
                Dim result As String = roundedValueInTSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInL As Double = value
                Dim valueInTBSP As Double = valueInL * 67.6
                Dim roundedValueInTBSP As Double = Math.Round(valueInTBSP, 3)
                Dim result As String = roundedValueInTBSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInL As Double = value
                Dim valueInUK As Double = valueInL * 3.52
                Dim roundedValueInUK As Double = Math.Round(valueInUK, 3)
                Dim result As String = roundedValueInUK.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke uk cups (UK cup) adalah " & result & " uk cup")
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInL As Double = value
                Dim valueInUS As Double = valueInL * 4.23
                Dim roundedValueInUS As Double = Math.Round(valueInUS, 3)
                Dim result As String = roundedValueInUS.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke grams (g) adalah " & result & " us cup")
            ElseIf String.Equals(awal, "liters (L)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInL As Double = value
                Dim valueInGlasses As Double = valueInL * 4
                Dim roundedValueInGlasses As Double = Math.Round(valueInGlasses, 3)
                Dim result As String = roundedValueInGlasses.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " liters (L) ke glasses [250 mL] adalah " & result & " glasses")

                'teaspoons [5 mL] (tsp)
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTSP As Double = value
                Dim valueInGram As Double = valueInTSP * 6.59
                Dim roundedValueInGram As Double = Math.Round(valueInGram, 3)
                Dim result As String = roundedValueInGram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke grams (g) adalah " & result & " g")
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTSP As Double = value
                Dim valueInKilogram As Double = valueInTSP * 0.0066
                Dim roundedValueInKilogram As Double = Math.Round(valueInKilogram, 3)
                Dim result As String = roundedValueInKilogram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTSP As Double = value
                Dim valueInOZ As Double = valueInTSP * 0.233
                Dim roundedValueInOZ As Double = Math.Round(valueInOZ, 3)
                Dim result As String = roundedValueInOZ.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTSP As Double = value
                Dim valueInLB As Double = valueInTSP * 0.015
                Dim roundedValueInLB As Double = Math.Round(valueInLB, 3)
                Dim result As String = roundedValueInLB.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTSP As Double = value
                Dim valueInML As Double = valueInTSP * 5
                Dim roundedValueInML As Double = Math.Round(valueInML, 3)
                Dim result As String = roundedValueInML.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTSP As Double = value
                Dim valueInL As Double = valueInTSP * 0.005
                Dim roundedValueInL As Double = Math.Round(valueInL, 3)
                Dim result As String = roundedValueInL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTSP As Double = value
                Dim valueInTBSP As Double = valueInTSP * 0.338
                Dim roundedValueInTBSP As Double = Math.Round(valueInTBSP, 3)
                Dim result As String = roundedValueInTBSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTSP As Double = value
                Dim valueInUK As Double = valueInTSP * 0.018
                Dim roundedValueInUK As Double = Math.Round(valueInUK, 3)
                Dim result As String = roundedValueInUK.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke uk cups (UK cup) adalah " & result & " uk cup")
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTSP As Double = value
                Dim valueInUS As Double = valueInTSP * 0.021
                Dim roundedValueInUS As Double = Math.Round(valueInUS, 3)
                Dim result As String = roundedValueInUS.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke us cups (US cup) adalah " & result & " us cup")
            ElseIf String.Equals(awal, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTSP As Double = value
                Dim valueInGlasses As Double = valueInTSP * 0.02
                Dim roundedValueInGlasses As Double = Math.Round(valueInGlasses, 3)
                Dim result As String = roundedValueInGlasses.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " teaspoons [5 mL] (tsp) ke glasses [250 mL] adalah " & result & " glasses")

                'tablespoons [15 mL] (tbsp)
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTBSP As Double = value
                Dim valueInGram As Double = valueInTBSP * 19.5
                Dim roundedValueInGram As Double = Math.Round(valueInGram, 3)
                Dim result As String = roundedValueInGram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke grams (g) adalah " & result & " g")
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTBSP As Double = value
                Dim valueInKilogram As Double = valueInTBSP * 0.02
                Dim roundedValueInKilogram As Double = Math.Round(valueInKilogram, 3)
                Dim result As String = roundedValueInKilogram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke Kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTBSP As Double = value
                Dim valueInOZ As Double = valueInTBSP * 0.688
                Dim roundedValueInOZ As Double = Math.Round(valueInOZ, 3)
                Dim result As String = roundedValueInOZ.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTBSP As Double = value
                Dim valueInLB As Double = valueInTBSP * 0.043
                Dim roundedValueInLB As Double = Math.Round(valueInLB, 3)
                Dim result As String = roundedValueInLB.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTBSP As Double = value
                Dim valueInML As Double = valueInTBSP * 14.8
                Dim roundedValueInML As Double = Math.Round(valueInML, 3)
                Dim result As String = roundedValueInML.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTBSP As Double = value
                Dim valueInL As Double = valueInTBSP * 0.015
                Dim roundedValueInL As Double = Math.Round(valueInL, 3)
                Dim result As String = roundedValueInL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTBSP As Double = value
                Dim valueInTSP As Double = valueInTBSP * 2.96
                Dim roundedValueInTSP As Double = Math.Round(valueInTSP, 3)
                Dim result As String = roundedValueInTSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTBSP As Double = value
                Dim valueInUK As Double = valueInTBSP * 0.052
                Dim roundedValueInUK As Double = Math.Round(valueInUK, 3)
                Dim result As String = roundedValueInUK.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke uk cups (UK cup) adalah " & result & " uk cup")
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTBSP As Double = value
                Dim valueInUS As Double = valueInTBSP * 0.062
                Dim roundedValueInUS As Double = Math.Round(valueInUS, 3)
                Dim result As String = roundedValueInUS.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke us cups (US cup) adalah " & result & " us cup")
            ElseIf String.Equals(awal, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInTBSP As Double = value
                Dim valueInGlasses As Double = valueInTBSP * 0.059
                Dim roundedValueInGlasses As Double = Math.Round(valueInGlasses, 3)
                Dim result As String = roundedValueInGlasses.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " tablespoons [15 mL] (tbsp) ke glasses [250 mL] adalah " & result & " glasses")

                'uk cups (UK cup)
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUK As Double = value
                Dim valueInGram As Double = valueInUK * 374.7
                Dim roundedValueInGram As Double = Math.Round(valueInGram, 3)
                Dim result As String = roundedValueInGram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke grams (g) adalah " & result & " g")
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUK As Double = value
                Dim valueInKilogram As Double = valueInUK * 0.375
                Dim roundedValueInKilogram As Double = Math.Round(valueInKilogram, 3)
                Dim result As String = roundedValueInKilogram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUK As Double = value
                Dim valueInOZ As Double = valueInUK * 13.2
                Dim roundedValueInOZ As Double = Math.Round(valueInOZ, 3)
                Dim result As String = roundedValueInOZ.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUK As Double = value
                Dim valueInLB As Double = valueInUK * 0.826
                Dim roundedValueInLB As Double = Math.Round(valueInLB, 3)
                Dim result As String = roundedValueInLB.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUK As Double = value
                Dim valueInML As Double = valueInUK * 284.1
                Dim roundedValueInML As Double = Math.Round(valueInML, 3)
                Dim result As String = roundedValueInML.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUK As Double = value
                Dim valueInL As Double = valueInUK * 0.284
                Dim roundedValueInL As Double = Math.Round(valueInL, 3)
                Dim result As String = roundedValueInL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUK As Double = value
                Dim valueInTSP As Double = valueInUK * 56.8
                Dim roundedValueInTSP As Double = Math.Round(valueInTSP, 3)
                Dim result As String = roundedValueInTSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUK As Double = value
                Dim valueInTBSP As Double = valueInUK * 19.2
                Dim roundedValueInTBSP As Double = Math.Round(valueInTBSP, 3)
                Dim result As String = roundedValueInTBSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke uk cups (UK cup) adalah " & result & " uk cup")
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUK As Double = value
                Dim valueInUS As Double = valueInUK * 1.2
                Dim roundedValueInUS As Double = Math.Round(valueInUS, 3)
                Dim result As String = roundedValueInUS.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke us cups (US cup) adalah " & result & " us cup")
            ElseIf String.Equals(awal, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUK As Double = value
                Dim valueInGlasses As Double = valueInUK * 1.14
                Dim roundedValueInGlasses As Double = Math.Round(valueInGlasses, 3)
                Dim result As String = roundedValueInGlasses.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " uk cups (UK cup) ke glasses [250 mL] adalah " & result & " glasses")

                'us cups (US cup)
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUS As Double = value
                Dim valueInGram As Double = valueInUS * 312
                Dim roundedValueInGram As Double = Math.Round(valueInGram, 3)
                Dim result As String = roundedValueInGram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke grams (g) adalah " & result & " g")
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUS As Double = value
                Dim valueInKilogram As Double = valueInUS * 0.312
                Dim roundedValueInKilogram As Double = Math.Round(valueInKilogram, 3)
                Dim result As String = roundedValueInKilogram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUS As Double = value
                Dim valueInOZ As Double = valueInUS * 11
                Dim roundedValueInOZ As Double = Math.Round(valueInOZ, 3)
                Dim result As String = roundedValueInOZ.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUS As Double = value
                Dim valueInLB As Double = valueInUS * 0.688
                Dim roundedValueInLB As Double = Math.Round(valueInLB, 3)
                Dim result As String = roundedValueInLB.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUS As Double = value
                Dim valueInML As Double = valueInUS * 236.6
                Dim roundedValueInML As Double = Math.Round(valueInML, 3)
                Dim result As String = roundedValueInML.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUS As Double = value
                Dim valueInL As Double = valueInUS * 0.237
                Dim roundedValueInL As Double = Math.Round(valueInL, 3)
                Dim result As String = roundedValueInL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUS As Double = value
                Dim valueInTSP As Double = valueInUS * 47.3
                Dim roundedValueInTSP As Double = Math.Round(valueInTSP, 3)
                Dim result As String = roundedValueInTSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUS As Double = value
                Dim valueInTBSP As Double = valueInUS * 16
                Dim roundedValueInTBSP As Double = Math.Round(valueInTBSP, 3)
                Dim result As String = roundedValueInTBSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUS As Double = value
                Dim valueInUK As Double = valueInUS * 0.833
                Dim roundedValueInUK As Double = Math.Round(valueInUK, 3)
                Dim result As String = roundedValueInUK.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke uk cups (UK cup) adalah " & result & " uk cup")
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke us cups (US cup) adalah " & result & " us cup")
            ElseIf String.Equals(awal, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInUS As Double = value
                Dim valueInGlasses As Double = valueInUS * 0.946
                Dim roundedValueInGlasses As Double = Math.Round(valueInGlasses, 3)
                Dim result As String = roundedValueInGlasses.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " us cups (US cup) ke glasses [250 mL] adalah " & result & " glasses")

                'glasses [250 mL]
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "grams (g)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGlasses As Double = value
                Dim valueInGram As Double = valueInGlasses * 329.7
                Dim roundedValueInGram As Double = Math.Round(valueInGram, 3)
                Dim result As String = roundedValueInGram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke grams (g) adalah " & result & " g")
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "kilogram (kg)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGlasses As Double = value
                Dim valueInKilogram As Double = valueInGlasses * 0.33
                Dim roundedValueInKilogram As Double = Math.Round(valueInKilogram, 3)
                Dim result As String = roundedValueInKilogram.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke kilogram (kg) adalah " & result & " kg")
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "ounces (oz)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGlasses As Double = value
                Dim valueInOZ As Double = valueInGlasses * 11.6
                Dim roundedValueInOZ As Double = Math.Round(valueInOZ, 3)
                Dim result As String = roundedValueInOZ.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke ounces (oz) adalah " & result & " oz")
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "pounds (lb)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGlasses As Double = value
                Dim valueInLB As Double = valueInGlasses * 0.727
                Dim roundedValueInLB As Double = Math.Round(valueInLB, 3)
                Dim result As String = roundedValueInLB.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke pounds (lb) adalah " & result & " lb")
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "milliliters (mL)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGlasses As Double = value
                Dim valueInML As Double = valueInGlasses * 250
                Dim roundedValueInML As Double = Math.Round(valueInML, 3)
                Dim result As String = roundedValueInML.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke milliliters (mL) adalah " & result & " mL")
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "liters (L)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGlasses As Double = value
                Dim valueInL As Double = valueInGlasses * 0.25
                Dim roundedValueInL As Double = Math.Round(valueInL, 3)
                Dim result As String = roundedValueInL.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke liters (L) adalah " & result & " L")
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "teaspoons [5 mL] (tsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGlasses As Double = value
                Dim valueInTSP As Double = valueInGlasses * 50
                Dim roundedValueInTSP As Double = Math.Round(valueInTSP, 3)
                Dim result As String = roundedValueInTSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke teaspoons [5 mL] (tsp) adalah " & result & " tsp")
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "tablespoons [15 mL] (tbsp)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGlasses As Double = value
                Dim valueInTBSP As Double = valueInGlasses * 16.9
                Dim roundedValueInTBSP As Double = Math.Round(valueInTBSP, 3)
                Dim result As String = roundedValueInTBSP.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke tablespoons [15 mL] (tbsp) adalah " & result & " tbsp")
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "uk cups (UK cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGlasses As Double = value
                Dim valueInUK As Double = valueInGlasses * 0.88
                Dim roundedValueInUK As Double = Math.Round(valueInUK, 3)
                Dim result As String = roundedValueInUK.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke uk cups (UK cup) adalah " & result & " uk cup")
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "us cups (US cup)", StringComparison.OrdinalIgnoreCase) Then
                Dim valueInGlasses As Double = value
                Dim valueInUS As Double = valueInGlasses * 1.06
                Dim roundedValueInUS As Double = Math.Round(valueInUS, 3)
                Dim result As String = roundedValueInUS.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke us cups (US cup) adalah " & result & " us cup")
            ElseIf String.Equals(awal, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(akhir, "glasses [250 mL]", StringComparison.OrdinalIgnoreCase) Then
                Dim roundedValue As Double = Math.Round(value)
                Dim result As String = roundedValue.ToString("0.###")
                txtHasil.Text = result
                txtHistori.Text = Nothing
                txtHistori.AppendText("Konversi dari " & txtMasukan.Text & " glasses [250 mL] ke glasses [250 mL] adalah " & result & " glasses")
            End If
        End If
    End Sub
    Public Function RoundDecimalPublic(value As Double, decimalPlaces As Integer) As Double
        Dim multiplier As Double = Math.Pow(10, decimalPlaces)
        Dim roundedValue As Double = Math.Round(value * multiplier) / multiplier
        Return roundedValue
    End Function
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtHasil.Clear()
        txtHistori.Clear()
        txtMasukan.Clear()
    End Sub
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If Not String.IsNullOrEmpty(txtHistori.Text) Then
            Clipboard.SetText(txtHistori.Text)
        End If
    End Sub
End Class
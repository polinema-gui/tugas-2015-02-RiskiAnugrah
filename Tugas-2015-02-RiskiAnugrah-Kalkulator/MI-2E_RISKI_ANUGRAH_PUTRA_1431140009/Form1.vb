Public Class Form1
    Dim input_angka, Hasil As Double

    Dim Rumus As String
    Private Sub tombol0_Click(sender As Object, e As EventArgs) Handles tombol0.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub tombol1_Click(sender As Object, e As EventArgs) Handles tombol1.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub tombol2_Click(sender As Object, e As EventArgs) Handles tombol2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub tombol3_Click(sender As Object, e As EventArgs) Handles tombol3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub tombol4_Click(sender As Object, e As EventArgs) Handles tombol4.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub tombol5_Click(sender As Object, e As EventArgs) Handles tombol5.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub tombol6_Click(sender As Object, e As EventArgs) Handles tombol6.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub tombol7_Click(sender As Object, e As EventArgs) Handles tombol7.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub tombol8_Click(sender As Object, e As EventArgs) Handles tombol8.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub tombol9_Click(sender As Object, e As EventArgs) Handles tombol9.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub
    Private Sub tombolPlus_Click(sender As Object, e As EventArgs) Handles tombolPlus.Click
        input_angka = TextBox1.Text

        Rumus = "+"

        TextBox1.Text = Nothing
    End Sub

    Private Sub tombolClear_Click(sender As Object, e As EventArgs) Handles tombolClear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub tombolMinus_Click(sender As Object, e As EventArgs) Handles tombolMinus.Click
        input_angka = TextBox1.Text

        Rumus = "-"

        TextBox1.Text = Nothing
    End Sub
    'Private Sub tombolSamaDengan_Click(sender As Object, e As EventArgs) Handles tombolSamaDengan.Click
    '    If Rumus = "+" Then

    '        TextBox1.Text = input_angka + TextBox1.Text

    '    ElseIf Rumus = "-" Then

    '        TextBox1.Text = input_angka - TextBox1.Text
    '    End If
    'End Sub
    Private Sub tombolSamaDengan_Click(sender As Object, e As EventArgs) Handles tombolSamaDengan.Click
        Select Case Rumus
            Case "+"
                Hasil = input_angka + TextBox1.Text
            Case "-"
                Hasil = input_angka - TextBox1.Text
        End Select
        TextBox1.Text = Hasil
    End Sub
End Class

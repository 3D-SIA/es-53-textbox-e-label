Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pezzi, prezzo, sconto, tot1, totale As Double
        prezzo = Val(TextBox1.Text)
        pezzi = Val(TextBox2.Text)
        tot1 = prezzo * pezzi
        If (pezzi = 1) Then
            sconto = (tot1 * 10) / 100
            totale = tot1 - sconto
        ElseIf (pezzi = 3) Then
            sconto = (tot1 * 20) / 100
            totale = tot1 - sconto
        ElseIf (pezzi = 5) Then
            sconto = (tot1 * 30) / 100
            totale = tot1 - sconto
        ElseIf (pezzi = 10) Then
            sconto = (tot1 * 35) / 100
            totale = tot1 - sconto
        ElseIf (pezzi > 10) Then
            sconto = (tot1 * 40) / 100
            totale = tot1 - sconto
        Else
            totale = tot1
            TextBox3.Text = tot1
        End If
        TextBox3.Text = totale
    End Sub
End Class

Public Class Form2
    ' Функция по варианту 10 для 8.2: (Ln(x)*Cos(x))/x^2
    Function f_opt(ByVal x As Double) As Double
        Return (Math.Log(x) * Math.Cos(x)) / (x ^ 2)
    End Function

    Private Sub btnGolden_Click(sender As Object, e As EventArgs) Handles btnGolden.Click
        Dim a As Double = CDbl(txtA2.Text)
        Dim b As Double = CDbl(txtB2.Text)
        Dim eps As Double = CDbl(txtEps2.Text)

        ' Коэффициент золотого сечения
        Dim phi As Double = (Math.Sqrt(5) - 1) / 2

        Dim x1 As Double = b - phi * (b - a)
        Dim x2 As Double = a + phi * (b - a)

        Dim f1 As Double = f_opt(x1)
        Dim f2 As Double = f_opt(x2)

        While Math.Abs(b - a) > eps
            ' Для поиска МИНИМУМА: f1 > f2. Для МАКСИМУМА: f1 < f2.
            ' В таблице 2 обычно ищут минимум.
            If f1 > f2 Then
                a = x1
                x1 = x2
                f1 = f2
                x2 = a + phi * (b - a)
                f2 = f_opt(x2)
            Else
                b = x2
                x2 = x1
                f2 = f1
                x1 = b - phi * (b - a)
                f1 = f_opt(x1)
            End If
        End While

        Dim resX As Double = (a + b) / 2
        txtResX.Text = "x = " & resX.ToString("F4") & " f(x)=" & f_opt(resX).ToString("F4")
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

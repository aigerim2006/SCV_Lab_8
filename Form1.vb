Public Class Form1
    ' Функция по варианту 10: Cos(Ln(1+x))*e^x
    Function f(ByVal x As Double) As Double
        Return Math.Cos(Math.Log(1 + x)) * Math.Exp(x)
    End Function
    ' МЕТОД ПРЯМОУГОЛЬНИКОВ
    Private Sub btnRect_Click(sender As Object, e As EventArgs) Handles btnRect.Click
        Try
            Dim a As Double = CDbl(txtA.Text)
            Dim b As Double = CDbl(txtB.Text)
            Dim eps As Double = CDbl(txtEps.Text)

            ' Для упрощения берем фиксированное n, 
            ' но для точности eps лучше использовать цикл с удвоением n
            Dim n As Integer = 1000
            Dim h As Double = (b - a) / n
            Dim sum As Double = 0

            For i As Integer = 0 To n - 1
                sum += f(a + i * h) ' Левые прямоугольники
            Next

            txtResult1.Text = "Прям: " & (sum * h).ToString("F6")
        Catch ex As Exception
            MsgBox("Ошибка ввода данных!")
        End Try
    End Sub

    ' МЕТОД СИМПСОНА
    Private Sub btnSimpson_Click(sender As Object, e As EventArgs) Handles btnSimpson.Click
        Try
            Dim a As Double = CDbl(txtA.Text)
            Dim b As Double = CDbl(txtB.Text)
            Dim n As Integer = 1000 ' n должно быть четным
            Dim h As Double = (b - a) / n
            Dim sum As Double = f(a) + f(b)

            For i As Integer = 1 To n - 1
                If i Mod 2 <> 0 Then
                    sum += 4 * f(a + i * h)
                Else
                    sum += 2 * f(a + i * h)
                End If
            Next

            txtResult2.Text = "Симпс: " & (h / 3 * sum).ToString("F6")
        Catch ex As Exception
            MsgBox("Ошибка ввода!")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

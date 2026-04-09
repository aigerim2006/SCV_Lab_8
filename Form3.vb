Imports System.Net.Mime.MediaTypeNames
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Form3
    Private Function f(x As Double) As Double
        If x = 0 Then Return 0 ' Защита от деления на 0
        Return Math.Sin(x) - (1 / x)
    End Function

    ' Производная функции (нужна для метода Ньютона): f'(x) = cos(x) + 1/x^2
    Private Function df(x As Double) As Double
        Return Math.Cos(x) + (1 / (x * x))
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' 1. Считываем данные из интерфейса
        Dim a As Double = CDbl(txtStart.Text.Replace(".", ",")) ' Начало отрезка
        Dim b As Double = CDbl(txtEnd.Text.Replace(".", ","))   ' Конец отрезка
        Dim eps As Double = CDbl(txtEps.Text.Replace(".", ",")) ' Точность
        Dim result As Double = 0

        If eps <= 0 Then eps = 0.0001 ' Защита от нулевой точности

        ' Устанавливаем текст оптимизируемой функции
        lblFunction.Text = "f(x) = sin(x) - 1/x"

        ' 2. Выбираем метод в зависимости от RadioButton
        If rbDichotomy.Checked Then
            result = MethodDichotomy(a, b, eps)
        ElseIf rbChords.Checked Then
            result = MethodChords(a, b, eps)
        ElseIf rbNewton.Checked Then
            result = MethodNewton(a, eps) ' Для Ньютона берем точку 'a' как старт
        ElseIf rbIteration.Checked Then
            result = MethodIteration(a, eps)
        End If

        ' 3. Вывод результата корня
        lblResult.Text = "Корень: " & result.ToString("F5")

        ' 4. Расчет интеграла (самостоятельная работа)
        lblIntegral.Text = MethodTrapezoid(a, b, 1000).ToString("F5")

        DrawGraph(a, b)

    End Sub

    Private Function MethodDichotomy(a As Double, b As Double, eps As Double) As Double
        Dim c As Double
        Dim iter As Integer = 0
        While (Math.Abs(b - a) > eps) And (iter < 10000)
            iter += 1
            c = (a + b) / 2
            If f(a) * f(c) < 0 Then b = c Else a = c
        End While
        Return (a + b) / 2
    End Function

    Private Function MethodChords(a As Double, b As Double, eps As Double) As Double
        Dim x0 As Double = a
        Dim x1 As Double = b
        Dim x_next As Double = 0
        Dim iter As Integer = 0

        ' Метод хорд требует, чтобы f(a) и f(b) имели разные знаки
        If f(a) * f(b) >= 0 Then
            MsgBox("Метод хорд: на концах отрезка функция должна иметь разные знаки!")
            Return 0
        End If

        Do
            iter += 1
            ' Проверка на деление на ноль (если значения функции стали одинаковыми)
            Dim denominator As Double = f(x1) - f(x0)
            If Math.Abs(denominator) < 0.0000000001 Then Exit Do

            ' Формула метода хорд
            x_next = x1 - f(x1) * (x1 - x0) / denominator

            ' Условие выхода: если разница между шагами стала меньше точности
            If Math.Abs(x_next - x1) < eps Then Exit Do

            ' Подготовка к следующему шагу
            x0 = x1
            x1 = x_next

            ' Предохранитель от бесконечного цикла
            If iter > 10000 Then
                MsgBox("Метод хорд не сошелся за 10 000 итераций.")
                Exit Do
            End If
        Loop

        Return x_next
    End Function

    Private Function MethodNewton(x0 As Double, eps As Double) As Double
        Dim x_next As Double = x0
        Dim iter As Integer = 0
        Do
            iter += 1
            x0 = x_next
            Dim d = df(x0)
            If d = 0 Then Exit Do ' Защита от деления на ноль
            x_next = x0 - f(x0) / d
        Loop Until (Math.Abs(x_next - x0) < eps) Or (iter > 10000)
        Return x_next
    End Function

    Private Function MethodIteration(x0 As Double, eps As Double) As Double
        Dim x_next As Double = x0
        Dim iter As Integer = 0
        Try
            Do
                iter += 1
                x0 = x_next
                ' Если 1/x0 > 1, Asin выдаст ошибку, поэтому используем Try
                Dim valToAsin = 1 / x0
                If Math.Abs(valToAsin) > 1 Then Return x0 ' Корень вне диапазона

                x_next = Math.Asin(valToAsin)

                If Double.IsNaN(x_next) Then Return x0
            Loop Until (Math.Abs(x_next - x0) < eps) Or (iter > 10000)
        Catch
            Return x0
        End Try
        Return x_next
    End Function

    Private Function MethodTrapezoid(a As Double, b As Double, n As Integer) As Double
        Dim h As Double = (b - a) / n
        Dim sum As Double = (f(a) + f(b)) / 2
        For i As Integer = 1 To n - 1
            sum += f(a + i * h)
        Next
        Return sum * h
    End Function

    Private Sub DrawGraph(a As Double, b As Double)
        Dim chartArea As ChartArea = Chart1.ChartAreas(0)
        Dim series As Series = Chart1.Series(0)

        ' 1. Убираем легенду (надпись Series1)
        If Chart1.Legends.Count > 0 Then Chart1.Legends(0).Enabled = False

        ' 2. Базовый стиль
        series.Points.Clear()
        series.ChartType = SeriesChartType.Line
        series.Color = Color.FromArgb(79, 129, 189)
        series.BorderWidth = 2
        chartArea.BackColor = Color.White

        ' 3. НАСТРОЙКА ОСЕЙ "КАК В EXCEL"
        ' Чтобы ось Y была слева, а не в центре, ставим NaN
        chartArea.AxisY.Crossing = 0
        ' Чтобы ось X была на уровне нуля
        chartArea.AxisX.Crossing = 0

        ' Ставим фиксированные границы, как на вашем скриншоте из Excel
        chartArea.AxisX.Minimum = 0
        chartArea.AxisX.Maximum = 4.5
        chartArea.AxisX.Interval = 0.5

        chartArea.AxisY.Minimum = -2
        chartArea.AxisY.Maximum = 1
        chartArea.AxisY.Interval = 0.5

        ' 4. Сетка и засечки
        chartArea.AxisX.MajorGrid.LineColor = Color.LightGray
        chartArea.AxisY.MajorGrid.LineColor = Color.LightGray
        chartArea.AxisX.MajorTickMark.TickMarkStyle = TickMarkStyle.OutsideArea
        chartArea.AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.OutsideArea
        chartArea.AxisY.LabelStyle.Format = "0.0"


        chartArea.AxisX.LineWidth = 2
        chartArea.AxisX.LineColor = Color.Black
        chartArea.AxisY.LineWidth = 2
        chartArea.AxisY.LineColor = Color.Black

        ' 5. РИСОВАНИЕ (от 0.4 до 4.5, чтобы было как в таблице)
        Dim startPoint As Double = 0.4
        Dim endPoint As Double = 4.5
        Dim steps As Integer = 300
        Dim h As Double = (endPoint - startPoint) / steps

        For i As Integer = 0 To steps
            Dim currX As Double = startPoint + (i * h)

            ' Защита от разрыва в нуле (1/x)
            If Math.Abs(currX) > 0.001 Then
                Dim currY As Double = f(currX)
                ' Добавляем точку, только если она вменяемых размеров
                If currY < 2 And currY > -3 Then
                    series.Points.AddXY(currX, currY)
                End If
            End If
        Next
    End Sub

End Class
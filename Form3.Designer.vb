<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbDichotomy = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIntegral = New System.Windows.Forms.Label()
        Me.rbIteration = New System.Windows.Forms.RadioButton()
        Me.rbChords = New System.Windows.Forms.RadioButton()
        Me.rbNewton = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEps = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFunction = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(327, 80)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(100, 22)
        Me.txtStart.TabIndex = 0
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(327, 120)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(100, 22)
        Me.txtEnd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Введите начало отрезка:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Введите конец отрезка:"
        '
        'rbDichotomy
        '
        Me.rbDichotomy.AutoSize = True
        Me.rbDichotomy.Location = New System.Drawing.Point(116, 243)
        Me.rbDichotomy.Name = "rbDichotomy"
        Me.rbDichotomy.Size = New System.Drawing.Size(98, 20)
        Me.rbDichotomy.TabIndex = 4
        Me.rbDichotomy.TabStop = True
        Me.rbDichotomy.Text = "Дихотомия" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbDichotomy.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(242, 390)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(138, 35)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Расчитать"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Выберете каким методом расчитать:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Результат:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblResult.Location = New System.Drawing.Point(239, 318)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 18)
        Me.lblResult.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Интеграл:"
        '
        'lblIntegral
        '
        Me.lblIntegral.AutoSize = True
        Me.lblIntegral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblIntegral.Location = New System.Drawing.Point(239, 353)
        Me.lblIntegral.Name = "lblIntegral"
        Me.lblIntegral.Size = New System.Drawing.Size(0, 18)
        Me.lblIntegral.TabIndex = 10
        '
        'rbIteration
        '
        Me.rbIteration.AutoSize = True
        Me.rbIteration.Location = New System.Drawing.Point(116, 269)
        Me.rbIteration.Name = "rbIteration"
        Me.rbIteration.Size = New System.Drawing.Size(93, 20)
        Me.rbIteration.TabIndex = 11
        Me.rbIteration.TabStop = True
        Me.rbIteration.Text = "Итерации"
        Me.rbIteration.UseVisualStyleBackColor = True
        '
        'rbChords
        '
        Me.rbChords.AutoSize = True
        Me.rbChords.Location = New System.Drawing.Point(277, 243)
        Me.rbChords.Name = "rbChords"
        Me.rbChords.Size = New System.Drawing.Size(60, 20)
        Me.rbChords.TabIndex = 12
        Me.rbChords.TabStop = True
        Me.rbChords.Text = "Хорд"
        Me.rbChords.UseVisualStyleBackColor = True
        '
        'rbNewton
        '
        Me.rbNewton.AutoSize = True
        Me.rbNewton.Location = New System.Drawing.Point(277, 270)
        Me.rbNewton.Name = "rbNewton"
        Me.rbNewton.Size = New System.Drawing.Size(181, 20)
        Me.rbNewton.TabIndex = 13
        Me.rbNewton.TabStop = True
        Me.rbNewton.Text = "Касательных (Ньютона)"
        Me.rbNewton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(116, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Введите точность:"
        '
        'txtEps
        '
        Me.txtEps.Location = New System.Drawing.Point(327, 159)
        Me.txtEps.Name = "txtEps"
        Me.txtEps.Size = New System.Drawing.Size(100, 22)
        Me.txtEps.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(111, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(219, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Решаемое уравнение: "
        '
        'lblFunction
        '
        Me.lblFunction.AutoSize = True
        Me.lblFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFunction.Location = New System.Drawing.Point(331, 31)
        Me.lblFunction.Name = "lblFunction"
        Me.lblFunction.Size = New System.Drawing.Size(0, 20)
        Me.lblFunction.TabIndex = 17
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(473, 59)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(452, 330)
        Me.Chart1.TabIndex = 18
        Me.Chart1.Text = "Chart1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 450)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lblFunction)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEps)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbNewton)
        Me.Controls.Add(Me.rbChords)
        Me.Controls.Add(Me.rbIteration)
        Me.Controls.Add(Me.lblIntegral)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.rbDichotomy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtStart)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStart As TextBox
    Friend WithEvents txtEnd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbDichotomy As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblIntegral As Label
    Friend WithEvents rbIteration As RadioButton
    Friend WithEvents rbChords As RadioButton
    Friend WithEvents rbNewton As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEps As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblFunction As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class

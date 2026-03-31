<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtEps = New System.Windows.Forms.TextBox()
        Me.btnRect = New System.Windows.Forms.Button()
        Me.btnSimpson = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResult1 = New System.Windows.Forms.TextBox()
        Me.txtResult2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Интервал интегрирования"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "a"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "b"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Точность"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(412, 100)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(141, 31)
        Me.txtA.TabIndex = 4
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(412, 164)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(141, 31)
        Me.txtB.TabIndex = 5
        '
        'txtEps
        '
        Me.txtEps.Location = New System.Drawing.Point(412, 223)
        Me.txtEps.Name = "txtEps"
        Me.txtEps.Size = New System.Drawing.Size(141, 31)
        Me.txtEps.TabIndex = 6
        '
        'btnRect
        '
        Me.btnRect.Location = New System.Drawing.Point(167, 299)
        Me.btnRect.Name = "btnRect"
        Me.btnRect.Size = New System.Drawing.Size(292, 45)
        Me.btnRect.TabIndex = 7
        Me.btnRect.Text = "Метод прямоугольников"
        Me.btnRect.UseVisualStyleBackColor = True
        '
        'btnSimpson
        '
        Me.btnSimpson.Location = New System.Drawing.Point(167, 365)
        Me.btnSimpson.Name = "btnSimpson"
        Me.btnSimpson.Size = New System.Drawing.Size(292, 43)
        Me.btnSimpson.TabIndex = 8
        Me.btnSimpson.Text = "Метод Симпсона"
        Me.btnSimpson.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(521, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Результаты"
        '
        'txtResult1
        '
        Me.txtResult1.Location = New System.Drawing.Point(508, 306)
        Me.txtResult1.Name = "txtResult1"
        Me.txtResult1.Size = New System.Drawing.Size(246, 31)
        Me.txtResult1.TabIndex = 10
        '
        'txtResult2
        '
        Me.txtResult2.Location = New System.Drawing.Point(508, 371)
        Me.txtResult2.Name = "txtResult2"
        Me.txtResult2.Size = New System.Drawing.Size(246, 31)
        Me.txtResult2.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtResult2)
        Me.Controls.Add(Me.txtResult1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSimpson)
        Me.Controls.Add(Me.btnRect)
        Me.Controls.Add(Me.txtEps)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtEps As TextBox
    Friend WithEvents btnRect As Button
    Friend WithEvents btnSimpson As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtResult1 As TextBox
    Friend WithEvents txtResult2 As TextBox
End Class

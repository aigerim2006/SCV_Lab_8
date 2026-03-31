<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtA2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtB2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEps2 = New System.Windows.Forms.TextBox()
        Me.btnGolden = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtResX = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Граница a:"
        '
        'txtA2
        '
        Me.txtA2.Location = New System.Drawing.Point(334, 109)
        Me.txtA2.Name = "txtA2"
        Me.txtA2.Size = New System.Drawing.Size(180, 31)
        Me.txtA2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Граница b:"
        '
        'txtB2
        '
        Me.txtB2.Location = New System.Drawing.Point(334, 169)
        Me.txtB2.Name = "txtB2"
        Me.txtB2.Size = New System.Drawing.Size(180, 31)
        Me.txtB2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Точность:"
        '
        'txtEps2
        '
        Me.txtEps2.Location = New System.Drawing.Point(334, 234)
        Me.txtEps2.Name = "txtEps2"
        Me.txtEps2.Size = New System.Drawing.Size(180, 31)
        Me.txtEps2.TabIndex = 5
        '
        'btnGolden
        '
        Me.btnGolden.Location = New System.Drawing.Point(81, 320)
        Me.btnGolden.Name = "btnGolden"
        Me.btnGolden.Size = New System.Drawing.Size(234, 50)
        Me.btnGolden.TabIndex = 6
        Me.btnGolden.Text = "Найти экстремум"
        Me.btnGolden.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Точка X:"
        '
        'txtResX
        '
        Me.txtResX.Location = New System.Drawing.Point(473, 326)
        Me.txtResX.Name = "txtResX"
        Me.txtResX.Size = New System.Drawing.Size(294, 31)
        Me.txtResX.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtResX)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGolden)
        Me.Controls.Add(Me.txtEps2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtB2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtA2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtA2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtB2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEps2 As TextBox
    Friend WithEvents btnGolden As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtResX As TextBox
End Class

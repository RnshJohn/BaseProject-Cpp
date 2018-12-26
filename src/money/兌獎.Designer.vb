<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 兌獎
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pricenum = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ramdonint = New System.Windows.Forms.Label()
        Me.winprice = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pricenum
        '
        Me.pricenum.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.pricenum.Location = New System.Drawing.Point(12, 12)
        Me.pricenum.Name = "pricenum"
        Me.pricenum.Size = New System.Drawing.Size(205, 39)
        Me.pricenum.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "檢查中獎"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ramdonint
        '
        Me.ramdonint.AutoSize = True
        Me.ramdonint.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.ramdonint.Location = New System.Drawing.Point(132, 54)
        Me.ramdonint.Name = "ramdonint"
        Me.ramdonint.Size = New System.Drawing.Size(120, 27)
        Me.ramdonint.TabIndex = 2
        Me.ramdonint.Text = "發票號碼"
        '
        'winprice
        '
        Me.winprice.AutoSize = True
        Me.winprice.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.winprice.Location = New System.Drawing.Point(132, 81)
        Me.winprice.Name = "winprice"
        Me.winprice.Size = New System.Drawing.Size(85, 27)
        Me.winprice.TabIndex = 3
        Me.winprice.Text = "中獎?!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(138, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 27)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "中獎金額"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "發票號碼"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "發票張數"
        '
        '兌獎
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 152)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.winprice)
        Me.Controls.Add(Me.ramdonint)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pricenum)
        Me.Name = "兌獎"
        Me.Text = "兌獎"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pricenum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ramdonint As Label
    Friend WithEvents winprice As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

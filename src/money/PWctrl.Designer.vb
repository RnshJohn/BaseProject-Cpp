<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PWctrl
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
        Me.opw = New System.Windows.Forms.TextBox()
        Me.cpw = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'opw
        '
        Me.opw.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.opw.Location = New System.Drawing.Point(127, 6)
        Me.opw.Name = "opw"
        Me.opw.Size = New System.Drawing.Size(124, 39)
        Me.opw.TabIndex = 1
        '
        'cpw
        '
        Me.cpw.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.cpw.Location = New System.Drawing.Point(127, 51)
        Me.cpw.Name = "cpw"
        Me.cpw.Size = New System.Drawing.Size(124, 39)
        Me.cpw.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "確認"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "原有密碼"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(1, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 27)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "更改密碼"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(122, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "狀態"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(1, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "修改狀態:"
        '
        'PWctrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 128)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cpw)
        Me.Controls.Add(Me.opw)
        Me.Name = "PWctrl"
        Me.Text = "PWctrl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opw As TextBox
    Friend WithEvents cpw As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

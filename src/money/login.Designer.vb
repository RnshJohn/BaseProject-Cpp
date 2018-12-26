<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pwinput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Loginbut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pwinput
        '
        Me.pwinput.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.pwinput.Location = New System.Drawing.Point(155, 0)
        Me.pwinput.Name = "pwinput"
        Me.pwinput.Size = New System.Drawing.Size(226, 39)
        Me.pwinput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "請輸入密碼"
        '
        'Loginbut
        '
        Me.Loginbut.Location = New System.Drawing.Point(388, 0)
        Me.Loginbut.Name = "Loginbut"
        Me.Loginbut.Size = New System.Drawing.Size(157, 39)
        Me.Loginbut.TabIndex = 3
        Me.Loginbut.Text = "登入"
        Me.Loginbut.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 45)
        Me.Controls.Add(Me.Loginbut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pwinput)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pwinput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Loginbut As Button
End Class

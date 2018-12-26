Public Class PWctrl
    Dim ts As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If opw.Text <> login.pw Then
            Label3.ForeColor = Color.Red
            Label3.Text = "失敗"
            Label3.Visible = 1
        End If

        If opw.Text = login.pw Then
            Label3.ForeColor = Color.Blue
            login.pw = cpw.Text
            Label3.Text = "成功"
            Label3.Visible = 1

        End If
    End Sub

    Private Sub PWctrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub
End Class
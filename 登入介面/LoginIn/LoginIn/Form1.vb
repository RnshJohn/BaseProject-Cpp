
Public Class Form1
    Public pw As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pwinput.Text = pw Then

            Form2.Show()
            Me.Close()
        ElseIf pwinput.text <> pw Then
            Label1.Text = "密碼輸入錯誤"
            Label1.Visible = True
            pwinput.Text = ""

        End If
    End Sub

    Private Sub a_TextChanged(sender As Object, e As EventArgs) Handles pwinput.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

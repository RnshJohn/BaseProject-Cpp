Public Class 圓餅圖

    Public sum As Integer = 0
    Dim rate(5) As Single

    Public Sub 圓餅圖_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim g As Graphics
        g = Me.CreateGraphics

        For i As Integer = 1 To 4
            rate(i) = Val(money_wallet.cost(i)) / sum
        Next

        g.FillPie(Brushes.Blue, 50, 10, 300, 300, 0, 360 * rate(1))
        g.FillPie(Brushes.Red, 50, 10, 300, 300, 360 * rate(1), 360 * rate(2))
        g.FillPie(Brushes.Purple, 50, 10, 300, 300, 360 * rate(1) + 360 * rate(2), 360 * rate(3))
        g.FillPie(Brushes.Green, 50, 10, 300, 300, 360 * rate(1) + 360 * rate(2) + 360 * rate(3), 360 * rate(4))
        g.DrawPie(Pens.Black, 50, 10, 300, 300, 0, 360 * rate(1))
        g.DrawPie(Pens.Black, 50, 10, 300, 300, 360 * rate(1), 360 * rate(2))
        g.DrawPie(Pens.Black, 50, 10, 300, 300, 360 * rate(1) + 360 * rate(2), 360 * rate(3))
        g.DrawPie(Pens.Black, 50, 10, 300, 300, 360 * rate(1) + 360 * rate(2) + 360 * rate(3), 360 * rate(4))

    End Sub
End Class
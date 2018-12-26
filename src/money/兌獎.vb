Public Class 兌獎
    Dim j As Integer
    Dim tempyour, tempprice As String
    Dim numstr As String
    Dim bonus As Integer = 0
    Dim times As Integer = 0

    Private Sub 兌獎_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim yournum As Integer
        Randomize()
        yournum = Int(Rnd() * 99999999)
        Console.WriteLine("{0,22:D8} {0,22:X8}", yournum)
        numstr = yournum
        For j = 3 To 8
            tempyour = Strings.Right(numstr, j)
            tempprice = Strings.Right(pricenum.Text, j)
            If tempyour = tempprice Then
                Select Case j
                    Case 3
                        bonus = 200 + bonus
                    Case 4
                        bonus = 1000 + bonus
                    Case 5
                        bonus = 4000 + bonus
                    Case 6
                        bonus = 10000 + bonus
                    Case 7
                        bonus = 40000 + bonus
                    Case 8
                        bonus = 200000 + bonus
                End Select
            End If
            If bonus <> 0 Then
                Button1.Enabled = False
            End If
        Next

        times = times + 1
        Label1.Text = Val(times)
        winprice.Text = Val(bonus)
        ramdonint.Text = yournum.ToString("00000000")
    End Sub
End Class
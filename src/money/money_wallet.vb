Public Class money_wallet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'RecordDataSet.PieChart' 資料表。您可以視需要進行移動或移除。
        Me.PieChartTableAdapter.Fill(Me.RecordDataSet.PieChart)
        'TODO: 這行程式碼會將資料載入 'RecordDataSet.Record' 資料表。您可以視需要進行移動或移除。
        Me.RecordTableAdapter.Fill(Me.RecordDataSet.Record)
        'TODO: 這行程式碼會將資料載入 'RecordDataSet.Money' 資料表。您可以視需要進行移動或移除。
        Me.MoneyTableAdapter.Fill(Me.RecordDataSet.Money)
        'TODO: 這行程式碼會將資料載入 'RecordDataSet.PieChart' 資料表。您可以視需要進行移動或移除。
        Me.PieChartTableAdapter.Fill(Me.RecordDataSet.PieChart)
        'TODO: 這行程式碼會將資料載入 'RecordDataSet.Money' 資料表。您可以視需要進行移動或移除。
        Me.MoneyTableAdapter.Fill(Me.RecordDataSet.Money)
        'TODO: 這行程式碼會將資料載入 'RecordDataSet.Record' 資料表。您可以視需要進行移動或移除。
        Me.RecordTableAdapter.Fill(Me.RecordDataSet.Record)
        'TODO: 這行程式碼會將資料載入 'RecordDataSet.Money' 資料表。您可以視需要進行移動或移除。
        Me.MoneyTableAdapter.Fill(Me.RecordDataSet.Money)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        If Val(CostMoneyTextBox.Text) < 0 Then
            Button7.Enabled = True
        Else
            Button7.Enabled = False
        End If

    End Sub

    Dim wallet_money As Integer = 0
    Public cost(5) As Integer


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login.Show()
        PWctrl.Close()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PWctrl.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pieChart.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        兌獎.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MaxMoneyTextBox.Text = Val(critmon.Text) * 0.8
        critmonmax.Text = MaxMoneyTextBox.Text
        MoneyBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(RecordDataSet)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        record.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not IsNumeric(moneychange.Text) Then
            MessageBox.Show("請輸入數字")
            Exit Sub
        End If
        RecordBindingSource.AddNew()
        Select Case SA_SPlist.SelectedIndex
            Case 0


                savcosTextBox.Text = "食"
                monTextBox.Text = Val(moneychange.Text) * -1

                dateTextBox.Text = Format(Now, "yyyy/m/d")
                CostMoneyTextBox.Text = Val(CostMoneyTextBox.Text) - Val(moneychange.Text)
                walletmoney_now.Text = Val(CostMoneyTextBox.Text) + Val(DepositMoneyTextBox.Text)

                RecordBindingSource.EndEdit()
                MoneyBindingSource.EndEdit()
                PieChartBindingSource.MoveFirst()
                金額TextBox1.Text = Val(金額TextBox1.Text) + Val(moneychange.Text)
                PieChartBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(RecordDataSet)

            Case 1



                savcosTextBox.Text = "衣"
                monTextBox.Text = Val(moneychange.Text) * -1

                dateTextBox.Text = Format(Now, "yyyy/m/d")
                CostMoneyTextBox.Text = Val(CostMoneyTextBox.Text) - Val(moneychange.Text)
                walletmoney_now.Text = Val(CostMoneyTextBox.Text) + Val(DepositMoneyTextBox.Text)
                PieChartBindingSource.MoveFirst()
                PieChartBindingSource.MoveNext()
                金額TextBox1.Text = Val(金額TextBox1.Text) + Val(moneychange.Text)
                RecordBindingSource.EndEdit()
                MoneyBindingSource.EndEdit()
                PieChartBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(RecordDataSet)

            Case 2



                savcosTextBox.Text = "住"
                monTextBox.Text = Val(moneychange.Text) * -1

                dateTextBox.Text = Format(Now, "yyyy/m/d")
                CostMoneyTextBox.Text = Val(CostMoneyTextBox.Text) - Val(moneychange.Text)
                walletmoney_now.Text = Val(CostMoneyTextBox.Text) + Val(DepositMoneyTextBox.Text)
                PieChartBindingSource.MoveFirst()
                PieChartBindingSource.MoveNext()
                PieChartBindingSource.MoveNext()
                金額TextBox1.Text = Val(金額TextBox1.Text) + Val(moneychange.Text)
                RecordBindingSource.EndEdit()
                MoneyBindingSource.EndEdit()
                PieChartBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(RecordDataSet)

            Case 3



                savcosTextBox.Text = "行"
                monTextBox.Text = Val(moneychange.Text) * -1

                dateTextBox.Text = Format(Now, "yyyy/m/d")
                CostMoneyTextBox.Text = Val(CostMoneyTextBox.Text) - Val(moneychange.Text)
                walletmoney_now.Text = Val(CostMoneyTextBox.Text) + Val(DepositMoneyTextBox.Text)
                PieChartBindingSource.MoveFirst()
                PieChartBindingSource.MoveNext()
                PieChartBindingSource.MoveNext()
                PieChartBindingSource.MoveNext()
                金額TextBox1.Text = Val(金額TextBox1.Text) + Val(moneychange.Text)
                RecordBindingSource.EndEdit()
                MoneyBindingSource.EndEdit()
                PieChartBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(RecordDataSet)

            Case 4


                savcosTextBox.Text = "存入"
                monTextBox.Text = moneychange.Text
                dateTextBox.Text = Format(Now, "yyyy/m/d")
                DepositMoneyTextBox.Text = Val(DepositMoneyTextBox.Text) + Val(moneychange.Text)
                walletmoney_now.Text = Val(CostMoneyTextBox.Text) + Val(DepositMoneyTextBox.Text)
                RecordBindingSource.EndEdit()
                MoneyBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(RecordDataSet)
        End Select
        If Val(CostMoneyTextBox.Text) < 0 Then
            Button7.Enabled = True
        Else
            Button7.Enabled = False
        End If
        If Val(MaxMoneyTextBox.Text) > 0 Then
            If Val(MaxMoneyTextBox.Text) > Val(CostMoneyTextBox.Text) Then
                Label2.Text = "花費已超出最大預算的80%"
                Label2.Visible = True
            End If

        End If

    End Sub
    Private Sub frmPractise_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        login.Close()
    End Sub

    Private Sub MoneyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MoneyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RecordDataSet)

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class


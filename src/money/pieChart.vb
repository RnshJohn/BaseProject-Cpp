Public Class pieChart



    Public Sub 圓餅圖_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'RecordDataSet.PieChart' 資料表。您可以視需要進行移動或移除。
        Me.PieChartTableAdapter.Fill(Me.RecordDataSet.PieChart)
        'TODO: 這行程式碼會將資料載入 'RecordDataSet.Money' 資料表。您可以視需要進行移動或移除。
        Me.MoneyTableAdapter.Fill(Me.RecordDataSet.Money)
        'TODO: 這行程式碼會將資料載入 'RecordDataSet.Record' 資料表。您可以視需要進行移動或移除。
        Me.RecordTableAdapter.Fill(Me.RecordDataSet.Record)
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

    End Sub


End Class
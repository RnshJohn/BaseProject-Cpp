<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pieChart
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PieChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordDataSet = New money.recordDataSet()
        Me.MoneyTableAdapter = New money.recordDataSetTableAdapters.MoneyTableAdapter()
        Me.RecordTableAdapter = New money.recordDataSetTableAdapters.RecordTableAdapter()
        Me.TableAdapterManager = New money.recordDataSetTableAdapters.TableAdapterManager()
        Me.PieChartTableAdapter = New money.recordDataSetTableAdapters.PieChartTableAdapter()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PieChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.PieChartBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.CustomProperties = "PieLabelStyle=Disabled"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.XValueMember = "項目"
        Series1.YValueMembers = "金額"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(460, 337)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'PieChartBindingSource
        '
        Me.PieChartBindingSource.DataMember = "PieChart"
        Me.PieChartBindingSource.DataSource = Me.RecordDataSet
        '
        'RecordDataSet
        '
        Me.RecordDataSet.DataSetName = "recordDataSet"
        Me.RecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoneyTableAdapter
        '
        Me.MoneyTableAdapter.ClearBeforeFill = True
        '
        'RecordTableAdapter
        '
        Me.RecordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MoneyTableAdapter = Me.MoneyTableAdapter
        Me.TableAdapterManager.PieChartTableAdapter = Me.PieChartTableAdapter
        Me.TableAdapterManager.RecordTableAdapter = Me.RecordTableAdapter
        Me.TableAdapterManager.UpdateOrder = money.recordDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PieChartTableAdapter
        '
        Me.PieChartTableAdapter.ClearBeforeFill = True
        '
        'pieChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "pieChart"
        Me.Text = "圓餅圖"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PieChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents RecordDataSet As recordDataSet
    Friend WithEvents MoneyTableAdapter As recordDataSetTableAdapters.MoneyTableAdapter
    Friend WithEvents RecordTableAdapter As recordDataSetTableAdapters.RecordTableAdapter
    Friend WithEvents TableAdapterManager As recordDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PieChartTableAdapter As recordDataSetTableAdapters.PieChartTableAdapter
    Friend WithEvents PieChartBindingSource As BindingSource
End Class

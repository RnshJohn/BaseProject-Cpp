<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class record
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
        Me.RecordDataSet = New money.recordDataSet()
        Me.RecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordTableAdapter = New money.recordDataSetTableAdapters.RecordTableAdapter()
        Me.TableAdapterManager = New money.recordDataSetTableAdapters.TableAdapterManager()
        Me.RecordDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecordDataSet
        '
        Me.RecordDataSet.DataSetName = "recordDataSet"
        Me.RecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecordBindingSource
        '
        Me.RecordBindingSource.DataMember = "Record"
        Me.RecordBindingSource.DataSource = Me.RecordDataSet
        '
        'RecordTableAdapter
        '
        Me.RecordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MoneyTableAdapter = Nothing
        Me.TableAdapterManager.PieChartTableAdapter = Nothing
        Me.TableAdapterManager.RecordTableAdapter = Me.RecordTableAdapter
        Me.TableAdapterManager.UpdateOrder = money.recordDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecordDataGridView
        '
        Me.RecordDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecordDataGridView.AutoGenerateColumns = False
        Me.RecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.RecordDataGridView.DataSource = Me.RecordBindingSource
        Me.RecordDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.RecordDataGridView.Name = "RecordDataGridView"
        Me.RecordDataGridView.RowTemplate.Height = 24
        Me.RecordDataGridView.Size = New System.Drawing.Size(532, 373)
        Me.RecordDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "存取"
        Me.DataGridViewTextBoxColumn2.HeaderText = "存取"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "金額"
        Me.DataGridViewTextBoxColumn3.HeaderText = "金額"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "日期"
        Me.DataGridViewTextBoxColumn4.HeaderText = "日期"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 397)
        Me.Controls.Add(Me.RecordDataGridView)
        Me.Name = "record"
        Me.Text = "record"
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RecordDataSet As recordDataSet
    Friend WithEvents RecordBindingSource As BindingSource
    Friend WithEvents RecordTableAdapter As recordDataSetTableAdapters.RecordTableAdapter
    Friend WithEvents TableAdapterManager As recordDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecordDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class

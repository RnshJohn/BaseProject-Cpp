<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class money_wallet
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
        Me.SA_SPlist = New System.Windows.Forms.ComboBox()
        Me.moneychange = New System.Windows.Forms.TextBox()
        Me.walletmoney_now = New System.Windows.Forms.Label()
        Me.wallet = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.critmon = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.critmonmax = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.RecordDataSet = New money.recordDataSet()
        Me.MoneyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoneyTableAdapter = New money.recordDataSetTableAdapters.MoneyTableAdapter()
        Me.TableAdapterManager = New money.recordDataSetTableAdapters.TableAdapterManager()
        Me.PieChartTableAdapter = New money.recordDataSetTableAdapters.PieChartTableAdapter()
        Me.RecordTableAdapter = New money.recordDataSetTableAdapters.RecordTableAdapter()
        Me.RecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoTextBox = New System.Windows.Forms.TextBox()
        Me.savcosTextBox = New System.Windows.Forms.TextBox()
        Me.monTextBox = New System.Windows.Forms.TextBox()
        Me.dateTextBox = New System.Windows.Forms.TextBox()
        Me.NoTextBox1 = New System.Windows.Forms.TextBox()
        Me.MaxMoneyTextBox = New System.Windows.Forms.TextBox()
        Me.CostMoneyTextBox = New System.Windows.Forms.TextBox()
        Me.DepositMoneyTextBox = New System.Windows.Forms.TextBox()
        Me.PieChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.識別碼TextBox = New System.Windows.Forms.TextBox()
        Me.項目TextBox = New System.Windows.Forms.TextBox()
        Me.金額TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PieChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SA_SPlist
        '
        Me.SA_SPlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SA_SPlist.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.SA_SPlist.FormattingEnabled = True
        Me.SA_SPlist.Items.AddRange(New Object() {"花費(食)", "花費(衣)", "花費(住)", "花費(行)", "存入"})
        Me.SA_SPlist.Location = New System.Drawing.Point(149, 60)
        Me.SA_SPlist.Name = "SA_SPlist"
        Me.SA_SPlist.Size = New System.Drawing.Size(141, 35)
        Me.SA_SPlist.TabIndex = 97
        '
        'moneychange
        '
        Me.moneychange.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.moneychange.Location = New System.Drawing.Point(8, 60)
        Me.moneychange.Multiline = True
        Me.moneychange.Name = "moneychange"
        Me.moneychange.Size = New System.Drawing.Size(135, 35)
        Me.moneychange.TabIndex = 53
        Me.moneychange.UseSystemPasswordChar = True
        '
        'walletmoney_now
        '
        Me.walletmoney_now.AutoSize = True
        Me.walletmoney_now.Font = New System.Drawing.Font("新細明體", 25.0!)
        Me.walletmoney_now.Location = New System.Drawing.Point(156, 9)
        Me.walletmoney_now.Name = "walletmoney_now"
        Me.walletmoney_now.Size = New System.Drawing.Size(31, 34)
        Me.walletmoney_now.TabIndex = 51
        Me.walletmoney_now.Text = "0"
        '
        'wallet
        '
        Me.wallet.AutoSize = True
        Me.wallet.Font = New System.Drawing.Font("新細明體", 25.0!)
        Me.wallet.Location = New System.Drawing.Point(0, 9)
        Me.wallet.Name = "wallet"
        Me.wallet.Size = New System.Drawing.Size(160, 34)
        Me.wallet.TabIndex = 50
        Me.wallet.Text = "錢包餘額:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 52)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "確認"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(149, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 48)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "更改密碼"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 48)
        Me.Button3.TabIndex = 183
        Me.Button3.Text = "登出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 49)
        Me.Button4.TabIndex = 184
        Me.Button4.Text = "紀錄"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(149, 214)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 48)
        Me.Button5.TabIndex = 185
        Me.Button5.Text = "發票兌獎"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'critmon
        '
        Me.critmon.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.critmon.Location = New System.Drawing.Point(8, 271)
        Me.critmon.Name = "critmon"
        Me.critmon.Size = New System.Drawing.Size(135, 39)
        Me.critmon.TabIndex = 186
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(149, 268)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 48)
        Me.Button6.TabIndex = 187
        Me.Button6.Text = "設定最高預算"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(1, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 27)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "目前最高預算:"
        '
        'critmonmax
        '
        Me.critmonmax.AutoSize = True
        Me.critmonmax.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.critmonmax.Location = New System.Drawing.Point(188, 319)
        Me.critmonmax.Name = "critmonmax"
        Me.critmonmax.Size = New System.Drawing.Size(39, 27)
        Me.critmonmax.TabIndex = 189
        Me.critmonmax.Text = "無"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(3, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 30)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(149, 102)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(141, 52)
        Me.Button7.TabIndex = 191
        Me.Button7.Text = "圓餅圖"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'RecordDataSet
        '
        Me.RecordDataSet.DataSetName = "recordDataSet"
        Me.RecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoneyBindingSource
        '
        Me.MoneyBindingSource.DataMember = "Money"
        Me.MoneyBindingSource.DataSource = Me.RecordDataSet
        '
        'MoneyTableAdapter
        '
        Me.MoneyTableAdapter.ClearBeforeFill = True
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
        'RecordTableAdapter
        '
        Me.RecordTableAdapter.ClearBeforeFill = True
        '
        'RecordBindingSource
        '
        Me.RecordBindingSource.DataMember = "Record"
        Me.RecordBindingSource.DataSource = Me.RecordDataSet
        '
        'NoTextBox
        '
        Me.NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "No", True))
        Me.NoTextBox.Location = New System.Drawing.Point(521, 53)
        Me.NoTextBox.Name = "NoTextBox"
        Me.NoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NoTextBox.TabIndex = 192
        '
        'savcosTextBox
        '
        Me.savcosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "存取", True))
        Me.savcosTextBox.Location = New System.Drawing.Point(521, 81)
        Me.savcosTextBox.Name = "savcosTextBox"
        Me.savcosTextBox.Size = New System.Drawing.Size(100, 22)
        Me.savcosTextBox.TabIndex = 194
        '
        'monTextBox
        '
        Me.monTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "金額", True))
        Me.monTextBox.Location = New System.Drawing.Point(521, 109)
        Me.monTextBox.Name = "monTextBox"
        Me.monTextBox.Size = New System.Drawing.Size(100, 22)
        Me.monTextBox.TabIndex = 196
        '
        'dateTextBox
        '
        Me.dateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "日期", True))
        Me.dateTextBox.Location = New System.Drawing.Point(521, 137)
        Me.dateTextBox.Name = "dateTextBox"
        Me.dateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.dateTextBox.TabIndex = 198
        '
        'NoTextBox1
        '
        Me.NoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyBindingSource, "No", True))
        Me.NoTextBox1.Location = New System.Drawing.Point(521, 174)
        Me.NoTextBox1.Name = "NoTextBox1"
        Me.NoTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.NoTextBox1.TabIndex = 199
        '
        'MaxMoneyTextBox
        '
        Me.MaxMoneyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyBindingSource, "maxMoney", True))
        Me.MaxMoneyTextBox.Location = New System.Drawing.Point(521, 202)
        Me.MaxMoneyTextBox.Name = "MaxMoneyTextBox"
        Me.MaxMoneyTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MaxMoneyTextBox.TabIndex = 201
        '
        'CostMoneyTextBox
        '
        Me.CostMoneyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyBindingSource, "costMoney", True))
        Me.CostMoneyTextBox.Location = New System.Drawing.Point(521, 230)
        Me.CostMoneyTextBox.Name = "CostMoneyTextBox"
        Me.CostMoneyTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CostMoneyTextBox.TabIndex = 203
        '
        'DepositMoneyTextBox
        '
        Me.DepositMoneyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyBindingSource, "depositMoney", True))
        Me.DepositMoneyTextBox.Location = New System.Drawing.Point(521, 258)
        Me.DepositMoneyTextBox.Name = "DepositMoneyTextBox"
        Me.DepositMoneyTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DepositMoneyTextBox.TabIndex = 205
        '
        'PieChartBindingSource
        '
        Me.PieChartBindingSource.DataMember = "PieChart"
        Me.PieChartBindingSource.DataSource = Me.RecordDataSet
        '
        '識別碼TextBox
        '
        Me.識別碼TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PieChartBindingSource, "識別碼", True))
        Me.識別碼TextBox.Location = New System.Drawing.Point(521, 294)
        Me.識別碼TextBox.Name = "識別碼TextBox"
        Me.識別碼TextBox.Size = New System.Drawing.Size(100, 22)
        Me.識別碼TextBox.TabIndex = 206
        '
        '項目TextBox
        '
        Me.項目TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PieChartBindingSource, "項目", True))
        Me.項目TextBox.Location = New System.Drawing.Point(521, 322)
        Me.項目TextBox.Name = "項目TextBox"
        Me.項目TextBox.Size = New System.Drawing.Size(100, 22)
        Me.項目TextBox.TabIndex = 208
        '
        '金額TextBox1
        '
        Me.金額TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PieChartBindingSource, "金額", True))
        Me.金額TextBox1.Location = New System.Drawing.Point(521, 350)
        Me.金額TextBox1.Name = "金額TextBox1"
        Me.金額TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.金額TextBox1.TabIndex = 210
        '
        'money_wallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 417)
        Me.Controls.Add(Me.識別碼TextBox)
        Me.Controls.Add(Me.項目TextBox)
        Me.Controls.Add(Me.金額TextBox1)
        Me.Controls.Add(Me.NoTextBox1)
        Me.Controls.Add(Me.MaxMoneyTextBox)
        Me.Controls.Add(Me.CostMoneyTextBox)
        Me.Controls.Add(Me.DepositMoneyTextBox)
        Me.Controls.Add(Me.NoTextBox)
        Me.Controls.Add(Me.savcosTextBox)
        Me.Controls.Add(Me.monTextBox)
        Me.Controls.Add(Me.dateTextBox)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.critmonmax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.critmon)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.wallet)
        Me.Controls.Add(Me.SA_SPlist)
        Me.Controls.Add(Me.walletmoney_now)
        Me.Controls.Add(Me.moneychange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "money_wallet"
        Me.Text = "money"
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PieChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SA_SPlist As ComboBox
    Friend WithEvents moneychange As TextBox
    Friend WithEvents walletmoney_now As Label
    Friend WithEvents wallet As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents critmon As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents critmonmax As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents RecordDataSet As recordDataSet
    Friend WithEvents MoneyBindingSource As BindingSource
    Friend WithEvents MoneyTableAdapter As recordDataSetTableAdapters.MoneyTableAdapter
    Friend WithEvents TableAdapterManager As recordDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecordTableAdapter As recordDataSetTableAdapters.RecordTableAdapter
    Friend WithEvents RecordBindingSource As BindingSource
    Friend WithEvents PieChartTableAdapter As recordDataSetTableAdapters.PieChartTableAdapter
    Friend WithEvents NoTextBox As TextBox
    Friend WithEvents savcosTextBox As TextBox
    Friend WithEvents monTextBox As TextBox
    Friend WithEvents dateTextBox As TextBox
    Friend WithEvents NoTextBox1 As TextBox
    Friend WithEvents MaxMoneyTextBox As TextBox
    Friend WithEvents CostMoneyTextBox As TextBox
    Friend WithEvents DepositMoneyTextBox As TextBox
    Friend WithEvents PieChartBindingSource As BindingSource
    Friend WithEvents 識別碼TextBox As TextBox
    Friend WithEvents 項目TextBox As TextBox
    Friend WithEvents 金額TextBox1 As TextBox
End Class

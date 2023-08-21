<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventoryViewer
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SplitContainer1 = New SplitContainer()
        cmbInputType = New ComboBox()
        numKingaku = New NumericUpDown()
        Label7 = New Label()
        dtpInputDate = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtTantou = New TextBox()
        TextBox1 = New TextBox()
        txtHinmei = New TextBox()
        btnFind = New Button()
        SplitContainer2 = New SplitContainer()
        dgvInventory = New DataGridView()
        btnExit = New Button()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(numKingaku, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel1
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(cmbInputType)
        SplitContainer1.Panel1.Controls.Add(numKingaku)
        SplitContainer1.Panel1.Controls.Add(Label7)
        SplitContainer1.Panel1.Controls.Add(dtpInputDate)
        SplitContainer1.Panel1.Controls.Add(Label5)
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(Label8)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(txtTantou)
        SplitContainer1.Panel1.Controls.Add(TextBox1)
        SplitContainer1.Panel1.Controls.Add(txtHinmei)
        SplitContainer1.Panel1.Controls.Add(btnFind)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(816, 612)
        SplitContainer1.SplitterDistance = 71
        SplitContainer1.TabIndex = 0
        ' 
        ' cmbInputType
        ' 
        cmbInputType.DisplayMember = "1,2"
        cmbInputType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbInputType.FlatStyle = FlatStyle.System
        cmbInputType.FormattingEnabled = True
        cmbInputType.Items.AddRange(New Object() {"入庫", "出庫"})
        cmbInputType.Location = New Point(67, 41)
        cmbInputType.Name = "cmbInputType"
        cmbInputType.Size = New Size(121, 23)
        cmbInputType.TabIndex = 5
        cmbInputType.ValueMember = "1,2"
        ' 
        ' numKingaku
        ' 
        numKingaku.Location = New Point(507, 41)
        numKingaku.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        numKingaku.Name = "numKingaku"
        numKingaku.Size = New Size(86, 23)
        numKingaku.TabIndex = 13
        numKingaku.ThousandsSeparator = True
        numKingaku.Value = New Decimal(New Integer() {999999999, 0, 0, 0})
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(476, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(31, 15)
        Label7.TabIndex = 12
        Label7.Text = "金額"
        ' 
        ' dtpInputDate
        ' 
        dtpInputDate.CustomFormat = "yyyy/MM/dd hh:mm"
        dtpInputDate.Format = DateTimePickerFormat.Custom
        dtpInputDate.Location = New Point(250, 12)
        dtpInputDate.Name = "dtpInputDate"
        dtpInputDate.Size = New Size(132, 23)
        dtpInputDate.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(189, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 2
        Label5.Text = "処理日時"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 4
        Label4.Text = "処理区分"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(339, 45)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 15)
        Label8.TabIndex = 14
        Label8.Text = "備考"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(194, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 6
        Label2.Text = "品名"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 0
        Label1.Text = "担当者"
        ' 
        ' txtTantou
        ' 
        txtTantou.Location = New Point(61, 12)
        txtTantou.Name = "txtTantou"
        txtTantou.Size = New Size(100, 23)
        txtTantou.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(370, 41)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 7
        ' 
        ' txtHinmei
        ' 
        txtHinmei.Location = New Point(231, 41)
        txtHinmei.Name = "txtHinmei"
        txtHinmei.Size = New Size(100, 23)
        txtHinmei.TabIndex = 7
        ' 
        ' btnFind
        ' 
        btnFind.Location = New Point(668, 28)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(145, 36)
        btnFind.TabIndex = 16
        btnFind.Text = "検索"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.FixedPanel = FixedPanel.Panel2
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(dgvInventory)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(btnExit)
        SplitContainer2.Panel2MinSize = 38
        SplitContainer2.Size = New Size(816, 537)
        SplitContainer2.SplitterDistance = 485
        SplitContainer2.TabIndex = 0
        ' 
        ' dgvInventory
        ' 
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventory.Dock = DockStyle.Fill
        dgvInventory.Location = New Point(0, 0)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.RowTemplate.Height = 25
        dgvInventory.Size = New Size(816, 485)
        dgvInventory.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.Dock = DockStyle.Fill
        btnExit.Location = New Point(0, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(816, 48)
        btnExit.TabIndex = 1
        btnExit.Text = "終了"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmInventoryViewer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(816, 612)
        Controls.Add(SplitContainer1)
        Name = "frmInventoryViewer"
        Text = "在庫確認画面"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(numKingaku, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents btnExit As Button
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHinmei As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents dtpInputDate As DateTimePicker
    Friend WithEvents cmbInputType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTantou As TextBox
    Friend WithEvents numKingaku As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
End Class

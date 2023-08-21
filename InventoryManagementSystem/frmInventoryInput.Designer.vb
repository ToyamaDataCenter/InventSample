<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryInput
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmInventoryInput))
        SplitContainer1 = New SplitContainer()
        cmbInputType = New ComboBox()
        numKingaku = New NumericUpDown()
        numSuryou = New NumericUpDown()
        Label7 = New Label()
        dtpInputDate = New DateTimePicker()
        Label3 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtTantou = New TextBox()
        txtBikou = New TextBox()
        txtTani = New TextBox()
        txtHinmei = New TextBox()
        btnAdd = New Button()
        SplitContainer2 = New SplitContainer()
        dgvInventory = New DataGridView()
        btnRegist = New Button()
        btnExit = New Button()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(numKingaku, ComponentModel.ISupportInitialize).BeginInit()
        CType(numSuryou, ComponentModel.ISupportInitialize).BeginInit()
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
        SplitContainer1.Panel1.Controls.Add(numSuryou)
        SplitContainer1.Panel1.Controls.Add(Label7)
        SplitContainer1.Panel1.Controls.Add(dtpInputDate)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(Label5)
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(Label8)
        SplitContainer1.Panel1.Controls.Add(Label6)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(txtTantou)
        SplitContainer1.Panel1.Controls.Add(txtBikou)
        SplitContainer1.Panel1.Controls.Add(txtTani)
        SplitContainer1.Panel1.Controls.Add(txtHinmei)
        SplitContainer1.Panel1.Controls.Add(btnAdd)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(816, 612)
        SplitContainer1.SplitterDistance = 211
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
        numKingaku.Location = New Point(502, 70)
        numKingaku.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        numKingaku.Name = "numKingaku"
        numKingaku.Size = New Size(86, 23)
        numKingaku.TabIndex = 13
        numKingaku.ThousandsSeparator = True
        numKingaku.Value = New Decimal(New Integer() {999999999, 0, 0, 0})
        ' 
        ' numSuryou
        ' 
        numSuryou.DecimalPlaces = 2
        numSuryou.Location = New Point(206, 70)
        numSuryou.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        numSuryou.Name = "numSuryou"
        numSuryou.Size = New Size(70, 23)
        numSuryou.TabIndex = 9
        numSuryou.ThousandsSeparator = True
        numSuryou.Value = New Decimal(New Integer() {999999, 0, 0, 131072})
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(471, 74)
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(175, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 8
        Label3.Text = "数量"
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
        Label8.Location = New Point(12, 103)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 15)
        Label8.TabIndex = 14
        Label8.Text = "備考"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(308, 74)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 15)
        Label6.TabIndex = 10
        Label6.Text = "単位"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 74)
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
        ' txtBikou
        ' 
        txtBikou.Location = New Point(12, 118)
        txtBikou.MaxLength = 512
        txtBikou.Multiline = True
        txtBikou.Name = "txtBikou"
        txtBikou.Size = New Size(800, 88)
        txtBikou.TabIndex = 15
        txtBikou.Text = resources.GetString("txtBikou.Text")
        ' 
        ' txtTani
        ' 
        txtTani.Location = New Point(339, 70)
        txtTani.Name = "txtTani"
        txtTani.Size = New Size(100, 23)
        txtTani.TabIndex = 11
        ' 
        ' txtHinmei
        ' 
        txtHinmei.Location = New Point(49, 70)
        txtHinmei.Name = "txtHinmei"
        txtHinmei.Size = New Size(100, 23)
        txtHinmei.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(667, 76)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(145, 36)
        btnAdd.TabIndex = 16
        btnAdd.Text = "追加"
        btnAdd.UseVisualStyleBackColor = True
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
        SplitContainer2.Panel2.Controls.Add(btnRegist)
        SplitContainer2.Panel2.Controls.Add(btnExit)
        SplitContainer2.Panel2MinSize = 38
        SplitContainer2.Size = New Size(816, 397)
        SplitContainer2.SplitterDistance = 345
        SplitContainer2.TabIndex = 0
        ' 
        ' dgvInventory
        ' 
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventory.Dock = DockStyle.Fill
        dgvInventory.Location = New Point(0, 0)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.RowTemplate.Height = 25
        dgvInventory.Size = New Size(816, 345)
        dgvInventory.TabIndex = 0
        ' 
        ' btnRegist
        ' 
        btnRegist.Dock = DockStyle.Fill
        btnRegist.Location = New Point(0, 0)
        btnRegist.Name = "btnRegist"
        btnRegist.Size = New Size(653, 48)
        btnRegist.TabIndex = 0
        btnRegist.Text = "登録"
        btnRegist.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Dock = DockStyle.Right
        btnExit.Location = New Point(653, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(163, 48)
        btnExit.TabIndex = 1
        btnExit.Text = "終了"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmInventoryInput
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(816, 612)
        Controls.Add(SplitContainer1)
        Name = "frmInventoryInput"
        Text = "frmInventoryInput"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(numKingaku, ComponentModel.ISupportInitialize).EndInit()
        CType(numSuryou, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnRegist As Button
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHinmei As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents dtpInputDate As DateTimePicker
    Friend WithEvents cmbInputType As ComboBox
    Friend WithEvents numSuryou As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTantou As TextBox
    Friend WithEvents numKingaku As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBikou As TextBox
    Friend WithEvents txtTani As TextBox
End Class

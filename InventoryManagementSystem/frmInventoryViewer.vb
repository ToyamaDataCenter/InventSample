Public Class frmInventoryViewer

    ''' <summary>
    ''' 追加済データの登録／未登録
    ''' </summary>
    Private fpIsRegisted As Boolean = True

    ''' <summary>
    ''' 画面へ表示する内容を保持するデータテーブル
    ''' </summary>
    Private fpInventoryDataTable As DataTable


    Private fprInventoryAdapter As clsInventoryAdapter


    Private Enum InvGridColumns
        vSyoriKubun
        vHinmei
        vSuuryou
        vTani
        vKingaku
        vTantousya
        vBikou
        vSyoriDateTime

    End Enum


    Private Sub frmInventoryInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InputClear()

        Me.fpInventoryDataTable = New DataTable

        Me.fprInventoryAdapter = New clsInventoryAdapter
        Me.fpInventoryDataTable = fprInventoryAdapter.FillInventoryLog()

    End Sub


    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim wViewDataRows As IEnumerable(Of DataRow) =
            (From
                 _dataRow In Me.fpInventoryDataTable
             Where
                 _dataRow.Field(Of String)("Tantousya").Contains(Me.txtTantou.Text.Trim) And
                 _dataRow.Field(Of DateTime)("SyoriDateTime").Date = Me.dtpInputDate.Value.Date And
                 _dataRow.Field(Of String)("SyoriKubun") = {"1", "2"}(Me.cmbInputType.SelectedIndex) And
                 _dataRow.Field(Of String)("Hinmei").Contains(Me.txtHinmei.Text.Trim) And
                 _dataRow.Field(Of String)("Bikou").Contains(Me.txtBikou.Text.Trim))

        If (wViewDataRows.Any = False) Then
            MessageBox.Show(Me, "件数がゼロ件です。", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Me.txtTantou.Focus()
            Return
        End If

        Dim wRowCount As Integer = wViewDataRows.Count
        Me.dgvInventory.RowCount = wRowCount

        For _dtIdx As Integer = 0 To wRowCount - 1
            Dim wDataRow As DataRow = wViewDataRows(_dtIdx)
            Me.dgvInventory.Item(InvGridColumns.vSyoriKubun, _dtIdx).Value =
                If(wDataRow.Field(Of String)("SyoriKubun") = "1", "入庫", "出庫")
            Me.dgvInventory.Item(InvGridColumns.vHinmei, _dtIdx).Value = wDataRow.Field(Of String)("Hinmei")
            Me.dgvInventory.Item(InvGridColumns.vSuuryou, _dtIdx).Value = wDataRow.Field(Of Integer)("Suuryou")
            Me.dgvInventory.Item(InvGridColumns.vTani, _dtIdx).Value = wDataRow.Field(Of String)("Tani")
            Me.dgvInventory.Item(InvGridColumns.vKingaku, _dtIdx).Value = wDataRow.Field(Of Integer)("Kingaku")
            Me.dgvInventory.Item(InvGridColumns.vTantousya, _dtIdx).Value = wDataRow.Field(Of String)("Tantousya")
            Me.dgvInventory.Item(InvGridColumns.vBikou, _dtIdx).Value = wDataRow.Field(Of String)("Bikou")
            Me.dgvInventory.Item(InvGridColumns.vSyoriDateTime, _dtIdx).Value = wDataRow.Field(Of DateTime)("SyoriDatetime").ToString("yy/MM/dd HH:mm")

        Next

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    ''' <summary>
    ''' 入力データのクリア
    ''' </summary>
    Private Sub InputClear()
        Me.txtTantou.Clear()
        Me.cmbInputType.SelectedIndex = 0
        Me.txtHinmei.Clear()
        Me.txtBikou.Clear()
    End Sub

End Class
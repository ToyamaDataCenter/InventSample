Public Class frmInventoryViewer

    ''' <summary>
    ''' 追加済データの登録／未登録
    ''' </summary>
    Private fpIsRegisted As Boolean = True

    ''' <summary>
    ''' 画面へ表示する内容を保持するデータテーブル
    ''' </summary>
    Private fpInventoryDataTable As New DataTable

    ''' <summary>
    ''' 在庫データ接続クラス
    ''' </summary>
    Private fpInventoryAdapter As New clsInventoryAdapter

    ''' <summary>
    ''' データグリッドビュー上の列インデックス
    ''' </summary>
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


    ''' <summary>
    ''' フォーム開始時イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmInventoryInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 検索条件をリセットする
        Me.ClearInput()

    End Sub


    ''' <summary>
    ''' 検索ボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ' DBより最新の在庫データを取り込む
        Me.fpInventoryDataTable = fpInventoryAdapter.FillInventoryLog()


        '' 在庫データを検索条件に従い絞り込む
        Dim wViewDataRows As IEnumerable(Of DataRow) =
            (From
                 _dataRow In Me.fpInventoryDataTable
             Where
                 _dataRow.Field(Of String)("Tantousya") = Me.txtTantou.Text.Trim And
                 _dataRow.Field(Of DateTime)("SyoriDateTime").Date = Me.dtpInputDate.Value.Date And
                 _dataRow.Field(Of String)("SyoriKubun") = {"1", "2"}(Me.cmbInputType.SelectedIndex))

        '' 検索結果を画面へ表示する
        Dim wRowCount As Integer = wViewDataRows.Count
        Me.dgvInventory.RowCount = wRowCount ' データグリッドの行数を設定

        For _dtIdx As Integer = 0 To wRowCount - 1
            Dim wDataRow As DataRow = wViewDataRows(_dtIdx)

            '' 在庫データを成型してグリッドへ設定する
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


    ''' <summary>
    ''' 終了ボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    ''' <summary>
    ''' 入力データのクリア
    ''' </summary>
    Private Sub ClearInput()
        Me.txtTantou.Clear()
        Me.cmbInputType.SelectedIndex = 0
        Me.txtHinmei.Clear()
        Me.txtBikou.Clear()
    End Sub

End Class
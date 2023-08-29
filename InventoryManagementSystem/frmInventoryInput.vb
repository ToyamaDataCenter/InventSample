Imports System.ComponentModel
Imports System.Text

Public Class frmInventoryInput

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
        ' 画面全体のデータをクリア
        Me.ClearInput(True)

        Me.FetchInventoryData()

    End Sub

    ''' <summary>
    ''' フォーム終了前イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmInventoryInput_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (Me.fpIsUnregisted = True AndAlso
            MessageBox.Show(Me,
                            "未登録のデータがあります。終了してもよろしいですか？",
                            Me.Text,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2) = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub

    ''' <summary>
    ''' 追加ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '' 入力中のデータがグリッドへ追加可能か確認
        If (Me.ValidateData() = False) Then
            Me.txtTantou.Focus()
            Return
        End If

        '' 入力中のデータを行データとしてまとめる
        Dim wNewRow As DataRow = fpInventoryDataTable.NewRow()
        wNewRow.Item("SyoriKubun") = {"1", "2"}(Me.cmbInputType.SelectedIndex)
        wNewRow.Item("Hinmei") = Me.txtHinmei.Text.ToString()
        wNewRow.Item("Suuryou") = CInt(Me.numSuryou.Value)
        wNewRow.Item("Tani") = Me.txtTani.Text
        wNewRow.Item("Kingaku") = CInt(Me.numKingaku.Value)
        wNewRow.Item("Tantousya") = Me.txtTantou.Text
        wNewRow.Item("Bikou") = Me.txtBikou.Text
        wNewRow.Item("SyoriDateTime") = Me.dtpInputDate.Value
        wNewRow.Item("InputDateTime") = DateTime.MinValue
        wNewRow.Item("UpdateDateTime") = DateTime.MinValue

        '' 行データを追加する
        Me.fpInventoryDataTable.Rows.Add(wNewRow)

        Dim wNewRowIndex As Integer = dgvInventory.RowCount - 2
        dgvInventory.RowCount = dgvInventory.RowCount + 1
        Me.dgvInventory.Item(InvGridColumns.vSyoriKubun, wNewRowIndex).Value =
                If(wNewRow.Field(Of String)("SyoriKubun") = "1", "入庫", "出庫")
        Me.dgvInventory.Item(InvGridColumns.vHinmei, wNewRowIndex).Value = wNewRow.Field(Of String)("Hinmei")
        Me.dgvInventory.Item(InvGridColumns.vSuuryou, wNewRowIndex).Value = wNewRow.Field(Of Integer)("Suuryou")
        Me.dgvInventory.Item(InvGridColumns.vTani, wNewRowIndex).Value = wNewRow.Field(Of String)("Tani")
        Me.dgvInventory.Item(InvGridColumns.vKingaku, wNewRowIndex).Value = wNewRow.Field(Of Integer)("Kingaku")
        Me.dgvInventory.Item(InvGridColumns.vTantousya, wNewRowIndex).Value = wNewRow.Field(Of String)("Tantousya")
        Me.dgvInventory.Item(InvGridColumns.vBikou, wNewRowIndex).Value = wNewRow.Field(Of String)("Bikou")
        Me.dgvInventory.Item(InvGridColumns.vSyoriDateTime, wNewRowIndex).Value = wNewRow.Field(Of DateTime)("SyoriDatetime").ToString("yy/MM/dd HH:mm")

        Me.SettingUnregisted()

        '' 画面を新規入力可能な状態に設定する
        Me.ClearInput(False)
        Me.txtHinmei.Focus()
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click
        ' DBを更新し最新データを再度取得する
        If (fpInventoryAdapter.InsertInventoryLog(fpInventoryDataTable) > 0) Then
            Me.ReleaseUnregisted()

            Me.FetchInventoryData()
        End If

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
    ''' <param name="aNewForm"></param>
    Private Sub ClearInput(ByVal aNewForm As Boolean)
        If (aNewForm) Then
            '' フォーム立ち上げ時のみクリアする項目
            Me.txtTantou.Clear()
            Me.ReleaseUnregisted()

        End If

        Me.cmbInputType.SelectedIndex = 0
        Me.txtHinmei.Clear()
        Me.numSuryou.Value = 0
        Me.numKingaku.Value = 0
        Me.txtTani.Clear()
        Me.txtBikou.Clear()

    End Sub


    ''' <summary>
    ''' フォーム内のデータが追加可能か検証する
    ''' </summary>
    ''' <returns>追加可能/追加不可(True/False)</returns>
    Private Function ValidateData() As Boolean
        Dim wSblWarningMessage As New StringBuilder
        Dim wIsWarning As Boolean = False

        '' 各入力項目の警告メッセージと警告の有無を設定する
        If (Me.txtTantou.Text.Trim.Length = 0) Then
            wSblWarningMessage.Append("・担当者が入力されていません" & vbCrLf)
            wIsWarning = True

        End If

        If (Me.txtHinmei.Text.Trim.Length = 0) Then
            wSblWarningMessage.Append("・品名が入力されていません" & vbCrLf)
            wIsWarning = True

        End If

        If (Me.numSuryou.Value = 0) Then
            wSblWarningMessage.Append("・数量が入力されていません" & vbCrLf)
            wIsWarning = True

        End If

        If (Me.txtTani.Text.Trim.Length = 0) Then
            wSblWarningMessage.Append("・単位が入力されていません" & vbCrLf)
            wIsWarning = True

        End If

        '' 警告メッセージを表示する
        If (wIsWarning = True) Then
            MessageBox.Show(Me, wSblWarningMessage.ToString(),
                            Me.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1)
        End If

        Return Not wIsWarning

    End Function


    Const VIEW_COUNT As Integer = 20
    Private Sub FetchInventoryData()
        ' 最新の在庫履歴を取得
        Me.fpInventoryDataTable = fpInventoryAdapter.FillInventoryLog()

        '' 在庫履歴データをとデータグリッドビューへ結びつける
        'Me.dgvInventory.DataSource = Me.fpInventoryDataTable
        dgvInventory.Rows.Clear()

        '' 在庫データを検索条件に従い絞り込む
        Dim wViewDataRows As IEnumerable(Of DataRow) =
            (From
                 _dataRow In Me.fpInventoryDataTable
             Order By
                 _dataRow.Field(Of DateTime)("SyoriDateTime") Descending,
                 _dataRow.Field(Of Integer)("ID") Descending
             ).Take(VIEW_COUNT)

        '' 検索結果を画面へ表示する
        Dim wRowCount As Integer = wViewDataRows.Count
        Me.dgvInventory.RowCount = wRowCount + 2 ' データグリッドの行数を設定

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

#Region "未登録状態の管理"
    ''' <summary>
    ''' 未登録フラグ
    ''' </summary>
    Private Property fpIsUnregisted As Boolean = False

    ''' <summary>
    ''' 未登録状態の設定
    ''' </summary>
    Private Sub SettingUnregisted()
        If (Me.fpIsUnregisted = False) Then
            Me.btnRegist.BackColor = Color.Red
            Me.fpIsUnregisted = True
        End If

    End Sub

    ''' <summary>
    ''' 未登録状態の解除
    ''' </summary>
    Private Sub ReleaseUnregisted()
        Me.btnRegist.BackColor = SystemColors.Control
        Me.fpIsUnregisted = False

    End Sub


#End Region




End Class
Imports System.Text

Public Class frmInventoryInput

    ''' <summary>
    ''' 追加済データの登録／未登録
    ''' </summary>
    Private fpIsRegisted As Boolean = True

    ''' <summary>
    ''' 画面へ表示する内容を保持するデータテーブル
    ''' </summary>
    Private fpInventoryDataTable As DataTable

    ''' <summary>
    ''' 在庫データ接続クラス
    ''' </summary>
    Private fprInventoryAdapter As clsInventoryAdapter


    Private Sub frmInventoryInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InputClear(True)

        Me.fpInventoryDataTable = New DataTable

        Me.fprInventoryAdapter = New clsInventoryAdapter
        Me.fpInventoryDataTable = fprInventoryAdapter.FillInventoryLog()

        Me.dgvInventory.DataSource = Me.fpInventoryDataTable


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim wNewRow As DataRow = fpInventoryDataTable.NewRow()

        If (Me.CheckAddData() = False) Then
            Me.txtTantou.Focus()
            Return
        End If

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

        fpInventoryDataTable.Rows.Add(wNewRow)

        Me.SetingUnregisted()
        Me.InputClear(False)
        Me.txtHinmei.Focus()
    End Sub

    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click
        If (fprInventoryAdapter.InsertInventoryLog(fpInventoryDataTable) > 0) Then
            Me.ReleaseUnregisted()

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If (Me.fprIsUnregisted = True) Then
            MessageBox.Show(Me,
                            "未登録のデータがあります。終了してもよろしいですか？",
                            Me.Text,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2)
        Else
            Me.Close()
        End If

    End Sub

    ''' <summary>
    ''' 入力データのクリア
    ''' </summary>
    ''' <param name="aNewForm"></param>
    Private Sub InputClear(ByVal aNewForm As Boolean)
        If (aNewForm) Then
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
    ''' 追加データのチェック
    ''' </summary>
    ''' <returns></returns>
    Private Function CheckAddData() As Boolean
        Dim wSblWarningMessage As New StringBuilder
        Dim wCheckSuccess As Boolean = True

        If (Me.txtTantou.Text.Trim.Length = 0) Then
            wSblWarningMessage.Append("・担当者が入力されていません" & vbCrLf)
            wCheckSuccess = False

        End If

        If (Me.txtHinmei.Text.Trim.Length = 0) Then
            wSblWarningMessage.Append("・品名が入力されていません" & vbCrLf)
            wCheckSuccess = False

        End If

        If (Me.numSuryou.Value = 0) Then
            wSblWarningMessage.Append("・数量が入力されていません" & vbCrLf)
            wCheckSuccess = False

        End If

        If (Me.txtTani.Text.Trim.Length = 0) Then
            wSblWarningMessage.Append("・単位が入力されていません" & vbCrLf)
            wCheckSuccess = False

        End If

        If (wCheckSuccess = False) Then
            MessageBox.Show(Me, wSblWarningMessage.ToString(),
                            Me.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1)
        End If

        Return wCheckSuccess

    End Function

#Region "未登録状態の管理"
    ''' <summary>
    ''' 未登録フラグ
    ''' </summary>
    Private fprIsUnregisted As Boolean = False

    ''' <summary>
    ''' 未登録状態の設定
    ''' </summary>
    Private Sub SetingUnregisted()
        If (Me.fprIsUnregisted = False) Then
            Me.btnRegist.BackColor = Color.Red
            Me.fprIsUnregisted = True
        End If

    End Sub

    ''' <summary>
    ''' 未登録状態の解除
    ''' </summary>
    Private Sub ReleaseUnregisted()
        Me.btnRegist.BackColor = SystemColors.Control
        Me.fprIsUnregisted = False

    End Sub

#End Region




End Class
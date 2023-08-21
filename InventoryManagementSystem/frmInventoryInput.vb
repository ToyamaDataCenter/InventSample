Public Class frmInventoryInput

    ''' <summary>
    ''' 追加済データの登録／未登録
    ''' </summary>
    Private fpIsRegisted As Boolean = True

    ''' <summary>
    ''' 画面へ表示する内容を保持するデータテーブル
    ''' </summary>
    Private fpInventoryDataTable As DataTable


    Private Sub frmInventoryInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fpInventoryDataTable = New DataTable

        Me.dgvInventory.DataSource = fpInventoryDataTable


        Dim wNewDataRow As DataRow = fpInventoryDataTable.NewRow

        'wNewDataRow.co.Item("hoge") = 1

        fpInventoryDataTable.ImportRow(wNewDataRow)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Field(Of Integer)("hoge") = 1

    End Sub

    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    Private Function fetchInventoryDataTable() As DataSet
        Dim wNewDataSet As DataSet


        Dim wDataAdapter As Data.Common.DataAdapter
        'Data.Common.DataAdapter.

        wDataAdapter.Fill(wNewDataSet)

        Return wNewDataSet

    End Function

End Class
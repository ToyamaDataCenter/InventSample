Public Class frmInventoryViewer

    ''' <summary>
    ''' 追加済データの登録／未登録
    ''' </summary>
    Private fpIsRegisted As Boolean = True

    ''' <summary>
    ''' 画面へ表示する内容を保持するデータテーブル
    ''' </summary>
    Private fpInventoryDataTable As DataTable


    Private Sub frmInventoryInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

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
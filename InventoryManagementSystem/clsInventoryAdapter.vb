Imports Microsoft.Data.SqlClient

Public Class clsInventoryManager

    Private connectionString As String = ""

    Private Function fetchInventoryDataTable() As DataSet
        Dim wNewDataSet As DataSet

        Dim wNewDataTable As DataTable


        Using wConnection = New SqlConnection(connectionString)
            wConnection.Open()

            Using wDataAdapter As New SqlDataAdapter


                wDataAdapter.SelectCommand = New SqlCommand("", wConnection)

                wDataAdapter.Fill(wNewDataTable)

            End Using


            wConnection.Close()
        End Using

        For Each _dr As DataRow In wNewDataTable.Rows
            Dim idx As Integer = _dr.Field(Of Integer)("hoge")
        Next

        Return wNewDataSet

    End Function

End Class

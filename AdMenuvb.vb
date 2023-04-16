Imports IBM.Data.DB2
Public Class AdMenuvb


    Private dbCon As Common.DbConnection

    Private Sub AdMenuvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=techshop;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub bttnItems_Click(sender As Object, e As EventArgs) Handles bttnItems.Click
        Inventory.Show()
        Me.Hide()
    End Sub

    Private Sub bttnSales_Click(sender As Object, e As EventArgs) Handles bttnSales.Click
        Me.Hide()
        Sales.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        User.Show()

    End Sub
End Class
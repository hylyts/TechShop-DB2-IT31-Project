Imports IBM.Data.DB2
Public Class Sales

    Private dbCon As Common.DbConnection

    Private Sub bttnback_Click(sender As Object, e As EventArgs) Handles bttnback.Click
        Me.Close()
        AdMenuvb.Show()

    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            dbCon = New DB2Connection("server=localhost;database=techshop;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()


        ItemView.ColumnCount = 6
        With ItemView
            .Columns(0).Name = " Sales ID "
            .Columns(1).Name = " Sales Date "
            .Columns(2).Name = " Checkout ID "
            .Columns(3).Name = " Item ID "
            .Columns(4).Name = " Name "
            .Columns(5).Name = " Price "
        End With



        Strread = " select * from table(DisplaySalesCombo()) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            ItemView.Rows.Add(row)
        End While
    End Sub
End Class
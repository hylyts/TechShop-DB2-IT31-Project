Imports IBM.Data.DB2

Public Class Cart
    Public Property IDcon As String
    Public Property CartItem As String
    Public Property Itemcount As Integer
    Private dbCon As Common.DbConnection

    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Dim Total As Decimal
        CartView.ColumnCount = 5
        With CartView
            .Columns(0).Name = " Cart ID"
            .Columns(1).Name = " Product ID "
            .Columns(2).Name = " Product Name "
            .Columns(3).Name = " Product Type "
            .Columns(4).Name = " Price "
        End With


        Strread = " select * from table(DisplayCart('" & IDcon & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            Total = Total + ReadData.GetDecimal(4)
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetDecimal(4)}
            CartView.Rows.Add(row)
        End While

        If Total = 0 Then
            Me.lblprice.Text = " "
        Else
            Me.lblprice.Text = Total
        End If
    End Sub


    Private Sub bttnback_Click(sender As Object, e As EventArgs) Handles bttnback.Click
        Me.Close()
        Hub.Hide()
        MenuAll.IDpasser = IDcon
        MenuAll.Show()


    End Sub
    Private Sub CartView_SelectionChanged(sender As Object, e As EventArgs) Handles CartView.SelectionChanged
        Try
            Dim data As String = CartView.SelectedRows(0).Cells(0).Value.ToString
            CartItem = data
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bttndelete_Click(sender As Object, e As EventArgs) Handles bttndelete.Click

        Dim cartdel As String
        Dim CmdDel As DB2Command

        MsgBox(CartItem)

        cartdel = "call DelCart('" & CartItem & "')"
        CmdDel = New DB2Command(cartdel, dbCon)
        CmdDel.ExecuteReader()
        MsgBox("Item has been removed from your cart")

        CartView.Rows.Clear()

        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()
        Dim Total As Decimal

        Strread = " select * from table(DisplayCart('" & IDcon & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            Total = Total + ReadData.GetDecimal(4)
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetDecimal(4)}
            CartView.Rows.Add(row)
        End While

        Me.lblprice.Text = Total

        Dim strrow As String
        Dim rowread As DB2Command
        Dim reader As DB2DataReader

        strrow = " select count(*) from cart where custid = '" & IDcon & "'"
        rowread = New DB2Command(strrow, dbCon)
        reader = rowread.ExecuteReader
        reader.Read()

        Itemcount = reader.GetInt32(0)

        If Itemcount = 0 Then
            MenuAll.lblcartcount.Text = ""
        Else
            MenuAll.lblcartcount.Text = Itemcount
        End If
    End Sub

    Private Sub bttncheck_Click(sender As Object, e As EventArgs) Handles bttncheck.Click

        Transact.IDcon = IDcon
        Transact.Show()

        Me.Close()
        MenuAll.Close()
        Hub.Hide()
    End Sub
End Class
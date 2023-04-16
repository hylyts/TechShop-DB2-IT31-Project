Imports IBM.Data.DB2
Public Class Transact
    Public Property IDcon As String
    Public Property Count As Integer
    Public Property ItemArr As String()
    Private dbCon As Common.DbConnection

    Private Sub Transact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim counter As Integer

        counter = 0
        CartView.ColumnCount = 2


        With CartView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Price "
        End With

        'Cart item counter

        Dim strrow As String
        Dim rowread As DB2Command
        Dim reader As DB2DataReader

        strrow = " select count(*) from cart where custid = '" & IDcon & "'"
        rowread = New DB2Command(strrow, dbCon)
        reader = rowread.ExecuteReader
        reader.Read()

        Count = reader.GetInt32(0)
        Dim Items(Count - 1) As String


        Strread = " select * from table(DisplayCart('" & IDcon & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            Items(counter) = ReadData.GetString(1)
            Total = Total + ReadData.GetDecimal(4)
            row = New String() {ReadData.GetString(2), ReadData.GetDecimal(4)}
            CartView.Rows.Add(row)
            counter = counter + 1
        End While

        If Total = 0 Then
            Me.lbltotal.Text = " "
        Else
            Me.lbltotal.Text = Total
        End If


        ItemArr = Items




    End Sub

    Private Sub bttnMenu_Click(sender As Object, e As EventArgs) Handles bttnMenu.Click

        MenuAll.ViewType = 0
        MenuAll.IDpasser = IDcon
        MenuAll.Show()
        Me.Close()

    End Sub

    Private Sub bttnconfirm_Click(sender As Object, e As EventArgs) Handles bttnconfirm.Click

        Dim strcheckid As String
        Dim idcount As Integer
        Dim cartread As String
        Dim readercart As DB2Command
        Dim exec As DB2DataReader
        Dim salecount As Integer
        Dim checkadd As String
        Dim saleadd As String
        Dim checkdate As String
        Dim Adder As DB2Command


        idcount = 1
        salecount = 100
        strcheckid = CStr(idcount)


        For i As Integer = 0 To (Count - 1)
            Do
                cartread = "select checkoutid from checkout where checkoutid ='" & idcount & "'"
                readercart = New DB2Command(cartread, dbCon)
                exec = readercart.ExecuteReader
                exec.Read()

                If (exec.HasRows) Then

                    idcount = idcount + 1
                    strcheckid = CStr(idcount)

                Else
                    strcheckid = CStr(idcount)
                End If
            Loop While exec.HasRows

            checkadd = "call AddCheck('" & strcheckid & "','" & ItemArr(i) & "','" & IDcon & "')"
            Adder = New DB2Command(checkadd, dbCon)
            Adder.ExecuteReader()

            Do
                cartread = "select salesid from sales where salesid ='" & salecount & "'"
                readercart = New DB2Command(cartread, dbCon)
                exec = readercart.ExecuteReader
                exec.Read()

                If (exec.HasRows) Then
                    salecount = salecount + 1
                End If
            Loop While exec.HasRows

            checkdate = String.Format("{0:dd-MM-yyyy}", DateTime.Now)
            saleadd = "call AddSales('" & salecount & "','" & checkdate & "', '" & strcheckid & "')"
            Adder = New DB2Command(saleadd, dbCon)
            Adder.ExecuteReader()

            Dim getqty As String
            Dim setqty As String
            Dim qtytemp As String
            Dim qtytemp2 As Integer
            Dim readqty As DB2Command




            getqty = " select itemqty from item where itemid = '" & (ItemArr(i)) & "' "
            readqty = New DB2Command(getqty, dbCon)
            exec = readqty.ExecuteReader
            exec.Read()
            qtytemp = exec.GetString(0)

            qtytemp2 = CInt(Int(qtytemp))

            qtytemp2 = qtytemp2 - 1
            setqty = " call UpdateQTY('" & qtytemp2 & "','" & (ItemArr(i)) & "')"
            readqty = New DB2Command(setqty, dbCon)
            exec = readqty.ExecuteReader
            exec.Read()


        Next

        Dim delall As String
        Dim Cmddel As DB2Command

        delall = "call DellCartAll('" & IDcon & "')"
        Cmddel = New DB2Command(delall, dbCon)
        Cmddel.ExecuteReader()
        MsgBox("Items has been successfully purchased")

        Me.Close()
        MenuAll.Show()
        MenuAll.IDpasser = IDcon
        MenuAll.lblcartcount.Text = ""

    End Sub

    Private Sub bttnedit_Click(sender As Object, e As EventArgs) Handles bttnedit.Click
        Cart.IDcon = IDcon
        Cart.Show()
        Me.Close()

    End Sub
End Class
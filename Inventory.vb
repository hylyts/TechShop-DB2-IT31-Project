Imports IBM.Data.DB2
Public Class Inventory

    Private dbCon As Common.DbConnection
    Public Property ITEM As String
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Dim mobo As String
        Dim temp As String
   

        mobo = "MOTHERBOARD"
        temp = "MOBO"

        Me.lblitem.Text = ""

        ItemView.ColumnCount = 6
        With ItemView
            .Columns(0).Name = " Item ID "
            .Columns(1).Name = " Item Type "
            .Columns(2).Name = " Item Name "
            .Columns(3).Name = " Serial Number "
            .Columns(4).Name = " Price "
            .Columns(5).Name = " QTY"
        End With



        Strread = " select * from table(DisplayFullAll()) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            If ReadData.GetString(1) = temp Then

                row = New String() {ReadData.GetString(0), mobo, ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            Else
                row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            End If
            ItemView.Rows.Add(row)
        End While

    End Sub

    Private Sub bttnCPU_Click(sender As Object, e As EventArgs) Handles bttnCPU.Click

        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()

        ItemView.Rows.Clear()



        Dim Type As String
        Type = "CPU"
        Strread = " select * from table(DisplayFullSpec('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            ItemView.Rows.Add(row)
        End While


    End Sub

    Private Sub bttnMOBO_Click(sender As Object, e As EventArgs) Handles bttnMOBO.Click

        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()
        Dim mobo As String
        Dim temp As String
        mobo = "MOTHERBOARD"
        temp = "MOBO"

        ItemView.Rows.Clear()

        Dim Type As String
        Type = "MOBO"
        Strread = " select * from table(DisplayFullSpec('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            If ReadData.GetString(1) = temp Then

                row = New String() {ReadData.GetString(0), mobo, ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            Else
                row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            End If
            ItemView.Rows.Add(row)
        End While


    End Sub

    Private Sub bttnGPU_Click(sender As Object, e As EventArgs) Handles bttnGPU.Click
        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()

        ItemView.Rows.Clear()

        Dim Type As String
        Type = "GPU"
        Strread = " select * from table(DisplayFullSpec('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            ItemView.Rows.Add(row)
        End While


    End Sub

    Private Sub bttnRAM_Click(sender As Object, e As EventArgs) Handles bttnRAM.Click

        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()

        ItemView.Rows.Clear()


        Dim Type As String
        Type = "RAM"
        Strread = " select * from table(DisplayFullSpec('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            ItemView.Rows.Add(row)
        End While

    End Sub

    Private Sub bttnSPACE_Click(sender As Object, e As EventArgs) Handles bttnSPACE.Click

        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()

        ItemView.Rows.Clear()


        Dim Type As String
        Dim Type2 As String

        Type = "SSD"
        Type2 = "HDD"
        Strread = " select * from table(DisplayFullMult('" & Type & "','" & Type2 & "','')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            ItemView.Rows.Add(row)
        End While
    End Sub

    Private Sub bttnPOW_Click(sender As Object, e As EventArgs) Handles bttnPOW.Click
        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()
        Dim power As String
        Dim temp As String
        power = "POWER SUPPLY"
        temp = "PSU"

        ItemView.Rows.Clear()


        Dim Type As String
        Type = "PSU"
        Strread = " select * from table(DisplayFullSpec('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            If ReadData.GetString(1) = temp Then

                row = New String() {ReadData.GetString(0), power, ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            Else
                row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            End If
            ItemView.Rows.Add(row)
        End While
    End Sub

    Private Sub bttnCASE_Click(sender As Object, e As EventArgs) Handles bttnCASE.Click
        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()

        ItemView.Rows.Clear()


        Dim Type As String
        Type = "CASE"
        Strread = " select * from table(DisplayFullSpec('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader
        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            ItemView.Rows.Add(row)
        End While
    End Sub

    Private Sub bttnEX_Click(sender As Object, e As EventArgs) Handles bttnEX.Click
        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()

        ItemView.Rows.Clear()

        Dim Type As String
        Dim Type2 As String

        Type = "FAN"
        Type2 = "EX"
        Strread = " select * from table(DisplayFullMult('" & Type & "','" & Type2 & "','')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read

            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            ItemView.Rows.Add(row)
        End While
    End Sub

    Private Sub ItemView_SelectionChanged(sender As Object, e As EventArgs) Handles ItemView.SelectionChanged
        Try
            Dim data As String = ItemView.SelectedRows(0).Cells(0).Value.ToString
            Dim name As String = ItemView.SelectedRows(0).Cells(2).Value.ToString
            Me.lblitem.Text = name
            ITEM = data

        Catch ex As Exception
            Me.lblitem.Text = ""
        End Try

    End Sub


    Private Sub bttnALL_Click(sender As Object, e As EventArgs) Handles bttnALL.Click

        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()
        Dim mobo As String
        Dim temp As String


        mobo = "MOTHERBOARD"
        temp = "MOBO"

        ItemView.Rows.Clear()

        Strread = " select * from table(DisplayFullAll()) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            If ReadData.GetString(1) = temp Then

                row = New String() {ReadData.GetString(0), mobo, ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            Else
                row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
            End If
            ItemView.Rows.Add(row)
        End While
    End Sub

    Private Sub bttnDel_Click(sender As Object, e As EventArgs) Handles bttnDel.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure to Delete this Item?", "", MessageBoxButtons.YesNo)
     If result = DialogResult.Yes Then
            Dim strdel As String
            Dim CmdINs As DB2Command

            strdel = "call DeleteItem('" & ITEM & "')"
            CmdINs = New DB2Command(strdel, dbCon)
            CmdINs.ExecuteReader()
            MsgBox("Item has Removed from Inventory")


        End If

        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()
        Dim mobo As String
        Dim temp As String


        mobo = "MOTHERBOARD"
        temp = "MOBO"

        ItemView.Rows.Clear()

                Strread = " select * from table(DisplayFullAll()) as udf"
                CmdRead = New DB2Command(Strread, dbCon)
                ReadData = CmdRead.ExecuteReader

                While ReadData.Read
                    If ReadData.GetString(1) = temp Then

                        row = New String() {ReadData.GetString(0), mobo, ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
                    Else
                        row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
                    End If
                    ItemView.Rows.Add(row)
                End While



    End Sub

    Private Sub bttnUpdate_Click(sender As Object, e As EventArgs) Handles bttnUpdate.Click

        Dim newPrice As String
        Dim price As Decimal

        newPrice = InputBox("Enter new price for product", "", 0.0)

        If newPrice = "" Then

        Else
            price = CDec(Val(newPrice))

            Dim strprice As String
            Dim CmdINs As DB2Command



            strprice = "call UpdatePrice('" & ITEM & "','" & price & "')"
            CmdINs = New DB2Command(strprice, dbCon)
            CmdINs.ExecuteReader()
            MsgBox("Item Price is Updated")

            Dim Strread As String
            Dim CmdRead As DB2Command
            Dim ReadData As DB2DataReader
            Dim row As String()
            Dim mobo As String
            Dim temp As String


            mobo = "MOTHERBOARD"
            temp = "MOBO"

            ItemView.Rows.Clear()

            Strread = " select * from table(DisplayFullAll()) as udf"
            CmdRead = New DB2Command(Strread, dbCon)
            ReadData = CmdRead.ExecuteReader

            While ReadData.Read
                If ReadData.GetString(1) = temp Then

                    row = New String() {ReadData.GetString(0), mobo, ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
                Else
                    row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
                End If
                ItemView.Rows.Add(row)
            End While

        End If

    End Sub

    Private Sub bttnQTY_Click(sender As Object, e As EventArgs) Handles bttnQTY.Click

        Dim newqty As String
        Dim qty As Integer

        newqty = InputBox("Enter new quantity for product", "", 0.0)

        If newqty = "" Then

        Else
            qty = CInt(Int(newqty))
            Dim strqty As String
            Dim CmdINs As DB2Command

            strqty = "call UpdateQty('" & qty & "','" & ITEM & "')"
            CmdINs = New DB2Command(strqty, dbCon)
            CmdINs.ExecuteReader()
            MsgBox("Item Quantity is Updated")

            Dim Strread As String
            Dim CmdRead As DB2Command
            Dim ReadData As DB2DataReader
            Dim row As String()
            Dim mobo As String
            Dim temp As String


            mobo = "MOTHERBOARD"
            temp = "MOBO"

            ItemView.Rows.Clear()

            Strread = " select * from table(DisplayFullAll()) as udf"
            CmdRead = New DB2Command(Strread, dbCon)
            ReadData = CmdRead.ExecuteReader

            While ReadData.Read
                If ReadData.GetString(1) = temp Then

                    row = New String() {ReadData.GetString(0), mobo, ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
                Else
                    row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3), ReadData.GetString(4), ReadData.GetString(5)}
                End If
                ItemView.Rows.Add(row)
            End While

        End If
    End Sub



    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Me.Close()
        ItemAdd.Show()

    End Sub

  
    Private Sub bttnback_Click_1(sender As Object, e As EventArgs) Handles bttnback.Click
        Me.Close()
        AdMenuvb.Show()
    End Sub
End Class
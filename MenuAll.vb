Imports IBM.Data.DB2
Public Class MenuAll

    Public Property IDpasser As String
    Public Property ITEM As String
    Public Property ViewType As Integer
    Public Property Cartcount As Integer
    Public Property Itemcount As Integer
    Public Property cartrows As Integer
    Private dbCon As Common.DbConnection

    Private Sub MenuAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            dbCon = New DB2Connection("server=localhost;database=techshop;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'Cart item counter

        Dim count As Integer
        Dim strrow As String
        Dim rowread As DB2Command
        Dim reader As DB2DataReader

        strrow = " select count(*) from cart where custid = '" & IDpasser & "'"
        rowread = New DB2Command(strrow, dbCon)
        reader = rowread.ExecuteReader
        reader.Read()

        count = reader.GetInt32(0)

        If count = 0 Then
            Me.lblcartcount.Text = ""
        Else
            Me.lblcartcount.Text = count
        End If

        '-cartid
        Dim strcart As String
        Dim cartread As String
        Dim readercart As DB2Command
        Dim exec As DB2DataReader


        strcart = CStr(Cartcount + 1)


        Do
            cartread = "select cartitemcount from cart where cartitemcount ='" & strcart & "'"
            readercart = New DB2Command(cartread, dbCon)
            exec = readercart.ExecuteReader
            exec.Read()

            If (exec.HasRows) Then

                Cartcount = Cartcount + 1
                strcart = CStr(Cartcount + 1)

            Else
                strcart = CStr(Cartcount + 1)
            End If
        Loop While exec.HasRows

        '----------ITEM DISPLAY

        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()
        Dim mobo As String
        Dim temp As String
        Dim type As String
        Dim type2 As String
        Dim type3 As String

        mobo = "MOTHERBOARD"
        temp = "MOBO"

        Me.lblitem.Text = ""

        ItemView.ColumnCount = 4
        With ItemView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Product Type "
            .Columns(2).Name = " Price "
            .Columns(3).Name = " Current Stock "

        End With

        If ViewType = 0 Then

            Strread = " select * from table(DisplayItem()) as udf"
            CmdRead = New DB2Command(Strread, dbCon)
            ReadData = CmdRead.ExecuteReader

            While ReadData.Read
                If ReadData.GetString(1) = temp Then

                    row = New String() {ReadData.GetString(0), mobo, ReadData.GetString(2), ReadData.GetString(3)}
                Else
                    row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
                End If
                ItemView.Rows.Add(row)
            End While


        ElseIf ViewType = 1 Then
            type = "CPU"

            Strread = " select * from table(DisplaySPEC('" & type & "')) as udf"
            CmdRead = New DB2Command(Strread, dbCon)
            ReadData = CmdRead.ExecuteReader

            While ReadData.Read
                row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
                ItemView.Rows.Add(row)
            End While


        ElseIf ViewType = 2 Then
            type = "GPU"

            Strread = " select * from table(DisplaySPEC('" & type & "')) as udf"
            CmdRead = New DB2Command(Strread, dbCon)
            ReadData = CmdRead.ExecuteReader

            While ReadData.Read
                    row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
                    ItemView.Rows.Add(row)
            End While


        ElseIf ViewType = 3 Then
            type = "MOBO"

            Strread = " select * from table(DisplaySPEC('" & type & "')) as udf"
            CmdRead = New DB2Command(Strread, dbCon)
            ReadData = CmdRead.ExecuteReader

            While ReadData.Read
                If ReadData.GetString(1) = temp Then

                    row = New String() {ReadData.GetString(0), mobo, ReadData.GetString(2), ReadData.GetString(3)}
                Else
                    row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
                End If
                ItemView.Rows.Add(row)
            End While

        ElseIf ViewType = 4 Then
            type = "RAM"
            type2 = "SSD"
            type3 = "HDD"

            Strread = " select * from table(DisplayMULT('" & type & "','" & type2 & "','" & type3 & "')) as udf"
            CmdRead = New DB2Command(Strread, dbCon)
            ReadData = CmdRead.ExecuteReader

            While ReadData.Read
              
                row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
                ItemView.Rows.Add(row)
            End While
        End If

    End Sub

    Private Sub bttnback_Click(sender As Object, e As EventArgs) Handles bttnback.Click
        Me.Close()
        Hub.Show()
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


        ItemView.ColumnCount = 4
        With ItemView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Product Type "
            .Columns(2).Name = " Price "
            .Columns(3).Name = " Current Stock "

        End With
        Strread = " select * from table(DisplayItem()) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            If ReadData.GetString(1) = temp Then

                row = New String() {ReadData.GetString(0), mobo, ReadData.GetString(2), ReadData.GetString(3)}
            Else
                row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
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

        ItemView.ColumnCount = 4
        With ItemView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Product Type "
            .Columns(2).Name = " Price "
            .Columns(3).Name = " Current Stock "

        End With

        Dim Type As String
        Type = "CPU"
        Strread = " select * from table(DisplaySPEC('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
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

        ItemView.ColumnCount = 4
        With ItemView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Product Type "
            .Columns(2).Name = " Price "
            .Columns(3).Name = " Current Stock "

        End With
        Dim Type As String
        Type = "MOBO"
        Strread = " select * from table(DisplaySPEC('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            If ReadData.GetString(1) = temp Then

                row = New String() {ReadData.GetString(0), mobo, ReadData.GetString(2), ReadData.GetString(3)}
            Else
                row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
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

        ItemView.ColumnCount = 4
        With ItemView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Product Type "
            .Columns(2).Name = " Price "
            .Columns(3).Name = " Current Stock "

        End With
        Dim Type As String
        Type = "GPU"
        Strread = " select * from table(DisplaySPEC('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
            ItemView.Rows.Add(row)
        End While

    End Sub

    Private Sub bttnRAM_Click(sender As Object, e As EventArgs) Handles bttnRAM.Click

        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()
      
    

        ItemView.Rows.Clear()

        ItemView.ColumnCount = 4
        With ItemView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Product Type "
            .Columns(2).Name = " Price "
            .Columns(3).Name = " Current Stock "

        End With
        Dim Type As String
        Type = "RAM"
        Strread = " select * from table(DisplaySPEC('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
            ItemView.Rows.Add(row)
        End While
    End Sub

    Private Sub bttnSPACE_Click(sender As Object, e As EventArgs) Handles bttnSPACE.Click

        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String() 

        ItemView.Rows.Clear()

        ItemView.ColumnCount = 4
        With ItemView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Product Type "
            .Columns(2).Name = " Price "
            .Columns(3).Name = " Current Stock "

        End With
        Dim Type As String
        Dim Type2 As String

        Type = "SSD"
        Type2 = "HDD"
        Strread = " select * from table(DisplayMULT('" & Type & "','" & Type2 & "','')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
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

        ItemView.ColumnCount = 4
        With ItemView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Product Type "
            .Columns(2).Name = " Price "
            .Columns(3).Name = " Current Stock "

        End With
        Dim Type As String
        Type = "PSU"
        Strread = " select * from table(DisplaySPEC('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            If ReadData.GetString(1) = temp Then

                row = New String() {ReadData.GetString(0), power, ReadData.GetString(2), ReadData.GetString(3)}
            Else
                row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
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

        ItemView.ColumnCount = 4
        With ItemView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Product Type "
            .Columns(2).Name = " Price "
            .Columns(3).Name = " Current Stock "

        End With
        Dim Type As String
        Type = "CASE"
        Strread = " select * from table(DisplaySPEC('" & Type & "')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read
            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
            ItemView.Rows.Add(row)
        End While
    End Sub

    Private Sub bttnEX_Click(sender As Object, e As EventArgs) Handles bttnEX.Click
        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()

        ItemView.Rows.Clear()

        ItemView.ColumnCount = 4
        With ItemView
            .Columns(0).Name = " Product Name "
            .Columns(1).Name = " Product Type "
            .Columns(2).Name = " Price "
            .Columns(3).Name = " Current Stock "

        End With
        Dim Type As String
        Dim Type2 As String

        Type = "FAN"
        Type2 = "EX"
        Strread = " select * from table(DisplayMULT('" & Type & "','" & Type2 & "','')) as udf"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader

        While ReadData.Read

            row = New String() {ReadData.GetString(0), ReadData.GetString(1), ReadData.GetString(2), ReadData.GetString(3)}
            ItemView.Rows.Add(row)
        End While
    End Sub

    Private Sub ItemView_SelectionChanged(sender As Object, e As EventArgs) Handles ItemView.SelectionChanged
        Try
            Dim data As String = ItemView.SelectedRows(0).Cells(0).Value.ToString
            Me.lblitem.Text = data
            ITEM = data

        Catch ex As Exception
            Me.lblitem.Text = ""
        End Try
        
    End Sub


    '--------ADD ITEM TO CART

    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Dim itemread As String
        Dim cartadd As String
        Dim cartread As String
        Dim CmdRead As DB2Command
        Dim CmdIns As DB2Command
        Dim ReadData As DB2DataReader
        Dim IDitem As String
        Dim carttemp As String

        carttemp = CStr(Cartcount + 1)

        Do
            cartread = "select cartitemcount from cart where cartitemcount ='" & carttemp & "'"
            CmdRead = New DB2Command(cartread, dbCon)
            ReadData = CmdRead.ExecuteReader
            ReadData.Read()

            If (ReadData.HasRows) Then

                Cartcount = Cartcount + 1
                carttemp = CStr(Cartcount + 1)

            Else
                carttemp = CStr(Cartcount + 1)
            End If
        Loop While ReadData.HasRows

        itemread = "select * from table(GETID('" & ITEM & "')) as udf "
        CmdRead = New DB2Command(itemread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

            IDitem = ReadData.GetString(0)

        cartadd = "call AddCart('" & carttemp & "','" & IDitem & "','" & IDpasser & "')"
        CmdIns = New DB2Command(cartadd, dbCon)
        CmdIns.ExecuteReader()
        Cartcount = Cartcount + 1
        MsgBox("Item has been added to cart")



        Dim strrow As String
        Dim rowread As DB2Command
        Dim reader As DB2DataReader

        strrow = " select count(*) from cart where custid = '" & IDpasser & "'"
        rowread = New DB2Command(strrow, dbCon)
        reader = rowread.ExecuteReader
        reader.Read()

        Itemcount = reader.GetInt32(0)

        If Itemcount = 0 Then
            Me.lblcartcount.Text = ""
        Else
            Me.lblcartcount.Text = Itemcount
        End If

        Cart.Itemcount = Itemcount

    End Sub

    '----CART VIEW
    Private Sub bttncart_Click(sender As Object, e As EventArgs) Handles bttncart.Click
        Cart.IDcon = IDpasser
        Cart.Show()
    End Sub


    Private Sub bttncheck_Click(sender As Object, e As EventArgs) Handles bttncheck.Click

        Transact.IDcon = IDpasser
        Transact.Show()

        Me.Hide()

    End Sub

   
End Class
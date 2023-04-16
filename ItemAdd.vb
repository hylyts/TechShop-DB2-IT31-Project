Imports IBM.Data.DB2
Public Class ItemAdd

    Private dbCon As Common.DbConnection

    Private Sub ItemAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            dbCon = New DB2Connection("server=localhost;database=techshop;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.lblerror.Text = ""
    End Sub


    Private Sub bttnback_Click(sender As Object, e As EventArgs) Handles bttnback.Click
        Me.Close()
        Inventory.Show()
    End Sub

    Private Sub bttnSubmit_Click(sender As Object, e As EventArgs) Handles bttnSubmit.Click
        Try


            Dim ID As String
            Dim type As String
            Dim name As String
            Dim serial As Integer
            Dim Price As Decimal
            Dim qty As Integer


            ID = Me.txtid.Text
            type = Me.txttype.Text
            name = Me.txtname.Text
            serial = Me.txtsn.Text
            Price = Me.txtprice.Text
            qty = Me.txtqty.Text

            Dim itemadd As String
            Dim CmdInsert As DB2Command


            itemadd = " call AddNew('" & ID & "','" & type & "','" & name & "','" & serial & "','" & Price & "','" & qty & "')"
            CmdInsert = New DB2Command(itemadd, dbCon)
            CmdInsert.ExecuteReader()
            MsgBox("A New Item has been Added")
            Me.lblerror.Text = ""
            Me.Close()

        Catch ex As Exception
            Me.lblerror.Text = ""
            Me.lblerror.Text = "Fields are lacking or InventoryID is already Taken"
            Call ClearEntry()
        End Try
    End Sub

    Private Sub ClearEntry()
        Me.txtID.Clear()
        Me.txtname.Clear()
        Me.txttype.Clear()
        Me.txtsn.Clear()
        Me.txtprice.Clear()
        Me.txtqty.Clear()

        Me.txtID.Focus()
    End Sub
End Class
Imports IBM.Data.DB2
Public Class Hub

    Public Property IDpass As String


    Private dbCon As Common.DbConnection

    Private Sub Hub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=techshop;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.lblid.Text = IDpass
    End Sub


    Private Sub lnkExit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkExit.LinkClicked
        Me.Close()
        User.Show()
    End Sub

    Private Sub bttnAll_Click(sender As Object, e As EventArgs) Handles bttnAll.Click
        Dim ID As String
        ID = IDpass

        MenuAll.IDpasser = ID
        MenuAll.ViewType = 0
        MenuAll.Show()
        Me.Hide()

    End Sub

    Private Sub bttnCPU_Click(sender As Object, e As EventArgs) Handles bttnCPU.Click
        Dim ID As String
        ID = IDpass

        MenuAll.IDpasser = ID
        MenuAll.ViewType = 1
        MenuAll.Show()
        Me.Hide()
    End Sub

    Private Sub bttnGPU_Click(sender As Object, e As EventArgs) Handles bttnGPU.Click
        Dim ID As String
        ID = IDpass

        MenuAll.IDpasser = ID
        MenuAll.ViewType = 2
        MenuAll.Show()
        Me.Hide()
    End Sub

    Private Sub bttnMOBO_Click(sender As Object, e As EventArgs) Handles bttnMOBO.Click
        Dim ID As String
        ID = IDpass

        MenuAll.IDpasser = ID
        MenuAll.ViewType = 3
        MenuAll.Show()
        Me.Hide()
    End Sub

    Private Sub bttnSPACE_Click(sender As Object, e As EventArgs) Handles bttnSPACE.Click
        Dim ID As String
        ID = IDpass

        MenuAll.IDpasser = ID
        MenuAll.ViewType = 4
        MenuAll.Show()
        Me.Hide()
    End Sub


    Private Sub bttncart_Click(sender As Object, e As EventArgs) Handles bttncart.Click
        Cart.IDcon = IDpass
        Cart.Show()
        Me.Hide()
    End Sub

  
End Class
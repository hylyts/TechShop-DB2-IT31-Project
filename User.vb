Imports IBM.Data.DB2

Public Class User

    Private dbCon As Common.DbConnection
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbCon = New DB2Connection("server=localhost;database=techshop;" + "uid=db2admin;password=password;")
        dbCon.Open()
        If dbCon.State = ConnectionState.Open Then

        Else
            MsgBox("No connection")
        End If

        Me.lblerror.Text = ""
    End Sub


    Private Sub bttnexit_Click(sender As Object, e As EventArgs) Handles bttnexit.Click
        dbCon.Close()

        Me.Close()
    End Sub

    Private Sub bttnlogin_Click(sender As Object, e As EventArgs) Handles bttnlogin.Click

        Try
            Dim Uname As String
            Dim Pass As String
            Dim Strread As String
            Dim Cmdread As DB2Command
            Dim Readdata As DB2DataReader

            Dim tableuname As String
            Dim tablepass As String
            Dim tablecustid As String
            Dim tableempid As String


            Dim dummy As String

            dummy = "-"



            Uname = Me.txtuser.Text
            Pass = Me.txtpass.Text()

            If Uname = vbNullString Then
                Me.lblerror.Text = "Enter the fields first before proceeding."
                Me.txtuser.Clear()
                Me.txtpass.Clear()
                Me.txtuser.Focus()
            Else
                Strread = "select username,password,custid,empid from users where username = '" & Uname & "'"


                Cmdread = New DB2Command(Strread, dbCon)
                Readdata = Cmdread.ExecuteReader

                Readdata.Read()

                tableuname = Readdata.GetString(0)
                tablepass = Readdata.GetString(1)
                Try
                    tablecustid = Readdata.GetString(2)

                Catch ex As Exception
                    tablecustid = "-"

                End Try

                Try
                    tableempid = Readdata.GetString(3)
                Catch ex As Exception

                    tableempid = "-"
                End Try

                If Pass <> tablepass Then
                    Me.lblerror.Text = "Password does not match the username."
                    Me.txtpass.Clear()

                    Me.txtpass.Focus()

                ElseIf Pass = tablepass Then

                    Me.txtuser.Clear()
                    Me.txtpass.Clear()


                    If tableempid = dummy Then

                        Hub.IDpass = tablecustid
                        Hub.Show()
                        Me.Hide()
                        Me.lblerror.Text = ""
                    ElseIf tablecustid = dummy Then
                        AdMenuvb.Show()
                        Me.Hide()
                        Me.lblerror.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            Me.lblerror.Text = "Username does not exist in the database."
            Me.txtuser.Clear()
            Me.txtpass.Clear()
            Me.txtuser.Focus()
        End Try




    End Sub

    Private Sub CreateTxt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreateTxt.LinkClicked
        CreateAcc.Show()
        Me.Hide()
    End Sub
End Class

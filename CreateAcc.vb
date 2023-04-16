Imports IBM.Data.DB2
Public Class CreateAcc
    Private dbCon As Common.DbConnection
    Private Sub CreateAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=techshop;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.lblerror.Text = ""
        Me.lblsuccess.Text = ""
    End Sub

    Private Sub bttncreate_Click(sender As Object, e As EventArgs) Handles bttncreate.Click
        Try


        Dim custID As String
        Dim Uname As String
        Dim Pass As String
        Dim Cpass As String
        Dim InsertStr As String
        Dim Strread As String
        Dim Compread As String
        Dim CmdInsert As DB2Command
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim CompData As DB2DataReader
        Dim bankcomp As String

        custID = Me.txtID.Text
        Uname = Me.txtuser.Text
        Pass = Me.txtpass.Text
        Cpass = Me.txtcpass.Text

        If custID = vbNullString Or Uname = vbNullString Or Pass = vbNullString Then
            Me.lblerror.Text = ""
            Me.lblsuccess.Text = ""
            Me.lblerror.Text = "Please enter all fields."
        Else

            If Pass <> Cpass Then
                Me.lblerror.Text = ""
                Me.lblsuccess.Text = ""
                Me.lblerror.Text = "Passwords do not match."
                Call ClearEntry()
            Else
                Strread = "select custid from customer where custid = '" & custID & "'"
                CmdRead = New DB2Command(Strread, dbCon)
                ReadData = CmdRead.ExecuteReader
                ReadData.Read()
                bankcomp = ReadData.GetString(0)

                Compread = "select username from users where username = '" & Uname & "'"
                CmdRead = New DB2Command(Compread, dbCon)
                CompData = CmdRead.ExecuteReader
                CompData.Read()

                If CompData.HasRows Then
                    Me.lblerror.Text = ""
                    Me.lblsuccess.Text = ""
                    Me.lblerror.Text = "Username is already Taken."
                    Me.txtID.Clear()
                    Me.txtuser.Clear()
                    Me.txtpass.Clear()
                    Me.txtcpass.Clear()

                    Me.txtID.Focus()

                Else

                    Compread = "select custid from users where custid = '" & bankcomp & "'"
                    CmdRead = New DB2Command(Compread, dbCon)
                    CompData = CmdRead.ExecuteReader
                    CompData.Read()

                    If CompData.HasRows Then
                        Me.lblerror.Text = "Customer Already Has an Account."
                        Me.txtID.Clear()
                        Me.txtuser.Clear()
                        Me.txtpass.Clear()
                        Me.txtcpass.Clear()

                        Me.txtID.Focus()


                    Else

                        InsertStr = "insert into userS values('" & Uname & "','" & Pass & "','" & custID & "', NULL )"
                        CmdInsert = New DB2Command(InsertStr, dbCon)
                        CmdInsert.ExecuteNonQuery()

                        Me.lblerror.Text = ""
                        Me.lblsuccess.Text = ""
                        Me.lblsuccess.Text = "Online Account has Succesfully Created"

                        Call ClearEntry()

                    End If
                End If

            End If
        End If

              Catch ex As Exception
            Me.lblerror.Text = ""
            Me.lblsuccess.Text = ""
            Me.lblerror.Text = "Customer is not found in the Database."
            Call ClearEntry()
        End Try
    End Sub

    Private Sub ClearEntry()
        Me.txtID.Clear()
        Me.TxtUser.Clear()
        Me.txtpass.Clear()
        Me.txtcpass.Clear()

        Me.txtID.Focus()
    End Sub

    Private Sub lnkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBack.LinkClicked
        Me.Close()
        User.Show()
    End Sub
End Class
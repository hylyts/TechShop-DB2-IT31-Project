<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAcc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtcpass = New System.Windows.Forms.TextBox()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.bttncreate = New System.Windows.Forms.Button()
        Me.lnkBack = New System.Windows.Forms.LinkLabel()
        Me.lblsuccess = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(39, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CustID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(39, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username "
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.MintCream
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Font = New System.Drawing.Font("Bahnschrift SemiLight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.Location = New System.Drawing.Point(73, 122)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(245, 29)
        Me.txtID.TabIndex = 4
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.MintCream
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuser.Font = New System.Drawing.Font("Bahnschrift SemiLight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.Black
        Me.txtuser.Location = New System.Drawing.Point(73, 215)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(245, 29)
        Me.txtuser.TabIndex = 5
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.MintCream
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Bahnschrift SemiLight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.Black
        Me.txtpass.Location = New System.Drawing.Point(73, 299)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(245, 29)
        Me.txtpass.TabIndex = 6
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtcpass
        '
        Me.txtcpass.BackColor = System.Drawing.Color.MintCream
        Me.txtcpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcpass.Font = New System.Drawing.Font("Bahnschrift SemiLight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcpass.ForeColor = System.Drawing.Color.Black
        Me.txtcpass.Location = New System.Drawing.Point(73, 385)
        Me.txtcpass.Name = "txtcpass"
        Me.txtcpass.Size = New System.Drawing.Size(245, 29)
        Me.txtcpass.TabIndex = 7
        Me.txtcpass.UseSystemPasswordChar = True
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.Color.Transparent
        Me.lblerror.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Crimson
        Me.lblerror.Location = New System.Drawing.Point(41, 443)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(66, 18)
        Me.lblerror.TabIndex = 8
        Me.lblerror.Text = "error text"
        '
        'bttncreate
        '
        Me.bttncreate.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bttncreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttncreate.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttncreate.ForeColor = System.Drawing.Color.MintCream
        Me.bttncreate.Location = New System.Drawing.Point(256, 476)
        Me.bttncreate.Name = "bttncreate"
        Me.bttncreate.Size = New System.Drawing.Size(135, 54)
        Me.bttncreate.TabIndex = 9
        Me.bttncreate.Text = "Create Account"
        Me.bttncreate.UseVisualStyleBackColor = False
        '
        'lnkBack
        '
        Me.lnkBack.AutoSize = True
        Me.lnkBack.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkBack.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lnkBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkBack.LinkColor = System.Drawing.Color.DarkCyan
        Me.lnkBack.Location = New System.Drawing.Point(21, 492)
        Me.lnkBack.Name = "lnkBack"
        Me.lnkBack.Size = New System.Drawing.Size(69, 23)
        Me.lnkBack.TabIndex = 10
        Me.lnkBack.TabStop = True
        Me.lnkBack.Text = "Go Back"
        '
        'lblsuccess
        '
        Me.lblsuccess.AutoSize = True
        Me.lblsuccess.BackColor = System.Drawing.Color.Transparent
        Me.lblsuccess.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuccess.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblsuccess.Location = New System.Drawing.Point(74, 443)
        Me.lblsuccess.Name = "lblsuccess"
        Me.lblsuccess.Size = New System.Drawing.Size(66, 18)
        Me.lblsuccess.TabIndex = 11
        Me.lblsuccess.Text = "error text"
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.Color.Aquamarine
        Me.LineShape1.X1 = 71
        Me.LineShape1.X2 = 320
        Me.LineShape1.Y1 = 154
        Me.LineShape1.Y2 = 154
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(435, 550)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.LineShape4.BorderWidth = 3
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.SelectionColor = System.Drawing.Color.Aquamarine
        Me.LineShape4.X1 = 71
        Me.LineShape4.X2 = 320
        Me.LineShape4.Y1 = 418
        Me.LineShape4.Y2 = 418
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.SelectionColor = System.Drawing.Color.Aquamarine
        Me.LineShape3.X1 = 72
        Me.LineShape3.X2 = 321
        Me.LineShape3.Y1 = 331
        Me.LineShape3.Y2 = 331
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.SelectionColor = System.Drawing.Color.Aquamarine
        Me.LineShape2.X1 = 72
        Me.LineShape2.X2 = 321
        Me.LineShape2.Y1 = 247
        Me.LineShape2.Y2 = 247
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(39, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(39, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Confirm Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Location = New System.Drawing.Point(-10, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(476, 75)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightCyan
        Me.Label5.Location = New System.Drawing.Point(17, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Create an Account"
        '
        'CreateAcc
        '
        Me.AcceptButton = Me.bttncreate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(435, 550)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblsuccess)
        Me.Controls.Add(Me.lnkBack)
        Me.Controls.Add(Me.bttncreate)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.txtcpass)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateAcc"
        Me.Text = "CreateAcc"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtcpass As System.Windows.Forms.TextBox
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents bttncreate As System.Windows.Forms.Button
    Friend WithEvents lnkBack As System.Windows.Forms.LinkLabel
    Friend WithEvents lblsuccess As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.bttnlogin = New System.Windows.Forms.Button()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CreateTxt = New System.Windows.Forms.LinkLabel()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.bttnexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.MintCream
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuser.Font = New System.Drawing.Font("Bahnschrift SemiLight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.Black
        Me.txtuser.Location = New System.Drawing.Point(97, 177)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(245, 29)
        Me.txtuser.TabIndex = 0
        '
        'bttnlogin
        '
        Me.bttnlogin.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bttnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnlogin.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnlogin.ForeColor = System.Drawing.Color.MintCream
        Me.bttnlogin.Location = New System.Drawing.Point(140, 380)
        Me.bttnlogin.Name = "bttnlogin"
        Me.bttnlogin.Size = New System.Drawing.Size(166, 40)
        Me.bttnlogin.TabIndex = 1
        Me.bttnlogin.Text = "LOGIN"
        Me.bttnlogin.UseVisualStyleBackColor = False
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.MintCream
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.Black
        Me.txtpass.Location = New System.Drawing.Point(94, 259)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(245, 23)
        Me.txtpass.TabIndex = 3
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(90, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(90, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'CreateTxt
        '
        Me.CreateTxt.AutoSize = True
        Me.CreateTxt.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateTxt.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CreateTxt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.CreateTxt.LinkColor = System.Drawing.Color.DarkCyan
        Me.CreateTxt.Location = New System.Drawing.Point(91, 295)
        Me.CreateTxt.Name = "CreateTxt"
        Me.CreateTxt.Size = New System.Drawing.Size(115, 18)
        Me.CreateTxt.TabIndex = 6
        Me.CreateTxt.TabStop = True
        Me.CreateTxt.Text = "Create an account"
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.Color.Transparent
        Me.lblerror.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Crimson
        Me.lblerror.Location = New System.Drawing.Point(92, 322)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(66, 18)
        Me.lblerror.TabIndex = 7
        Me.lblerror.Text = "error text"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(469, 525)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.SelectionColor = System.Drawing.Color.Aquamarine
        Me.LineShape2.X1 = 93
        Me.LineShape2.X2 = 342
        Me.LineShape2.Y1 = 284
        Me.LineShape2.Y2 = 284
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.Color.Aquamarine
        Me.LineShape1.X1 = 95
        Me.LineShape1.X2 = 344
        Me.LineShape1.Y1 = 208
        Me.LineShape1.Y2 = 208
        '
        'bttnexit
        '
        Me.bttnexit.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnexit.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnexit.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.bttnexit.Location = New System.Drawing.Point(140, 448)
        Me.bttnexit.Name = "bttnexit"
        Me.bttnexit.Size = New System.Drawing.Size(166, 40)
        Me.bttnexit.TabIndex = 9
        Me.bttnexit.Text = "EXIT"
        Me.bttnexit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Project.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(162, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 126)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'User
        '
        Me.AcceptButton = Me.bttnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(469, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bttnexit)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.CreateTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.bttnlogin)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User"
        Me.Text = "CCS CyberShop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents bttnlogin As System.Windows.Forms.Button
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CreateTxt As System.Windows.Forms.LinkLabel
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents bttnexit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

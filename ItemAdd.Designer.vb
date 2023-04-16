<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemAdd
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bttnback = New System.Windows.Forms.Button()
        Me.bttnSubmit = New System.Windows.Forms.Button()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtsn = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(140, 170)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(229, 30)
        Me.txtid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(56, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ItemID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(70, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Type :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(60, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(35, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Serial No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(65, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Price :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(41, 488)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Quantity :"
        '
        'bttnback
        '
        Me.bttnback.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnback.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnback.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.bttnback.Location = New System.Drawing.Point(33, 618)
        Me.bttnback.Name = "bttnback"
        Me.bttnback.Size = New System.Drawing.Size(88, 41)
        Me.bttnback.TabIndex = 12
        Me.bttnback.Text = "Go Back"
        Me.bttnback.UseVisualStyleBackColor = False
        '
        'bttnSubmit
        '
        Me.bttnSubmit.BackColor = System.Drawing.Color.Teal
        Me.bttnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnSubmit.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSubmit.ForeColor = System.Drawing.Color.MintCream
        Me.bttnSubmit.Location = New System.Drawing.Point(325, 608)
        Me.bttnSubmit.Name = "bttnSubmit"
        Me.bttnSubmit.Size = New System.Drawing.Size(136, 51)
        Me.bttnSubmit.TabIndex = 13
        Me.bttnSubmit.Text = "Submit "
        Me.bttnSubmit.UseVisualStyleBackColor = False
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.Color.Transparent
        Me.lblerror.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Crimson
        Me.lblerror.Location = New System.Drawing.Point(66, 552)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(66, 18)
        Me.lblerror.TabIndex = 14
        Me.lblerror.Text = "error text"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(12, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Enter New Item Details"
        '
        'txttype
        '
        Me.txttype.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype.Location = New System.Drawing.Point(140, 230)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(229, 30)
        Me.txttype.TabIndex = 16
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(140, 291)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(229, 30)
        Me.txtname.TabIndex = 17
        '
        'txtsn
        '
        Me.txtsn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsn.Location = New System.Drawing.Point(140, 353)
        Me.txtsn.Name = "txtsn"
        Me.txtsn.Size = New System.Drawing.Size(229, 30)
        Me.txtsn.TabIndex = 18
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(140, 417)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(229, 30)
        Me.txtprice.TabIndex = 19
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(140, 485)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(229, 30)
        Me.txtqty.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PictureBox1.Location = New System.Drawing.Point(-10, -10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(530, 97)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PictureBox2.BackgroundImage = Global.Project.My.Resources.Resources.logo
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 64)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'ItemAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(504, 690)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtsn)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.bttnSubmit)
        Me.Controls.Add(Me.bttnback)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemAdd"
        Me.Text = "ItemAdd"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bttnback As System.Windows.Forms.Button
    Friend WithEvents bttnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttype As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtsn As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

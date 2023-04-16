<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hub
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
        Me.bttnCPU = New System.Windows.Forms.Button()
        Me.bttnMOBO = New System.Windows.Forms.Button()
        Me.bttnGPU = New System.Windows.Forms.Button()
        Me.bttnSPACE = New System.Windows.Forms.Button()
        Me.bttnAll = New System.Windows.Forms.Button()
        Me.bttncart = New System.Windows.Forms.Button()
        Me.lnkExit = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttnCPU
        '
        Me.bttnCPU.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnCPU.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCPU.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.bttnCPU.Location = New System.Drawing.Point(91, 277)
        Me.bttnCPU.Name = "bttnCPU"
        Me.bttnCPU.Size = New System.Drawing.Size(148, 58)
        Me.bttnCPU.TabIndex = 4
        Me.bttnCPU.Text = "View Processors"
        Me.bttnCPU.UseVisualStyleBackColor = False
        '
        'bttnMOBO
        '
        Me.bttnMOBO.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnMOBO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnMOBO.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMOBO.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.bttnMOBO.Location = New System.Drawing.Point(91, 515)
        Me.bttnMOBO.Name = "bttnMOBO"
        Me.bttnMOBO.Size = New System.Drawing.Size(148, 58)
        Me.bttnMOBO.TabIndex = 5
        Me.bttnMOBO.Text = "View Motherboards"
        Me.bttnMOBO.UseVisualStyleBackColor = False
        '
        'bttnGPU
        '
        Me.bttnGPU.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnGPU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnGPU.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnGPU.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.bttnGPU.Location = New System.Drawing.Point(388, 277)
        Me.bttnGPU.Name = "bttnGPU"
        Me.bttnGPU.Size = New System.Drawing.Size(148, 58)
        Me.bttnGPU.TabIndex = 6
        Me.bttnGPU.Text = "View GPUs"
        Me.bttnGPU.UseVisualStyleBackColor = False
        '
        'bttnSPACE
        '
        Me.bttnSPACE.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnSPACE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnSPACE.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSPACE.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.bttnSPACE.Location = New System.Drawing.Point(388, 515)
        Me.bttnSPACE.Name = "bttnSPACE"
        Me.bttnSPACE.Size = New System.Drawing.Size(148, 58)
        Me.bttnSPACE.TabIndex = 7
        Me.bttnSPACE.Text = "View RAM and Storage Options"
        Me.bttnSPACE.UseVisualStyleBackColor = False
        '
        'bttnAll
        '
        Me.bttnAll.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bttnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnAll.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAll.ForeColor = System.Drawing.Color.MintCream
        Me.bttnAll.Location = New System.Drawing.Point(232, 599)
        Me.bttnAll.Name = "bttnAll"
        Me.bttnAll.Size = New System.Drawing.Size(174, 58)
        Me.bttnAll.TabIndex = 8
        Me.bttnAll.Text = "View Entire Catalog"
        Me.bttnAll.UseVisualStyleBackColor = False
        '
        'bttncart
        '
        Me.bttncart.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bttncart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttncart.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttncart.ForeColor = System.Drawing.Color.MintCream
        Me.bttncart.Location = New System.Drawing.Point(482, 62)
        Me.bttncart.Name = "bttncart"
        Me.bttncart.Size = New System.Drawing.Size(111, 41)
        Me.bttncart.TabIndex = 9
        Me.bttncart.Text = "View Cart"
        Me.bttncart.UseVisualStyleBackColor = False
        '
        'lnkExit
        '
        Me.lnkExit.AutoSize = True
        Me.lnkExit.BackColor = System.Drawing.Color.Teal
        Me.lnkExit.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkExit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkExit.LinkColor = System.Drawing.Color.MintCream
        Me.lnkExit.Location = New System.Drawing.Point(520, 21)
        Me.lnkExit.Name = "lnkExit"
        Me.lnkExit.Size = New System.Drawing.Size(73, 25)
        Me.lnkExit.TabIndex = 10
        Me.lnkExit.TabStop = True
        Me.lnkExit.Text = "Log out"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MintCream
        Me.Label1.Location = New System.Drawing.Point(143, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "CUSTOMER"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Teal
        Me.lblid.Font = New System.Drawing.Font("Bahnschrift", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.MintCream
        Me.lblid.Location = New System.Drawing.Point(143, 62)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(116, 35)
        Me.lblid.TabIndex = 19
        Me.lblid.Text = "number"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Project.My.Resources.Resources.profile
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(114, 101)
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.Project.My.Resources.Resources.ram_n_space
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(357, 373)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(211, 135)
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.Project.My.Resources.Resources.GPU
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(388, 156)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(148, 105)
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Project.My.Resources.Resources.mobo
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(91, 384)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(148, 114)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Project.My.Resources.Resources.CPU1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(91, 156)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(148, 105)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Teal
        Me.PictureBox1.BackgroundImage = Global.Project.My.Resources.Resources.cart2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(435, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 41)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Teal
        Me.PictureBox7.Location = New System.Drawing.Point(-11, -4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(653, 128)
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        '
        'Hub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(626, 702)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lnkExit)
        Me.Controls.Add(Me.bttncart)
        Me.Controls.Add(Me.bttnAll)
        Me.Controls.Add(Me.bttnSPACE)
        Me.Controls.Add(Me.bttnGPU)
        Me.Controls.Add(Me.bttnMOBO)
        Me.Controls.Add(Me.bttnCPU)
        Me.Controls.Add(Me.PictureBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Hub"
        Me.Text = "Hub"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnCPU As System.Windows.Forms.Button
    Friend WithEvents bttnMOBO As System.Windows.Forms.Button
    Friend WithEvents bttnGPU As System.Windows.Forms.Button
    Friend WithEvents bttnSPACE As System.Windows.Forms.Button
    Friend WithEvents bttnAll As System.Windows.Forms.Button
    Friend WithEvents bttncart As System.Windows.Forms.Button
    Friend WithEvents lnkExit As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblid As System.Windows.Forms.Label
End Class

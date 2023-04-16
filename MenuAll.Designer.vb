<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAll
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bttncheck = New System.Windows.Forms.Button()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnMOBO = New System.Windows.Forms.Button()
        Me.bttnback = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ItemView = New System.Windows.Forms.DataGridView()
        Me.bttnCPU = New System.Windows.Forms.Button()
        Me.bttnGPU = New System.Windows.Forms.Button()
        Me.bttnRAM = New System.Windows.Forms.Button()
        Me.bttnSPACE = New System.Windows.Forms.Button()
        Me.bttnCASE = New System.Windows.Forms.Button()
        Me.bttnEX = New System.Windows.Forms.Button()
        Me.bttnPOW = New System.Windows.Forms.Button()
        Me.bttnALL = New System.Windows.Forms.Button()
        Me.bttncart = New System.Windows.Forms.Button()
        Me.lblitem = New System.Windows.Forms.Label()
        Me.lblcartcount = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.ItemView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttncheck
        '
        Me.bttncheck.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttncheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttncheck.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttncheck.Location = New System.Drawing.Point(826, 619)
        Me.bttncheck.Name = "bttncheck"
        Me.bttncheck.Size = New System.Drawing.Size(168, 73)
        Me.bttncheck.TabIndex = 0
        Me.bttncheck.Text = "Proceed to Transaction"
        Me.bttncheck.UseVisualStyleBackColor = False
        '
        'bttnAdd
        '
        Me.bttnAdd.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnAdd.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAdd.ForeColor = System.Drawing.Color.MintCream
        Me.bttnAdd.Location = New System.Drawing.Point(826, 526)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(168, 60)
        Me.bttnAdd.TabIndex = 1
        Me.bttnAdd.Text = "Add to Cart"
        Me.bttnAdd.UseVisualStyleBackColor = False
        '
        'bttnMOBO
        '
        Me.bttnMOBO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnMOBO.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMOBO.Location = New System.Drawing.Point(35, 256)
        Me.bttnMOBO.Name = "bttnMOBO"
        Me.bttnMOBO.Size = New System.Drawing.Size(162, 39)
        Me.bttnMOBO.TabIndex = 3
        Me.bttnMOBO.Text = "Motherboards"
        Me.bttnMOBO.UseVisualStyleBackColor = True
        '
        'bttnback
        '
        Me.bttnback.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bttnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnback.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnback.ForeColor = System.Drawing.Color.MintCream
        Me.bttnback.Location = New System.Drawing.Point(909, 24)
        Me.bttnback.Name = "bttnback"
        Me.bttnback.Size = New System.Drawing.Size(127, 39)
        Me.bttnback.TabIndex = 7
        Me.bttnback.Text = "Go Back"
        Me.bttnback.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Filter By PC Part:"
        '
        'ItemView
        '
        Me.ItemView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemView.BackgroundColor = System.Drawing.Color.White
        Me.ItemView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.ItemView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemView.Location = New System.Drawing.Point(257, 86)
        Me.ItemView.Name = "ItemView"
        Me.ItemView.ReadOnly = True
        Me.ItemView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ItemView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        Me.ItemView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.ItemView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemView.Size = New System.Drawing.Size(737, 425)
        Me.ItemView.TabIndex = 12
        '
        'bttnCPU
        '
        Me.bttnCPU.BackColor = System.Drawing.Color.MintCream
        Me.bttnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnCPU.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCPU.Location = New System.Drawing.Point(35, 211)
        Me.bttnCPU.Name = "bttnCPU"
        Me.bttnCPU.Size = New System.Drawing.Size(162, 39)
        Me.bttnCPU.TabIndex = 13
        Me.bttnCPU.Text = "Processors"
        Me.bttnCPU.UseVisualStyleBackColor = False
        '
        'bttnGPU
        '
        Me.bttnGPU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnGPU.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnGPU.Location = New System.Drawing.Point(35, 301)
        Me.bttnGPU.Name = "bttnGPU"
        Me.bttnGPU.Size = New System.Drawing.Size(162, 39)
        Me.bttnGPU.TabIndex = 14
        Me.bttnGPU.Text = "GPUs"
        Me.bttnGPU.UseVisualStyleBackColor = True
        '
        'bttnRAM
        '
        Me.bttnRAM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnRAM.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnRAM.Location = New System.Drawing.Point(35, 346)
        Me.bttnRAM.Name = "bttnRAM"
        Me.bttnRAM.Size = New System.Drawing.Size(162, 39)
        Me.bttnRAM.TabIndex = 15
        Me.bttnRAM.Text = "RAM"
        Me.bttnRAM.UseVisualStyleBackColor = True
        '
        'bttnSPACE
        '
        Me.bttnSPACE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnSPACE.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSPACE.Location = New System.Drawing.Point(35, 391)
        Me.bttnSPACE.Name = "bttnSPACE"
        Me.bttnSPACE.Size = New System.Drawing.Size(162, 39)
        Me.bttnSPACE.TabIndex = 16
        Me.bttnSPACE.Text = "Storage"
        Me.bttnSPACE.UseVisualStyleBackColor = True
        '
        'bttnCASE
        '
        Me.bttnCASE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnCASE.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCASE.Location = New System.Drawing.Point(35, 481)
        Me.bttnCASE.Name = "bttnCASE"
        Me.bttnCASE.Size = New System.Drawing.Size(162, 39)
        Me.bttnCASE.TabIndex = 17
        Me.bttnCASE.Text = "Cases"
        Me.bttnCASE.UseVisualStyleBackColor = True
        '
        'bttnEX
        '
        Me.bttnEX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnEX.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnEX.Location = New System.Drawing.Point(35, 526)
        Me.bttnEX.Name = "bttnEX"
        Me.bttnEX.Size = New System.Drawing.Size(162, 39)
        Me.bttnEX.TabIndex = 18
        Me.bttnEX.Text = "Fans and Accessories"
        Me.bttnEX.UseVisualStyleBackColor = True
        '
        'bttnPOW
        '
        Me.bttnPOW.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnPOW.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPOW.Location = New System.Drawing.Point(35, 436)
        Me.bttnPOW.Name = "bttnPOW"
        Me.bttnPOW.Size = New System.Drawing.Size(162, 39)
        Me.bttnPOW.TabIndex = 19
        Me.bttnPOW.Text = "Power Supply"
        Me.bttnPOW.UseVisualStyleBackColor = True
        '
        'bttnALL
        '
        Me.bttnALL.BackColor = System.Drawing.Color.Teal
        Me.bttnALL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnALL.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnALL.ForeColor = System.Drawing.Color.MintCream
        Me.bttnALL.Location = New System.Drawing.Point(23, 109)
        Me.bttnALL.Name = "bttnALL"
        Me.bttnALL.Size = New System.Drawing.Size(189, 53)
        Me.bttnALL.TabIndex = 20
        Me.bttnALL.Text = "View All Products"
        Me.bttnALL.UseVisualStyleBackColor = False
        '
        'bttncart
        '
        Me.bttncart.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttncart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttncart.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttncart.Location = New System.Drawing.Point(617, 619)
        Me.bttncart.Name = "bttncart"
        Me.bttncart.Size = New System.Drawing.Size(168, 73)
        Me.bttncart.TabIndex = 21
        Me.bttncart.Text = "View your Cart"
        Me.bttncart.UseVisualStyleBackColor = False
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Font = New System.Drawing.Font("Bahnschrift", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitem.ForeColor = System.Drawing.Color.Black
        Me.lblitem.Location = New System.Drawing.Point(260, 541)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(152, 35)
        Me.lblitem.TabIndex = 22
        Me.lblitem.Text = "item name"
        Me.lblitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcartcount
        '
        Me.lblcartcount.AutoSize = True
        Me.lblcartcount.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartcount.ForeColor = System.Drawing.Color.Teal
        Me.lblcartcount.Location = New System.Drawing.Point(769, 598)
        Me.lblcartcount.Name = "lblcartcount"
        Me.lblcartcount.Size = New System.Drawing.Size(35, 39)
        Me.lblcartcount.TabIndex = 23
        Me.lblcartcount.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox1.BackgroundImage = Global.Project.My.Resources.Resources.cart2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(548, 619)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 73)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Teal
        Me.PictureBox2.Location = New System.Drawing.Point(-28, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1259, 91)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'MenuAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1072, 742)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblcartcount)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.bttncart)
        Me.Controls.Add(Me.bttnALL)
        Me.Controls.Add(Me.bttnPOW)
        Me.Controls.Add(Me.bttnEX)
        Me.Controls.Add(Me.bttnCASE)
        Me.Controls.Add(Me.bttnSPACE)
        Me.Controls.Add(Me.bttnRAM)
        Me.Controls.Add(Me.bttnGPU)
        Me.Controls.Add(Me.bttnCPU)
        Me.Controls.Add(Me.ItemView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnback)
        Me.Controls.Add(Me.bttnMOBO)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.bttncheck)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuAll"
        Me.Text = "Browse All"
        CType(Me.ItemView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttncheck As System.Windows.Forms.Button
    Friend WithEvents bttnAdd As System.Windows.Forms.Button
    Friend WithEvents bttnMOBO As System.Windows.Forms.Button
    Friend WithEvents bttnback As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ItemView As System.Windows.Forms.DataGridView
    Friend WithEvents bttnCPU As System.Windows.Forms.Button
    Friend WithEvents bttnGPU As System.Windows.Forms.Button
    Friend WithEvents bttnRAM As System.Windows.Forms.Button
    Friend WithEvents bttnSPACE As System.Windows.Forms.Button
    Friend WithEvents bttnCASE As System.Windows.Forms.Button
    Friend WithEvents bttnEX As System.Windows.Forms.Button
    Friend WithEvents bttnPOW As System.Windows.Forms.Button
    Friend WithEvents bttnALL As System.Windows.Forms.Button
    Friend WithEvents bttncart As System.Windows.Forms.Button
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lblcartcount As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

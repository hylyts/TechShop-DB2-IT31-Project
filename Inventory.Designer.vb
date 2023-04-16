<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnUpdate = New System.Windows.Forms.Button()
        Me.bttnQTY = New System.Windows.Forms.Button()
        Me.bttnDel = New System.Windows.Forms.Button()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.ItemView = New System.Windows.Forms.DataGridView()
        Me.lblitem = New System.Windows.Forms.Label()
        Me.bttnPOW = New System.Windows.Forms.Button()
        Me.bttnEX = New System.Windows.Forms.Button()
        Me.bttnCASE = New System.Windows.Forms.Button()
        Me.bttnSPACE = New System.Windows.Forms.Button()
        Me.bttnRAM = New System.Windows.Forms.Button()
        Me.bttnGPU = New System.Windows.Forms.Button()
        Me.bttnCPU = New System.Windows.Forms.Button()
        Me.bttnMOBO = New System.Windows.Forms.Button()
        Me.bttnALL = New System.Windows.Forms.Button()
        Me.bttnback = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ItemView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Filter By PC Part:"
        '
        'bttnUpdate
        '
        Me.bttnUpdate.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnUpdate.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnUpdate.Location = New System.Drawing.Point(569, 632)
        Me.bttnUpdate.Name = "bttnUpdate"
        Me.bttnUpdate.Size = New System.Drawing.Size(168, 60)
        Me.bttnUpdate.TabIndex = 30
        Me.bttnUpdate.Text = "Update Price"
        Me.bttnUpdate.UseVisualStyleBackColor = False
        '
        'bttnQTY
        '
        Me.bttnQTY.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnQTY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnQTY.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnQTY.Location = New System.Drawing.Point(770, 632)
        Me.bttnQTY.Name = "bttnQTY"
        Me.bttnQTY.Size = New System.Drawing.Size(168, 60)
        Me.bttnQTY.TabIndex = 31
        Me.bttnQTY.Text = "Update Quantity"
        Me.bttnQTY.UseVisualStyleBackColor = False
        '
        'bttnDel
        '
        Me.bttnDel.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnDel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDel.Location = New System.Drawing.Point(968, 632)
        Me.bttnDel.Name = "bttnDel"
        Me.bttnDel.Size = New System.Drawing.Size(168, 60)
        Me.bttnDel.TabIndex = 32
        Me.bttnDel.Text = "Delete Item"
        Me.bttnDel.UseVisualStyleBackColor = False
        '
        'bttnAdd
        '
        Me.bttnAdd.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnAdd.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAdd.Location = New System.Drawing.Point(19, 629)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(189, 60)
        Me.bttnAdd.TabIndex = 33
        Me.bttnAdd.Text = "Add new Item"
        Me.bttnAdd.UseVisualStyleBackColor = False
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
        Me.ItemView.Location = New System.Drawing.Point(232, 99)
        Me.ItemView.Name = "ItemView"
        Me.ItemView.ReadOnly = True
        Me.ItemView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ItemView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        Me.ItemView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.ItemView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemView.Size = New System.Drawing.Size(904, 455)
        Me.ItemView.TabIndex = 34
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitem.ForeColor = System.Drawing.Color.Black
        Me.lblitem.Location = New System.Drawing.Point(235, 566)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(167, 39)
        Me.lblitem.TabIndex = 35
        Me.lblitem.Text = "item name"
        Me.lblitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bttnPOW
        '
        Me.bttnPOW.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnPOW.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPOW.Location = New System.Drawing.Point(28, 404)
        Me.bttnPOW.Name = "bttnPOW"
        Me.bttnPOW.Size = New System.Drawing.Size(162, 39)
        Me.bttnPOW.TabIndex = 43
        Me.bttnPOW.Text = "Power Supply"
        Me.bttnPOW.UseVisualStyleBackColor = True
        '
        'bttnEX
        '
        Me.bttnEX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnEX.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnEX.Location = New System.Drawing.Point(28, 494)
        Me.bttnEX.Name = "bttnEX"
        Me.bttnEX.Size = New System.Drawing.Size(162, 39)
        Me.bttnEX.TabIndex = 42
        Me.bttnEX.Text = "Fans and Accessories"
        Me.bttnEX.UseVisualStyleBackColor = True
        '
        'bttnCASE
        '
        Me.bttnCASE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnCASE.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCASE.Location = New System.Drawing.Point(28, 449)
        Me.bttnCASE.Name = "bttnCASE"
        Me.bttnCASE.Size = New System.Drawing.Size(162, 39)
        Me.bttnCASE.TabIndex = 41
        Me.bttnCASE.Text = "Cases"
        Me.bttnCASE.UseVisualStyleBackColor = True
        '
        'bttnSPACE
        '
        Me.bttnSPACE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnSPACE.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSPACE.Location = New System.Drawing.Point(28, 359)
        Me.bttnSPACE.Name = "bttnSPACE"
        Me.bttnSPACE.Size = New System.Drawing.Size(162, 39)
        Me.bttnSPACE.TabIndex = 40
        Me.bttnSPACE.Text = "Storage"
        Me.bttnSPACE.UseVisualStyleBackColor = True
        '
        'bttnRAM
        '
        Me.bttnRAM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnRAM.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnRAM.Location = New System.Drawing.Point(28, 314)
        Me.bttnRAM.Name = "bttnRAM"
        Me.bttnRAM.Size = New System.Drawing.Size(162, 39)
        Me.bttnRAM.TabIndex = 39
        Me.bttnRAM.Text = "RAM"
        Me.bttnRAM.UseVisualStyleBackColor = True
        '
        'bttnGPU
        '
        Me.bttnGPU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnGPU.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnGPU.Location = New System.Drawing.Point(28, 269)
        Me.bttnGPU.Name = "bttnGPU"
        Me.bttnGPU.Size = New System.Drawing.Size(162, 39)
        Me.bttnGPU.TabIndex = 38
        Me.bttnGPU.Text = "GPUs"
        Me.bttnGPU.UseVisualStyleBackColor = True
        '
        'bttnCPU
        '
        Me.bttnCPU.BackColor = System.Drawing.Color.MintCream
        Me.bttnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnCPU.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCPU.Location = New System.Drawing.Point(28, 179)
        Me.bttnCPU.Name = "bttnCPU"
        Me.bttnCPU.Size = New System.Drawing.Size(162, 39)
        Me.bttnCPU.TabIndex = 37
        Me.bttnCPU.Text = "Processors"
        Me.bttnCPU.UseVisualStyleBackColor = False
        '
        'bttnMOBO
        '
        Me.bttnMOBO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnMOBO.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMOBO.Location = New System.Drawing.Point(28, 224)
        Me.bttnMOBO.Name = "bttnMOBO"
        Me.bttnMOBO.Size = New System.Drawing.Size(162, 39)
        Me.bttnMOBO.TabIndex = 36
        Me.bttnMOBO.Text = "Motherboards"
        Me.bttnMOBO.UseVisualStyleBackColor = True
        '
        'bttnALL
        '
        Me.bttnALL.BackColor = System.Drawing.Color.Teal
        Me.bttnALL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnALL.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnALL.ForeColor = System.Drawing.Color.MintCream
        Me.bttnALL.Location = New System.Drawing.Point(19, 64)
        Me.bttnALL.Name = "bttnALL"
        Me.bttnALL.Size = New System.Drawing.Size(189, 53)
        Me.bttnALL.TabIndex = 44
        Me.bttnALL.Text = "View All Products"
        Me.bttnALL.UseVisualStyleBackColor = False
        '
        'bttnback
        '
        Me.bttnback.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bttnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnback.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnback.ForeColor = System.Drawing.Color.MintCream
        Me.bttnback.Location = New System.Drawing.Point(1009, 24)
        Me.bttnback.Name = "bttnback"
        Me.bttnback.Size = New System.Drawing.Size(127, 39)
        Me.bttnback.TabIndex = 45
        Me.bttnback.Text = "Go Back"
        Me.bttnback.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Teal
        Me.PictureBox1.Location = New System.Drawing.Point(968, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 65)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1200, 718)
        Me.Controls.Add(Me.bttnback)
        Me.Controls.Add(Me.bttnALL)
        Me.Controls.Add(Me.bttnPOW)
        Me.Controls.Add(Me.bttnEX)
        Me.Controls.Add(Me.bttnCASE)
        Me.Controls.Add(Me.bttnSPACE)
        Me.Controls.Add(Me.bttnRAM)
        Me.Controls.Add(Me.bttnGPU)
        Me.Controls.Add(Me.bttnCPU)
        Me.Controls.Add(Me.bttnMOBO)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.ItemView)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.bttnDel)
        Me.Controls.Add(Me.bttnQTY)
        Me.Controls.Add(Me.bttnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        CType(Me.ItemView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnUpdate As System.Windows.Forms.Button
    Friend WithEvents bttnQTY As System.Windows.Forms.Button
    Friend WithEvents bttnDel As System.Windows.Forms.Button
    Friend WithEvents bttnAdd As System.Windows.Forms.Button
    Friend WithEvents ItemView As System.Windows.Forms.DataGridView
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents bttnPOW As System.Windows.Forms.Button
    Friend WithEvents bttnEX As System.Windows.Forms.Button
    Friend WithEvents bttnCASE As System.Windows.Forms.Button
    Friend WithEvents bttnSPACE As System.Windows.Forms.Button
    Friend WithEvents bttnRAM As System.Windows.Forms.Button
    Friend WithEvents bttnGPU As System.Windows.Forms.Button
    Friend WithEvents bttnCPU As System.Windows.Forms.Button
    Friend WithEvents bttnMOBO As System.Windows.Forms.Button
    Friend WithEvents bttnALL As System.Windows.Forms.Button
    Friend WithEvents bttnback As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

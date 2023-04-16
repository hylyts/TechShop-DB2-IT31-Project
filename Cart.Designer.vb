<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
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
        Me.bttndelete = New System.Windows.Forms.Button()
        Me.bttncheck = New System.Windows.Forms.Button()
        Me.bttnback = New System.Windows.Forms.Button()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.CartView = New System.Windows.Forms.DataGridView()
        CType(Me.CartView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttndelete
        '
        Me.bttndelete.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttndelete.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttndelete.Location = New System.Drawing.Point(84, 525)
        Me.bttndelete.Name = "bttndelete"
        Me.bttndelete.Size = New System.Drawing.Size(224, 76)
        Me.bttndelete.TabIndex = 1
        Me.bttndelete.Text = "Delete Item"
        Me.bttndelete.UseVisualStyleBackColor = False
        '
        'bttncheck
        '
        Me.bttncheck.BackColor = System.Drawing.Color.Teal
        Me.bttncheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttncheck.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttncheck.ForeColor = System.Drawing.Color.MintCream
        Me.bttncheck.Location = New System.Drawing.Point(511, 525)
        Me.bttncheck.Name = "bttncheck"
        Me.bttncheck.Size = New System.Drawing.Size(224, 76)
        Me.bttncheck.TabIndex = 2
        Me.bttncheck.Text = "Proceed to Transaction"
        Me.bttncheck.UseVisualStyleBackColor = False
        '
        'bttnback
        '
        Me.bttnback.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bttnback.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnback.ForeColor = System.Drawing.Color.MintCream
        Me.bttnback.Location = New System.Drawing.Point(12, 28)
        Me.bttnback.Name = "bttnback"
        Me.bttnback.Size = New System.Drawing.Size(127, 39)
        Me.bttnback.TabIndex = 8
        Me.bttnback.Text = "Back to Catalog"
        Me.bttnback.UseVisualStyleBackColor = False
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(593, 461)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(142, 33)
        Me.lblprice.TabIndex = 9
        Me.lblprice.Text = "Total Price"
        '
        'CartView
        '
        Me.CartView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CartView.BackgroundColor = System.Drawing.Color.White
        Me.CartView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.CartView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CartView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartView.Location = New System.Drawing.Point(60, 97)
        Me.CartView.Name = "CartView"
        Me.CartView.ReadOnly = True
        Me.CartView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CartView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        Me.CartView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.CartView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CartView.Size = New System.Drawing.Size(675, 345)
        Me.CartView.TabIndex = 13
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(811, 642)
        Me.Controls.Add(Me.CartView)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.bttnback)
        Me.Controls.Add(Me.bttncheck)
        Me.Controls.Add(Me.bttndelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cart"
        Me.Text = "Cart"
        CType(Me.CartView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttndelete As System.Windows.Forms.Button
    Friend WithEvents bttncheck As System.Windows.Forms.Button
    Friend WithEvents bttnback As System.Windows.Forms.Button
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents CartView As System.Windows.Forms.DataGridView
End Class

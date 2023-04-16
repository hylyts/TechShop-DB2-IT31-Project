<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transact
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bttnconfirm = New System.Windows.Forms.Button()
        Me.bttnedit = New System.Windows.Forms.Button()
        Me.bttnMenu = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CartView = New System.Windows.Forms.DataGridView()
        CType(Me.CartView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttnconfirm
        '
        Me.bttnconfirm.BackColor = System.Drawing.Color.PaleTurquoise
        Me.bttnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnconfirm.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnconfirm.Location = New System.Drawing.Point(279, 530)
        Me.bttnconfirm.Name = "bttnconfirm"
        Me.bttnconfirm.Size = New System.Drawing.Size(179, 73)
        Me.bttnconfirm.TabIndex = 1
        Me.bttnconfirm.Text = "Confirm Purchase"
        Me.bttnconfirm.UseVisualStyleBackColor = False
        '
        'bttnedit
        '
        Me.bttnedit.BackColor = System.Drawing.Color.Teal
        Me.bttnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnedit.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnedit.ForeColor = System.Drawing.Color.MintCream
        Me.bttnedit.Location = New System.Drawing.Point(35, 530)
        Me.bttnedit.Name = "bttnedit"
        Me.bttnedit.Size = New System.Drawing.Size(119, 73)
        Me.bttnedit.TabIndex = 2
        Me.bttnedit.Text = "Edit Cart"
        Me.bttnedit.UseVisualStyleBackColor = False
        '
        'bttnMenu
        '
        Me.bttnMenu.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bttnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnMenu.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMenu.ForeColor = System.Drawing.Color.MintCream
        Me.bttnMenu.Location = New System.Drawing.Point(35, 33)
        Me.bttnMenu.Name = "bttnMenu"
        Me.bttnMenu.Size = New System.Drawing.Size(119, 38)
        Me.bttnMenu.TabIndex = 3
        Me.bttnMenu.Text = "Back to Catalog"
        Me.bttnMenu.UseVisualStyleBackColor = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(28, 446)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(166, 39)
        Me.lbltotal.TabIndex = 10
        Me.lbltotal.Text = "Total Price"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Total Price"
        '
        'CartView
        '
        Me.CartView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CartView.BackgroundColor = System.Drawing.Color.White
        Me.CartView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.CartView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CartView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartView.Location = New System.Drawing.Point(35, 92)
        Me.CartView.Name = "CartView"
        Me.CartView.ReadOnly = True
        Me.CartView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CartView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        Me.CartView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.CartView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CartView.Size = New System.Drawing.Size(423, 300)
        Me.CartView.TabIndex = 13
        '
        'Transact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(492, 645)
        Me.Controls.Add(Me.CartView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.bttnMenu)
        Me.Controls.Add(Me.bttnedit)
        Me.Controls.Add(Me.bttnconfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transact"
        Me.Text = "Transact"
        CType(Me.CartView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnconfirm As System.Windows.Forms.Button
    Friend WithEvents bttnedit As System.Windows.Forms.Button
    Friend WithEvents bttnMenu As System.Windows.Forms.Button
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CartView As System.Windows.Forms.DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdMenuvb
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
        Me.bttnItems = New System.Windows.Forms.Button()
        Me.bttnSales = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttnItems
        '
        Me.bttnItems.BackColor = System.Drawing.Color.Teal
        Me.bttnItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnItems.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnItems.ForeColor = System.Drawing.Color.MintCream
        Me.bttnItems.Location = New System.Drawing.Point(59, 210)
        Me.bttnItems.Name = "bttnItems"
        Me.bttnItems.Size = New System.Drawing.Size(196, 167)
        Me.bttnItems.TabIndex = 0
        Me.bttnItems.Text = "View Inventory"
        Me.bttnItems.UseVisualStyleBackColor = False
        '
        'bttnSales
        '
        Me.bttnSales.BackColor = System.Drawing.Color.Teal
        Me.bttnSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnSales.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSales.ForeColor = System.Drawing.Color.MintCream
        Me.bttnSales.Location = New System.Drawing.Point(370, 210)
        Me.bttnSales.Name = "bttnSales"
        Me.bttnSales.Size = New System.Drawing.Size(196, 167)
        Me.bttnSales.TabIndex = 1
        Me.bttnSales.Text = "View Sales"
        Me.bttnSales.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.Location = New System.Drawing.Point(496, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 42)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Log out"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Location = New System.Drawing.Point(-10, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(669, 169)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Project.My.Resources.Resources.profile
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 137)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MintCream
        Me.Label1.Location = New System.Drawing.Point(186, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "EMPLOYEE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MintCream
        Me.Label2.Location = New System.Drawing.Point(186, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 42)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mode"
        '
        'AdMenuvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(630, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bttnSales)
        Me.Controls.Add(Me.bttnItems)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdMenuvb"
        Me.Text = "AdMenuvb"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnItems As System.Windows.Forms.Button
    Friend WithEvents bttnSales As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

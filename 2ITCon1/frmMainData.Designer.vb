<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainData))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.btnUnit = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnCustomer)
        Me.Panel1.Controls.Add(Me.btnStaff)
        Me.Panel1.Controls.Add(Me.btnProduct)
        Me.Panel1.Controls.Add(Me.btnCategory)
        Me.Panel1.Controls.Add(Me.btnUnit)
        Me.Panel1.Controls.Add(Me.btnSupplier)
        Me.Panel1.Location = New System.Drawing.Point(47, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(908, 601)
        Me.Panel1.TabIndex = 29
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.SandyBrown
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.Location = New System.Drawing.Point(648, 343)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(200, 200)
        Me.btnCustomer.TabIndex = 5
        Me.btnCustomer.Text = "ຂໍ້ມູນລູກຄ້າ"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStaff.Image = CType(resources.GetObject("btnStaff.Image"), System.Drawing.Image)
        Me.btnStaff.Location = New System.Drawing.Point(350, 333)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(200, 200)
        Me.btnStaff.TabIndex = 4
        Me.btnStaff.Text = "ຂໍ້ມູນພະນັກງານ"
        Me.btnStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProduct.Image = CType(resources.GetObject("btnProduct.Image"), System.Drawing.Image)
        Me.btnProduct.Location = New System.Drawing.Point(73, 333)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(200, 200)
        Me.btnProduct.TabIndex = 3
        Me.btnProduct.Text = "ຂໍ້ມູນສິນຄ້າ"
        Me.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.Color.Turquoise
        Me.btnCategory.FlatAppearance.BorderSize = 0
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategory.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCategory.Image = CType(resources.GetObject("btnCategory.Image"), System.Drawing.Image)
        Me.btnCategory.Location = New System.Drawing.Point(648, 42)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(200, 200)
        Me.btnCategory.TabIndex = 2
        Me.btnCategory.Text = "ຂໍ້ມູນປະເພດ"
        Me.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'btnUnit
        '
        Me.btnUnit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnUnit.FlatAppearance.BorderSize = 0
        Me.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnit.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUnit.Image = CType(resources.GetObject("btnUnit.Image"), System.Drawing.Image)
        Me.btnUnit.Location = New System.Drawing.Point(350, 42)
        Me.btnUnit.Name = "btnUnit"
        Me.btnUnit.Size = New System.Drawing.Size(200, 200)
        Me.btnUnit.TabIndex = 1
        Me.btnUnit.Text = "ຂໍ້ມູນຫົວໜ່ວຍ"
        Me.btnUnit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUnit.UseVisualStyleBackColor = False
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSupplier.FlatAppearance.BorderSize = 0
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSupplier.Image = CType(resources.GetObject("btnSupplier.Image"), System.Drawing.Image)
        Me.btnSupplier.Location = New System.Drawing.Point(73, 42)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(200, 200)
        Me.btnSupplier.TabIndex = 0
        Me.btnSupplier.Text = "ຂໍ້ມູນຜູ້ສະໜອງ"
        Me.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(994, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 50)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Turquoise
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(508, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 73)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ຂໍ້ມູນປະເພດ"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmMainData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 766)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainData"
        Me.Text = "frmMainData"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents btnCategory As Button
    Friend WithEvents btnUnit As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Button1 As Button
End Class

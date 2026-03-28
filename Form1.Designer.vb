<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.lbProduct = New System.Windows.Forms.Label()
        Me.lbQty = New System.Windows.Forms.Label()
        Me.lbBrand = New System.Windows.Forms.Label()
        Me.cboProduct = New System.Windows.Forms.ComboBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lbProductList = New System.Windows.Forms.Label()
        Me.lbQtyList = New System.Windows.Forms.Label()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.lbTotalList = New System.Windows.Forms.Label()
        Me.lstProduct = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lstQty = New System.Windows.Forms.ListBox()
        Me.lstTotal = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pboProduct = New System.Windows.Forms.PictureBox()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammedByIzyneGallardoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BSCS2AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pboProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbProduct
        '
        Me.lbProduct.AutoSize = True
        Me.lbProduct.BackColor = System.Drawing.Color.Transparent
        Me.lbProduct.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProduct.Location = New System.Drawing.Point(39, 114)
        Me.lbProduct.Name = "lbProduct"
        Me.lbProduct.Size = New System.Drawing.Size(83, 20)
        Me.lbProduct.TabIndex = 0
        Me.lbProduct.Text = "Product: "
        '
        'lbQty
        '
        Me.lbQty.AutoSize = True
        Me.lbQty.BackColor = System.Drawing.Color.Transparent
        Me.lbQty.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQty.Location = New System.Drawing.Point(39, 147)
        Me.lbQty.Name = "lbQty"
        Me.lbQty.Size = New System.Drawing.Size(93, 20)
        Me.lbQty.TabIndex = 1
        Me.lbQty.Text = "Quantity: "
        '
        'lbBrand
        '
        Me.lbBrand.AutoSize = True
        Me.lbBrand.BackColor = System.Drawing.Color.Transparent
        Me.lbBrand.Font = New System.Drawing.Font("Fugaz One", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBrand.Location = New System.Drawing.Point(127, 49)
        Me.lbBrand.Name = "lbBrand"
        Me.lbBrand.Size = New System.Drawing.Size(189, 39)
        Me.lbBrand.TabIndex = 2
        Me.lbBrand.Text = "Yum Corner."
        '
        'cboProduct
        '
        Me.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Items.AddRange(New Object() {"None", "Hamburger", "Fries", "Footlong", "Sandwich", "Softdrink"})
        Me.cboProduct.Location = New System.Drawing.Point(150, 113)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(124, 21)
        Me.cboProduct.TabIndex = 1
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(185, 148)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(54, 20)
        Me.txtQty.TabIndex = 4
        '
        'lbProductList
        '
        Me.lbProductList.AutoSize = True
        Me.lbProductList.BackColor = System.Drawing.Color.Transparent
        Me.lbProductList.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProductList.Location = New System.Drawing.Point(69, 239)
        Me.lbProductList.Name = "lbProductList"
        Me.lbProductList.Size = New System.Drawing.Size(70, 20)
        Me.lbProductList.TabIndex = 6
        Me.lbProductList.Text = "Product"
        '
        'lbQtyList
        '
        Me.lbQtyList.AutoSize = True
        Me.lbQtyList.BackColor = System.Drawing.Color.Transparent
        Me.lbQtyList.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQtyList.Location = New System.Drawing.Point(419, 239)
        Me.lbQtyList.Name = "lbQtyList"
        Me.lbQtyList.Size = New System.Drawing.Size(80, 20)
        Me.lbQtyList.TabIndex = 7
        Me.lbQtyList.Text = "Quantity"
        '
        'lbPrice
        '
        Me.lbPrice.AutoSize = True
        Me.lbPrice.BackColor = System.Drawing.Color.Transparent
        Me.lbPrice.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrice.Location = New System.Drawing.Point(259, 239)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(48, 20)
        Me.lbPrice.TabIndex = 8
        Me.lbPrice.Text = "Price"
        '
        'lbTotalList
        '
        Me.lbTotalList.AutoSize = True
        Me.lbTotalList.BackColor = System.Drawing.Color.Transparent
        Me.lbTotalList.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalList.Location = New System.Drawing.Point(601, 239)
        Me.lbTotalList.Name = "lbTotalList"
        Me.lbTotalList.Size = New System.Drawing.Size(51, 20)
        Me.lbTotalList.TabIndex = 9
        Me.lbTotalList.Text = "Total"
        '
        'lstProduct
        '
        Me.lstProduct.FormattingEnabled = True
        Me.lstProduct.Location = New System.Drawing.Point(32, 276)
        Me.lstProduct.Name = "lstProduct"
        Me.lstProduct.Size = New System.Drawing.Size(150, 147)
        Me.lstProduct.TabIndex = 10
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.Location = New System.Drawing.Point(208, 276)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(150, 147)
        Me.lstPrice.TabIndex = 11
        '
        'lstQty
        '
        Me.lstQty.FormattingEnabled = True
        Me.lstQty.Location = New System.Drawing.Point(384, 276)
        Me.lstQty.Name = "lstQty"
        Me.lstQty.Size = New System.Drawing.Size(150, 147)
        Me.lstQty.TabIndex = 12
        '
        'lstTotal
        '
        Me.lstTotal.FormattingEnabled = True
        Me.lstTotal.Location = New System.Drawing.Point(550, 276)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.Size = New System.Drawing.Size(150, 147)
        Me.lstTotal.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Teko SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(544, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 39)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Total: "
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.BackColor = System.Drawing.Color.Transparent
        Me.lbTotal.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(617, 443)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(15, 20)
        Me.lbTotal.TabIndex = 15
        Me.lbTotal.Text = " "
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(32, 436)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(86, 20)
        Me.btnRemove.TabIndex = 16
        Me.btnRemove.Text = "Remove Items"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(184, 177)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 20)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pboProduct
        '
        Me.pboProduct.BackColor = System.Drawing.Color.Transparent
        Me.pboProduct.BackgroundImage = Global.Store.My.Resources.Resources.logo
        Me.pboProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pboProduct.Location = New System.Drawing.Point(511, 70)
        Me.pboProduct.Name = "pboProduct"
        Me.pboProduct.Size = New System.Drawing.Size(173, 136)
        Me.pboProduct.TabIndex = 5
        Me.pboProduct.TabStop = False
        '
        'btnSubtract
        '
        Me.btnSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtract.Location = New System.Drawing.Point(150, 148)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(31, 20)
        Me.btnSubtract.TabIndex = 18
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(243, 148)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(31, 20)
        Me.btnPlus.TabIndex = 19
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkRed
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(755, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrammedByIzyneGallardoToolStripMenuItem, Me.BSCS2AToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ProgrammedByIzyneGallardoToolStripMenuItem
        '
        Me.ProgrammedByIzyneGallardoToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate
        Me.ProgrammedByIzyneGallardoToolStripMenuItem.Name = "ProgrammedByIzyneGallardoToolStripMenuItem"
        Me.ProgrammedByIzyneGallardoToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgrammedByIzyneGallardoToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ProgrammedByIzyneGallardoToolStripMenuItem.Text = "Programmed by Izyne Gallardo ♥"
        '
        'BSCS2AToolStripMenuItem
        '
        Me.BSCS2AToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate
        Me.BSCS2AToolStripMenuItem.Name = "BSCS2AToolStripMenuItem"
        Me.BSCS2AToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BSCS2AToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BSCS2AToolStripMenuItem.Text = "BSCS 2 - A"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImage = Global.Store.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(755, 484)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTotal)
        Me.Controls.Add(Me.lstQty)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstProduct)
        Me.Controls.Add(Me.lbTotalList)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbQtyList)
        Me.Controls.Add(Me.lbProductList)
        Me.Controls.Add(Me.pboProduct)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.lbBrand)
        Me.Controls.Add(Me.lbQty)
        Me.Controls.Add(Me.lbProduct)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMainMenu"
        Me.Text = "Yum Corner."
        CType(Me.pboProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbProduct As Label
    Friend WithEvents lbQty As Label
    Friend WithEvents lbBrand As Label
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents pboProduct As PictureBox
    Friend WithEvents lbProductList As Label
    Friend WithEvents lbQtyList As Label
    Friend WithEvents lbPrice As Label
    Friend WithEvents lbTotalList As Label
    Friend WithEvents lstProduct As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents lstQty As ListBox
    Friend WithEvents lstTotal As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrammedByIzyneGallardoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BSCS2AToolStripMenuItem As ToolStripMenuItem
End Class

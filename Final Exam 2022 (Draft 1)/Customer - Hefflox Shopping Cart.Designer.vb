<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Shopping_Cart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shopping_Cart))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PCTB_Trash = New System.Windows.Forms.PictureBox()
        Me.lblItemQuantity = New System.Windows.Forms.Label()
        Me.lblItemCode = New System.Windows.Forms.Label()
        Me.PCTB_Plus = New System.Windows.Forms.PictureBox()
        Me.PCTB_Minus = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_Finish = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_OrderSum = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.BTN_Print = New System.Windows.Forms.Button()
        Me.lbl_sbttl = New System.Windows.Forms.Label()
        Me.lblNoItems = New System.Windows.Forms.Label()
        Me.DGV_receipt = New System.Windows.Forms.DataGridView()
        Me.ProdID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Make = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Placement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrossPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Photo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PCTB_Back = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PCTB_Min = New System.Windows.Forms.PictureBox()
        Me.PCTB_Close = New System.Windows.Forms.PictureBox()
        Me.PCTB_Max = New System.Windows.Forms.PictureBox()
        Me.PCTBX_Normal = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PCTB_Trash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTB_Plus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTB_Minus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.DGV_receipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTB_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PCTB_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTB_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTB_Max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTBX_Normal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.DGV_receipt)
        Me.Panel3.Location = New System.Drawing.Point(0, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1367, 622)
        Me.Panel3.TabIndex = 38
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.PCTB_Trash)
        Me.Panel7.Controls.Add(Me.lblItemQuantity)
        Me.Panel7.Controls.Add(Me.lblItemCode)
        Me.Panel7.Controls.Add(Me.PCTB_Plus)
        Me.Panel7.Controls.Add(Me.PCTB_Minus)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.BTN_Finish)
        Me.Panel7.Location = New System.Drawing.Point(1020, 281)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(343, 138)
        Me.Panel7.TabIndex = 59
        '
        'PCTB_Trash
        '
        Me.PCTB_Trash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PCTB_Trash.Image = CType(resources.GetObject("PCTB_Trash.Image"), System.Drawing.Image)
        Me.PCTB_Trash.Location = New System.Drawing.Point(203, 44)
        Me.PCTB_Trash.Name = "PCTB_Trash"
        Me.PCTB_Trash.Size = New System.Drawing.Size(28, 26)
        Me.PCTB_Trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCTB_Trash.TabIndex = 65
        Me.PCTB_Trash.TabStop = False
        '
        'lblItemQuantity
        '
        Me.lblItemQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItemQuantity.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemQuantity.ForeColor = System.Drawing.Color.Black
        Me.lblItemQuantity.Location = New System.Drawing.Point(305, 44)
        Me.lblItemQuantity.Name = "lblItemQuantity"
        Me.lblItemQuantity.Size = New System.Drawing.Size(28, 25)
        Me.lblItemQuantity.TabIndex = 64
        Me.lblItemQuantity.Text = "0"
        Me.lblItemQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemCode
        '
        Me.lblItemCode.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemCode.ForeColor = System.Drawing.Color.Black
        Me.lblItemCode.Location = New System.Drawing.Point(3, 45)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(179, 25)
        Me.lblItemCode.TabIndex = 63
        Me.lblItemCode.Text = "Item Code"
        '
        'PCTB_Plus
        '
        Me.PCTB_Plus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PCTB_Plus.Image = CType(resources.GetObject("PCTB_Plus.Image"), System.Drawing.Image)
        Me.PCTB_Plus.Location = New System.Drawing.Point(271, 44)
        Me.PCTB_Plus.Name = "PCTB_Plus"
        Me.PCTB_Plus.Size = New System.Drawing.Size(28, 26)
        Me.PCTB_Plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCTB_Plus.TabIndex = 62
        Me.PCTB_Plus.TabStop = False
        '
        'PCTB_Minus
        '
        Me.PCTB_Minus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PCTB_Minus.Image = CType(resources.GetObject("PCTB_Minus.Image"), System.Drawing.Image)
        Me.PCTB_Minus.Location = New System.Drawing.Point(237, 44)
        Me.PCTB_Minus.Name = "PCTB_Minus"
        Me.PCTB_Minus.Size = New System.Drawing.Size(28, 26)
        Me.PCTB_Minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCTB_Minus.TabIndex = 61
        Me.PCTB_Minus.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(-1, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 37)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Options"
        '
        'BTN_Finish
        '
        Me.BTN_Finish.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Finish.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Finish.ForeColor = System.Drawing.Color.Black
        Me.BTN_Finish.Image = CType(resources.GetObject("BTN_Finish.Image"), System.Drawing.Image)
        Me.BTN_Finish.Location = New System.Drawing.Point(8, 91)
        Me.BTN_Finish.Name = "BTN_Finish"
        Me.BTN_Finish.Size = New System.Drawing.Size(325, 39)
        Me.BTN_Finish.TabIndex = 60
        Me.BTN_Finish.Text = "Order Finished"
        Me.BTN_Finish.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lbl_OrderSum)
        Me.Panel6.Controls.Add(Me.lblSubTotal)
        Me.Panel6.Controls.Add(Me.BTN_Print)
        Me.Panel6.Controls.Add(Me.lbl_sbttl)
        Me.Panel6.Controls.Add(Me.lblNoItems)
        Me.Panel6.Location = New System.Drawing.Point(1020, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(343, 264)
        Me.Panel6.TabIndex = 53
        '
        'lbl_OrderSum
        '
        Me.lbl_OrderSum.AutoSize = True
        Me.lbl_OrderSum.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_OrderSum.Location = New System.Drawing.Point(-1, 5)
        Me.lbl_OrderSum.Name = "lbl_OrderSum"
        Me.lbl_OrderSum.Size = New System.Drawing.Size(221, 37)
        Me.lbl_OrderSum.TabIndex = 55
        Me.lbl_OrderSum.Text = "Order Summary"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSubTotal.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubTotal.ForeColor = System.Drawing.Color.Black
        Me.lblSubTotal.Location = New System.Drawing.Point(182, 54)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(156, 25)
        Me.lblSubTotal.TabIndex = 58
        Me.lblSubTotal.Text = "00.00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTN_Print
        '
        Me.BTN_Print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Print.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Print.ForeColor = System.Drawing.Color.Black
        Me.BTN_Print.Image = CType(resources.GetObject("BTN_Print.Image"), System.Drawing.Image)
        Me.BTN_Print.Location = New System.Drawing.Point(8, 217)
        Me.BTN_Print.Name = "BTN_Print"
        Me.BTN_Print.Size = New System.Drawing.Size(325, 39)
        Me.BTN_Print.TabIndex = 39
        Me.BTN_Print.Text = "Receipt-Out"
        Me.BTN_Print.UseVisualStyleBackColor = True
        '
        'lbl_sbttl
        '
        Me.lbl_sbttl.AutoSize = True
        Me.lbl_sbttl.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_sbttl.ForeColor = System.Drawing.Color.Gray
        Me.lbl_sbttl.Location = New System.Drawing.Point(3, 54)
        Me.lbl_sbttl.Name = "lbl_sbttl"
        Me.lbl_sbttl.Size = New System.Drawing.Size(84, 25)
        Me.lbl_sbttl.TabIndex = 56
        Me.lbl_sbttl.Text = "Subtotal"
        '
        'lblNoItems
        '
        Me.lblNoItems.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoItems.AutoSize = True
        Me.lblNoItems.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblNoItems.ForeColor = System.Drawing.Color.Gray
        Me.lblNoItems.Location = New System.Drawing.Point(83, 54)
        Me.lblNoItems.Name = "lblNoItems"
        Me.lblNoItems.Size = New System.Drawing.Size(88, 25)
        Me.lblNoItems.TabIndex = 57
        Me.lblNoItems.Text = "(0 Items)"
        '
        'DGV_receipt
        '
        Me.DGV_receipt.AllowUserToAddRows = False
        Me.DGV_receipt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DGV_receipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_receipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_receipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdID, Me.Code, Me.Make, Me.Model, Me.Year, Me.Description, Me.Placement, Me.Brand, Me.GrossPrice, Me.NetPrice, Me.Quantity, Me.Photo})
        Me.DGV_receipt.Location = New System.Drawing.Point(4, 6)
        Me.DGV_receipt.Name = "DGV_receipt"
        Me.DGV_receipt.RowHeadersVisible = False
        Me.DGV_receipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_receipt.Size = New System.Drawing.Size(1012, 612)
        Me.DGV_receipt.TabIndex = 0
        '
        'ProdID
        '
        Me.ProdID.HeaderText = "Product ID"
        Me.ProdID.Name = "ProdID"
        Me.ProdID.Visible = False
        '
        'Code
        '
        Me.Code.HeaderText = "Product Code"
        Me.Code.Name = "Code"
        Me.Code.Visible = False
        '
        'Make
        '
        Me.Make.HeaderText = "Make"
        Me.Make.Name = "Make"
        Me.Make.Visible = False
        '
        'Model
        '
        Me.Model.HeaderText = "Model"
        Me.Model.Name = "Model"
        Me.Model.Visible = False
        '
        'Year
        '
        Me.Year.HeaderText = "Year"
        Me.Year.Name = "Year"
        Me.Year.Visible = False
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Visible = False
        Me.Description.Width = 150
        '
        'Placement
        '
        Me.Placement.HeaderText = "Placement"
        Me.Placement.Name = "Placement"
        Me.Placement.Visible = False
        '
        'Brand
        '
        Me.Brand.HeaderText = "Brand"
        Me.Brand.Name = "Brand"
        Me.Brand.Visible = False
        '
        'GrossPrice
        '
        Me.GrossPrice.HeaderText = "GP"
        Me.GrossPrice.Name = "GrossPrice"
        Me.GrossPrice.Visible = False
        '
        'NetPrice
        '
        Me.NetPrice.HeaderText = "Price Per Item"
        Me.NetPrice.Name = "NetPrice"
        Me.NetPrice.Visible = False
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Stocks Available"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Visible = False
        '
        'Photo
        '
        Me.Photo.HeaderText = "Photo"
        Me.Photo.Name = "Photo"
        Me.Photo.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Venus Rising Rg", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(214, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "CART"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Venus Rising Rg", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(214, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "SHOPPING"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Venus Rising Rg", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 33)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "HEFFLOX"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1367, 84)
        Me.Panel2.TabIndex = 20
        '
        'PCTB_Back
        '
        Me.PCTB_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PCTB_Back.Image = CType(resources.GetObject("PCTB_Back.Image"), System.Drawing.Image)
        Me.PCTB_Back.Location = New System.Drawing.Point(0, 0)
        Me.PCTB_Back.Name = "PCTB_Back"
        Me.PCTB_Back.Size = New System.Drawing.Size(28, 26)
        Me.PCTB_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCTB_Back.TabIndex = 15
        Me.PCTB_Back.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PCTB_Back)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 26)
        Me.Panel5.TabIndex = 20
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Panel5)
        Me.panelTop.Controls.Add(Me.Panel2)
        Me.panelTop.Controls.Add(Me.Panel1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1367, 32)
        Me.panelTop.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.PCTB_Min)
        Me.Panel1.Controls.Add(Me.PCTB_Close)
        Me.Panel1.Controls.Add(Me.PCTB_Max)
        Me.Panel1.Controls.Add(Me.PCTBX_Normal)
        Me.Panel1.Location = New System.Drawing.Point(583, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 26)
        Me.Panel1.TabIndex = 19
        '
        'PCTB_Min
        '
        Me.PCTB_Min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PCTB_Min.Image = CType(resources.GetObject("PCTB_Min.Image"), System.Drawing.Image)
        Me.PCTB_Min.Location = New System.Drawing.Point(0, 0)
        Me.PCTB_Min.Name = "PCTB_Min"
        Me.PCTB_Min.Size = New System.Drawing.Size(28, 26)
        Me.PCTB_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCTB_Min.TabIndex = 15
        Me.PCTB_Min.TabStop = False
        '
        'PCTB_Close
        '
        Me.PCTB_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PCTB_Close.Image = CType(resources.GetObject("PCTB_Close.Image"), System.Drawing.Image)
        Me.PCTB_Close.Location = New System.Drawing.Point(172, 0)
        Me.PCTB_Close.Name = "PCTB_Close"
        Me.PCTB_Close.Size = New System.Drawing.Size(28, 26)
        Me.PCTB_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCTB_Close.TabIndex = 17
        Me.PCTB_Close.TabStop = False
        '
        'PCTB_Max
        '
        Me.PCTB_Max.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PCTB_Max.Image = CType(resources.GetObject("PCTB_Max.Image"), System.Drawing.Image)
        Me.PCTB_Max.Location = New System.Drawing.Point(114, 0)
        Me.PCTB_Max.Name = "PCTB_Max"
        Me.PCTB_Max.Size = New System.Drawing.Size(28, 26)
        Me.PCTB_Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCTB_Max.TabIndex = 16
        Me.PCTB_Max.TabStop = False
        '
        'PCTBX_Normal
        '
        Me.PCTBX_Normal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PCTBX_Normal.Image = CType(resources.GetObject("PCTBX_Normal.Image"), System.Drawing.Image)
        Me.PCTBX_Normal.Location = New System.Drawing.Point(56, 0)
        Me.PCTBX_Normal.Name = "PCTBX_Normal"
        Me.PCTBX_Normal.Size = New System.Drawing.Size(28, 26)
        Me.PCTBX_Normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCTBX_Normal.TabIndex = 18
        Me.PCTBX_Normal.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1367, 53)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(519, 37)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(324, 48)
        Me.Panel4.TabIndex = 39
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(0, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1367, 53)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'Shopping_Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 706)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.MinimumSize = New System.Drawing.Size(1383, 722)
        Me.Name = "Shopping_Cart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PCTB_Trash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTB_Plus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTB_Minus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DGV_receipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTB_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PCTB_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTB_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTB_Max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTBX_Normal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PCTB_Back As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PCTB_Min As PictureBox
    Friend WithEvents PCTB_Close As PictureBox
    Friend WithEvents PCTB_Max As PictureBox
    Friend WithEvents PCTBX_Normal As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DGV_receipt As DataGridView
    Friend WithEvents BTN_Print As Button
    Friend WithEvents ProdID As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Make As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents Year As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Placement As DataGridViewTextBoxColumn
    Friend WithEvents Brand As DataGridViewTextBoxColumn
    Friend WithEvents GrossPrice As DataGridViewTextBoxColumn
    Friend WithEvents NetPrice As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Photo As DataGridViewImageColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_OrderSum As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblNoItems As Label
    Friend WithEvents lbl_sbttl As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_Finish As Button
    Friend WithEvents lblItemQuantity As Label
    Friend WithEvents lblItemCode As Label
    Friend WithEvents PCTB_Plus As PictureBox
    Friend WithEvents PCTB_Minus As PictureBox
    Friend WithEvents PCTB_Trash As PictureBox
End Class

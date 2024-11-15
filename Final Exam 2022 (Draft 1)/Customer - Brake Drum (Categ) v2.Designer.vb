<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Brake_Drum__Categ__v2
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Brake_Drum__Categ__v2))
        Me.Photo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NetPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrossPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Placement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Make = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoOfItems = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTN_STC = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DGV_Layout = New System.Windows.Forms.DataGridView()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PCTB_Back = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TXTBX_Search = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4.SuspendLayout()
        CType(Me.DGV_Layout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PCTB_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Photo
        '
        Me.Photo.HeaderText = "Photo"
        Me.Photo.Name = "Photo"
        Me.Photo.Visible = False
        '
        'NetPrice
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NetPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.NetPrice.HeaderText = "Price Per Item"
        Me.NetPrice.Name = "NetPrice"
        '
        'GrossPrice
        '
        Me.GrossPrice.HeaderText = "GP"
        Me.GrossPrice.Name = "GrossPrice"
        Me.GrossPrice.Visible = False
        '
        'Brand
        '
        Me.Brand.HeaderText = "Brand"
        Me.Brand.Name = "Brand"
        '
        'Placement
        '
        Me.Placement.HeaderText = "Placement"
        Me.Placement.Name = "Placement"
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        '
        'Year
        '
        Me.Year.HeaderText = "Year"
        Me.Year.Name = "Year"
        '
        'Model
        '
        Me.Model.HeaderText = "Model"
        Me.Model.Name = "Model"
        '
        'Make
        '
        Me.Make.HeaderText = "Make"
        Me.Make.Name = "Make"
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        '
        'NoOfItems
        '
        Me.NoOfItems.HeaderText = "Product ID"
        Me.NoOfItems.Name = "NoOfItems"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Carted"
        Me.Column1.Name = "Column1"
        '
        'BTN_STC
        '
        Me.BTN_STC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_STC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_STC.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_STC.Location = New System.Drawing.Point(906, 510)
        Me.BTN_STC.Name = "BTN_STC"
        Me.BTN_STC.Size = New System.Drawing.Size(141, 39)
        Me.BTN_STC.TabIndex = 43
        Me.BTN_STC.Text = "Send to Cart"
        Me.BTN_STC.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(3, 1)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(72, 37)
        Me.lbltotal.TabIndex = 17
        Me.lbltotal.Text = "0.00"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.Controls.Add(Me.lbltotal)
        Me.Panel4.Location = New System.Drawing.Point(528, 509)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(221, 41)
        Me.Panel4.TabIndex = 42
        '
        'DGV_Layout
        '
        Me.DGV_Layout.AllowUserToAddRows = False
        Me.DGV_Layout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DGV_Layout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Layout.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Layout.ColumnHeadersHeight = 30
        Me.DGV_Layout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Layout.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.NoOfItems, Me.Code, Me.Make, Me.Model, Me.Year, Me.Description, Me.Placement, Me.Brand, Me.GrossPrice, Me.NetPrice, Me.Quantity, Me.Photo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Layout.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Layout.Location = New System.Drawing.Point(528, 39)
        Me.DGV_Layout.Name = "DGV_Layout"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Layout.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Layout.RowHeadersVisible = False
        Me.DGV_Layout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Layout.Size = New System.Drawing.Size(519, 465)
        Me.DGV_Layout.TabIndex = 41
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity Available"
        Me.Quantity.Name = "Quantity"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Brake Drum"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1367, 84)
        Me.Panel2.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(429, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 26)
        Me.Panel1.TabIndex = 19
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
        'TXTBX_Search
        '
        Me.TXTBX_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTBX_Search.Location = New System.Drawing.Point(3, 3)
        Me.TXTBX_Search.Name = "TXTBX_Search"
        Me.TXTBX_Search.Size = New System.Drawing.Size(415, 20)
        Me.TXTBX_Search.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.TXTBX_Search)
        Me.Panel3.Location = New System.Drawing.Point(635, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(421, 26)
        Me.Panel3.TabIndex = 21
        '
        'panelTop
        '
        Me.panelTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Panel3)
        Me.panelTop.Controls.Add(Me.Panel5)
        Me.panelTop.Controls.Add(Me.Panel2)
        Me.panelTop.Controls.Add(Me.Panel1)
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1059, 32)
        Me.panelTop.TabIndex = 39
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 39)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(519, 512)
        Me.FlowLayoutPanel1.TabIndex = 40
        '
        'Brake_Drum__Categ__v2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1059, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTN_STC)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DGV_Layout)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Brake_Drum__Categ__v2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGV_Layout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PCTB_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Photo As DataGridViewImageColumn
    Friend WithEvents NetPrice As DataGridViewTextBoxColumn
    Friend WithEvents GrossPrice As DataGridViewTextBoxColumn
    Friend WithEvents Brand As DataGridViewTextBoxColumn
    Friend WithEvents Placement As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Year As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents Make As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents NoOfItems As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents BTN_STC As Button
    Friend WithEvents lbltotal As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DGV_Layout As DataGridView
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PCTB_Back As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TXTBX_Search As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class

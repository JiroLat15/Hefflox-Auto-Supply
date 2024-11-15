<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Brake_Fluid__Categ__C
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Brake_Fluid__Categ__C))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PCTB_Back = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGV_BFC = New System.Windows.Forms.DataGridView()
        Me.Photo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PCTB_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_BFC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Brake Fluid"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Panel5)
        Me.panelTop.Controls.Add(Me.Panel2)
        Me.panelTop.Controls.Add(Me.Panel1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1059, 32)
        Me.panelTop.TabIndex = 37
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PCTB_Back)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 26)
        Me.Panel5.TabIndex = 20
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
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1367, 84)
        Me.Panel2.TabIndex = 20
        '
        'DGV_BFC
        '
        Me.DGV_BFC.AllowUserToAddRows = False
        Me.DGV_BFC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_BFC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_BFC.ColumnHeadersHeight = 30
        Me.DGV_BFC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_BFC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Photo, Me.Code, Me.Description, Me.Brand, Me.NetPrice, Me.Quantity})
        Me.DGV_BFC.Location = New System.Drawing.Point(0, 42)
        Me.DGV_BFC.Name = "DGV_BFC"
        Me.DGV_BFC.RowHeadersVisible = False
        Me.DGV_BFC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_BFC.Size = New System.Drawing.Size(1059, 510)
        Me.DGV_BFC.TabIndex = 36
        '
        'Photo
        '
        Me.Photo.HeaderText = "Image"
        Me.Photo.Name = "Photo"
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.MinimumWidth = 8
        Me.Description.Name = "Description"
        '
        'Brand
        '
        Me.Brand.HeaderText = "Brand"
        Me.Brand.Name = "Brand"
        '
        'NetPrice
        '
        Me.NetPrice.HeaderText = "Price"
        Me.NetPrice.Name = "NetPrice"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Stock"
        Me.Quantity.Name = "Quantity"
        '
        'Brake_Fluid__Categ__C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1059, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.DGV_BFC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Brake_Fluid__Categ__C"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PCTB_Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_BFC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelTop As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PCTB_Back As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGV_BFC As DataGridView
    Friend WithEvents Photo As DataGridViewImageColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Brand As DataGridViewTextBoxColumn
    Friend WithEvents NetPrice As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
End Class

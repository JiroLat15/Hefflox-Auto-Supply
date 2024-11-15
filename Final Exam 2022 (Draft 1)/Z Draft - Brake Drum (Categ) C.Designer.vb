<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Brake_Drum__Categ__C
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Brake_Drum__Categ__C))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PCTB_Back = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Make = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Photo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Placement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_BDC = New System.Windows.Forms.DataGridView()
        CType(Me.PCTB_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_BDC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Brake Drum"
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
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Panel5)
        Me.panelTop.Controls.Add(Me.Panel2)
        Me.panelTop.Controls.Add(Me.Panel1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1059, 32)
        Me.panelTop.TabIndex = 35
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
        'Quantity
        '
        Me.Quantity.HeaderText = "Stock"
        Me.Quantity.Name = "Quantity"
        '
        'NetPrice
        '
        Me.NetPrice.HeaderText = "Price"
        Me.NetPrice.Name = "NetPrice"
        '
        'Brand
        '
        Me.Brand.HeaderText = "Brand"
        Me.Brand.Name = "Brand"
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.MinimumWidth = 8
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
        'Photo
        '
        Me.Photo.HeaderText = "Image"
        Me.Photo.Name = "Photo"
        '
        'Placement
        '
        Me.Placement.HeaderText = "Placement"
        Me.Placement.Name = "Placement"
        '
        'DGV_BDC
        '
        Me.DGV_BDC.AllowUserToAddRows = False
        Me.DGV_BDC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_BDC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_BDC.ColumnHeadersHeight = 30
        Me.DGV_BDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_BDC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Photo, Me.Code, Me.Make, Me.Model, Me.Year, Me.Description, Me.Placement, Me.Brand, Me.NetPrice, Me.Quantity})
        Me.DGV_BDC.Location = New System.Drawing.Point(0, 42)
        Me.DGV_BDC.Name = "DGV_BDC"
        Me.DGV_BDC.RowHeadersVisible = False
        Me.DGV_BDC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_BDC.Size = New System.Drawing.Size(1059, 510)
        Me.DGV_BDC.TabIndex = 34
        '
        'Brake_Drum__Categ__C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1059, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.DGV_BDC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Brake_Drum__Categ__C"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PCTB_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_BDC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PCTB_Back As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents NetPrice As DataGridViewTextBoxColumn
    Friend WithEvents Brand As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Year As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents Make As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Photo As DataGridViewImageColumn
    Friend WithEvents Placement As DataGridViewTextBoxColumn
    Friend WithEvents DGV_BDC As DataGridView
End Class

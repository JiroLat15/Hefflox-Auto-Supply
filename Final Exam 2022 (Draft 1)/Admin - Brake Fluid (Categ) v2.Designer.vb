<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin___Brake_Fluid__Categ__v2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin___Brake_Fluid__Categ__v2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTBX_SID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BTN_Browse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DGV_PT = New System.Windows.Forms.DataGridView()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.BTN_Edit = New System.Windows.Forms.Button()
        Me.BTN_Add = New System.Windows.Forms.Button()
        Me.TXTBX_Q = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTBX_NPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTBX_GPrice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTBX_Brand = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTBX_Placement = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TXTBX_Description = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTBX_Year = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTBX_Model = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTBX_Make = New System.Windows.Forms.TextBox()
        Me.TXTBX_Code = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PCTB_Back = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.LBL_ProdID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_PT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PCTB_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(437, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 26)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Brake Fluid"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(564, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 25)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Product ID:"
        '
        'TXTBX_SID
        '
        Me.TXTBX_SID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_SID.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_SID.Location = New System.Drawing.Point(938, 69)
        Me.TXTBX_SID.Name = "TXTBX_SID"
        Me.TXTBX_SID.Size = New System.Drawing.Size(114, 33)
        Me.TXTBX_SID.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(821, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 25)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Supplier ID:"
        '
        'BTN_Browse
        '
        Me.BTN_Browse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Browse.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Browse.Location = New System.Drawing.Point(569, 507)
        Me.BTN_Browse.Name = "BTN_Browse"
        Me.BTN_Browse.Size = New System.Drawing.Size(87, 34)
        Me.BTN_Browse.TabIndex = 30
        Me.BTN_Browse.Text = "Browse"
        Me.BTN_Browse.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(569, 381)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'DGV_PT
        '
        Me.DGV_PT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DGV_PT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PT.Location = New System.Drawing.Point(569, 108)
        Me.DGV_PT.Name = "DGV_PT"
        Me.DGV_PT.Size = New System.Drawing.Size(483, 267)
        Me.DGV_PT.TabIndex = 28
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Delete.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Delete.Location = New System.Drawing.Point(451, 507)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(87, 34)
        Me.BTN_Delete.TabIndex = 25
        Me.BTN_Delete.Text = "Delete"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Edit
        '
        Me.BTN_Edit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Edit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Edit.Location = New System.Drawing.Point(358, 507)
        Me.BTN_Edit.Name = "BTN_Edit"
        Me.BTN_Edit.Size = New System.Drawing.Size(87, 34)
        Me.BTN_Edit.TabIndex = 24
        Me.BTN_Edit.Text = "Edit"
        Me.BTN_Edit.UseVisualStyleBackColor = True
        '
        'BTN_Add
        '
        Me.BTN_Add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Add.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Add.Location = New System.Drawing.Point(265, 507)
        Me.BTN_Add.Name = "BTN_Add"
        Me.BTN_Add.Size = New System.Drawing.Size(87, 34)
        Me.BTN_Add.TabIndex = 23
        Me.BTN_Add.Text = "Add"
        Me.BTN_Add.UseVisualStyleBackColor = True
        '
        'TXTBX_Q
        '
        Me.TXTBX_Q.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_Q.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_Q.Location = New System.Drawing.Point(187, 459)
        Me.TXTBX_Q.Name = "TXTBX_Q"
        Me.TXTBX_Q.Size = New System.Drawing.Size(351, 33)
        Me.TXTBX_Q.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 462)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 25)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "QUANTITY"
        '
        'TXTBX_NPrice
        '
        Me.TXTBX_NPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_NPrice.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_NPrice.Location = New System.Drawing.Point(187, 420)
        Me.TXTBX_NPrice.Name = "TXTBX_NPrice"
        Me.TXTBX_NPrice.Size = New System.Drawing.Size(351, 33)
        Me.TXTBX_NPrice.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 423)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 25)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "NET PRICE"
        '
        'TXTBX_GPrice
        '
        Me.TXTBX_GPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_GPrice.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_GPrice.Location = New System.Drawing.Point(187, 381)
        Me.TXTBX_GPrice.Name = "TXTBX_GPrice"
        Me.TXTBX_GPrice.Size = New System.Drawing.Size(351, 33)
        Me.TXTBX_GPrice.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "GROSS PRICE"
        '
        'TXTBX_Brand
        '
        Me.TXTBX_Brand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_Brand.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_Brand.Location = New System.Drawing.Point(187, 342)
        Me.TXTBX_Brand.Name = "TXTBX_Brand"
        Me.TXTBX_Brand.Size = New System.Drawing.Size(351, 33)
        Me.TXTBX_Brand.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "BRAND"
        '
        'TXTBX_Placement
        '
        Me.TXTBX_Placement.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_Placement.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_Placement.Location = New System.Drawing.Point(187, 303)
        Me.TXTBX_Placement.Name = "TXTBX_Placement"
        Me.TXTBX_Placement.Size = New System.Drawing.Size(351, 33)
        Me.TXTBX_Placement.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "PLACEMENT"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoScroll = True
        Me.Panel3.AutoSize = True
        Me.Panel3.Controls.Add(Me.LBL_ProdID)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.TXTBX_SID)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.BTN_Browse)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.DGV_PT)
        Me.Panel3.Controls.Add(Me.BTN_Delete)
        Me.Panel3.Controls.Add(Me.BTN_Edit)
        Me.Panel3.Controls.Add(Me.BTN_Add)
        Me.Panel3.Controls.Add(Me.TXTBX_Q)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.TXTBX_NPrice)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.TXTBX_GPrice)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.TXTBX_Brand)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TXTBX_Placement)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.TXTBX_Description)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TXTBX_Year)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.TXTBX_Model)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TXTBX_Make)
        Me.Panel3.Controls.Add(Me.TXTBX_Code)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(-9, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1092, 598)
        Me.Panel3.TabIndex = 39
        '
        'TXTBX_Description
        '
        Me.TXTBX_Description.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_Description.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_Description.Location = New System.Drawing.Point(187, 264)
        Me.TXTBX_Description.Name = "TXTBX_Description"
        Me.TXTBX_Description.Size = New System.Drawing.Size(351, 33)
        Me.TXTBX_Description.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "DESCRIPTION"
        '
        'TXTBX_Year
        '
        Me.TXTBX_Year.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_Year.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_Year.Location = New System.Drawing.Point(187, 225)
        Me.TXTBX_Year.Name = "TXTBX_Year"
        Me.TXTBX_Year.Size = New System.Drawing.Size(351, 33)
        Me.TXTBX_Year.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "YEAR"
        '
        'TXTBX_Model
        '
        Me.TXTBX_Model.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_Model.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_Model.Location = New System.Drawing.Point(187, 186)
        Me.TXTBX_Model.Name = "TXTBX_Model"
        Me.TXTBX_Model.Size = New System.Drawing.Size(351, 33)
        Me.TXTBX_Model.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MODEL"
        '
        'TXTBX_Make
        '
        Me.TXTBX_Make.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_Make.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_Make.Location = New System.Drawing.Point(187, 147)
        Me.TXTBX_Make.Name = "TXTBX_Make"
        Me.TXTBX_Make.Size = New System.Drawing.Size(351, 33)
        Me.TXTBX_Make.TabIndex = 5
        '
        'TXTBX_Code
        '
        Me.TXTBX_Code.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTBX_Code.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_Code.Location = New System.Drawing.Point(187, 108)
        Me.TXTBX_Code.Name = "TXTBX_Code"
        Me.TXTBX_Code.Size = New System.Drawing.Size(351, 33)
        Me.TXTBX_Code.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "MAKE"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CODE"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.panelTop.Size = New System.Drawing.Size(1075, 32)
        Me.panelTop.TabIndex = 38
        '
        'LBL_ProdID
        '
        Me.LBL_ProdID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBL_ProdID.AutoSize = True
        Me.LBL_ProdID.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ProdID.Location = New System.Drawing.Point(684, 72)
        Me.LBL_ProdID.Name = "LBL_ProdID"
        Me.LBL_ProdID.Size = New System.Drawing.Size(0, 25)
        Me.LBL_ProdID.TabIndex = 37
        '
        'Admin___Brake_Fluid__Categ__v2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1075, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin___Brake_Fluid__Categ__v2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_PT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PCTB_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TXTBX_SID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BTN_Browse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGV_PT As DataGridView
    Friend WithEvents BTN_Delete As Button
    Friend WithEvents BTN_Edit As Button
    Friend WithEvents BTN_Add As Button
    Friend WithEvents TXTBX_Q As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTBX_NPrice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTBX_GPrice As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTBX_Brand As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTBX_Placement As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TXTBX_Description As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTBX_Year As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTBX_Model As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTBX_Make As TextBox
    Friend WithEvents TXTBX_Code As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PCTB_Back As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents panelTop As Panel
    Friend WithEvents LBL_ProdID As Label
End Class

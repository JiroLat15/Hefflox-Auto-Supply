<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer___Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer___Main_Menu))
        Me.PCTB_Min = New System.Windows.Forms.PictureBox()
        Me.PCTB_Close = New System.Windows.Forms.PictureBox()
        Me.PCTBX_Normal = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PCTB_Max = New System.Windows.Forms.PictureBox()
        Me.PCTB_Bin = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BTN_CEnt = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_ExitM = New System.Windows.Forms.Button()
        CType(Me.PCTB_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTB_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTBX_Normal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PCTB_Max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTB_Bin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.PCTB_Min)
        Me.Panel1.Controls.Add(Me.PCTB_Close)
        Me.Panel1.Controls.Add(Me.PCTB_Max)
        Me.Panel1.Controls.Add(Me.PCTBX_Normal)
        Me.Panel1.Location = New System.Drawing.Point(599, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 26)
        Me.Panel1.TabIndex = 19
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
        'PCTB_Bin
        '
        Me.PCTB_Bin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PCTB_Bin.Image = CType(resources.GetObject("PCTB_Bin.Image"), System.Drawing.Image)
        Me.PCTB_Bin.Location = New System.Drawing.Point(0, 0)
        Me.PCTB_Bin.Name = "PCTB_Bin"
        Me.PCTB_Bin.Size = New System.Drawing.Size(28, 26)
        Me.PCTB_Bin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCTB_Bin.TabIndex = 15
        Me.PCTB_Bin.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PCTB_Bin)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(55, 26)
        Me.Panel2.TabIndex = 20
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Panel2)
        Me.panelTop.Controls.Add(Me.Panel1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1383, 32)
        Me.panelTop.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Averta Demo", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(617, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 32)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Welcome to"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(341, 101)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(717, 217)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'BTN_CEnt
        '
        Me.BTN_CEnt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_CEnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BTN_CEnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CEnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_CEnt.Font = New System.Drawing.Font("Segoe UI Semibold", 35.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_CEnt.ForeColor = System.Drawing.Color.Khaki
        Me.BTN_CEnt.Location = New System.Drawing.Point(472, 344)
        Me.BTN_CEnt.Name = "BTN_CEnt"
        Me.BTN_CEnt.Size = New System.Drawing.Size(454, 92)
        Me.BTN_CEnt.TabIndex = 16
        Me.BTN_CEnt.Text = "Enter"
        Me.BTN_CEnt.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1383, 722)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 35.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Khaki
        Me.Button1.Location = New System.Drawing.Point(472, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(454, 92)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Help"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTN_ExitM
        '
        Me.BTN_ExitM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_ExitM.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BTN_ExitM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ExitM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_ExitM.Font = New System.Drawing.Font("Segoe UI Semibold", 35.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_ExitM.ForeColor = System.Drawing.Color.Khaki
        Me.BTN_ExitM.Location = New System.Drawing.Point(472, 540)
        Me.BTN_ExitM.Name = "BTN_ExitM"
        Me.BTN_ExitM.Size = New System.Drawing.Size(454, 92)
        Me.BTN_ExitM.TabIndex = 31
        Me.BTN_ExitM.Text = "Exit"
        Me.BTN_ExitM.UseVisualStyleBackColor = False
        '
        'Customer___Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1383, 722)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTN_ExitM)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BTN_CEnt)
        Me.Controls.Add(Me.PictureBox5)
        Me.MinimumSize = New System.Drawing.Size(1383, 722)
        Me.Name = "Customer___Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PCTB_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTB_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTBX_Normal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PCTB_Max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTB_Bin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PCTB_Min As PictureBox
    Friend WithEvents PCTB_Close As PictureBox
    Friend WithEvents PCTBX_Normal As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PCTB_Max As PictureBox
    Friend WithEvents PCTB_Bin As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BTN_CEnt As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_ExitM As Button
End Class

Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Security
Imports System.Security.Permissions
Imports Mysqlx.XDevAPI.Relational
Imports System.Diagnostics.Eventing
Imports Org.BouncyCastle.Asn1.Ocsp
Imports System.Windows
Imports Org.BouncyCastle.Utilities.Collections

Public Class Brake_Fluid__Categ__C_v2
    Dim cn As New MySqlConnection
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim _tot As Double

    Private WithEvents pic As New PictureBox
    Private WithEvents lblC As New Label
    Private WithEvents lblPl As New Label
    Private Sub Brake_Fluid__Categ__C_v2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection
        With cn
            .ConnectionString = "Server = localhost; userid = root; database = hefflox"
        End With
        LoadData()
    End Sub

    Sub LoadData()
        FlowLayoutPanel1.Controls.Clear()
        cn.Open()
        cm = New MySqlCommand("Select NoOfItems, Photo, Code, Description from brake_fluid_v2 where Code like '" & TXTBX_Search.Text & "%' order by Code", cn)
        dr = cm.ExecuteReader
        While dr.Read

            Dim len As Long = dr.GetBytes(1, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(1, 0, array, 0, CInt(len))
            pic = New PictureBox
            pic.Width = 120
            pic.Height = 120
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("NoOfItems").ToString

            lblC = New Label
            lblC.ForeColor = Color.White
            lblC.BackColor = Color.FromArgb(156, 156, 156)
            lblC.Dock = DockStyle.Top
            lblC.Tag = dr.Item("NoOfItems").ToString

            lblPl = New Label
            lblPl.ForeColor = Color.White
            lblPl.BackColor = Color.FromArgb(156, 156, 156)
            lblPl.Dock = DockStyle.Bottom
            lblPl.Tag = dr.Item("NoOfItems").ToString

            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lblC.Text = dr.Item("Code").ToString
            lblPl.Text = dr.Item("Description").ToString

            pic.Controls.Add(lblC)
            pic.Controls.Add(lblPl)

            FlowLayoutPanel1.Controls.Add(pic)
            AddHandler pic.Click, AddressOf lblC_Click
            AddHandler lblC.Click, AddressOf lblC_Click
            AddHandler lblPl.Click, AddressOf lblC_Click


        End While
        cn.Close()
    End Sub

    Public Sub lblC_Click(sender As Object, e As EventArgs)
        'gawa gawa ko lang to, maaaring mali, maaaring may chance na ganto talaga code, maaaring copium
        Try
            If MsgBox("Add to Cart?", vbYesNo + vbQuestion, "Selected Item") = vbYes Then


                cn.Open()
                cm = New MySqlCommand("Select * from brake_fluid_v2 where NoOfItems like '" & sender.tag.ToString & "'", cn)
                dr = cm.ExecuteReader

                While dr.Read
                    _tot += CDbl(dr.Item("NetPrice").ToString)
                    DGV_Layout.Rows.Add(DGV_Layout.Rows.Count + 1, dr.Item("NoOfItems").ToString, dr.Item("Code").ToString, dr.Item("Make").ToString, dr.Item("Model").ToString, dr.Item("Year").ToString, dr.Item("Description").ToString, dr.Item("Placement").ToString, dr.Item("Brand").ToString, dr.Item("GrossPrice").ToString, Format(CDbl(dr.Item("NetPrice").ToString), "#,##0.00#"), dr.Item("Quantity").ToString, dr.Item("Photo").ToString, MySqlDbType.Blob)
                End While
                dr.Close()
                cn.Close()
                lbltotal.Text = Format(_tot, "#,##.00")
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub PCTB_Back_Click(sender As Object, e As EventArgs) Handles PCTB_Back.Click
        Me.Close()
    End Sub

    Private Sub TXTBX_Search_TextChanged(sender As Object, e As EventArgs) Handles TXTBX_Search.TextChanged
        LoadData()
    End Sub

    Private Sub BTN_STC_Click(sender As Object, e As EventArgs) Handles BTN_STC.Click
        Dim cn As New MySqlConnection("Server = localhost; userid = root; database = hefflox")
        For Each row As DataGridViewRow In DGV_Layout.Rows

            Dim cm As New MySqlCommand("insert into hefflox.customer_orders(NoOfItems,Code,Make,Model,Year,Description,Placement,Brand,GrossPrice,NetPrice,Quantity,Photo) values (@NoOfItems,@Code,@Make,@Model,@Year,@Description,@Placement,@Brand,@GrossPrice,@NetPrice,@Quantity,@Photo)", cn)
            cm.Parameters.AddWithValue("NoOfItems", row.Cells("NoOfItems").Value)
            cm.Parameters.AddWithValue("Code", row.Cells("Code").Value)
            cm.Parameters.AddWithValue("Make", row.Cells("Make").Value)
            cm.Parameters.AddWithValue("Model", row.Cells("Model").Value)
            cm.Parameters.AddWithValue("Year", row.Cells("Year").Value)
            cm.Parameters.AddWithValue("Description", row.Cells("Description").Value)
            cm.Parameters.AddWithValue("Placement", row.Cells("Placement").Value)
            cm.Parameters.AddWithValue("Brand", row.Cells("Brand").Value)
            cm.Parameters.AddWithValue("GrossPrice", row.Cells("GrossPrice").Value)
            cm.Parameters.AddWithValue("NetPrice", row.Cells("NetPrice").Value)
            cm.Parameters.AddWithValue("Quantity", row.Cells("Quantity").Value)

            Dim memstr As New MemoryStream
            Brake_Fluid__Categ_.PictureBox1.Image.Save(memstr, Brake_Fluid__Categ_.PictureBox1.Image.RawFormat)
            cm.Parameters.Add("@Photo", MySqlDbType.Blob).Value = memstr.ToArray

            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
        Next
        DGV_Layout.Rows.Clear()
        MessageBox.Show("Items added to Cart Successfully.")

    End Sub

    Private Sub DGV_Layout_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Layout.CellContentClick

        End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
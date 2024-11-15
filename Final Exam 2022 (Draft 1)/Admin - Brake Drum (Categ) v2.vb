Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class Admin___Brake_Drum__Categ__v2
    Dim CONN As New MySqlConnection("server = localhost;userid = root;database = hefflox")
    Dim command As MySqlCommand

    Private Sub Bin1()
        Dim command As New MySqlCommand("SELECT * FROM hefflox.product_table WHERE ProdID >= 2000 AND ProdID < 3000 ORDER BY ProdID ASC", CONN)

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()
        adapter.Fill(table)
        DGV_PT.AllowUserToAddRows = False
        DGV_PT.RowTemplate.Height = 100

        Dim pic1 As New DataGridViewImageColumn
        DGV_PT.DataSource = table
        pic1 = DGV_PT.Columns(12)
        pic1.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub
    Private Sub BTN_Add_Click(sender As Object, e As EventArgs) Handles BTN_Add.Click
        Dim command As MySqlCommand
        Dim lastProdId As Integer = GetLastProdId(2000, 2999) ' Function to retrieve the last ProdID

        ' Determine the category based on the ProdID range
        If lastProdId >= 2000 AndAlso lastProdId < 3000 Then
            ' Category: Brake Drum
            lastProdId += 1 ' Increment the ProdID within the category range
        Else
            ' No previous entries or unknown category
            lastProdId = 2000 ' Start from the beginning for Brake Drum
        End If

        ' Prepare the SQL command with the updated ProdID
        command = New MySqlCommand("INSERT INTO hefflox.product_table(SuppID, ProdID, Code, Make, Model, Year, Description, Placement, Brand, GrossPrice, NetPrice, Quantity, Photo) VALUES (@SuppID, @ProdID, @Code, @Make, @Model, @Year, @Description, @Placement, @Brand, @GrossPrice, @NetPrice, @Quantity, @Photo)", CONN)
        command.Parameters.Add("@SuppID", MySqlDbType.VarChar).Value = TXTBX_SID.Text
        command.Parameters.Add("@ProdID", MySqlDbType.Int32).Value = lastProdId
        command.Parameters.Add("@Code", MySqlDbType.VarChar).Value = TXTBX_Code.Text
        command.Parameters.Add("@Make", MySqlDbType.VarChar).Value = TXTBX_Make.Text
        command.Parameters.Add("@Model", MySqlDbType.VarChar).Value = TXTBX_Model.Text
        command.Parameters.Add("@Year", MySqlDbType.VarChar).Value = TXTBX_Year.Text
        command.Parameters.Add("@Description", MySqlDbType.VarChar).Value = TXTBX_Description.Text
        command.Parameters.Add("@Placement", MySqlDbType.VarChar).Value = TXTBX_Placement.Text
        command.Parameters.Add("@Brand", MySqlDbType.VarChar).Value = TXTBX_Brand.Text
        command.Parameters.Add("@GrossPrice", MySqlDbType.VarChar).Value = TXTBX_GPrice.Text
        command.Parameters.Add("@NetPrice", MySqlDbType.VarChar).Value = TXTBX_NPrice.Text
        command.Parameters.Add("@Quantity", MySqlDbType.VarChar).Value = TXTBX_Q.Text
        'imaginary
        Dim memstr As New MemoryStream
        PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)
        command.Parameters.Add("@Photo", MySqlDbType.Blob).Value = memstr.ToArray

        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
        command.ExecuteNonQuery()
        MessageBox.Show("Item Added")
        CONN.Close()
        Bin1()

    End Sub
    Private Function GetLastProdId(categoryStart As Integer, categoryEnd As Integer) As Integer
        Dim command As New MySqlCommand("SELECT MAX(ProdID) FROM hefflox.product_table WHERE ProdID >= @CategoryStart AND ProdID <= @CategoryEnd", CONN)
        command.Parameters.Add("@CategoryStart", MySqlDbType.Int32).Value = categoryStart
        command.Parameters.Add("@CategoryEnd", MySqlDbType.Int32).Value = categoryEnd

        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If

        Dim result As Object = command.ExecuteScalar()
        CONN.Close()

        If result IsNot DBNull.Value Then
            Return Convert.ToInt32(result)
        Else
            Return 0
        End If
    End Function
    Private Sub BTN_Edit_Click(sender As Object, e As EventArgs) Handles BTN_Edit.Click
        Dim memstr As New MemoryStream
        PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)
        Dim img() As Byte
        img = memstr.ToArray()

        Dim update1 As String = "Update hefflox.product_table set SuppID='" & TXTBX_SID.Text & "',Code='" & TXTBX_Code.Text & "',Make='" & TXTBX_Make.Text & "',Model='" & TXTBX_Model.Text & "',Year='" & TXTBX_Year.Text & "',Description='" & TXTBX_Description.Text & "',Placement='" & TXTBX_Placement.Text & "',Brand='" & TXTBX_Brand.Text & "',GrossPrice='" & TXTBX_GPrice.Text & "',NetPrice='" & TXTBX_NPrice.Text & "',Quantity='" & TXTBX_Q.Text & "',Photo=@Photo where ProdID=" & LBL_ProdID.Text

        Dim command As New MySqlCommand(update1, CONN)
        command.Parameters.Add("@Photo", MySqlDbType.Blob).Value = img

        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If

        command.ExecuteNonQuery()
        MessageBox.Show("Item Edited")

        CONN.Close()

        Bin1()
    End Sub

    Private Sub PCTB_Back_Click(sender As Object, e As EventArgs) Handles PCTB_Back.Click
        Me.Close()
    End Sub

    Private Sub Admin___Brake_Drum__Categ__v2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bin1()
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        Dim delete1 As String = "Delete from hefflox.product_table where ProdID='" & LBL_ProdID.Text & "' "

        Dim command As New MySqlCommand(delete1, CONN)

        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
        command.ExecuteNonQuery()
        MessageBox.Show("Item Deleted")

        CONN.Close()

        Bin1()
    End Sub

    Private Sub BTN_Browse_Click(sender As Object, e As EventArgs) Handles BTN_Browse.Click
        Dim openfiledialog1 As New OpenFileDialog
        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"

        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openfiledialog1.FileName)
        End If
    End Sub
    Private Sub Admin___Brake_Drum__Categ__v2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PT.CellContentClick
        LBL_ProdID.Text = DGV_PT.CurrentRow.Cells(0).Value.ToString
        TXTBX_SID.Text = DGV_PT.CurrentRow.Cells(1).Value.ToString
        TXTBX_Code.Text = DGV_PT.CurrentRow.Cells(2).Value.ToString
        TXTBX_Make.Text = DGV_PT.CurrentRow.Cells(3).Value.ToString
        TXTBX_Model.Text = DGV_PT.CurrentRow.Cells(4).Value.ToString
        TXTBX_Year.Text = DGV_PT.CurrentRow.Cells(5).Value.ToString
        TXTBX_Description.Text = DGV_PT.CurrentRow.Cells(6).Value.ToString
        TXTBX_Placement.Text = DGV_PT.CurrentRow.Cells(7).Value.ToString
        TXTBX_Brand.Text = DGV_PT.CurrentRow.Cells(8).Value.ToString
        TXTBX_GPrice.Text = DGV_PT.CurrentRow.Cells(9).Value.ToString
        TXTBX_NPrice.Text = DGV_PT.CurrentRow.Cells(10).Value.ToString
        TXTBX_Q.Text = DGV_PT.CurrentRow.Cells(11).Value.ToString

        Dim img As Byte()
        img = DGV_PT.CurrentRow.Cells(12).Value

        Dim memstr As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(memstr)
    End Sub
End Class
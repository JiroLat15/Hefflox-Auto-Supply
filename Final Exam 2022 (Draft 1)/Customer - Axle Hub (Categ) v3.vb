Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Customer___Axle_Hub__Categ__v3
    Dim cn As New MySqlConnection
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim _tot As Double

    Private WithEvents pic As New PictureBox
    Private WithEvents lblC As New Label
    Private WithEvents lblPl As New Label
    Private dgvLayoutClicked As Boolean = False
    Private Sub Customer___Axle_Hub__Categ__v3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection
        With cn
            .ConnectionString = "Server = localhost; userid = root; database = hefflox"
        End With
        LoadData()
    End Sub
    Sub LoadData()
        FlowLayoutPanel1.Controls.Clear()
        cn.Open()
        cm = New MySqlCommand("SELECT ProdID, Photo, Code, Make, Model, Year, Placement, Description, Quantity FROM product_table WHERE (ProdID >= 1000 AND ProdID <= 1999) AND (ProdID LIKE '%" & TXTBX_Search.Text & "%' OR Code LIKE '%" & TXTBX_Search.Text & "%' OR Make LIKE '%" & TXTBX_Search.Text & "%' OR Model LIKE '%" & TXTBX_Search.Text & "%' OR Year LIKE '%" & TXTBX_Search.Text & "%' OR Placement LIKE '%" & TXTBX_Search.Text & "%' OR Description LIKE '%" & TXTBX_Search.Text & "%') ORDER BY ProdID", cn)
        dr = cm.ExecuteReader
        While dr.Read()
            Dim len As Long = dr.GetBytes(1, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(1, 0, array, 0, CInt(len))
            Dim pic As New PictureBox
            pic.Width = 120
            pic.Height = 120
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("ProdID").ToString()

            Dim lblC As New Label
            lblC.ForeColor = Color.White
            lblC.BackColor = Color.FromArgb(156, 156, 156)
            lblC.Dock = DockStyle.Top
            lblC.Tag = dr.Item("ProdID").ToString()

            Dim lblPl As New Label
            lblPl.ForeColor = Color.White
            lblPl.BackColor = Color.FromArgb(156, 156, 156)
            lblPl.Dock = DockStyle.Bottom
            lblPl.Tag = dr.Item("ProdID").ToString()

            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lblC.Text = dr.Item("Code").ToString()
            lblPl.Text = dr.Item("Description").ToString()

            pic.Controls.Add(lblC)
            pic.Controls.Add(lblPl)

            FlowLayoutPanel1.Controls.Add(pic)
            AddHandler pic.Click, AddressOf lblC_Click
            AddHandler lblC.Click, AddressOf lblC_Click
            AddHandler lblPl.Click, AddressOf lblC_Click
        End While

        dr.Close()
        cn.Close()
    End Sub
    Public Sub lblC_Click(sender As Object, e As EventArgs)
        Try
            If MsgBox("Add to Cart?", vbYesNo + vbQuestion, "Selected Item") = vbYes Then
                cn.Open()
                cm = New MySqlCommand("SELECT * FROM product_table WHERE ProdID = @ProdID", cn)
                cm.Parameters.AddWithValue("@ProdID", sender.Tag.ToString())
                dr = cm.ExecuteReader()

                While dr.Read()
                    Dim quantity As Integer = Integer.Parse(dr.Item("Quantity").ToString())
                    Dim existingQuantity As Integer = 0

                    ' Check if the item already exists in the DataGridView
                    Dim existingRowIndex As Integer = -1
                    For Each row As DataGridViewRow In DGV_Layout.Rows
                        Dim prodID As String = row.Cells("ProdID").Value.ToString()
                        If prodID = dr.Item("ProdID").ToString() Then
                            existingQuantity += Integer.Parse(row.Cells("Quantity").Value.ToString())
                            existingRowIndex = row.Index
                            Exit For ' Exit the loop once the item is found
                        End If
                    Next

                    If quantity <= 0 Then
                        MsgBox("Item is out of stock: " & dr.Item("Description").ToString(), vbExclamation)
                    ElseIf existingRowIndex <> -1 Then
                        If existingQuantity + 1 > quantity Then
                            MsgBox("Adding one more item exceeds the quantity limit for: " & dr.Item("Description").ToString(), vbExclamation)
                        Else
                            DGV_Layout.Rows(existingRowIndex).Cells("Quantity").Value = (existingQuantity + 1).ToString()
                            Dim netPrice As Double = CDbl(dr.Item("NetPrice").ToString())
                            Dim totalPrice As Double = existingQuantity * netPrice
                            _tot += netPrice
                        End If
                    Else
                        _tot += CDbl(dr.Item("NetPrice").ToString())
                        DGV_Layout.Rows.Add(DGV_Layout.Rows.Count + 1, dr.Item("ProdID").ToString(), dr.Item("Code").ToString(), dr.Item("Make").ToString(), dr.Item("Model").ToString(), dr.Item("Year").ToString(), dr.Item("Description").ToString(), dr.Item("Placement").ToString(), dr.Item("Brand").ToString(), dr.Item("GrossPrice").ToString(), Format(CDbl(dr.Item("NetPrice").ToString()), "#,##0.00#"), "1", dr.Item("Photo").ToString(), MySqlDbType.Blob)
                    End If
                End While

                dr.Close()
                cn.Close()
                lbltotal.Text = Format(_tot, "#,00.00")
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub PCTB_Back_Click(sender As Object, e As EventArgs) Handles PCTB_Back.Click
        Me.Hide()
        Hefflox___Home__Customer_.Show()
    End Sub
    Private Sub TXTBX_Search_TextChanged(sender As Object, e As EventArgs) Handles TXTBX_Search.TextChanged
        LoadData()
    End Sub

    Private Sub BTN_STC_Click(sender As Object, e As EventArgs) Handles BTN_STC.Click
        If DGV_Layout.Rows.Count = 0 Then
            lbltotal.Text = "00.00"
            MessageBox.Show("No items to add to cart.")
            Return
        End If

        Dim cn As New MySqlConnection("Server=localhost; userid=root; database=hefflox")

        Try
            cn.Open()
            _tot = 0 ' Reset the total price

            For Each row As DataGridViewRow In DGV_Layout.Rows
                Dim quantity As Integer = CInt(row.Cells("Quantity").Value)
                Dim prodId As Integer = CInt(row.Cells("ProdID").Value)

                ' Deduct the quantity from the product_table
                Dim deductQuery As String = "UPDATE product_table SET Quantity = Quantity - @Quantity WHERE ProdID = @ProdID AND Quantity >= @Quantity"
                Dim deductCmd As New MySqlCommand(deductQuery, cn)
                deductCmd.Parameters.AddWithValue("@Quantity", quantity)
                deductCmd.Parameters.AddWithValue("@ProdID", prodId)
                Dim rowsAffected As Integer = deductCmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    Dim existingItemQuery As String = "SELECT * FROM customer_orders WHERE Code = @Code"
                    Dim existingItemCmd As New MySqlCommand(existingItemQuery, cn)
                    existingItemCmd.Parameters.AddWithValue("@Code", row.Cells("Code").Value)
                    Dim existingItemReader As MySqlDataReader = existingItemCmd.ExecuteReader()

                    If existingItemReader.HasRows Then
                        ' Item already exists, update the existing row
                        existingItemReader.Read()
                        Dim existingItemId As Integer = existingItemReader.GetInt32("ProdID")
                        Dim existingItemQuantity As Integer = existingItemReader.GetInt32("Quantity")
                        existingItemReader.Close()

                        Dim updatedQuantity As Integer = existingItemQuantity + quantity

                        Dim updateCmd As New MySqlCommand("UPDATE customer_orders SET Quantity = @Quantity WHERE ProdID = @ProdID", cn)
                        updateCmd.Parameters.AddWithValue("@Quantity", updatedQuantity)
                        updateCmd.Parameters.AddWithValue("@ProdID", existingItemId)
                        updateCmd.ExecuteNonQuery()
                    Else
                        ' Item does not exist, insert a new row
                        existingItemReader.Close()

                        Dim cm As New MySqlCommand("INSERT INTO hefflox.customer_orders(ProdID, Code, Make, Model, Year, Description, Placement, Brand, GrossPrice, NetPrice, Quantity, Photo) VALUES (@ProdID, @Code, @Make, @Model, @Year, @Description, @Placement, @Brand, @GrossPrice, @NetPrice, @Quantity, @Photo)", cn)
                        cm.Parameters.AddWithValue("@ProdID", row.Cells("ProdID").Value)
                        cm.Parameters.AddWithValue("@Code", row.Cells("Code").Value)
                        cm.Parameters.AddWithValue("@Make", row.Cells("Make").Value)
                        cm.Parameters.AddWithValue("@Model", row.Cells("Model").Value)
                        cm.Parameters.AddWithValue("@Year", row.Cells("Year").Value)
                        cm.Parameters.AddWithValue("@Description", row.Cells("Description").Value)
                        cm.Parameters.AddWithValue("@Placement", row.Cells("Placement").Value)
                        cm.Parameters.AddWithValue("@Brand", row.Cells("Brand").Value)
                        cm.Parameters.AddWithValue("@GrossPrice", row.Cells("GrossPrice").Value)
                        cm.Parameters.AddWithValue("@NetPrice", row.Cells("NetPrice").Value)
                        cm.Parameters.AddWithValue("@Quantity", quantity)

                        Dim pictureBox As PictureBox = TryCast(row.Cells("Photo").Value, PictureBox)
                        If pictureBox IsNot Nothing Then
                            Dim memstr As New MemoryStream
                            pictureBox.Image.Save(memstr, pictureBox.Image.RawFormat)
                            cm.Parameters.Add("@Photo", MySqlDbType.Blob).Value = memstr.ToArray()
                        Else
                            cm.Parameters.AddWithValue("@Photo", DBNull.Value)
                        End If

                        cm.ExecuteNonQuery()
                    End If
                Else
                    MessageBox.Show("Insufficient quantity for the selected item: " & row.Cells("Code").Value.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Next

            DGV_Layout.Rows.Clear()
            lbltotal.Text = "00.00"
            MessageBox.Show("Items added to Cart Successfully.")
        Catch ex As MySqlException
            Dim errorMessage As String = "MySQL Exception: " & ex.Message & vbCrLf
            errorMessage += "Error code: " & ex.ErrorCode & vbCrLf
            errorMessage += "Error source: " & ex.Source & vbCrLf
            errorMessage += "Stack trace: " & ex.StackTrace & vbCrLf
            If ex.InnerException IsNot Nothing Then
                errorMessage += "Inner exception: " & ex.InnerException.Message
            End If
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Exception: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub BTN_RMV_Click(sender As Object, e As EventArgs) Handles BTN_RMV.Click
        If DGV_Layout.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DGV_Layout.SelectedRows(0).Index
            Dim selectedRow As DataGridViewRow = DGV_Layout.Rows(selectedRowIndex)

            ' Retrieve the quantity value from the selected row
            Dim quantity As Integer = CInt(selectedRow.Cells("Quantity").Value)

            ' Confirmation message box
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to remove 1 quantity of this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmation = DialogResult.Yes Then
                If quantity > 1 Then
                    ' Deduct 1 from the quantity of the selected item
                    selectedRow.Cells("Quantity").Value = (quantity - 1).ToString()
                Else
                    ' Remove the selected row from DGV_Layout if the quantity becomes zero
                    DGV_Layout.Rows.RemoveAt(selectedRowIndex)
                End If

                ' Reset the total variable
                _tot = 0

                ' Recalculate the total price
                For Each row As DataGridViewRow In DGV_Layout.Rows
                    Dim rowQuantity As Integer = CInt(row.Cells("Quantity").Value)
                    Dim rowPrice As Double = CDbl(row.Cells("NetPrice").Value)
                    _tot += rowQuantity * rowPrice
                Next

                lbltotal.Text = _tot.ToString("#,00.00")
            End If
        Else
            MessageBox.Show("Please select a row to remove.")
        End If
    End Sub
    Private Sub DGV_Layout_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_Layout.SelectionChanged
        If Not dgvLayoutClicked Then
            ' Calculate the total price from the existing rows in DGV_Layout
            _tot = 0 ' Reset the total price

            For Each row As DataGridViewRow In DGV_Layout.Rows
                Dim price As Double
                If Double.TryParse(row.Cells("NetPrice").Value.ToString(), price) Then
                    _tot += price
                End If
            Next

            lbltotal.Text = Format(_tot, "#,00.00")
        Else
            dgvLayoutClicked = False ' Reset the flag
        End If
    End Sub
End Class
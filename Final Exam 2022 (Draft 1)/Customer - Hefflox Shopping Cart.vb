Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports Org.BouncyCastle.Utilities.IO

Public Class Shopping_Cart
    Dim MysqlConn As New MySqlConnection("server=localhost;userid=root;database=hefflox")
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Private availableStock As Integer
    Private orderedQuantity As Integer


    Private Sub Shopping_Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideColumns()
        bin1()
        AddHandler DGV_receipt.CellClick, AddressOf DGV_receipt_CellClick
    End Sub
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DGV_receipt.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 700
    End Sub
    Private Sub BTN_Print_Click(sender As Object, e As EventArgs) Handles BTN_Print.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14b As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "________________________________________________________________________"

        e.Graphics.DrawString("HEFFLOX AUTO SUPPLY", f14b, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Auto Parts Supply Store", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Owned & Operated by: Rolly A. Lat", f10, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Invoice #", f8, Brushes.Black, 50, 60)
        e.Graphics.DrawString(":", f8, Brushes.Black, 100, 60)
        e.Graphics.DrawString("Tel No: 740 - 8900", f8, Brushes.Black, 110, 60)

        e.Graphics.DrawString("Cashier ", f8, Brushes.Black, 72.5, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 112.5, 75)
        e.Graphics.DrawString("Jiro Y. Lat", f8, Brushes.Black, 122.5, 75)

        e.Graphics.DrawString("Date  :  " & Date.Now(), f8, Brushes.Black, 55, 90)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)

        ' Retrieve customer order details from the database
        Dim orderDetailsTable As DataTable = GetCustomerOrderDetails()

        ' Print customer order details
        Dim yPos As Integer = 120
        For Each row As DataRow In orderDetailsTable.Rows
            Dim code As String = row("Code").ToString()
            Dim make As String = row("Make").ToString()
            Dim model As String = row("Model").ToString()
            Dim year As String = row("Year").ToString()
            Dim description As String = row("Description").ToString()
            Dim brand As String = row("Brand").ToString()
            Dim netPrice As Decimal = Convert.ToDecimal(row("NetPrice"))
            Dim quantity As Integer = Convert.ToInt32(row("Quantity"))

            ' Format the customer order details line
            Dim orderLine As String = $"{code} x {quantity}"

            ' Draw the order line on the graphics context
            e.Graphics.DrawString(orderLine, f10, Brushes.Black, 10, yPos)

            ' Multiply the netPrice by quantity
            Dim totalAmount As Decimal = netPrice * quantity

            ' Format the customer order details line
            Dim orderLine2 As String = $"{totalAmount:C}"

            ' Draw the order line on the graphics context
            e.Graphics.DrawString(orderLine2, f10, Brushes.Black, 170, yPos)

            ' Increment the y-position for the next line
            yPos += 15
        Next

        ' Calculate the total quantity and subtotal price
        Dim totalQuantity As Integer = 0
        Dim subtotalPrice As Decimal = 0

        For Each row As DataRow In orderDetailsTable.Rows
            Dim quantity As Integer = Convert.ToInt32(row("Quantity"))
            Dim netPrice As Decimal = Convert.ToDecimal(row("NetPrice"))

            totalQuantity += quantity
            subtotalPrice += quantity * netPrice
        Next

        ' Print Total Amount Due (n)
        Dim totalAmountDueLine As String = $"Total Amount Due ({totalQuantity})"
        Dim totalAmountDueXPos As Single = 10
        Dim totalAmountDueYPos As Single = yPos + 20 ' Adjust the position accordingly

        e.Graphics.DrawString(totalAmountDueLine, f10b, Brushes.Black, totalAmountDueXPos, totalAmountDueYPos)

        ' Print Subtotal Price
        Dim subtotalPriceLine As String = subtotalPrice.ToString("C")
        Dim subtotalPriceXPos As Single = 170
        Dim subtotalPriceYPos As Single = totalAmountDueYPos

        e.Graphics.DrawString(subtotalPriceLine, f10b, Brushes.Black, subtotalPriceXPos, subtotalPriceYPos)

        ' Draw a line separator
        Dim lineSeparatorYPos As Single = subtotalPriceYPos + 15 ' Adjust the position accordingly

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, yPos)
        ' ... existing code ...

        ' Draw Customer Name and Signature
        Dim customerNameLine As String = "Customer Name: __________________"
        Dim customerSignatureLine As String = "Customer Signature: _______________"

        Dim customerInfoXPos As Single = 10
        Dim customerInfoYPos As Single = totalAmountDueYPos + 30 ' Adjust the position accordingly

        e.Graphics.DrawString(customerNameLine, f10, Brushes.Black, customerInfoXPos, customerInfoYPos)
        e.Graphics.DrawString(customerSignatureLine, f10, Brushes.Black, customerInfoXPos, customerInfoYPos + 15)

        ' Draw line separator
        Dim lineSeparatorYPos2 As Single = customerInfoYPos + 30 ' Adjust the position accordingly

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, lineSeparatorYPos2)

        ' Draw owner's copy text
        Dim ownersCopyText As String = "- THIS IS THE OWNER'S COPY OF THE RECEIPT -"
        Dim ownersCopyXPos As Single = (PD.DefaultPageSettings.PaperSize.Width - e.Graphics.MeasureString(ownersCopyText, f8).Width) / 2
        Dim ownersCopyYPos As Single = lineSeparatorYPos2 + 20 ' Adjust the position accordingly

        e.Graphics.DrawString(ownersCopyText, f8, Brushes.Black, 17, ownersCopyYPos)

        ' Draw copy of the order
        Dim yPos2 As Integer = lineSeparatorYPos2 + 50 ' Adjust the position accordingly

        For Each row As DataRow In orderDetailsTable.Rows
            Dim code As String = row("Code").ToString()
            Dim make As String = row("Make").ToString()
            Dim model As String = row("Model").ToString()
            Dim year As String = row("Year").ToString()
            Dim description As String = row("Description").ToString()
            Dim brand As String = row("Brand").ToString()
            Dim netPrice As Decimal = Convert.ToDecimal(row("NetPrice"))
            Dim quantity As Integer = Convert.ToInt32(row("Quantity"))

            ' Format the customer order details line
            Dim orderLineCopy As String = $"{code} x {quantity}"

            ' Draw the order line on the graphics context
            e.Graphics.DrawString(orderLineCopy, f10, Brushes.Black, 10, yPos2)

            ' Multiply the netPrice by quantity
            Dim totalAmountCopy As Decimal = netPrice * quantity

            ' Format the customer order details line
            Dim orderLine2Copy As String = $"{totalAmountCopy:C}"

            ' Draw the order line on the graphics context
            e.Graphics.DrawString(orderLine2Copy, f10, Brushes.Black, 170, yPos2)

            ' Increment the y-position for the next line
            yPos2 += 15
        Next

        ' Draw subtotal price, total amount due, and line separator for the copy
        Dim subtotalPriceYPos2 As Single = yPos2 + 30 ' Adjust the position accordingly

        e.Graphics.DrawString(subtotalPriceLine, f10, Brushes.Black, subtotalPriceXPos, subtotalPriceYPos2)

        Dim totalAmountDueYPos2 As Single = subtotalPriceYPos2 + 0 ' Adjust the position accordingly

        e.Graphics.DrawString(totalAmountDueLine, f10, Brushes.Black, totalAmountDueXPos, totalAmountDueYPos2)

        Dim lineSeparatorYPos3 As Single = totalAmountDueYPos2 + 20 ' Adjust the position accordingly

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, lineSeparatorYPos3)

        ' Draw copy receipt text
        Dim copyReceiptText As String = "- THIS IS A COPY OF THE RECEIPT -"
        Dim copyReceiptXPos As Single = (PD.DefaultPageSettings.PaperSize.Width - e.Graphics.MeasureString(copyReceiptText, f10).Width) / 2
        Dim copyReceiptYPos As Single = lineSeparatorYPos3 + 20 ' Adjust the position accordingly

        e.Graphics.DrawString(copyReceiptText, f10b, Brushes.Black, copyReceiptXPos, copyReceiptYPos)

        ' End the print page
        e.HasMorePages = False
    End Sub

    Private Function GetCustomerOrderDetails() As DataTable
        Dim table As New DataTable()

        ' Query to fetch customer order details from the database
        Dim query As String = "SELECT Code, Make, Model, Year, Description, Brand, NetPrice, Quantity FROM customer_orders"
        Using command As New MySqlCommand(query, MysqlConn)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)
        End Using

        Return table
    End Function

    Private Sub panelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTop.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub panelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTop.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub panelTop_MouseUp(sender As Object, e As MouseEventArgs) Handles panelTop.MouseUp
        draggable = False
    End Sub
    Private Sub PCTB_Min_Click(sender As Object, e As EventArgs) Handles PCTB_Min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PCTBX_Normal_Click(sender As Object, e As EventArgs) Handles PCTBX_Normal.Click
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub PCTB_Max_Click(sender As Object, e As EventArgs) Handles PCTB_Max.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub PCTB_Close_Click(sender As Object, e As EventArgs) Handles PCTB_Close.Click
        Dim Response As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server = localhost; userid = root; database = hefflox"
        Dim READER As MySqlDataReader

        Response = MessageBox.Show("Are you sure you want to exit? All Carted items would be lost.", "Exit Application",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Response = vbYes Then
            MysqlConn.Open()
            Dim Query As String
            Query = "drop table hefflox.customer_orders"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Application.ExitThread()

        End If
    End Sub
    Private Sub PCTB_Back_Click(sender As Object, e As EventArgs) Handles PCTB_Back.Click
        'Dim Response As Integer

        Hefflox___Home__Customer_.Show()
        Me.Close()
    End Sub
    Private Sub PCTB_Back_MouseHover(sender As Object, e As EventArgs) Handles PCTB_Back.MouseHover

        Dim tt As ToolTip

        tt = New ToolTip
        tt.SetToolTip(PCTB_Back, "Go Home")
    End Sub
    Private Sub PCTB_Min_MouseHover(sender As Object, e As EventArgs) Handles PCTB_Min.MouseHover

        Dim tt As ToolTip

        tt = New ToolTip
        tt.SetToolTip(PCTB_Min, "Minimize")
    End Sub
    Private Sub PCTBX_Normal_MouseHover(sender As Object, e As EventArgs) Handles PCTBX_Normal.MouseHover

        Dim tt As ToolTip

        tt = New ToolTip
        tt.SetToolTip(PCTBX_Normal, "Restore Down")
    End Sub
    Private Sub PCTB_Max_MouseHover(sender As Object, e As EventArgs) Handles PCTB_Max.MouseHover

        Dim tt As ToolTip

        tt = New ToolTip
        tt.SetToolTip(PCTB_Max, "Maximize")
    End Sub
    Private Sub PCTB_Close_MouseHover(sender As Object, e As EventArgs) Handles PCTB_Close.MouseHover

        Dim tt As ToolTip

        tt = New ToolTip
        tt.SetToolTip(PCTB_Close, "Exit")
    End Sub
    Private Sub hideColumns()
        DGV_receipt.Columns("GrossPrice").Visible = False
        DGV_receipt.Columns("Quantity").Visible = False
    End Sub
    Private Sub bin1()
        Dim command As New MySqlCommand("SELECT ProdID, Code, Make, Model, Year, Description, Brand, NetPrice, SUM(Quantity) AS TotalQuantity FROM hefflox.customer_orders GROUP BY ProdID, Code, Make, Model, Year, Description, Brand, NetPrice ORDER BY ProdID ASC", MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        table.Columns("ProdID").ColumnName = "Product ID"
        table.Columns("Code").ColumnName = "Code"
        table.Columns("Make").ColumnName = "Make"
        table.Columns("Model").ColumnName = "Model"
        table.Columns("Year").ColumnName = "Year"
        table.Columns("Description").ColumnName = "Details"
        table.Columns("Brand").ColumnName = "Brand"
        table.Columns("NetPrice").ColumnName = "Price"
        table.Columns("TotalQuantity").ColumnName = "Quantity in Cart"

        DGV_receipt.AllowUserToAddRows = False
        DGV_receipt.RowTemplate.Height = 100
        DGV_receipt.DataSource = table

        ' Calculate total quantity and subtotal
        Dim totalQuantity As Integer = 0
        Dim subtotal As Decimal = 0

        For Each row As DataRow In table.Rows
            Dim quantity As Integer = Convert.ToInt32(row("Quantity in Cart"))
            Dim netPrice As Decimal = Convert.ToDecimal(row("Price"))
            totalQuantity += quantity
            subtotal += quantity * netPrice
        Next

        ' Update labels
        lblNoItems.Text = "(" & totalQuantity.ToString() & " Items)"
        lblSubTotal.Text = subtotal.ToString("0.00")
    End Sub

    'Private Sub DGV_receipt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_receipt.CellClick
    '    Dim selectedColumnName As String = "Code"

    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
    '        Dim selectedCell As DataGridViewCell = DGV_receipt.Rows(e.RowIndex).Cells(e.ColumnIndex)
    '        Dim columnName As String = DGV_receipt.Columns(e.ColumnIndex).Name

    '        If columnName = selectedColumnName AndAlso selectedCell.Value IsNot Nothing AndAlso Not DBNull.Value.Equals(selectedCell.Value) Then
    '            lblItemCode.Text = selectedCell.Value.ToString()
    '        Else
    '            lblItemCode.Text = ""
    '        End If
    '    End If
    'End Sub
    Private Sub DGV_receipt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_receipt.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso DGV_receipt.Columns(e.ColumnIndex).Name = "Code" Then
            If DGV_receipt.Rows.Count > 0 Then
                Dim selectedCell As DataGridViewCell = DGV_receipt.Rows(e.RowIndex).Cells(e.ColumnIndex)

                If selectedCell.Value IsNot Nothing AndAlso Not Convert.IsDBNull(selectedCell.Value) Then
                    Dim codeValue As String = selectedCell.Value.ToString()
                    lblItemCode.Text = codeValue

                    ' Fetch available stock quantity from product_table based on the selected item's code
                    availableStock = GetAvailableStockQuantity(codeValue)

                    ' Fetch ordered quantity from customer_orders based on the selected item's code
                    orderedQuantity = GetOrderedQuantity(codeValue)

                    ' Update lblItemQuantity with the selected item's quantity
                    UpdateItemQuantity(e.RowIndex)
                End If
            Else
                lblItemCode.Text = ""
                lblItemQuantity.Text = "0"
            End If
        End If
    End Sub
    Private Function GetAvailableStockQuantity(code As String) As Integer
        ' Query the product_table to get the available stock quantity for the given code
        Dim query As String = "SELECT Quantity FROM product_table WHERE Code = @Code"
        Using command As New MySqlCommand(query, MysqlConn)
            command.Parameters.AddWithValue("@Code", code)
            MysqlConn.Open()
            Dim result As Object = command.ExecuteScalar()
            MysqlConn.Close()

            ' Return the available stock quantity
            If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                Return Convert.ToInt32(result)
            Else
                Return 0
            End If
        End Using
    End Function
    Private Function GetOrderedQuantity(code As String) As Integer
        ' Query the customer_orders table to get the ordered quantity for the given code
        Dim query As String = "SELECT SUM(Quantity) FROM customer_orders WHERE Code = @Code"
        Using command As New MySqlCommand(query, MysqlConn)
            command.Parameters.AddWithValue("@Code", code)
            MysqlConn.Open()
            Dim result As Object = command.ExecuteScalar()
            MysqlConn.Close()

            ' Return the ordered quantity
            If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                Return Convert.ToInt32(result)
            Else
                Return 0
            End If
        End Using
    End Function

    Private Sub PCTB_Plus_Click(sender As Object, e As EventArgs) Handles PCTB_Plus.Click
        If DGV_receipt.Rows.Count > 0 Then
            Dim selectedRowIndex As Integer = DGV_receipt.SelectedCells(0).RowIndex
            Dim currentQuantity As Integer = CInt(DGV_receipt.Rows(selectedRowIndex).Cells("Quantity in Cart").Value)
            Dim availableStock As Integer = GetAvailableStockQuantity(lblItemCode.Text)

            ' Check if there is available stock
            If availableStock > 0 Then
                ' Increase the quantity in the customer_orders table
                currentQuantity += 1

                ' Update the customer_orders table with the new quantity
                UpdateCustomerOrderQuantity(selectedRowIndex, currentQuantity)

                ' Decrease the available stock in the product_table
                UpdateProductTableQuantity(lblItemCode.Text, -1)

                ' Update the quantity in the DGV_receipt
                DGV_receipt.Rows(selectedRowIndex).Cells("Quantity in Cart").Value = currentQuantity

                ' Update labels
                UpdateLabels()

                ' Update lblItemQuantity with the selected item's quantity
                UpdateItemQuantity(selectedRowIndex)
            Else
                MessageBox.Show("There are no more stocks available.")
            End If
        End If
    End Sub


    ' Event handler for the minus button click event
    Private Sub PCTB_Minus_Click(sender As Object, e As EventArgs) Handles PCTB_Minus.Click
        If DGV_receipt.Rows.Count > 0 Then
            Dim selectedRowIndex As Integer = DGV_receipt.SelectedCells(0).RowIndex
            Dim currentQuantity As Integer = CInt(DGV_receipt.Rows(selectedRowIndex).Cells("Quantity in Cart").Value)

            ' Decrease the quantity if it's greater than the minimum value (1)
            If currentQuantity > 1 Then
                ' Decrease the quantity in the customer_orders table
                currentQuantity -= 1

                ' Update the customer_orders table with the new quantity
                UpdateCustomerOrderQuantity(selectedRowIndex, currentQuantity)

                ' Increase the available stock in the product_table
                UpdateProductTableQuantity(lblItemCode.Text, 1)

                ' Update the quantity in the DGV_receipt
                DGV_receipt.Rows(selectedRowIndex).Cells("Quantity in Cart").Value = currentQuantity

                ' Update labels
                UpdateLabels()

                ' Update lblItemQuantity with the selected item's quantity
                UpdateItemQuantity(selectedRowIndex)
            Else
                MessageBox.Show("The minimum value for quantity is 1.")
            End If
        End If
    End Sub
    Private Sub PCTB_Trash_Click(sender As Object, e As EventArgs) Handles PCTB_Trash.Click
        If DGV_receipt.Rows.Count > 0 Then
            Dim selectedRowIndex As Integer = DGV_receipt.SelectedCells(0).RowIndex

            ' Retrieve the necessary information from the selected row
            Dim productID As Integer = Convert.ToInt32(DGV_receipt.Rows(selectedRowIndex).Cells("Product ID").Value)
            Dim quantityToDelete As Integer = Convert.ToInt32(DGV_receipt.Rows(selectedRowIndex).Cells("Quantity in Cart").Value)
            Dim productCode As String = lblItemCode.Text

            ' Increment the available stock in product_table
            UpdateProductTableQuantity(productCode, quantityToDelete)

            ' Delete the selected row from customer_orders table
            DeleteCustomerOrder(selectedRowIndex)

            ' Clear the selection in the DataGridView
            DGV_receipt.ClearSelection()

            ' Update labels
            UpdateLabels()
        End If
        If DGV_receipt.SelectedCells.Count = 0 Then
            lblItemCode.Text = "Item Code"
            lblItemQuantity.Text = "0"
        End If
    End Sub
    Private Sub UpdateItemQuantity(rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex < DGV_receipt.Rows.Count Then
            Dim quantity As Integer = CInt(DGV_receipt.Rows(rowIndex).Cells("Quantity in Cart").Value)
            lblItemQuantity.Text = quantity.ToString()
        End If
    End Sub
    Private Sub DeleteCustomerOrder(rowIndex As Integer)
        ' Retrieve the necessary information from the selected row
        Dim productID As Integer = Convert.ToInt32(DGV_receipt.Rows(rowIndex).Cells("Product ID").Value)
        Dim quantityToDelete As Integer = Convert.ToInt32(DGV_receipt.Rows(rowIndex).Cells("Quantity in Cart").Value)
        Dim productCode As String = ""

        ' Check if the cell value is not null
        If DGV_receipt.Rows(rowIndex).Cells("Code").Value IsNot Nothing Then
            productCode = DGV_receipt.Rows(rowIndex).Cells("Code").Value.ToString()
        End If

        ' Increment the available stock in product_table
        UpdateProductTableQuantity(productCode, quantityToDelete)

        ' Delete the selected row from customer_orders table
        Dim query As String = "DELETE FROM customer_orders WHERE ProdID = @ProdID"
        Using command As New MySqlCommand(query, MysqlConn)
            command.Parameters.AddWithValue("@ProdID", productID)
            MysqlConn.Open()
            command.ExecuteNonQuery()
            MysqlConn.Close()
        End Using

        ' Remove the selected row from the DataGridView
        Dim selectedRow As DataGridViewRow = DGV_receipt.Rows(rowIndex)
        DGV_receipt.Rows.Remove(selectedRow)

        ' Clear the selection in the DataGridView
        DGV_receipt.ClearSelection()

        ' Update labels
        UpdateLabels()
    End Sub

    Private Sub UpdateCustomerOrderQuantity(rowIndex As Integer, quantity As Integer)
        ' Get the product ID for the selected row
        Dim productID As Integer = Convert.ToInt32(DGV_receipt.Rows(rowIndex).Cells("Product ID").Value)

        ' Update the customer_orders table with the new quantity
        Dim query As String = "UPDATE customer_orders SET Quantity = @Quantity WHERE ProdID = @ProdID"
        Using command As New MySqlCommand(query, MysqlConn)
            command.Parameters.AddWithValue("@Quantity", quantity)
            command.Parameters.AddWithValue("@ProdID", productID)
            MysqlConn.Open()
            command.ExecuteNonQuery()
            MysqlConn.Close()
        End Using
    End Sub

    Private Sub UpdateProductTableQuantity(code As String, quantityChange As Integer)
        ' Update the product_table by adjusting the available stock quantity
        Dim newQuantity As Integer = GetAvailableStockQuantity(code) + quantityChange

        ' Ensure the new quantity does not go below 0
        If newQuantity < 0 Then
            newQuantity = 0
        End If

        Dim query As String = "UPDATE product_table SET Quantity = @NewQuantity WHERE Code = @Code"
        Using command As New MySqlCommand(query, MysqlConn)
            command.Parameters.AddWithValue("@NewQuantity", newQuantity)
            command.Parameters.AddWithValue("@Code", code)
            MysqlConn.Open()
            command.ExecuteNonQuery()
            MysqlConn.Close()
        End Using
    End Sub
    Private Sub UpdateLabels()
        ' Calculate total quantity and subtotal
        Dim totalQuantity As Integer = 0
        Dim subtotal As Decimal = 0

        For Each row As DataRow In CType(DGV_receipt.DataSource, DataTable).Rows
            ' Check if the row is not deleted
            If row.RowState <> DataRowState.Deleted Then
                Dim quantity As Integer = Convert.ToInt32(row("Quantity in Cart"))
                Dim netPrice As Decimal = Convert.ToDecimal(row("Price"))
                totalQuantity += quantity
                subtotal += quantity * netPrice
            End If
        Next

        ' Update labels
        lblNoItems.Text = "(" & totalQuantity.ToString() & " Items)"
        lblSubTotal.Text = subtotal.ToString("0.00")
    End Sub

    Private Sub BTN_Finish_Click(sender As Object, e As EventArgs) Handles BTN_Finish.Click
        ' Display prompt message
        Dim response As DialogResult = MessageBox.Show("Are you done with your order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            ' Display another prompt message
            MessageBox.Show("Thank you for ordering! Please proceed to the counter.", "Order Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Drop the table customer_orders
            Dim connectionString As String = "Server = localhost; userid = root; database = hefflox"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "DROP TABLE hefflox.customer_orders"
                Using command As New MySqlCommand(query, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Return to Customer_Main_Menu Form
            Dim customerMainMenuForm As New Customer___Main_Menu()
            customerMainMenuForm.Show()
            Me.Close()
        End If
    End Sub
End Class

'for bin 1
' ' Set the image column properties
'Dim imageColumn As DataGridViewImageColumn = CType(DGV_receipt.Columns("Photo"), DataGridViewImageColumn)
'imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

'this is all under DGV receipt datasource = table
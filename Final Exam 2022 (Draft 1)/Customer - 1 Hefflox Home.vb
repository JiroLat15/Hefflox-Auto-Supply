Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports MySql.Data.MySqlClient
Public Class Hefflox___Home__Customer_
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private selectedItems As New List(Of DataGridViewRow)
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

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
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server = localhost; userid = root; database = hefflox"
        Dim READER As MySqlDataReader
        Dim Response As Integer

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
        Dim Response As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server = localhost; userid = root; database = hefflox"
        Dim READER As MySqlDataReader

        Response = MessageBox.Show("Are you sure you want to go back? All Carted items would be lost.", "Return to Log In",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Response = vbYes Then
            MysqlConn.Open()
            Dim Query As String
            Query = "drop table hefflox.customer_orders"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Customer___Main_Menu.Show()
            Me.Close()

        End If
    End Sub

    Private Sub PCTB_Back_MouseHover(sender As Object, e As EventArgs) Handles PCTB_Back.MouseHover

        Dim tt As ToolTip

        tt = New ToolTip
        tt.SetToolTip(PCTB_Back, "Go Back")
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
    Private Sub PCTBX_Cart_MouseHover(sender As Object, e As EventArgs) Handles PCTBX_Cart.MouseHover

        Dim tt As ToolTip

        tt = New ToolTip
        tt.SetToolTip(PCTBX_Cart, "Check Cart")
    End Sub

    Private Sub PCTBX_Cart_Click(sender As Object, e As EventArgs) Handles PCTBX_Cart.Click

        Shopping_Cart.Show()
        Me.Hide()
    End Sub

    'go back here, we needed a product table first to be implemented         
    Private Sub LL_AHv2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_AHv2.LinkClicked
        ' Store the selected rows in a list
        Dim selectedRows As List(Of DataGridViewRow) = New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In Customer___Axle_Hub__Categ__v3.DGV_Layout.SelectedRows
            selectedRows.Add(row)
        Next

        With Customer___Axle_Hub__Categ__v3
            .TopLevel = False
            P_Display.Controls.Add(Customer___Axle_Hub__Categ__v3)
            .BringToFront()
            .Show()
        End With

        ' Remove the selected rows from the DataGridView after the form is closed
        AddHandler Customer___Axle_Hub__Categ__v3.FormClosed, Sub()
                                                                  For Each row As DataGridViewRow In selectedRows
                                                                      Customer___Axle_Hub__Categ__v3.DGV_Layout.Rows.Remove(row)
                                                                  Next
                                                              End Sub
    End Sub

    Private Sub LL_BDv2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_BDv2.LinkClicked
        ' Store the selected rows in a list
        Dim selectedRows As List(Of DataGridViewRow) = New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In Customer___Brake_Drum__Categ__v3.DGV_Layout.SelectedRows
            selectedRows.Add(row)
        Next

        With Customer___Brake_Drum__Categ__v3
            .TopLevel = False
            P_Display.Controls.Add(Customer___Brake_Drum__Categ__v3)
            .BringToFront()
            .Show()
        End With

        ' Remove the selected rows from the DataGridView after the form is closed
        AddHandler Customer___Brake_Drum__Categ__v3.FormClosed, Sub()
                                                                    For Each row As DataGridViewRow In selectedRows
                                                                        Customer___Brake_Drum__Categ__v3.DGV_Layout.Rows.Remove(row)
                                                                    Next
                                                                End Sub
    End Sub
    Private Sub LL_BFv2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_BFv2.LinkClicked
        With Customer___Brake_Fluid__Categ__v3
            .TopLevel = False
            P_Display.Controls.Add(Customer___Brake_Fluid__Categ__v3)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
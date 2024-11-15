Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Customer___Main_Menu
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_CEnt_Click(sender As Object, e As EventArgs) Handles BTN_CEnt.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server = localhost; userid = root; database = hefflox"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "create table hefflox.customer_orders (ProdID bigint(11), SuppID int(11), Code varchar(100), Make varchar(100), Model varchar(100), Year varchar(100), Description varchar(100), Placement varchar(100), Brand varchar(100), GrossPrice varchar(100), NetPrice varchar(100), Quantity varchar(100), Photo blob)"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Hefflox___Home__Customer_.Show()
            Me.Hide()
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

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

    Private Sub PCTB_Close_Click(sender As Object, e As EventArgs) Handles PCTB_Close.Click

        Dim Response As Integer

        Response = MessageBox.Show("Are you sure you want to exit?", "Exit Application",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Response = vbYes Then
            Application.ExitThread()

        End If
    End Sub

    Private Sub PCTB_Max_Click(sender As Object, e As EventArgs) Handles PCTB_Max.Click

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub PCTB_Min_Click(sender As Object, e As EventArgs) Handles PCTB_Min.Click

        Me.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub PCTB_Normal_Click(sender As Object, e As EventArgs) Handles PCTBX_Normal.Click
        Me.WindowState = FormWindowState.Normal
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

    Private Sub PCTB_Bin_Click(sender As Object, e As EventArgs) Handles PCTB_Bin.Click
        Dim result As DialogResult = MessageBox.Show("Removing Existing customer_orders Table. Continue?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "Server=localhost;userid=root;database=hefflox"
            Try
                MysqlConn.Open()
                Dim Query As String = "DROP TABLE IF EXISTS hefflox.customer_orders"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                COMMAND.ExecuteNonQuery()
                MessageBox.Show("customer_orders Table removed successfully.")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Close()
            End Try
        End If
    End Sub

    Private Sub PCTB_Bin_MouseHover(sender As Object, e As EventArgs) Handles PCTB_Bin.MouseHover

        Dim tt As ToolTip

        tt = New ToolTip
        tt.SetToolTip(PCTB_Bin, "Drop Customer Table")
    End Sub

    Private Sub BTN_ExitM_Click(sender As Object, e As EventArgs) Handles BTN_ExitM.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to leave the Customer Menu?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Handle the user's response
        If result = DialogResult.Yes Then
            ' Close the current form (Customer___Main_Menu)
            Me.Close()

            ' Show another form (Form1)
            Dim form1 As New Form1()
            form1.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Customer___3_Help_Menu.Show()
        Me.Hide()
    End Sub

End Class
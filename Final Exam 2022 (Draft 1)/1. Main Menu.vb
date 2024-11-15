Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub TXTBX_UN_Enter(sender As Object, e As EventArgs) Handles TXTBX_UN.Enter
        If TXTBX_UN.Text = "Username" Then

            TXTBX_UN.Text = ""
            TXTBX_UN.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TXTBX_UN_Leave(sender As Object, e As EventArgs) Handles TXTBX_UN.Leave
        If TXTBX_UN.Text = "" Then

            TXTBX_UN.Text = "Username"
            TXTBX_UN.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub TXTBX_PW_Enter(sender As Object, e As EventArgs) Handles TXTBX_PW.Enter
        If TXTBX_PW.Text = "Password" Then

            TXTBX_PW.Text = ""
            TXTBX_PW.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TXTBX_PW_Leave(sender As Object, e As EventArgs) Handles TXTBX_PW.Leave
        If TXTBX_PW.Text = "" Then

            TXTBX_PW.Text = "Password"
            TXTBX_PW.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub BTN_LogIn_Click(sender As Object, e As EventArgs) Handles BTN_LogIn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server = localhost; userid = root; database = hefflox"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from hefflox.admin where username = '" & TXTBX_UN.Text & "' and pass = '" & TXTBX_PW.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Welcome, Owner.")
                Hefflox___Home__Admin_.Show()
                Me.Hide()

            Else
                MessageBox.Show("Username and Password Incorrect.")
            End If

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_CEnt_Click(sender As Object, e As EventArgs) Handles BTN_CEnt.Click
        Customer___Main_Menu.Show()
        Me.Hide()
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Label1.BackColor = System.Drawing.Color.Transparent
    End Sub
End Class

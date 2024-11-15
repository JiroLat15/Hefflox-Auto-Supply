Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Public Class Hefflox___Home__Admin_
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub Hefflox___Home__Admin__Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Response = MessageBox.Show("Are you sure you want to exit?", "Exit Application",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Response = vbYes Then
            Application.ExitThread()

        End If
    End Sub

    Private Sub PCTB_Back_Click(sender As Object, e As EventArgs) Handles PCTB_Back.Click
        'Dim Response As Integer

        Form1.Show()
        Me.Close()
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


    Private Sub LL_v2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_AHv2.LinkClicked
        With Admin___Category
            .TopLevel = False
            P_Display.Controls.Add(Admin___Category)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub LL_SP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_S.LinkClicked

        With Admin___Supplier__Categ_
            .TopLevel = False
            P_Display.Controls.Add(Admin___Supplier__Categ_)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub LL_BDv2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_BDv2.LinkClicked
        With Admin___Brake_Drum__Categ__v2
            .TopLevel = False
            P_Display.Controls.Add(Admin___Brake_Drum__Categ__v2)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub LL_BFv2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_BFv2.LinkClicked
        With Admin___Brake_Fluid__Categ__v2
            .TopLevel = False
            P_Display.Controls.Add(Admin___Brake_Fluid__Categ__v2)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
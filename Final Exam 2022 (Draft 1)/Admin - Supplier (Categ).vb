Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Data.SqlClient

Public Class Admin___Supplier__Categ_
    Dim CONN As New MySqlConnection("server = localhost;userid = root;database = hefflox")
    Dim command As MySqlCommand

    Private Sub Admin_Supplier__Categ_(sender As Object, e As EventArgs) Handles MyBase.Load
        Bin1()
    End Sub

    Private Sub Bin1()
        Dim command As New MySqlCommand("Select * from hefflox.supplier_table order by SuppID asc", CONN)

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()
        adapter.Fill(table)
        DGV_SP.AllowUserToAddRows = False
        DGV_SP.RowTemplate.Height = 100

        Dim pic1 As New DataGridViewImageColumn
        DGV_SP.DataSource = table
        'pic1 = DGV_SP.Columns(3)
        'pic1.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TXTBX_Code_TextChanged(sender As Object, e As EventArgs) Handles TXTBX_SID.TextChanged

    End Sub

    Private Sub TXTBX_Make_TextChanged(sender As Object, e As EventArgs) Handles TXTBX_SUPPNAME.TextChanged

    End Sub

    Private Sub TXTBX_Model_TextChanged(sender As Object, e As EventArgs) Handles TXTBX_SUPPNO.TextChanged

    End Sub

    Private Sub TXTBX_Year_TextChanged(sender As Object, e As EventArgs) Handles TXTBX_SUPPADD.TextChanged

    End Sub

    Private Sub BTN_Add_Click(sender As Object, e As EventArgs) Handles BTN_Add.Click

        Dim command As New MySqlCommand("insert into hefflox.supplier_table(SuppID,SName,SContact,SAddress) values (@SuppID,@SName,@SContact,@SAddress)", CONN)
        command.Parameters.Add("@SuppID", MySqlDbType.VarChar).Value = TXTBX_SID.Text
        command.Parameters.Add("@SName", MySqlDbType.VarChar).Value = TXTBX_SUPPNAME.Text
        command.Parameters.Add("@SContact", MySqlDbType.VarChar).Value = TXTBX_SUPPNO.Text
        command.Parameters.Add("SAddress", MySqlDbType.VarChar).Value = TXTBX_SUPPADD.Text

        'imaginary

        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
        command.ExecuteNonQuery()
        MessageBox.Show("Supplier Information Added")

        CONN.Close()
        Bin1()
    End Sub

    Private Sub BTN_Edit_Click(sender As Object, e As EventArgs) Handles BTN_Edit.Click
        'Dim memstr As New MemoryStream
        'PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)
        'Dim img() As Byte
        'img = memstr.ToArray()

        Dim update1 As String = "Update hefflox.supplier_table set SName='" & TXTBX_SUPPNAME.Text & "',SContact='" & TXTBX_SUPPNO.Text & "',SAddress='" & TXTBX_SUPPADD.Text & "' WHERE SuppID='" & TXTBX_SID.Text & "'"

        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If

        Dim command As New MySqlCommand(update1, CONN) ' Initialize the MySqlCommand object

        command.ExecuteNonQuery()
        MessageBox.Show("Supplier Information Edited")

        CONN.Close()

        Bin1()
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        Dim delete1 As String = "Delete from hefflox.supplier_table where SuppID='" & TXTBX_SID.Text & "' "

        Dim command As New MySqlCommand(delete1, CONN)

        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
        command.ExecuteNonQuery()
        MessageBox.Show("Supplier Information Deleted")

        CONN.Close()

        Bin1()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PCTB_Back_Click(sender As Object, e As EventArgs) Handles PCTB_Back.Click
        Me.Close()
    End Sub

    Private Sub DGV_SP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_SP.CellContentClick
        TXTBX_SID.Text = DGV_SP.CurrentRow.Cells(0).Value.ToString
        TXTBX_SUPPNAME.Text = DGV_SP.CurrentRow.Cells(1).Value.ToString
        TXTBX_SUPPNO.Text = DGV_SP.CurrentRow.Cells(2).Value.ToString
        TXTBX_SUPPADD.Text = DGV_SP.CurrentRow.Cells(3).Value.ToString


        'Dim img As Byte()
        'img = DGV_BF.CurrentRow.Cells(11).Value

        'Dim memstr As New MemoryStream(img)
        'PictureBox1.Image = Image.FromStream(memstr)
    End Sub
End Class
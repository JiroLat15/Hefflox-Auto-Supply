Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Axle_Hub__Categ__C
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader

    Private Sub PCTB_Back_Click(sender As Object, e As EventArgs) Handles PCTB_Back.Click

        Me.Close()

    End Sub

    Private Sub All_Tables__Categ__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server = localhost; userid = root; database = hefflox"
        LoadRecord()
    End Sub

    Sub LoadRecord()

        DGV_AHC.Rows.Clear()
        MysqlConn.Open()
        COMMAND = New MySqlCommand("select * from hefflox.axle_hub", MysqlConn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            DGV_AHC.Rows.Add(READER.Item("Photo"), READER.Item("Code").ToString, READER.Item("Make").ToString, READER.Item("Model").ToString, READER.Item("Year").ToString, READER.Item("Description").ToString, READER.Item("Placement").ToString, READER.Item("Brand").ToString, READER.Item("NetPrice").ToString, READER.Item("Quantity").ToString)
        End While
        READER.Close()
        MysqlConn.Close()

        For i = 0 To DGV_AHC.Rows.Count - 1
            Dim r As DataGridViewRow = DGV_AHC.Rows(i)
            r.Height = 100

        Next

        Dim imagecolumn = DirectCast(DGV_AHC.Columns("Photo"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub DGV_AHC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_AHC.CellContentClick

    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class Brake_Fluid__Categ__C
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

        DGV_BFC.Rows.Clear()
        MysqlConn.Open()
        COMMAND = New MySqlCommand("select * from hefflox.brake_fluid_v2", MysqlConn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            DGV_BFC.Rows.Add(READER.Item("Photo"), READER.Item("Code").ToString, READER.Item("Description").ToString, READER.Item("Brand").ToString, READER.Item("NetPrice").ToString, READER.Item("Quantity").ToString)
        End While
        READER.Close()
        MysqlConn.Close()

        For i = 0 To DGV_BFC.Rows.Count - 1
            Dim r As DataGridViewRow = DGV_BFC.Rows(i)
            r.Height = 100

        Next

        Dim imagecolumn = DirectCast(DGV_BFC.Columns("Photo"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub
End Class
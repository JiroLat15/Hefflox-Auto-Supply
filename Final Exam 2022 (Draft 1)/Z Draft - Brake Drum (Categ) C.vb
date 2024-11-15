Imports MySql.Data.MySqlClient

Public Class Brake_Drum__Categ__C
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

        DGV_BDC.Rows.Clear()
        MysqlConn.Open()
        COMMAND = New MySqlCommand("select * from hefflox.brake_drum_v2", MysqlConn)
        READER = COMMAND.ExecuteReader
        While READER.Read
            DGV_BDC.Rows.Add(READER.Item("Photo"), READER.Item("Code").ToString, READER.Item("Make").ToString, READER.Item("Model").ToString, READER.Item("Year").ToString, READER.Item("Description").ToString, READER.Item("Placement").ToString, READER.Item("Brand").ToString, READER.Item("NetPrice").ToString, READER.Item("Quantity").ToString)
        End While
        READER.Close()
        MysqlConn.Close()

        For i = 0 To DGV_BDC.Rows.Count - 1
            Dim r As DataGridViewRow = DGV_BDC.Rows(i)
            r.Height = 100

        Next

        Dim imagecolumn = DirectCast(DGV_BDC.Columns("Photo"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub DGV_BDC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BDC.CellContentClick

    End Sub
End Class

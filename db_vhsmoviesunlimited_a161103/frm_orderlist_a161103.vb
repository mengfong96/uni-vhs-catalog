Public Class frm_orderlist_a161103

    Private Sub frm_orderlist_a161103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A161103"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable

        grd_order.Columns(0).HeaderText = "ORDER ID"
        grd_order.Columns(1).HeaderText = "CUSTOMER ID"
        grd_order.Columns(2).HeaderText = "STAFF ID"
        grd_order.Columns(3).HeaderText = "ORDER DATE"

    End Sub


    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu_a161103.Show()
        Me.Dispose()

    End Sub
End Class
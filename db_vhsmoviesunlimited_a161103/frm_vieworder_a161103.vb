Public Class frm_vieworder_a161103




    Private Sub frm_orderlist_a161103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        combo_order.DataSource = run_sql_query("SELECT FLD_ORDER_ID FROM TBL_ORDER_A161103")
        combo_order.DisplayMember = "FLD_ORDER_ID"

        grd_order.Columns(0).HeaderText = "PRODUCT ID"
        grd_order.Columns(1).HeaderText = "PRODUCT NAME"
        grd_order.Columns(2).HeaderText = "QUANTITY"
        grd_order.Columns(3).HeaderText = "UNIT PRICE"
        grd_order.Columns(4).HeaderText = "SUBTOTAL"

        txt_total.Text = "RM" & get_total()

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frm_mainmenu_a161103.Show()
        Me.Hide()

    End Sub

    Private Sub combo_order_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_order.SelectedIndexChanged

        Dim order = run_sql_query("SELECT * FROM TBL_ORDER_A161103")
        Dim orderid = order.Rows(combo_order.SelectedIndex).Item("FLD_ORDER_ID")

        Dim mydatatable = run_sql_query("SELECT TBL_QUANTITY_A161103.FLD_PRODUCT_ID, FLD_PRODUCT_NAME, FLD_QUANTITY, FLD_PRICE, FLD_QUANTITY*FLD_PRICE FROM TBL_QUANTITY_A161103, TBL_PRODUCT_A161103 WHERE FLD_ORDER_ID ='" & orderid & "' AND TBL_QUANTITY_A161103.FLD_PRODUCT_ID = TBL_PRODUCT_A161103.FLD_PRODUCT_ID")

        grd_order.DataSource = mydatatable

        Dim orderdatatable = run_sql_query("SELECT * FROM TBL_ORDER_A161103 WHERE FLD_ORDER_ID = '" & orderid & "'")


        txt_customer.Text = orderdatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        txt_staff.Text = orderdatatable.Rows(0).Item("FLD_STAFF_ID")
        txt_date.Text = orderdatatable.Rows(0).Item("FLD_ORDER_DATE")

        txt_total.Text = "RM" & get_total()

    End Sub

    Private Function get_total() As Integer

        Dim total As Integer = 0

        For i As Integer = 0 To grd_order.RowCount - 1
            total = total + grd_order(4, i).Value
        Next

        Return total

    End Function

    Private Sub lbl_customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_customer.Click

    End Sub

    Private Sub btn_back_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu_a161103.Show()
        Me.Dispose()

    End Sub
End Class
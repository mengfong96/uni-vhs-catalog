Public Class frm_order_a161103

    Dim i As Integer = 0
    Dim current_row As Integer
    Dim Total As Integer
    Dim staffid As String
    Dim customerid As String

    Private Sub frm_order_a161103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_A161103")
        grd_product.Columns(0).HeaderText = "VHS ID"
        grd_product.Columns(1).HeaderText = "VHS NAME"
        grd_product.Columns(2).HeaderText = "VHS DIRECTOR"
        grd_product.Columns(3).HeaderText = "VHS MAINCAST"
        grd_product.Columns(4).HeaderText = "VHS LENGTH"
        grd_product.Columns(5).HeaderText = "VHS MPAA"
        grd_product.Columns(6).HeaderText = "VHS GENRE"
        grd_product.Columns(7).HeaderText = "VHS YEAR RELEASED"
        grd_product.Columns(8).HeaderText = "VHS COUNTRY RELEASED"
        grd_product.Columns(9).HeaderText = "VHS RATING"
        grd_product.Columns(10).HeaderText = "VHS PRICE"

        grd_order.ColumnCount = 4
        grd_order.RowCount = 0

        grd_order.Columns(0).HeaderText = "PRODUCT NAME"
        grd_order.Columns(1).HeaderText = "QUANTITY"
        grd_order.Columns(2).HeaderText = "UNIT PRICE"
        grd_order.Columns(3).HeaderText = "SUBTOTAL"

        lbl_id.Text = generate_id()

        combo_customer.DataSource = run_sql_query("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A161103")
        combo_customer.DisplayMember = "FLD_CUSTOMER_ID"
        combo_staff.DataSource = run_sql_query("SELECT FLD_STAFF_ID FROM TBL_STAFF_A161103")
        combo_staff.DisplayMember = "FLD_STAFF_ID"

        lbl_date.Text = Date.Now

        pbox_product.BackgroundImage = Image.FromFile("pictures/V01.jpg")

        txt_total.Text = ""

    End Sub

    Private Function generate_id() As String

        Dim newid As String

        Dim mydatatable As DataTable = run_sql_query("SELECT * FROM TBL_ORDER_A161103")

        If mydatatable.Rows.Count = 0 Then
            newid = "O101"
        Else
            Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A161103").Rows(0).Item("LASTID")
            newid = "O" & Mid(lastid, 2) + 1

        End If

        Return newid

    End Function

    Private Function get_current_row() As Integer

        current_row = grd_product.CurrentRow.Index

        Return current_row

    End Function

    Private Sub combo_staff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_staff.SelectedIndexChanged

        Dim mydatatable = run_sql_query("SELECT * FROM TBL_STAFF_A161103")

        staffid = mydatatable.Rows(combo_staff.SelectedIndex).Item("FLD_STAFF_ID")

    End Sub

    Private Sub combo_customer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_customer.SelectedIndexChanged

        Dim mydatatable = run_sql_query("SELECT * FROM TBL_CUSTOMER_A161103")

        customerid = mydatatable.Rows(combo_customer.SelectedIndex).Item("FLD_CUSTOMER_ID")

    End Sub

    Private Sub grd_product_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_product.CellClick

        Dim current_row As Integer = grd_product.CurrentRow.Index

        Try
            pbox_product.BackgroundImage = Image.FromFile("pictures/" & grd_product(0, current_row).Value & ".jpg")
        Catch ex As Exception
            pbox_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub btn_add2cart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add2cart.Click

        Dim count As Integer = 0
        Dim temp As Integer

        For x As Integer = 0 To grd_order.RowCount - 1
            If grd_product(1, get_current_row).Value = grd_order(0, x).Value Then
                count = count + 1
                temp = x
            End If
        Next

        If count > 0 Then
            grd_order(1, temp).Value = grd_order(1, temp).Value + num_quantity.Value
            Dim temptotal As Integer = num_quantity.Value * grd_order(2, temp).Value
            grd_order(3, temp).Value = grd_order(3, temp).Value + temptotal

            Total = Total + temptotal
        Else
            grd_order.RowCount = grd_order.RowCount + 1
            grd_order(0, i).Value = grd_product(1, get_current_row).Value
            grd_order(1, i).Value = num_quantity.Value
            grd_order(2, i).Value = grd_product(10, get_current_row).Value
            grd_order(3, i).Value = num_quantity.Value * grd_product(10, get_current_row).Value

            Total = Total + grd_order(3, i).Value

            i += 1
        End If

        txt_total.Text = "RM" & Total
        num_quantity.Text = "1"

    End Sub

    Private Sub btn_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirm.Click

        If grd_order.RowCount > 0 Then

            myconnection2.Open()
            Dim mytransaction As OleDb.OleDbTransaction = myconnection2.BeginTransaction

            Dim orderid As String = lbl_id.Text
            Dim orderdate As String = lbl_date.Text


            Try

                Dim myordersql As String = "INSERT INTO TBL_ORDER_A161103 VALUES ('" & orderid & "', '" & customerid & "', '" & staffid & "', '" & orderdate & "')"

                Dim myorderwritter As New OleDb.OleDbCommand(myordersql, myconnection2, mytransaction)

                myorderwritter.ExecuteNonQuery()

                For x As Integer = 0 To grd_order.RowCount - 1

                    Dim productdatatable = run_sql_query("SELECT * FROM TBL_PRODUCT_A161103 WHERE FLD_PRODUCT_NAME ='" & grd_order(0, x).Value & "'")
                    Dim productid As String = productdatatable.Rows(0).Item("FLD_PRODUCT_ID")
                    Dim quantity As Integer = grd_order(1, x).Value

                    Dim quantitysql As String = "INSERT INTO TBL_QUANTITY_A161103 VALUES ('" & orderid & "', '" & productid & "', " & quantity & ")"

                    Dim quantitywritter As New OleDb.OleDbCommand(quantitysql, myconnection2, mytransaction)

                    quantitywritter.ExecuteNonQuery()

                Next

                mytransaction.Commit()
                myconnection2.Close()

                Beep()
                MessageBox.Show("Transaction Successful!", "VHS Movie Unlimited")

                grd_order.Rows.Clear()
                refresh_grid()

            Catch ex As Exception

                mytransaction.Rollback()
                Beep()
                MessageBox.Show("An error occured while confirming order: " & vbCrLf & vbCrLf & ex.Message, "VHS Movie Unlimited")
                myconnection2.Close()

                grd_order.Rows.Clear()
                refresh_grid()

            End Try

            i = 0
        Else
            Beep()
            MessageBox.Show("Please add something in the column ^^", "VHS Movie Unlimited")
        End If

    End Sub

    
    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click

        If grd_order.RowCount > 0 Then
            Dim current As Integer = grd_order.CurrentRow.Index
            Total = Total - grd_order(3, current).Value
            grd_order.Rows.RemoveAt(current)
            txt_total.Text = Total
            i = i - 1
        Else
            Beep()
            MessageBox.Show("Please do not spam the delete button.", "VHS Movie Unlimited")
        End If
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu_a161103.Show()
        Me.Dispose()

    End Sub

    Private Sub btn_vieworder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vieworder.Click
        frm_vieworder_a161103.Show()

    End Sub
End Class
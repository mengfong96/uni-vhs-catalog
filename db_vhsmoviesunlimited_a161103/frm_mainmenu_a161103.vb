Public Class frm_mainmenu_a161103

    Private Sub frm_mainmenu_a161103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click

        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btn_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_staff.Click

        frm_staff_a161103.Show()
    End Sub

    Private Sub btn_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_order.Click
        MessageBox.Show("Welcome to VHS Movie Ordering System. Have a nice day!", "VHS Movie Unlimited", MessageBoxButtons.OK)
        frm_order_a161103.Show()
    End Sub

    Private Sub btn_product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_product.Click

        frm_product_a161103.Show()
    End Sub

    Private Sub btn_customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_customer.Click

        frm_customer_a161103.Show()
    End Sub

    Private Sub btn_orderlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_orderlist.Click

        frm_vieworder_a161103.Show()
    End Sub

    Private Sub btn_addmovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addmovie.Click

        frm_insertmovie_a161103.Show()
    End Sub

    Private Sub btn_productdetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_productdetails.Click

        frm_productdetails_a161103.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Application.Restart()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_orderlist_a161103.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lbl_date.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")

    End Sub
End Class
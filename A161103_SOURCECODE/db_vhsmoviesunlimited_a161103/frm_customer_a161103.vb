Public Class frm_customer_a161103

    Private Sub frm_customer_a161103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A161103"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_customer.DataSource = mydatatable
        lst_customer.DisplayMember = "fld_customer_id"

        refresh_text(lst_customer.Text)

    End Sub

    Private Sub refresh_text(ByVal customerid As String)

        Dim mysql As String = "Select * from tbl_customer_a161103 where fld_customer_id='" & customerid & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_customerid.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        txt_customername.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NAME")
        txt_customerphoneno.Text = mydatatable.Rows(0).Item("FLD_PHONE")

    End Sub
    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu_a161103.Show()
        Me.Dispose()

    End Sub

    Private Sub lst_customer_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_customer.MouseClick
        refresh_text(lst_customer.Text)

    End Sub
End Class
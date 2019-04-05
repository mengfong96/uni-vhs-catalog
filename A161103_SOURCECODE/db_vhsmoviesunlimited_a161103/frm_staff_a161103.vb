Public Class frm_staff_a161103

    Private Sub frm_staff_a161103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A161103"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_staff.DataSource = mydatatable
        lst_staff.DisplayMember = "fld_staff_id"

        refresh_text(lst_staff.Text)

    End Sub

    Private Sub refresh_text(ByVal staffid As String)

        Dim mysql As String = "Select * from tbl_staff_a161103 where fld_staff_id='" & staffid & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_staffid.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        txt_staffname.Text = mydatatable.Rows(0).Item("FLD_STAFF_NAME")
        txt_staffphoneno.Text = mydatatable.Rows(0).Item("FLD_STAFF_PHONENO")


    End Sub
    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu_a161103.Show()
        Me.Dispose()

    End Sub

    Private Sub lst_staff_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_staff.MouseClick

        refresh_text(lst_staff.Text)

    End Sub
End Class
Public Class frm_productdetails_a161103

    Private Sub frm_productdetails_a161103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mysql As String = "select fld_product_id from tbl_product_a161103"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_productid.DataSource = mydatatable
        lst_productid.DisplayMember = "fld_product_id"

        refresh_text(lst_productid.Text)

    End Sub

    Private Sub refresh_text(ByVal productid As String)

        Dim mysql As String = "select * from tbl_product_a161103 where FLD_PRODUCT_ID='" & productid & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_name")
        txt_director.Text = mydatatable.Rows(0).Item("FLD_director")
        txt_maincast.Text = mydatatable.Rows(0).Item("FLD_maincast")
        txt_length.Text = mydatatable.Rows(0).Item("FLD_length")
        txt_mpaa.Text = mydatatable.Rows(0).Item("FLD_mpaa")
        txt_genre.Text = mydatatable.Rows(0).Item("FLD_genre")
        txt_year.Text = mydatatable.Rows(0).Item("FLD_year_released")
        txt_country.Text = mydatatable.Rows(0).Item("FLD_country_released")
        txt_rating.Text = mydatatable.Rows(0).Item("FLD_rating")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_price")

        Try
            pic_productid.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")

        Catch ex As Exception
            pic_productid.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

        End Try

    End Sub
    Private Sub lst_productid_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_productid.MouseClick

        refresh_text(lst_productid.Text)

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu_a161103.Show()
        Me.Dispose()

    End Sub
End Class
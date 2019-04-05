Public Class frm_product_a161103


    Dim current_row As Integer

    Private Sub frm_product_a161103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        'lbl_date.Text = current_date

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A161103"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable

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


        pic_product.BackgroundImage = Image.FromFile("pictures/V01.jpg")

    End Sub

    Private Function get_current_row() As Integer

        current_row = grd_product.CurrentRow.Index

        Return current_row

    End Function

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frm_mainmenu_a161103.Show()
        Me.Hide()

    End Sub

    Private Sub refresh_text(ByVal productid As String)

        Dim mysql As String = "select * from tbl_poduct_a161103 where fld_product_id='" & productid & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

    End Sub

    Private Sub btn_details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_productdetails_a161103.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_editmovie_a161103.Show()

    End Sub

    Private Sub grd_product_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_product.CellClick
        Dim current_row As Integer = grd_product.CurrentRow.Index

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & grd_product(0, current_row).Value & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try
    End Sub

    Private Sub grd_product_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_product.CellContentClick

    End Sub

    Private Sub btn_insertfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        frm_mainmenu_a161103.Show()

        Me.Dispose()
    End Sub
End Class
Public Class frm_insertmovie_a161103

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"


    Private Sub frm_insertmovie_a161103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()

        Dim lastproductid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS lastProductid from tbl_product_a161103").Rows(0).Item("lastProductid")

        txt_id.Text = generate_id()

        txt_picture.Text = defaultpicture

        pic_vhsmovie.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Function generate_id() As String
        Dim lastproductid As String = run_sql_query("select max(FLD_PRODUCT_ID) as lastproductid from tbl_product_a161103").Rows(0).Item("Lastproductid")

        MessageBox.Show(lastproductid, "VHS Movie Unlimited")

        Dim newproductid As String = "V" & Mid(lastproductid, 2) + 1

        Return newproductid
    End Function

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A161103"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_insertproduct.DataSource = mydatatable

        grd_insertproduct.Columns(0).HeaderText = "VHS ID"
        grd_insertproduct.Columns(1).HeaderText = "VHS NAME"
        grd_insertproduct.Columns(2).HeaderText = "VHS DIRECTOR"
        grd_insertproduct.Columns(3).HeaderText = "VHS MAINCAST"
        grd_insertproduct.Columns(4).HeaderText = "VHS LENGTH"
        grd_insertproduct.Columns(5).HeaderText = "VHS MPAA"
        grd_insertproduct.Columns(6).HeaderText = "VHS GENRE"
        grd_insertproduct.Columns(7).HeaderText = "VHS YEAR RELEASED"
        grd_insertproduct.Columns(8).HeaderText = "VHS COUNTRY RELEASED"
        grd_insertproduct.Columns(9).HeaderText = "VHS RATING"
        grd_insertproduct.Columns(10).HeaderText = "VHS PRICE"

    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_director.Text = ""
        txt_maincast.Text = ""
        txt_length.Text = ""
        txt_mpaa.Text = ""
        txt_genre.Text = ""
        txt_year.Text = ""
        txt_country.Text = ""
        txt_rating.Text = ""
        txt_price.Text = ""
    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        Dim mysql As String = "insert into tbl_product_a161103 values ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_director.Text & "','" & txt_maincast.Text & "','" & txt_length.Text & "','" & txt_mpaa.Text & "','" & txt_genre.Text & "','" & txt_year.Text & "','" & txt_country.Text & "','" & txt_rating.Text & "','" & txt_price.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()

            mywriter.ExecuteNonQuery()

            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            refresh_grid()

            clear_fields()

            txt_picture.Text = defaultpicture
            pic_vhsmovie.BackgroundImage = Image.FromFile(defaultpicture)

            Beep()
            MessageBox.Show("Data has been successfully added into system.", "VHS Movie Unilimited")

        Catch ex As Exception

            Beep()

            MessageBox.Show("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message, "VHS Movie Unlimited")

            mywriter.Connection.Close()

        End Try
    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu_a161103.Show()
        Me.Dispose()

    End Sub

End Class
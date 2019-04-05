Public Class frm_editmovie_a161103

    Dim current_code As String

    Private Sub frm_editmovie_a161103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_code()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A161103"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_movie.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_length.Text = ""
        txt_year.Text = ""
        txt_country.Text = ""
        txt_price.Text = ""
    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_movie.CurrentRow.Index
        current_code = grd_movie(0, current_row).Value
        txt_id.Text = current_code
        txt_name.Text = grd_movie(1, current_row).Value
        txt_length.Text = grd_movie(4, current_row).Value
        txt_year.Text = grd_movie(7, current_row).Value
        txt_country.Text = grd_movie(8, current_row).Value
        txt_price.Text = grd_movie(10, current_row).Value
    End Sub

    Private Sub grd_movie_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_movie.CellClick

        get_current_code()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_PRODUCT_A161103 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_LENGTH='" & txt_length.Text & "', FLD_YEAR_RELEASED='" & txt_year.Text & "', FLD_COUNTRY_RELEASED='" & txt_country.Text & "', FLD_PRICE='" & txt_price.Text & "'WHERE FLD_PRODUCT_ID='" & current_code & "'")
        Beep()
        MsgBox("Are you sure want to update the current movie details?", MsgBoxStyle.YesNo)
        If DialogResult.Yes Then
            Beep()
            MsgBox("You have successfully updated the movie """ & current_code & """.")
        ElseIf DialogResult.No Then

        End If
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you want to delete the movie """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCT_A161103 WHERE FLD_PRODUCT_ID='" & current_code & "'")

            Beep()
            MessageBox.Show("The movie """ & current_code & """ has been successfully deleted.", "VHS Movie Unlimited")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_order_a161103.Show()
        Me.Dispose()

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editmovie_a161103
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editmovie_a161103))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_movie = New System.Windows.Forms.DataGridView()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_length = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_length = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_movie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Movie"
        '
        'grd_movie
        '
        Me.grd_movie.AllowUserToAddRows = False
        Me.grd_movie.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.grd_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_movie.Location = New System.Drawing.Point(17, 56)
        Me.grd_movie.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_movie.Name = "grd_movie"
        Me.grd_movie.ReadOnly = True
        Me.grd_movie.RowTemplate.Height = 24
        Me.grd_movie.Size = New System.Drawing.Size(532, 349)
        Me.grd_movie.TabIndex = 1
        '
        'txt_year
        '
        Me.txt_year.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_year.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(672, 184)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(132, 23)
        Me.txt_year.TabIndex = 74
        '
        'txt_country
        '
        Me.txt_country.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_country.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_country.Location = New System.Drawing.Point(672, 216)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(132, 23)
        Me.txt_country.TabIndex = 73
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_price.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(672, 249)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(132, 23)
        Me.txt_price.TabIndex = 71
        '
        'txt_length
        '
        Me.txt_length.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_length.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_length.Location = New System.Drawing.Point(672, 151)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(132, 23)
        Me.txt_length.TabIndex = 70
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_name.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(672, 119)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(132, 23)
        Me.txt_name.TabIndex = 69
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(562, 249)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(54, 20)
        Me.lbl_price.TabIndex = 66
        Me.lbl_price.Text = "Price:"
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.BackColor = System.Drawing.Color.Transparent
        Me.lbl_country.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_country.Location = New System.Drawing.Point(562, 216)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(83, 20)
        Me.lbl_country.TabIndex = 64
        Me.lbl_country.Text = "Country:"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.BackColor = System.Drawing.Color.Transparent
        Me.lbl_year.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year.Location = New System.Drawing.Point(562, 184)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(111, 20)
        Me.lbl_year.TabIndex = 63
        Me.lbl_year.Text = "Year Release:"
        '
        'lbl_length
        '
        Me.lbl_length.AutoSize = True
        Me.lbl_length.BackColor = System.Drawing.Color.Transparent
        Me.lbl_length.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_length.Location = New System.Drawing.Point(562, 151)
        Me.lbl_length.Name = "lbl_length"
        Me.lbl_length.Size = New System.Drawing.Size(73, 20)
        Me.lbl_length.TabIndex = 60
        Me.lbl_length.Text = "Length:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(562, 119)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(56, 20)
        Me.lbl_name.TabIndex = 57
        Me.lbl_name.Text = "Name:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(562, 86)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(32, 20)
        Me.lbl_id.TabIndex = 56
        Me.lbl_id.Text = "ID:"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_id.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(672, 86)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(132, 23)
        Me.txt_id.TabIndex = 55
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Lime
        Me.btn_update.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(598, 291)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(170, 32)
        Me.btn_update.TabIndex = 77
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Pink
        Me.btn_delete.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(598, 329)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_delete.Size = New System.Drawing.Size(170, 32)
        Me.btn_delete.TabIndex = 78
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Trajan Pro 3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(598, 368)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(170, 32)
        Me.btn_back.TabIndex = 79
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_editmovie_a161103
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 427)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_country)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_length)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_country)
        Me.Controls.Add(Me.lbl_year)
        Me.Controls.Add(Me.lbl_length)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_movie)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_editmovie_a161103"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Movie Info"
        CType(Me.grd_movie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grd_movie As System.Windows.Forms.DataGridView
    Friend WithEvents txt_year As System.Windows.Forms.TextBox
    Friend WithEvents txt_country As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_length As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents lbl_country As System.Windows.Forms.Label
    Friend WithEvents lbl_year As System.Windows.Forms.Label
    Friend WithEvents lbl_length As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
End Class

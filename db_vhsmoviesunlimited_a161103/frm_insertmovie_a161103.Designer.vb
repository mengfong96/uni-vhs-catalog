<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertmovie_a161103
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertmovie_a161103))
        Me.grd_insertproduct = New System.Windows.Forms.DataGridView()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_director = New System.Windows.Forms.Label()
        Me.lbl_maincast = New System.Windows.Forms.Label()
        Me.lbl_length = New System.Windows.Forms.Label()
        Me.lbl_mpaa = New System.Windows.Forms.Label()
        Me.lbl_genre = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.lbl_rating = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_maincast = New System.Windows.Forms.TextBox()
        Me.txt_director = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_length = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.pic_vhsmovie = New System.Windows.Forms.PictureBox()
        Me.btn_insertfile = New System.Windows.Forms.Button()
        Me.txt_rating = New System.Windows.Forms.TextBox()
        Me.txt_genre = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.txt_mpaa = New System.Windows.Forms.TextBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_title2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_insertproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_vhsmovie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_insertproduct
        '
        Me.grd_insertproduct.AllowUserToAddRows = False
        Me.grd_insertproduct.AllowUserToDeleteRows = False
        Me.grd_insertproduct.BackgroundColor = System.Drawing.Color.Thistle
        Me.grd_insertproduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grd_insertproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_insertproduct.Location = New System.Drawing.Point(12, 59)
        Me.grd_insertproduct.Name = "grd_insertproduct"
        Me.grd_insertproduct.ReadOnly = True
        Me.grd_insertproduct.Size = New System.Drawing.Size(836, 349)
        Me.grd_insertproduct.TabIndex = 1
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Trajan Pro 3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(329, 662)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(85, 30)
        Me.btn_insert.TabIndex = 2
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_id.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(181, 474)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(120, 23)
        Me.txt_id.TabIndex = 3
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(47, 474)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(88, 19)
        Me.lbl_id.TabIndex = 4
        Me.lbl_id.Text = "MOVIE ID:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(47, 504)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 19)
        Me.lbl_name.TabIndex = 5
        Me.lbl_name.Text = "Name:"
        '
        'lbl_director
        '
        Me.lbl_director.AutoSize = True
        Me.lbl_director.BackColor = System.Drawing.Color.Transparent
        Me.lbl_director.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_director.Location = New System.Drawing.Point(47, 534)
        Me.lbl_director.Name = "lbl_director"
        Me.lbl_director.Size = New System.Drawing.Size(72, 19)
        Me.lbl_director.TabIndex = 6
        Me.lbl_director.Text = "Director:"
        '
        'lbl_maincast
        '
        Me.lbl_maincast.AutoSize = True
        Me.lbl_maincast.BackColor = System.Drawing.Color.Transparent
        Me.lbl_maincast.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maincast.Location = New System.Drawing.Point(47, 564)
        Me.lbl_maincast.Name = "lbl_maincast"
        Me.lbl_maincast.Size = New System.Drawing.Size(75, 19)
        Me.lbl_maincast.TabIndex = 7
        Me.lbl_maincast.Text = "Maincast:"
        '
        'lbl_length
        '
        Me.lbl_length.AutoSize = True
        Me.lbl_length.BackColor = System.Drawing.Color.Transparent
        Me.lbl_length.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_length.Location = New System.Drawing.Point(47, 594)
        Me.lbl_length.Name = "lbl_length"
        Me.lbl_length.Size = New System.Drawing.Size(60, 19)
        Me.lbl_length.TabIndex = 8
        Me.lbl_length.Text = "Length:"
        '
        'lbl_mpaa
        '
        Me.lbl_mpaa.AutoSize = True
        Me.lbl_mpaa.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mpaa.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mpaa.Location = New System.Drawing.Point(338, 474)
        Me.lbl_mpaa.Name = "lbl_mpaa"
        Me.lbl_mpaa.Size = New System.Drawing.Size(60, 19)
        Me.lbl_mpaa.TabIndex = 9
        Me.lbl_mpaa.Text = "MPAA:"
        '
        'lbl_genre
        '
        Me.lbl_genre.AutoSize = True
        Me.lbl_genre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_genre.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_genre.Location = New System.Drawing.Point(338, 504)
        Me.lbl_genre.Name = "lbl_genre"
        Me.lbl_genre.Size = New System.Drawing.Size(57, 19)
        Me.lbl_genre.TabIndex = 10
        Me.lbl_genre.Text = "Genre:"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.BackColor = System.Drawing.Color.Transparent
        Me.lbl_year.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year.Location = New System.Drawing.Point(338, 534)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(102, 19)
        Me.lbl_year.TabIndex = 11
        Me.lbl_year.Text = "Year Release:"
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.BackColor = System.Drawing.Color.Transparent
        Me.lbl_country.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_country.Location = New System.Drawing.Point(338, 564)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(128, 19)
        Me.lbl_country.TabIndex = 12
        Me.lbl_country.Text = "Country Release:"
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.BackColor = System.Drawing.Color.Transparent
        Me.lbl_rating.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rating.Location = New System.Drawing.Point(338, 594)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(58, 19)
        Me.lbl_rating.TabIndex = 13
        Me.lbl_rating.Text = "Rating:"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(338, 624)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(48, 19)
        Me.lbl_price.TabIndex = 14
        Me.lbl_price.Text = "Price:"
        '
        'txt_maincast
        '
        Me.txt_maincast.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_maincast.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_maincast.Location = New System.Drawing.Point(181, 564)
        Me.txt_maincast.Name = "txt_maincast"
        Me.txt_maincast.Size = New System.Drawing.Size(120, 23)
        Me.txt_maincast.TabIndex = 15
        '
        'txt_director
        '
        Me.txt_director.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_director.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_director.Location = New System.Drawing.Point(181, 534)
        Me.txt_director.Name = "txt_director"
        Me.txt_director.Size = New System.Drawing.Size(120, 23)
        Me.txt_director.TabIndex = 16
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_name.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(181, 504)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(120, 23)
        Me.txt_name.TabIndex = 17
        '
        'txt_length
        '
        Me.txt_length.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_length.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_length.Location = New System.Drawing.Point(181, 594)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(120, 23)
        Me.txt_length.TabIndex = 18
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_price.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(472, 624)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(120, 23)
        Me.txt_price.TabIndex = 19
        '
        'pic_vhsmovie
        '
        Me.pic_vhsmovie.BackColor = System.Drawing.Color.Transparent
        Me.pic_vhsmovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_vhsmovie.Location = New System.Drawing.Point(660, 465)
        Me.pic_vhsmovie.Name = "pic_vhsmovie"
        Me.pic_vhsmovie.Size = New System.Drawing.Size(161, 122)
        Me.pic_vhsmovie.TabIndex = 25
        Me.pic_vhsmovie.TabStop = False
        '
        'btn_insertfile
        '
        Me.btn_insertfile.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertfile.Location = New System.Drawing.Point(679, 593)
        Me.btn_insertfile.Name = "btn_insertfile"
        Me.btn_insertfile.Size = New System.Drawing.Size(120, 30)
        Me.btn_insertfile.TabIndex = 26
        Me.btn_insertfile.Text = "Open File..."
        Me.btn_insertfile.UseVisualStyleBackColor = True
        '
        'txt_rating
        '
        Me.txt_rating.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_rating.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rating.Location = New System.Drawing.Point(472, 594)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.Size = New System.Drawing.Size(120, 23)
        Me.txt_rating.TabIndex = 31
        '
        'txt_genre
        '
        Me.txt_genre.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_genre.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_genre.Location = New System.Drawing.Point(472, 504)
        Me.txt_genre.Name = "txt_genre"
        Me.txt_genre.Size = New System.Drawing.Size(120, 23)
        Me.txt_genre.TabIndex = 30
        '
        'txt_year
        '
        Me.txt_year.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_year.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(472, 534)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(120, 23)
        Me.txt_year.TabIndex = 29
        '
        'txt_country
        '
        Me.txt_country.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_country.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_country.Location = New System.Drawing.Point(472, 564)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(120, 23)
        Me.txt_country.TabIndex = 28
        '
        'txt_mpaa
        '
        Me.txt_mpaa.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_mpaa.Font = New System.Drawing.Font("Trajan Pro 3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mpaa.Location = New System.Drawing.Point(472, 474)
        Me.txt_mpaa.Name = "txt_mpaa"
        Me.txt_mpaa.Size = New System.Drawing.Size(120, 23)
        Me.txt_mpaa.TabIndex = 27
        '
        'txt_picture
        '
        Me.txt_picture.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_picture.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_picture.Location = New System.Drawing.Point(693, 628)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(133, 23)
        Me.txt_picture.TabIndex = 32
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_title2
        '
        Me.lbl_title2.AutoSize = True
        Me.lbl_title2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title2.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title2.Location = New System.Drawing.Point(4, 9)
        Me.lbl_title2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title2.Name = "lbl_title2"
        Me.lbl_title2.Size = New System.Drawing.Size(255, 47)
        Me.lbl_title2.TabIndex = 33
        Me.lbl_title2.Text = "Insert Movie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trajan Pro 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Basic Info :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trajan Pro 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(338, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Technical Info :-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trajan Pro 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(655, 424)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 25)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Insert Picture :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trajan Pro 3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(627, 628)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "PATH:"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Trajan Pro 3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(420, 662)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(85, 30)
        Me.btn_back.TabIndex = 38
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_insertmovie_a161103
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(860, 713)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_title2)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.txt_rating)
        Me.Controls.Add(Me.txt_genre)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_country)
        Me.Controls.Add(Me.txt_mpaa)
        Me.Controls.Add(Me.btn_insertfile)
        Me.Controls.Add(Me.pic_vhsmovie)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_length)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_director)
        Me.Controls.Add(Me.txt_maincast)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_rating)
        Me.Controls.Add(Me.lbl_country)
        Me.Controls.Add(Me.lbl_year)
        Me.Controls.Add(Me.lbl_genre)
        Me.Controls.Add(Me.lbl_mpaa)
        Me.Controls.Add(Me.lbl_length)
        Me.Controls.Add(Me.lbl_maincast)
        Me.Controls.Add(Me.lbl_director)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.grd_insertproduct)
        Me.Name = "frm_insertmovie_a161103"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Movies"
        CType(Me.grd_insertproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_vhsmovie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_insertproduct As System.Windows.Forms.DataGridView
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_director As System.Windows.Forms.Label
    Friend WithEvents lbl_maincast As System.Windows.Forms.Label
    Friend WithEvents lbl_length As System.Windows.Forms.Label
    Friend WithEvents lbl_mpaa As System.Windows.Forms.Label
    Friend WithEvents lbl_genre As System.Windows.Forms.Label
    Friend WithEvents lbl_year As System.Windows.Forms.Label
    Friend WithEvents lbl_country As System.Windows.Forms.Label
    Friend WithEvents lbl_rating As System.Windows.Forms.Label
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents txt_maincast As System.Windows.Forms.TextBox
    Friend WithEvents txt_director As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_length As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents pic_vhsmovie As System.Windows.Forms.PictureBox
    Friend WithEvents btn_insertfile As System.Windows.Forms.Button
    Friend WithEvents txt_rating As System.Windows.Forms.TextBox
    Friend WithEvents txt_genre As System.Windows.Forms.TextBox
    Friend WithEvents txt_year As System.Windows.Forms.TextBox
    Friend WithEvents txt_country As System.Windows.Forms.TextBox
    Friend WithEvents txt_mpaa As System.Windows.Forms.TextBox
    Friend WithEvents txt_picture As System.Windows.Forms.TextBox

    Private Sub btn_insertfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insertfile.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        'OpenFileDialog1.InitialDirectory = mydesktop
        'OpenFileDialog1.FileName = ""
        'OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        'OpenFileDialog1.ShowDialog()

        Dim strFileName As String
        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = OpenFileDialog1.FileName
            If strFileName <> "" Then

                pic_vhsmovie.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                txt_picture.Text = OpenFileDialog1.FileName
            Else
                MsgBox("No File Selected")
            End If
        End If
    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_title2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
End Class

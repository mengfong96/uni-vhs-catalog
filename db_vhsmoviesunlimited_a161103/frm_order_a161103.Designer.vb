<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_a161103
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_order_a161103))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_subtitle2 = New System.Windows.Forms.Label()
        Me.lbl_subtitle = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.lbl_order_date = New System.Windows.Forms.Label()
        Me.combo_customer = New System.Windows.Forms.ComboBox()
        Me.lbl_tips0 = New System.Windows.Forms.Label()
        Me.lbl_tips2 = New System.Windows.Forms.Label()
        Me.lbl_tips1 = New System.Windows.Forms.Label()
        Me.combo_staff = New System.Windows.Forms.ComboBox()
        Me.lbl_tips3 = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.pbox_product = New System.Windows.Forms.PictureBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.num_quantity = New System.Windows.Forms.NumericUpDown()
        Me.btn_add2cart = New System.Windows.Forms.Button()
        Me.lbl_tips4 = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.lbl_tips5 = New System.Windows.Forms.Label()
        Me.btn_vieworder = New System.Windows.Forms.Button()
        Me.lbl_tips6 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(343, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 147)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'lbl_subtitle2
        '
        Me.lbl_subtitle2.AutoSize = True
        Me.lbl_subtitle2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtitle2.Font = New System.Drawing.Font("Trajan Pro", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtitle2.Location = New System.Drawing.Point(578, 101)
        Me.lbl_subtitle2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_subtitle2.Name = "lbl_subtitle2"
        Me.lbl_subtitle2.Size = New System.Drawing.Size(231, 25)
        Me.lbl_subtitle2.TabIndex = 23
        Me.lbl_subtitle2.Text = "Tel/ Fax: 03-96458897"
        '
        'lbl_subtitle
        '
        Me.lbl_subtitle.AutoSize = True
        Me.lbl_subtitle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtitle.Font = New System.Drawing.Font("Trajan Pro", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtitle.Location = New System.Drawing.Point(509, 75)
        Me.lbl_subtitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_subtitle.Name = "lbl_subtitle"
        Me.lbl_subtitle.Size = New System.Drawing.Size(387, 25)
        Me.lbl_subtitle.TabIndex = 22
        Me.lbl_subtitle.Text = "3, Jalan Mega 2, Cheras, Selangor"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(480, 27)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(446, 47)
        Me.lbl_title.TabIndex = 21
        Me.lbl_title.Text = "VHS MOVIE UNLIMITED"
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.Location = New System.Drawing.Point(40, 167)
        Me.lbl_order.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(69, 24)
        Me.lbl_order.TabIndex = 25
        Me.lbl_order.Text = "Order: "
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(635, 198)
        Me.lbl_customer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(101, 24)
        Me.lbl_customer.TabIndex = 26
        Me.lbl_customer.Text = "Customer: "
        '
        'lbl_order_date
        '
        Me.lbl_order_date.AutoSize = True
        Me.lbl_order_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_date.Location = New System.Drawing.Point(40, 198)
        Me.lbl_order_date.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_order_date.Name = "lbl_order_date"
        Me.lbl_order_date.Size = New System.Drawing.Size(58, 24)
        Me.lbl_order_date.TabIndex = 27
        Me.lbl_order_date.Text = "Date: "
        '
        'combo_customer
        '
        Me.combo_customer.BackColor = System.Drawing.Color.PowderBlue
        Me.combo_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_customer.FormattingEnabled = True
        Me.combo_customer.Location = New System.Drawing.Point(744, 198)
        Me.combo_customer.Margin = New System.Windows.Forms.Padding(2)
        Me.combo_customer.Name = "combo_customer"
        Me.combo_customer.Size = New System.Drawing.Size(102, 28)
        Me.combo_customer.TabIndex = 28
        '
        'lbl_tips0
        '
        Me.lbl_tips0.AutoSize = True
        Me.lbl_tips0.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tips0.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tips0.Location = New System.Drawing.Point(23, 105)
        Me.lbl_tips0.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tips0.Name = "lbl_tips0"
        Me.lbl_tips0.Size = New System.Drawing.Size(280, 21)
        Me.lbl_tips0.TabIndex = 29
        Me.lbl_tips0.Text = "Order VHS movie in few easy steps! "
        '
        'lbl_tips2
        '
        Me.lbl_tips2.AutoSize = True
        Me.lbl_tips2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tips2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tips2.Location = New System.Drawing.Point(635, 166)
        Me.lbl_tips2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tips2.Name = "lbl_tips2"
        Me.lbl_tips2.Size = New System.Drawing.Size(234, 21)
        Me.lbl_tips2.TabIndex = 30
        Me.lbl_tips2.Text = "Step 2: Select Your Customer. "
        '
        'lbl_tips1
        '
        Me.lbl_tips1.AutoSize = True
        Me.lbl_tips1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tips1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tips1.Location = New System.Drawing.Point(424, 166)
        Me.lbl_tips1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tips1.Name = "lbl_tips1"
        Me.lbl_tips1.Size = New System.Drawing.Size(218, 21)
        Me.lbl_tips1.TabIndex = 35
        Me.lbl_tips1.Text = "Step 1: Choose your staffID. "
        '
        'combo_staff
        '
        Me.combo_staff.BackColor = System.Drawing.Color.PowderBlue
        Me.combo_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_staff.FormattingEnabled = True
        Me.combo_staff.Location = New System.Drawing.Point(483, 198)
        Me.combo_staff.Margin = New System.Windows.Forms.Padding(2)
        Me.combo_staff.Name = "combo_staff"
        Me.combo_staff.Size = New System.Drawing.Size(102, 28)
        Me.combo_staff.TabIndex = 37
        '
        'lbl_tips3
        '
        Me.lbl_tips3.AutoSize = True
        Me.lbl_tips3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tips3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tips3.Location = New System.Drawing.Point(18, 240)
        Me.lbl_tips3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tips3.Name = "lbl_tips3"
        Me.lbl_tips3.Size = New System.Drawing.Size(239, 21)
        Me.lbl_tips3.TabIndex = 42
        Me.lbl_tips3.Text = "Step 3: Select favourite movie. "
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AllowUserToDeleteRows = False
        Me.grd_product.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(22, 265)
        Me.grd_product.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(484, 261)
        Me.grd_product.TabIndex = 4
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(724, 265)
        Me.grd_order.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(484, 261)
        Me.grd_order.TabIndex = 12
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.PowderBlue
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(103, 167)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(27, 24)
        Me.lbl_id.TabIndex = 45
        Me.lbl_id.Text = "ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(424, 198)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 24)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Staff: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1084, 537)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Total: "
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(1137, 535)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(76, 26)
        Me.txt_total.TabIndex = 47
        '
        'pbox_product
        '
        Me.pbox_product.BackColor = System.Drawing.Color.PowderBlue
        Me.pbox_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbox_product.Location = New System.Drawing.Point(511, 265)
        Me.pbox_product.Margin = New System.Windows.Forms.Padding(2)
        Me.pbox_product.Name = "pbox_product"
        Me.pbox_product.Size = New System.Drawing.Size(182, 261)
        Me.pbox_product.TabIndex = 48
        Me.pbox_product.TabStop = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.PowderBlue
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(103, 198)
        Me.lbl_date.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(61, 24)
        Me.lbl_date.TabIndex = 49
        Me.lbl_date.Text = "DATE"
        '
        'num_quantity
        '
        Me.num_quantity.BackColor = System.Drawing.Color.PowderBlue
        Me.num_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_quantity.Location = New System.Drawing.Point(26, 570)
        Me.num_quantity.Margin = New System.Windows.Forms.Padding(2)
        Me.num_quantity.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.num_quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_quantity.Name = "num_quantity"
        Me.num_quantity.Size = New System.Drawing.Size(55, 26)
        Me.num_quantity.TabIndex = 21
        Me.num_quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_add2cart
        '
        Me.btn_add2cart.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add2cart.Location = New System.Drawing.Point(85, 567)
        Me.btn_add2cart.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_add2cart.Name = "btn_add2cart"
        Me.btn_add2cart.Size = New System.Drawing.Size(106, 29)
        Me.btn_add2cart.TabIndex = 51
        Me.btn_add2cart.Text = "Add to Cart"
        Me.btn_add2cart.UseVisualStyleBackColor = True
        '
        'lbl_tips4
        '
        Me.lbl_tips4.AutoSize = True
        Me.lbl_tips4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tips4.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tips4.Location = New System.Drawing.Point(24, 537)
        Me.lbl_tips4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tips4.Name = "lbl_tips4"
        Me.lbl_tips4.Size = New System.Drawing.Size(413, 21)
        Me.lbl_tips4.TabIndex = 52
        Me.lbl_tips4.Text = "Step 4: Select quantity of VHS Movie then add to cart. "
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_confirm.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(1096, 579)
        Me.btn_confirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(117, 29)
        Me.btn_confirm.TabIndex = 53
        Me.btn_confirm.Text = "Confirm Order"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(724, 530)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(100, 30)
        Me.btn_clear.TabIndex = 54
        Me.btn_clear.Text = "Clear Order"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'lbl_tips5
        '
        Me.lbl_tips5.AutoSize = True
        Me.lbl_tips5.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tips5.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tips5.Location = New System.Drawing.Point(916, 582)
        Me.lbl_tips5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tips5.Name = "lbl_tips5"
        Me.lbl_tips5.Size = New System.Drawing.Size(176, 21)
        Me.lbl_tips5.TabIndex = 55
        Me.lbl_tips5.Text = "Step 5: Confirm order!"
        '
        'btn_vieworder
        '
        Me.btn_vieworder.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vieworder.Location = New System.Drawing.Point(1096, 613)
        Me.btn_vieworder.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_vieworder.Name = "btn_vieworder"
        Me.btn_vieworder.Size = New System.Drawing.Size(117, 29)
        Me.btn_vieworder.TabIndex = 56
        Me.btn_vieworder.Text = "View Order"
        Me.btn_vieworder.UseVisualStyleBackColor = True
        '
        'lbl_tips6
        '
        Me.lbl_tips6.AutoSize = True
        Me.lbl_tips6.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tips6.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tips6.Location = New System.Drawing.Point(932, 617)
        Me.lbl_tips6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tips6.Name = "lbl_tips6"
        Me.lbl_tips6.Size = New System.Drawing.Size(162, 21)
        Me.lbl_tips6.TabIndex = 57
        Me.lbl_tips6.Text = "Step 6: Check order!"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(606, 623)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(106, 29)
        Me.btn_back.TabIndex = 58
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_order_a161103
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1233, 662)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_tips6)
        Me.Controls.Add(Me.btn_vieworder)
        Me.Controls.Add(Me.lbl_tips5)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.lbl_tips4)
        Me.Controls.Add(Me.btn_add2cart)
        Me.Controls.Add(Me.num_quantity)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.pbox_product)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_tips3)
        Me.Controls.Add(Me.combo_staff)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_tips1)
        Me.Controls.Add(Me.lbl_tips2)
        Me.Controls.Add(Me.lbl_tips0)
        Me.Controls.Add(Me.combo_customer)
        Me.Controls.Add(Me.lbl_order_date)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.lbl_order)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_subtitle2)
        Me.Controls.Add(Me.lbl_subtitle)
        Me.Controls.Add(Me.lbl_title)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_order_a161103"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Order"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_subtitle2 As System.Windows.Forms.Label
    Friend WithEvents lbl_subtitle As System.Windows.Forms.Label
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lbl_order As System.Windows.Forms.Label
    Friend WithEvents lbl_customer As System.Windows.Forms.Label
    Friend WithEvents lbl_order_date As System.Windows.Forms.Label
    Friend WithEvents combo_customer As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tips0 As System.Windows.Forms.Label
    Friend WithEvents lbl_tips2 As System.Windows.Forms.Label
    Friend WithEvents lbl_tips1 As System.Windows.Forms.Label
    Friend WithEvents combo_staff As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tips3 As System.Windows.Forms.Label
    Friend WithEvents grd_product As System.Windows.Forms.DataGridView
    Friend WithEvents grd_order As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents pbox_product As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents num_quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_add2cart As System.Windows.Forms.Button
    Friend WithEvents lbl_tips4 As System.Windows.Forms.Label
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents lbl_tips5 As System.Windows.Forms.Label
    Friend WithEvents btn_vieworder As System.Windows.Forms.Button
    Friend WithEvents lbl_tips6 As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworder_a161103
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vieworder_a161103))
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_subtitle2 = New System.Windows.Forms.Label()
        Me.lbl_subtitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.combo_order = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_customer = New System.Windows.Forms.TextBox()
        Me.txt_staff = New System.Windows.Forms.TextBox()
        Me.lbl_orderdate = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Enabled = False
        Me.grd_order.Location = New System.Drawing.Point(49, 337)
        Me.grd_order.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(613, 351)
        Me.grd_order.TabIndex = 5
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Trajan Pro 3", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(201, 147)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(305, 50)
        Me.lbl_title.TabIndex = 4
        Me.lbl_title.Text = "Order History"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(65, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 147)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'lbl_subtitle2
        '
        Me.lbl_subtitle2.AutoSize = True
        Me.lbl_subtitle2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtitle2.Font = New System.Drawing.Font("Trajan Pro", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtitle2.Location = New System.Drawing.Point(300, 94)
        Me.lbl_subtitle2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_subtitle2.Name = "lbl_subtitle2"
        Me.lbl_subtitle2.Size = New System.Drawing.Size(231, 25)
        Me.lbl_subtitle2.TabIndex = 27
        Me.lbl_subtitle2.Text = "Tel/ Fax: 03-96458897"
        '
        'lbl_subtitle
        '
        Me.lbl_subtitle.AutoSize = True
        Me.lbl_subtitle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtitle.Font = New System.Drawing.Font("Trajan Pro", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtitle.Location = New System.Drawing.Point(231, 68)
        Me.lbl_subtitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_subtitle.Name = "lbl_subtitle"
        Me.lbl_subtitle.Size = New System.Drawing.Size(387, 25)
        Me.lbl_subtitle.TabIndex = 26
        Me.lbl_subtitle.Text = "3, Jalan Mega 2, Cheras, Selangor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 47)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "VHS MOVIE UNLIMITED"
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.Location = New System.Drawing.Point(45, 213)
        Me.lbl_order.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(91, 24)
        Me.lbl_order.TabIndex = 29
        Me.lbl_order.Text = "Order ID: "
        '
        'combo_order
        '
        Me.combo_order.BackColor = System.Drawing.Color.PowderBlue
        Me.combo_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_order.FormattingEnabled = True
        Me.combo_order.Location = New System.Drawing.Point(171, 213)
        Me.combo_order.Name = "combo_order"
        Me.combo_order.Size = New System.Drawing.Size(161, 28)
        Me.combo_order.TabIndex = 30
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(365, 213)
        Me.lbl_customer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(123, 24)
        Me.lbl_customer.TabIndex = 31
        Me.lbl_customer.Text = "Customer ID: "
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.Location = New System.Drawing.Point(365, 253)
        Me.lbl_staff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(133, 24)
        Me.lbl_staff.TabIndex = 33
        Me.lbl_staff.Text = "Staff Incharge: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 293)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Total: "
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(171, 293)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(161, 26)
        Me.txt_total.TabIndex = 36
        '
        'txt_customer
        '
        Me.txt_customer.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer.Location = New System.Drawing.Point(501, 213)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.ReadOnly = True
        Me.txt_customer.Size = New System.Drawing.Size(161, 26)
        Me.txt_customer.TabIndex = 37
        '
        'txt_staff
        '
        Me.txt_staff.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff.Location = New System.Drawing.Point(501, 253)
        Me.txt_staff.Name = "txt_staff"
        Me.txt_staff.ReadOnly = True
        Me.txt_staff.Size = New System.Drawing.Size(161, 26)
        Me.txt_staff.TabIndex = 38
        '
        'lbl_orderdate
        '
        Me.lbl_orderdate.AutoSize = True
        Me.lbl_orderdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderdate.Location = New System.Drawing.Point(45, 253)
        Me.lbl_orderdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_orderdate.Name = "lbl_orderdate"
        Me.lbl_orderdate.Size = New System.Drawing.Size(112, 24)
        Me.lbl_orderdate.TabIndex = 39
        Me.lbl_orderdate.Text = "Order Date: "
        '
        'txt_date
        '
        Me.txt_date.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Location = New System.Drawing.Point(171, 253)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.ReadOnly = True
        Me.txt_date.Size = New System.Drawing.Size(161, 26)
        Me.txt_date.TabIndex = 40
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(542, 698)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(120, 30)
        Me.btn_back.TabIndex = 58
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_vieworder_a161103
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 740)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.lbl_orderdate)
        Me.Controls.Add(Me.txt_staff)
        Me.Controls.Add(Me.txt_customer)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.combo_order)
        Me.Controls.Add(Me.lbl_order)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_subtitle2)
        Me.Controls.Add(Me.lbl_subtitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.lbl_title)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_vieworder_a161103"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Order"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_order As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_subtitle2 As System.Windows.Forms.Label
    Friend WithEvents lbl_subtitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_order As System.Windows.Forms.Label
    Friend WithEvents combo_order As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_customer As System.Windows.Forms.Label
    Friend WithEvents lbl_staff As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_customer As System.Windows.Forms.TextBox
    Friend WithEvents txt_staff As System.Windows.Forms.TextBox
    Friend WithEvents lbl_orderdate As System.Windows.Forms.Label
    Friend WithEvents txt_date As System.Windows.Forms.TextBox
    Friend WithEvents btn_back As System.Windows.Forms.Button
End Class

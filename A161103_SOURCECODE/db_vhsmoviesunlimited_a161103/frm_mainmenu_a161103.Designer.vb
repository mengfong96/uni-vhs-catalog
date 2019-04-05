<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_a161103
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_a161103))
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_orderlist = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_addmovie = New System.Windows.Forms.Button()
        Me.lbl_subtitle = New System.Windows.Forms.Label()
        Me.lbl_subtitle2 = New System.Windows.Forms.Label()
        Me.btn_productdetails = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Minion Pro", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(12, 9)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(44, 24)
        Me.lbl_date.TabIndex = 15
        Me.lbl_date.Text = "Date"
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Pink
        Me.btn_exit.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(1000, 566)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(175, 46)
        Me.btn_exit.TabIndex = 14
        Me.btn_exit.Text = "Log Out"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.Location = New System.Drawing.Point(23, 566)
        Me.btn_staff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(171, 46)
        Me.btn_staff.TabIndex = 13
        Me.btn_staff.Text = "Staff Info"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_orderlist
        '
        Me.btn_orderlist.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderlist.Location = New System.Drawing.Point(23, 505)
        Me.btn_orderlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_orderlist.Name = "btn_orderlist"
        Me.btn_orderlist.Size = New System.Drawing.Size(171, 46)
        Me.btn_orderlist.TabIndex = 12
        Me.btn_orderlist.Text = "View Order"
        Me.btn_orderlist.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_order.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Location = New System.Drawing.Point(23, 443)
        Me.btn_order.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(361, 46)
        Me.btn_order.TabIndex = 11
        Me.btn_order.Text = "Make Order!"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'btn_customer
        '
        Me.btn_customer.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Location = New System.Drawing.Point(209, 566)
        Me.btn_customer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(175, 46)
        Me.btn_customer.TabIndex = 10
        Me.btn_customer.Text = "Customer Info"
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_product
        '
        Me.btn_product.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product.Location = New System.Drawing.Point(23, 320)
        Me.btn_product.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(361, 46)
        Me.btn_product.TabIndex = 9
        Me.btn_product.Text = "Movie Catalog"
        Me.btn_product.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(373, 25)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(556, 59)
        Me.lbl_title.TabIndex = 8
        Me.lbl_title.Text = "VHS MOVIE UNLIMITED"
        '
        'btn_addmovie
        '
        Me.btn_addmovie.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addmovie.Location = New System.Drawing.Point(23, 382)
        Me.btn_addmovie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_addmovie.Name = "btn_addmovie"
        Me.btn_addmovie.Size = New System.Drawing.Size(171, 46)
        Me.btn_addmovie.TabIndex = 16
        Me.btn_addmovie.Text = "Insert Movie"
        Me.btn_addmovie.UseVisualStyleBackColor = True
        '
        'lbl_subtitle
        '
        Me.lbl_subtitle.AutoSize = True
        Me.lbl_subtitle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtitle.Font = New System.Drawing.Font("Trajan Pro", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtitle.Location = New System.Drawing.Point(412, 84)
        Me.lbl_subtitle.Name = "lbl_subtitle"
        Me.lbl_subtitle.Size = New System.Drawing.Size(485, 31)
        Me.lbl_subtitle.TabIndex = 17
        Me.lbl_subtitle.Text = "3, Jalan Mega 2, Cheras, Selangor"
        '
        'lbl_subtitle2
        '
        Me.lbl_subtitle2.AutoSize = True
        Me.lbl_subtitle2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtitle2.Font = New System.Drawing.Font("Trajan Pro", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtitle2.Location = New System.Drawing.Point(504, 114)
        Me.lbl_subtitle2.Name = "lbl_subtitle2"
        Me.lbl_subtitle2.Size = New System.Drawing.Size(289, 31)
        Me.lbl_subtitle2.TabIndex = 18
        Me.lbl_subtitle2.Text = "Tel/ Fax: 03-96458897"
        '
        'btn_productdetails
        '
        Me.btn_productdetails.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productdetails.Location = New System.Drawing.Point(209, 382)
        Me.btn_productdetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_productdetails.Name = "btn_productdetails"
        Me.btn_productdetails.Size = New System.Drawing.Size(175, 46)
        Me.btn_productdetails.TabIndex = 19
        Me.btn_productdetails.Text = "Movie Details"
        Me.btn_productdetails.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(191, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 181)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(209, 505)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 46)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Order List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_mainmenu_a161103
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1189, 650)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_productdetails)
        Me.Controls.Add(Me.lbl_subtitle2)
        Me.Controls.Add(Me.lbl_subtitle)
        Me.Controls.Add(Me.btn_addmovie)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_orderlist)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_mainmenu_a161103"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VHS MOVIE UNLIMITED"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_staff As System.Windows.Forms.Button
    Friend WithEvents btn_orderlist As System.Windows.Forms.Button
    Friend WithEvents btn_order As System.Windows.Forms.Button
    Friend WithEvents btn_customer As System.Windows.Forms.Button
    Friend WithEvents btn_product As System.Windows.Forms.Button
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents btn_addmovie As System.Windows.Forms.Button
    Friend WithEvents lbl_subtitle As System.Windows.Forms.Label
    Friend WithEvents lbl_subtitle2 As System.Windows.Forms.Label
    Friend WithEvents btn_productdetails As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

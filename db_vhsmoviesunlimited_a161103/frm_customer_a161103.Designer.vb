<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer_a161103
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customer_a161103))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_customerid = New System.Windows.Forms.TextBox()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.txt_customerphoneno = New System.Windows.Forms.TextBox()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.lbl_staff_phoneno = New System.Windows.Forms.Label()
        Me.lbl_staffname = New System.Windows.Forms.Label()
        Me.lst_customer = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(366, 268)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(82, 32)
        Me.btn_back.TabIndex = 2
        Me.btn_back.Text = "Close"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 47)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Customer"
        '
        'txt_customerid
        '
        Me.txt_customerid.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_customerid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customerid.Location = New System.Drawing.Point(299, 100)
        Me.txt_customerid.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_customerid.Name = "txt_customerid"
        Me.txt_customerid.Size = New System.Drawing.Size(138, 26)
        Me.txt_customerid.TabIndex = 31
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.Location = New System.Drawing.Point(170, 104)
        Me.lbl_staffid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(99, 18)
        Me.lbl_staffid.TabIndex = 30
        Me.lbl_staffid.Text = "Customer ID:"
        '
        'txt_customerphoneno
        '
        Me.txt_customerphoneno.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_customerphoneno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customerphoneno.Location = New System.Drawing.Point(299, 165)
        Me.txt_customerphoneno.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_customerphoneno.Name = "txt_customerphoneno"
        Me.txt_customerphoneno.Size = New System.Drawing.Size(138, 26)
        Me.txt_customerphoneno.TabIndex = 29
        '
        'txt_customername
        '
        Me.txt_customername.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_customername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customername.Location = New System.Drawing.Point(299, 132)
        Me.txt_customername.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.Size = New System.Drawing.Size(138, 26)
        Me.txt_customername.TabIndex = 28
        '
        'lbl_staff_phoneno
        '
        Me.lbl_staff_phoneno.AutoSize = True
        Me.lbl_staff_phoneno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff_phoneno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_phoneno.Location = New System.Drawing.Point(170, 168)
        Me.lbl_staff_phoneno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_staff_phoneno.Name = "lbl_staff_phoneno"
        Me.lbl_staff_phoneno.Size = New System.Drawing.Size(94, 18)
        Me.lbl_staff_phoneno.TabIndex = 27
        Me.lbl_staff_phoneno.Text = "Contact No.:"
        '
        'lbl_staffname
        '
        Me.lbl_staffname.AutoSize = True
        Me.lbl_staffname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffname.Location = New System.Drawing.Point(170, 136)
        Me.lbl_staffname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_staffname.Name = "lbl_staffname"
        Me.lbl_staffname.Size = New System.Drawing.Size(126, 18)
        Me.lbl_staffname.TabIndex = 26
        Me.lbl_staffname.Text = "Customer Name:"
        '
        'lst_customer
        '
        Me.lst_customer.BackColor = System.Drawing.Color.PowderBlue
        Me.lst_customer.FormattingEnabled = True
        Me.lst_customer.Location = New System.Drawing.Point(42, 104)
        Me.lst_customer.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_customer.Name = "lst_customer"
        Me.lst_customer.Size = New System.Drawing.Size(124, 134)
        Me.lst_customer.TabIndex = 25
        '
        'frm_customer_a161103
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(459, 303)
        Me.Controls.Add(Me.txt_customerid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.txt_customerphoneno)
        Me.Controls.Add(Me.txt_customername)
        Me.Controls.Add(Me.lbl_staff_phoneno)
        Me.Controls.Add(Me.lbl_staffname)
        Me.Controls.Add(Me.lst_customer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_back)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_customer_a161103"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_customerid As System.Windows.Forms.TextBox
    Friend WithEvents lbl_staffid As System.Windows.Forms.Label
    Friend WithEvents txt_customerphoneno As System.Windows.Forms.TextBox
    Friend WithEvents txt_customername As System.Windows.Forms.TextBox
    Friend WithEvents lbl_staff_phoneno As System.Windows.Forms.Label
    Friend WithEvents lbl_staffname As System.Windows.Forms.Label
    Friend WithEvents lst_customer As System.Windows.Forms.ListBox
End Class

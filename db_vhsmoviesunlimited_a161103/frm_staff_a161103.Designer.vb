<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staff_a161103
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staff_a161103))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lst_staff = New System.Windows.Forms.ListBox()
        Me.lbl_inquiry = New System.Windows.Forms.Label()
        Me.lbl_staffname = New System.Windows.Forms.Label()
        Me.lbl_staff_phoneno = New System.Windows.Forms.Label()
        Me.txt_staffname = New System.Windows.Forms.TextBox()
        Me.txt_staffphoneno = New System.Windows.Forms.TextBox()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(366, 268)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(82, 32)
        Me.btn_back.TabIndex = 10
        Me.btn_back.Text = "Close"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(11, 9)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(101, 47)
        Me.lbl_title.TabIndex = 8
        Me.lbl_title.Text = "Staff"
        '
        'lst_staff
        '
        Me.lst_staff.BackColor = System.Drawing.Color.PowderBlue
        Me.lst_staff.FormattingEnabled = True
        Me.lst_staff.Location = New System.Drawing.Point(42, 104)
        Me.lst_staff.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_staff.Name = "lst_staff"
        Me.lst_staff.Size = New System.Drawing.Size(124, 134)
        Me.lst_staff.TabIndex = 17
        '
        'lbl_inquiry
        '
        Me.lbl_inquiry.AutoSize = True
        Me.lbl_inquiry.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inquiry.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inquiry.Location = New System.Drawing.Point(11, 277)
        Me.lbl_inquiry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_inquiry.Name = "lbl_inquiry"
        Me.lbl_inquiry.Size = New System.Drawing.Size(343, 17)
        Me.lbl_inquiry.TabIndex = 18
        Me.lbl_inquiry.Text = "Tips: If you have any inquiries, please contact any one of us. "
        '
        'lbl_staffname
        '
        Me.lbl_staffname.AutoSize = True
        Me.lbl_staffname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffname.Location = New System.Drawing.Point(170, 136)
        Me.lbl_staffname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_staffname.Name = "lbl_staffname"
        Me.lbl_staffname.Size = New System.Drawing.Size(90, 18)
        Me.lbl_staffname.TabIndex = 19
        Me.lbl_staffname.Text = "Staff Name:"
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
        Me.lbl_staff_phoneno.TabIndex = 20
        Me.lbl_staff_phoneno.Text = "Contact No.:"
        '
        'txt_staffname
        '
        Me.txt_staffname.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_staffname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffname.Location = New System.Drawing.Point(299, 132)
        Me.txt_staffname.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_staffname.Name = "txt_staffname"
        Me.txt_staffname.Size = New System.Drawing.Size(138, 26)
        Me.txt_staffname.TabIndex = 21
        '
        'txt_staffphoneno
        '
        Me.txt_staffphoneno.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_staffphoneno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffphoneno.Location = New System.Drawing.Point(299, 165)
        Me.txt_staffphoneno.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_staffphoneno.Name = "txt_staffphoneno"
        Me.txt_staffphoneno.Size = New System.Drawing.Size(138, 26)
        Me.txt_staffphoneno.TabIndex = 22
        '
        'txt_staffid
        '
        Me.txt_staffid.BackColor = System.Drawing.Color.PowderBlue
        Me.txt_staffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffid.Location = New System.Drawing.Point(299, 100)
        Me.txt_staffid.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.Size = New System.Drawing.Size(138, 26)
        Me.txt_staffid.TabIndex = 24
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.Location = New System.Drawing.Point(170, 104)
        Me.lbl_staffid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(63, 18)
        Me.lbl_staffid.TabIndex = 23
        Me.lbl_staffid.Text = "Staff ID:"
        '
        'frm_staff_a161103
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(459, 303)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.txt_staffphoneno)
        Me.Controls.Add(Me.txt_staffname)
        Me.Controls.Add(Me.lbl_staff_phoneno)
        Me.Controls.Add(Me.lbl_staffname)
        Me.Controls.Add(Me.lbl_inquiry)
        Me.Controls.Add(Me.lst_staff)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_title)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_staff_a161103"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lst_staff As System.Windows.Forms.ListBox
    Friend WithEvents lbl_inquiry As System.Windows.Forms.Label
    Friend WithEvents lbl_staffname As System.Windows.Forms.Label
    Friend WithEvents lbl_staff_phoneno As System.Windows.Forms.Label
    Friend WithEvents txt_staffname As System.Windows.Forms.TextBox
    Friend WithEvents txt_staffphoneno As System.Windows.Forms.TextBox
    Friend WithEvents txt_staffid As System.Windows.Forms.TextBox
    Friend WithEvents lbl_staffid As System.Windows.Forms.Label
End Class

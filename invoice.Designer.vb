<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(invoice))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.cmbcusname = New System.Windows.Forms.ComboBox()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Service_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnisave = New System.Windows.Forms.Button()
        Me.btnprintpreview = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.discount = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.gtotal = New System.Windows.Forms.Label()
        Me.cmbservice = New System.Windows.Forms.ComboBox()
        Me.txttotal = New System.Windows.Forms.Label()
        Me.txtdiscount = New System.Windows.Forms.Label()
        Me.txtgrand = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LavenderBlush
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txttime)
        Me.GroupBox1.Controls.Add(Me.txtcustomer)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.cmbcusname)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Controls.Add(Me.phone)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1112, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(649, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Time:"
        '
        'txttime
        '
        Me.txttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.Location = New System.Drawing.Point(729, 80)
        Me.txttime.Name = "txttime"
        Me.txttime.ReadOnly = True
        Me.txttime.Size = New System.Drawing.Size(116, 28)
        Me.txttime.TabIndex = 25
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(212, 103)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.ReadOnly = True
        Me.txtcustomer.Size = New System.Drawing.Size(298, 34)
        Me.txtcustomer.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Customer Name:"
        '
        'dtp
        '
        Me.dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Location = New System.Drawing.Point(729, 41)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(345, 30)
        Me.dtp.TabIndex = 3
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(930, 154)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(70, 26)
        Me.rb2.TabIndex = 3
        Me.rb2.TabStop = True
        Me.rb2.Text = "Card"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'cmbcusname
        '
        Me.cmbcusname.FormattingEnabled = True
        Me.cmbcusname.Location = New System.Drawing.Point(212, 43)
        Me.cmbcusname.Name = "cmbcusname"
        Me.cmbcusname.Size = New System.Drawing.Size(182, 37)
        Me.cmbcusname.TabIndex = 2
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(821, 154)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(73, 26)
        Me.rb1.TabIndex = 3
        Me.rb1.TabStop = True
        Me.rb1.Text = "Cash"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(212, 155)
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.Size = New System.Drawing.Size(298, 34)
        Me.phone.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(618, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 25)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Payment Method:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(649, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Phone Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Id:"
        '
        'DataGridView5
        '
        Me.DataGridView5.BackgroundColor = System.Drawing.Color.Lavender
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Service_Name})
        Me.DataGridView5.GridColor = System.Drawing.Color.LightPink
        Me.DataGridView5.Location = New System.Drawing.Point(46, 404)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(1090, 148)
        Me.DataGridView5.TabIndex = 4
        '
        'Service_Name
        '
        Me.Service_Name.HeaderText = "Column1"
        Me.Service_Name.MinimumWidth = 6
        Me.Service_Name.Name = "Service_Name"
        Me.Service_Name.Width = 125
        '
        'btnisave
        '
        Me.btnisave.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnisave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnisave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnisave.Location = New System.Drawing.Point(46, 577)
        Me.btnisave.Name = "btnisave"
        Me.btnisave.Size = New System.Drawing.Size(178, 63)
        Me.btnisave.TabIndex = 5
        Me.btnisave.Text = "Save Invoice"
        Me.btnisave.UseVisualStyleBackColor = False
        '
        'btnprintpreview
        '
        Me.btnprintpreview.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnprintpreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprintpreview.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnprintpreview.Location = New System.Drawing.Point(244, 577)
        Me.btnprintpreview.Name = "btnprintpreview"
        Me.btnprintpreview.Size = New System.Drawing.Size(178, 63)
        Me.btnprintpreview.TabIndex = 5
        Me.btnprintpreview.Text = "Print Preview"
        Me.btnprintpreview.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.DeepPink
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnadd.Location = New System.Drawing.Point(438, 346)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(128, 44)
        Me.btnadd.TabIndex = 5
        Me.btnadd.Text = "Add service"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'piclogo
        '
        Me.piclogo.Image = CType(resources.GetObject("piclogo.Image"), System.Drawing.Image)
        Me.piclogo.Location = New System.Drawing.Point(31, 12)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(97, 104)
        Me.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclogo.TabIndex = 13
        Me.piclogo.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(134, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 33)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "SalonEase"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label13.Font = New System.Drawing.Font("SansSerif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(446, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(210, 35)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Create Invoice"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Invoice Items:"
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnprint.Location = New System.Drawing.Point(438, 577)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(178, 63)
        Me.btnprint.TabIndex = 19
        Me.btnprint.Text = "Print Invoice"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(744, 558)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sub Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(753, 605)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Discount:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(689, 641)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 29)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Grand Total:"
        '
        'discount
        '
        Me.discount.AutoSize = True
        Me.discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount.Location = New System.Drawing.Point(877, 605)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(0, 25)
        Me.discount.TabIndex = 22
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(877, 558)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(0, 25)
        Me.total.TabIndex = 23
        '
        'gtotal
        '
        Me.gtotal.AutoSize = True
        Me.gtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtotal.Location = New System.Drawing.Point(877, 641)
        Me.gtotal.Name = "gtotal"
        Me.gtotal.Size = New System.Drawing.Size(0, 29)
        Me.gtotal.TabIndex = 24
        '
        'cmbservice
        '
        Me.cmbservice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbservice.FormattingEnabled = True
        Me.cmbservice.Location = New System.Drawing.Point(190, 346)
        Me.cmbservice.Name = "cmbservice"
        Me.cmbservice.Size = New System.Drawing.Size(182, 30)
        Me.cmbservice.TabIndex = 27
        '
        'txttotal
        '
        Me.txttotal.AutoSize = True
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(853, 558)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(23, 25)
        Me.txttotal.TabIndex = 28
        Me.txttotal.Text = "0"
        '
        'txtdiscount
        '
        Me.txtdiscount.AutoSize = True
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.Location = New System.Drawing.Point(853, 605)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(23, 25)
        Me.txtdiscount.TabIndex = 29
        Me.txtdiscount.Text = "0"
        '
        'txtgrand
        '
        Me.txtgrand.AutoSize = True
        Me.txtgrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrand.Location = New System.Drawing.Point(853, 641)
        Me.txtgrand.Name = "txtgrand"
        Me.txtgrand.Size = New System.Drawing.Size(27, 29)
        Me.txtgrand.TabIndex = 30
        Me.txtgrand.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1116, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(1183, 724)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtgrand)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.cmbservice)
        Me.Controls.Add(Me.gtotal)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.discount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.piclogo)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnprintpreview)
        Me.Controls.Add(Me.btnisave)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "invoice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents cmbcusname As ComboBox
    Friend WithEvents phone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents Service_Name As DataGridViewTextBoxColumn
    Friend WithEvents btnisave As Button
    Friend WithEvents btnprintpreview As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents piclogo As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnprint As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcustomer As TextBox
    Friend WithEvents discount As Label
    Friend WithEvents total As Label
    Friend WithEvents gtotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txttime As TextBox
    Friend WithEvents cmbservice As ComboBox
    Friend WithEvents txttotal As Label
    Friend WithEvents txtdiscount As Label
    Friend WithEvents txtgrand As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

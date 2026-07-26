<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcustomernames = New System.Windows.Forms.TextBox()
        Me.txtphonecus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.btneditcus = New System.Windows.Forms.Button()
        Me.btnnewcus = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtsearchcustomer = New System.Windows.Forms.TextBox()
        Me.searchcutomer = New System.Windows.Forms.Button()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblstaff = New System.Windows.Forms.Label()
        Me.btnlogoutsstaff = New System.Windows.Forms.Button()
        Me.txtcutomerid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(6, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1073, 84)
        Me.Panel1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(852, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 33)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "SalonEase"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(986, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(79, 80)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(7, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1267, 10)
        Me.Panel2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.HotPink
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(295, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(516, 44)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Customer Management"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Phone:"
        '
        'txtcustomernames
        '
        Me.txtcustomernames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomernames.Location = New System.Drawing.Point(176, 197)
        Me.txtcustomernames.Name = "txtcustomernames"
        Me.txtcustomernames.Size = New System.Drawing.Size(307, 30)
        Me.txtcustomernames.TabIndex = 6
        '
        'txtphonecus
        '
        Me.txtphonecus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphonecus.Location = New System.Drawing.Point(176, 245)
        Me.txtphonecus.Name = "txtphonecus"
        Me.txtphonecus.Size = New System.Drawing.Size(307, 30)
        Me.txtphonecus.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Address:"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(176, 294)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(307, 30)
        Me.txtaddress.TabIndex = 6
        '
        'btneditcus
        '
        Me.btneditcus.BackColor = System.Drawing.Color.Goldenrod
        Me.btneditcus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneditcus.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditcus.ForeColor = System.Drawing.Color.White
        Me.btneditcus.Location = New System.Drawing.Point(152, 381)
        Me.btneditcus.Name = "btneditcus"
        Me.btneditcus.Size = New System.Drawing.Size(116, 53)
        Me.btneditcus.TabIndex = 10
        Me.btneditcus.Text = "Edit"
        Me.btneditcus.UseVisualStyleBackColor = False
        '
        'btnnewcus
        '
        Me.btnnewcus.BackColor = System.Drawing.Color.Green
        Me.btnnewcus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnewcus.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewcus.ForeColor = System.Drawing.Color.White
        Me.btnnewcus.Location = New System.Drawing.Point(13, 381)
        Me.btnnewcus.Name = "btnnewcus"
        Me.btnnewcus.Size = New System.Drawing.Size(118, 53)
        Me.btnnewcus.TabIndex = 10
        Me.btnnewcus.Text = " Add "
        Me.btnnewcus.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Firebrick
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(301, 381)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(119, 53)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'txtsearchcustomer
        '
        Me.txtsearchcustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchcustomer.Location = New System.Drawing.Point(665, 142)
        Me.txtsearchcustomer.Name = "txtsearchcustomer"
        Me.txtsearchcustomer.Size = New System.Drawing.Size(307, 30)
        Me.txtsearchcustomer.TabIndex = 6
        '
        'searchcutomer
        '
        Me.searchcutomer.BackColor = System.Drawing.Color.SteelBlue
        Me.searchcutomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchcutomer.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchcutomer.ForeColor = System.Drawing.Color.White
        Me.searchcutomer.Location = New System.Drawing.Point(530, 139)
        Me.searchcutomer.Name = "searchcutomer"
        Me.searchcutomer.Size = New System.Drawing.Size(113, 36)
        Me.searchcutomer.TabIndex = 10
        Me.searchcutomer.Text = "Search"
        Me.searchcutomer.UseVisualStyleBackColor = False
        '
        'DataGridView7
        '
        Me.DataGridView7.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView7.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView7.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView7.GridColor = System.Drawing.Color.Pink
        Me.DataGridView7.Location = New System.Drawing.Point(541, 237)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.RowHeadersWidth = 51
        Me.DataGridView7.RowTemplate.Height = 24
        Me.DataGridView7.Size = New System.Drawing.Size(445, 197)
        Me.DataGridView7.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(593, 449)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Total Customers:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.HotPink
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(541, 197)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(445, 37)
        Me.Panel4.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(214, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Customer List"
        '
        'lblstaff
        '
        Me.lblstaff.AutoSize = True
        Me.lblstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaff.Location = New System.Drawing.Point(754, 447)
        Me.lblstaff.Name = "lblstaff"
        Me.lblstaff.Size = New System.Drawing.Size(23, 25)
        Me.lblstaff.TabIndex = 19
        Me.lblstaff.Text = "0"
        '
        'btnlogoutsstaff
        '
        Me.btnlogoutsstaff.BackColor = System.Drawing.Color.LightPink
        Me.btnlogoutsstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogoutsstaff.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogoutsstaff.ForeColor = System.Drawing.Color.Crimson
        Me.btnlogoutsstaff.Location = New System.Drawing.Point(27, 464)
        Me.btnlogoutsstaff.Name = "btnlogoutsstaff"
        Me.btnlogoutsstaff.Size = New System.Drawing.Size(86, 42)
        Me.btnlogoutsstaff.TabIndex = 20
        Me.btnlogoutsstaff.Text = "Exit"
        Me.btnlogoutsstaff.UseVisualStyleBackColor = False
        '
        'txtcutomerid
        '
        Me.txtcutomerid.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtcutomerid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcutomerid.Location = New System.Drawing.Point(167, 136)
        Me.txtcutomerid.Name = "txtcutomerid"
        Me.txtcutomerid.ReadOnly = True
        Me.txtcutomerid.Size = New System.Drawing.Size(85, 30)
        Me.txtcutomerid.TabIndex = 6
        Me.txtcutomerid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Customer Id:"
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(1080, 549)
        Me.Controls.Add(Me.btnlogoutsstaff)
        Me.Controls.Add(Me.lblstaff)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView7)
        Me.Controls.Add(Me.btnnewcus)
        Me.Controls.Add(Me.searchcutomer)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.txtsearchcustomer)
        Me.Controls.Add(Me.btneditcus)
        Me.Controls.Add(Me.txtcutomerid)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtphonecus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcustomernames)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcustomernames As TextBox
    Friend WithEvents txtphonecus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents btneditcus As Button
    Friend WithEvents btnnewcus As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents txtsearchcustomer As TextBox
    Friend WithEvents searchcutomer As Button
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblstaff As Label
    Friend WithEvents btnlogoutsstaff As Button
    Friend WithEvents txtcutomerid As TextBox
    Friend WithEvents Label4 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtstaffname = New System.Windows.Forms.TextBox()
        Me.cmbstaffservice = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtnote = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnaddsstaff = New System.Windows.Forms.Button()
        Me.btnupdatesstaff = New System.Windows.Forms.Button()
        Me.btndeletesstaff = New System.Windows.Forms.Button()
        Me.btnclearsstaff = New System.Windows.Forms.Button()
        Me.btnlogoutsstaff = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblstaff = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtstaffid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(1, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1139, 84)
        Me.Panel1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(904, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 33)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "SalonEase"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1047, 0)
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
        Me.TextBox1.Text = "Staff Management"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Service:"
        '
        'txtstaffname
        '
        Me.txtstaffname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaffname.Location = New System.Drawing.Point(120, 131)
        Me.txtstaffname.Name = "txtstaffname"
        Me.txtstaffname.Size = New System.Drawing.Size(333, 30)
        Me.txtstaffname.TabIndex = 6
        '
        'cmbstaffservice
        '
        Me.cmbstaffservice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstaffservice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstaffservice.FormattingEnabled = True
        Me.cmbstaffservice.Location = New System.Drawing.Point(120, 172)
        Me.cmbstaffservice.Name = "cmbstaffservice"
        Me.cmbstaffservice.Size = New System.Drawing.Size(333, 33)
        Me.cmbstaffservice.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Phone:"
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(120, 216)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(333, 30)
        Me.txtphone.TabIndex = 6
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(120, 270)
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(333, 99)
        Me.txtnote.TabIndex = 8
        Me.txtnote.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Note:"
        '
        'btnaddsstaff
        '
        Me.btnaddsstaff.BackColor = System.Drawing.Color.Green
        Me.btnaddsstaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddsstaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddsstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddsstaff.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddsstaff.ForeColor = System.Drawing.Color.White
        Me.btnaddsstaff.Location = New System.Drawing.Point(25, 397)
        Me.btnaddsstaff.Name = "btnaddsstaff"
        Me.btnaddsstaff.Size = New System.Drawing.Size(148, 53)
        Me.btnaddsstaff.TabIndex = 9
        Me.btnaddsstaff.Text = "Add Staff"
        Me.btnaddsstaff.UseVisualStyleBackColor = False
        '
        'btnupdatesstaff
        '
        Me.btnupdatesstaff.BackColor = System.Drawing.Color.Goldenrod
        Me.btnupdatesstaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdatesstaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive
        Me.btnupdatesstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdatesstaff.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdatesstaff.ForeColor = System.Drawing.Color.White
        Me.btnupdatesstaff.Location = New System.Drawing.Point(221, 397)
        Me.btnupdatesstaff.Name = "btnupdatesstaff"
        Me.btnupdatesstaff.Size = New System.Drawing.Size(160, 53)
        Me.btnupdatesstaff.TabIndex = 10
        Me.btnupdatesstaff.Text = "Update Staff"
        Me.btnupdatesstaff.UseVisualStyleBackColor = False
        '
        'btndeletesstaff
        '
        Me.btndeletesstaff.BackColor = System.Drawing.Color.Crimson
        Me.btndeletesstaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeletesstaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btndeletesstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletesstaff.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletesstaff.ForeColor = System.Drawing.Color.White
        Me.btndeletesstaff.Location = New System.Drawing.Point(63, 471)
        Me.btndeletesstaff.Name = "btndeletesstaff"
        Me.btndeletesstaff.Size = New System.Drawing.Size(168, 51)
        Me.btndeletesstaff.TabIndex = 11
        Me.btndeletesstaff.Text = "Delete Staff"
        Me.btndeletesstaff.UseVisualStyleBackColor = False
        '
        'btnclearsstaff
        '
        Me.btnclearsstaff.BackColor = System.Drawing.Color.Orchid
        Me.btnclearsstaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclearsstaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnclearsstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclearsstaff.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclearsstaff.ForeColor = System.Drawing.Color.White
        Me.btnclearsstaff.Location = New System.Drawing.Point(296, 478)
        Me.btnclearsstaff.Name = "btnclearsstaff"
        Me.btnclearsstaff.Size = New System.Drawing.Size(109, 44)
        Me.btnclearsstaff.TabIndex = 12
        Me.btnclearsstaff.Text = "Clear"
        Me.btnclearsstaff.UseVisualStyleBackColor = False
        '
        'btnlogoutsstaff
        '
        Me.btnlogoutsstaff.BackColor = System.Drawing.Color.LightPink
        Me.btnlogoutsstaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogoutsstaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink
        Me.btnlogoutsstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogoutsstaff.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogoutsstaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlogoutsstaff.Location = New System.Drawing.Point(39, 554)
        Me.btnlogoutsstaff.Name = "btnlogoutsstaff"
        Me.btnlogoutsstaff.Size = New System.Drawing.Size(86, 42)
        Me.btnlogoutsstaff.TabIndex = 13
        Me.btnlogoutsstaff.Text = "Exit"
        Me.btnlogoutsstaff.UseVisualStyleBackColor = False
        '
        'DataGridView4
        '
        Me.DataGridView4.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(533, 216)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(544, 290)
        Me.DataGridView4.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.HotPink
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(533, 175)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(544, 37)
        Me.Panel4.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Staff List"
        '
        'lblstaff
        '
        Me.lblstaff.AutoSize = True
        Me.lblstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaff.Location = New System.Drawing.Point(745, 526)
        Me.lblstaff.Name = "lblstaff"
        Me.lblstaff.Size = New System.Drawing.Size(23, 25)
        Me.lblstaff.TabIndex = 17
        Me.lblstaff.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(517, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Staff Id:"
        '
        'txtstaffid
        '
        Me.txtstaffid.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtstaffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaffid.Location = New System.Drawing.Point(616, 123)
        Me.txtstaffid.Name = "txtstaffid"
        Me.txtstaffid.ReadOnly = True
        Me.txtstaffid.Size = New System.Drawing.Size(85, 30)
        Me.txtstaffid.TabIndex = 19
        Me.txtstaffid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(627, 526)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total Staff:"
        '
        'staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(1145, 646)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtstaffid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblstaff)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.btnlogoutsstaff)
        Me.Controls.Add(Me.btnclearsstaff)
        Me.Controls.Add(Me.btndeletesstaff)
        Me.Controls.Add(Me.btnupdatesstaff)
        Me.Controls.Add(Me.btnaddsstaff)
        Me.Controls.Add(Me.txtnote)
        Me.Controls.Add(Me.cmbstaffservice)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtstaffname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents txtstaffname As TextBox
    Friend WithEvents cmbstaffservice As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtnote As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnaddsstaff As Button
    Friend WithEvents btnupdatesstaff As Button
    Friend WithEvents btndeletesstaff As Button
    Friend WithEvents btnclearsstaff As Button
    Friend WithEvents btnlogoutsstaff As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblstaff As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtstaffid As TextBox
    Friend WithEvents Label6 As Label
End Class

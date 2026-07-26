<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class appointmentsee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appointmentsee))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbservice = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.richdec = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnadda = New System.Windows.Forms.Button()
        Me.btncleara = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.lblapp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.cmbtime = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbnamee = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 84)
        Me.Panel1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(1033, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 33)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "SalonEase"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1167, 0)
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
        Me.TextBox1.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(295, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(516, 49)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Appointment Management"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        '
        'cmbservice
        '
        Me.cmbservice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbservice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbservice.FormattingEnabled = True
        Me.cmbservice.Location = New System.Drawing.Point(90, 199)
        Me.cmbservice.Name = "cmbservice"
        Me.cmbservice.Size = New System.Drawing.Size(333, 33)
        Me.cmbservice.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Service:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date:"
        '
        'dtpdate
        '
        Me.dtpdate.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdate.Location = New System.Drawing.Point(98, 251)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(325, 32)
        Me.dtpdate.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Time:"
        '
        'richdec
        '
        Me.richdec.Location = New System.Drawing.Point(98, 350)
        Me.richdec.Name = "richdec"
        Me.richdec.Size = New System.Drawing.Size(333, 63)
        Me.richdec.TabIndex = 7
        Me.richdec.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 25)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Note:"
        '
        'btnadda
        '
        Me.btnadda.BackColor = System.Drawing.Color.Green
        Me.btnadda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnadda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadda.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadda.ForeColor = System.Drawing.Color.White
        Me.btnadda.Location = New System.Drawing.Point(19, 441)
        Me.btnadda.Name = "btnadda"
        Me.btnadda.Size = New System.Drawing.Size(104, 47)
        Me.btnadda.TabIndex = 8
        Me.btnadda.Text = "Add "
        Me.btnadda.UseVisualStyleBackColor = False
        '
        'btncleara
        '
        Me.btncleara.BackColor = System.Drawing.Color.BlueViolet
        Me.btncleara.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncleara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btncleara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncleara.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncleara.ForeColor = System.Drawing.Color.White
        Me.btncleara.Location = New System.Drawing.Point(316, 441)
        Me.btncleara.Name = "btncleara"
        Me.btncleara.Size = New System.Drawing.Size(115, 47)
        Me.btncleara.TabIndex = 9
        Me.btncleara.Text = "Clear"
        Me.btncleara.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightPink
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.DataGridView3)
        Me.Panel3.Controls.Add(Me.lblapp)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(510, 190)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(675, 456)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.HotPink
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(17, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(611, 37)
        Me.Panel4.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(176, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Appointments List"
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.Snow
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(17, 137)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(608, 262)
        Me.DataGridView3.TabIndex = 0
        '
        'lblapp
        '
        Me.lblapp.AutoSize = True
        Me.lblapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapp.Location = New System.Drawing.Point(269, 36)
        Me.lblapp.Name = "lblapp"
        Me.lblapp.Size = New System.Drawing.Size(23, 25)
        Me.lblapp.TabIndex = 12
        Me.lblapp.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(58, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total appointments:"
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.Crimson
        Me.btndel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndel.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.Color.White
        Me.btndel.Location = New System.Drawing.Point(157, 441)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(114, 48)
        Me.btndel.TabIndex = 8
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.AliceBlue
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnexit.Location = New System.Drawing.Point(28, 531)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(86, 42)
        Me.btnexit.TabIndex = 13
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'cmbtime
        '
        Me.cmbtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtime.FormattingEnabled = True
        Me.cmbtime.Location = New System.Drawing.Point(98, 296)
        Me.cmbtime.Name = "cmbtime"
        Me.cmbtime.Size = New System.Drawing.Size(333, 33)
        Me.cmbtime.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightPink
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(19, 917)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 42)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmbnamee
        '
        Me.cmbnamee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnamee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbnamee.FormattingEnabled = True
        Me.cmbnamee.Location = New System.Drawing.Point(90, 148)
        Me.cmbnamee.Name = "cmbnamee"
        Me.cmbnamee.Size = New System.Drawing.Size(333, 33)
        Me.cmbnamee.TabIndex = 14
        '
        'appointmentsee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1270, 708)
        Me.Controls.Add(Me.cmbnamee)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btncleara)
        Me.Controls.Add(Me.btnadda)
        Me.Controls.Add(Me.richdec)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.cmbtime)
        Me.Controls.Add(Me.cmbservice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "appointmentsee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "appointmentsee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbservice As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpdate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents richdec As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnadda As Button
    Friend WithEvents btncleara As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents btndel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblapp As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbtime As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbnamee As ComboBox
End Class

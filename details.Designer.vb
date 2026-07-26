<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(details))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtidservice = New System.Windows.Forms.TextBox()
        Me.lbldet = New System.Windows.Forms.Label()
        Me.btnlogouts = New System.Windows.Forms.Button()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnclears = New System.Windows.Forms.Button()
        Me.btndeletes = New System.Windows.Forms.Button()
        Me.btnupdates = New System.Windows.Forms.Button()
        Me.btnadds = New System.Windows.Forms.Button()
        Me.richdes = New System.Windows.Forms.RichTextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtservice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1108, 84)
        Me.Panel1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(886, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 33)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "SalonEase"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1020, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(79, 84)
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
        Me.TextBox1.Location = New System.Drawing.Point(291, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(516, 44)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Services Management"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Pink
        Me.Panel3.Controls.Add(Me.txtidservice)
        Me.Panel3.Controls.Add(Me.lbldet)
        Me.Panel3.Controls.Add(Me.btnlogouts)
        Me.Panel3.Controls.Add(Me.lblcount)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.DataGridView2)
        Me.Panel3.Controls.Add(Me.btnclears)
        Me.Panel3.Controls.Add(Me.btndeletes)
        Me.Panel3.Controls.Add(Me.btnupdates)
        Me.Panel3.Controls.Add(Me.btnadds)
        Me.Panel3.Controls.Add(Me.richdes)
        Me.Panel3.Controls.Add(Me.txtprice)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtservice)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(12, 129)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1115, 530)
        Me.Panel3.TabIndex = 3
        '
        'txtidservice
        '
        Me.txtidservice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidservice.Location = New System.Drawing.Point(133, 24)
        Me.txtidservice.Name = "txtidservice"
        Me.txtidservice.ReadOnly = True
        Me.txtidservice.Size = New System.Drawing.Size(81, 30)
        Me.txtidservice.TabIndex = 10
        Me.txtidservice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbldet
        '
        Me.lbldet.AutoSize = True
        Me.lbldet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldet.Location = New System.Drawing.Point(20, 27)
        Me.lbldet.Name = "lbldet"
        Me.lbldet.Size = New System.Drawing.Size(111, 25)
        Me.lbldet.TabIndex = 9
        Me.lbldet.Text = "Service no:"
        '
        'btnlogouts
        '
        Me.btnlogouts.BackColor = System.Drawing.Color.LightPink
        Me.btnlogouts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogouts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink
        Me.btnlogouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogouts.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogouts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlogouts.Location = New System.Drawing.Point(29, 465)
        Me.btnlogouts.Name = "btnlogouts"
        Me.btnlogouts.Size = New System.Drawing.Size(86, 42)
        Me.btnlogouts.TabIndex = 8
        Me.btnlogouts.Text = "Exit"
        Me.btnlogouts.UseVisualStyleBackColor = False
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(231, 583)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(0, 25)
        Me.lblcount.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.HotPink
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(530, 48)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(511, 37)
        Me.Panel4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(176, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Service List"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(530, 85)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(511, 326)
        Me.DataGridView2.TabIndex = 5
        '
        'btnclears
        '
        Me.btnclears.BackColor = System.Drawing.Color.Orchid
        Me.btnclears.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclears.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia
        Me.btnclears.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclears.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclears.ForeColor = System.Drawing.Color.White
        Me.btnclears.Location = New System.Drawing.Point(336, 387)
        Me.btnclears.Name = "btnclears"
        Me.btnclears.Size = New System.Drawing.Size(122, 45)
        Me.btnclears.TabIndex = 4
        Me.btnclears.Text = "Clear"
        Me.btnclears.UseVisualStyleBackColor = False
        '
        'btndeletes
        '
        Me.btndeletes.BackColor = System.Drawing.Color.Crimson
        Me.btndeletes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeletes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btndeletes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletes.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletes.ForeColor = System.Drawing.Color.White
        Me.btndeletes.Location = New System.Drawing.Point(94, 387)
        Me.btndeletes.Name = "btndeletes"
        Me.btndeletes.Size = New System.Drawing.Size(168, 58)
        Me.btndeletes.TabIndex = 4
        Me.btndeletes.Text = "Delete Service"
        Me.btndeletes.UseVisualStyleBackColor = False
        '
        'btnupdates
        '
        Me.btnupdates.BackColor = System.Drawing.Color.Goldenrod
        Me.btnupdates.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive
        Me.btnupdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdates.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdates.ForeColor = System.Drawing.Color.White
        Me.btnupdates.Location = New System.Drawing.Point(215, 306)
        Me.btnupdates.Name = "btnupdates"
        Me.btnupdates.Size = New System.Drawing.Size(171, 58)
        Me.btnupdates.TabIndex = 4
        Me.btnupdates.Text = "Update Service"
        Me.btnupdates.UseVisualStyleBackColor = False
        '
        'btnadds
        '
        Me.btnadds.BackColor = System.Drawing.Color.Green
        Me.btnadds.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnadds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadds.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadds.ForeColor = System.Drawing.Color.White
        Me.btnadds.Location = New System.Drawing.Point(29, 306)
        Me.btnadds.Name = "btnadds"
        Me.btnadds.Size = New System.Drawing.Size(144, 58)
        Me.btnadds.TabIndex = 4
        Me.btnadds.Text = "Add Service"
        Me.btnadds.UseVisualStyleBackColor = False
        '
        'richdes
        '
        Me.richdes.Location = New System.Drawing.Point(145, 185)
        Me.richdes.Name = "richdes"
        Me.richdes.Size = New System.Drawing.Size(313, 99)
        Me.richdes.TabIndex = 3
        Me.richdes.Text = ""
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(145, 130)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(241, 30)
        Me.txtprice.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Description:"
        '
        'txtservice
        '
        Me.txtservice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtservice.Location = New System.Drawing.Point(140, 80)
        Me.txtservice.Name = "txtservice"
        Me.txtservice.Size = New System.Drawing.Size(246, 30)
        Me.txtservice.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Service:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price(LKR):"
        '
        'details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1156, 698)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnlogouts As Button
    Friend WithEvents lblcount As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnclears As Button
    Friend WithEvents btndeletes As Button
    Friend WithEvents btnupdates As Button
    Friend WithEvents btnadds As Button
    Friend WithEvents richdes As RichTextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtservice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidservice As TextBox
    Friend WithEvents lbldet As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admindashboard
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
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admindashboard))
        Me.btncustomer = New System.Windows.Forms.Button()
        Me.btnappointment = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.invoicebton = New System.Windows.Forms.Button()
        Me.grprecentactivity = New System.Windows.Forms.GroupBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblappointments = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblstaff = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblclients = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnstaffmanage = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnservice = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grprecentactivity.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Crimson
        Label3.Location = New System.Drawing.Point(11, 151)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(219, 71)
        Label3.TabIndex = 20
        Label3.Text = "Welcome!"
        '
        'btncustomer
        '
        Me.btncustomer.BackColor = System.Drawing.Color.DeepPink
        Me.btncustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncustomer.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite
        Me.btncustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid
        Me.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustomer.ForeColor = System.Drawing.Color.White
        Me.btncustomer.Location = New System.Drawing.Point(12, 260)
        Me.btncustomer.Name = "btncustomer"
        Me.btncustomer.Size = New System.Drawing.Size(228, 62)
        Me.btncustomer.TabIndex = 5
        Me.btncustomer.Text = "          Customers"
        Me.btncustomer.UseVisualStyleBackColor = False
        '
        'btnappointment
        '
        Me.btnappointment.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnappointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnappointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid
        Me.btnappointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnappointment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnappointment.ForeColor = System.Drawing.Color.White
        Me.btnappointment.Location = New System.Drawing.Point(12, 345)
        Me.btnappointment.Name = "btnappointment"
        Me.btnappointment.Size = New System.Drawing.Size(228, 62)
        Me.btnappointment.TabIndex = 5
        Me.btnappointment.Text = "           Appointments"
        Me.btnappointment.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LavenderBlush
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.grprecentactivity)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(242, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 509)
        Me.Panel2.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.invoicebton)
        Me.GroupBox1.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(527, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 210)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Quick Billing"
        '
        'invoicebton
        '
        Me.invoicebton.BackColor = System.Drawing.Color.PaleVioletRed
        Me.invoicebton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.invoicebton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink
        Me.invoicebton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.invoicebton.ForeColor = System.Drawing.Color.White
        Me.invoicebton.Location = New System.Drawing.Point(12, 54)
        Me.invoicebton.Name = "invoicebton"
        Me.invoicebton.Size = New System.Drawing.Size(380, 79)
        Me.invoicebton.TabIndex = 4
        Me.invoicebton.Text = "Create Invoice"
        Me.invoicebton.UseVisualStyleBackColor = False
        '
        'grprecentactivity
        '
        Me.grprecentactivity.BackColor = System.Drawing.Color.MistyRose
        Me.grprecentactivity.Controls.Add(Me.lbl1)
        Me.grprecentactivity.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grprecentactivity.Location = New System.Drawing.Point(38, 187)
        Me.grprecentactivity.Name = "grprecentactivity"
        Me.grprecentactivity.Size = New System.Drawing.Size(467, 292)
        Me.grprecentactivity.TabIndex = 3
        Me.grprecentactivity.TabStop = False
        Me.grprecentactivity.Text = "  Today Appointments"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(6, 68)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(69, 28)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Label2"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Pink
        Me.Panel4.Controls.Add(Me.lblappointments)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Location = New System.Drawing.Point(19, 21)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(289, 137)
        Me.Panel4.TabIndex = 0
        '
        'lblappointments
        '
        Me.lblappointments.AutoSize = True
        Me.lblappointments.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblappointments.Location = New System.Drawing.Point(110, 83)
        Me.lblappointments.Name = "lblappointments"
        Me.lblappointments.Size = New System.Drawing.Size(22, 25)
        Me.lblappointments.TabIndex = 1
        Me.lblappointments.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Pink
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(19, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 28)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "   Today's Appointments"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Pink
        Me.Panel5.Controls.Add(Me.lblstaff)
        Me.Panel5.Controls.Add(Me.TextBox3)
        Me.Panel5.Location = New System.Drawing.Point(668, 21)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(292, 137)
        Me.Panel5.TabIndex = 0
        '
        'lblstaff
        '
        Me.lblstaff.AutoSize = True
        Me.lblstaff.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaff.Location = New System.Drawing.Point(145, 83)
        Me.lblstaff.Name = "lblstaff"
        Me.lblstaff.Size = New System.Drawing.Size(22, 25)
        Me.lblstaff.TabIndex = 1
        Me.lblstaff.Text = "0"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Pink
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(27, 26)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(245, 28)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = " Total Staff"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Pink
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.lblclients)
        Me.Panel3.Location = New System.Drawing.Point(347, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 137)
        Me.Panel3.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Pink
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(22, 26)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(245, 28)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = " Total Clients"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblclients
        '
        Me.lblclients.AutoSize = True
        Me.lblclients.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclients.Location = New System.Drawing.Point(123, 83)
        Me.lblclients.Name = "lblclients"
        Me.lblclients.Size = New System.Drawing.Size(22, 25)
        Me.lblclients.TabIndex = 1
        Me.lblclients.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 260)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.LightPink
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlogout.Location = New System.Drawing.Point(62, 625)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(86, 42)
        Me.btnlogout.TabIndex = 7
        Me.btnlogout.Text = "Exit"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1157, 50)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(1026, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SalonEase"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1161, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(79, 86)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(23, 345)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(56, 59)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        '
        'btnstaffmanage
        '
        Me.btnstaffmanage.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnstaffmanage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstaffmanage.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush
        Me.btnstaffmanage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid
        Me.btnstaffmanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstaffmanage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstaffmanage.ForeColor = System.Drawing.Color.White
        Me.btnstaffmanage.Location = New System.Drawing.Point(12, 522)
        Me.btnstaffmanage.Name = "btnstaffmanage"
        Me.btnstaffmanage.Size = New System.Drawing.Size(228, 62)
        Me.btnstaffmanage.TabIndex = 5
        Me.btnstaffmanage.Text = "           Manage Staff"
        Me.btnstaffmanage.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(23, 521)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'btnservice
        '
        Me.btnservice.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnservice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnservice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid
        Me.btnservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnservice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnservice.ForeColor = System.Drawing.Color.White
        Me.btnservice.Location = New System.Drawing.Point(12, 437)
        Me.btnservice.Name = "btnservice"
        Me.btnservice.Size = New System.Drawing.Size(228, 62)
        Me.btnservice.TabIndex = 18
        Me.btnservice.Text = "               Manage Services"
        Me.btnservice.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(23, 437)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(56, 62)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 19
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(51, 62)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(121, 96)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 21
        Me.PictureBox8.TabStop = False
        '
        'admindashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(1252, 686)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.btnservice)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnappointment)
        Me.Controls.Add(Me.btnstaffmanage)
        Me.Controls.Add(Me.btncustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admindashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admindashboard"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grprecentactivity.ResumeLayout(False)
        Me.grprecentactivity.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncustomer As Button
    Friend WithEvents btnappointment As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grprecentactivity As GroupBox
    Friend WithEvents invoicebton As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnstaffmanage As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnservice As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblappointments As Label
    Friend WithEvents lblstaff As Label
    Friend WithEvents lblclients As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lbl1 As Label
End Class

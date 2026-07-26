Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Crud

Public Class invoice

    Private Sub invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp.Value = DateTime.Today
        dtp.Enabled = False
        txttime.Text = DateTime.Now.ToString("hh:mm:ss")
        txttime.ReadOnly = True
        rb1.Checked = True

        Loadcustomerids()
        Loadservices()

        txtcustomer.ReadOnly = True
        phone.ReadOnly = True

        DataGridView5.Columns.Clear()
        DataGridView5.Columns.Add("Servicename", "Service name")
        DataGridView5.Columns.Add("price", "Price")



    End Sub

    Private Sub calculator()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In DataGridView5.Rows
            If row.Cells("price").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("price").Value)


            End If
        Next
        txttotal.Text = total.ToString()
        'discount
        Dim discount As Decimal = total * 5 / 100
        txtdiscount.Text = discount.ToString()

        'grand total
        Dim grandtotal As Decimal = total - discount
        txtgrand.Text = grandtotal.ToString()

    End Sub
    Private Sub Loadcustomerids()
        connectsalonease()
        Dim cmd As New MySqlCommand("SELECT customer_id FROM customers", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        cmbcusname.Items.Clear()
        While reader.Read()

            cmbcusname.Items.Add(reader("customer_id").ToString())
        End While

        reader.Close()
        Disconnectsalonease()

    End Sub

    Private Sub Loadservices()
        Try
            connectsalonease()

            Dim cmd As New MySqlCommand("SELECT service_name FROM services", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            cmbservice.Items.Clear()

            While reader.Read()
                cmbservice.Items.Add(reader("service_name").ToString())


            End While
            reader.Close()
            Disconnectsalonease()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprintpreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub




    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If cmbservice.Text = "" Then
            MessageBox.Show("Select a service.")
            Exit Sub
        End If

        Try
            connectsalonease()
            Dim cmd As New MySqlCommand("SELECT service_name,price FROM services WHERE service_name=@name", conn)
            cmd.Parameters.AddWithValue("@name", cmbservice.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim servicename As String = reader("service_name").ToString()
                Dim price As Decimal = Convert.ToDecimal(reader("price"))

                DataGridView5.Rows.Add(servicename, price)
                calculator()
            End If

            reader.Close()
            Disconnectsalonease()

            cmbservice.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try
    End Sub

    Private Sub cmbcusname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcusname.SelectedIndexChanged
        Try
            connectsalonease()

            Dim cmd As New MySqlCommand("SELECT full_name,phone FROM customers WHERE customer_id=@id", conn)

            cmd.Parameters.AddWithValue("@id", cmbcusname.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtcustomer.Text = reader("full_name").ToString()
                phone.Text = reader("phone").ToString()
            End If
            reader.Close()
            Disconnectsalonease()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnisave_Click(sender As Object, e As EventArgs) Handles btnisave.Click
        Dim query As String = "INSERT INTO invoice(customer_id,customer_name,date,total) VALUES(@cid,@name,@date,@total)"

        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@cid", cmbcusname.Text)
        cmd.Parameters.AddWithValue("@name", txtcustomer.Text)
        cmd.Parameters.AddWithValue("@date", dtp.Value.Date)
        cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtgrand.Text))
        Try
            connectsalonease()
            cmd.ExecuteNonQuery()
            MessageBox.Show("invoice saved")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Disconnectsalonease()
        End Try
    End Sub



    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        Dim y As Integer = 20
        If piclogo.Image IsNot Nothing Then
            e.Graphics.DrawImage(piclogo.Image, 50, y, 100, 80)
        End If
        Dim fontTitle As New Font("Arial", 18, FontStyle.Bold)
        Dim fontsub As New Font("Arial", 10, FontStyle.Regular)
        Dim fontBody As New Font("Arial", 10, FontStyle.Regular)

        e.Graphics.DrawString("SalonEase", fontTitle, Brushes.Black, 300, y)
        y += 30
        e.Graphics.DrawString("43/A,Beauty Street,Colombo 15.", fontsub, Brushes.Black, 200, y)
        y += 20
        e.Graphics.DrawString("Phone: 0112990142 / 0763104002", fontsub, Brushes.Black, 240, y)
        y += 30
        e.Graphics.DrawLine(Pens.Black, 50, y, 750, y)
        y += 20


        'TITLE
        e.Graphics.DrawString("SALON INVOICE", fontTitle, Brushes.Black, 300, y)
        y += 40

        'CUSTOMER DETAILS
        e.Graphics.DrawString("Customer ID: " & cmbcusname.Text, fontBody, Brushes.Black, 50, y)
        y += 20
        e.Graphics.DrawString("Name: " & txtcustomer.Text, fontBody, Brushes.Black, 50, y)
        y += 20
        e.Graphics.DrawString("Phone: " & phone.Text, fontBody, Brushes.Black, 50, y)
        y += 20
        e.Graphics.DrawString("Date: " & dtp.Value.ToShortDateString(), fontBody, Brushes.Black, 50, y)
        y += 30

        'TABLE HEADER
        e.Graphics.DrawString("Service", fontBody, Brushes.Black, 50, y)
        e.Graphics.DrawString("Price", fontBody, Brushes.Black, 300, y)
        y += 20

        e.Graphics.DrawLine(Pens.Black, 50, y, 500, y)
        y += 10

        'DATA GRID VIEW ITEMS
        For Each row As DataGridViewRow In DataGridView5.Rows

            If Not row.IsNewRow Then

                e.Graphics.DrawString(row.Cells(0).Value.ToString(), fontBody, Brushes.Black, 50, y)
                e.Graphics.DrawString(row.Cells(1).Value.ToString(), fontBody, Brushes.Black, 300, y)

                y += 20

            End If

        Next

        y += 20

        'TOTAL
        e.Graphics.DrawString("Total: " & txttotal.Text, fontBody, Brushes.Black, 50, y)
        y += 20

        e.Graphics.DrawString("Discount: " & txtdiscount.Text, fontBody, Brushes.Black, 50, y)
        y += 20

        e.Graphics.DrawString("Grand Total: " & txtgrand.Text, fontBody, Brushes.Black, 50, y)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        admindashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnprint_Click_1(sender As Object, e As EventArgs) Handles btnprint.Click
        MessageBox.Show("Do you want to print this report?", "Print Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        PrintDocument1.Print()
    End Sub
End Class
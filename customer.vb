Imports MySql.Data.MySqlClient
Public Class customer

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
        customers()
    End Sub
    Public Sub customers()
        Try
            connectsalonease()
            Dim da As New MySqlDataAdapter("SELECT*FROM customers", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView7.DataSource = dt
            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try
    End Sub
    Private Sub LoadCustomers()
        Try
            connectsalonease()
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM customers", conn)
                Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblstaff.Text = total.ToString()
            End Using
            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Function Capital(ByVal name As String) As String
        If String.IsNullOrWhiteSpace(name) Then
            Return ""
        End If
        name = name.Trim()
            Return Char.ToUpper(name(0)) &
                name.Substring(1).ToLower()
    End Function
    Private Sub btnlogoutsstaff_Click(sender As Object, e As EventArgs) Handles btnlogoutsstaff.Click
        admindashboard.Show()
        Me.Close()

    End Sub

    Private Sub btnnewcus_Click(sender As Object, e As EventArgs) Handles btnnewcus.Click
        If txtcustomernames.Text = "" Or txtphonecus.Text = "" Or txtaddress.Text = "" Then
            MessageBox.Show("Please fill all required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not IsNumeric(txtphonecus.Text) Then
            MessageBox.Show("phone number must contain only numbers", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtphonecus.Focus()
                Exit Sub

            End If

        If txtphonecus.Text.Length <> 10 Then

            MessageBox.Show("Must contain 10 numbers only", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtphonecus.Focus()
            Exit Sub

        End If
        connectsalonease()

        Dim customername As String = Capital(txtcustomernames.Text)
        Dim cmd As New MySqlCommand("INSERT INTO customers(full_name, phone, address) VALUES(@name,@phone,@address)", conn)

        cmd.Parameters.AddWithValue("@name", customername)
        cmd.Parameters.AddWithValue("@phone", txtphonecus.Text)
        cmd.Parameters.AddWithValue("@address", txtaddress.Text)


        cmd.ExecuteNonQuery()
        Disconnectsalonease()

        MessageBox.Show("Customer added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadCustomers()
        customers()
        admindashboard.Loadtotalclient()
        ClearFields()
    End Sub

    Private Sub btneditcus_Click(sender As Object, e As EventArgs) Handles btneditcus.Click
        If DataGridView7.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a customer to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            connectsalonease()
            Dim customername As String = Capital(txtcustomernames.Text)
            Dim cmd As New MySqlCommand("UPDATE customers SET full_name=@name, phone=@phone,address=@address WHERE customer_id=@id", conn)

            cmd.Parameters.AddWithValue("@id", txtaddress.Text)
            cmd.Parameters.AddWithValue("@name", customername)
            cmd.Parameters.AddWithValue("@phone", txtphonecus.Text)
            cmd.Parameters.AddWithValue("@address", txtaddress.Text)


            cmd.ExecuteNonQuery()

            Disconnectsalonease()

            MessageBox.Show("Customer Updated Successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customers()

            ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If DataGridView7.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a customer to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim id As Integer = DataGridView7.CurrentRow.Cells("customer_id").Value
        If MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try

            connectsalonease()
            Dim cmd As New MySqlCommand(
                "DELETE FROM customers WHERE customer_id=@id", conn)
            cmd.Parameters.AddWithValue("@id", txtcutomerid.Text)
            cmd.ExecuteNonQuery()
            Disconnectsalonease()

            MessageBox.Show("Staff Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            customers()
            admindashboard.Loadtotalclient()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ClearFields()
        txtcutomerid.Clear()
        txtcustomernames.Clear()
        txtphonecus.Clear()
        txtaddress.Clear()
    End Sub

    Private Sub DataGridView7_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellClick
        If e.RowIndex >= 0 Then
            txtcutomerid.Text = DataGridView7.Rows(e.RowIndex).Cells("customer_id").Value.ToString()
            txtcustomernames.Text = DataGridView7.Rows(e.RowIndex).Cells("full_name").Value.ToString()
            txtphonecus.Text = DataGridView7.Rows(e.RowIndex).Cells("phone").Value.ToString()
            txtaddress.Text = DataGridView7.Rows(e.RowIndex).Cells("address").Value.ToString()
        End If

        DataGridView7.DefaultCellStyle.Font = New Font("segoe Ui", 14, FontStyle.Regular)
    End Sub


    Private Sub searchcutomer_Click(sender As Object, e As EventArgs) Handles searchcutomer.Click
        If txtsearchcustomer.Text = "" Then
            MessageBox.Show("Please enter name or phone to search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Exit Sub
        End If
        Try
            connectsalonease()

            Dim dt As New DataTable
            Dim query As String = "SELECT customer_id,full_name,phone,address FROM customers WHERE full_name LIKE @search OR phone LIKE @search"

            Using da As New MySqlDataAdapter(query, conn)

                da.SelectCommand.Parameters.AddWithValue("@search", "%" & txtsearchcustomer.Text & "%")
                da.Fill(dt)
            End Using

            Disconnectsalonease()
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Customer not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'load result to grid
            DataGridView7.DataSource = dt

            'auto select firstrow
            DataGridView7.ClearSelection()
            DataGridView7.Rows(0).Selected = True

            txtcutomerid.Text = dt.Rows(0)("customer_id").ToString()
            txtcustomernames.Text = dt.Rows(0)("full_name").ToString()
            txtphonecus.Text = dt.Rows(0)("phone").ToString()
            txtaddress.Text = dt.Rows(0)("address").ToString()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub txtphonecus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphonecus.KeyPress
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class
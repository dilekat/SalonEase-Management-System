
Imports MySql.Data.MySqlClient
Public Class staff
    Private Sub staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadservices()
        LoadStaff()
        Staffcount()
    End Sub
    Sub Loadservices()
        Try
            connectsalonease()

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT service_id,service_name FROM services", conn)
            da.Fill(dt)

            cmbstaffservice.DataSource = dt
            cmbstaffservice.DisplayMember = "service_name"
            cmbstaffservice.ValueMember = "service_id"

            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Staffcount()
        Try
            connectsalonease()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM stafftable", conn)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblstaff.Text = count.ToString()
            Disconnectsalonease()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try
    End Sub
    Private Sub LoadStaff()
        Try
            connectsalonease()

            Dim da As New MySqlDataAdapter("SELECT st.staff_id, st.staff_name,st.phone,st.note,sv.service_name FROM stafftable st LEFT JOIN
            service_staff ss ON st.staff_id= ss.staff_id LEFT JOIN services sv ON ss.service_id=sv.service_id", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView4.DataSource = dt


            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

            Disconnectsalonease()

        End Try

    End Sub
    Function Capital1(ByVal name As String) As String
        If String.IsNullOrWhiteSpace(name) Then
            Return ""
        End If
        name = name.Trim()
        Return Char.ToUpper(name(0)) &
                name.Substring(1).ToLower()
    End Function

    Private Sub btnaddsstaff_Click(sender As Object, e As EventArgs) Handles btnaddsstaff.Click
        If Not IsNumeric(txtphone.Text) Then
            MessageBox.Show("phone number must contain only numbers", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtphone.Clear()
            txtphone.Focus()
            Exit Sub

        End If
        If txtstaffname.Text = "" Or txtphone.Text = "" Then
            MessageBox.Show("Please fill required fields")
            Exit Sub
        End If


        If txtphone.Text.Length <> 10 Then

            MessageBox.Show("Must contain 10 numbers only", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtphone.Focus()
            Exit Sub

        End If
        Try
            connectsalonease()
            'insert staff
            Dim staffname As String = Capital1(txtstaffname.Text)
            Dim cmd As New MySqlCommand("INSERT INTO stafftable(staff_name, role, phone, note) VALUES(@n,@r,@p,@no)", conn)

            cmd.Parameters.AddWithValue("@n", staffname)
            cmd.Parameters.AddWithValue("@r", cmbstaffservice.Text)
            cmd.Parameters.AddWithValue("@p", txtphone.Text)
            cmd.Parameters.AddWithValue("@no", txtnote.Text)

            cmd.ExecuteNonQuery()

            Dim staffid As Integer = cmd.LastInsertedId

            'insert staff-service relation
            Dim cmd2 As New MySqlCommand("INSERT INTO service_staff(service_id,staff_id) VALUES(@sid,@stid)", conn)

            cmd2.Parameters.AddWithValue("@sid", cmbstaffservice.SelectedValue)
            cmd2.Parameters.AddWithValue("@stid", staffid)

            cmd2.ExecuteNonQuery()
            Disconnectsalonease()

            MessageBox.Show("Staff added Successfully.")
            Disconnectsalonease()

            LoadStaff()
            Staffcount()

            admindashboard.Totalstaff()

            ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try

    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        If e.RowIndex >= 0 Then
            txtstaffid.Text = DataGridView4.Rows(e.RowIndex).Cells("staff_id").Value.ToString()
            txtstaffname.Text = DataGridView4.Rows(e.RowIndex).Cells("staff_name").Value.ToString()
            txtphone.Text = DataGridView4.Rows(e.RowIndex).Cells("phone").Value.ToString()
            txtnote.Text = DataGridView4.Rows(e.RowIndex).Cells("note").Value.ToString()
            cmbstaffservice.Text = DataGridView4.Rows(e.RowIndex).Cells("service_name").Value.ToString
        End If

    End Sub

    Private Sub btnupdatesstaff_Click(sender As Object, e As EventArgs) Handles btnupdatesstaff.Click
        Try

            If DataGridView4.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a staff member first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

            Dim id As Integer = Convert.ToInt32(DataGridView4.SelectedRows(0).Cells(0).Value)
            connectsalonease()
            Dim cmd As New MySqlCommand("UPDATE stafftable SET staff_name=@n, role=@r, phone=@p, note=@no WHERE staff_id=@id", conn)

            cmd.Parameters.AddWithValue("@n", txtstaffname.Text)
            cmd.Parameters.AddWithValue("@r", cmbstaffservice.Text)
            cmd.Parameters.AddWithValue("@p", txtphone.Text)
            cmd.Parameters.AddWithValue("@no", txtnote.Text)
            cmd.Parameters.AddWithValue("@id", txtstaffid.Text)

            cmd.ExecuteNonQuery()

            Dim cmd2 As New MySqlCommand("UPDATE service_staff SET service_id=@sid WHERE staff_id=@stid", conn)

            cmd2.Parameters.AddWithValue("@sid", cmbstaffservice.SelectedValue)
            cmd2.Parameters.AddWithValue("@stid", txtstaffid.Text)

            cmd2.ExecuteNonQuery()
            Disconnectsalonease()


            MessageBox.Show("Staff Updated Successfully.")
            LoadStaff()
            Staffcount()
            admindashboard.Totalstaff()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try
    End Sub

    Private Sub btndeletesstaff_Click(sender As Object, e As EventArgs) Handles btndeletesstaff.Click
        Try
            If DataGridView4.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a staff member to delete")
                Exit Sub
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure Delete this staff?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Exit Sub
            End If

            Dim id As Integer = Convert.ToInt32(DataGridView4.SelectedRows(0).Cells(0).Value)


            connectsalonease()
            Dim cmd As New MySqlCommand(
                "DELETE FROM service_staff WHERE staff_id=@id", conn)
            cmd.Parameters.AddWithValue("@id", txtstaffid.Text)
            cmd.ExecuteNonQuery()

            Dim cmd2 As New MySqlCommand("DELETE FROM stafftable WHERE staff_id=@id", conn)
            cmd2.Parameters.AddWithValue("@id", txtstaffid.Text)
            cmd2.ExecuteNonQuery()
            Disconnectsalonease()

            MessageBox.Show("Staff Deleted Successfully")
            LoadStaff()
            ClearFields()

            Staffcount()
            admindashboard.Totalstaff()
            ClearFields()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub ClearFields()
        txtstaffname.Clear()
        cmbstaffservice.SelectedIndex = -1
        txtphone.Clear()
        txtnote.Clear()
        txtstaffid.Clear()
    End Sub

    Private Sub btnclearsstaff_Click(sender As Object, e As EventArgs) Handles btnclearsstaff.Click
        ClearFields()
    End Sub

    Private Sub btnlogoutsstaff_Click(sender As Object, e As EventArgs) Handles btnlogoutsstaff.Click
        admindashboard.Show()
        Me.Close()
    End Sub


End Class
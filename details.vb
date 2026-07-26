
Imports System.Drawing.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class details


    Sub Loadservices()
        Try
            connectsalonease()

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT s.service_id,s.service_name,s.price,s.note,st.staff_name FROM services s LEFT JOIN service_staff ss ON s.service_id = ss.service_id LEFT JOIN stafftable st ON ss.staff_id = st.staff_id ORDER BY s.service_id ASC", conn)

            da.Fill(dt)
            DataGridView2.DataSource = dt


            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try
    End Sub
    Private Sub details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadservices()

    End Sub
    Private Sub btnadds_Click(sender As Object, e As EventArgs) Handles btnadds.Click

        If txtservice.Text = "" Or txtprice.Text = "" Then
            MessageBox.Show("Please fill Service,Price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Exit Sub
        End If

        Try
            connectsalonease()

            Dim cmd As New MySqlCommand("INSERT INTO services(service_name, price, note) VALUES(@n,@p,@des)", conn)
            cmd.Parameters.AddWithValue("@n", txtservice.Text)
            cmd.Parameters.AddWithValue("@p", txtprice.Text)
            cmd.Parameters.AddWithValue("@des", richdes.Text)



            cmd.ExecuteNonQuery()

            Disconnectsalonease()
            MessageBox.Show("Service Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loadservices()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            txtidservice.Text = DataGridView2.CurrentRow.Cells("service_id").Value.ToString()
            txtservice.Text = If(IsDBNull(row.Cells("Service_name").Value), "", row.Cells("service_name").Value.ToString())
            txtprice.Text = If(IsDBNull(row.Cells("price").Value), "", row.Cells("price").Value.ToString())

            richdes.Text = If(IsDBNull(row.Cells("note").Value), "", row.Cells("note").Value.ToString())
        End If
    End Sub

    Private Sub btnupdates_Click(sender As Object, e As EventArgs) Handles btnupdates.Click
        Try
            If txtservice.Text = "" Then
                MessageBox.Show("Please select a service")
                Exit Sub
            End If

            Dim id As Integer = DataGridView2.SelectedRows(0).Cells(0).Value

            connectsalonease()
            Dim cmd As New MySqlCommand("UPDATE services SET Service_name=@n, Price=@p, note=@des WHERE service_id=@id", conn)

            cmd.Parameters.AddWithValue("@id", txtidservice.Text)
            cmd.Parameters.AddWithValue("@n", txtservice.Text)
            cmd.Parameters.AddWithValue("@p", txtprice.Text)
            cmd.Parameters.AddWithValue("@des", richdes.Text)


            cmd.ExecuteNonQuery()


            Disconnectsalonease()

            MessageBox.Show("Service Updated Successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loadservices()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try

    End Sub

    Private Sub btndeletes_Click(sender As Object, e As EventArgs) Handles btndeletes.Click
        Try
            If DataGridView2.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a service to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to Delete this service?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If

            Dim id As Integer = Convert.ToInt32(DataGridView2.SelectedRows(0).Cells(0).Value)

            connectsalonease()
            'child
            Dim cmd1 As New MySqlCommand(
                "DELETE FROM service_staff WHERE service_id=@id", conn)
            cmd1.Parameters.AddWithValue("@id", id)
            cmd1.ExecuteNonQuery()

            'child2
            Dim cmd2 As New MySqlCommand(
                "DELETE FROM services WHERE service_id=@id", conn)
            cmd2.Parameters.AddWithValue("@id", id)
            cmd2.ExecuteNonQuery()

            'parent
            Dim cmd3 As New MySqlCommand(
                "DELETE FROM services WHERE service_id=@id", conn)
            cmd3.Parameters.AddWithValue("@id", id)
            cmd3.ExecuteNonQuery()

            Disconnectsalonease()

            MessageBox.Show("Service Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Loadservices()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try

    End Sub
    Private Sub ClearFields()
        txtidservice.Clear()
        txtservice.Clear()
        txtprice.Clear()
        richdes.Clear()
    End Sub

    Private Sub btnclears_Click(sender As Object, e As EventArgs) Handles btnclears.Click
        ClearFields()
    End Sub

    Private Sub btnlogouts_Click(sender As Object, e As EventArgs) Handles btnlogouts.Click
        admindashboard.Show()
        Me.Close()

    End Sub


End Class
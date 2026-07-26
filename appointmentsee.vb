
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class appointmentsee

    Private Sub appointmentsee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadcustomer()
        Loadservice()
        Loadtimeslots()
        loadappointments1()
        appcount()

        dtpdate.MinDate = Date.Today
        dtpdate.MaxDate = Date.Today.AddMonths(6)
        dtpdate.Value = Date.Today

    End Sub
    Sub loadappointments1()
        Try
            Dim dt As New DataTable

            connectsalonease()
            Dim da As New MySqlDataAdapter(
            "SELECT a.appointment_id,c.full_name,s.service_name,a.app_date,a.app_time FROM appointments a LEFT JOIN customers c ON
            a.customer_id=c.customer_id LEFT JOIN services s ON a.service_id=s.service_id", conn)

            dt.Clear()
            da.Fill(dt)


            DataGridView3.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Disconnectsalonease()
        End Try
    End Sub

    Public Sub appcount()
        Try
            connectsalonease()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM appointments ", conn)
            Dim count As Integer
            count = Convert.ToInt32(cmd.ExecuteScalar())
            lblapp.Text = count.ToString()
            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try
    End Sub
    Sub Loadcustomer()
        cmbnamee.Items.Clear()
        connectsalonease()
        Dim cmd As New MySqlCommand("SELECT full_name From customers", conn)
        Dim dr = cmd.ExecuteReader()
        While dr.Read()

            cmbnamee.Items.Add(dr("full_name").ToString())
        End While
        Disconnectsalonease()
    End Sub

    Sub Loadservice()
        cmbservice.Items.Clear()
        connectsalonease()
        Dim cmd As New MySqlCommand("SELECT service_name From services", conn)
        Dim dr = cmd.ExecuteReader()
        While dr.Read()

            cmbservice.Items.Add(dr("service_name").ToString())
        End While
        Disconnectsalonease()

    End Sub

    Sub Loadtimeslots()
        cmbtime.Items.Clear()

        Dim starttime As DateTime = DateTime.Parse("09:00")
        Dim endtime As DateTime = DateTime.Parse("21:00")

        While starttime < endtime

            cmbtime.Items.Add(starttime.ToString("hh:mm tt"))
            starttime = starttime.AddMinutes(30)
        End While

    End Sub

    Sub Removetimes()

        Try
            connectsalonease()
            Dim cmd As New MySqlCommand("SELECT app_time FROM appointments WHERE app_date=@d", conn)
            cmd.Parameters.AddWithValue("@d", dtpdate.Value.ToString("yyyy-MM-dd"))

            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                Dim ts As TimeSpan = CType(dr("app_time"), TimeSpan)
                Dim dt As DateTime = DateTime.Today.Add(ts)

                Dim timetext As String = dt.ToString("hh:mm tt")

                If cmbtime.Items.Contains(timetext) Then
                    cmbtime.Items.Remove(timetext)
                End If
            End While
            dr.Close()
            Disconnectsalonease()

        Catch ex As Exception
            MessageBox.Show("error removing booked times: " & ex.Message)

        End Try

    End Sub
    Private Sub dtpdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpdate.ValueChanged
        Loadtimeslots()
        Removetimes()
    End Sub




    Private Sub btnadda_Click(sender As Object, e As EventArgs) Handles btnadda.Click
        Try
            connectsalonease()
            If cmbnamee.SelectedIndex = -1 Or cmbservice.SelectedIndex = -1 Or cmbtime.SelectedIndex = -1 Then
                MessageBox.Show("Please fill all required fields.")
                Exit Sub
            End If
            connectsalonease()

            'get customer id

            Dim cmdcustomer As New MySqlCommand("SELECT customer_id FROM customers WHERE full_name=@c", conn)

            cmdcustomer.Parameters.AddWithValue("@c", cmbnamee.Text)
            Dim customerid As Integer = Convert.ToInt32(cmdcustomer.ExecuteScalar())

            'get service id
            Dim cmdservice As New MySqlCommand("SELECT service_id FROM services WHERE service_name=@s", conn)
            cmdservice.Parameters.AddWithValue("@s", cmbservice.Text)
            Dim serviceid As Integer = Convert.ToUInt32(cmdservice.ExecuteScalar())

            Dim cmdinsert As New MySqlCommand("INSERT INTO appointments(customer_id,service_id,app_date,app_time,note) VALUES(@cid,@sid,
@d,@t,@n)", conn)
            cmdinsert.Parameters.AddWithValue("@cid", customerid)
            cmdinsert.Parameters.AddWithValue("@sid", serviceid)
            cmdinsert.Parameters.AddWithValue("@d", dtpdate.Value.Date)
            cmdinsert.Parameters.AddWithValue("@t", cmbtime.SelectedItem.ToString)

            cmdinsert.Parameters.AddWithValue("@n", richdec.Text)

            cmdinsert.ExecuteNonQuery()
            MessageBox.Show("Appointment Added Successfully!")
            Disconnectsalonease()
            admindashboard.TodayTask()
            admindashboard.Todayappointment()
            loadappointments1()
            appcount()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try

    End Sub


    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = DataGridView3.Rows(e.RowIndex)
            cmbnamee.Text = If(IsDBNull(row.Cells("full_name").Value), "", row.Cells("full_name").Value.ToString())
            cmbservice.Text = If(IsDBNull(row.Cells("service_name").Value), "", row.Cells("service_name").Value.ToString())

            dtpdate.Value = Convert.ToDateTime(DataGridView3.Rows(e.RowIndex).Cells("app_date").Value)

            cmbtime.Text = DataGridView3.Rows(e.RowIndex).Cells("app_time").Value.ToString()

            richdec.Text = DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString()
        End If
    End Sub




    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Try

            If DataGridView3.CurrentRow Is Nothing Then
                MessageBox.Show("Please select an appointment")
                Exit Sub
            End If


            Dim result As DialogResult =
        MessageBox.Show("Delete this appointment?", "confirm", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Exit Sub
            End If

            Dim id As Integer = Convert.ToInt32(DataGridView3.SelectedRows(0).Cells(0).Value)
            connectsalonease()

            Dim cmd As New MySqlCommand("DELETE FROM appointments WHERE appointment_id=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)

            Dim row As Integer = cmd.ExecuteNonQuery()
            Disconnectsalonease()
            If row > 0 Then
                MessageBox.Show("Appointment Deleted")
            Else
                MessageBox.Show("Appointment not Deleted")
            End If
            admindashboard.TodayTask()
            admindashboard.Todayappointment()
            loadappointments1()
            appcount()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Disconnectsalonease()
        End Try
    End Sub

    Private Sub ClearFields()
        cmbnamee.SelectedIndex = -1
        cmbservice.SelectedIndex = -1

        cmbtime.SelectedIndex = -1
        richdec.Clear()
    End Sub
    Private Sub btncleara_Click(sender As Object, e As EventArgs) Handles btncleara.Click
        ClearFields()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        admindashboard.Show()
        Me.Close()
    End Sub


End Class
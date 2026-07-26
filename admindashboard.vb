
Imports MySql.Data.MySqlClient


Public Class admindashboard

    Private Sub admindashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadtotalclient()

        Todayappointment()
        TodayTask()

        Totalstaff()

    End Sub
    Sub Loadtotalclient()

        Try
            connectsalonease()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM customers", conn)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblclients.Text = count.ToString()
            Disconnectsalonease()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Disconnectsalonease()
        End Try
    End Sub




    Public Sub Todayappointment()
        Try
            connectsalonease()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM appointments WHERE DATE(app_date)=CURDATE()", conn)


            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblappointments.Text = count.ToString
            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try

    End Sub

    Public Sub TodayTask()
        Try
            connectsalonease()
            Dim query As String = "SELECT A.customer_id,A.app_time,S.service_name FROM appointments A INNER JOIN services S ON
   A.service_id = S.service_id WHERE A.app_date = @date ORDER BY A.app_time ASC"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@date", Date.Today)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            lbl1.Text = ""
            While reader.Read()
                lbl1.Text &= " * " &
                reader("app_time").ToString() &
                    " - " &
                    reader("Service_name").ToString() &
                    " -  Customer ID: " &
                    reader("customer_id").ToString() & vbCrLf

            End While
            If lbl1.Text = "" Then
                lbl1.Text = "No appointments today."
            End If
            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Disconnectsalonease()
        End Try
    End Sub
    Public Sub Totalstaff()
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
    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncustomer.Click
        customer.Show()
        Me.Hide()
    End Sub
    Private Sub btnstaffmanage_Click(sender As Object, e As EventArgs) Handles btnstaffmanage.Click
        staff.Show()
        Me.Hide()
    End Sub

    Private Sub btnappointment_Click(sender As Object, e As EventArgs) Handles btnappointment.Click
        appointmentsee.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnservice_Click(sender As Object, e As EventArgs) Handles btnservice.Click
        details.Show()
        Me.Close()
    End Sub

    Private Sub invoicebton_Click(sender As Object, e As EventArgs) Handles invoicebton.Click
        invoice.Show()
        Me.Hide()
    End Sub
End Class

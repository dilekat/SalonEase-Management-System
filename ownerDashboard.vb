
Imports MySql.Data.MySqlClient
Imports System.ComponentModel.Design.Serialization
Imports System.Linq.Expressions
Imports System.Windows.Forms.DataVisualization.Charting
Imports ZstdSharp.Unsafe
Public Class ownerDashboard


    Private Sub btnstaff_Click(sender As Object, e As EventArgs)
        staff.Show()
        Me.Hide()

    End Sub

    Private Sub btnservices_Click(sender As Object, e As EventArgs)

        details.Show()
        Me.Hide()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs)
        frmownerreport.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ownerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadchart()
        loadpiechart()

    End Sub


    Sub Loadchart()
        chartincome.Series.Clear()
        Dim series1 As New Series("Appointments")
        series1.ChartType = SeriesChartType.Column
        connectsalonease()
        Dim query As String = "SELECT WEEK(app_date) AS weekno, COUNT(*) AS total FROM appointments WHERE MONTH(app_date)=MONTH(CURDATE())
GROUP BY WEEK(app_date)"

        Dim cmd As New MySqlCommand(query, conn)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            series1.Points.AddXY(
                "week " & dr("weekno").ToString(),
dr("total").ToString())
        End While
        chartincome.Series.Add(series1)
        Disconnectsalonease()
    End Sub

    Private Sub btnreport_Click_1(sender As Object, e As EventArgs) Handles btnreport.Click

        Dim query As String = "SELECT MIN(app_date) AS start_date, MAX(app_date) AS end_date,SUM(s.price) AS total_income FROM appointments a
INNER JOIN services s ON a.service_id = s.service_id WHERE DATE(a. app_date) BETWEEN @from AND @to"

        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@from", dtpfrom.Value.Date)
        cmd.Parameters.AddWithValue("@to", dtpto.Value.Date)

        Dim da As New MySqlDataAdapter(cmd)

        Dim dt As New DataTable()

        Try
            connectsalonease()
            da.Fill(dt)
            reportgrid.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Disconnectsalonease()

        End Try
    End Sub


    Private Sub loadpiechart()
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()

        Chart1.ChartAreas.Add("Main")

        Dim series As New Series()
        series.ChartType = SeriesChartType.Pie


        connectsalonease()

            Dim sql As String = "SELECT s.service_name,COUNT(a.service_id) AS total " & "FROM appointments a " & "INNER JOIN services s ON a.service_id =
           s.service_id " & "GROUP BY s.service_name"

            Dim cmd As New MySqlCommand(sql, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()

                Dim serviceName As String = reader("service_name").ToString()
                Dim total As Integer = Convert.ToInt32(reader("total"))

            series.Points.AddXY(reader("service_Name"), reader("total"))
        End While

        reader.Close()
        Disconnectsalonease()

        series.IsValueShownAsLabel = True


        Chart1.Series.Add(series)
            Disconnectsalonease()



    End Sub


End Class
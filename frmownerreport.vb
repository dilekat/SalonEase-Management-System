Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmownerreport

    Private Sub btngen_Click(sender As Object, e As EventArgs) Handles btngen.Click
        DataGridView6.DataSource = Nothing

        connectsalonease()
        Dim sql As String = "SELECT date, total FROM invoice WHERE invoice BETWEEN @from AND @to ORDER BY date"

        Dim cmd As New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@from", DateTimePicker1.Value.Date)
        cmd.Parameters.AddWithValue("@to", DateTimePicker2.Value.Date)

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        DataGridView6.DataSource = dt

        'calculate total income
        Dim total As Decimal = 0
        For Each row As DataRow In dt.Rows
            total += Convert.ToDecimal(row("total"))

        Next
        lblrs.Text = total.ToString("N2")
        Disconnectsalonease()
        LoadIncomeChart(dt)

    End Sub


    Private Sub LoadIncomeChart(dt As DataTable)

        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()

        Dim serias As New Series("Income")
        serias.ChartType = SeriesChartType.Column
        serias.XValueType = ChartValueType.String
        serias.YValueType = ChartValueType.Double

        For Each row As DataRow In dt.Rows
            serias.Points.AddXY(
                Convert.ToDateTime(row("date")).ToShortTimeString(),
                Convert.ToDouble(row("total")))

        Next
        Chart1.Series.Add(serias)
    End Sub

    Private Sub frmownerreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView6.ReadOnly = True
    End Sub
End Class
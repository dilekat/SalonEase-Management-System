Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbusertype.Text = "" Then
            MessageBox.Show("Please select user Name")
            Exit Sub

        End If

        connectsalonease()
        Dim cmd As New MySqlCommand("SELECT * FROM login WHERE username=@u AND password=@p", conn)
        cmd.Parameters.AddWithValue("@u", cmbusertype.Text)
        cmd.Parameters.AddWithValue("@p", txtpassword.Text)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            reader.Close()
            Disconnectsalonease()

            'role based dashboard
            If cmbusertype.Text = "Owner" Then
                ownerDashboard.Show()
                txtpassword.Clear()
            ElseIf cmbusertype.Text = "Admin" Then
                admindashboard.Show()
                txtpassword.Clear()
            End If
            Me.Hide()
        Else
            reader.Close()
            Disconnectsalonease()

            MessageBox.Show("Invalid password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Clear()
            txtpassword.Focus()
        End If

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub


    Private Sub chkshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkshowpassword.CheckedChanged
        If chkshowpassword.Checked = True Then
            txtpassword.UseSystemPasswordChar = False  'password show
        Else
            txtpassword.UseSystemPasswordChar = True     'password hide
        End If
    End Sub

    Private Sub f_password_Click(sender As Object, e As EventArgs) Handles f_password.Click
        frmforgetpassword.Show()
        Me.Hide()
    End Sub


End Class

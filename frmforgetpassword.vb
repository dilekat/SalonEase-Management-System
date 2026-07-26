Imports MySql.Data.MySqlClient

Public Class frmforgetpassword

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub cmbshow_CheckedChanged(sender As Object, e As EventArgs)
        txtpasswordnew.UseSystemPasswordChar = Not cmbshow.Checked
        txtnewpassword.UseSystemPasswordChar = Not cmbshow.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbusername.Text = "" Then
            MessageBox.Show("Select a username")
            Exit Sub
        End If

        connectsalonease()
        Dim cmd As New MySqlCommand("SELECT username FROM login Where username=@u", conn)
        cmd.Parameters.AddWithValue("@u", cmbusername.Text)
        Dim role As Object = cmd.ExecuteScalar()
        Disconnectsalonease()

        'role based question
        cmbquestion.Items.Clear()
        If role.ToString() = "Owner" Then
            cmbquestion.Items.Add("First salon employee name?")
        ElseIf role.ToString() = "Admin" Then
            cmbquestion.Items.Add("Favorite service to provide?")
        End If
        panelsec.Visible = True

    End Sub
    Private Sub cmbquestion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbquestion.SelectedIndexChanged

    End Sub

    Private Sub btnverify_Click_1(sender As Object, e As EventArgs) Handles btnverify.Click
        If cmbquestion.Text = "" Or txtanswer.Text = "" Then
            MessageBox.Show("Select question and enter answer")
            Exit Sub
        End If
        connectsalonease()
        Dim cmd As New MySqlCommand("SELECT security_answer FROM login WHERE username=@u", conn)
        cmd.Parameters.AddWithValue("@u", cmbusername.Text)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            Dim databaseanswer As String = reader("security_answer").ToString()


            If txtanswer.Text.Trim().ToLower() = databaseanswer.Trim().ToLower() Then
                panreset.Visible = True
            Else

                MessageBox.Show("Incorrect answer")

            End If
        End If
        Disconnectsalonease()
    End Sub

    Private Sub btnreset_Click_1(sender As Object, e As EventArgs) Handles btnreset.Click
        If txtpasswordnew.Text = "" Or
                txtnewpassword.Text = "" Then
            MessageBox.Show("Enter all fields")
            Exit Sub
        End If

        If txtpasswordnew.Text <>
                txtnewpassword.Text Then
            MessageBox.Show("Password do not match")
            Exit Sub
        End If
        connectsalonease()
        Dim cmd As New MySqlCommand("UPDATE login SET password=@p WHERE username=@u", conn)
        cmd.Parameters.AddWithValue("@p", txtpasswordnew.Text)
        cmd.Parameters.AddWithValue("@u", cmbusername.Text)

        cmd.ExecuteNonQuery()
        Disconnectsalonease()

        MessageBox.Show("Password reset successfully")
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub cmbshow_CheckedChanged_1(sender As Object, e As EventArgs) Handles cmbshow.CheckedChanged
        If cmbshow.Checked = True Then
            txtnewpassword.UseSystemPasswordChar = False      'show password
        Else
            txtnewpassword.UseSystemPasswordChar = True        ' hide password
        End If
    End Sub


End Class

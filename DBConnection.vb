Imports MySql.Data.MySqlClient
Module DBConnection
    Public conn As New MySqlConnection("server=localhost;Database=salonease;User Id=root;password=;")
    Public Sub connectsalonease()

        If conn.State = ConnectionState.Closed Then
            conn.Open()
            'MessageBox.Show("Connection succesful")
        End If

    End Sub

    Public Sub Disconnectsalonease()

        If conn.State = ConnectionState.Open Then
            conn.Close()

        End If

    End Sub
End Module


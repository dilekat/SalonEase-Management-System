Imports MySql.Data.MySqlClient

Module Logincrud
    Public Function Loadusers() As DataTable 'Returns a value thats why not sub, but function
        Dim table As New DataTable()

        Try
            connectsalonease()

            Dim query As String = "Select user_id,u_name,password FROM userstable"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(table)

            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
        Return table

    End Function
End Module

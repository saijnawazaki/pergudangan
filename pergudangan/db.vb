Module db
    Dim constring As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\pergudangan.mdb;"
    Public Function getDataToDataGrid(query)
        Dim con As OleDb.OleDbConnection


        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        con = New OleDb.OleDbConnection(constring)

        con.Open()

        cmd.Connection = con
        cmd = New OleDb.OleDbCommand(query, con)

        da.SelectCommand = cmd
        da.Fill(dt)

        con.Close()
        Return dt
    End Function

    Public Function getSoloData(query)
        Dim con As OleDb.OleDbConnection


        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        con = New OleDb.OleDbConnection(constring)

        con.Open()

        cmd.Connection = con
        cmd = New OleDb.OleDbCommand(query, con)
        Return CStr(cmd.ExecuteScalar())
       
        con.Close()

    End Function

    Public Function getSoloRowData(query)
        Dim con As OleDb.OleDbConnection


        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        con = New OleDb.OleDbConnection(constring)

        con.Open()

        cmd.Connection = con
        cmd = New OleDb.OleDbCommand(query, con)
        Return cmd.ExecuteReader()

        con.Close()

    End Function

    Public Function getExecute(query)
        Dim con As OleDb.OleDbConnection


        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        con = New OleDb.OleDbConnection(constring)

        con.Open()

        cmd.Connection = con
        cmd = New OleDb.OleDbCommand(query, con)

        cmd.ExecuteNonQuery()
        con.Close()

        Return True

    End Function
End Module

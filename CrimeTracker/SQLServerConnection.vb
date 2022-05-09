Imports System.Data.SqlClient

Module SQLServerConnection
    Public ConnString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tejasranveer\Desktop\CrimeTracker\CrimeTracker\CrimeDB.mdf;Integrated Security=True"

    Private con As New SqlConnection
    Private SQLDA As SqlDataAdapter
    Private SQLDT As New DataTable
    Private SQLCMD As SqlCommand
    Public SQLDS As DataSet
    Function ExecuteSQL(sql As String) As DataTable

        Try
            Dim conn As New SqlConnection
            Dim adapter As SqlDataAdapter
            Dim dt As New DataTable

            conn.ConnectionString = ConnString
            conn.Open()

            adapter = New SqlDataAdapter(sql, conn)
            adapter.Fill(dt)

            conn.Close()
            conn = Nothing

            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Function

    Public Function hasConnection() As Boolean
        Try
            'conn.Open()

            'conn.Close()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return False
    End Function

    Public Sub runQuery(Query As String)
        'Dim con As New SqlConnection
        'Dim adapter As SqlDataAdapter
        'Dim dt As New DataTable
        'Dim SQLCmd As SqlCommand
        'Dim ds As DataSet

        Try


            con.ConnectionString = ConnString
            con.Open()

            'CREATE COMMAND
            SQLCMD = New SqlCommand(Query, con)

            'Fill DATASET
            SQLDA = New SqlDataAdapter(SQLCMD)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

            ' Make sure the connection is closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try
    End Sub
End Module

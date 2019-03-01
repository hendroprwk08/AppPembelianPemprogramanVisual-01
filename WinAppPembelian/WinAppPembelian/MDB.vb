Imports System.Data
Imports System.Data.SqlClient

Module MDB
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public adp As SqlDataAdapter

    Dim dt As New DataTable
    Dim sql, connString As String

    Public Sub connOpen()
        connString = "server = DOSENLABINFOR; " & _
                        "database = dbpembelian; " & _
                        "integrated security = true;"
        Try
            conn = New SqlConnection(connString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub open()
        Try
            conn.Open()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub close()
        conn.Close()
    End Sub

    Public Sub execute(ByVal sql As String)
        Try
            open()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            close()
        End Try
    End Sub

    Public Function getAll(ByVal sql As String) As DataTable
        Dim d As New DataTable

        Try
            open()
            adp = New SqlDataAdapter(sql, conn)
            adp.Fill(d)
            Return d
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            close()
        End Try

        Return Nothing
    End Function

    Public Function getOne(ByVal sql As String) As String
        Dim d As New DataTable

        Try
            open()
            adp = New SqlDataAdapter(sql, conn)
            adp.Fill(d)
            Return d.Rows(0).Item(0).ToString
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            close()
        End Try

        Return Nothing
    End Function


End Module

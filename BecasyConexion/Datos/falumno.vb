Imports System.Data.SqlClient


Public Class falumno

    Inherits Conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try

    End Function


    Public Function insertar(ByVal fel As Valumno) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@nombre", fel.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", fel.gapellidos)
            cmd.Parameters.AddWithValue("@cal1", fel.gcal1)
            cmd.Parameters.AddWithValue("@cal2", fel.gcal2)
            cmd.Parameters.AddWithValue("@cal3", fel.gcal3)
            cmd.Parameters.AddWithValue("@cal4", fel.gcal4)
            cmd.Parameters.AddWithValue("@cal5", fel.gcal5)
            cmd.Parameters.AddWithValue("@cal6", fel.gcal6)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function


    Public Function editar(ByVal fel As Valumno) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id", fel.gid)
            cmd.Parameters.AddWithValue("@nombre", fel.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", fel.gapellidos)
            cmd.Parameters.AddWithValue("@cal1", fel.gcal1)
            cmd.Parameters.AddWithValue("@cal2", fel.gcal2)
            cmd.Parameters.AddWithValue("@cal3", fel.gcal3)
            cmd.Parameters.AddWithValue("@cal4", fel.gcal4)
            cmd.Parameters.AddWithValue("@cal5", fel.gcal5)
            cmd.Parameters.AddWithValue("@cal6", fel.gcal6)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function


    Public Function eliminar(ByVal dts As Valumno) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("eliminar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dts.gid

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function


End Class

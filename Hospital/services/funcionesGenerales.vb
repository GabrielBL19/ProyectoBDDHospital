Imports MySql.Data.MySqlClient

﻿Imports System.Security.Cryptography.X509Certificates

Module funcionesGenerales
    Public Function obtenerConexion() As MySqlConnection
        Return New MySqlConnection("server=127.0.0.1; user=root; password=; database=hospitalDb") 'MsqlConnection objeto de la libreria, 
    End Function

    Public Function consultaGeneral(query As String, datos As Object) As Object
        ' Crear la conexión a la base de datos
        Dim conexion As MySqlConnection = obtenerConexion()
        conexion.Open()

        ' Crear el comando SQL
        Dim cmd As New MySqlCommand(query, conexion)

        ' Obtener las propiedades del objeto "datos" (que puede ser Persona, Empleado, etc.)
        Dim properties = datos.GetType().GetProperties()

        ' Crear una lista para los parámetros
        For Each prop As System.Reflection.PropertyInfo In properties
            ' Obtener el nombre de la propiedad y el valor
            Dim nombreParametro As String = "@" & prop.Name  ' Ejemplo: @idEmpleado, @nombre
            Dim valorParametro As Object = prop.GetValue(datos)  ' Obtener el valor de la propiedad

            ' Crear el parámetro y agregarlo al comando
            Dim param As New MySqlParameter(nombreParametro, valorParametro)
            cmd.Parameters.Add(param)
        Next

        ' Determinar el tipo de consulta (SELECT, INSERT, UPDATE, DELETE)
        If query.Trim().ToUpper().StartsWith("SELECT") Then
            ' Si es una consulta SELECT, ejecutamos ExecuteReader() y devolvemos los resultados
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim resultados As New List(Of Dictionary(Of String, Object))()

            While reader.Read()
                ' Crear un diccionario para cada fila
                Dim fila As New Dictionary(Of String, Object)()

                ' Agregar cada columna de la fila al diccionario
                For i As Integer = 0 To reader.FieldCount - 1
                    fila.Add(reader.GetName(i), reader.GetValue(i))
                Next

                ' Agregar la fila al resultado
                resultados.Add(fila)
            End While

            reader.Close()
            conexion.Close()

            ' Retornar los resultados de la consulta SELECT
            Return resultados

        Else
            ' Si no es un SELECT (INSERT, UPDATE, DELETE), ejecutamos ExecuteNonQuery()
            Try
                Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
                conexion.Close()

                ' Si las filas afectadas son mayores a 0, la operación fue exitosa
                Return filasAfectadas > 0
            Catch ex As Exception
                ' Manejo de excepciones
                conexion.Close()
                Return False
            End Try
        End If
    End Function




End Module

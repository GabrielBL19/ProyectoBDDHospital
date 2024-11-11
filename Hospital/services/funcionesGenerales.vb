Imports MySql.Data.MySqlClient


Module funcionesGenerales
    Public Function obtenerConexion() As MySqlConnection
        Return New MySqlConnection("server=127.0.0.1; user=root; password=; database=hospitalDb") 'MsqlConnection objeto de la libreria, 
    End Function

    Public Function insertarGeneral(query As String, datos As Object, Optional ByVal transaccion As MySqlTransaction = Nothing) As Boolean
        ' Crear la conexión a la base de datos
        Dim conexion As MySqlConnection = obtenerConexion()

        ' Crear el comando SQL
        Dim cmd As New MySqlCommand(query, conexion)
        If transaccion IsNot Nothing Then
            cmd.Transaction = transaccion
        End If

        ' Obtener las propiedades del objeto "datos" (que puede ser Persona o Enfermero)
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

        ' Ejecutar el comando
        Try
            conexion.Open()
            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            conexion.Close()
            Return filasAfectadas > 0
        Catch ex As Exception
            ' Manejo de excepciones
            conexion.Close()
            Return False
        End Try
    End Function





End Module

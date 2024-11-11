
Imports MySql.Data.MySqlClient

Public Class FormularioDoctores

    Public Function agDoctor() As Boolean
        Dim personaO As New C_persona()
        Dim doctor As New C_doctor()

        ' Rellenamos el objeto personaO con los datos personales
        personaO.numIdentidad = txtNumidentidad.Text
        personaO.nombre = txtNombDoc.Text
        personaO.apellido = txtApeDoc.Text
        personaO.correo = txtCorreoDoc.Text
        personaO.telefono = txtTelefono.Text
        personaO.direccion = txtDirecDoc.Text
        personaO.fechaNac = "2002-01-14"
        If rdbFemeninoDoc.Checked = True Then
            personaO.genero = 0
        Else
            personaO.genero = 1
        End If

        ' Crear la conexión y abrirla
        Dim conexion As MySqlConnection = obtenerConexion()
        conexion.Open()

        ' Iniciar una transacción
        Dim transaccion As MySqlTransaction = conexion.BeginTransaction()

        Try
            ' Comprobar si el numIdentidad ya existe
            Dim checkQuery As String = "SELECT COUNT(*) FROM persona WHERE numIdentidad = @numIdentidad"
            Dim cmdCheck As New MySqlCommand(checkQuery, conexion)
            cmdCheck.Parameters.AddWithValue("@numIdentidad", personaO.numIdentidad)
            cmdCheck.Transaction = transaccion

            Dim existe As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

            If existe > 0 Then
                ' Si ya existe, no hacer nada y mostrar mensaje
                MsgBox("El número de identidad ya está registrado.")
                Return False
            End If

            ' Insertar en la tabla persona
            Dim query1 As String = "INSERT INTO persona(numIdentidad, nombre, apellido, correo, genero, telefono, direccion, fechaNac) VALUES(@numIdentidad, @nombre, @apellido, @correo, @genero, @telefono, @direccion, @fechaNac)"
            Dim resultadoPersona As Boolean = insertarGeneral(query1, personaO, transaccion)
            If Not resultadoPersona Then
                ' Si falla la inserción en persona, revertir la transacción
                transaccion.Rollback()
                MsgBox("Error al insertar persona.")
                Return False
            End If

            ' Insertar en la tabla empleado
            Dim query2 As String = "INSERT INTO doctor(numIdentidad, estadoCivil, titulo, estado, sueldo) VALUES(@numIdentidad, @estadoCivil, @titulo, @estado, @sueldo)"
            doctor.numIdentidad = personaO.numIdentidad
            doctor.estadoCivil = 1 ' Suponiendo que el cargo es 1
            doctor.titulo = "adsad" ' Suponiendo que el estado civil es 1
            doctor.estado = If(rdbActivoDoc.Checked, 1, 0)
            doctor.sueldo = txtSueldoDoc.Text

            Dim resultadoEmpleado As Boolean = insertarGeneral(query2, doctor, transaccion)
            If Not resultadoEmpleado Then
                ' Si falla la inserción en empleado, revertir la transacción
                transaccion.Rollback()
                MsgBox("Error al insertar empleado.")
                Return False
            End If

            ' Si todo fue exitoso, hacer commit
            transaccion.Commit()

            ' Mensaje de éxito
            MsgBox("Empleado agregado correctamente.")
            Return True
        Catch ex As Exception
            ' En caso de error, revertir la transacción
            transaccion.Rollback()
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Private Sub btnAgregarDoc_Click(sender As Object, e As EventArgs) Handles btnAgregarDoc.Click
        agDoctor()


    End Sub
End Class
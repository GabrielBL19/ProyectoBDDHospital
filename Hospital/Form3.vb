Imports MySql.Data.MySqlClient

Public Class FormularioPacientes

    Public Function agPaciente() As Boolean
        Dim persona As New C_persona()
        Dim paciente As New C_paciente()

        Dim fechaDtp = dtpFechaNacPac.Value

        ' Rellenamos el objeto personaO con los datos personales
        persona.numIdentidad = txtIdentidadPaciente.Text
        persona.nombre = txtNombPac.Text
        persona.apellido = txtApePac.Text
        persona.correo = txtCorreoPac.Text
        persona.telefono = txtTelefonoPaciente.Text
        persona.direccion = txtDirecPac.Text
        persona.fechaNac = fechaDtp.ToString("yyyy-MM-dd")
        If rdbFemeninoPac.Checked = True Then
            persona.genero = 0
        Else
            persona.genero = 1
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
            cmdCheck.Parameters.AddWithValue("@numIdentidad", persona.numIdentidad)
            cmdCheck.Transaction = transaccion

            Dim existe As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

            If existe > 0 Then
                ' Si ya existe, no hacer nada y mostrar mensaje
                MsgBox("El número de identidad ya está registrado.")
                Return False
            End If

            ' Insertar en la tabla persona
            Dim query1 As String = "INSERT INTO persona(numIdentidad, nombre, apellido, correo, genero, telefono, direccion, fechaNac) VALUES(@numIdentidad, @nombre, @apellido, @correo, @genero, @telefono, @direccion, @fechaNac)"
            Dim resultadoPersona As Boolean = insertarGeneral(query1, persona, transaccion)
            If Not resultadoPersona Then
                ' Si falla la inserción en persona, revertir la transacción
                transaccion.Rollback()
                MsgBox("Error al insertar persona.")
                Return False
            End If

            ' Insertar en la tabla empleado
            Dim query2 As String = "INSERT INTO paciente(numIdentidad, numSeguro, nomResponsable, telefonoResponsable) VALUES(@numIdentidad, @numSeguro, @nomResponsable, @telefonoResponsable)"
            paciente.numIdentidad = persona.numIdentidad
            paciente.numSeguro = txtNumSeguroPac.Text
            paciente.nomResponsable = txtNombRespPac.Text
            paciente.telefonoResponsable = txtTelefonoPaciente.Text

            Dim resultadoEmpleado As Boolean = insertarGeneral(query2, paciente, transaccion)
            If Not resultadoEmpleado Then
                ' Si falla la inserción en empleado, revertir la transacción
                transaccion.Rollback()
                MsgBox("Error al insertar empleado.")
                Return False
            End If

            ' Si todo fue exitoso, hacer commit
            transaccion.Commit()

            ' Mensaje de éxito
            MsgBox("Paciente agregado correctamente.")
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

    Public Function actualizarPaciente() As Boolean
        Dim persona1 As New C_persona()
        Dim paciente As New C_paciente()

        ' Rellenamos los datos a actualizar
        persona1.numIdentidad = txtIdentidadPaciente.Text
        persona1.nombre = txtNombPac.Text
        persona1.apellido = txtApePac.Text
        persona1.correo = txtCorreoPac.Text
        persona1.telefono = txtTelefonoPaciente.Text
        persona1.direccion = txtDirecPac.Text
        persona1.fechaNac = dtpFechaNacPac.Value.ToString("yyyy-MM-dd")
        persona1.genero = If(rdbFemeninoPac.Checked, 0, 1)

        paciente.numIdentidad = persona1.numIdentidad
        paciente.numSeguro = txtNumSeguroPac.Text
        paciente.nomResponsable = txtNombRespPac.Text
        paciente.telefonoResponsable = txtTelRespPac.Text

        ' Crear la conexión
        Dim conexion As MySqlConnection = obtenerConexion()
        conexion.Open()

        ' Iniciar una transacción
        Dim transaccion As MySqlTransaction = conexion.BeginTransaction()

        Try
            ' Mostrar valores de depuración antes de ejecutar la actualización
            MsgBox("Actualizando persona con ID: " & persona1.numIdentidad)


            ' Actualizar todos los campos de la tabla persona
            Dim queryP As String = "UPDATE persona SET nombre = @nombre, apellido = @apellido, correo = @correo, telefono = @telefono, direccion = @direccion, fechaNac = @fechaNac, genero = @genero WHERE numIdentidad = @numIdentidad"
            Dim resultadoPersona As Boolean = actualizarGeneral1(queryP, persona1, transaccion)
            If Not resultadoPersona Then
                ' Si falla la actualización en persona, revertir la transacción
                transaccion.Rollback()
                MsgBox("Error al actualizar los datos de la persona.")
                Return False
            End If

            ' Actualizar todos los campos de la tabla paciente
            Dim query2 As String = "UPDATE paciente SET numSeguro = @numSeguro, nomResponsable = @nomResponsable, telefonoResponsable = @telefonoResponsable WHERE numIdentidad = @numIdentidad"
            Dim resultadoDoctor As Boolean = actualizarGeneral1(query2, paciente, transaccion)
            If Not resultadoDoctor Then
                ' Si falla la actualización en doctor, revertir la transacción
                transaccion.Rollback()
                MsgBox("Error al actualizar los datos del paciente.")
                Return False
            End If

            ' Si todo fue exitoso, hacer commit
            transaccion.Commit()

            ' Mensaje de éxito
            MsgBox("Datos actualizados correctamente.")
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

    Public Function eliminarPaciente() As Boolean
        Dim persona As New C_persona()
        Dim paciente As New C_paciente()

        ' Obtener el número de identidad del paciente a eliminar
        persona.numIdentidad = txtIdentidadPaciente.Text

        ' Crear la conexión
        Dim conexion As MySqlConnection = obtenerConexion()
        conexion.Open()

        ' Iniciar una transacción
        Dim transaccion As MySqlTransaction = conexion.BeginTransaction()

        Try
            ' Primero, eliminar el registro de la tabla paciente
            Dim query1 As String = "DELETE FROM paciente WHERE numIdentidad = @numIdentidad"
            Dim resultadoDoctor As Boolean = eliminarGeneral(query1, persona, transaccion)
            If Not resultadoDoctor Then
                ' Si falla la eliminación en doctor, revertir la transacción
                transaccion.Rollback()
                MsgBox("Error al eliminar los datos del paciente.")
                Return False
            End If

            ' Luego, eliminar el registro de la tabla persona
            Dim query2 As String = "DELETE FROM persona WHERE numIdentidad = @numIdentidad"
            Dim resultadoPersona As Boolean = eliminarGeneral(query2, persona, transaccion)
            If Not resultadoPersona Then
                ' Si falla la eliminación en persona, revertir la transacción
                transaccion.Rollback()
                MsgBox("Error al eliminar los datos de la persona.")
                Return False
            End If

            ' Si todo fue exitoso, hacer commit
            transaccion.Commit()

            ' Mensaje de éxito
            MsgBox("Datos eliminados correctamente.")
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
    Private Sub btnModificarPac_Click(sender As Object, e As EventArgs) Handles btnModificarPac.Click
        actualizarPaciente()
    End Sub

    Private Sub btnAgregarPac_Click(sender As Object, e As EventArgs) Handles btnAgregarPac.Click
        agPaciente()
    End Sub

    Private Sub btnEliminarPac_Click(sender As Object, e As EventArgs) Handles btnEliminarPac.Click
        eliminarPaciente()
    End Sub
End Class
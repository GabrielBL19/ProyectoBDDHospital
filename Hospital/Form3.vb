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
    Private Sub btnModificarPac_Click(sender As Object, e As EventArgs) Handles btnModificarPac.Click

    End Sub

    Private Sub btnAgregarPac_Click(sender As Object, e As EventArgs) Handles btnAgregarPac.Click
        agPaciente()
    End Sub
End Class
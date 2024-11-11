
Public Class FormularioDoctores
    Public Function agDoctor()
        Dim doctor As New C_doctor
        doctor.nombre = txtNombDoc.Text
        doctor.apellido = txtApeDoc.Text
        doctor.correo = txtCorreoDoc.Text

        If rdbMasculinoDoc.Checked Then
            doctor.genero = 0
        ElseIf rdbFemeninoDoc.Checked Then
            doctor.genero = 1
        End If
        doctor.telefono = txtTelefono.Text
        doctor.direccion = txtDirecDoc.Text
        Dim fechaNacDTP = dtpFechaNacDoc.Value
        doctor.fechaNac = fechaNacDTP.ToString("yyyy-MM-dd")

        Dim persona As New C_doctor

        Select Case cbxEstadoCivilDoc.SelectedIndex
            Case "Casado"
                persona.estadoCivil = "1"
            Case "Soltero"
                persona.estadoCivil = "2"
            Case "Viudo"
                persona.estadoCivil = "3"
        End Select
        persona.titulo = txtTituloDoc.Text
        If rdbActivoDoc.Checked Then
            persona.estado = 1
        ElseIf rdbFemeninoDoc.Checked Then
            persona.estado = 0
        End If
        persona.sueldo = txtSueldoDoc.Text


    End Function
End Class
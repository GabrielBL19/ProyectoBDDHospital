<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioProveedor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioProveedor))
        btnEliminarProveedor = New Button()
        btnActualizarProveedor = New Button()
        btnAgregarProveedor = New Button()
        grpDatosProfEnf = New GroupBox()
        cbxTipoProveedor = New ComboBox()
        lblTipoProveedor = New Label()
        rbObservacionProveedor = New RichTextBox()
        lblObervacionProveedor = New Label()
        txtEmpProveedor = New TextBox()
        lblEmpProveedor = New Label()
        grpDatosEnf = New GroupBox()
        btnBuscarProveedor = New Button()
        mskTelProveedor = New MaskedTextBox()
        lblTelefonoProveedor = New Label()
        txtCorreoProveedor = New TextBox()
        lblCorreoProveedor = New Label()
        txtDirecProveedor = New TextBox()
        lblDirecProveedor = New Label()
        grpGeneroProveedor = New GroupBox()
        rdbFemeninoProveedor = New RadioButton()
        rdbMasculinoProveedor = New RadioButton()
        txtEdadProveedor = New TextBox()
        lblEdadProveedor = New Label()
        dtpFechaNacProveedor = New DateTimePicker()
        lblFechaNacProveedor = New Label()
        txtApellidoProveedor = New TextBox()
        lblApellidoProveedor = New Label()
        TxNombProveedor = New TextBox()
        lblNombProveedor = New Label()
        mskIdentProveedor = New MaskedTextBox()
        lblIdentProveedor = New Label()
        lblNombFormProveedor = New Label()
        grpDatosProfEnf.SuspendLayout()
        grpDatosEnf.SuspendLayout()
        grpGeneroProveedor.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnEliminarProveedor
        ' 
        btnEliminarProveedor.Image = CType(resources.GetObject("btnEliminarProveedor.Image"), Image)
        btnEliminarProveedor.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarProveedor.Location = New Point(914, 377)
        btnEliminarProveedor.Name = "btnEliminarProveedor"
        btnEliminarProveedor.Size = New Size(168, 39)
        btnEliminarProveedor.TabIndex = 17
        btnEliminarProveedor.Text = "Eliminar Proveedor"
        btnEliminarProveedor.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarProveedor.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarProveedor
        ' 
        btnActualizarProveedor.Image = CType(resources.GetObject("btnActualizarProveedor.Image"), Image)
        btnActualizarProveedor.ImageAlign = ContentAlignment.MiddleRight
        btnActualizarProveedor.Location = New Point(730, 377)
        btnActualizarProveedor.Name = "btnActualizarProveedor"
        btnActualizarProveedor.Size = New Size(178, 39)
        btnActualizarProveedor.TabIndex = 16
        btnActualizarProveedor.Text = "Actualizar Proveedor"
        btnActualizarProveedor.TextAlign = ContentAlignment.MiddleLeft
        btnActualizarProveedor.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarProveedor
        ' 
        btnAgregarProveedor.Image = CType(resources.GetObject("btnAgregarProveedor.Image"), Image)
        btnAgregarProveedor.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarProveedor.Location = New Point(557, 377)
        btnAgregarProveedor.Name = "btnAgregarProveedor"
        btnAgregarProveedor.Size = New Size(167, 41)
        btnAgregarProveedor.TabIndex = 15
        btnAgregarProveedor.Text = "Agregar Proveedor"
        btnAgregarProveedor.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarProveedor.UseVisualStyleBackColor = True
        ' 
        ' grpDatosProfEnf
        ' 
        grpDatosProfEnf.Controls.Add(cbxTipoProveedor)
        grpDatosProfEnf.Controls.Add(lblTipoProveedor)
        grpDatosProfEnf.Controls.Add(rbObservacionProveedor)
        grpDatosProfEnf.Controls.Add(lblObervacionProveedor)
        grpDatosProfEnf.Controls.Add(txtEmpProveedor)
        grpDatosProfEnf.Controls.Add(lblEmpProveedor)
        grpDatosProfEnf.Location = New Point(604, 80)
        grpDatosProfEnf.Name = "grpDatosProfEnf"
        grpDatosProfEnf.Size = New Size(478, 258)
        grpDatosProfEnf.TabIndex = 14
        grpDatosProfEnf.TabStop = False
        grpDatosProfEnf.Text = "Datos Profesionales"
        ' 
        ' cbxTipoProveedor
        ' 
        cbxTipoProveedor.FormattingEnabled = True
        cbxTipoProveedor.Location = New Point(126, 56)
        cbxTipoProveedor.Name = "cbxTipoProveedor"
        cbxTipoProveedor.Size = New Size(194, 28)
        cbxTipoProveedor.TabIndex = 5
        ' 
        ' lblTipoProveedor
        ' 
        lblTipoProveedor.AutoSize = True
        lblTipoProveedor.Location = New Point(6, 64)
        lblTipoProveedor.Name = "lblTipoProveedor"
        lblTipoProveedor.Size = New Size(114, 20)
        lblTipoProveedor.TabIndex = 4
        lblTipoProveedor.Text = "Tipo Proveedor:"
        ' 
        ' rbObservacionProveedor
        ' 
        rbObservacionProveedor.Location = New Point(120, 107)
        rbObservacionProveedor.Name = "rbObservacionProveedor"
        rbObservacionProveedor.Size = New Size(344, 120)
        rbObservacionProveedor.TabIndex = 3
        rbObservacionProveedor.Text = ""
        ' 
        ' lblObervacionProveedor
        ' 
        lblObervacionProveedor.AutoSize = True
        lblObervacionProveedor.Location = New Point(6, 103)
        lblObervacionProveedor.Name = "lblObervacionProveedor"
        lblObervacionProveedor.Size = New Size(108, 20)
        lblObervacionProveedor.TabIndex = 2
        lblObervacionProveedor.Text = "Observaciones:"
        ' 
        ' txtEmpProveedor
        ' 
        txtEmpProveedor.Location = New Point(177, 22)
        txtEmpProveedor.Name = "txtEmpProveedor"
        txtEmpProveedor.Size = New Size(247, 27)
        txtEmpProveedor.TabIndex = 1
        ' 
        ' lblEmpProveedor
        ' 
        lblEmpProveedor.AutoSize = True
        lblEmpProveedor.Location = New Point(6, 29)
        lblEmpProveedor.Name = "lblEmpProveedor"
        lblEmpProveedor.Size = New Size(165, 20)
        lblEmpProveedor.TabIndex = 0
        lblEmpProveedor.Text = "Nombre de la empresa:"
        ' 
        ' grpDatosEnf
        ' 
        grpDatosEnf.Controls.Add(btnBuscarProveedor)
        grpDatosEnf.Controls.Add(mskTelProveedor)
        grpDatosEnf.Controls.Add(lblTelefonoProveedor)
        grpDatosEnf.Controls.Add(txtCorreoProveedor)
        grpDatosEnf.Controls.Add(lblCorreoProveedor)
        grpDatosEnf.Controls.Add(txtDirecProveedor)
        grpDatosEnf.Controls.Add(lblDirecProveedor)
        grpDatosEnf.Controls.Add(grpGeneroProveedor)
        grpDatosEnf.Controls.Add(txtEdadProveedor)
        grpDatosEnf.Controls.Add(lblEdadProveedor)
        grpDatosEnf.Controls.Add(dtpFechaNacProveedor)
        grpDatosEnf.Controls.Add(lblFechaNacProveedor)
        grpDatosEnf.Controls.Add(txtApellidoProveedor)
        grpDatosEnf.Controls.Add(lblApellidoProveedor)
        grpDatosEnf.Controls.Add(TxNombProveedor)
        grpDatosEnf.Controls.Add(lblNombProveedor)
        grpDatosEnf.Controls.Add(mskIdentProveedor)
        grpDatosEnf.Controls.Add(lblIdentProveedor)
        grpDatosEnf.Location = New Point(49, 80)
        grpDatosEnf.Name = "grpDatosEnf"
        grpDatosEnf.Size = New Size(489, 392)
        grpDatosEnf.TabIndex = 13
        grpDatosEnf.TabStop = False
        grpDatosEnf.Text = "Datos Personales"
        ' 
        ' btnBuscarProveedor
        ' 
        btnBuscarProveedor.Location = New Point(396, 26)
        btnBuscarProveedor.Name = "btnBuscarProveedor"
        btnBuscarProveedor.Size = New Size(87, 30)
        btnBuscarProveedor.TabIndex = 18
        btnBuscarProveedor.Text = "Buscar"
        btnBuscarProveedor.UseVisualStyleBackColor = True
        ' 
        ' mskTelProveedor
        ' 
        mskTelProveedor.Location = New Point(79, 346)
        mskTelProveedor.Name = "mskTelProveedor"
        mskTelProveedor.Size = New Size(174, 27)
        mskTelProveedor.TabIndex = 15
        ' 
        ' lblTelefonoProveedor
        ' 
        lblTelefonoProveedor.AutoSize = True
        lblTelefonoProveedor.Location = New Point(6, 353)
        lblTelefonoProveedor.Name = "lblTelefonoProveedor"
        lblTelefonoProveedor.Size = New Size(70, 20)
        lblTelefonoProveedor.TabIndex = 14
        lblTelefonoProveedor.Text = "Teléfono:"
        ' 
        ' txtCorreoProveedor
        ' 
        txtCorreoProveedor.Location = New Point(69, 309)
        txtCorreoProveedor.Name = "txtCorreoProveedor"
        txtCorreoProveedor.Size = New Size(155, 27)
        txtCorreoProveedor.TabIndex = 13
        ' 
        ' lblCorreoProveedor
        ' 
        lblCorreoProveedor.AutoSize = True
        lblCorreoProveedor.Location = New Point(6, 316)
        lblCorreoProveedor.Name = "lblCorreoProveedor"
        lblCorreoProveedor.Size = New Size(57, 20)
        lblCorreoProveedor.TabIndex = 12
        lblCorreoProveedor.Text = "Correo:"
        ' 
        ' txtDirecProveedor
        ' 
        txtDirecProveedor.Location = New Point(87, 277)
        txtDirecProveedor.Name = "txtDirecProveedor"
        txtDirecProveedor.Size = New Size(201, 27)
        txtDirecProveedor.TabIndex = 11
        ' 
        ' lblDirecProveedor
        ' 
        lblDirecProveedor.AutoSize = True
        lblDirecProveedor.Location = New Point(6, 284)
        lblDirecProveedor.Name = "lblDirecProveedor"
        lblDirecProveedor.Size = New Size(75, 20)
        lblDirecProveedor.TabIndex = 10
        lblDirecProveedor.Text = "Dirección:"
        ' 
        ' grpGeneroProveedor
        ' 
        grpGeneroProveedor.Controls.Add(rdbFemeninoProveedor)
        grpGeneroProveedor.Controls.Add(rdbMasculinoProveedor)
        grpGeneroProveedor.Location = New Point(79, 215)
        grpGeneroProveedor.Name = "grpGeneroProveedor"
        grpGeneroProveedor.Size = New Size(222, 49)
        grpGeneroProveedor.TabIndex = 9
        grpGeneroProveedor.TabStop = False
        grpGeneroProveedor.Text = "Género"
        ' 
        ' rdbFemeninoProveedor
        ' 
        rdbFemeninoProveedor.AutoSize = True
        rdbFemeninoProveedor.Location = New Point(8, 19)
        rdbFemeninoProveedor.Name = "rdbFemeninoProveedor"
        rdbFemeninoProveedor.Size = New Size(95, 24)
        rdbFemeninoProveedor.TabIndex = 10
        rdbFemeninoProveedor.TabStop = True
        rdbFemeninoProveedor.Text = "Femenino"
        rdbFemeninoProveedor.UseVisualStyleBackColor = True
        ' 
        ' rdbMasculinoProveedor
        ' 
        rdbMasculinoProveedor.AutoSize = True
        rdbMasculinoProveedor.Location = New Point(119, 19)
        rdbMasculinoProveedor.Name = "rdbMasculinoProveedor"
        rdbMasculinoProveedor.Size = New Size(97, 24)
        rdbMasculinoProveedor.TabIndex = 10
        rdbMasculinoProveedor.TabStop = True
        rdbMasculinoProveedor.Text = "Masculino"
        rdbMasculinoProveedor.UseVisualStyleBackColor = True
        ' 
        ' txtEdadProveedor
        ' 
        txtEdadProveedor.Location = New Point(58, 173)
        txtEdadProveedor.Name = "txtEdadProveedor"
        txtEdadProveedor.Size = New Size(156, 27)
        txtEdadProveedor.TabIndex = 2
        ' 
        ' lblEdadProveedor
        ' 
        lblEdadProveedor.AutoSize = True
        lblEdadProveedor.Location = New Point(6, 180)
        lblEdadProveedor.Name = "lblEdadProveedor"
        lblEdadProveedor.Size = New Size(46, 20)
        lblEdadProveedor.TabIndex = 8
        lblEdadProveedor.Text = "Edad:"
        ' 
        ' dtpFechaNacProveedor
        ' 
        dtpFechaNacProveedor.Location = New Point(164, 138)
        dtpFechaNacProveedor.Name = "dtpFechaNacProveedor"
        dtpFechaNacProveedor.Size = New Size(250, 27)
        dtpFechaNacProveedor.TabIndex = 7
        ' 
        ' lblFechaNacProveedor
        ' 
        lblFechaNacProveedor.AutoSize = True
        lblFechaNacProveedor.Location = New Point(6, 145)
        lblFechaNacProveedor.Name = "lblFechaNacProveedor"
        lblFechaNacProveedor.Size = New Size(152, 20)
        lblFechaNacProveedor.TabIndex = 6
        lblFechaNacProveedor.Text = "Fecha de Nacimiento:"
        ' 
        ' txtApellidoProveedor
        ' 
        txtApellidoProveedor.Location = New Point(79, 100)
        txtApellidoProveedor.Name = "txtApellidoProveedor"
        txtApellidoProveedor.Size = New Size(210, 27)
        txtApellidoProveedor.TabIndex = 5
        ' 
        ' lblApellidoProveedor
        ' 
        lblApellidoProveedor.AutoSize = True
        lblApellidoProveedor.Location = New Point(6, 107)
        lblApellidoProveedor.Name = "lblApellidoProveedor"
        lblApellidoProveedor.Size = New Size(69, 20)
        lblApellidoProveedor.TabIndex = 4
        lblApellidoProveedor.Text = "Apellido:"
        ' 
        ' TxNombProveedor
        ' 
        TxNombProveedor.Location = New Point(79, 64)
        TxNombProveedor.Name = "TxNombProveedor"
        TxNombProveedor.Size = New Size(201, 27)
        TxNombProveedor.TabIndex = 2
        ' 
        ' lblNombProveedor
        ' 
        lblNombProveedor.AutoSize = True
        lblNombProveedor.Location = New Point(6, 71)
        lblNombProveedor.Name = "lblNombProveedor"
        lblNombProveedor.Size = New Size(67, 20)
        lblNombProveedor.TabIndex = 3
        lblNombProveedor.Text = "Nombre:"
        ' 
        ' mskIdentProveedor
        ' 
        mskIdentProveedor.Location = New Point(164, 29)
        mskIdentProveedor.Name = "mskIdentProveedor"
        mskIdentProveedor.Size = New Size(226, 27)
        mskIdentProveedor.TabIndex = 2
        ' 
        ' lblIdentProveedor
        ' 
        lblIdentProveedor.AutoSize = True
        lblIdentProveedor.Location = New Point(6, 36)
        lblIdentProveedor.Name = "lblIdentProveedor"
        lblIdentProveedor.Size = New Size(155, 20)
        lblIdentProveedor.TabIndex = 2
        lblIdentProveedor.Text = "Número de Identidad:"
        ' 
        ' lblNombFormProveedor
        ' 
        lblNombFormProveedor.AutoSize = True
        lblNombFormProveedor.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormProveedor.Location = New Point(404, 9)
        lblNombFormProveedor.Name = "lblNombFormProveedor"
        lblNombFormProveedor.Size = New Size(377, 41)
        lblNombFormProveedor.TabIndex = 12
        lblNombFormProveedor.Text = "Formulario de Proveedores"
        ' 
        ' FormularioProveedor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1120, 614)
        Controls.Add(btnEliminarProveedor)
        Controls.Add(btnActualizarProveedor)
        Controls.Add(btnAgregarProveedor)
        Controls.Add(grpDatosProfEnf)
        Controls.Add(grpDatosEnf)
        Controls.Add(lblNombFormProveedor)
        Name = "FormularioProveedor"
        Text = "Proveedores"
        grpDatosProfEnf.ResumeLayout(False)
        grpDatosProfEnf.PerformLayout()
        grpDatosEnf.ResumeLayout(False)
        grpDatosEnf.PerformLayout()
        grpGeneroProveedor.ResumeLayout(False)
        grpGeneroProveedor.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents btnActualizarProveedor As Button
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents grpDatosProfEnf As GroupBox
    Friend WithEvents lblObervacionProveedor As Label
    Friend WithEvents txtEmpProveedor As TextBox
    Friend WithEvents lblEmpProveedor As Label
    Friend WithEvents grpDatosEnf As GroupBox
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents mskTelProveedor As MaskedTextBox
    Friend WithEvents lblTelefonoProveedor As Label
    Friend WithEvents txtCorreoProveedor As TextBox
    Friend WithEvents lblCorreoProveedor As Label
    Friend WithEvents txtDirecProveedor As TextBox
    Friend WithEvents lblDirecProveedor As Label
    Friend WithEvents grpGeneroProveedor As GroupBox
    Friend WithEvents rdbFemeninoProveedor As RadioButton
    Friend WithEvents rdbMasculinoProveedor As RadioButton
    Friend WithEvents txtEdadProveedor As TextBox
    Friend WithEvents lblEdadProveedor As Label
    Friend WithEvents dtpFechaNacProveedor As DateTimePicker
    Friend WithEvents lblFechaNacProveedor As Label
    Friend WithEvents txtApellidoProveedor As TextBox
    Friend WithEvents lblApellidoProveedor As Label
    Friend WithEvents TxNombProveedor As TextBox
    Friend WithEvents lblNombProveedor As Label
    Friend WithEvents mskIdentProveedor As MaskedTextBox
    Friend WithEvents lblIdentProveedor As Label
    Friend WithEvents lblNombFormProveedor As Label
    Friend WithEvents cbxTipoProveedor As ComboBox
    Friend WithEvents lblTipoProveedor As Label
    Friend WithEvents rbObservacionProveedor As RichTextBox
End Class

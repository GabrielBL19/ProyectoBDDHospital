<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioDoctores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioDoctores))
        lblFormDoc = New Label()
        grpDatosDoc = New GroupBox()
        btnBuscarDoc = New Button()
        cbxEstadoCivilDoc = New ComboBox()
        lblEstadoCivilDoc = New Label()
        mskTelDoc = New MaskedTextBox()
        lblTelDoc = New Label()
        txtCorreoDoc = New TextBox()
        lblCorreoDoc = New Label()
        txtDirecDoc = New TextBox()
        lblDirecDoc = New Label()
        grpGeneroDoc = New GroupBox()
        rdbMasculinoDoc = New RadioButton()
        rdbFemeninoDoc = New RadioButton()
        txtEdadDoc = New TextBox()
        lblEdadDoc = New Label()
        dtpFechaNacDoc = New DateTimePicker()
        lblFechaNacDoc = New Label()
        txtApeDoc = New TextBox()
        lblApeDoc = New Label()
        txtNombDoc = New TextBox()
        lblNombDoc = New Label()
        mskIdDoc = New MaskedTextBox()
        lblIdDoc = New Label()
        grpDatosProfesionalesDoc = New GroupBox()
        grpEstadoDoc = New GroupBox()
        rdbInactivoDoc = New RadioButton()
        rdbActivoDoc = New RadioButton()
        txtSueldoDoc = New TextBox()
        lblSueldoDoc = New Label()
        txtTituloDoc = New TextBox()
        lblTituloDoc = New Label()
        cbxEspDoc = New ComboBox()
        lblEspDoc = New Label()
        btnAgregarDoc = New Button()
        btnModificarDoc = New Button()
        btnEliminarDoc = New Button()
        grpDatosDoc.SuspendLayout()
        grpGeneroDoc.SuspendLayout()
        grpDatosProfesionalesDoc.SuspendLayout()
        grpEstadoDoc.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblFormDoc
        ' 
        lblFormDoc.AutoSize = True
        lblFormDoc.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFormDoc.Location = New Point(383, 20)
        lblFormDoc.Name = "lblFormDoc"
        lblFormDoc.Size = New Size(331, 41)
        lblFormDoc.TabIndex = 0
        lblFormDoc.Text = "Formulario de Doctores"
        ' 
        ' grpDatosDoc
        ' 
        grpDatosDoc.Controls.Add(btnBuscarDoc)
        grpDatosDoc.Controls.Add(cbxEstadoCivilDoc)
        grpDatosDoc.Controls.Add(lblEstadoCivilDoc)
        grpDatosDoc.Controls.Add(mskTelDoc)
        grpDatosDoc.Controls.Add(lblTelDoc)
        grpDatosDoc.Controls.Add(txtCorreoDoc)
        grpDatosDoc.Controls.Add(lblCorreoDoc)
        grpDatosDoc.Controls.Add(txtDirecDoc)
        grpDatosDoc.Controls.Add(lblDirecDoc)
        grpDatosDoc.Controls.Add(grpGeneroDoc)
        grpDatosDoc.Controls.Add(txtEdadDoc)
        grpDatosDoc.Controls.Add(lblEdadDoc)
        grpDatosDoc.Controls.Add(dtpFechaNacDoc)
        grpDatosDoc.Controls.Add(lblFechaNacDoc)
        grpDatosDoc.Controls.Add(txtApeDoc)
        grpDatosDoc.Controls.Add(lblApeDoc)
        grpDatosDoc.Controls.Add(txtNombDoc)
        grpDatosDoc.Controls.Add(lblNombDoc)
        grpDatosDoc.Controls.Add(mskIdDoc)
        grpDatosDoc.Controls.Add(lblIdDoc)
        grpDatosDoc.Location = New Point(76, 81)
        grpDatosDoc.Name = "grpDatosDoc"
        grpDatosDoc.Size = New Size(447, 426)
        grpDatosDoc.TabIndex = 1
        grpDatosDoc.TabStop = False
        grpDatosDoc.Text = "Datos Personales"
        ' 
        ' btnBuscarDoc
        ' 
        btnBuscarDoc.Location = New Point(366, 22)
        btnBuscarDoc.Name = "btnBuscarDoc"
        btnBuscarDoc.Size = New Size(67, 31)
        btnBuscarDoc.TabIndex = 6
        btnBuscarDoc.Text = "Buscar"
        btnBuscarDoc.UseVisualStyleBackColor = True
        ' 
        ' cbxEstadoCivilDoc
        ' 
        cbxEstadoCivilDoc.FormattingEnabled = True
        cbxEstadoCivilDoc.Location = New Point(101, 372)
        cbxEstadoCivilDoc.Name = "cbxEstadoCivilDoc"
        cbxEstadoCivilDoc.Size = New Size(151, 28)
        cbxEstadoCivilDoc.TabIndex = 13
        ' 
        ' lblEstadoCivilDoc
        ' 
        lblEstadoCivilDoc.AutoSize = True
        lblEstadoCivilDoc.Location = New Point(6, 380)
        lblEstadoCivilDoc.Name = "lblEstadoCivilDoc"
        lblEstadoCivilDoc.Size = New Size(89, 20)
        lblEstadoCivilDoc.TabIndex = 12
        lblEstadoCivilDoc.Text = "Estado Civil:"
        ' 
        ' mskTelDoc
        ' 
        mskTelDoc.Location = New Point(82, 338)
        mskTelDoc.Name = "mskTelDoc"
        mskTelDoc.Size = New Size(176, 27)
        mskTelDoc.TabIndex = 11
        ' 
        ' lblTelDoc
        ' 
        lblTelDoc.AutoSize = True
        lblTelDoc.Location = New Point(6, 345)
        lblTelDoc.Name = "lblTelDoc"
        lblTelDoc.Size = New Size(70, 20)
        lblTelDoc.TabIndex = 2
        lblTelDoc.Text = "Teléfono:"
        ' 
        ' txtCorreoDoc
        ' 
        txtCorreoDoc.Location = New Point(69, 306)
        txtCorreoDoc.Name = "txtCorreoDoc"
        txtCorreoDoc.Size = New Size(189, 27)
        txtCorreoDoc.TabIndex = 10
        ' 
        ' lblCorreoDoc
        ' 
        lblCorreoDoc.AutoSize = True
        lblCorreoDoc.Location = New Point(6, 313)
        lblCorreoDoc.Name = "lblCorreoDoc"
        lblCorreoDoc.Size = New Size(57, 20)
        lblCorreoDoc.TabIndex = 9
        lblCorreoDoc.Text = "Correo:"
        ' 
        ' txtDirecDoc
        ' 
        txtDirecDoc.Location = New Point(86, 273)
        txtDirecDoc.Name = "txtDirecDoc"
        txtDirecDoc.Size = New Size(195, 27)
        txtDirecDoc.TabIndex = 8
        ' 
        ' lblDirecDoc
        ' 
        lblDirecDoc.AutoSize = True
        lblDirecDoc.Location = New Point(6, 280)
        lblDirecDoc.Name = "lblDirecDoc"
        lblDirecDoc.Size = New Size(75, 20)
        lblDirecDoc.TabIndex = 7
        lblDirecDoc.Text = "Dirección:"
        ' 
        ' grpGeneroDoc
        ' 
        grpGeneroDoc.Controls.Add(rdbMasculinoDoc)
        grpGeneroDoc.Controls.Add(rdbFemeninoDoc)
        grpGeneroDoc.Location = New Point(110, 202)
        grpGeneroDoc.Name = "grpGeneroDoc"
        grpGeneroDoc.Size = New Size(217, 61)
        grpGeneroDoc.TabIndex = 6
        grpGeneroDoc.TabStop = False
        grpGeneroDoc.Text = "Género"
        ' 
        ' rdbMasculinoDoc
        ' 
        rdbMasculinoDoc.AutoSize = True
        rdbMasculinoDoc.Location = New Point(114, 26)
        rdbMasculinoDoc.Name = "rdbMasculinoDoc"
        rdbMasculinoDoc.Size = New Size(97, 24)
        rdbMasculinoDoc.TabIndex = 3
        rdbMasculinoDoc.TabStop = True
        rdbMasculinoDoc.Text = "Masculino"
        rdbMasculinoDoc.UseVisualStyleBackColor = True
        ' 
        ' rdbFemeninoDoc
        ' 
        rdbFemeninoDoc.AutoSize = True
        rdbFemeninoDoc.Location = New Point(6, 26)
        rdbFemeninoDoc.Name = "rdbFemeninoDoc"
        rdbFemeninoDoc.Size = New Size(95, 24)
        rdbFemeninoDoc.TabIndex = 2
        rdbFemeninoDoc.TabStop = True
        rdbFemeninoDoc.Text = "Femenino"
        rdbFemeninoDoc.UseVisualStyleBackColor = True
        ' 
        ' txtEdadDoc
        ' 
        txtEdadDoc.Location = New Point(58, 158)
        txtEdadDoc.Name = "txtEdadDoc"
        txtEdadDoc.Size = New Size(125, 27)
        txtEdadDoc.TabIndex = 2
        ' 
        ' lblEdadDoc
        ' 
        lblEdadDoc.AutoSize = True
        lblEdadDoc.Location = New Point(6, 165)
        lblEdadDoc.Name = "lblEdadDoc"
        lblEdadDoc.Size = New Size(46, 20)
        lblEdadDoc.TabIndex = 5
        lblEdadDoc.Text = "Edad:"
        ' 
        ' dtpFechaNacDoc
        ' 
        dtpFechaNacDoc.Location = New Point(161, 127)
        dtpFechaNacDoc.Name = "dtpFechaNacDoc"
        dtpFechaNacDoc.Size = New Size(250, 27)
        dtpFechaNacDoc.TabIndex = 4
        ' 
        ' lblFechaNacDoc
        ' 
        lblFechaNacDoc.AutoSize = True
        lblFechaNacDoc.Location = New Point(6, 134)
        lblFechaNacDoc.Name = "lblFechaNacDoc"
        lblFechaNacDoc.Size = New Size(149, 20)
        lblFechaNacDoc.TabIndex = 2
        lblFechaNacDoc.Text = "Fecha de nacimiento:"
        ' 
        ' txtApeDoc
        ' 
        txtApeDoc.Location = New Point(79, 93)
        txtApeDoc.Name = "txtApeDoc"
        txtApeDoc.Size = New Size(202, 27)
        txtApeDoc.TabIndex = 2
        ' 
        ' lblApeDoc
        ' 
        lblApeDoc.AutoSize = True
        lblApeDoc.Location = New Point(6, 100)
        lblApeDoc.Name = "lblApeDoc"
        lblApeDoc.Size = New Size(69, 20)
        lblApeDoc.TabIndex = 2
        lblApeDoc.Text = "Apellido:"
        ' 
        ' txtNombDoc
        ' 
        txtNombDoc.Location = New Point(79, 58)
        txtNombDoc.Name = "txtNombDoc"
        txtNombDoc.Size = New Size(202, 27)
        txtNombDoc.TabIndex = 2
        ' 
        ' lblNombDoc
        ' 
        lblNombDoc.AutoSize = True
        lblNombDoc.Location = New Point(6, 65)
        lblNombDoc.Name = "lblNombDoc"
        lblNombDoc.Size = New Size(67, 20)
        lblNombDoc.TabIndex = 3
        lblNombDoc.Text = "Nombre:"
        ' 
        ' mskIdDoc
        ' 
        mskIdDoc.Location = New Point(167, 25)
        mskIdDoc.Name = "mskIdDoc"
        mskIdDoc.Size = New Size(193, 27)
        mskIdDoc.TabIndex = 2
        ' 
        ' lblIdDoc
        ' 
        lblIdDoc.AutoSize = True
        lblIdDoc.Location = New Point(6, 32)
        lblIdDoc.Name = "lblIdDoc"
        lblIdDoc.Size = New Size(155, 20)
        lblIdDoc.TabIndex = 2
        lblIdDoc.Text = "Número de Identidad:"
        ' 
        ' grpDatosProfesionalesDoc
        ' 
        grpDatosProfesionalesDoc.Controls.Add(grpEstadoDoc)
        grpDatosProfesionalesDoc.Controls.Add(txtSueldoDoc)
        grpDatosProfesionalesDoc.Controls.Add(lblSueldoDoc)
        grpDatosProfesionalesDoc.Controls.Add(txtTituloDoc)
        grpDatosProfesionalesDoc.Controls.Add(lblTituloDoc)
        grpDatosProfesionalesDoc.Controls.Add(cbxEspDoc)
        grpDatosProfesionalesDoc.Controls.Add(lblEspDoc)
        grpDatosProfesionalesDoc.Location = New Point(587, 81)
        grpDatosProfesionalesDoc.Name = "grpDatosProfesionalesDoc"
        grpDatosProfesionalesDoc.Size = New Size(314, 211)
        grpDatosProfesionalesDoc.TabIndex = 2
        grpDatosProfesionalesDoc.TabStop = False
        grpDatosProfesionalesDoc.Text = "Datos Profesionales"
        ' 
        ' grpEstadoDoc
        ' 
        grpEstadoDoc.Controls.Add(rdbInactivoDoc)
        grpEstadoDoc.Controls.Add(rdbActivoDoc)
        grpEstadoDoc.Location = New Point(62, 134)
        grpEstadoDoc.Name = "grpEstadoDoc"
        grpEstadoDoc.Size = New Size(183, 65)
        grpEstadoDoc.TabIndex = 6
        grpEstadoDoc.TabStop = False
        grpEstadoDoc.Text = "Estado"
        ' 
        ' rdbInactivoDoc
        ' 
        rdbInactivoDoc.AutoSize = True
        rdbInactivoDoc.Location = New Point(95, 29)
        rdbInactivoDoc.Name = "rdbInactivoDoc"
        rdbInactivoDoc.Size = New Size(82, 24)
        rdbInactivoDoc.TabIndex = 1
        rdbInactivoDoc.TabStop = True
        rdbInactivoDoc.Text = "Inactivo"
        rdbInactivoDoc.UseVisualStyleBackColor = True
        ' 
        ' rdbActivoDoc
        ' 
        rdbActivoDoc.AutoSize = True
        rdbActivoDoc.Location = New Point(8, 29)
        rdbActivoDoc.Name = "rdbActivoDoc"
        rdbActivoDoc.Size = New Size(72, 24)
        rdbActivoDoc.TabIndex = 0
        rdbActivoDoc.TabStop = True
        rdbActivoDoc.Text = "Activo"
        rdbActivoDoc.UseVisualStyleBackColor = True
        ' 
        ' txtSueldoDoc
        ' 
        txtSueldoDoc.Location = New Point(70, 93)
        txtSueldoDoc.Name = "txtSueldoDoc"
        txtSueldoDoc.Size = New Size(140, 27)
        txtSueldoDoc.TabIndex = 5
        ' 
        ' lblSueldoDoc
        ' 
        lblSueldoDoc.AutoSize = True
        lblSueldoDoc.Location = New Point(6, 100)
        lblSueldoDoc.Name = "lblSueldoDoc"
        lblSueldoDoc.Size = New Size(58, 20)
        lblSueldoDoc.TabIndex = 4
        lblSueldoDoc.Text = "Sueldo:"
        ' 
        ' txtTituloDoc
        ' 
        txtTituloDoc.Location = New Point(62, 58)
        txtTituloDoc.Name = "txtTituloDoc"
        txtTituloDoc.Size = New Size(169, 27)
        txtTituloDoc.TabIndex = 3
        ' 
        ' lblTituloDoc
        ' 
        lblTituloDoc.AutoSize = True
        lblTituloDoc.Location = New Point(6, 65)
        lblTituloDoc.Name = "lblTituloDoc"
        lblTituloDoc.Size = New Size(50, 20)
        lblTituloDoc.TabIndex = 2
        lblTituloDoc.Text = "Título:"
        ' 
        ' cbxEspDoc
        ' 
        cbxEspDoc.FormattingEnabled = True
        cbxEspDoc.Location = New Point(108, 24)
        cbxEspDoc.Name = "cbxEspDoc"
        cbxEspDoc.Size = New Size(182, 28)
        cbxEspDoc.TabIndex = 1
        ' 
        ' lblEspDoc
        ' 
        lblEspDoc.AutoSize = True
        lblEspDoc.Location = New Point(6, 32)
        lblEspDoc.Name = "lblEspDoc"
        lblEspDoc.Size = New Size(96, 20)
        lblEspDoc.TabIndex = 0
        lblEspDoc.Text = "Especialidad:"
        ' 
        ' btnAgregarDoc
        ' 
        btnAgregarDoc.Image = CType(resources.GetObject("btnAgregarDoc.Image"), Image)
        btnAgregarDoc.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarDoc.Location = New Point(571, 394)
        btnAgregarDoc.Name = "btnAgregarDoc"
        btnAgregarDoc.Size = New Size(94, 40)
        btnAgregarDoc.TabIndex = 3
        btnAgregarDoc.Text = "Agregar"
        btnAgregarDoc.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarDoc.UseVisualStyleBackColor = True
        ' 
        ' btnModificarDoc
        ' 
        btnModificarDoc.Image = CType(resources.GetObject("btnModificarDoc.Image"), Image)
        btnModificarDoc.ImageAlign = ContentAlignment.MiddleRight
        btnModificarDoc.Location = New Point(692, 394)
        btnModificarDoc.Name = "btnModificarDoc"
        btnModificarDoc.Size = New Size(105, 40)
        btnModificarDoc.TabIndex = 4
        btnModificarDoc.Text = "Modificar"
        btnModificarDoc.TextAlign = ContentAlignment.MiddleLeft
        btnModificarDoc.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarDoc
        ' 
        btnEliminarDoc.Image = CType(resources.GetObject("btnEliminarDoc.Image"), Image)
        btnEliminarDoc.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarDoc.Location = New Point(830, 394)
        btnEliminarDoc.Name = "btnEliminarDoc"
        btnEliminarDoc.Size = New Size(97, 40)
        btnEliminarDoc.TabIndex = 5
        btnEliminarDoc.Text = "Eliminar"
        btnEliminarDoc.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarDoc.UseVisualStyleBackColor = True
        ' 
        ' FormularioDoctores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1055, 588)
        Controls.Add(btnEliminarDoc)
        Controls.Add(btnModificarDoc)
        Controls.Add(btnAgregarDoc)
        Controls.Add(grpDatosProfesionalesDoc)
        Controls.Add(grpDatosDoc)
        Controls.Add(lblFormDoc)
        Name = "FormularioDoctores"
        Text = "Doctores"
        grpDatosDoc.ResumeLayout(False)
        grpDatosDoc.PerformLayout()
        grpGeneroDoc.ResumeLayout(False)
        grpGeneroDoc.PerformLayout()
        grpDatosProfesionalesDoc.ResumeLayout(False)
        grpDatosProfesionalesDoc.PerformLayout()
        grpEstadoDoc.ResumeLayout(False)
        grpEstadoDoc.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFormDoc As Label
    Friend WithEvents grpDatosDoc As GroupBox
    Friend WithEvents txtApeDoc As TextBox
    Friend WithEvents lblApeDoc As Label
    Friend WithEvents txtNombDoc As TextBox
    Friend WithEvents lblNombDoc As Label
    Friend WithEvents mskIdDoc As MaskedTextBox
    Friend WithEvents lblIdDoc As Label
    Friend WithEvents lblFechaNacDoc As Label
    Friend WithEvents txtEdadDoc As TextBox
    Friend WithEvents lblEdadDoc As Label
    Friend WithEvents dtpFechaNacDoc As DateTimePicker
    Friend WithEvents lblCorreoDoc As Label
    Friend WithEvents txtDirecDoc As TextBox
    Friend WithEvents lblDirecDoc As Label
    Friend WithEvents grpGeneroDoc As GroupBox
    Friend WithEvents rdbMasculinoDoc As RadioButton
    Friend WithEvents rdbFemeninoDoc As RadioButton
    Friend WithEvents mskTelDoc As MaskedTextBox
    Friend WithEvents lblTelDoc As Label
    Friend WithEvents txtCorreoDoc As TextBox
    Friend WithEvents cbxEstadoCivilDoc As ComboBox
    Friend WithEvents lblEstadoCivilDoc As Label
    Friend WithEvents grpDatosProfesionalesDoc As GroupBox
    Friend WithEvents lblEspDoc As Label
    Friend WithEvents grpEstadoDoc As GroupBox
    Friend WithEvents rdbInactivoDoc As RadioButton
    Friend WithEvents rdbActivoDoc As RadioButton
    Friend WithEvents txtSueldoDoc As TextBox
    Friend WithEvents lblSueldoDoc As Label
    Friend WithEvents txtTituloDoc As TextBox
    Friend WithEvents lblTituloDoc As Label
    Friend WithEvents cbxEspDoc As ComboBox
    Friend WithEvents btnBuscarDoc As Button
    Friend WithEvents btnAgregarDoc As Button
    Friend WithEvents btnModificarDoc As Button
    Friend WithEvents btnEliminarDoc As Button
End Class

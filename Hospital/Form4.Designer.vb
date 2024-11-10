<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioEnfermeros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioEnfermeros))
        btnElimEnf = New Button()
        btnModificarEnf = New Button()
        btnAgregarEnf = New Button()
        grpDatosProfEnf = New GroupBox()
        grpEstadoEnf = New GroupBox()
        rdbInactivoEnf = New RadioButton()
        rdbActivoEnf = New RadioButton()
        txtSueldoEnf = New TextBox()
        lblSueldoEnf = New Label()
        txtTituloEnf = New TextBox()
        lblTituloEnf = New Label()
        txtEspEnf = New TextBox()
        lblEspEnf = New Label()
        grpDatosEnf = New GroupBox()
        btnBuscEnf = New Button()
        cbxEstadoCivEnf = New ComboBox()
        lblEstadoCivEnf = New Label()
        mskTelEnf = New MaskedTextBox()
        lblTelefonoEnf = New Label()
        txtCorreoEnf = New TextBox()
        lblCorreoEnf = New Label()
        txtDirecEnf = New TextBox()
        lblDirecEnf = New Label()
        grpGeneroEnf = New GroupBox()
        rdbFemeninoEnf = New RadioButton()
        rdbMasculinoEnf = New RadioButton()
        txtEdadEnf = New TextBox()
        lblEdadEnf = New Label()
        dtpFechaNacEnf = New DateTimePicker()
        lblFechaNacEnf = New Label()
        txtApeEnf = New TextBox()
        lblApeEnf = New Label()
        TxNombEnf = New TextBox()
        lblNombEnf = New Label()
        mskIdentEnf = New MaskedTextBox()
        lblIdentEnf = New Label()
        lblNombFormEnf = New Label()
        grpDatosProfEnf.SuspendLayout()
        grpEstadoEnf.SuspendLayout()
        grpDatosEnf.SuspendLayout()
        grpGeneroEnf.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnElimEnf
        ' 
        btnElimEnf.Image = CType(resources.GetObject("btnElimEnf.Image"), Image)
        btnElimEnf.ImageAlign = ContentAlignment.MiddleRight
        btnElimEnf.Location = New Point(933, 374)
        btnElimEnf.Name = "btnElimEnf"
        btnElimEnf.Size = New Size(96, 42)
        btnElimEnf.TabIndex = 11
        btnElimEnf.Text = "Eliminar"
        btnElimEnf.TextAlign = ContentAlignment.MiddleLeft
        btnElimEnf.UseVisualStyleBackColor = True
        ' 
        ' btnModificarEnf
        ' 
        btnModificarEnf.Image = CType(resources.GetObject("btnModificarEnf.Image"), Image)
        btnModificarEnf.ImageAlign = ContentAlignment.MiddleRight
        btnModificarEnf.Location = New Point(801, 374)
        btnModificarEnf.Name = "btnModificarEnf"
        btnModificarEnf.Size = New Size(106, 42)
        btnModificarEnf.TabIndex = 10
        btnModificarEnf.Text = "Actualizar"
        btnModificarEnf.TextAlign = ContentAlignment.MiddleLeft
        btnModificarEnf.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarEnf
        ' 
        btnAgregarEnf.Image = CType(resources.GetObject("btnAgregarEnf.Image"), Image)
        btnAgregarEnf.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarEnf.Location = New Point(682, 374)
        btnAgregarEnf.Name = "btnAgregarEnf"
        btnAgregarEnf.Size = New Size(93, 42)
        btnAgregarEnf.TabIndex = 9
        btnAgregarEnf.Text = "Agregar"
        btnAgregarEnf.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarEnf.UseVisualStyleBackColor = True
        ' 
        ' grpDatosProfEnf
        ' 
        grpDatosProfEnf.Controls.Add(grpEstadoEnf)
        grpDatosProfEnf.Controls.Add(txtSueldoEnf)
        grpDatosProfEnf.Controls.Add(lblSueldoEnf)
        grpDatosProfEnf.Controls.Add(txtTituloEnf)
        grpDatosProfEnf.Controls.Add(lblTituloEnf)
        grpDatosProfEnf.Controls.Add(txtEspEnf)
        grpDatosProfEnf.Controls.Add(lblEspEnf)
        grpDatosProfEnf.Location = New Point(673, 80)
        grpDatosProfEnf.Name = "grpDatosProfEnf"
        grpDatosProfEnf.Size = New Size(380, 214)
        grpDatosProfEnf.TabIndex = 8
        grpDatosProfEnf.TabStop = False
        grpDatosProfEnf.Text = "Datos Profesionales"
        ' 
        ' grpEstadoEnf
        ' 
        grpEstadoEnf.Controls.Add(rdbInactivoEnf)
        grpEstadoEnf.Controls.Add(rdbActivoEnf)
        grpEstadoEnf.Location = New Point(108, 138)
        grpEstadoEnf.Name = "grpEstadoEnf"
        grpEstadoEnf.Size = New Size(172, 50)
        grpEstadoEnf.TabIndex = 6
        grpEstadoEnf.TabStop = False
        grpEstadoEnf.Text = "Estado"
        ' 
        ' rdbInactivoEnf
        ' 
        rdbInactivoEnf.AutoSize = True
        rdbInactivoEnf.Location = New Point(84, 20)
        rdbInactivoEnf.Name = "rdbInactivoEnf"
        rdbInactivoEnf.Size = New Size(82, 24)
        rdbInactivoEnf.TabIndex = 1
        rdbInactivoEnf.TabStop = True
        rdbInactivoEnf.Text = "Inactivo"
        rdbInactivoEnf.UseVisualStyleBackColor = True
        ' 
        ' rdbActivoEnf
        ' 
        rdbActivoEnf.AutoSize = True
        rdbActivoEnf.Location = New Point(6, 20)
        rdbActivoEnf.Name = "rdbActivoEnf"
        rdbActivoEnf.Size = New Size(72, 24)
        rdbActivoEnf.TabIndex = 0
        rdbActivoEnf.TabStop = True
        rdbActivoEnf.Text = "Activo"
        rdbActivoEnf.UseVisualStyleBackColor = True
        ' 
        ' txtSueldoEnf
        ' 
        txtSueldoEnf.Location = New Point(70, 100)
        txtSueldoEnf.Name = "txtSueldoEnf"
        txtSueldoEnf.Size = New Size(125, 27)
        txtSueldoEnf.TabIndex = 5
        ' 
        ' lblSueldoEnf
        ' 
        lblSueldoEnf.AutoSize = True
        lblSueldoEnf.Location = New Point(6, 107)
        lblSueldoEnf.Name = "lblSueldoEnf"
        lblSueldoEnf.Size = New Size(58, 20)
        lblSueldoEnf.TabIndex = 4
        lblSueldoEnf.Text = "Sueldo:"
        ' 
        ' txtTituloEnf
        ' 
        txtTituloEnf.Location = New Point(62, 60)
        txtTituloEnf.Name = "txtTituloEnf"
        txtTituloEnf.Size = New Size(172, 27)
        txtTituloEnf.TabIndex = 3
        ' 
        ' lblTituloEnf
        ' 
        lblTituloEnf.AutoSize = True
        lblTituloEnf.Location = New Point(6, 67)
        lblTituloEnf.Name = "lblTituloEnf"
        lblTituloEnf.Size = New Size(50, 20)
        lblTituloEnf.TabIndex = 2
        lblTituloEnf.Text = "Título:"
        ' 
        ' txtEspEnf
        ' 
        txtEspEnf.Location = New Point(108, 22)
        txtEspEnf.Name = "txtEspEnf"
        txtEspEnf.Size = New Size(190, 27)
        txtEspEnf.TabIndex = 1
        ' 
        ' lblEspEnf
        ' 
        lblEspEnf.AutoSize = True
        lblEspEnf.Location = New Point(6, 29)
        lblEspEnf.Name = "lblEspEnf"
        lblEspEnf.Size = New Size(96, 20)
        lblEspEnf.TabIndex = 0
        lblEspEnf.Text = "Especialidad:"
        ' 
        ' grpDatosEnf
        ' 
        grpDatosEnf.Controls.Add(btnBuscEnf)
        grpDatosEnf.Controls.Add(cbxEstadoCivEnf)
        grpDatosEnf.Controls.Add(lblEstadoCivEnf)
        grpDatosEnf.Controls.Add(mskTelEnf)
        grpDatosEnf.Controls.Add(lblTelefonoEnf)
        grpDatosEnf.Controls.Add(txtCorreoEnf)
        grpDatosEnf.Controls.Add(lblCorreoEnf)
        grpDatosEnf.Controls.Add(txtDirecEnf)
        grpDatosEnf.Controls.Add(lblDirecEnf)
        grpDatosEnf.Controls.Add(grpGeneroEnf)
        grpDatosEnf.Controls.Add(txtEdadEnf)
        grpDatosEnf.Controls.Add(lblEdadEnf)
        grpDatosEnf.Controls.Add(dtpFechaNacEnf)
        grpDatosEnf.Controls.Add(lblFechaNacEnf)
        grpDatosEnf.Controls.Add(txtApeEnf)
        grpDatosEnf.Controls.Add(lblApeEnf)
        grpDatosEnf.Controls.Add(TxNombEnf)
        grpDatosEnf.Controls.Add(lblNombEnf)
        grpDatosEnf.Controls.Add(mskIdentEnf)
        grpDatosEnf.Controls.Add(lblIdentEnf)
        grpDatosEnf.Location = New Point(43, 80)
        grpDatosEnf.Name = "grpDatosEnf"
        grpDatosEnf.Size = New Size(489, 427)
        grpDatosEnf.TabIndex = 7
        grpDatosEnf.TabStop = False
        grpDatosEnf.Text = "Datos Personales"
        ' 
        ' btnBuscEnf
        ' 
        btnBuscEnf.Location = New Point(396, 26)
        btnBuscEnf.Name = "btnBuscEnf"
        btnBuscEnf.Size = New Size(87, 30)
        btnBuscEnf.TabIndex = 18
        btnBuscEnf.Text = "Buscar"
        btnBuscEnf.UseVisualStyleBackColor = True
        ' 
        ' cbxEstadoCivEnf
        ' 
        cbxEstadoCivEnf.FormattingEnabled = True
        cbxEstadoCivEnf.Items.AddRange(New Object() {"Casado", "Soltero", "Viudo"})
        cbxEstadoCivEnf.Location = New Point(101, 380)
        cbxEstadoCivEnf.Name = "cbxEstadoCivEnf"
        cbxEstadoCivEnf.Size = New Size(151, 28)
        cbxEstadoCivEnf.TabIndex = 17
        ' 
        ' lblEstadoCivEnf
        ' 
        lblEstadoCivEnf.AutoSize = True
        lblEstadoCivEnf.Location = New Point(6, 388)
        lblEstadoCivEnf.Name = "lblEstadoCivEnf"
        lblEstadoCivEnf.Size = New Size(89, 20)
        lblEstadoCivEnf.TabIndex = 16
        lblEstadoCivEnf.Text = "Estado Civil:"
        ' 
        ' mskTelEnf
        ' 
        mskTelEnf.Location = New Point(79, 346)
        mskTelEnf.Name = "mskTelEnf"
        mskTelEnf.Size = New Size(174, 27)
        mskTelEnf.TabIndex = 15
        ' 
        ' lblTelefonoEnf
        ' 
        lblTelefonoEnf.AutoSize = True
        lblTelefonoEnf.Location = New Point(6, 353)
        lblTelefonoEnf.Name = "lblTelefonoEnf"
        lblTelefonoEnf.Size = New Size(70, 20)
        lblTelefonoEnf.TabIndex = 14
        lblTelefonoEnf.Text = "Teléfono:"
        ' 
        ' txtCorreoEnf
        ' 
        txtCorreoEnf.Location = New Point(69, 309)
        txtCorreoEnf.Name = "txtCorreoEnf"
        txtCorreoEnf.Size = New Size(155, 27)
        txtCorreoEnf.TabIndex = 13
        ' 
        ' lblCorreoEnf
        ' 
        lblCorreoEnf.AutoSize = True
        lblCorreoEnf.Location = New Point(6, 316)
        lblCorreoEnf.Name = "lblCorreoEnf"
        lblCorreoEnf.Size = New Size(57, 20)
        lblCorreoEnf.TabIndex = 12
        lblCorreoEnf.Text = "Correo:"
        ' 
        ' txtDirecEnf
        ' 
        txtDirecEnf.Location = New Point(87, 277)
        txtDirecEnf.Name = "txtDirecEnf"
        txtDirecEnf.Size = New Size(201, 27)
        txtDirecEnf.TabIndex = 11
        ' 
        ' lblDirecEnf
        ' 
        lblDirecEnf.AutoSize = True
        lblDirecEnf.Location = New Point(6, 284)
        lblDirecEnf.Name = "lblDirecEnf"
        lblDirecEnf.Size = New Size(75, 20)
        lblDirecEnf.TabIndex = 10
        lblDirecEnf.Text = "Dirección:"
        ' 
        ' grpGeneroEnf
        ' 
        grpGeneroEnf.Controls.Add(rdbFemeninoEnf)
        grpGeneroEnf.Controls.Add(rdbMasculinoEnf)
        grpGeneroEnf.Location = New Point(79, 215)
        grpGeneroEnf.Name = "grpGeneroEnf"
        grpGeneroEnf.Size = New Size(222, 49)
        grpGeneroEnf.TabIndex = 9
        grpGeneroEnf.TabStop = False
        grpGeneroEnf.Text = "Género"
        ' 
        ' rdbFemeninoEnf
        ' 
        rdbFemeninoEnf.AutoSize = True
        rdbFemeninoEnf.Location = New Point(8, 19)
        rdbFemeninoEnf.Name = "rdbFemeninoEnf"
        rdbFemeninoEnf.Size = New Size(95, 24)
        rdbFemeninoEnf.TabIndex = 10
        rdbFemeninoEnf.TabStop = True
        rdbFemeninoEnf.Text = "Femenino"
        rdbFemeninoEnf.UseVisualStyleBackColor = True
        ' 
        ' rdbMasculinoEnf
        ' 
        rdbMasculinoEnf.AutoSize = True
        rdbMasculinoEnf.Location = New Point(119, 19)
        rdbMasculinoEnf.Name = "rdbMasculinoEnf"
        rdbMasculinoEnf.Size = New Size(97, 24)
        rdbMasculinoEnf.TabIndex = 10
        rdbMasculinoEnf.TabStop = True
        rdbMasculinoEnf.Text = "Masculino"
        rdbMasculinoEnf.UseVisualStyleBackColor = True
        ' 
        ' txtEdadEnf
        ' 
        txtEdadEnf.Location = New Point(58, 173)
        txtEdadEnf.Name = "txtEdadEnf"
        txtEdadEnf.Size = New Size(156, 27)
        txtEdadEnf.TabIndex = 2
        ' 
        ' lblEdadEnf
        ' 
        lblEdadEnf.AutoSize = True
        lblEdadEnf.Location = New Point(6, 180)
        lblEdadEnf.Name = "lblEdadEnf"
        lblEdadEnf.Size = New Size(46, 20)
        lblEdadEnf.TabIndex = 8
        lblEdadEnf.Text = "Edad:"
        ' 
        ' dtpFechaNacEnf
        ' 
        dtpFechaNacEnf.Location = New Point(164, 138)
        dtpFechaNacEnf.Name = "dtpFechaNacEnf"
        dtpFechaNacEnf.Size = New Size(250, 27)
        dtpFechaNacEnf.TabIndex = 7
        ' 
        ' lblFechaNacEnf
        ' 
        lblFechaNacEnf.AutoSize = True
        lblFechaNacEnf.Location = New Point(6, 145)
        lblFechaNacEnf.Name = "lblFechaNacEnf"
        lblFechaNacEnf.Size = New Size(152, 20)
        lblFechaNacEnf.TabIndex = 6
        lblFechaNacEnf.Text = "Fecha de Nacimiento:"
        ' 
        ' txtApeEnf
        ' 
        txtApeEnf.Location = New Point(79, 100)
        txtApeEnf.Name = "txtApeEnf"
        txtApeEnf.Size = New Size(210, 27)
        txtApeEnf.TabIndex = 5
        ' 
        ' lblApeEnf
        ' 
        lblApeEnf.AutoSize = True
        lblApeEnf.Location = New Point(6, 107)
        lblApeEnf.Name = "lblApeEnf"
        lblApeEnf.Size = New Size(69, 20)
        lblApeEnf.TabIndex = 4
        lblApeEnf.Text = "Apellido:"
        ' 
        ' TxNombEnf
        ' 
        TxNombEnf.Location = New Point(79, 64)
        TxNombEnf.Name = "TxNombEnf"
        TxNombEnf.Size = New Size(201, 27)
        TxNombEnf.TabIndex = 2
        ' 
        ' lblNombEnf
        ' 
        lblNombEnf.AutoSize = True
        lblNombEnf.Location = New Point(6, 71)
        lblNombEnf.Name = "lblNombEnf"
        lblNombEnf.Size = New Size(67, 20)
        lblNombEnf.TabIndex = 3
        lblNombEnf.Text = "Nombre:"
        ' 
        ' mskIdentEnf
        ' 
        mskIdentEnf.Location = New Point(164, 29)
        mskIdentEnf.Name = "mskIdentEnf"
        mskIdentEnf.Size = New Size(226, 27)
        mskIdentEnf.TabIndex = 2
        ' 
        ' lblIdentEnf
        ' 
        lblIdentEnf.AutoSize = True
        lblIdentEnf.Location = New Point(6, 36)
        lblIdentEnf.Name = "lblIdentEnf"
        lblIdentEnf.Size = New Size(155, 20)
        lblIdentEnf.TabIndex = 2
        lblIdentEnf.Text = "Número de Identidad:"
        ' 
        ' lblNombFormEnf
        ' 
        lblNombFormEnf.AutoSize = True
        lblNombFormEnf.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormEnf.Location = New Point(439, 9)
        lblNombFormEnf.Name = "lblNombFormEnf"
        lblNombFormEnf.Size = New Size(319, 41)
        lblNombFormEnf.TabIndex = 6
        lblNombFormEnf.Text = "Formulario Enfermeros"
        ' 
        ' FormularioEnfermeros
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1165, 636)
        Controls.Add(btnElimEnf)
        Controls.Add(btnModificarEnf)
        Controls.Add(btnAgregarEnf)
        Controls.Add(grpDatosProfEnf)
        Controls.Add(grpDatosEnf)
        Controls.Add(lblNombFormEnf)
        Name = "FormularioEnfermeros"
        Text = "Enfermeros"
        grpDatosProfEnf.ResumeLayout(False)
        grpDatosProfEnf.PerformLayout()
        grpEstadoEnf.ResumeLayout(False)
        grpEstadoEnf.PerformLayout()
        grpDatosEnf.ResumeLayout(False)
        grpDatosEnf.PerformLayout()
        grpGeneroEnf.ResumeLayout(False)
        grpGeneroEnf.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnElimEnf As Button
    Friend WithEvents btnModificarEnf As Button
    Friend WithEvents btnAgregarEnf As Button
    Friend WithEvents grpDatosProfEnf As GroupBox
    Friend WithEvents grpEstadoEnf As GroupBox
    Friend WithEvents rdbInactivoEnf As RadioButton
    Friend WithEvents rdbActivoEnf As RadioButton
    Friend WithEvents txtSueldoEnf As TextBox
    Friend WithEvents lblSueldoEnf As Label
    Friend WithEvents txtTituloEnf As TextBox
    Friend WithEvents lblTituloEnf As Label
    Friend WithEvents txtEspEnf As TextBox
    Friend WithEvents lblEspEnf As Label
    Friend WithEvents grpDatosEnf As GroupBox
    Friend WithEvents btnBuscEnf As Button
    Friend WithEvents cbxEstadoCivEnf As ComboBox
    Friend WithEvents lblEstadoCivEnf As Label
    Friend WithEvents mskTelEnf As MaskedTextBox
    Friend WithEvents lblTelefonoEnf As Label
    Friend WithEvents txtCorreoEnf As TextBox
    Friend WithEvents lblCorreoEnf As Label
    Friend WithEvents txtDirecEnf As TextBox
    Friend WithEvents lblDirecEnf As Label
    Friend WithEvents grpGeneroEnf As GroupBox
    Friend WithEvents rdbFemeninoEnf As RadioButton
    Friend WithEvents rdbMasculinoEnf As RadioButton
    Friend WithEvents txtEdadEnf As TextBox
    Friend WithEvents lblEdadEnf As Label
    Friend WithEvents dtpFechaNacEnf As DateTimePicker
    Friend WithEvents lblFechaNacEnf As Label
    Friend WithEvents txtApeEnf As TextBox
    Friend WithEvents lblApeEnf As Label
    Friend WithEvents TxNombEnf As TextBox
    Friend WithEvents lblNombEnf As Label
    Friend WithEvents mskIdentEnf As MaskedTextBox
    Friend WithEvents lblIdentEnf As Label
    Friend WithEvents lblNombFormEnf As Label
End Class

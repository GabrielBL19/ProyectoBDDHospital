<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioEmpleados))
        btnElimEmp = New Button()
        btnModificarEmp = New Button()
        btnAgregarEmp = New Button()
        grpDatosProfEmp = New GroupBox()
        cbxCargoEmp = New ComboBox()
        lblCargoEmp = New Label()
        grpEstadoEmp = New GroupBox()
        rdbInactivoEmp = New RadioButton()
        rdbActivoEmp = New RadioButton()
        txtSueldoEmp = New TextBox()
        lblSueldoEmp = New Label()
        grpDatosEnf = New GroupBox()
        btnBuscEmp = New Button()
        cbxEstadoCivEmp = New ComboBox()
        lblEstadoCivEmp = New Label()
        mskTelEmp = New MaskedTextBox()
        lblTelefonoEmp = New Label()
        txtCorreoEmp = New TextBox()
        lblCorreoEmp = New Label()
        txtDirecEmp = New TextBox()
        lblDirecEmp = New Label()
        grpGeneroEmp = New GroupBox()
        rdbFemeninoEmp = New RadioButton()
        rdbMasculinoEmp = New RadioButton()
        txtEdadEmp = New TextBox()
        lblEdadEmp = New Label()
        dtpFechaNacEmp = New DateTimePicker()
        lblFechaNacEmp = New Label()
        txtApeEmp = New TextBox()
        lblApeEmp = New Label()
        TxNombEmp = New TextBox()
        lblNombEmp = New Label()
        mskIdentEmp = New MaskedTextBox()
        lblIdentEmp = New Label()
        lblNombFormEmp = New Label()
        grpDatosProfEmp.SuspendLayout()
        grpEstadoEmp.SuspendLayout()
        grpDatosEnf.SuspendLayout()
        grpGeneroEmp.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnElimEmp
        ' 
        btnElimEmp.Image = CType(resources.GetObject("btnElimEmp.Image"), Image)
        btnElimEmp.ImageAlign = ContentAlignment.MiddleRight
        btnElimEmp.Location = New Point(875, 357)
        btnElimEmp.Name = "btnElimEmp"
        btnElimEmp.Size = New Size(95, 41)
        btnElimEmp.TabIndex = 17
        btnElimEmp.Text = "Eliminar"
        btnElimEmp.TextAlign = ContentAlignment.MiddleLeft
        btnElimEmp.UseVisualStyleBackColor = True
        ' 
        ' btnModificarEmp
        ' 
        btnModificarEmp.Image = CType(resources.GetObject("btnModificarEmp.Image"), Image)
        btnModificarEmp.ImageAlign = ContentAlignment.MiddleRight
        btnModificarEmp.Location = New Point(752, 357)
        btnModificarEmp.Name = "btnModificarEmp"
        btnModificarEmp.Size = New Size(105, 41)
        btnModificarEmp.TabIndex = 16
        btnModificarEmp.Text = "Actualizar"
        btnModificarEmp.TextAlign = ContentAlignment.MiddleLeft
        btnModificarEmp.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarEmp
        ' 
        btnAgregarEmp.Image = CType(resources.GetObject("btnAgregarEmp.Image"), Image)
        btnAgregarEmp.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarEmp.Location = New Point(642, 357)
        btnAgregarEmp.Name = "btnAgregarEmp"
        btnAgregarEmp.Size = New Size(94, 41)
        btnAgregarEmp.TabIndex = 15
        btnAgregarEmp.Text = "Agregar"
        btnAgregarEmp.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarEmp.UseVisualStyleBackColor = True
        ' 
        ' grpDatosProfEmp
        ' 
        grpDatosProfEmp.Controls.Add(cbxCargoEmp)
        grpDatosProfEmp.Controls.Add(lblCargoEmp)
        grpDatosProfEmp.Controls.Add(grpEstadoEmp)
        grpDatosProfEmp.Controls.Add(txtSueldoEmp)
        grpDatosProfEmp.Controls.Add(lblSueldoEmp)
        grpDatosProfEmp.Location = New Point(653, 80)
        grpDatosProfEmp.Name = "grpDatosProfEmp"
        grpDatosProfEmp.Size = New Size(380, 165)
        grpDatosProfEmp.TabIndex = 14
        grpDatosProfEmp.TabStop = False
        grpDatosProfEmp.Text = "Datos Profesionales"
        ' 
        ' cbxCargoEmp
        ' 
        cbxCargoEmp.FormattingEnabled = True
        cbxCargoEmp.Items.AddRange(New Object() {"Director del Hospital", "Subdirector Médico", "Gerente de RRHH", "Secretario (a)", "Recepcionista"})
        cbxCargoEmp.Location = New Point(64, 26)
        cbxCargoEmp.Name = "cbxCargoEmp"
        cbxCargoEmp.Size = New Size(151, 28)
        cbxCargoEmp.TabIndex = 8
        ' 
        ' lblCargoEmp
        ' 
        lblCargoEmp.AutoSize = True
        lblCargoEmp.Location = New Point(6, 32)
        lblCargoEmp.Name = "lblCargoEmp"
        lblCargoEmp.Size = New Size(52, 20)
        lblCargoEmp.TabIndex = 7
        lblCargoEmp.Text = "Cargo:"
        ' 
        ' grpEstadoEmp
        ' 
        grpEstadoEmp.Controls.Add(rdbInactivoEmp)
        grpEstadoEmp.Controls.Add(rdbActivoEmp)
        grpEstadoEmp.Location = New Point(99, 100)
        grpEstadoEmp.Name = "grpEstadoEmp"
        grpEstadoEmp.Size = New Size(172, 50)
        grpEstadoEmp.TabIndex = 6
        grpEstadoEmp.TabStop = False
        grpEstadoEmp.Text = "Estado"
        ' 
        ' rdbInactivoEmp
        ' 
        rdbInactivoEmp.AutoSize = True
        rdbInactivoEmp.Location = New Point(84, 20)
        rdbInactivoEmp.Name = "rdbInactivoEmp"
        rdbInactivoEmp.Size = New Size(82, 24)
        rdbInactivoEmp.TabIndex = 1
        rdbInactivoEmp.TabStop = True
        rdbInactivoEmp.Text = "Inactivo"
        rdbInactivoEmp.UseVisualStyleBackColor = True
        ' 
        ' rdbActivoEmp
        ' 
        rdbActivoEmp.AutoSize = True
        rdbActivoEmp.Location = New Point(6, 20)
        rdbActivoEmp.Name = "rdbActivoEmp"
        rdbActivoEmp.Size = New Size(72, 24)
        rdbActivoEmp.TabIndex = 0
        rdbActivoEmp.TabStop = True
        rdbActivoEmp.Text = "Activo"
        rdbActivoEmp.UseVisualStyleBackColor = True
        ' 
        ' txtSueldoEmp
        ' 
        txtSueldoEmp.Location = New Point(64, 64)
        txtSueldoEmp.Name = "txtSueldoEmp"
        txtSueldoEmp.Size = New Size(125, 27)
        txtSueldoEmp.TabIndex = 5
        ' 
        ' lblSueldoEmp
        ' 
        lblSueldoEmp.AutoSize = True
        lblSueldoEmp.Location = New Point(6, 71)
        lblSueldoEmp.Name = "lblSueldoEmp"
        lblSueldoEmp.Size = New Size(58, 20)
        lblSueldoEmp.TabIndex = 4
        lblSueldoEmp.Text = "Sueldo:"
        ' 
        ' grpDatosEnf
        ' 
        grpDatosEnf.Controls.Add(btnBuscEmp)
        grpDatosEnf.Controls.Add(cbxEstadoCivEmp)
        grpDatosEnf.Controls.Add(lblEstadoCivEmp)
        grpDatosEnf.Controls.Add(mskTelEmp)
        grpDatosEnf.Controls.Add(lblTelefonoEmp)
        grpDatosEnf.Controls.Add(txtCorreoEmp)
        grpDatosEnf.Controls.Add(lblCorreoEmp)
        grpDatosEnf.Controls.Add(txtDirecEmp)
        grpDatosEnf.Controls.Add(lblDirecEmp)
        grpDatosEnf.Controls.Add(grpGeneroEmp)
        grpDatosEnf.Controls.Add(txtEdadEmp)
        grpDatosEnf.Controls.Add(lblEdadEmp)
        grpDatosEnf.Controls.Add(dtpFechaNacEmp)
        grpDatosEnf.Controls.Add(lblFechaNacEmp)
        grpDatosEnf.Controls.Add(txtApeEmp)
        grpDatosEnf.Controls.Add(lblApeEmp)
        grpDatosEnf.Controls.Add(TxNombEmp)
        grpDatosEnf.Controls.Add(lblNombEmp)
        grpDatosEnf.Controls.Add(mskIdentEmp)
        grpDatosEnf.Controls.Add(lblIdentEmp)
        grpDatosEnf.Location = New Point(23, 80)
        grpDatosEnf.Name = "grpDatosEnf"
        grpDatosEnf.Size = New Size(489, 427)
        grpDatosEnf.TabIndex = 13
        grpDatosEnf.TabStop = False
        grpDatosEnf.Text = "Datos Personales"
        ' 
        ' btnBuscEmp
        ' 
        btnBuscEmp.Location = New Point(396, 26)
        btnBuscEmp.Name = "btnBuscEmp"
        btnBuscEmp.Size = New Size(87, 30)
        btnBuscEmp.TabIndex = 18
        btnBuscEmp.Text = "Buscar"
        btnBuscEmp.UseVisualStyleBackColor = True
        ' 
        ' cbxEstadoCivEmp
        ' 
        cbxEstadoCivEmp.FormattingEnabled = True
        cbxEstadoCivEmp.Items.AddRange(New Object() {"Casado", "Soltero", "Viudo"})
        cbxEstadoCivEmp.Location = New Point(101, 380)
        cbxEstadoCivEmp.Name = "cbxEstadoCivEmp"
        cbxEstadoCivEmp.Size = New Size(151, 28)
        cbxEstadoCivEmp.TabIndex = 17
        ' 
        ' lblEstadoCivEmp
        ' 
        lblEstadoCivEmp.AutoSize = True
        lblEstadoCivEmp.Location = New Point(6, 388)
        lblEstadoCivEmp.Name = "lblEstadoCivEmp"
        lblEstadoCivEmp.Size = New Size(89, 20)
        lblEstadoCivEmp.TabIndex = 16
        lblEstadoCivEmp.Text = "Estado Civil:"
        ' 
        ' mskTelEmp
        ' 
        mskTelEmp.Location = New Point(79, 346)
        mskTelEmp.Name = "mskTelEmp"
        mskTelEmp.Size = New Size(174, 27)
        mskTelEmp.TabIndex = 15
        ' 
        ' lblTelefonoEmp
        ' 
        lblTelefonoEmp.AutoSize = True
        lblTelefonoEmp.Location = New Point(6, 353)
        lblTelefonoEmp.Name = "lblTelefonoEmp"
        lblTelefonoEmp.Size = New Size(70, 20)
        lblTelefonoEmp.TabIndex = 14
        lblTelefonoEmp.Text = "Teléfono:"
        ' 
        ' txtCorreoEmp
        ' 
        txtCorreoEmp.Location = New Point(69, 309)
        txtCorreoEmp.Name = "txtCorreoEmp"
        txtCorreoEmp.Size = New Size(155, 27)
        txtCorreoEmp.TabIndex = 13
        ' 
        ' lblCorreoEmp
        ' 
        lblCorreoEmp.AutoSize = True
        lblCorreoEmp.Location = New Point(6, 316)
        lblCorreoEmp.Name = "lblCorreoEmp"
        lblCorreoEmp.Size = New Size(57, 20)
        lblCorreoEmp.TabIndex = 12
        lblCorreoEmp.Text = "Correo:"
        ' 
        ' txtDirecEmp
        ' 
        txtDirecEmp.Location = New Point(87, 277)
        txtDirecEmp.Name = "txtDirecEmp"
        txtDirecEmp.Size = New Size(201, 27)
        txtDirecEmp.TabIndex = 11
        ' 
        ' lblDirecEmp
        ' 
        lblDirecEmp.AutoSize = True
        lblDirecEmp.Location = New Point(6, 284)
        lblDirecEmp.Name = "lblDirecEmp"
        lblDirecEmp.Size = New Size(75, 20)
        lblDirecEmp.TabIndex = 10
        lblDirecEmp.Text = "Dirección:"
        ' 
        ' grpGeneroEmp
        ' 
        grpGeneroEmp.Controls.Add(rdbFemeninoEmp)
        grpGeneroEmp.Controls.Add(rdbMasculinoEmp)
        grpGeneroEmp.Location = New Point(79, 215)
        grpGeneroEmp.Name = "grpGeneroEmp"
        grpGeneroEmp.Size = New Size(222, 49)
        grpGeneroEmp.TabIndex = 9
        grpGeneroEmp.TabStop = False
        grpGeneroEmp.Text = "Género"
        ' 
        ' rdbFemeninoEmp
        ' 
        rdbFemeninoEmp.AutoSize = True
        rdbFemeninoEmp.Location = New Point(8, 19)
        rdbFemeninoEmp.Name = "rdbFemeninoEmp"
        rdbFemeninoEmp.Size = New Size(95, 24)
        rdbFemeninoEmp.TabIndex = 10
        rdbFemeninoEmp.TabStop = True
        rdbFemeninoEmp.Text = "Femenino"
        rdbFemeninoEmp.UseVisualStyleBackColor = True
        ' 
        ' rdbMasculinoEmp
        ' 
        rdbMasculinoEmp.AutoSize = True
        rdbMasculinoEmp.Location = New Point(119, 19)
        rdbMasculinoEmp.Name = "rdbMasculinoEmp"
        rdbMasculinoEmp.Size = New Size(97, 24)
        rdbMasculinoEmp.TabIndex = 10
        rdbMasculinoEmp.TabStop = True
        rdbMasculinoEmp.Text = "Masculino"
        rdbMasculinoEmp.UseVisualStyleBackColor = True
        ' 
        ' txtEdadEmp
        ' 
        txtEdadEmp.Location = New Point(58, 173)
        txtEdadEmp.Name = "txtEdadEmp"
        txtEdadEmp.Size = New Size(156, 27)
        txtEdadEmp.TabIndex = 2
        ' 
        ' lblEdadEmp
        ' 
        lblEdadEmp.AutoSize = True
        lblEdadEmp.Location = New Point(6, 180)
        lblEdadEmp.Name = "lblEdadEmp"
        lblEdadEmp.Size = New Size(46, 20)
        lblEdadEmp.TabIndex = 8
        lblEdadEmp.Text = "Edad:"
        ' 
        ' dtpFechaNacEmp
        ' 
        dtpFechaNacEmp.Location = New Point(164, 138)
        dtpFechaNacEmp.Name = "dtpFechaNacEmp"
        dtpFechaNacEmp.Size = New Size(250, 27)
        dtpFechaNacEmp.TabIndex = 7
        ' 
        ' lblFechaNacEmp
        ' 
        lblFechaNacEmp.AutoSize = True
        lblFechaNacEmp.Location = New Point(6, 145)
        lblFechaNacEmp.Name = "lblFechaNacEmp"
        lblFechaNacEmp.Size = New Size(152, 20)
        lblFechaNacEmp.TabIndex = 6
        lblFechaNacEmp.Text = "Fecha de Nacimiento:"
        ' 
        ' txtApeEmp
        ' 
        txtApeEmp.Location = New Point(79, 100)
        txtApeEmp.Name = "txtApeEmp"
        txtApeEmp.Size = New Size(210, 27)
        txtApeEmp.TabIndex = 5
        ' 
        ' lblApeEmp
        ' 
        lblApeEmp.AutoSize = True
        lblApeEmp.Location = New Point(6, 107)
        lblApeEmp.Name = "lblApeEmp"
        lblApeEmp.Size = New Size(69, 20)
        lblApeEmp.TabIndex = 4
        lblApeEmp.Text = "Apellido:"
        ' 
        ' TxNombEmp
        ' 
        TxNombEmp.Location = New Point(79, 64)
        TxNombEmp.Name = "TxNombEmp"
        TxNombEmp.Size = New Size(201, 27)
        TxNombEmp.TabIndex = 2
        ' 
        ' lblNombEmp
        ' 
        lblNombEmp.AutoSize = True
        lblNombEmp.Location = New Point(6, 71)
        lblNombEmp.Name = "lblNombEmp"
        lblNombEmp.Size = New Size(67, 20)
        lblNombEmp.TabIndex = 3
        lblNombEmp.Text = "Nombre:"
        ' 
        ' mskIdentEmp
        ' 
        mskIdentEmp.Location = New Point(164, 29)
        mskIdentEmp.Name = "mskIdentEmp"
        mskIdentEmp.Size = New Size(226, 27)
        mskIdentEmp.TabIndex = 2
        ' 
        ' lblIdentEmp
        ' 
        lblIdentEmp.AutoSize = True
        lblIdentEmp.Location = New Point(6, 36)
        lblIdentEmp.Name = "lblIdentEmp"
        lblIdentEmp.Size = New Size(155, 20)
        lblIdentEmp.TabIndex = 2
        lblIdentEmp.Text = "Número de Identidad:"
        ' 
        ' lblNombFormEmp
        ' 
        lblNombFormEmp.AutoSize = True
        lblNombFormEmp.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormEmp.Location = New Point(411, 9)
        lblNombFormEmp.Name = "lblNombFormEmp"
        lblNombFormEmp.Size = New Size(315, 41)
        lblNombFormEmp.TabIndex = 12
        lblNombFormEmp.Text = "Formulario Empleados"
        ' 
        ' FormularioEmpleados
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1071, 599)
        Controls.Add(btnElimEmp)
        Controls.Add(btnModificarEmp)
        Controls.Add(btnAgregarEmp)
        Controls.Add(grpDatosProfEmp)
        Controls.Add(grpDatosEnf)
        Controls.Add(lblNombFormEmp)
        Name = "FormularioEmpleados"
        Text = "Empleados"
        grpDatosProfEmp.ResumeLayout(False)
        grpDatosProfEmp.PerformLayout()
        grpEstadoEmp.ResumeLayout(False)
        grpEstadoEmp.PerformLayout()
        grpDatosEnf.ResumeLayout(False)
        grpDatosEnf.PerformLayout()
        grpGeneroEmp.ResumeLayout(False)
        grpGeneroEmp.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnElimEmp As Button
    Friend WithEvents btnModificarEmp As Button
    Friend WithEvents btnAgregarEmp As Button
    Friend WithEvents grpDatosProfEmp As GroupBox
    Friend WithEvents grpEstadoEmp As GroupBox
    Friend WithEvents rdbInactivoEmp As RadioButton
    Friend WithEvents rdbActivoEmp As RadioButton
    Friend WithEvents txtSueldoEmp As TextBox
    Friend WithEvents lblSueldoEmp As Label
    Friend WithEvents grpDatosEnf As GroupBox
    Friend WithEvents btnBuscEmp As Button
    Friend WithEvents cbxEstadoCivEmp As ComboBox
    Friend WithEvents lblEstadoCivEmp As Label
    Friend WithEvents mskTelEmp As MaskedTextBox
    Friend WithEvents lblTelefonoEmp As Label
    Friend WithEvents txtCorreoEmp As TextBox
    Friend WithEvents lblCorreoEmp As Label
    Friend WithEvents txtDirecEmp As TextBox
    Friend WithEvents lblDirecEmp As Label
    Friend WithEvents grpGeneroEmp As GroupBox
    Friend WithEvents rdbFemeninoEmp As RadioButton
    Friend WithEvents rdbMasculinoEmp As RadioButton
    Friend WithEvents txtEdadEmp As TextBox
    Friend WithEvents lblEdadEmp As Label
    Friend WithEvents dtpFechaNacEmp As DateTimePicker
    Friend WithEvents lblFechaNacEmp As Label
    Friend WithEvents txtApeEmp As TextBox
    Friend WithEvents lblApeEmp As Label
    Friend WithEvents TxNombEmp As TextBox
    Friend WithEvents lblNombEmp As Label
    Friend WithEvents mskIdentEmp As MaskedTextBox
    Friend WithEvents lblIdentEmp As Label
    Friend WithEvents lblNombFormEmp As Label
    Friend WithEvents cbxCargoEmp As ComboBox
    Friend WithEvents lblCargoEmp As Label
End Class

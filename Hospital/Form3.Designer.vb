<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPacientes))
        grpDatosRespPac = New GroupBox()
        txtTelRespPac = New TextBox()
        lblTelRespPac = New Label()
        txtNombRespPac = New TextBox()
        lblNombRespPac = New Label()
        grpDatosPac = New GroupBox()
        txtNumSeguroPac = New TextBox()
        txtTelefonoPaciente = New TextBox()
        txtIdentidadPaciente = New TextBox()
        lblNumSegPac = New Label()
        lblTelPac = New Label()
        txtCorreoPac = New TextBox()
        lblCorreoPac = New Label()
        txtDirecPac = New TextBox()
        lblDirecPac = New Label()
        grpGeneroPac = New GroupBox()
        rdbMasculinoPac = New RadioButton()
        rdbFemeninoPac = New RadioButton()
        txtEdadPac = New TextBox()
        lblEdadPac = New Label()
        dtpFechaNacPac = New DateTimePicker()
        lblFechaNacPac = New Label()
        txtApePac = New TextBox()
        lblApePac = New Label()
        txtNombPac = New TextBox()
        lblNombPac = New Label()
        lblIdPac = New Label()
        btnBuscarPaciente = New Button()
        lblFormPac = New Label()
        btnAgregarPac = New Button()
        btnModificarPac = New Button()
        btnEliminarPac = New Button()
        dtgPacientes = New DataGridView()
        grpBuscarPaciente = New GroupBox()
        txtBuscarPaciente = New TextBox()
        lblInstruccionesFormularioP = New Label()
        grpDatosRespPac.SuspendLayout()
        grpDatosPac.SuspendLayout()
        grpGeneroPac.SuspendLayout()
        CType(dtgPacientes, ComponentModel.ISupportInitialize).BeginInit()
        grpBuscarPaciente.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpDatosRespPac
        ' 
        grpDatosRespPac.Controls.Add(txtTelRespPac)
        grpDatosRespPac.Controls.Add(lblTelRespPac)
        grpDatosRespPac.Controls.Add(txtNombRespPac)
        grpDatosRespPac.Controls.Add(lblNombRespPac)
        grpDatosRespPac.Location = New Point(68, 532)
        grpDatosRespPac.Name = "grpDatosRespPac"
        grpDatosRespPac.Size = New Size(447, 120)
        grpDatosRespPac.TabIndex = 5
        grpDatosRespPac.TabStop = False
        grpDatosRespPac.Text = "Datos del Responsable"
        ' 
        ' txtTelRespPac
        ' 
        txtTelRespPac.Location = New Point(192, 58)
        txtTelRespPac.MaxLength = 8
        txtTelRespPac.Name = "txtTelRespPac"
        txtTelRespPac.Size = New Size(219, 27)
        txtTelRespPac.TabIndex = 3
        ' 
        ' lblTelRespPac
        ' 
        lblTelRespPac.AutoSize = True
        lblTelRespPac.Location = New Point(6, 65)
        lblTelRespPac.Name = "lblTelRespPac"
        lblTelRespPac.Size = New Size(183, 20)
        lblTelRespPac.TabIndex = 2
        lblTelRespPac.Text = "Teléfono del Responsable:"
        ' 
        ' txtNombRespPac
        ' 
        txtNombRespPac.Location = New Point(192, 25)
        txtNombRespPac.MaxLength = 30
        txtNombRespPac.Name = "txtNombRespPac"
        txtNombRespPac.Size = New Size(219, 27)
        txtNombRespPac.TabIndex = 1
        ' 
        ' lblNombRespPac
        ' 
        lblNombRespPac.AutoSize = True
        lblNombRespPac.Location = New Point(6, 32)
        lblNombRespPac.Name = "lblNombRespPac"
        lblNombRespPac.Size = New Size(180, 20)
        lblNombRespPac.TabIndex = 0
        lblNombRespPac.Text = "Nombre del Responsable:"
        ' 
        ' grpDatosPac
        ' 
        grpDatosPac.Controls.Add(txtNumSeguroPac)
        grpDatosPac.Controls.Add(txtTelefonoPaciente)
        grpDatosPac.Controls.Add(txtIdentidadPaciente)
        grpDatosPac.Controls.Add(lblNumSegPac)
        grpDatosPac.Controls.Add(lblTelPac)
        grpDatosPac.Controls.Add(txtCorreoPac)
        grpDatosPac.Controls.Add(lblCorreoPac)
        grpDatosPac.Controls.Add(txtDirecPac)
        grpDatosPac.Controls.Add(lblDirecPac)
        grpDatosPac.Controls.Add(grpGeneroPac)
        grpDatosPac.Controls.Add(txtEdadPac)
        grpDatosPac.Controls.Add(lblEdadPac)
        grpDatosPac.Controls.Add(dtpFechaNacPac)
        grpDatosPac.Controls.Add(lblFechaNacPac)
        grpDatosPac.Controls.Add(txtApePac)
        grpDatosPac.Controls.Add(lblApePac)
        grpDatosPac.Controls.Add(txtNombPac)
        grpDatosPac.Controls.Add(lblNombPac)
        grpDatosPac.Controls.Add(lblIdPac)
        grpDatosPac.Location = New Point(68, 100)
        grpDatosPac.Name = "grpDatosPac"
        grpDatosPac.Size = New Size(447, 426)
        grpDatosPac.TabIndex = 4
        grpDatosPac.TabStop = False
        grpDatosPac.Text = "Datos Personales"
        ' 
        ' txtNumSeguroPac
        ' 
        txtNumSeguroPac.Location = New Point(150, 371)
        txtNumSeguroPac.MaxLength = 40
        txtNumSeguroPac.Name = "txtNumSeguroPac"
        txtNumSeguroPac.Size = New Size(188, 27)
        txtNumSeguroPac.TabIndex = 15
        ' 
        ' txtTelefonoPaciente
        ' 
        txtTelefonoPaciente.Location = New Point(79, 338)
        txtTelefonoPaciente.MaxLength = 75
        txtTelefonoPaciente.Name = "txtTelefonoPaciente"
        txtTelefonoPaciente.Size = New Size(159, 27)
        txtTelefonoPaciente.TabIndex = 14
        ' 
        ' txtIdentidadPaciente
        ' 
        txtIdentidadPaciente.Location = New Point(161, 26)
        txtIdentidadPaciente.MaxLength = 13
        txtIdentidadPaciente.Name = "txtIdentidadPaciente"
        txtIdentidadPaciente.Size = New Size(195, 27)
        txtIdentidadPaciente.TabIndex = 13
        ' 
        ' lblNumSegPac
        ' 
        lblNumSegPac.AutoSize = True
        lblNumSegPac.Location = New Point(6, 378)
        lblNumSegPac.Name = "lblNumSegPac"
        lblNumSegPac.Size = New Size(138, 20)
        lblNumSegPac.TabIndex = 6
        lblNumSegPac.Text = "Número de Seguro:"
        ' 
        ' lblTelPac
        ' 
        lblTelPac.AutoSize = True
        lblTelPac.Location = New Point(6, 345)
        lblTelPac.Name = "lblTelPac"
        lblTelPac.Size = New Size(70, 20)
        lblTelPac.TabIndex = 2
        lblTelPac.Text = "Teléfono:"
        ' 
        ' txtCorreoPac
        ' 
        txtCorreoPac.Location = New Point(69, 306)
        txtCorreoPac.MaxLength = 75
        txtCorreoPac.Name = "txtCorreoPac"
        txtCorreoPac.Size = New Size(189, 27)
        txtCorreoPac.TabIndex = 10
        ' 
        ' lblCorreoPac
        ' 
        lblCorreoPac.AutoSize = True
        lblCorreoPac.Location = New Point(6, 313)
        lblCorreoPac.Name = "lblCorreoPac"
        lblCorreoPac.Size = New Size(57, 20)
        lblCorreoPac.TabIndex = 9
        lblCorreoPac.Text = "Correo:"
        ' 
        ' txtDirecPac
        ' 
        txtDirecPac.Location = New Point(86, 273)
        txtDirecPac.MaxLength = 50
        txtDirecPac.Name = "txtDirecPac"
        txtDirecPac.Size = New Size(195, 27)
        txtDirecPac.TabIndex = 8
        ' 
        ' lblDirecPac
        ' 
        lblDirecPac.AutoSize = True
        lblDirecPac.Location = New Point(6, 280)
        lblDirecPac.Name = "lblDirecPac"
        lblDirecPac.Size = New Size(75, 20)
        lblDirecPac.TabIndex = 7
        lblDirecPac.Text = "Dirección:"
        ' 
        ' grpGeneroPac
        ' 
        grpGeneroPac.Controls.Add(rdbMasculinoPac)
        grpGeneroPac.Controls.Add(rdbFemeninoPac)
        grpGeneroPac.Location = New Point(110, 202)
        grpGeneroPac.Name = "grpGeneroPac"
        grpGeneroPac.Size = New Size(217, 61)
        grpGeneroPac.TabIndex = 6
        grpGeneroPac.TabStop = False
        grpGeneroPac.Text = "Género"
        ' 
        ' rdbMasculinoPac
        ' 
        rdbMasculinoPac.AutoSize = True
        rdbMasculinoPac.Location = New Point(114, 26)
        rdbMasculinoPac.Name = "rdbMasculinoPac"
        rdbMasculinoPac.Size = New Size(97, 24)
        rdbMasculinoPac.TabIndex = 3
        rdbMasculinoPac.TabStop = True
        rdbMasculinoPac.Text = "Masculino"
        rdbMasculinoPac.UseVisualStyleBackColor = True
        ' 
        ' rdbFemeninoPac
        ' 
        rdbFemeninoPac.AutoSize = True
        rdbFemeninoPac.Location = New Point(6, 26)
        rdbFemeninoPac.Name = "rdbFemeninoPac"
        rdbFemeninoPac.Size = New Size(95, 24)
        rdbFemeninoPac.TabIndex = 2
        rdbFemeninoPac.TabStop = True
        rdbFemeninoPac.Text = "Femenino"
        rdbFemeninoPac.UseVisualStyleBackColor = True
        ' 
        ' txtEdadPac
        ' 
        txtEdadPac.Location = New Point(58, 158)
        txtEdadPac.Name = "txtEdadPac"
        txtEdadPac.Size = New Size(125, 27)
        txtEdadPac.TabIndex = 2
        ' 
        ' lblEdadPac
        ' 
        lblEdadPac.AutoSize = True
        lblEdadPac.Location = New Point(6, 165)
        lblEdadPac.Name = "lblEdadPac"
        lblEdadPac.Size = New Size(46, 20)
        lblEdadPac.TabIndex = 5
        lblEdadPac.Text = "Edad:"
        ' 
        ' dtpFechaNacPac
        ' 
        dtpFechaNacPac.Location = New Point(161, 127)
        dtpFechaNacPac.Name = "dtpFechaNacPac"
        dtpFechaNacPac.Size = New Size(250, 27)
        dtpFechaNacPac.TabIndex = 4
        ' 
        ' lblFechaNacPac
        ' 
        lblFechaNacPac.AutoSize = True
        lblFechaNacPac.Location = New Point(6, 134)
        lblFechaNacPac.Name = "lblFechaNacPac"
        lblFechaNacPac.Size = New Size(149, 20)
        lblFechaNacPac.TabIndex = 2
        lblFechaNacPac.Text = "Fecha de nacimiento:"
        ' 
        ' txtApePac
        ' 
        txtApePac.Location = New Point(79, 93)
        txtApePac.MaxLength = 30
        txtApePac.Name = "txtApePac"
        txtApePac.Size = New Size(202, 27)
        txtApePac.TabIndex = 2
        ' 
        ' lblApePac
        ' 
        lblApePac.AutoSize = True
        lblApePac.Location = New Point(6, 100)
        lblApePac.Name = "lblApePac"
        lblApePac.Size = New Size(69, 20)
        lblApePac.TabIndex = 2
        lblApePac.Text = "Apellido:"
        ' 
        ' txtNombPac
        ' 
        txtNombPac.Location = New Point(79, 58)
        txtNombPac.MaxLength = 30
        txtNombPac.Name = "txtNombPac"
        txtNombPac.Size = New Size(202, 27)
        txtNombPac.TabIndex = 2
        ' 
        ' lblNombPac
        ' 
        lblNombPac.AutoSize = True
        lblNombPac.Location = New Point(6, 65)
        lblNombPac.Name = "lblNombPac"
        lblNombPac.Size = New Size(67, 20)
        lblNombPac.TabIndex = 3
        lblNombPac.Text = "Nombre:"
        ' 
        ' lblIdPac
        ' 
        lblIdPac.AutoSize = True
        lblIdPac.Location = New Point(6, 32)
        lblIdPac.Name = "lblIdPac"
        lblIdPac.Size = New Size(155, 20)
        lblIdPac.TabIndex = 2
        lblIdPac.Text = "Número de Identidad:"
        ' 
        ' btnBuscarPaciente
        ' 
        btnBuscarPaciente.Location = New Point(291, 36)
        btnBuscarPaciente.Name = "btnBuscarPaciente"
        btnBuscarPaciente.Size = New Size(66, 29)
        btnBuscarPaciente.TabIndex = 9
        btnBuscarPaciente.Text = "Buscar"
        btnBuscarPaciente.UseVisualStyleBackColor = True
        ' 
        ' lblFormPac
        ' 
        lblFormPac.AutoSize = True
        lblFormPac.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFormPac.Location = New Point(688, 9)
        lblFormPac.Name = "lblFormPac"
        lblFormPac.Size = New Size(335, 41)
        lblFormPac.TabIndex = 3
        lblFormPac.Text = "Formulario de Pacientes"
        ' 
        ' btnAgregarPac
        ' 
        btnAgregarPac.Image = CType(resources.GetObject("btnAgregarPac.Image"), Image)
        btnAgregarPac.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarPac.Location = New Point(83, 683)
        btnAgregarPac.Name = "btnAgregarPac"
        btnAgregarPac.Size = New Size(95, 34)
        btnAgregarPac.TabIndex = 6
        btnAgregarPac.Text = "Agregar"
        btnAgregarPac.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarPac.UseVisualStyleBackColor = True
        ' 
        ' btnModificarPac
        ' 
        btnModificarPac.Image = CType(resources.GetObject("btnModificarPac.Image"), Image)
        btnModificarPac.ImageAlign = ContentAlignment.MiddleRight
        btnModificarPac.Location = New Point(218, 683)
        btnModificarPac.Name = "btnModificarPac"
        btnModificarPac.Size = New Size(107, 34)
        btnModificarPac.TabIndex = 7
        btnModificarPac.Text = "Modificar"
        btnModificarPac.TextAlign = ContentAlignment.MiddleLeft
        btnModificarPac.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarPac
        ' 
        btnEliminarPac.Image = CType(resources.GetObject("btnEliminarPac.Image"), Image)
        btnEliminarPac.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarPac.Location = New Point(361, 683)
        btnEliminarPac.Name = "btnEliminarPac"
        btnEliminarPac.Size = New Size(95, 34)
        btnEliminarPac.TabIndex = 8
        btnEliminarPac.Text = "Eliminar"
        btnEliminarPac.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarPac.UseVisualStyleBackColor = True
        ' 
        ' dtgPacientes
        ' 
        dtgPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgPacientes.Location = New Point(21, 71)
        dtgPacientes.Name = "dtgPacientes"
        dtgPacientes.RowHeadersWidth = 51
        dtgPacientes.Size = New Size(971, 447)
        dtgPacientes.TabIndex = 9
        ' 
        ' grpBuscarPaciente
        ' 
        grpBuscarPaciente.Controls.Add(btnBuscarPaciente)
        grpBuscarPaciente.Controls.Add(txtBuscarPaciente)
        grpBuscarPaciente.Controls.Add(dtgPacientes)
        grpBuscarPaciente.Location = New Point(542, 100)
        grpBuscarPaciente.Name = "grpBuscarPaciente"
        grpBuscarPaciente.Size = New Size(1013, 539)
        grpBuscarPaciente.TabIndex = 10
        grpBuscarPaciente.TabStop = False
        grpBuscarPaciente.Text = "Buscar Paciente"
        ' 
        ' txtBuscarPaciente
        ' 
        txtBuscarPaciente.Location = New Point(21, 38)
        txtBuscarPaciente.Name = "txtBuscarPaciente"
        txtBuscarPaciente.Size = New Size(264, 27)
        txtBuscarPaciente.TabIndex = 10
        ' 
        ' lblInstruccionesFormularioP
        ' 
        lblInstruccionesFormularioP.AutoSize = True
        lblInstruccionesFormularioP.ForeColor = Color.Red
        lblInstruccionesFormularioP.Location = New Point(126, 68)
        lblInstruccionesFormularioP.Name = "lblInstruccionesFormularioP"
        lblInstruccionesFormularioP.Size = New Size(1318, 20)
        lblInstruccionesFormularioP.TabIndex = 11
        lblInstruccionesFormularioP.Text = "*Si desea agregar usuario solo llene los campos y presione el botón agregar. Si desea modificar o eliminar , búsquelo en la sección de Buscar Doctor y elija el usuario que desea eliminar o modificar."
        ' 
        ' FormularioPacientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1595, 743)
        Controls.Add(lblInstruccionesFormularioP)
        Controls.Add(grpBuscarPaciente)
        Controls.Add(btnEliminarPac)
        Controls.Add(btnModificarPac)
        Controls.Add(btnAgregarPac)
        Controls.Add(grpDatosRespPac)
        Controls.Add(grpDatosPac)
        Controls.Add(lblFormPac)
        Name = "FormularioPacientes"
        Text = "Pacientes"
        grpDatosRespPac.ResumeLayout(False)
        grpDatosRespPac.PerformLayout()
        grpDatosPac.ResumeLayout(False)
        grpDatosPac.PerformLayout()
        grpGeneroPac.ResumeLayout(False)
        grpGeneroPac.PerformLayout()
        CType(dtgPacientes, ComponentModel.ISupportInitialize).EndInit()
        grpBuscarPaciente.ResumeLayout(False)
        grpBuscarPaciente.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpDatosRespPac As GroupBox
    Friend WithEvents grpDatosPac As GroupBox
    Friend WithEvents lblTelPac As Label
    Friend WithEvents txtCorreoPac As TextBox
    Friend WithEvents lblCorreoPac As Label
    Friend WithEvents txtDirecPac As TextBox
    Friend WithEvents lblDirecPac As Label
    Friend WithEvents grpGeneroPac As GroupBox
    Friend WithEvents rdbMasculinoPac As RadioButton
    Friend WithEvents rdbFemeninoPac As RadioButton
    Friend WithEvents txtEdadPac As TextBox
    Friend WithEvents lblEdadPac As Label
    Friend WithEvents dtpFechaNacPac As DateTimePicker
    Friend WithEvents lblFechaNacPac As Label
    Friend WithEvents txtApePac As TextBox
    Friend WithEvents lblApePac As Label
    Friend WithEvents txtNombPac As TextBox
    Friend WithEvents lblNombPac As Label
    Friend WithEvents lblIdPac As Label
    Friend WithEvents lblFormPac As Label
    Friend WithEvents lblNumSegPac As Label
    Friend WithEvents lblTelRespPac As Label
    Friend WithEvents txtNombRespPac As TextBox
    Friend WithEvents lblNombRespPac As Label
    Friend WithEvents txtTelRespPac As TextBox
    Friend WithEvents btnAgregarPac As Button
    Friend WithEvents btnModificarPac As Button
    Friend WithEvents btnEliminarPac As Button
    Friend WithEvents btnBuscarPaciente As Button
    Friend WithEvents dtgPacientes As DataGridView
    Friend WithEvents grpBuscarPaciente As GroupBox
    Friend WithEvents txtBuscarPaciente As TextBox
    Friend WithEvents lblInstruccionesFormularioP As Label
    Friend WithEvents txtIdentidadPaciente As TextBox
    Friend WithEvents txtNumSeguroPac As TextBox
    Friend WithEvents txtTelefonoPaciente As TextBox
End Class

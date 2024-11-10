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
        btnBuscarPac = New Button()
        mskNumSegPac = New MaskedTextBox()
        lblNumSegPac = New Label()
        mskTelPac = New MaskedTextBox()
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
        mskIdPac = New MaskedTextBox()
        lblIdPac = New Label()
        lblFormPac = New Label()
        btnAgregarPac = New Button()
        btnModificarPac = New Button()
        btnEliminarPac = New Button()
        grpDatosRespPac.SuspendLayout()
        grpDatosPac.SuspendLayout()
        grpGeneroPac.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpDatosRespPac
        ' 
        grpDatosRespPac.Controls.Add(txtTelRespPac)
        grpDatosRespPac.Controls.Add(lblTelRespPac)
        grpDatosRespPac.Controls.Add(txtNombRespPac)
        grpDatosRespPac.Controls.Add(lblNombRespPac)
        grpDatosRespPac.Location = New Point(579, 100)
        grpDatosRespPac.Name = "grpDatosRespPac"
        grpDatosRespPac.Size = New Size(402, 120)
        grpDatosRespPac.TabIndex = 5
        grpDatosRespPac.TabStop = False
        grpDatosRespPac.Text = "Datos del Responsable"
        ' 
        ' txtTelRespPac
        ' 
        txtTelRespPac.Location = New Point(192, 58)
        txtTelRespPac.Name = "txtTelRespPac"
        txtTelRespPac.Size = New Size(191, 27)
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
        txtNombRespPac.Name = "txtNombRespPac"
        txtNombRespPac.Size = New Size(191, 27)
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
        grpDatosPac.Controls.Add(btnBuscarPac)
        grpDatosPac.Controls.Add(mskNumSegPac)
        grpDatosPac.Controls.Add(lblNumSegPac)
        grpDatosPac.Controls.Add(mskTelPac)
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
        grpDatosPac.Controls.Add(mskIdPac)
        grpDatosPac.Controls.Add(lblIdPac)
        grpDatosPac.Location = New Point(68, 100)
        grpDatosPac.Name = "grpDatosPac"
        grpDatosPac.Size = New Size(447, 426)
        grpDatosPac.TabIndex = 4
        grpDatosPac.TabStop = False
        grpDatosPac.Text = "Datos Personales"
        ' 
        ' btnBuscarPac
        ' 
        btnBuscarPac.Location = New Point(366, 23)
        btnBuscarPac.Name = "btnBuscarPac"
        btnBuscarPac.Size = New Size(66, 29)
        btnBuscarPac.TabIndex = 9
        btnBuscarPac.Text = "Buscar"
        btnBuscarPac.UseVisualStyleBackColor = True
        ' 
        ' mskNumSegPac
        ' 
        mskNumSegPac.Location = New Point(150, 371)
        mskNumSegPac.Name = "mskNumSegPac"
        mskNumSegPac.Size = New Size(200, 27)
        mskNumSegPac.TabIndex = 12
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
        ' mskTelPac
        ' 
        mskTelPac.Location = New Point(82, 338)
        mskTelPac.Name = "mskTelPac"
        mskTelPac.Size = New Size(176, 27)
        mskTelPac.TabIndex = 11
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
        ' mskIdPac
        ' 
        mskIdPac.Location = New Point(167, 25)
        mskIdPac.Name = "mskIdPac"
        mskIdPac.Size = New Size(193, 27)
        mskIdPac.TabIndex = 2
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
        ' lblFormPac
        ' 
        lblFormPac.AutoSize = True
        lblFormPac.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFormPac.Location = New Point(375, 39)
        lblFormPac.Name = "lblFormPac"
        lblFormPac.Size = New Size(335, 41)
        lblFormPac.TabIndex = 3
        lblFormPac.Text = "Formulario de Pacientes"
        ' 
        ' btnAgregarPac
        ' 
        btnAgregarPac.Image = CType(resources.GetObject("btnAgregarPac.Image"), Image)
        btnAgregarPac.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarPac.Location = New Point(550, 371)
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
        btnModificarPac.Location = New Point(671, 371)
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
        btnEliminarPac.Location = New Point(795, 373)
        btnEliminarPac.Name = "btnEliminarPac"
        btnEliminarPac.Size = New Size(95, 34)
        btnEliminarPac.TabIndex = 8
        btnEliminarPac.Text = "Eliminar"
        btnEliminarPac.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarPac.UseVisualStyleBackColor = True
        ' 
        ' FormularioPacientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1052, 642)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpDatosRespPac As GroupBox
    Friend WithEvents grpDatosPac As GroupBox
    Friend WithEvents mskTelPac As MaskedTextBox
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
    Friend WithEvents mskIdPac As MaskedTextBox
    Friend WithEvents lblIdPac As Label
    Friend WithEvents lblFormPac As Label
    Friend WithEvents mskNumSegPac As MaskedTextBox
    Friend WithEvents lblNumSegPac As Label
    Friend WithEvents lblTelRespPac As Label
    Friend WithEvents txtNombRespPac As TextBox
    Friend WithEvents lblNombRespPac As Label
    Friend WithEvents txtTelRespPac As TextBox
    Friend WithEvents btnAgregarPac As Button
    Friend WithEvents btnModificarPac As Button
    Friend WithEvents btnEliminarPac As Button
    Friend WithEvents btnBuscarPac As Button
End Class

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
        txtTelefono = New TextBox()
        txtNumidentidad = New TextBox()
        cbxEstadoCivilDoc = New ComboBox()
        lblEstadoCivilDoc = New Label()
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
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        btnBuscarDoc = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        grpDatosDoc.SuspendLayout()
        grpGeneroDoc.SuspendLayout()
        grpDatosProfesionalesDoc.SuspendLayout()
        grpEstadoDoc.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblFormDoc
        ' 
        lblFormDoc.AutoSize = True
        lblFormDoc.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFormDoc.Location = New Point(684, 9)
        lblFormDoc.Margin = New Padding(4, 0, 4, 0)
        lblFormDoc.Name = "lblFormDoc"
        lblFormDoc.Size = New Size(396, 48)
        lblFormDoc.TabIndex = 0
        lblFormDoc.Text = "Formulario de Doctores"
        ' 
        ' grpDatosDoc
        ' 
        grpDatosDoc.Controls.Add(txtTelefono)
        grpDatosDoc.Controls.Add(txtNumidentidad)
        grpDatosDoc.Controls.Add(cbxEstadoCivilDoc)
        grpDatosDoc.Controls.Add(lblEstadoCivilDoc)
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
        grpDatosDoc.Controls.Add(lblIdDoc)
        grpDatosDoc.Location = New Point(14, 144)
        grpDatosDoc.Margin = New Padding(4)
        grpDatosDoc.Name = "grpDatosDoc"
        grpDatosDoc.Padding = New Padding(4)
        grpDatosDoc.Size = New Size(559, 532)
        grpDatosDoc.TabIndex = 1
        grpDatosDoc.TabStop = False
        grpDatosDoc.Text = "Datos Personales"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(95, 427)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(418, 31)
        txtTelefono.TabIndex = 10
        ' 
        ' txtNumidentidad
        ' 
        txtNumidentidad.Location = New Point(195, 34)
        txtNumidentidad.MaxLength = 13
        txtNumidentidad.Name = "txtNumidentidad"
        txtNumidentidad.Size = New Size(318, 31)
        txtNumidentidad.TabIndex = 1
        ' 
        ' cbxEstadoCivilDoc
        ' 
        cbxEstadoCivilDoc.FormattingEnabled = True
        cbxEstadoCivilDoc.Items.AddRange(New Object() {"Casado", "Soltero", "Divorciado"})
        cbxEstadoCivilDoc.Location = New Point(126, 465)
        cbxEstadoCivilDoc.Margin = New Padding(4)
        cbxEstadoCivilDoc.Name = "cbxEstadoCivilDoc"
        cbxEstadoCivilDoc.Size = New Size(387, 33)
        cbxEstadoCivilDoc.TabIndex = 11
        ' 
        ' lblEstadoCivilDoc
        ' 
        lblEstadoCivilDoc.AutoSize = True
        lblEstadoCivilDoc.Location = New Point(8, 475)
        lblEstadoCivilDoc.Margin = New Padding(4, 0, 4, 0)
        lblEstadoCivilDoc.Name = "lblEstadoCivilDoc"
        lblEstadoCivilDoc.Size = New Size(107, 25)
        lblEstadoCivilDoc.TabIndex = 12
        lblEstadoCivilDoc.Text = "Estado Civil:"
        ' 
        ' lblTelDoc
        ' 
        lblTelDoc.AutoSize = True
        lblTelDoc.Location = New Point(8, 431)
        lblTelDoc.Margin = New Padding(4, 0, 4, 0)
        lblTelDoc.Name = "lblTelDoc"
        lblTelDoc.Size = New Size(83, 25)
        lblTelDoc.TabIndex = 2
        lblTelDoc.Text = "Teléfono:"
        ' 
        ' txtCorreoDoc
        ' 
        txtCorreoDoc.Location = New Point(86, 382)
        txtCorreoDoc.Margin = New Padding(4)
        txtCorreoDoc.MaxLength = 75
        txtCorreoDoc.Name = "txtCorreoDoc"
        txtCorreoDoc.Size = New Size(427, 31)
        txtCorreoDoc.TabIndex = 9
        ' 
        ' lblCorreoDoc
        ' 
        lblCorreoDoc.AutoSize = True
        lblCorreoDoc.Location = New Point(8, 391)
        lblCorreoDoc.Margin = New Padding(4, 0, 4, 0)
        lblCorreoDoc.Name = "lblCorreoDoc"
        lblCorreoDoc.Size = New Size(70, 25)
        lblCorreoDoc.TabIndex = 9
        lblCorreoDoc.Text = "Correo:"
        ' 
        ' txtDirecDoc
        ' 
        txtDirecDoc.Location = New Point(108, 341)
        txtDirecDoc.Margin = New Padding(4)
        txtDirecDoc.MaxLength = 50
        txtDirecDoc.Name = "txtDirecDoc"
        txtDirecDoc.Size = New Size(405, 31)
        txtDirecDoc.TabIndex = 8
        ' 
        ' lblDirecDoc
        ' 
        lblDirecDoc.AutoSize = True
        lblDirecDoc.Location = New Point(8, 350)
        lblDirecDoc.Margin = New Padding(4, 0, 4, 0)
        lblDirecDoc.Name = "lblDirecDoc"
        lblDirecDoc.Size = New Size(89, 25)
        lblDirecDoc.TabIndex = 7
        lblDirecDoc.Text = "Dirección:"
        ' 
        ' grpGeneroDoc
        ' 
        grpGeneroDoc.Controls.Add(rdbMasculinoDoc)
        grpGeneroDoc.Controls.Add(rdbFemeninoDoc)
        grpGeneroDoc.Location = New Point(8, 247)
        grpGeneroDoc.Margin = New Padding(4)
        grpGeneroDoc.Name = "grpGeneroDoc"
        grpGeneroDoc.Padding = New Padding(4)
        grpGeneroDoc.Size = New Size(271, 76)
        grpGeneroDoc.TabIndex = 6
        grpGeneroDoc.TabStop = False
        grpGeneroDoc.Text = "Género"
        ' 
        ' rdbMasculinoDoc
        ' 
        rdbMasculinoDoc.AutoSize = True
        rdbMasculinoDoc.Location = New Point(142, 32)
        rdbMasculinoDoc.Margin = New Padding(4)
        rdbMasculinoDoc.Name = "rdbMasculinoDoc"
        rdbMasculinoDoc.Size = New Size(117, 29)
        rdbMasculinoDoc.TabIndex = 7
        rdbMasculinoDoc.TabStop = True
        rdbMasculinoDoc.Text = "Masculino"
        rdbMasculinoDoc.UseVisualStyleBackColor = True
        ' 
        ' rdbFemeninoDoc
        ' 
        rdbFemeninoDoc.AutoSize = True
        rdbFemeninoDoc.Location = New Point(8, 32)
        rdbFemeninoDoc.Margin = New Padding(4)
        rdbFemeninoDoc.Name = "rdbFemeninoDoc"
        rdbFemeninoDoc.Size = New Size(115, 29)
        rdbFemeninoDoc.TabIndex = 6
        rdbFemeninoDoc.TabStop = True
        rdbFemeninoDoc.Text = "Femenino"
        rdbFemeninoDoc.UseVisualStyleBackColor = True
        ' 
        ' txtEdadDoc
        ' 
        txtEdadDoc.Enabled = False
        txtEdadDoc.Location = New Point(72, 198)
        txtEdadDoc.Margin = New Padding(4)
        txtEdadDoc.MaxLength = 75
        txtEdadDoc.Name = "txtEdadDoc"
        txtEdadDoc.Size = New Size(441, 31)
        txtEdadDoc.TabIndex = 5
        ' 
        ' lblEdadDoc
        ' 
        lblEdadDoc.AutoSize = True
        lblEdadDoc.Location = New Point(8, 206)
        lblEdadDoc.Margin = New Padding(4, 0, 4, 0)
        lblEdadDoc.Name = "lblEdadDoc"
        lblEdadDoc.Size = New Size(56, 25)
        lblEdadDoc.TabIndex = 5
        lblEdadDoc.Text = "Edad:"
        ' 
        ' dtpFechaNacDoc
        ' 
        dtpFechaNacDoc.Location = New Point(201, 159)
        dtpFechaNacDoc.Margin = New Padding(4)
        dtpFechaNacDoc.Name = "dtpFechaNacDoc"
        dtpFechaNacDoc.Size = New Size(312, 31)
        dtpFechaNacDoc.TabIndex = 4
        ' 
        ' lblFechaNacDoc
        ' 
        lblFechaNacDoc.AutoSize = True
        lblFechaNacDoc.Location = New Point(8, 168)
        lblFechaNacDoc.Margin = New Padding(4, 0, 4, 0)
        lblFechaNacDoc.Name = "lblFechaNacDoc"
        lblFechaNacDoc.Size = New Size(178, 25)
        lblFechaNacDoc.TabIndex = 2
        lblFechaNacDoc.Text = "Fecha de nacimiento:"
        ' 
        ' txtApeDoc
        ' 
        txtApeDoc.Location = New Point(99, 116)
        txtApeDoc.Margin = New Padding(4)
        txtApeDoc.MaxLength = 30
        txtApeDoc.Name = "txtApeDoc"
        txtApeDoc.Size = New Size(414, 31)
        txtApeDoc.TabIndex = 3
        ' 
        ' lblApeDoc
        ' 
        lblApeDoc.AutoSize = True
        lblApeDoc.Location = New Point(8, 125)
        lblApeDoc.Margin = New Padding(4, 0, 4, 0)
        lblApeDoc.Name = "lblApeDoc"
        lblApeDoc.Size = New Size(82, 25)
        lblApeDoc.TabIndex = 2
        lblApeDoc.Text = "Apellido:"
        ' 
        ' txtNombDoc
        ' 
        txtNombDoc.Location = New Point(99, 72)
        txtNombDoc.Margin = New Padding(4)
        txtNombDoc.MaxLength = 30
        txtNombDoc.Name = "txtNombDoc"
        txtNombDoc.Size = New Size(414, 31)
        txtNombDoc.TabIndex = 2
        ' 
        ' lblNombDoc
        ' 
        lblNombDoc.AutoSize = True
        lblNombDoc.Location = New Point(8, 81)
        lblNombDoc.Margin = New Padding(4, 0, 4, 0)
        lblNombDoc.Name = "lblNombDoc"
        lblNombDoc.Size = New Size(82, 25)
        lblNombDoc.TabIndex = 3
        lblNombDoc.Text = "Nombre:"
        ' 
        ' lblIdDoc
        ' 
        lblIdDoc.AutoSize = True
        lblIdDoc.Location = New Point(8, 40)
        lblIdDoc.Margin = New Padding(4, 0, 4, 0)
        lblIdDoc.Name = "lblIdDoc"
        lblIdDoc.Size = New Size(187, 25)
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
        grpDatosProfesionalesDoc.Location = New Point(14, 698)
        grpDatosProfesionalesDoc.Margin = New Padding(4)
        grpDatosProfesionalesDoc.Name = "grpDatosProfesionalesDoc"
        grpDatosProfesionalesDoc.Padding = New Padding(4)
        grpDatosProfesionalesDoc.Size = New Size(559, 264)
        grpDatosProfesionalesDoc.TabIndex = 2
        grpDatosProfesionalesDoc.TabStop = False
        grpDatosProfesionalesDoc.Text = "Datos Profesionales"
        ' 
        ' grpEstadoDoc
        ' 
        grpEstadoDoc.Controls.Add(rdbInactivoDoc)
        grpEstadoDoc.Controls.Add(rdbActivoDoc)
        grpEstadoDoc.Location = New Point(16, 168)
        grpEstadoDoc.Margin = New Padding(4)
        grpEstadoDoc.Name = "grpEstadoDoc"
        grpEstadoDoc.Padding = New Padding(4)
        grpEstadoDoc.Size = New Size(229, 81)
        grpEstadoDoc.TabIndex = 6
        grpEstadoDoc.TabStop = False
        grpEstadoDoc.Text = "Estado"
        ' 
        ' rdbInactivoDoc
        ' 
        rdbInactivoDoc.AutoSize = True
        rdbInactivoDoc.Location = New Point(119, 36)
        rdbInactivoDoc.Margin = New Padding(4)
        rdbInactivoDoc.Name = "rdbInactivoDoc"
        rdbInactivoDoc.Size = New Size(99, 29)
        rdbInactivoDoc.TabIndex = 17
        rdbInactivoDoc.TabStop = True
        rdbInactivoDoc.Text = "Inactivo"
        rdbInactivoDoc.UseVisualStyleBackColor = True
        ' 
        ' rdbActivoDoc
        ' 
        rdbActivoDoc.AutoSize = True
        rdbActivoDoc.Location = New Point(10, 36)
        rdbActivoDoc.Margin = New Padding(4)
        rdbActivoDoc.Name = "rdbActivoDoc"
        rdbActivoDoc.Size = New Size(87, 29)
        rdbActivoDoc.TabIndex = 16
        rdbActivoDoc.TabStop = True
        rdbActivoDoc.Text = "Activo"
        rdbActivoDoc.UseVisualStyleBackColor = True
        ' 
        ' txtSueldoDoc
        ' 
        txtSueldoDoc.Location = New Point(88, 116)
        txtSueldoDoc.Margin = New Padding(4)
        txtSueldoDoc.Name = "txtSueldoDoc"
        txtSueldoDoc.Size = New Size(425, 31)
        txtSueldoDoc.TabIndex = 14
        ' 
        ' lblSueldoDoc
        ' 
        lblSueldoDoc.AutoSize = True
        lblSueldoDoc.Location = New Point(8, 125)
        lblSueldoDoc.Margin = New Padding(4, 0, 4, 0)
        lblSueldoDoc.Name = "lblSueldoDoc"
        lblSueldoDoc.Size = New Size(71, 25)
        lblSueldoDoc.TabIndex = 4
        lblSueldoDoc.Text = "Sueldo:"
        ' 
        ' txtTituloDoc
        ' 
        txtTituloDoc.Location = New Point(78, 72)
        txtTituloDoc.Margin = New Padding(4)
        txtTituloDoc.MaxLength = 40
        txtTituloDoc.Name = "txtTituloDoc"
        txtTituloDoc.Size = New Size(435, 31)
        txtTituloDoc.TabIndex = 13
        ' 
        ' lblTituloDoc
        ' 
        lblTituloDoc.AutoSize = True
        lblTituloDoc.Location = New Point(8, 81)
        lblTituloDoc.Margin = New Padding(4, 0, 4, 0)
        lblTituloDoc.Name = "lblTituloDoc"
        lblTituloDoc.Size = New Size(60, 25)
        lblTituloDoc.TabIndex = 2
        lblTituloDoc.Text = "Título:"
        ' 
        ' cbxEspDoc
        ' 
        cbxEspDoc.FormattingEnabled = True
        cbxEspDoc.Location = New Point(135, 30)
        cbxEspDoc.Margin = New Padding(4)
        cbxEspDoc.Name = "cbxEspDoc"
        cbxEspDoc.Size = New Size(378, 33)
        cbxEspDoc.TabIndex = 12
        ' 
        ' lblEspDoc
        ' 
        lblEspDoc.AutoSize = True
        lblEspDoc.Location = New Point(8, 40)
        lblEspDoc.Margin = New Padding(4, 0, 4, 0)
        lblEspDoc.Name = "lblEspDoc"
        lblEspDoc.Size = New Size(113, 25)
        lblEspDoc.TabIndex = 0
        lblEspDoc.Text = "Especialidad:"
        ' 
        ' btnAgregarDoc
        ' 
        btnAgregarDoc.Image = CType(resources.GetObject("btnAgregarDoc.Image"), Image)
        btnAgregarDoc.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarDoc.Location = New Point(30, 970)
        btnAgregarDoc.Margin = New Padding(4)
        btnAgregarDoc.Name = "btnAgregarDoc"
        btnAgregarDoc.Size = New Size(118, 50)
        btnAgregarDoc.TabIndex = 18
        btnAgregarDoc.Text = "Agregar"
        btnAgregarDoc.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarDoc.UseVisualStyleBackColor = True
        ' 
        ' btnModificarDoc
        ' 
        btnModificarDoc.Enabled = False
        btnModificarDoc.Image = CType(resources.GetObject("btnModificarDoc.Image"), Image)
        btnModificarDoc.ImageAlign = ContentAlignment.MiddleRight
        btnModificarDoc.Location = New Point(181, 970)
        btnModificarDoc.Margin = New Padding(4)
        btnModificarDoc.Name = "btnModificarDoc"
        btnModificarDoc.Size = New Size(131, 50)
        btnModificarDoc.TabIndex = 19
        btnModificarDoc.Text = "Modificar"
        btnModificarDoc.TextAlign = ContentAlignment.MiddleLeft
        btnModificarDoc.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarDoc
        ' 
        btnEliminarDoc.Enabled = False
        btnEliminarDoc.Image = CType(resources.GetObject("btnEliminarDoc.Image"), Image)
        btnEliminarDoc.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarDoc.Location = New Point(354, 970)
        btnEliminarDoc.Margin = New Padding(4)
        btnEliminarDoc.Name = "btnEliminarDoc"
        btnEliminarDoc.Size = New Size(121, 50)
        btnEliminarDoc.TabIndex = 20
        btnEliminarDoc.Text = "Eliminar"
        btnEliminarDoc.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarDoc.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(btnBuscarDoc)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Location = New Point(614, 144)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1145, 818)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Buscar Doctor"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 30)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(305, 31)
        TextBox1.TabIndex = 25
        ' 
        ' btnBuscarDoc
        ' 
        btnBuscarDoc.Location = New Point(318, 26)
        btnBuscarDoc.Margin = New Padding(4)
        btnBuscarDoc.Name = "btnBuscarDoc"
        btnBuscarDoc.Size = New Size(84, 39)
        btnBuscarDoc.TabIndex = 23
        btnBuscarDoc.Text = "Buscar"
        btnBuscarDoc.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 72)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1120, 731)
        DataGridView1.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(14, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(1717, 28)
        Label1.TabIndex = 24
        Label1.Text = "* Si desea agregar usuario solo llene los campos y precione el botón agregar. Si desea modificar o eliminar, busquelo en la seccion de Buscar Doctor y elija el usuario que desea modificar o eliminar."
        ' 
        ' FormularioDoctores
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1888, 1050)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(btnEliminarDoc)
        Controls.Add(btnModificarDoc)
        Controls.Add(btnAgregarDoc)
        Controls.Add(grpDatosProfesionalesDoc)
        Controls.Add(grpDatosDoc)
        Controls.Add(lblFormDoc)
        Margin = New Padding(4)
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
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFormDoc As Label
    Friend WithEvents grpDatosDoc As GroupBox
    Friend WithEvents txtApeDoc As TextBox
    Friend WithEvents lblApeDoc As Label
    Friend WithEvents txtNombDoc As TextBox
    Friend WithEvents lblNombDoc As Label
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
    Friend WithEvents btnAgregarDoc As Button
    Friend WithEvents btnModificarDoc As Button
    Friend WithEvents btnEliminarDoc As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBuscarDoc As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumidentidad As TextBox
    Friend WithEvents txtTelefono As TextBox
End Class

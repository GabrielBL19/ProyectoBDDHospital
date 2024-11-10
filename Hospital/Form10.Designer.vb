<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioSalas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioSalas))
        lblFormSalas = New Label()
        grpInfoSala = New GroupBox()
        lblComentarioSala = New Label()
        rbComentarioSala = New RichTextBox()
        grpEstadoSala = New GroupBox()
        rdbNoDispSala = New RadioButton()
        rdbDisponibleSala = New RadioButton()
        dtpFechaMantSala = New DateTimePicker()
        lblFechaMantSala = New Label()
        cbxTipoSala = New ComboBox()
        lblCatSala = New Label()
        txtCapacidadSala = New TextBox()
        lblCapacidadSala = New Label()
        txtPisoSala = New TextBox()
        lblPisoSala = New Label()
        txtNombSala = New TextBox()
        lblNombSala = New Label()
        txtIdSala = New TextBox()
        lblIdSala = New Label()
        dtgSalas = New DataGridView()
        btnAgregarSala = New Button()
        btnModificarSala = New Button()
        btnEliminarSala = New Button()
        grpInfoSala.SuspendLayout()
        grpEstadoSala.SuspendLayout()
        CType(dtgSalas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblFormSalas
        ' 
        lblFormSalas.AutoSize = True
        lblFormSalas.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFormSalas.Location = New Point(573, 9)
        lblFormSalas.Name = "lblFormSalas"
        lblFormSalas.Size = New Size(277, 41)
        lblFormSalas.TabIndex = 0
        lblFormSalas.Text = "Formulario de Salas"
        ' 
        ' grpInfoSala
        ' 
        grpInfoSala.Controls.Add(lblComentarioSala)
        grpInfoSala.Controls.Add(rbComentarioSala)
        grpInfoSala.Controls.Add(grpEstadoSala)
        grpInfoSala.Controls.Add(dtpFechaMantSala)
        grpInfoSala.Controls.Add(lblFechaMantSala)
        grpInfoSala.Controls.Add(cbxTipoSala)
        grpInfoSala.Controls.Add(lblCatSala)
        grpInfoSala.Controls.Add(txtCapacidadSala)
        grpInfoSala.Controls.Add(lblCapacidadSala)
        grpInfoSala.Controls.Add(txtPisoSala)
        grpInfoSala.Controls.Add(lblPisoSala)
        grpInfoSala.Controls.Add(txtNombSala)
        grpInfoSala.Controls.Add(lblNombSala)
        grpInfoSala.Controls.Add(txtIdSala)
        grpInfoSala.Controls.Add(lblIdSala)
        grpInfoSala.Location = New Point(34, 73)
        grpInfoSala.Name = "grpInfoSala"
        grpInfoSala.Size = New Size(510, 452)
        grpInfoSala.TabIndex = 1
        grpInfoSala.TabStop = False
        grpInfoSala.Text = "Informacion de Sala"
        ' 
        ' lblComentarioSala
        ' 
        lblComentarioSala.AutoSize = True
        lblComentarioSala.Location = New Point(6, 314)
        lblComentarioSala.Name = "lblComentarioSala"
        lblComentarioSala.Size = New Size(90, 20)
        lblComentarioSala.TabIndex = 2
        lblComentarioSala.Text = "Comentario:"
        ' 
        ' rbComentarioSala
        ' 
        rbComentarioSala.Location = New Point(102, 314)
        rbComentarioSala.Name = "rbComentarioSala"
        rbComentarioSala.Size = New Size(323, 120)
        rbComentarioSala.TabIndex = 8
        rbComentarioSala.Text = ""
        ' 
        ' grpEstadoSala
        ' 
        grpEstadoSala.Controls.Add(rdbNoDispSala)
        grpEstadoSala.Controls.Add(rdbDisponibleSala)
        grpEstadoSala.Location = New Point(132, 241)
        grpEstadoSala.Name = "grpEstadoSala"
        grpEstadoSala.Size = New Size(242, 54)
        grpEstadoSala.TabIndex = 7
        grpEstadoSala.TabStop = False
        grpEstadoSala.Text = "Estado"
        ' 
        ' rdbNoDispSala
        ' 
        rdbNoDispSala.AutoSize = True
        rdbNoDispSala.Location = New Point(110, 24)
        rdbNoDispSala.Name = "rdbNoDispSala"
        rdbNoDispSala.Size = New Size(126, 24)
        rdbNoDispSala.TabIndex = 1
        rdbNoDispSala.TabStop = True
        rdbNoDispSala.Text = "No Disponible"
        rdbNoDispSala.UseVisualStyleBackColor = True
        ' 
        ' rdbDisponibleSala
        ' 
        rdbDisponibleSala.AutoSize = True
        rdbDisponibleSala.Location = New Point(6, 24)
        rdbDisponibleSala.Name = "rdbDisponibleSala"
        rdbDisponibleSala.Size = New Size(102, 24)
        rdbDisponibleSala.TabIndex = 0
        rdbDisponibleSala.TabStop = True
        rdbDisponibleSala.Text = "Disponible"
        rdbDisponibleSala.UseVisualStyleBackColor = True
        ' 
        ' dtpFechaMantSala
        ' 
        dtpFechaMantSala.Location = New Point(235, 198)
        dtpFechaMantSala.Name = "dtpFechaMantSala"
        dtpFechaMantSala.Size = New Size(250, 27)
        dtpFechaMantSala.TabIndex = 6
        ' 
        ' lblFechaMantSala
        ' 
        lblFechaMantSala.AutoSize = True
        lblFechaMantSala.Location = New Point(6, 205)
        lblFechaMantSala.Name = "lblFechaMantSala"
        lblFechaMantSala.Size = New Size(223, 20)
        lblFechaMantSala.TabIndex = 2
        lblFechaMantSala.Text = "Fecha de último mantenimiento:"
        ' 
        ' cbxTipoSala
        ' 
        cbxTipoSala.FormattingEnabled = True
        cbxTipoSala.Location = New Point(87, 164)
        cbxTipoSala.Name = "cbxTipoSala"
        cbxTipoSala.Size = New Size(151, 28)
        cbxTipoSala.TabIndex = 2
        ' 
        ' lblCatSala
        ' 
        lblCatSala.AutoSize = True
        lblCatSala.Location = New Point(6, 172)
        lblCatSala.Name = "lblCatSala"
        lblCatSala.Size = New Size(74, 20)
        lblCatSala.TabIndex = 2
        lblCatSala.Text = "Tipo Sala:"
        ' 
        ' txtCapacidadSala
        ' 
        txtCapacidadSala.Location = New Point(95, 127)
        txtCapacidadSala.Name = "txtCapacidadSala"
        txtCapacidadSala.Size = New Size(125, 27)
        txtCapacidadSala.TabIndex = 2
        ' 
        ' lblCapacidadSala
        ' 
        lblCapacidadSala.AutoSize = True
        lblCapacidadSala.Location = New Point(6, 134)
        lblCapacidadSala.Name = "lblCapacidadSala"
        lblCapacidadSala.Size = New Size(83, 20)
        lblCapacidadSala.TabIndex = 2
        lblCapacidadSala.Text = "Capacidad:"
        ' 
        ' txtPisoSala
        ' 
        txtPisoSala.Location = New Point(51, 93)
        txtPisoSala.Name = "txtPisoSala"
        txtPisoSala.Size = New Size(136, 27)
        txtPisoSala.TabIndex = 2
        ' 
        ' lblPisoSala
        ' 
        lblPisoSala.AutoSize = True
        lblPisoSala.Location = New Point(6, 100)
        lblPisoSala.Name = "lblPisoSala"
        lblPisoSala.Size = New Size(39, 20)
        lblPisoSala.TabIndex = 5
        lblPisoSala.Text = "Piso:"
        ' 
        ' txtNombSala
        ' 
        txtNombSala.Location = New Point(148, 61)
        txtNombSala.Name = "txtNombSala"
        txtNombSala.Size = New Size(213, 27)
        txtNombSala.TabIndex = 4
        ' 
        ' lblNombSala
        ' 
        lblNombSala.AutoSize = True
        lblNombSala.Location = New Point(6, 68)
        lblNombSala.Name = "lblNombSala"
        lblNombSala.Size = New Size(136, 20)
        lblNombSala.TabIndex = 3
        lblNombSala.Text = "Nombre de la Sala:"
        ' 
        ' txtIdSala
        ' 
        txtIdSala.Location = New Point(71, 25)
        txtIdSala.Name = "txtIdSala"
        txtIdSala.Size = New Size(167, 27)
        txtIdSala.TabIndex = 2
        ' 
        ' lblIdSala
        ' 
        lblIdSala.AutoSize = True
        lblIdSala.Location = New Point(6, 32)
        lblIdSala.Name = "lblIdSala"
        lblIdSala.Size = New Size(59, 20)
        lblIdSala.TabIndex = 2
        lblIdSala.Text = "ID Sala:"
        ' 
        ' dtgSalas
        ' 
        dtgSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgSalas.Location = New Point(562, 105)
        dtgSalas.Name = "dtgSalas"
        dtgSalas.RowHeadersWidth = 51
        dtgSalas.Size = New Size(792, 391)
        dtgSalas.TabIndex = 2
        ' 
        ' btnAgregarSala
        ' 
        btnAgregarSala.Image = CType(resources.GetObject("btnAgregarSala.Image"), Image)
        btnAgregarSala.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarSala.Location = New Point(71, 544)
        btnAgregarSala.Name = "btnAgregarSala"
        btnAgregarSala.Size = New Size(94, 43)
        btnAgregarSala.TabIndex = 3
        btnAgregarSala.Text = "Agregar"
        btnAgregarSala.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarSala.UseVisualStyleBackColor = True
        ' 
        ' btnModificarSala
        ' 
        btnModificarSala.Image = CType(resources.GetObject("btnModificarSala.Image"), Image)
        btnModificarSala.ImageAlign = ContentAlignment.MiddleRight
        btnModificarSala.Location = New Point(213, 544)
        btnModificarSala.Name = "btnModificarSala"
        btnModificarSala.Size = New Size(103, 43)
        btnModificarSala.TabIndex = 4
        btnModificarSala.Text = "Modificar"
        btnModificarSala.TextAlign = ContentAlignment.MiddleLeft
        btnModificarSala.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarSala
        ' 
        btnEliminarSala.Image = CType(resources.GetObject("btnEliminarSala.Image"), Image)
        btnEliminarSala.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarSala.Location = New Point(378, 544)
        btnEliminarSala.Name = "btnEliminarSala"
        btnEliminarSala.Size = New Size(95, 43)
        btnEliminarSala.TabIndex = 5
        btnEliminarSala.Text = "Eliminar"
        btnEliminarSala.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarSala.UseVisualStyleBackColor = True
        ' 
        ' FormularioSalas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1366, 651)
        Controls.Add(btnEliminarSala)
        Controls.Add(btnModificarSala)
        Controls.Add(btnAgregarSala)
        Controls.Add(dtgSalas)
        Controls.Add(grpInfoSala)
        Controls.Add(lblFormSalas)
        Name = "FormularioSalas"
        Text = "Salas"
        grpInfoSala.ResumeLayout(False)
        grpInfoSala.PerformLayout()
        grpEstadoSala.ResumeLayout(False)
        grpEstadoSala.PerformLayout()
        CType(dtgSalas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFormSalas As Label
    Friend WithEvents grpInfoSala As GroupBox
    Friend WithEvents lblNombSala As Label
    Friend WithEvents txtIdSala As TextBox
    Friend WithEvents lblIdSala As Label
    Friend WithEvents lblPisoSala As Label
    Friend WithEvents txtNombSala As TextBox
    Friend WithEvents lblFechaMantSala As Label
    Friend WithEvents cbxTipoSala As ComboBox
    Friend WithEvents lblCatSala As Label
    Friend WithEvents txtCapacidadSala As TextBox
    Friend WithEvents lblCapacidadSala As Label
    Friend WithEvents txtPisoSala As TextBox
    Friend WithEvents dtpFechaMantSala As DateTimePicker
    Friend WithEvents grpEstadoSala As GroupBox
    Friend WithEvents rdbDisponibleSala As RadioButton
    Friend WithEvents rdbNoDispSala As RadioButton
    Friend WithEvents lblComentarioSala As Label
    Friend WithEvents rbComentarioSala As RichTextBox
    Friend WithEvents dtgSalas As DataGridView
    Friend WithEvents btnAgregarSala As Button
    Friend WithEvents btnModificarSala As Button
    Friend WithEvents btnEliminarSala As Button
End Class

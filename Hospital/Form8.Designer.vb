<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioEquipoLimpieza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioEquipoLimpieza))
        dtgEquipo = New DataGridView()
        btnEliminarEquipo = New Button()
        btnModificarEquipo = New Button()
        btnAgregarEquipo = New Button()
        grpDatosEquipoLimp = New GroupBox()
        cbxCatEquipo = New ComboBox()
        cbxMarcaEquipo = New ComboBox()
        lblMarcaEquipo = New Label()
        btnBuscarEquipo = New Button()
        txtSerialEquipo = New TextBox()
        lblSerialEquipo = New Label()
        lblCatEquipo = New Label()
        txtDescripEquipo = New TextBox()
        lblDescripEquipo = New Label()
        txtPrecioEquipo = New TextBox()
        lblPrecioEquipo = New Label()
        txtNombreEquipo = New TextBox()
        lblNombreEquipo = New Label()
        txtIdEquipo = New TextBox()
        lblIdEquipo = New Label()
        lblNombFormEquipoLimp = New Label()
        CType(dtgEquipo, ComponentModel.ISupportInitialize).BeginInit()
        grpDatosEquipoLimp.SuspendLayout()
        SuspendLayout()
        ' 
        ' dtgEquipo
        ' 
        dtgEquipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgEquipo.Location = New Point(504, 100)
        dtgEquipo.Name = "dtgEquipo"
        dtgEquipo.RowHeadersWidth = 51
        dtgEquipo.Size = New Size(825, 324)
        dtgEquipo.TabIndex = 16
        ' 
        ' btnEliminarEquipo
        ' 
        btnEliminarEquipo.Image = CType(resources.GetObject("btnEliminarEquipo.Image"), Image)
        btnEliminarEquipo.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarEquipo.Location = New Point(286, 401)
        btnEliminarEquipo.Name = "btnEliminarEquipo"
        btnEliminarEquipo.Size = New Size(96, 44)
        btnEliminarEquipo.TabIndex = 15
        btnEliminarEquipo.Text = "Eliminar"
        btnEliminarEquipo.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarEquipo.UseVisualStyleBackColor = True
        ' 
        ' btnModificarEquipo
        ' 
        btnModificarEquipo.Image = CType(resources.GetObject("btnModificarEquipo.Image"), Image)
        btnModificarEquipo.ImageAlign = ContentAlignment.MiddleRight
        btnModificarEquipo.Location = New Point(165, 401)
        btnModificarEquipo.Name = "btnModificarEquipo"
        btnModificarEquipo.Size = New Size(102, 44)
        btnModificarEquipo.TabIndex = 14
        btnModificarEquipo.Text = "Modificar"
        btnModificarEquipo.TextAlign = ContentAlignment.MiddleLeft
        btnModificarEquipo.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarEquipo
        ' 
        btnAgregarEquipo.Image = CType(resources.GetObject("btnAgregarEquipo.Image"), Image)
        btnAgregarEquipo.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarEquipo.Location = New Point(49, 401)
        btnAgregarEquipo.Name = "btnAgregarEquipo"
        btnAgregarEquipo.Size = New Size(94, 44)
        btnAgregarEquipo.TabIndex = 13
        btnAgregarEquipo.Text = "Agregar"
        btnAgregarEquipo.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarEquipo.UseVisualStyleBackColor = True
        ' 
        ' grpDatosEquipoLimp
        ' 
        grpDatosEquipoLimp.Controls.Add(cbxCatEquipo)
        grpDatosEquipoLimp.Controls.Add(cbxMarcaEquipo)
        grpDatosEquipoLimp.Controls.Add(lblMarcaEquipo)
        grpDatosEquipoLimp.Controls.Add(btnBuscarEquipo)
        grpDatosEquipoLimp.Controls.Add(txtSerialEquipo)
        grpDatosEquipoLimp.Controls.Add(lblSerialEquipo)
        grpDatosEquipoLimp.Controls.Add(lblCatEquipo)
        grpDatosEquipoLimp.Controls.Add(txtDescripEquipo)
        grpDatosEquipoLimp.Controls.Add(lblDescripEquipo)
        grpDatosEquipoLimp.Controls.Add(txtPrecioEquipo)
        grpDatosEquipoLimp.Controls.Add(lblPrecioEquipo)
        grpDatosEquipoLimp.Controls.Add(txtNombreEquipo)
        grpDatosEquipoLimp.Controls.Add(lblNombreEquipo)
        grpDatosEquipoLimp.Controls.Add(txtIdEquipo)
        grpDatosEquipoLimp.Controls.Add(lblIdEquipo)
        grpDatosEquipoLimp.Location = New Point(34, 100)
        grpDatosEquipoLimp.Name = "grpDatosEquipoLimp"
        grpDatosEquipoLimp.Size = New Size(432, 288)
        grpDatosEquipoLimp.TabIndex = 12
        grpDatosEquipoLimp.TabStop = False
        grpDatosEquipoLimp.Text = "Información de Equipo"
        ' 
        ' cbxCatEquipo
        ' 
        cbxCatEquipo.FormattingEnabled = True
        cbxCatEquipo.Location = New Point(89, 100)
        cbxCatEquipo.Name = "cbxCatEquipo"
        cbxCatEquipo.Size = New Size(206, 28)
        cbxCatEquipo.TabIndex = 12
        ' 
        ' cbxMarcaEquipo
        ' 
        cbxMarcaEquipo.FormattingEnabled = True
        cbxMarcaEquipo.Location = New Point(65, 137)
        cbxMarcaEquipo.Name = "cbxMarcaEquipo"
        cbxMarcaEquipo.Size = New Size(201, 28)
        cbxMarcaEquipo.TabIndex = 11
        ' 
        ' lblMarcaEquipo
        ' 
        lblMarcaEquipo.AutoSize = True
        lblMarcaEquipo.Location = New Point(6, 145)
        lblMarcaEquipo.Name = "lblMarcaEquipo"
        lblMarcaEquipo.Size = New Size(53, 20)
        lblMarcaEquipo.TabIndex = 10
        lblMarcaEquipo.Text = "Marca:"
        ' 
        ' btnBuscarEquipo
        ' 
        btnBuscarEquipo.Location = New Point(326, 28)
        btnBuscarEquipo.Name = "btnBuscarEquipo"
        btnBuscarEquipo.Size = New Size(73, 29)
        btnBuscarEquipo.TabIndex = 9
        btnBuscarEquipo.Text = "Buscar"
        btnBuscarEquipo.UseVisualStyleBackColor = True
        ' 
        ' txtSerialEquipo
        ' 
        txtSerialEquipo.Location = New Point(61, 244)
        txtSerialEquipo.Name = "txtSerialEquipo"
        txtSerialEquipo.Size = New Size(196, 27)
        txtSerialEquipo.TabIndex = 7
        ' 
        ' lblSerialEquipo
        ' 
        lblSerialEquipo.AutoSize = True
        lblSerialEquipo.Location = New Point(6, 251)
        lblSerialEquipo.Name = "lblSerialEquipo"
        lblSerialEquipo.Size = New Size(49, 20)
        lblSerialEquipo.TabIndex = 6
        lblSerialEquipo.Text = "Serial:"
        ' 
        ' lblCatEquipo
        ' 
        lblCatEquipo.AutoSize = True
        lblCatEquipo.Location = New Point(6, 108)
        lblCatEquipo.Name = "lblCatEquipo"
        lblCatEquipo.Size = New Size(77, 20)
        lblCatEquipo.TabIndex = 2
        lblCatEquipo.Text = "Categoría:"
        ' 
        ' txtDescripEquipo
        ' 
        txtDescripEquipo.Location = New Point(99, 207)
        txtDescripEquipo.Name = "txtDescripEquipo"
        txtDescripEquipo.Size = New Size(181, 27)
        txtDescripEquipo.TabIndex = 2
        ' 
        ' lblDescripEquipo
        ' 
        lblDescripEquipo.AutoSize = True
        lblDescripEquipo.Location = New Point(6, 215)
        lblDescripEquipo.Name = "lblDescripEquipo"
        lblDescripEquipo.Size = New Size(90, 20)
        lblDescripEquipo.TabIndex = 2
        lblDescripEquipo.Text = "Descripción:"
        ' 
        ' txtPrecioEquipo
        ' 
        txtPrecioEquipo.Location = New Point(65, 174)
        txtPrecioEquipo.Name = "txtPrecioEquipo"
        txtPrecioEquipo.Size = New Size(186, 27)
        txtPrecioEquipo.TabIndex = 5
        ' 
        ' lblPrecioEquipo
        ' 
        lblPrecioEquipo.AutoSize = True
        lblPrecioEquipo.Location = New Point(6, 181)
        lblPrecioEquipo.Name = "lblPrecioEquipo"
        lblPrecioEquipo.Size = New Size(53, 20)
        lblPrecioEquipo.TabIndex = 4
        lblPrecioEquipo.Text = "Precio:"
        ' 
        ' txtNombreEquipo
        ' 
        txtNombreEquipo.Location = New Point(79, 64)
        txtNombreEquipo.Name = "txtNombreEquipo"
        txtNombreEquipo.Size = New Size(241, 27)
        txtNombreEquipo.TabIndex = 2
        ' 
        ' lblNombreEquipo
        ' 
        lblNombreEquipo.AutoSize = True
        lblNombreEquipo.Location = New Point(6, 71)
        lblNombreEquipo.Name = "lblNombreEquipo"
        lblNombreEquipo.Size = New Size(67, 20)
        lblNombreEquipo.TabIndex = 3
        lblNombreEquipo.Text = "Nombre:"
        ' 
        ' txtIdEquipo
        ' 
        txtIdEquipo.Location = New Point(115, 29)
        txtIdEquipo.Name = "txtIdEquipo"
        txtIdEquipo.Size = New Size(200, 27)
        txtIdEquipo.TabIndex = 2
        ' 
        ' lblIdEquipo
        ' 
        lblIdEquipo.AutoSize = True
        lblIdEquipo.Location = New Point(6, 35)
        lblIdEquipo.Name = "lblIdEquipo"
        lblIdEquipo.Size = New Size(103, 20)
        lblIdEquipo.TabIndex = 2
        lblIdEquipo.Text = "ID del Equipo:"
        ' 
        ' lblNombFormEquipoLimp
        ' 
        lblNombFormEquipoLimp.AutoSize = True
        lblNombFormEquipoLimp.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormEquipoLimp.Location = New Point(489, 20)
        lblNombFormEquipoLimp.Name = "lblNombFormEquipoLimp"
        lblNombFormEquipoLimp.Size = New Size(471, 41)
        lblNombFormEquipoLimp.TabIndex = 11
        lblNombFormEquipoLimp.Text = "Formulario de Equipo de Limpieza"
        ' 
        ' FormularioEquipoLimpieza
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 516)
        Controls.Add(dtgEquipo)
        Controls.Add(btnEliminarEquipo)
        Controls.Add(btnModificarEquipo)
        Controls.Add(btnAgregarEquipo)
        Controls.Add(grpDatosEquipoLimp)
        Controls.Add(lblNombFormEquipoLimp)
        Name = "FormularioEquipoLimpieza"
        Text = "Equipo de Limpieza"
        CType(dtgEquipo, ComponentModel.ISupportInitialize).EndInit()
        grpDatosEquipoLimp.ResumeLayout(False)
        grpDatosEquipoLimp.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtgEquipo As DataGridView
    Friend WithEvents btnEliminarEquipo As Button
    Friend WithEvents btnModificarEquipo As Button
    Friend WithEvents btnAgregarEquipo As Button
    Friend WithEvents grpDatosEquipoLimp As GroupBox
    Friend WithEvents cbxCatEquipo As ComboBox
    Friend WithEvents cbxMarcaEquipo As ComboBox
    Friend WithEvents lblMarcaEquipo As Label
    Friend WithEvents btnBuscarEquipo As Button
    Friend WithEvents txtSerialEquipo As TextBox
    Friend WithEvents lblSerialEquipo As Label
    Friend WithEvents lblCatEquipo As Label
    Friend WithEvents txtDescripEquipo As TextBox
    Friend WithEvents lblDescripEquipo As Label
    Friend WithEvents txtPrecioEquipo As TextBox
    Friend WithEvents lblPrecioEquipo As Label
    Friend WithEvents txtNombreEquipo As TextBox
    Friend WithEvents lblNombreEquipo As Label
    Friend WithEvents txtIdEquipo As TextBox
    Friend WithEvents lblIdEquipo As Label
    Friend WithEvents lblNombFormEquipoLimp As Label
End Class

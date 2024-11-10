<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioUtensilios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioUtensilios))
        btnEliminarUtensilio = New Button()
        btnModificarUtensilio = New Button()
        btnAgregarUtensilio = New Button()
        grpDatosUtensilio = New GroupBox()
        cbxCatUtensilio = New ComboBox()
        cbxMatUtensilio = New ComboBox()
        lblMatUtensilio = New Label()
        btnBuscarUtensilio = New Button()
        txtSerialUtensilio = New TextBox()
        lblSerialUtensilio = New Label()
        lblCatUtensilio = New Label()
        txtDescripUtensilio = New TextBox()
        lblDescripUtensilio = New Label()
        txtPrecioUtensilio = New TextBox()
        lblPrecioUtensilio = New Label()
        txtNombreUtensilio = New TextBox()
        lblNombreUtensilio = New Label()
        txtIdMob = New TextBox()
        lblIdUtensilio = New Label()
        lblNombFormUtensilios = New Label()
        dtgUtensilios = New DataGridView()
        lblMarcaUtensilio = New Label()
        cbxMarcaUtensilio = New ComboBox()
        grpDatosUtensilio.SuspendLayout()
        CType(dtgUtensilios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnEliminarUtensilio
        ' 
        btnEliminarUtensilio.Image = CType(resources.GetObject("btnEliminarUtensilio.Image"), Image)
        btnEliminarUtensilio.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarUtensilio.Location = New Point(326, 422)
        btnEliminarUtensilio.Name = "btnEliminarUtensilio"
        btnEliminarUtensilio.Size = New Size(94, 44)
        btnEliminarUtensilio.TabIndex = 9
        btnEliminarUtensilio.Text = "Eliminar"
        btnEliminarUtensilio.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarUtensilio.UseVisualStyleBackColor = True
        ' 
        ' btnModificarUtensilio
        ' 
        btnModificarUtensilio.Image = CType(resources.GetObject("btnModificarUtensilio.Image"), Image)
        btnModificarUtensilio.ImageAlign = ContentAlignment.MiddleRight
        btnModificarUtensilio.Location = New Point(176, 422)
        btnModificarUtensilio.Name = "btnModificarUtensilio"
        btnModificarUtensilio.Size = New Size(102, 44)
        btnModificarUtensilio.TabIndex = 8
        btnModificarUtensilio.Text = "Modificar"
        btnModificarUtensilio.TextAlign = ContentAlignment.MiddleLeft
        btnModificarUtensilio.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarUtensilio
        ' 
        btnAgregarUtensilio.Image = CType(resources.GetObject("btnAgregarUtensilio.Image"), Image)
        btnAgregarUtensilio.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarUtensilio.Location = New Point(27, 422)
        btnAgregarUtensilio.Name = "btnAgregarUtensilio"
        btnAgregarUtensilio.Size = New Size(94, 44)
        btnAgregarUtensilio.TabIndex = 7
        btnAgregarUtensilio.Text = "Agregar"
        btnAgregarUtensilio.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarUtensilio.UseVisualStyleBackColor = True
        ' 
        ' grpDatosUtensilio
        ' 
        grpDatosUtensilio.Controls.Add(cbxMarcaUtensilio)
        grpDatosUtensilio.Controls.Add(lblMarcaUtensilio)
        grpDatosUtensilio.Controls.Add(cbxCatUtensilio)
        grpDatosUtensilio.Controls.Add(cbxMatUtensilio)
        grpDatosUtensilio.Controls.Add(lblMatUtensilio)
        grpDatosUtensilio.Controls.Add(btnBuscarUtensilio)
        grpDatosUtensilio.Controls.Add(txtSerialUtensilio)
        grpDatosUtensilio.Controls.Add(lblSerialUtensilio)
        grpDatosUtensilio.Controls.Add(lblCatUtensilio)
        grpDatosUtensilio.Controls.Add(txtDescripUtensilio)
        grpDatosUtensilio.Controls.Add(lblDescripUtensilio)
        grpDatosUtensilio.Controls.Add(txtPrecioUtensilio)
        grpDatosUtensilio.Controls.Add(lblPrecioUtensilio)
        grpDatosUtensilio.Controls.Add(txtNombreUtensilio)
        grpDatosUtensilio.Controls.Add(lblNombreUtensilio)
        grpDatosUtensilio.Controls.Add(txtIdMob)
        grpDatosUtensilio.Controls.Add(lblIdUtensilio)
        grpDatosUtensilio.Location = New Point(21, 81)
        grpDatosUtensilio.Name = "grpDatosUtensilio"
        grpDatosUtensilio.Size = New Size(432, 324)
        grpDatosUtensilio.TabIndex = 6
        grpDatosUtensilio.TabStop = False
        grpDatosUtensilio.Text = "Información de Utensilios"
        ' 
        ' cbxCatUtensilio
        ' 
        cbxCatUtensilio.FormattingEnabled = True
        cbxCatUtensilio.Location = New Point(89, 100)
        cbxCatUtensilio.Name = "cbxCatUtensilio"
        cbxCatUtensilio.Size = New Size(206, 28)
        cbxCatUtensilio.TabIndex = 12
        ' 
        ' cbxMatUtensilio
        ' 
        cbxMatUtensilio.FormattingEnabled = True
        cbxMatUtensilio.Location = New Point(79, 137)
        cbxMatUtensilio.Name = "cbxMatUtensilio"
        cbxMatUtensilio.Size = New Size(201, 28)
        cbxMatUtensilio.TabIndex = 11
        ' 
        ' lblMatUtensilio
        ' 
        lblMatUtensilio.AutoSize = True
        lblMatUtensilio.Location = New Point(6, 145)
        lblMatUtensilio.Name = "lblMatUtensilio"
        lblMatUtensilio.Size = New Size(67, 20)
        lblMatUtensilio.TabIndex = 10
        lblMatUtensilio.Text = "Material:"
        ' 
        ' btnBuscarUtensilio
        ' 
        btnBuscarUtensilio.Location = New Point(326, 28)
        btnBuscarUtensilio.Name = "btnBuscarUtensilio"
        btnBuscarUtensilio.Size = New Size(73, 29)
        btnBuscarUtensilio.TabIndex = 9
        btnBuscarUtensilio.Text = "Buscar"
        btnBuscarUtensilio.UseVisualStyleBackColor = True
        ' 
        ' txtSerialUtensilio
        ' 
        txtSerialUtensilio.Location = New Point(61, 276)
        txtSerialUtensilio.Name = "txtSerialUtensilio"
        txtSerialUtensilio.Size = New Size(196, 27)
        txtSerialUtensilio.TabIndex = 7
        ' 
        ' lblSerialUtensilio
        ' 
        lblSerialUtensilio.AutoSize = True
        lblSerialUtensilio.Location = New Point(6, 283)
        lblSerialUtensilio.Name = "lblSerialUtensilio"
        lblSerialUtensilio.Size = New Size(49, 20)
        lblSerialUtensilio.TabIndex = 6
        lblSerialUtensilio.Text = "Serial:"
        ' 
        ' lblCatUtensilio
        ' 
        lblCatUtensilio.AutoSize = True
        lblCatUtensilio.Location = New Point(6, 108)
        lblCatUtensilio.Name = "lblCatUtensilio"
        lblCatUtensilio.Size = New Size(77, 20)
        lblCatUtensilio.TabIndex = 2
        lblCatUtensilio.Text = "Categoría:"
        ' 
        ' txtDescripUtensilio
        ' 
        txtDescripUtensilio.Location = New Point(99, 239)
        txtDescripUtensilio.Name = "txtDescripUtensilio"
        txtDescripUtensilio.Size = New Size(181, 27)
        txtDescripUtensilio.TabIndex = 2
        ' 
        ' lblDescripUtensilio
        ' 
        lblDescripUtensilio.AutoSize = True
        lblDescripUtensilio.Location = New Point(6, 246)
        lblDescripUtensilio.Name = "lblDescripUtensilio"
        lblDescripUtensilio.Size = New Size(90, 20)
        lblDescripUtensilio.TabIndex = 2
        lblDescripUtensilio.Text = "Descripción:"
        ' 
        ' txtPrecioUtensilio
        ' 
        txtPrecioUtensilio.Location = New Point(61, 205)
        txtPrecioUtensilio.Name = "txtPrecioUtensilio"
        txtPrecioUtensilio.Size = New Size(186, 27)
        txtPrecioUtensilio.TabIndex = 5
        ' 
        ' lblPrecioUtensilio
        ' 
        lblPrecioUtensilio.AutoSize = True
        lblPrecioUtensilio.Location = New Point(6, 212)
        lblPrecioUtensilio.Name = "lblPrecioUtensilio"
        lblPrecioUtensilio.Size = New Size(53, 20)
        lblPrecioUtensilio.TabIndex = 4
        lblPrecioUtensilio.Text = "Precio:"
        ' 
        ' txtNombreUtensilio
        ' 
        txtNombreUtensilio.Location = New Point(79, 64)
        txtNombreUtensilio.Name = "txtNombreUtensilio"
        txtNombreUtensilio.Size = New Size(241, 27)
        txtNombreUtensilio.TabIndex = 2
        ' 
        ' lblNombreUtensilio
        ' 
        lblNombreUtensilio.AutoSize = True
        lblNombreUtensilio.Location = New Point(6, 71)
        lblNombreUtensilio.Name = "lblNombreUtensilio"
        lblNombreUtensilio.Size = New Size(67, 20)
        lblNombreUtensilio.TabIndex = 3
        lblNombreUtensilio.Text = "Nombre:"
        ' 
        ' txtIdMob
        ' 
        txtIdMob.Location = New Point(120, 28)
        txtIdMob.Name = "txtIdMob"
        txtIdMob.Size = New Size(200, 27)
        txtIdMob.TabIndex = 2
        ' 
        ' lblIdUtensilio
        ' 
        lblIdUtensilio.AutoSize = True
        lblIdUtensilio.Location = New Point(6, 35)
        lblIdUtensilio.Name = "lblIdUtensilio"
        lblIdUtensilio.Size = New Size(114, 20)
        lblIdUtensilio.TabIndex = 2
        lblIdUtensilio.Text = "ID del Utensilio:"
        ' 
        ' lblNombFormUtensilios
        ' 
        lblNombFormUtensilios.AutoSize = True
        lblNombFormUtensilios.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormUtensilios.Location = New Point(491, 9)
        lblNombFormUtensilios.Name = "lblNombFormUtensilios"
        lblNombFormUtensilios.Size = New Size(340, 41)
        lblNombFormUtensilios.TabIndex = 5
        lblNombFormUtensilios.Text = "Formulario de Utensilios"
        ' 
        ' dtgUtensilios
        ' 
        dtgUtensilios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgUtensilios.Location = New Point(491, 81)
        dtgUtensilios.Name = "dtgUtensilios"
        dtgUtensilios.RowHeadersWidth = 51
        dtgUtensilios.Size = New Size(825, 324)
        dtgUtensilios.TabIndex = 10
        ' 
        ' lblMarcaUtensilio
        ' 
        lblMarcaUtensilio.AutoSize = True
        lblMarcaUtensilio.Location = New Point(6, 177)
        lblMarcaUtensilio.Name = "lblMarcaUtensilio"
        lblMarcaUtensilio.Size = New Size(53, 20)
        lblMarcaUtensilio.TabIndex = 13
        lblMarcaUtensilio.Text = "Marca:"
        ' 
        ' cbxMarcaUtensilio
        ' 
        cbxMarcaUtensilio.FormattingEnabled = True
        cbxMarcaUtensilio.Location = New Point(61, 169)
        cbxMarcaUtensilio.Name = "cbxMarcaUtensilio"
        cbxMarcaUtensilio.Size = New Size(151, 28)
        cbxMarcaUtensilio.TabIndex = 14
        ' 
        ' FormularioUtensilios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1347, 501)
        Controls.Add(dtgUtensilios)
        Controls.Add(btnEliminarUtensilio)
        Controls.Add(btnModificarUtensilio)
        Controls.Add(btnAgregarUtensilio)
        Controls.Add(grpDatosUtensilio)
        Controls.Add(lblNombFormUtensilios)
        Name = "FormularioUtensilios"
        Text = "Utensilios"
        grpDatosUtensilio.ResumeLayout(False)
        grpDatosUtensilio.PerformLayout()
        CType(dtgUtensilios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEliminarUtensilio As Button
    Friend WithEvents btnModificarUtensilio As Button
    Friend WithEvents btnAgregarUtensilio As Button
    Friend WithEvents grpDatosUtensilio As GroupBox
    Friend WithEvents btnBuscarUtensilio As Button
    Friend WithEvents txtSerialUtensilio As TextBox
    Friend WithEvents lblSerialUtensilio As Label
    Friend WithEvents lblCatUtensilio As Label
    Friend WithEvents txtDescripUtensilio As TextBox
    Friend WithEvents lblDescripUtensilio As Label
    Friend WithEvents txtPrecioUtensilio As TextBox
    Friend WithEvents lblPrecioUtensilio As Label
    Friend WithEvents txtNombreUtensilio As TextBox
    Friend WithEvents lblNombreUtensilio As Label
    Friend WithEvents txtIdMob As TextBox
    Friend WithEvents lblIdUtensilio As Label
    Friend WithEvents lblNombFormUtensilios As Label
    Friend WithEvents lblMatUtensilio As Label
    Friend WithEvents cbxCatUtensilio As ComboBox
    Friend WithEvents cbxMatUtensilio As ComboBox
    Friend WithEvents dtgUtensilios As DataGridView
    Friend WithEvents cbxMarcaUtensilio As ComboBox
    Friend WithEvents lblMarcaUtensilio As Label
End Class

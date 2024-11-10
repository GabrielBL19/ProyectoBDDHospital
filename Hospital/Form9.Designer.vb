<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioFarmacia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioFarmacia))
        dtgFarmaco = New DataGridView()
        btnEliminarFarmaco = New Button()
        btnModificarFarmaco = New Button()
        btnAgregarFarmaco = New Button()
        grpDatosUtensilio = New GroupBox()
        dtpCaducidadFarmaco = New DateTimePicker()
        lblCaducidadFarmaco = New Label()
        mskLoteFarmaco = New MaskedTextBox()
        lblLoteFarmaco = New Label()
        cbxCatFarmaco = New ComboBox()
        btnBuscarFarmaco = New Button()
        lblCatFarmaco = New Label()
        txtDescripFarmaco = New TextBox()
        lblDescripFarmaco = New Label()
        txtPrecioFarmaco = New TextBox()
        lblPrecioFarmaco = New Label()
        txtNombreFarmaco = New TextBox()
        lblNombreFarmaco = New Label()
        txtIdFarmaco = New TextBox()
        lblIdUtensilio = New Label()
        lblNombFormFarmacia = New Label()
        lblMarcaFarmaco = New Label()
        cbxMarcaFarmaco = New ComboBox()
        CType(dtgFarmaco, ComponentModel.ISupportInitialize).BeginInit()
        grpDatosUtensilio.SuspendLayout()
        SuspendLayout()
        ' 
        ' dtgFarmaco
        ' 
        dtgFarmaco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgFarmaco.Location = New Point(491, 81)
        dtgFarmaco.Name = "dtgFarmaco"
        dtgFarmaco.RowHeadersWidth = 51
        dtgFarmaco.Size = New Size(825, 324)
        dtgFarmaco.TabIndex = 16
        ' 
        ' btnEliminarFarmaco
        ' 
        btnEliminarFarmaco.Image = CType(resources.GetObject("btnEliminarFarmaco.Image"), Image)
        btnEliminarFarmaco.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarFarmaco.Location = New Point(347, 408)
        btnEliminarFarmaco.Name = "btnEliminarFarmaco"
        btnEliminarFarmaco.Size = New Size(94, 44)
        btnEliminarFarmaco.TabIndex = 15
        btnEliminarFarmaco.Text = "Eliminar"
        btnEliminarFarmaco.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarFarmaco.UseVisualStyleBackColor = True
        ' 
        ' btnModificarFarmaco
        ' 
        btnModificarFarmaco.Image = CType(resources.GetObject("btnModificarFarmaco.Image"), Image)
        btnModificarFarmaco.ImageAlign = ContentAlignment.MiddleRight
        btnModificarFarmaco.Location = New Point(200, 408)
        btnModificarFarmaco.Name = "btnModificarFarmaco"
        btnModificarFarmaco.Size = New Size(104, 44)
        btnModificarFarmaco.TabIndex = 14
        btnModificarFarmaco.Text = "Modificar"
        btnModificarFarmaco.TextAlign = ContentAlignment.MiddleLeft
        btnModificarFarmaco.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarFarmaco
        ' 
        btnAgregarFarmaco.Image = CType(resources.GetObject("btnAgregarFarmaco.Image"), Image)
        btnAgregarFarmaco.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarFarmaco.Location = New Point(45, 408)
        btnAgregarFarmaco.Name = "btnAgregarFarmaco"
        btnAgregarFarmaco.Size = New Size(94, 44)
        btnAgregarFarmaco.TabIndex = 13
        btnAgregarFarmaco.Text = "Agregar"
        btnAgregarFarmaco.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarFarmaco.UseVisualStyleBackColor = True
        ' 
        ' grpDatosUtensilio
        ' 
        grpDatosUtensilio.Controls.Add(cbxMarcaFarmaco)
        grpDatosUtensilio.Controls.Add(lblMarcaFarmaco)
        grpDatosUtensilio.Controls.Add(dtpCaducidadFarmaco)
        grpDatosUtensilio.Controls.Add(lblCaducidadFarmaco)
        grpDatosUtensilio.Controls.Add(mskLoteFarmaco)
        grpDatosUtensilio.Controls.Add(lblLoteFarmaco)
        grpDatosUtensilio.Controls.Add(cbxCatFarmaco)
        grpDatosUtensilio.Controls.Add(btnBuscarFarmaco)
        grpDatosUtensilio.Controls.Add(lblCatFarmaco)
        grpDatosUtensilio.Controls.Add(txtDescripFarmaco)
        grpDatosUtensilio.Controls.Add(lblDescripFarmaco)
        grpDatosUtensilio.Controls.Add(txtPrecioFarmaco)
        grpDatosUtensilio.Controls.Add(lblPrecioFarmaco)
        grpDatosUtensilio.Controls.Add(txtNombreFarmaco)
        grpDatosUtensilio.Controls.Add(lblNombreFarmaco)
        grpDatosUtensilio.Controls.Add(txtIdFarmaco)
        grpDatosUtensilio.Controls.Add(lblIdUtensilio)
        grpDatosUtensilio.Location = New Point(21, 81)
        grpDatosUtensilio.Name = "grpDatosUtensilio"
        grpDatosUtensilio.Size = New Size(432, 321)
        grpDatosUtensilio.TabIndex = 12
        grpDatosUtensilio.TabStop = False
        grpDatosUtensilio.Text = "Información de Mobiliario"
        ' 
        ' dtpCaducidadFarmaco
        ' 
        dtpCaducidadFarmaco.Location = New Point(95, 278)
        dtpCaducidadFarmaco.Name = "dtpCaducidadFarmaco"
        dtpCaducidadFarmaco.Size = New Size(250, 27)
        dtpCaducidadFarmaco.TabIndex = 16
        ' 
        ' lblCaducidadFarmaco
        ' 
        lblCaducidadFarmaco.AutoSize = True
        lblCaducidadFarmaco.Location = New Point(6, 285)
        lblCaducidadFarmaco.Name = "lblCaducidadFarmaco"
        lblCaducidadFarmaco.Size = New Size(83, 20)
        lblCaducidadFarmaco.TabIndex = 15
        lblCaducidadFarmaco.Text = "Caducidad:"
        ' 
        ' mskLoteFarmaco
        ' 
        mskLoteFarmaco.Location = New Point(53, 239)
        mskLoteFarmaco.Name = "mskLoteFarmaco"
        mskLoteFarmaco.Size = New Size(184, 27)
        mskLoteFarmaco.TabIndex = 14
        ' 
        ' lblLoteFarmaco
        ' 
        lblLoteFarmaco.AutoSize = True
        lblLoteFarmaco.Location = New Point(6, 246)
        lblLoteFarmaco.Name = "lblLoteFarmaco"
        lblLoteFarmaco.Size = New Size(41, 20)
        lblLoteFarmaco.TabIndex = 13
        lblLoteFarmaco.Text = "Lote:"
        ' 
        ' cbxCatFarmaco
        ' 
        cbxCatFarmaco.FormattingEnabled = True
        cbxCatFarmaco.Location = New Point(89, 100)
        cbxCatFarmaco.Name = "cbxCatFarmaco"
        cbxCatFarmaco.Size = New Size(206, 28)
        cbxCatFarmaco.TabIndex = 12
        ' 
        ' btnBuscarFarmaco
        ' 
        btnBuscarFarmaco.Location = New Point(326, 28)
        btnBuscarFarmaco.Name = "btnBuscarFarmaco"
        btnBuscarFarmaco.Size = New Size(73, 29)
        btnBuscarFarmaco.TabIndex = 9
        btnBuscarFarmaco.Text = "Buscar"
        btnBuscarFarmaco.UseVisualStyleBackColor = True
        ' 
        ' lblCatFarmaco
        ' 
        lblCatFarmaco.AutoSize = True
        lblCatFarmaco.Location = New Point(6, 108)
        lblCatFarmaco.Name = "lblCatFarmaco"
        lblCatFarmaco.Size = New Size(77, 20)
        lblCatFarmaco.TabIndex = 2
        lblCatFarmaco.Text = "Categoría:"
        ' 
        ' txtDescripFarmaco
        ' 
        txtDescripFarmaco.Location = New Point(102, 200)
        txtDescripFarmaco.Name = "txtDescripFarmaco"
        txtDescripFarmaco.Size = New Size(181, 27)
        txtDescripFarmaco.TabIndex = 2
        ' 
        ' lblDescripFarmaco
        ' 
        lblDescripFarmaco.AutoSize = True
        lblDescripFarmaco.Location = New Point(6, 207)
        lblDescripFarmaco.Name = "lblDescripFarmaco"
        lblDescripFarmaco.Size = New Size(90, 20)
        lblDescripFarmaco.TabIndex = 2
        lblDescripFarmaco.Text = "Descripción:"
        ' 
        ' txtPrecioFarmaco
        ' 
        txtPrecioFarmaco.Location = New Point(65, 167)
        txtPrecioFarmaco.Name = "txtPrecioFarmaco"
        txtPrecioFarmaco.Size = New Size(186, 27)
        txtPrecioFarmaco.TabIndex = 5
        ' 
        ' lblPrecioFarmaco
        ' 
        lblPrecioFarmaco.AutoSize = True
        lblPrecioFarmaco.Location = New Point(6, 175)
        lblPrecioFarmaco.Name = "lblPrecioFarmaco"
        lblPrecioFarmaco.Size = New Size(53, 20)
        lblPrecioFarmaco.TabIndex = 4
        lblPrecioFarmaco.Text = "Precio:"
        ' 
        ' txtNombreFarmaco
        ' 
        txtNombreFarmaco.Location = New Point(79, 64)
        txtNombreFarmaco.Name = "txtNombreFarmaco"
        txtNombreFarmaco.Size = New Size(241, 27)
        txtNombreFarmaco.TabIndex = 2
        ' 
        ' lblNombreFarmaco
        ' 
        lblNombreFarmaco.AutoSize = True
        lblNombreFarmaco.Location = New Point(6, 71)
        lblNombreFarmaco.Name = "lblNombreFarmaco"
        lblNombreFarmaco.Size = New Size(67, 20)
        lblNombreFarmaco.TabIndex = 3
        lblNombreFarmaco.Text = "Nombre:"
        ' 
        ' txtIdFarmaco
        ' 
        txtIdFarmaco.Location = New Point(120, 28)
        txtIdFarmaco.Name = "txtIdFarmaco"
        txtIdFarmaco.Size = New Size(200, 27)
        txtIdFarmaco.TabIndex = 2
        ' 
        ' lblIdUtensilio
        ' 
        lblIdUtensilio.AutoSize = True
        lblIdUtensilio.Location = New Point(6, 35)
        lblIdUtensilio.Name = "lblIdUtensilio"
        lblIdUtensilio.Size = New Size(112, 20)
        lblIdUtensilio.TabIndex = 2
        lblIdUtensilio.Text = "ID del Fármaco:"
        ' 
        ' lblNombFormFarmacia
        ' 
        lblNombFormFarmacia.AutoSize = True
        lblNombFormFarmacia.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormFarmacia.Location = New Point(517, 9)
        lblNombFormFarmacia.Name = "lblNombFormFarmacia"
        lblNombFormFarmacia.Size = New Size(327, 41)
        lblNombFormFarmacia.TabIndex = 11
        lblNombFormFarmacia.Text = "Formulario de Farmacia"
        ' 
        ' lblMarcaFarmaco
        ' 
        lblMarcaFarmaco.AutoSize = True
        lblMarcaFarmaco.Location = New Point(6, 142)
        lblMarcaFarmaco.Name = "lblMarcaFarmaco"
        lblMarcaFarmaco.Size = New Size(53, 20)
        lblMarcaFarmaco.TabIndex = 17
        lblMarcaFarmaco.Text = "Marca:"
        ' 
        ' cbxMarcaFarmaco
        ' 
        cbxMarcaFarmaco.FormattingEnabled = True
        cbxMarcaFarmaco.Location = New Point(65, 134)
        cbxMarcaFarmaco.Name = "cbxMarcaFarmaco"
        cbxMarcaFarmaco.Size = New Size(186, 28)
        cbxMarcaFarmaco.TabIndex = 18
        ' 
        ' FormularioFarmacia
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1336, 505)
        Controls.Add(dtgFarmaco)
        Controls.Add(btnEliminarFarmaco)
        Controls.Add(btnModificarFarmaco)
        Controls.Add(btnAgregarFarmaco)
        Controls.Add(grpDatosUtensilio)
        Controls.Add(lblNombFormFarmacia)
        Name = "FormularioFarmacia"
        Text = "Farmacia"
        CType(dtgFarmaco, ComponentModel.ISupportInitialize).EndInit()
        grpDatosUtensilio.ResumeLayout(False)
        grpDatosUtensilio.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtgFarmaco As DataGridView
    Friend WithEvents btnEliminarFarmaco As Button
    Friend WithEvents btnModificarFarmaco As Button
    Friend WithEvents btnAgregarFarmaco As Button
    Friend WithEvents grpDatosUtensilio As GroupBox
    Friend WithEvents lblLoteFarmaco As Label
    Friend WithEvents cbxCatFarmaco As ComboBox
    Friend WithEvents btnBuscarFarmaco As Button
    Friend WithEvents lblCatFarmaco As Label
    Friend WithEvents txtDescripFarmaco As TextBox
    Friend WithEvents lblDescripFarmaco As Label
    Friend WithEvents txtPrecioFarmaco As TextBox
    Friend WithEvents lblPrecioFarmaco As Label
    Friend WithEvents txtNombreFarmaco As TextBox
    Friend WithEvents lblNombreFarmaco As Label
    Friend WithEvents txtIdFarmaco As TextBox
    Friend WithEvents lblIdUtensilio As Label
    Friend WithEvents lblNombFormFarmacia As Label
    Friend WithEvents dtpCaducidadFarmaco As DateTimePicker
    Friend WithEvents lblCaducidadFarmaco As Label
    Friend WithEvents mskLoteFarmaco As MaskedTextBox
    Friend WithEvents cbxMarcaFarmaco As ComboBox
    Friend WithEvents lblMarcaFarmaco As Label
End Class

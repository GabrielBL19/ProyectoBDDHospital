<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioConsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioConsultas))
        Label1 = New Label()
        grpDatosCita = New GroupBox()
        lblObservacionConsulta = New Label()
        RichTextBox1 = New RichTextBox()
        txtPrecioConsulta = New TextBox()
        lblPrecioConsulta = New Label()
        lblFechaConsulta = New Label()
        DateTimePicker1 = New DateTimePicker()
        txtIdConsultaMedica = New TextBox()
        Label2 = New Label()
        dtgConsultasMedicas = New DataGridView()
        btnGuardarConsulta = New Button()
        btnModificarConsulta = New Button()
        btnEliminarConsulta = New Button()
        grpDatosCita.SuspendLayout()
        CType(dtgConsultasMedicas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(360, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(458, 41)
        Label1.TabIndex = 0
        Label1.Text = "Formulario de Consultas Médicas"
        ' 
        ' grpDatosCita
        ' 
        grpDatosCita.Controls.Add(lblObservacionConsulta)
        grpDatosCita.Controls.Add(RichTextBox1)
        grpDatosCita.Controls.Add(txtPrecioConsulta)
        grpDatosCita.Controls.Add(lblPrecioConsulta)
        grpDatosCita.Controls.Add(lblFechaConsulta)
        grpDatosCita.Controls.Add(DateTimePicker1)
        grpDatosCita.Controls.Add(txtIdConsultaMedica)
        grpDatosCita.Controls.Add(Label2)
        grpDatosCita.Location = New Point(21, 68)
        grpDatosCita.Name = "grpDatosCita"
        grpDatosCita.Size = New Size(436, 276)
        grpDatosCita.TabIndex = 1
        grpDatosCita.TabStop = False
        grpDatosCita.Text = "Datos de la Cita Médica"
        ' 
        ' lblObservacionConsulta
        ' 
        lblObservacionConsulta.AutoSize = True
        lblObservacionConsulta.Location = New Point(6, 144)
        lblObservacionConsulta.Name = "lblObservacionConsulta"
        lblObservacionConsulta.Size = New Size(108, 20)
        lblObservacionConsulta.TabIndex = 7
        lblObservacionConsulta.Text = "Observaciones:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(114, 141)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(296, 120)
        RichTextBox1.TabIndex = 6
        RichTextBox1.Text = ""
        ' 
        ' txtPrecioConsulta
        ' 
        txtPrecioConsulta.Location = New Point(65, 97)
        txtPrecioConsulta.Name = "txtPrecioConsulta"
        txtPrecioConsulta.Size = New Size(134, 27)
        txtPrecioConsulta.TabIndex = 5
        ' 
        ' lblPrecioConsulta
        ' 
        lblPrecioConsulta.AutoSize = True
        lblPrecioConsulta.Location = New Point(6, 104)
        lblPrecioConsulta.Name = "lblPrecioConsulta"
        lblPrecioConsulta.Size = New Size(53, 20)
        lblPrecioConsulta.TabIndex = 4
        lblPrecioConsulta.Text = "Precio:"
        ' 
        ' lblFechaConsulta
        ' 
        lblFechaConsulta.AutoSize = True
        lblFechaConsulta.Location = New Point(6, 71)
        lblFechaConsulta.Name = "lblFechaConsulta"
        lblFechaConsulta.Size = New Size(148, 20)
        lblFechaConsulta.TabIndex = 3
        lblFechaConsulta.Text = "Fecha de la Consulta:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(160, 64)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 2
        ' 
        ' txtIdConsultaMedica
        ' 
        txtIdConsultaMedica.Location = New Point(153, 26)
        txtIdConsultaMedica.Name = "txtIdConsultaMedica"
        txtIdConsultaMedica.Size = New Size(199, 27)
        txtIdConsultaMedica.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 20)
        Label2.TabIndex = 0
        Label2.Text = "ID Consulta Médica:"
        ' 
        ' dtgConsultasMedicas
        ' 
        dtgConsultasMedicas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgConsultasMedicas.Location = New Point(489, 72)
        dtgConsultasMedicas.Name = "dtgConsultasMedicas"
        dtgConsultasMedicas.RowHeadersWidth = 51
        dtgConsultasMedicas.Size = New Size(675, 272)
        dtgConsultasMedicas.TabIndex = 2
        ' 
        ' btnGuardarConsulta
        ' 
        btnGuardarConsulta.Image = CType(resources.GetObject("btnGuardarConsulta.Image"), Image)
        btnGuardarConsulta.ImageAlign = ContentAlignment.MiddleRight
        btnGuardarConsulta.Location = New Point(12, 359)
        btnGuardarConsulta.Name = "btnGuardarConsulta"
        btnGuardarConsulta.Size = New Size(156, 36)
        btnGuardarConsulta.TabIndex = 3
        btnGuardarConsulta.Text = "Guardar Consulta"
        btnGuardarConsulta.TextAlign = ContentAlignment.MiddleLeft
        btnGuardarConsulta.UseVisualStyleBackColor = True
        ' 
        ' btnModificarConsulta
        ' 
        btnModificarConsulta.Image = CType(resources.GetObject("btnModificarConsulta.Image"), Image)
        btnModificarConsulta.ImageAlign = ContentAlignment.MiddleRight
        btnModificarConsulta.Location = New Point(197, 359)
        btnModificarConsulta.Name = "btnModificarConsulta"
        btnModificarConsulta.Size = New Size(162, 36)
        btnModificarConsulta.TabIndex = 4
        btnModificarConsulta.Text = "Modificar Consulta"
        btnModificarConsulta.TextAlign = ContentAlignment.MiddleLeft
        btnModificarConsulta.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarConsulta
        ' 
        btnEliminarConsulta.Image = CType(resources.GetObject("btnEliminarConsulta.Image"), Image)
        btnEliminarConsulta.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarConsulta.Location = New Point(379, 359)
        btnEliminarConsulta.Name = "btnEliminarConsulta"
        btnEliminarConsulta.Size = New Size(158, 36)
        btnEliminarConsulta.TabIndex = 5
        btnEliminarConsulta.Text = "Eliminar Consulta"
        btnEliminarConsulta.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarConsulta.UseVisualStyleBackColor = True
        ' 
        ' FormularioConsultas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1191, 482)
        Controls.Add(btnEliminarConsulta)
        Controls.Add(btnModificarConsulta)
        Controls.Add(btnGuardarConsulta)
        Controls.Add(dtgConsultasMedicas)
        Controls.Add(grpDatosCita)
        Controls.Add(Label1)
        Name = "FormularioConsultas"
        Text = "Consultas Médicas"
        grpDatosCita.ResumeLayout(False)
        grpDatosCita.PerformLayout()
        CType(dtgConsultasMedicas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpDatosCita As GroupBox
    Friend WithEvents txtIdConsultaMedica As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblObservacionConsulta As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtPrecioConsulta As TextBox
    Friend WithEvents lblPrecioConsulta As Label
    Friend WithEvents lblFechaConsulta As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dtgConsultasMedicas As DataGridView
    Friend WithEvents btnGuardarConsulta As Button
    Friend WithEvents btnModificarConsulta As Button
    Friend WithEvents btnEliminarConsulta As Button
End Class

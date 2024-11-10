<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioCitasMedicas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioCitasMedicas))
        lblNombFormCitasMed = New Label()
        grpDatosCita = New GroupBox()
        lblHoraCita = New Label()
        dtpHoraCita = New DateTimePicker()
        lblFechaCita = New Label()
        dtpFechaCita = New DateTimePicker()
        TextBox1 = New TextBox()
        lblIdCitaMed = New Label()
        btnAgendarCita = New Button()
        btnModificarCita = New Button()
        btnEliminarCita = New Button()
        dtgCitas = New DataGridView()
        grpDatosCita.SuspendLayout()
        CType(dtgCitas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNombFormCitasMed
        ' 
        lblNombFormCitasMed.AutoSize = True
        lblNombFormCitasMed.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormCitasMed.Location = New Point(425, 9)
        lblNombFormCitasMed.Name = "lblNombFormCitasMed"
        lblNombFormCitasMed.Size = New Size(393, 41)
        lblNombFormCitasMed.TabIndex = 0
        lblNombFormCitasMed.Text = "Formulario de Citas Médicas"
        ' 
        ' grpDatosCita
        ' 
        grpDatosCita.Controls.Add(lblHoraCita)
        grpDatosCita.Controls.Add(dtpHoraCita)
        grpDatosCita.Controls.Add(lblFechaCita)
        grpDatosCita.Controls.Add(dtpFechaCita)
        grpDatosCita.Controls.Add(TextBox1)
        grpDatosCita.Controls.Add(lblIdCitaMed)
        grpDatosCita.Location = New Point(12, 72)
        grpDatosCita.Name = "grpDatosCita"
        grpDatosCita.Size = New Size(446, 171)
        grpDatosCita.TabIndex = 1
        grpDatosCita.TabStop = False
        grpDatosCita.Text = "Datos de Agenda de Cita Médica"
        ' 
        ' lblHoraCita
        ' 
        lblHoraCita.AutoSize = True
        lblHoraCita.Location = New Point(6, 129)
        lblHoraCita.Name = "lblHoraCita"
        lblHoraCita.Size = New Size(112, 20)
        lblHoraCita.TabIndex = 5
        lblHoraCita.Text = "Hora de la Cita:"
        ' 
        ' dtpHoraCita
        ' 
        dtpHoraCita.Format = DateTimePickerFormat.Time
        dtpHoraCita.Location = New Point(129, 122)
        dtpHoraCita.Name = "dtpHoraCita"
        dtpHoraCita.ShowUpDown = True
        dtpHoraCita.Size = New Size(120, 27)
        dtpHoraCita.TabIndex = 4
        ' 
        ' lblFechaCita
        ' 
        lblFechaCita.AutoSize = True
        lblFechaCita.Location = New Point(6, 80)
        lblFechaCita.Name = "lblFechaCita"
        lblFechaCita.Size = New Size(117, 20)
        lblFechaCita.TabIndex = 3
        lblFechaCita.Text = "Fecha de la Cita:"
        ' 
        ' dtpFechaCita
        ' 
        dtpFechaCita.Location = New Point(129, 73)
        dtpFechaCita.Name = "dtpFechaCita"
        dtpFechaCita.Size = New Size(250, 27)
        dtpFechaCita.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(122, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(197, 27)
        TextBox1.TabIndex = 1
        ' 
        ' lblIdCitaMed
        ' 
        lblIdCitaMed.AutoSize = True
        lblIdCitaMed.Location = New Point(6, 36)
        lblIdCitaMed.Name = "lblIdCitaMed"
        lblIdCitaMed.Size = New Size(110, 20)
        lblIdCitaMed.TabIndex = 0
        lblIdCitaMed.Text = "ID Cita Médica:"
        ' 
        ' btnAgendarCita
        ' 
        btnAgendarCita.Image = CType(resources.GetObject("btnAgendarCita.Image"), Image)
        btnAgendarCita.ImageAlign = ContentAlignment.MiddleRight
        btnAgendarCita.Location = New Point(18, 273)
        btnAgendarCita.Name = "btnAgendarCita"
        btnAgendarCita.Size = New Size(129, 39)
        btnAgendarCita.TabIndex = 2
        btnAgendarCita.Text = "Agendar Cita"
        btnAgendarCita.TextAlign = ContentAlignment.MiddleLeft
        btnAgendarCita.UseVisualStyleBackColor = True
        ' 
        ' btnModificarCita
        ' 
        btnModificarCita.Image = CType(resources.GetObject("btnModificarCita.Image"), Image)
        btnModificarCita.ImageAlign = ContentAlignment.MiddleRight
        btnModificarCita.Location = New Point(162, 273)
        btnModificarCita.Name = "btnModificarCita"
        btnModificarCita.Size = New Size(134, 39)
        btnModificarCita.TabIndex = 3
        btnModificarCita.Text = "Modificar Cita"
        btnModificarCita.TextAlign = ContentAlignment.MiddleLeft
        btnModificarCita.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarCita
        ' 
        btnEliminarCita.Image = CType(resources.GetObject("btnEliminarCita.Image"), Image)
        btnEliminarCita.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarCita.Location = New Point(322, 273)
        btnEliminarCita.Name = "btnEliminarCita"
        btnEliminarCita.Size = New Size(123, 39)
        btnEliminarCita.TabIndex = 4
        btnEliminarCita.Text = "Eliminar Cita"
        btnEliminarCita.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarCita.UseVisualStyleBackColor = True
        ' 
        ' dtgCitas
        ' 
        dtgCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgCitas.Location = New Point(487, 59)
        dtgCitas.Name = "dtgCitas"
        dtgCitas.RowHeadersWidth = 51
        dtgCitas.Size = New Size(746, 264)
        dtgCitas.TabIndex = 5
        ' 
        ' FormularioCitasMedicas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1256, 378)
        Controls.Add(dtgCitas)
        Controls.Add(btnEliminarCita)
        Controls.Add(btnModificarCita)
        Controls.Add(btnAgendarCita)
        Controls.Add(grpDatosCita)
        Controls.Add(lblNombFormCitasMed)
        Name = "FormularioCitasMedicas"
        Text = "Citas Médicas"
        grpDatosCita.ResumeLayout(False)
        grpDatosCita.PerformLayout()
        CType(dtgCitas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombFormCitasMed As Label
    Friend WithEvents grpDatosCita As GroupBox
    Friend WithEvents lblFechaCita As Label
    Friend WithEvents dtpFechaCita As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblIdCitaMed As Label
    Friend WithEvents lblHoraCita As Label
    Friend WithEvents dtpHoraCita As DateTimePicker
    Friend WithEvents btnAgendarCita As Button
    Friend WithEvents btnModificarCita As Button
    Friend WithEvents btnEliminarCita As Button
    Friend WithEvents dtgCitas As DataGridView
End Class

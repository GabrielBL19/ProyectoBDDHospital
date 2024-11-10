<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioMenu))
        MenuStrip1 = New MenuStrip()
        PersonaToolStripMenuItem = New ToolStripMenuItem()
        DoctoresToolStripMenuItem = New ToolStripMenuItem()
        EnfermerosToolStripMenuItem = New ToolStripMenuItem()
        EmpleadosToolStripMenuItem = New ToolStripMenuItem()
        PacientesToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        MobiliarioToolStripMenuItem = New ToolStripMenuItem()
        UtensiliosToolStripMenuItem = New ToolStripMenuItem()
        FarmaciaToolStripMenuItem = New ToolStripMenuItem()
        EquipoDeLimpiezaToolStripMenuItem = New ToolStripMenuItem()
        CitasMédicasToolStripMenuItem = New ToolStripMenuItem()
        ConsultasMédicasToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        PedidosToolStripMenuItem = New ToolStripMenuItem()
        FacturaciónToolStripMenuItem = New ToolStripMenuItem()
        SalasToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PersonaToolStripMenuItem, PacientesToolStripMenuItem, ProductosToolStripMenuItem, CitasMédicasToolStripMenuItem, ConsultasMédicasToolStripMenuItem, ProveedoresToolStripMenuItem, PedidosToolStripMenuItem, FacturaciónToolStripMenuItem, SalasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1484, 39)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PersonaToolStripMenuItem
        ' 
        PersonaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DoctoresToolStripMenuItem, EnfermerosToolStripMenuItem, EmpleadosToolStripMenuItem})
        PersonaToolStripMenuItem.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PersonaToolStripMenuItem.Image = CType(resources.GetObject("PersonaToolStripMenuItem.Image"), Image)
        PersonaToolStripMenuItem.Name = "PersonaToolStripMenuItem"
        PersonaToolStripMenuItem.Size = New Size(128, 35)
        PersonaToolStripMenuItem.Text = "Persona"
        ' 
        ' DoctoresToolStripMenuItem
        ' 
        DoctoresToolStripMenuItem.Image = CType(resources.GetObject("DoctoresToolStripMenuItem.Image"), Image)
        DoctoresToolStripMenuItem.Name = "DoctoresToolStripMenuItem"
        DoctoresToolStripMenuItem.Size = New Size(217, 36)
        DoctoresToolStripMenuItem.Text = "Doctores"
        ' 
        ' EnfermerosToolStripMenuItem
        ' 
        EnfermerosToolStripMenuItem.Image = CType(resources.GetObject("EnfermerosToolStripMenuItem.Image"), Image)
        EnfermerosToolStripMenuItem.Name = "EnfermerosToolStripMenuItem"
        EnfermerosToolStripMenuItem.Size = New Size(217, 36)
        EnfermerosToolStripMenuItem.Text = "Enfermeros"
        ' 
        ' EmpleadosToolStripMenuItem
        ' 
        EmpleadosToolStripMenuItem.Image = CType(resources.GetObject("EmpleadosToolStripMenuItem.Image"), Image)
        EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        EmpleadosToolStripMenuItem.Size = New Size(217, 36)
        EmpleadosToolStripMenuItem.Text = "Empleados"
        ' 
        ' PacientesToolStripMenuItem
        ' 
        PacientesToolStripMenuItem.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PacientesToolStripMenuItem.Image = CType(resources.GetObject("PacientesToolStripMenuItem.Image"), Image)
        PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        PacientesToolStripMenuItem.Size = New Size(144, 35)
        PacientesToolStripMenuItem.Text = "Pacientes"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MobiliarioToolStripMenuItem, UtensiliosToolStripMenuItem, FarmaciaToolStripMenuItem, EquipoDeLimpiezaToolStripMenuItem})
        ProductosToolStripMenuItem.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ProductosToolStripMenuItem.Image = CType(resources.GetObject("ProductosToolStripMenuItem.Image"), Image)
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(151, 35)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' MobiliarioToolStripMenuItem
        ' 
        MobiliarioToolStripMenuItem.Image = CType(resources.GetObject("MobiliarioToolStripMenuItem.Image"), Image)
        MobiliarioToolStripMenuItem.Name = "MobiliarioToolStripMenuItem"
        MobiliarioToolStripMenuItem.Size = New Size(298, 36)
        MobiliarioToolStripMenuItem.Text = "Mobiliario"
        ' 
        ' UtensiliosToolStripMenuItem
        ' 
        UtensiliosToolStripMenuItem.Image = CType(resources.GetObject("UtensiliosToolStripMenuItem.Image"), Image)
        UtensiliosToolStripMenuItem.Name = "UtensiliosToolStripMenuItem"
        UtensiliosToolStripMenuItem.Size = New Size(298, 36)
        UtensiliosToolStripMenuItem.Text = "Utensilios"
        ' 
        ' FarmaciaToolStripMenuItem
        ' 
        FarmaciaToolStripMenuItem.Image = CType(resources.GetObject("FarmaciaToolStripMenuItem.Image"), Image)
        FarmaciaToolStripMenuItem.Name = "FarmaciaToolStripMenuItem"
        FarmaciaToolStripMenuItem.Size = New Size(298, 36)
        FarmaciaToolStripMenuItem.Text = "Farmacia"
        ' 
        ' EquipoDeLimpiezaToolStripMenuItem
        ' 
        EquipoDeLimpiezaToolStripMenuItem.Image = CType(resources.GetObject("EquipoDeLimpiezaToolStripMenuItem.Image"), Image)
        EquipoDeLimpiezaToolStripMenuItem.Name = "EquipoDeLimpiezaToolStripMenuItem"
        EquipoDeLimpiezaToolStripMenuItem.Size = New Size(298, 36)
        EquipoDeLimpiezaToolStripMenuItem.Text = "Equipo de limpieza"
        ' 
        ' CitasMédicasToolStripMenuItem
        ' 
        CitasMédicasToolStripMenuItem.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CitasMédicasToolStripMenuItem.Image = CType(resources.GetObject("CitasMédicasToolStripMenuItem.Image"), Image)
        CitasMédicasToolStripMenuItem.Name = "CitasMédicasToolStripMenuItem"
        CitasMédicasToolStripMenuItem.Size = New Size(190, 35)
        CitasMédicasToolStripMenuItem.Text = "Citas Médicas"
        ' 
        ' ConsultasMédicasToolStripMenuItem
        ' 
        ConsultasMédicasToolStripMenuItem.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ConsultasMédicasToolStripMenuItem.Image = CType(resources.GetObject("ConsultasMédicasToolStripMenuItem.Image"), Image)
        ConsultasMédicasToolStripMenuItem.Name = "ConsultasMédicasToolStripMenuItem"
        ConsultasMédicasToolStripMenuItem.Size = New Size(239, 35)
        ConsultasMédicasToolStripMenuItem.Text = "Consultas Médicas"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ProveedoresToolStripMenuItem.Image = CType(resources.GetObject("ProveedoresToolStripMenuItem.Image"), Image)
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(174, 35)
        ProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' PedidosToolStripMenuItem
        ' 
        PedidosToolStripMenuItem.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PedidosToolStripMenuItem.Image = CType(resources.GetObject("PedidosToolStripMenuItem.Image"), Image)
        PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        PedidosToolStripMenuItem.Size = New Size(129, 35)
        PedidosToolStripMenuItem.Text = "Pedidos"
        ' 
        ' FacturaciónToolStripMenuItem
        ' 
        FacturaciónToolStripMenuItem.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FacturaciónToolStripMenuItem.Image = CType(resources.GetObject("FacturaciónToolStripMenuItem.Image"), Image)
        FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        FacturaciónToolStripMenuItem.Size = New Size(165, 35)
        FacturaciónToolStripMenuItem.Text = "Facturación"
        ' 
        ' SalasToolStripMenuItem
        ' 
        SalasToolStripMenuItem.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SalasToolStripMenuItem.Image = CType(resources.GetObject("SalasToolStripMenuItem.Image"), Image)
        SalasToolStripMenuItem.Name = "SalasToolStripMenuItem"
        SalasToolStripMenuItem.Size = New Size(100, 35)
        SalasToolStripMenuItem.Text = "Salas"
        ' 
        ' FormularioMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1484, 607)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormularioMenu"
        Text = "Menú"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoctoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnfermerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MobiliarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtensiliosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FarmaciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquipoDeLimpiezaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CitasMédicasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasMédicasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalasToolStripMenuItem As ToolStripMenuItem
End Class

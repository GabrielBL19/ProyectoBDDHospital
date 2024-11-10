Public Class FormularioMenu
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub DoctoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctoresToolStripMenuItem.Click
        FormularioDoctores.Show()

    End Sub

    Private Sub EnfermerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnfermerosToolStripMenuItem.Click
        FormularioEnfermeros.Show()

    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        FormularioEmpleados.Show()

    End Sub

    Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem.Click
        FormularioPacientes.Show()

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click

    End Sub

    Private Sub MobiliarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MobiliarioToolStripMenuItem.Click
        FormularioMobiliario.Show()

    End Sub

    Private Sub UtensiliosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtensiliosToolStripMenuItem.Click
        FormularioUtensilios.Show()

    End Sub

    Private Sub FarmaciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FarmaciaToolStripMenuItem.Click
        FormularioFarmacia.Show()

    End Sub

    Private Sub EquipoDeLimpiezaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipoDeLimpiezaToolStripMenuItem.Click
        FormularioEquipoLimpieza.Show()

    End Sub

    Private Sub CitasMédicasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CitasMédicasToolStripMenuItem.Click
        FormularioCitasMedicas.Show()

    End Sub

    Private Sub ConsultasMédicasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasMédicasToolStripMenuItem.Click
        FormularioConsultas.Show()

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FormularioProveedor.Show()

    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click

    End Sub

    Private Sub SalasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalasToolStripMenuItem.Click
        FormularioSalas.Show()

    End Sub
End Class
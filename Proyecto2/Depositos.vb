Public Class Depositos

    Private Sub Depositos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.BackColor = Color.FromArgb(247, 247, 249)
        ConfigurarHistorial()
    End Sub

    Private Sub btnRegistrarDeposito_Click(sender As Object, e As EventArgs) Handles btnRegistrarDeposito.Click
        If String.IsNullOrWhiteSpace(txtMonto.Text) OrElse cmbTipoDeposito.SelectedIndex = -1 Then
            MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        dgvHistorialDepositos.Rows.Add(cmbTipoDeposito.Text, dtpFechaDeposito.Value.ToShortDateString(), txtMonto.Text)
        cmbTipoDeposito.SelectedIndex = -1
        txtMonto.Clear()
    End Sub

    Private Sub ConfigurarHistorial()
        If dgvHistorialDepositos.Columns.Count = 0 Then
            dgvHistorialDepositos.Columns.Add("Tipo", "Tipo de Depósito")
            dgvHistorialDepositos.Columns.Add("Fecha", "Fecha")
            dgvHistorialDepositos.Columns.Add("Monto", "Monto")
        End If
        dgvHistorialDepositos.ReadOnly = True
        dgvHistorialDepositos.AllowUserToAddRows = False
    End Sub
End Class

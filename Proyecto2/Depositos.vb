Public Class Depositos

    Private Sub Deposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Verifica primero que el DataGridView esté inicializado
        If dgvHistorialDepositos IsNot Nothing Then
            If dgvHistorialDepositos.Columns.Count = 0 Then
                ' Agrega las columnas solo si no existen
                dgvHistorialDepositos.Columns.Add("NumeroDeposito", "Número de Depósito")
                dgvHistorialDepositos.Columns.Add("Monto", "Monto")
                dgvHistorialDepositos.Columns.Add("Fecha", "Fecha")
            End If
        Else
            MessageBox.Show("El DataGridView aún no está disponible (Nothing).", "Depósitos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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

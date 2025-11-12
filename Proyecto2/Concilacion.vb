Public Class Concilacion
    Inherits System.Windows.Forms.Form

    Private Sub Concilacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ajuste visual general
        Me.FormBorderStyle = FormBorderStyle.None
        Me.TopLevel = False
        Me.Dock = DockStyle.Fill
        Me.BackColor = Color.FromArgb(247, 247, 249)

        lblTitulo.ForeColor = Color.FromArgb(30, 41, 59)
        btnGrabar.BackColor = Color.FromArgb(17, 24, 39)
        btnGrabar.ForeColor = Color.White
        btnGrabar.FlatStyle = FlatStyle.Flat
        btnGrabar.FlatAppearance.BorderSize = 0
        btnGrabar.Cursor = Cursors.Hand

        ' Asignar estilo a los TextBox
        For Each txt As TextBox In {txtSaldoLibros, txtDepositosTransito, txtChequesPendientes, txtSaldoBancario}
            txt.Font = New Font("Segoe UI", 11.0F)
            txt.BackColor = Color.FromArgb(245, 247, 251)
            txt.BorderStyle = BorderStyle.FixedSingle
        Next
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs)
        ' Validar campos
        If txtSaldoLibros.Text = "" OrElse txtDepositosTransito.Text = "" OrElse
           txtChequesPendientes.Text = "" OrElse txtSaldoBancario.Text = "" Then
            MessageBox.Show("Por favor complete todos los campos antes de grabar.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim saldoLibros = Decimal.Parse(txtSaldoLibros.Text)
            Dim depositos = Decimal.Parse(txtDepositosTransito.Text)
            Dim cheques = Decimal.Parse(txtChequesPendientes.Text)
            Dim saldoBancario = Decimal.Parse(txtSaldoBancario.Text)

            Dim conciliado = saldoLibros + depositos - cheques

            Dim mensaje = $"Saldo según conciliación: {conciliado:C}" & vbCrLf &
                                    $"Saldo bancario informado: {saldoBancario:C}" & vbCrLf & vbCrLf

            If conciliado = saldoBancario Then
                mensaje &= "✅ Los saldos coinciden. Conciliación correcta."
            Else
                mensaje &= "⚠️ Los saldos NO coinciden. Revise los valores."
            End If

            MessageBox.Show(mensaje, "Resultado de Conciliación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al calcular conciliación. Verifique los valores numéricos.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

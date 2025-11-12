Public Class Concilacion

    ' Variables (default 0). Luego cambiarán por consultas a BD.
    Private saldoLibro As Decimal = 0D
    Private depositosLibro As Decimal = 0D
    Private chequesAnulados As Decimal = 0D
    Private chequesGirados As Decimal = 0D
    Private saldoConciliadoLibro As Decimal = 0D

    Private saldoBanco As Decimal = 0D
    Private depositosTransito As Decimal = 0D
    Private chequesCirculacion As Decimal = 0D
    Private saldoConciliadoBanco As Decimal = 0D

    Private Sub Concilacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarMeses()
        LlenarAños()
        cmbMes.SelectedIndex = Date.Now.Month - 1
        cmbAño.SelectedItem = Date.Now.Year
        ActualizarTexto() ' muestra inicial
    End Sub

    Private Sub LlenarMeses()
        Dim meses = New String() {
            "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
        }
        cmbMes.Items.Clear()
        cmbMes.Items.AddRange(meses)
    End Sub

    Private Sub LlenarAños()
        cmbAño.Items.Clear()
        For i As Integer = Date.Now.Year - 5 To Date.Now.Year + 1
            cmbAño.Items.Add(i)
        Next
    End Sub

    ' Nombre en PascalCase para evitar la advertencia de nomenclatura
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CalcularSaldos()
        ActualizarTexto()
    End Sub

    Private Sub CalcularSaldos()
        ' Aquí irán tus consultas reales a la BD (por ahora valores 0)
        saldoLibro = 0D
        depositosLibro = 0D
        chequesAnulados = 0D
        chequesGirados = 0D

        Dim subtotal = saldoLibro + depositosLibro + chequesAnulados
        saldoConciliadoLibro = subtotal - chequesGirados

        saldoBanco = 0D
        depositosTransito = 0D
        chequesCirculacion = 0D
        saldoConciliadoBanco = saldoBanco + depositosTransito - chequesCirculacion
    End Sub

    Private Sub ActualizarTexto()
        If cmbMes.SelectedIndex = -1 OrElse cmbAño.SelectedIndex = -1 Then Exit Sub

        Dim mesIndex As Integer = cmbMes.SelectedIndex
        Dim añoSeleccionado As Integer = CInt(cmbAño.SelectedItem)
        Dim mesSeleccionado As String = cmbMes.SelectedItem.ToString()

        ' mesAnterior y año anterior si corresponde
        Dim mesAnteriorIndex As Integer = mesIndex - 1
        Dim añoAnterior As Integer = añoSeleccionado
        If mesAnteriorIndex < 0 Then
            mesAnteriorIndex = 11
            añoAnterior -= 1
        End If
        Dim mesAnterior As String = cmbMes.Items(mesAnteriorIndex).ToString()

        Dim f As String = "C2"

        lblTitulo.Text = $"EMPRESA XYZ{vbCrLf}CONCILIACIÓN BANCARIA{vbCrLf}Correspondiente al mes de {mesSeleccionado} de {añoSeleccionado}"

        ' LIBRO (mes anterior en la fecha)
        lblSaldoLibroFecha.Text = $"Saldo según libro al 31 de {mesAnterior} de {añoAnterior}:"
        lblSaldoLibroValor.Text = saldoLibro.ToString(f)

        lblDepositosLibroTexto.Text = "Más: Depósitos"
        lblDepositosLibroValor.Text = depositosLibro.ToString(f)

        lblChequesAnuladosTexto.Text = "Cheques anulados"
        lblChequesAnuladosValor.Text = chequesAnulados.ToString(f)

        lblSubtotalTexto.Text = "SUBTOTAL"
        lblSubtotalValor.Text = (saldoLibro + depositosLibro + chequesAnulados).ToString(f)

        lblMenosChequesGiradosTexto.Text = "Menos: Cheques girados"
        lblMenosChequesGiradosValor.Text = chequesGirados.ToString(f)

        ' SALDO CONCILIADO (usando mes elegido)
        lblSaldoConciliadoLibrosFecha.Text = $"Saldo conciliado según libros al 31 de {mesSeleccionado} de {añoSeleccionado}:"
        lblSaldoConciliadoLibrosValor.Text = saldoConciliadoLibro.ToString(f)

        ' BANCO (usa mes elegido)
        lblSaldoBancoFecha.Text = $"Saldo en banco al 31 de {mesSeleccionado} de {añoSeleccionado}:"
        lblSaldoBancoValor.Text = saldoBanco.ToString(f)

        lblDepositosTransitoTexto.Text = "Más: Depósitos en tránsito"
        lblDepositosTransitoValor.Text = depositosTransito.ToString(f)

        lblChequesCirculacionTexto.Text = "Menos: Cheques en circulación"
        lblChequesCirculacionValor.Text = chequesCirculacion.ToString(f)

        lblSaldoConciliadoBancoFecha.Text = $"Saldo conciliado igual a banco al 31 de {mesSeleccionado} de {añoSeleccionado}:"
        lblSaldoConciliadoBancoValor.Text = saldoConciliadoBanco.ToString(f)
    End Sub
End Class

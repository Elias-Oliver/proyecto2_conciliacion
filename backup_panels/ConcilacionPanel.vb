Public Class ConcilacionPanelPublic Class ConcilacionPanelPublic Class ConcilacionPanel

    Inherits System.Windows.Forms.UserControl

    Inherits System.Windows.Forms.UserControl    Inherits UserControl

    Public Sub New()

        InitializeComponent()

        ConfigureUI()

    End Sub    Public Sub New()    Private components As System.ComponentModel.IContainer



    Private Sub ConfigureUI()        InitializeComponent()

        Dim lbl As New Label()

        lbl.Text = "Aquí irá la interfaz de conciliación bancaria"        ConfigureUI()    Private Sub InitializeComponent()

        lbl.Font = New Font("Segoe UI", 12)

        lbl.ForeColor = Color.FromArgb(82, 95, 110)    End Sub        Me.pnlTools = New Panel()

        lbl.AutoSize = False

        lbl.Dock = DockStyle.Fill        Me.btnNueva = New Button()

        lbl.TextAlign = ContentAlignment.MiddleCenter

        pnlBody.Controls.Add(lbl)    Private Sub ConfigureUI()        Me.btnHistorial = New Button()

    End Sub

End Class        ' Configure pnlTools        Me.pnlRegistro = New Panel()

        pnlTools.Height = 60        Me.lblTitulo = New Label()

        pnlTools.BackColor = Color.FromArgb(44, 58, 71)        Me.lblSubtitulo = New Label()

        Me.lblMes = New Label()

        ' Configure buttons        Me.cmbMes = New ComboBox()

        btnNueva.FlatStyle = FlatStyle.Flat        Me.lblAnio = New Label()

        btnNueva.ForeColor = Color.White        Me.txtAnio = New TextBox()

        btnNueva.BackColor = Color.Transparent        Me.lblSaldoLibros = New Label()

        btnNueva.Text = "NUEVA"        Me.txtSaldoLibros = New TextBox()

        btnNueva.Dock = DockStyle.Left        Me.lblDepositosTransito = New Label()

        btnNueva.Width = 150        Me.txtDepositosTransito = New TextBox()

        Me.lblChequesPendientes = New Label()

        btnHistorial.FlatStyle = FlatStyle.Flat        Me.txtChequesPendientes = New TextBox()

        btnHistorial.ForeColor = Color.White        Me.lblSaldoConciliado = New Label()

        btnHistorial.BackColor = Color.Transparent        Me.txtSaldoConciliado = New TextBox()

        btnHistorial.Text = "HISTORIAL"        Me.lblSaldoBancario = New Label()

        btnHistorial.Dock = DockStyle.Left        Me.txtSaldoBancario = New TextBox()

        btnHistorial.Width = 150        Me.btnGuardar = New Button()



        ' Configure pnlRegistro        Me.lblMes.Location = New Point(30, y)

        pnlRegistro.BackColor = Color.White        Me.lblMes.AutoSize = True

        pnlRegistro.Padding = New Padding(30)

        Me.cmbMes.Location = New Point(30, y + 25)

        ' Configure title labels        Me.cmbMes.Size = New Size(200, 30)

        lblTitulo.Text = "Conciliación Bancaria"        Me.cmbMes.DropDownStyle = ComboBoxStyle.DropDownList

        lblTitulo.Font = New Font("Segoe UI", 18, FontStyle.Bold)        Me.cmbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})

        lblTitulo.ForeColor = Color.FromArgb(44, 58, 71)

        lblTitulo.AutoSize = True        Me.lblAnio.Text = "Año"

        lblTitulo.Location = New Point(30, 30)        Me.lblAnio.Location = New Point(250, y)

        Me.lblAnio.AutoSize = True

        lblSubtitulo.Text = "Ingrese los datos para la conciliación"

        lblSubtitulo.Font = New Font("Segoe UI", 12, FontStyle.Regular)        Me.txtAnio.Text = DateTime.Now.Year.ToString()

        lblSubtitulo.ForeColor = Color.FromArgb(44, 58, 71)        Me.txtAnio.Location = New Point(250, y + 25)

        lblSubtitulo.AutoSize = True        Me.txtAnio.Size = New Size(100, 30)

        lblSubtitulo.Location = New Point(30, 60)        Me.txtAnio.BorderStyle = BorderStyle.FixedSingle

        y += spacing + 40

        ' Configure fields with similar style to maintain consistency

        ConfigureLabel(lblMes, "Mes")        ' Saldo según libros

        ConfigureComboBox(cmbMes)        Me.lblSaldoLibros.Text = "Saldo según libros"

        ConfigureLabel(lblAnio, "Año")        Me.lblSaldoLibros.Location = New Point(30, y)

        ConfigureTextBox(txtAnio)        Me.lblSaldoLibros.AutoSize = True

        ConfigureLabel(lblSaldoLibros, "Saldo según Libros")

        ConfigureTextBox(txtSaldoLibros)        Me.txtSaldoLibros.Location = New Point(30, y + 25)

        ConfigureLabel(lblDepositosTransito, "Depósitos en Tránsito")        Me.txtSaldoLibros.Size = New Size(controlWidth, 30)

        ConfigureTextBox(txtDepositosTransito)        Me.txtSaldoLibros.BorderStyle = BorderStyle.FixedSingle

        ConfigureLabel(lblChequesPendientes, "Cheques Pendientes")        y += spacing + 20

        ConfigureTextBox(txtChequesPendientes)

        ConfigureLabel(lblSaldoConciliado, "Saldo Conciliado")        ' Depósitos en tránsito

        ConfigureTextBox(txtSaldoConciliado)        Me.lblDepositosTransito.Text = "(+) Depósitos en tránsito"

        ConfigureLabel(lblSaldoBancario, "Saldo según Banco")        Me.lblDepositosTransito.Location = New Point(30, y)

        ConfigureTextBox(txtSaldoBancario)        Me.lblDepositosTransito.AutoSize = True



        ' Configure save button        Me.txtDepositosTransito.Location = New Point(30, y + 25)

        btnGuardar.Text = "GUARDAR"        Me.txtDepositosTransito.Size = New Size(controlWidth, 30)

        btnGuardar.Font = New Font("Segoe UI", 9, FontStyle.Bold)        Me.txtDepositosTransito.BorderStyle = BorderStyle.FixedSingle

        btnGuardar.ForeColor = Color.White        y += spacing + 20

        btnGuardar.BackColor = Color.FromArgb(46, 204, 113)

        btnGuardar.FlatStyle = FlatStyle.Flat        ' Cheques pendientes

        btnGuardar.Width = 120        Me.lblChequesPendientes.Text = "(-) Cheques pendientes"

        btnGuardar.Height = 40        Me.lblChequesPendientes.Location = New Point(30, y)

    End Sub        Me.lblChequesPendientes.AutoSize = True



    Private Sub ConfigureLabel(label As Label, text As String)        Me.txtChequesPendientes.Location = New Point(30, y + 25)

        label.Text = text        Me.txtChequesPendientes.Size = New Size(controlWidth, 30)

        label.Font = New Font("Segoe UI", 9, FontStyle.Regular)        Me.txtChequesPendientes.BorderStyle = BorderStyle.FixedSingle

        label.ForeColor = Color.FromArgb(44, 58, 71)        y += spacing + 20

        label.AutoSize = True

    End Sub        ' Saldo conciliado

        Me.lblSaldoConciliado.Text = "Saldo Conciliado"

    Private Sub ConfigureTextBox(textBox As TextBox)        Me.lblSaldoConciliado.Location = New Point(30, y)

        textBox.Font = New Font("Segoe UI", 9, FontStyle.Regular)        Me.lblSaldoConciliado.Font = New Font(lblSaldoConciliado.Font, FontStyle.Bold)

        textBox.ForeColor = Color.FromArgb(44, 58, 71)        Me.lblSaldoConciliado.AutoSize = True

        textBox.BorderStyle = BorderStyle.FixedSingle

        textBox.Width = 250        Me.txtSaldoConciliado.Location = New Point(30, y + 25)

    End Sub        Me.txtSaldoConciliado.Size = New Size(controlWidth, 30)

        Me.txtSaldoConciliado.BorderStyle = BorderStyle.FixedSingle

    Private Sub ConfigureComboBox(comboBox As ComboBox)        Me.txtSaldoConciliado.ReadOnly = True

        comboBox.Font = New Font("Segoe UI", 9, FontStyle.Regular)        Me.txtSaldoConciliado.BackColor = Color.FromArgb(240, 244, 248)

        comboBox.ForeColor = Color.FromArgb(44, 58, 71)        y += spacing + 40

        comboBox.Width = 250

        comboBox.DropDownStyle = ComboBoxStyle.DropDownList        ' Saldo bancario

        Me.lblSaldoBancario.Text = "Saldo bancario"

        ' Agregar meses        Me.lblSaldoBancario.Location = New Point(30, y)

        comboBox.Items.AddRange(New String() {        Me.lblSaldoBancario.AutoSize = True

            "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",

            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"        Me.txtSaldoBancario.Location = New Point(30, y + 25)

        })        Me.txtSaldoBancario.Size = New Size(controlWidth, 30)

    End Sub        Me.txtSaldoBancario.BorderStyle = BorderStyle.FixedSingle

        y += spacing + 40

    Private Sub btnNueva_Click(sender As Object, e As EventArgs) Handles btnNueva.Click

        btnNueva.BackColor = Color.FromArgb(39, 60, 117)        ' Botón guardar

        btnHistorial.BackColor = Color.Transparent        Me.btnGuardar.Text = "Guardar Conciliación"

        pnlRegistro.Visible = True        Me.btnGuardar.BackColor = Color.FromArgb(0, 0, 0)

    End Sub        Me.btnGuardar.ForeColor = Color.White

        Me.btnGuardar.FlatStyle = FlatStyle.Flat

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click        Me.btnGuardar.Size = New Size(controlWidth, 40)

        btnNueva.BackColor = Color.Transparent        Me.btnGuardar.Location = New Point(30, y)

        btnHistorial.BackColor = Color.FromArgb(39, 60, 117)        Me.btnGuardar.Cursor = Cursors.Hand

        pnlRegistro.Visible = False

    End Sub        ' Agregar controles

        Me.pnlTools.Controls.AddRange(New Control() {Me.btnNueva, Me.btnHistorial})

    Private Sub txtSaldoLibros_TextChanged(sender As Object, e As EventArgs) Handles txtSaldoLibros.TextChanged

        CalcularSaldoConciliado()        Me.pnlRegistro.Controls.AddRange(New Control() {

    End Sub            Me.lblTitulo, Me.lblSubtitulo,

            Me.lblMes, Me.cmbMes,

    Private Sub txtDepositosTransito_TextChanged(sender As Object, e As EventArgs) Handles txtDepositosTransito.TextChanged            Me.lblAnio, Me.txtAnio,

        CalcularSaldoConciliado()            Me.lblSaldoLibros, Me.txtSaldoLibros,

    End Sub            Me.lblDepositosTransito, Me.txtDepositosTransito,

            Me.lblChequesPendientes, Me.txtChequesPendientes,

    Private Sub txtChequesPendientes_TextChanged(sender As Object, e As EventArgs) Handles txtChequesPendientes.TextChanged            Me.lblSaldoConciliado, Me.txtSaldoConciliado,

        CalcularSaldoConciliado()            Me.lblSaldoBancario, Me.txtSaldoBancario,

    End Sub            Me.btnGuardar

        })

    Private Sub CalcularSaldoConciliado()

        If IsNumeric(txtSaldoLibros.Text) AndAlso IsNumeric(txtDepositosTransito.Text) AndAlso IsNumeric(txtChequesPendientes.Text) Then        Me.Controls.AddRange(New Control() {Me.pnlTools, Me.pnlRegistro})

            Dim saldoLibros As Decimal = CDec(txtSaldoLibros.Text)    End Sub

            Dim depositosTransito As Decimal = CDec(txtDepositosTransito.Text)

            Dim chequesPendientes As Decimal = CDec(txtChequesPendientes.Text)    Public Sub New()

                    InitializeComponent()

            txtSaldoConciliado.Text = (saldoLibros + depositosTransito - chequesPendientes).ToString("C2")        ConfigureEvents()

        Else    End Sub

            txtSaldoConciliado.Text = ""

        End If    Private Sub ConfigureEvents()

    End Sub        AddHandler btnNueva.Click, AddressOf ShowNuevaPanel

End Class        AddHandler btnHistorial.Click, AddressOf ShowHistorialPanel
        AddHandler btnGuardar.Click, AddressOf GuardarConciliacion
        AddHandler txtSaldoLibros.TextChanged, AddressOf CalcularSaldo
        AddHandler txtDepositosTransito.TextChanged, AddressOf CalcularSaldo
        AddHandler txtChequesPendientes.TextChanged, AddressOf CalcularSaldo
    End Sub

    Private Sub ShowNuevaPanel()
        btnNueva.BackColor = Color.Black
        btnNueva.ForeColor = Color.White
        btnHistorial.BackColor = Color.White
        btnHistorial.ForeColor = Color.Black
        ' TODO: Mostrar panel de nueva conciliación
    End Sub

    Private Sub ShowHistorialPanel()
        btnNueva.BackColor = Color.White
        btnNueva.ForeColor = Color.Black
        btnHistorial.BackColor = Color.Black
        btnHistorial.ForeColor = Color.White
        ' TODO: Mostrar historial
    End Sub

    Private Sub CalcularSaldo()
        Try
            Dim saldoLibros As Decimal = If(Decimal.TryParse(txtSaldoLibros.Text, Nothing), Decimal.Parse(txtSaldoLibros.Text), 0)
            Dim depositos As Decimal = If(Decimal.TryParse(txtDepositosTransito.Text, Nothing), Decimal.Parse(txtDepositosTransito.Text), 0)
            Dim cheques As Decimal = If(Decimal.TryParse(txtChequesPendientes.Text, Nothing), Decimal.Parse(txtChequesPendientes.Text), 0)
            
            Dim saldoConciliado As Decimal = saldoLibros + depositos - cheques
            txtSaldoConciliado.Text = saldoConciliado.ToString("N2")
        Catch ex As Exception
            txtSaldoConciliado.Text = "0.00"
        End Try
    End Sub

    Private Sub GuardarConciliacion()
        ' TODO: Validar y guardar conciliación
        MessageBox.Show("Implementar guardado de conciliación", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
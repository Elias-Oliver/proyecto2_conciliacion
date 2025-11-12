<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Concilacion
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmbMes = New ComboBox()
        lblSaldoLibroFecha = New Label()
        lblDepositosLibroTexto = New Label()
        lblChequesAnuladosTexto = New Label()
        lblSubtotalTexto = New Label()
        lblMenosChequesGiradosTexto = New Label()
        lblDepositosTransitoTexto = New Label()
        pnlForm = New Panel()
        btnActualizar = New Button()
        cmbAño = New ComboBox()
        lblTitulo = New Label()
        lblSaldoLibroValor = New Label()
        lblDepositosLibroValor = New Label()
        lblChequesAnuladosValor = New Label()
        lblSubtotalValor = New Label()
        lblMenosChequesGiradosValor = New Label()
        lblSaldoConciliadoLibrosFecha = New Label()
        lblSaldoConciliadoLibrosValor = New Label()
        lblSaldoBancoFecha = New Label()
        lblSaldoConciliadoBancoValor = New Label()
        lblDepositosTransitoValor = New Label()
        lblSaldoBancoValor = New Label()
        lblChequesCirculacionValor = New Label()
        lblChequesCirculacionTexto = New Label()
        lblSaldoConciliadoBancoFecha = New Label()
        pnlForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbMes
        ' 
        cmbMes.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMes.Font = New Font("Segoe UI", 10.0F)
        cmbMes.Location = New Point(150, 39)
        cmbMes.Name = "cmbMes"
        cmbMes.Size = New Size(160, 25)
        cmbMes.TabIndex = 0
        ' 
        ' lblSaldoLibroFecha
        ' 
        lblSaldoLibroFecha.AutoSize = True
        lblSaldoLibroFecha.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSaldoLibroFecha.Location = New Point(99, 139)
        lblSaldoLibroFecha.Name = "lblSaldoLibroFecha"
        lblSaldoLibroFecha.Size = New Size(184, 17)
        lblSaldoLibroFecha.TabIndex = 4
        lblSaldoLibroFecha.Text = "Saldo según libro al 31 de ..."
        ' 
        ' lblDepositosLibroTexto
        ' 
        lblDepositosLibroTexto.AutoSize = True
        lblDepositosLibroTexto.Font = New Font("Segoe UI", 10.0F)
        lblDepositosLibroTexto.Location = New Point(99, 169)
        lblDepositosLibroTexto.Name = "lblDepositosLibroTexto"
        lblDepositosLibroTexto.Size = New Size(103, 19)
        lblDepositosLibroTexto.TabIndex = 6
        lblDepositosLibroTexto.Text = "Más: Depósitos"
        ' 
        ' lblChequesAnuladosTexto
        ' 
        lblChequesAnuladosTexto.AutoSize = True
        lblChequesAnuladosTexto.Font = New Font("Segoe UI", 10.0F)
        lblChequesAnuladosTexto.Location = New Point(99, 199)
        lblChequesAnuladosTexto.Name = "lblChequesAnuladosTexto"
        lblChequesAnuladosTexto.Size = New Size(121, 19)
        lblChequesAnuladosTexto.TabIndex = 8
        lblChequesAnuladosTexto.Text = "Cheques anulados"
        ' 
        ' lblSubtotalTexto
        ' 
        lblSubtotalTexto.AutoSize = True
        lblSubtotalTexto.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSubtotalTexto.Location = New Point(99, 229)
        lblSubtotalTexto.Name = "lblSubtotalTexto"
        lblSubtotalTexto.Size = New Size(77, 19)
        lblSubtotalTexto.TabIndex = 10
        lblSubtotalTexto.Text = "SUBTOTAL"
        ' 
        ' lblMenosChequesGiradosTexto
        ' 
        lblMenosChequesGiradosTexto.AutoSize = True
        lblMenosChequesGiradosTexto.Font = New Font("Segoe UI", 10.0F)
        lblMenosChequesGiradosTexto.Location = New Point(99, 259)
        lblMenosChequesGiradosTexto.Name = "lblMenosChequesGiradosTexto"
        lblMenosChequesGiradosTexto.Size = New Size(160, 19)
        lblMenosChequesGiradosTexto.TabIndex = 12
        lblMenosChequesGiradosTexto.Text = "Menos: Cheques girados"
        ' 
        ' lblDepositosTransitoTexto
        ' 
        lblDepositosTransitoTexto.AutoSize = True
        lblDepositosTransitoTexto.Font = New Font("Segoe UI", 10.0F)
        lblDepositosTransitoTexto.Location = New Point(98, 389)
        lblDepositosTransitoTexto.Name = "lblDepositosTransitoTexto"
        lblDepositosTransitoTexto.Size = New Size(173, 19)
        lblDepositosTransitoTexto.TabIndex = 18
        lblDepositosTransitoTexto.Text = "Más: Depósitos en tránsito"
        ' 
        ' pnlForm
        ' 
        pnlForm.BackColor = Color.White
        pnlForm.Controls.Add(btnActualizar)
        pnlForm.Controls.Add(cmbAño)
        pnlForm.Controls.Add(cmbMes)
        pnlForm.Controls.Add(lblTitulo)
        pnlForm.Controls.Add(lblSaldoLibroFecha)
        pnlForm.Controls.Add(lblSaldoLibroValor)
        pnlForm.Controls.Add(lblDepositosLibroTexto)
        pnlForm.Controls.Add(lblDepositosLibroValor)
        pnlForm.Controls.Add(lblChequesAnuladosTexto)
        pnlForm.Controls.Add(lblChequesAnuladosValor)
        pnlForm.Controls.Add(lblSubtotalTexto)
        pnlForm.Controls.Add(lblSubtotalValor)
        pnlForm.Controls.Add(lblMenosChequesGiradosTexto)
        pnlForm.Controls.Add(lblMenosChequesGiradosValor)
        pnlForm.Controls.Add(lblSaldoConciliadoLibrosFecha)
        pnlForm.Controls.Add(lblSaldoConciliadoLibrosValor)
        pnlForm.Controls.Add(lblSaldoBancoFecha)
        pnlForm.Controls.Add(lblSaldoConciliadoBancoValor)
        pnlForm.Controls.Add(lblDepositosTransitoValor)
        pnlForm.Controls.Add(lblSaldoBancoValor)
        pnlForm.Controls.Add(lblChequesCirculacionValor)
        pnlForm.Controls.Add(lblDepositosTransitoTexto)
        pnlForm.Controls.Add(lblChequesCirculacionTexto)
        pnlForm.Controls.Add(lblSaldoConciliadoBancoFecha)
        pnlForm.Location = New Point(40, 121)
        pnlForm.Name = "pnlForm"
        pnlForm.Padding = New Padding(20)
        pnlForm.Size = New Size(827, 527)
        pnlForm.TabIndex = 25
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActualizar.Location = New Point(565, 36)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(90, 30)
        btnActualizar.TabIndex = 24
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' cmbAño
        ' 
        cmbAño.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAño.Font = New Font("Segoe UI", 10.0F)
        cmbAño.Location = New Point(316, 39)
        cmbAño.Name = "cmbAño"
        cmbAño.Size = New Size(231, 25)
        cmbAño.TabIndex = 1
        ' 
        ' lblTitulo
        ' 
        lblTitulo.BackColor = Color.White
        lblTitulo.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTitulo.Location = New Point(0, 82)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(827, 38)
        lblTitulo.TabIndex = 3
        lblTitulo.Text = "CONCILIACIÓN BANCARIA"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSaldoLibroValor
        ' 
        lblSaldoLibroValor.AutoSize = True
        lblSaldoLibroValor.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSaldoLibroValor.Location = New Point(646, 139)
        lblSaldoLibroValor.Name = "lblSaldoLibroValor"
        lblSaldoLibroValor.Size = New Size(45, 19)
        lblSaldoLibroValor.TabIndex = 5
        lblSaldoLibroValor.Text = "$0.00"
        ' 
        ' lblDepositosLibroValor
        ' 
        lblDepositosLibroValor.AutoSize = True
        lblDepositosLibroValor.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblDepositosLibroValor.Location = New Point(587, 169)
        lblDepositosLibroValor.Name = "lblDepositosLibroValor"
        lblDepositosLibroValor.Size = New Size(45, 19)
        lblDepositosLibroValor.TabIndex = 7
        lblDepositosLibroValor.Text = "$0.00"
        ' 
        ' lblChequesAnuladosValor
        ' 
        lblChequesAnuladosValor.AutoSize = True
        lblChequesAnuladosValor.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblChequesAnuladosValor.Location = New Point(587, 199)
        lblChequesAnuladosValor.Name = "lblChequesAnuladosValor"
        lblChequesAnuladosValor.Size = New Size(45, 19)
        lblChequesAnuladosValor.TabIndex = 9
        lblChequesAnuladosValor.Text = "$0.00"
        ' 
        ' lblSubtotalValor
        ' 
        lblSubtotalValor.AutoSize = True
        lblSubtotalValor.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSubtotalValor.Location = New Point(647, 229)
        lblSubtotalValor.Name = "lblSubtotalValor"
        lblSubtotalValor.Size = New Size(45, 19)
        lblSubtotalValor.TabIndex = 11
        lblSubtotalValor.Text = "$0.00"
        ' 
        ' lblMenosChequesGiradosValor
        ' 
        lblMenosChequesGiradosValor.AutoSize = True
        lblMenosChequesGiradosValor.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblMenosChequesGiradosValor.Location = New Point(587, 259)
        lblMenosChequesGiradosValor.Name = "lblMenosChequesGiradosValor"
        lblMenosChequesGiradosValor.Size = New Size(45, 19)
        lblMenosChequesGiradosValor.TabIndex = 13
        lblMenosChequesGiradosValor.Text = "$0.00"
        ' 
        ' lblSaldoConciliadoLibrosFecha
        ' 
        lblSaldoConciliadoLibrosFecha.AutoSize = True
        lblSaldoConciliadoLibrosFecha.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSaldoConciliadoLibrosFecha.Location = New Point(99, 299)
        lblSaldoConciliadoLibrosFecha.Name = "lblSaldoConciliadoLibrosFecha"
        lblSaldoConciliadoLibrosFecha.Size = New Size(278, 19)
        lblSaldoConciliadoLibrosFecha.TabIndex = 14
        lblSaldoConciliadoLibrosFecha.Text = "Saldo conciliado según libros al 31 de ..."
        ' 
        ' lblSaldoConciliadoLibrosValor
        ' 
        lblSaldoConciliadoLibrosValor.AutoSize = True
        lblSaldoConciliadoLibrosValor.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSaldoConciliadoLibrosValor.Location = New Point(647, 299)
        lblSaldoConciliadoLibrosValor.Name = "lblSaldoConciliadoLibrosValor"
        lblSaldoConciliadoLibrosValor.Size = New Size(45, 19)
        lblSaldoConciliadoLibrosValor.TabIndex = 15
        lblSaldoConciliadoLibrosValor.Text = "$0.00"
        ' 
        ' lblSaldoBancoFecha
        ' 
        lblSaldoBancoFecha.AutoSize = True
        lblSaldoBancoFecha.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSaldoBancoFecha.Location = New Point(98, 359)
        lblSaldoBancoFecha.Name = "lblSaldoBancoFecha"
        lblSaldoBancoFecha.Size = New Size(185, 19)
        lblSaldoBancoFecha.TabIndex = 16
        lblSaldoBancoFecha.Text = "Saldo en banco al 31 de ..."
        ' 
        ' lblSaldoConciliadoBancoValor
        ' 
        lblSaldoConciliadoBancoValor.AutoSize = True
        lblSaldoConciliadoBancoValor.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSaldoConciliadoBancoValor.Location = New Point(647, 359)
        lblSaldoConciliadoBancoValor.Name = "lblSaldoConciliadoBancoValor"
        lblSaldoConciliadoBancoValor.Size = New Size(45, 19)
        lblSaldoConciliadoBancoValor.TabIndex = 23
        lblSaldoConciliadoBancoValor.Text = "$0.00"
        ' 
        ' lblDepositosTransitoValor
        ' 
        lblDepositosTransitoValor.AutoSize = True
        lblDepositosTransitoValor.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblDepositosTransitoValor.Location = New Point(587, 389)
        lblDepositosTransitoValor.Name = "lblDepositosTransitoValor"
        lblDepositosTransitoValor.Size = New Size(45, 19)
        lblDepositosTransitoValor.TabIndex = 19
        lblDepositosTransitoValor.Text = "$0.00"
        ' 
        ' lblSaldoBancoValor
        ' 
        lblSaldoBancoValor.AutoSize = True
        lblSaldoBancoValor.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSaldoBancoValor.Location = New Point(646, 459)
        lblSaldoBancoValor.Name = "lblSaldoBancoValor"
        lblSaldoBancoValor.Size = New Size(45, 19)
        lblSaldoBancoValor.TabIndex = 17
        lblSaldoBancoValor.Text = "$0.00"
        ' 
        ' lblChequesCirculacionValor
        ' 
        lblChequesCirculacionValor.AutoSize = True
        lblChequesCirculacionValor.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblChequesCirculacionValor.Location = New Point(587, 419)
        lblChequesCirculacionValor.Name = "lblChequesCirculacionValor"
        lblChequesCirculacionValor.Size = New Size(45, 19)
        lblChequesCirculacionValor.TabIndex = 21
        lblChequesCirculacionValor.Text = "$0.00"
        ' 
        ' lblChequesCirculacionTexto
        ' 
        lblChequesCirculacionTexto.AutoSize = True
        lblChequesCirculacionTexto.Font = New Font("Segoe UI", 10.0F)
        lblChequesCirculacionTexto.Location = New Point(98, 419)
        lblChequesCirculacionTexto.Name = "lblChequesCirculacionTexto"
        lblChequesCirculacionTexto.Size = New Size(197, 19)
        lblChequesCirculacionTexto.TabIndex = 20
        lblChequesCirculacionTexto.Text = "Menos: Cheques en circulación"
        ' 
        ' lblSaldoConciliadoBancoFecha
        ' 
        lblSaldoConciliadoBancoFecha.AutoSize = True
        lblSaldoConciliadoBancoFecha.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSaldoConciliadoBancoFecha.Location = New Point(99, 459)
        lblSaldoConciliadoBancoFecha.Name = "lblSaldoConciliadoBancoFecha"
        lblSaldoConciliadoBancoFecha.Size = New Size(287, 19)
        lblSaldoConciliadoBancoFecha.TabIndex = 22
        lblSaldoConciliadoBancoFecha.Text = "Saldo conciliado igual a banco al 31 de ..."
        ' 
        ' Concilacion
        ' 
        ClientSize = New Size(906, 682)
        Controls.Add(pnlForm)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Concilacion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Conciliación Bancaria"
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbMes As ComboBox

    ' LIBRO
    Friend WithEvents lblSaldoLibroFecha As Label
    Friend WithEvents lblDepositosLibroTexto As Label
    Friend WithEvents lblChequesAnuladosTexto As Label
    Friend WithEvents lblSubtotalTexto As Label
    Friend WithEvents lblMenosChequesGiradosTexto As Label
    Friend WithEvents lblDepositosTransitoTexto As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblSaldoConciliadoBancoValor As Label
    Friend WithEvents lblSaldoConciliadoBancoFecha As Label
    Friend WithEvents lblChequesCirculacionValor As Label
    Friend WithEvents lblChequesCirculacionTexto As Label
    Friend WithEvents lblDepositosTransitoValor As Label
    Friend WithEvents lblSaldoBancoValor As Label
    Friend WithEvents lblSaldoBancoFecha As Label
    Friend WithEvents lblSaldoConciliadoLibrosValor As Label
    Friend WithEvents lblSaldoConciliadoLibrosFecha As Label
    Friend WithEvents lblMenosChequesGiradosValor As Label
    Friend WithEvents lblSubtotalValor As Label
    Friend WithEvents lblChequesAnuladosValor As Label
    Friend WithEvents lblDepositosLibroValor As Label
    Friend WithEvents lblSaldoLibroValor As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents btnActualizar As Button
End Class

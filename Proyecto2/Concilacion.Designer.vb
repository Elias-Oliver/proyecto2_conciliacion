<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Concilacion
    Inherits System.Windows.Forms.Form

    'Limpiar los recursos que se estén utilizando.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifiques con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvHistorialDepositos = New DataGridView()
        pnlContenedorDeposito = New Panel()
        btnGrabar = New Button()
        txtSaldoBancario = New TextBox()
        txtChequesPendientes = New TextBox()
        txtDepositosTransito = New TextBox()
        txtSaldoLibros = New TextBox()
        lblSaldoBancario = New Label()
        lblChequesPendientes = New Label()
        lblDepositosTransito = New Label()
        lblSaldoLibros = New Label()
        lblTitulo = New Label()
        CType(dgvHistorialDepositos, ComponentModel.ISupportInitialize).BeginInit()
        pnlContenedorDeposito.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvHistorialDepositos
        ' 
        dgvHistorialDepositos.AllowUserToAddRows = False
        dgvHistorialDepositos.AllowUserToOrderColumns = True
        dgvHistorialDepositos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHistorialDepositos.ColumnHeadersHeight = 29
        dgvHistorialDepositos.Location = New Point(29, 754)
        dgvHistorialDepositos.Margin = New Padding(3, 4, 3, 4)
        dgvHistorialDepositos.Name = "dgvHistorialDepositos"
        dgvHistorialDepositos.RowHeadersWidth = 51
        dgvHistorialDepositos.Size = New Size(1449, 213)
        dgvHistorialDepositos.TabIndex = 8
        ' 
        ' pnlContenedorDeposito
        ' 
        pnlContenedorDeposito.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlContenedorDeposito.BackColor = Color.White
        pnlContenedorDeposito.Controls.Add(btnGrabar)
        pnlContenedorDeposito.Controls.Add(txtSaldoBancario)
        pnlContenedorDeposito.Controls.Add(txtChequesPendientes)
        pnlContenedorDeposito.Controls.Add(txtDepositosTransito)
        pnlContenedorDeposito.Controls.Add(txtSaldoLibros)
        pnlContenedorDeposito.Controls.Add(lblSaldoBancario)
        pnlContenedorDeposito.Controls.Add(lblChequesPendientes)
        pnlContenedorDeposito.Controls.Add(lblDepositosTransito)
        pnlContenedorDeposito.Controls.Add(lblSaldoLibros)
        pnlContenedorDeposito.Controls.Add(lblTitulo)
        pnlContenedorDeposito.Controls.Add(dgvHistorialDepositos)
        pnlContenedorDeposito.Cursor = Cursors.No
        pnlContenedorDeposito.Location = New Point(27, 155)
        pnlContenedorDeposito.Margin = New Padding(6, 7, 6, 7)
        pnlContenedorDeposito.Name = "pnlContenedorDeposito"
        pnlContenedorDeposito.Size = New Size(912, 545)
        pnlContenedorDeposito.TabIndex = 10
        ' 
        ' btnGrabar
        ' 
        btnGrabar.BackColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        btnGrabar.FlatAppearance.BorderSize = 0
        btnGrabar.FlatStyle = FlatStyle.Flat
        btnGrabar.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnGrabar.ForeColor = Color.White
        btnGrabar.Location = New Point(57, 382)
        btnGrabar.Name = "btnGrabar"
        btnGrabar.Size = New Size(181, 40)
        btnGrabar.TabIndex = 19
        btnGrabar.Text = "Grabar conciliación"
        btnGrabar.UseVisualStyleBackColor = False
        ' 
        ' txtSaldoBancario
        ' 
        txtSaldoBancario.Font = New Font("Segoe UI", 11F)
        txtSaldoBancario.Location = New Point(627, 291)
        txtSaldoBancario.Name = "txtSaldoBancario"
        txtSaldoBancario.Size = New Size(201, 32)
        txtSaldoBancario.TabIndex = 18
        ' 
        ' txtChequesPendientes
        ' 
        txtChequesPendientes.Font = New Font("Segoe UI", 11F)
        txtChequesPendientes.Location = New Point(250, 291)
        txtChequesPendientes.Name = "txtChequesPendientes"
        txtChequesPendientes.Size = New Size(201, 32)
        txtChequesPendientes.TabIndex = 17
        ' 
        ' txtDepositosTransito
        ' 
        txtDepositosTransito.Font = New Font("Segoe UI", 11F)
        txtDepositosTransito.Location = New Point(627, 213)
        txtDepositosTransito.Name = "txtDepositosTransito"
        txtDepositosTransito.Size = New Size(201, 32)
        txtDepositosTransito.TabIndex = 16
        ' 
        ' txtSaldoLibros
        ' 
        txtSaldoLibros.Font = New Font("Segoe UI", 11F)
        txtSaldoLibros.Location = New Point(204, 213)
        txtSaldoLibros.Name = "txtSaldoLibros"
        txtSaldoLibros.Size = New Size(201, 32)
        txtSaldoLibros.TabIndex = 15
        ' 
        ' lblSaldoBancario
        ' 
        lblSaldoBancario.AutoSize = True
        lblSaldoBancario.Font = New Font("Segoe UI", 11F)
        lblSaldoBancario.Location = New Point(480, 300)
        lblSaldoBancario.Name = "lblSaldoBancario"
        lblSaldoBancario.Size = New Size(142, 25)
        lblSaldoBancario.TabIndex = 14
        lblSaldoBancario.Text = "Saldo bancario:"
        ' 
        ' lblChequesPendientes
        ' 
        lblChequesPendientes.AutoSize = True
        lblChequesPendientes.Font = New Font("Segoe UI", 11F)
        lblChequesPendientes.Location = New Point(57, 295)
        lblChequesPendientes.Name = "lblChequesPendientes"
        lblChequesPendientes.Size = New Size(187, 25)
        lblChequesPendientes.TabIndex = 13
        lblChequesPendientes.Text = "Cheques pendientes:"
        ' 
        ' lblDepositosTransito
        ' 
        lblDepositosTransito.AutoSize = True
        lblDepositosTransito.Font = New Font("Segoe UI", 11F)
        lblDepositosTransito.Location = New Point(433, 217)
        lblDepositosTransito.Name = "lblDepositosTransito"
        lblDepositosTransito.Size = New Size(194, 25)
        lblDepositosTransito.TabIndex = 12
        lblDepositosTransito.Text = "Depósitos en tránsito:"
        ' 
        ' lblSaldoLibros
        ' 
        lblSaldoLibros.AutoSize = True
        lblSaldoLibros.Font = New Font("Segoe UI", 11F)
        lblSaldoLibros.Location = New Point(57, 217)
        lblSaldoLibros.Name = "lblSaldoLibros"
        lblSaldoLibros.Size = New Size(141, 25)
        lblSaldoLibros.TabIndex = 11
        lblSaldoLibros.Text = "Saldo en libros:"
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        lblTitulo.Location = New Point(57, 141)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(295, 38)
        lblTitulo.TabIndex = 10
        lblTitulo.Text = "Conciliación Bancaria"
        ' 
        ' Concilacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(991, 735)
        Controls.Add(pnlContenedorDeposito)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Concilacion"
        Text = "Concilacion"
        CType(dgvHistorialDepositos, ComponentModel.ISupportInitialize).EndInit()
        pnlContenedorDeposito.ResumeLayout(False)
        pnlContenedorDeposito.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvHistorialDepositos As DataGridView
    Friend WithEvents pnlContenedorDeposito As Panel
    Friend WithEvents btnGrabar As Button
    Friend WithEvents txtSaldoBancario As TextBox
    Friend WithEvents txtChequesPendientes As TextBox
    Friend WithEvents txtDepositosTransito As TextBox
    Friend WithEvents txtSaldoLibros As TextBox
    Friend WithEvents lblSaldoBancario As Label
    Friend WithEvents lblChequesPendientes As Label
    Friend WithEvents lblDepositosTransito As Label
    Friend WithEvents lblSaldoLibros As Label
    Friend WithEvents lblTitulo As Label
End Class

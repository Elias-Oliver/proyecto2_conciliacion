<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Depositos
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent(lblTitulo As Label, cmbTipoDeposito As ComboBox, dtpFechaDeposito As DateTimePicker, lblMonto As Label, txtMonto As TextBox, btnRegistrarDeposito As Button, dgvHistorialDepositos As DataGridView)
        pnlContenedorDeposito = New Panel()
        lblTitulo = New Label()
        lblTipo = New Label()
        cmbTipoDeposito = New ComboBox()
        lblFecha = New Label()
        dtpFechaDeposito = New DateTimePicker()
        lblMonto = New Label()
        txtMonto = New TextBox()
        btnRegistrarDeposito = New Button()
        dgvHistorialDepositos = New DataGridView()
        pnlContenedorDeposito.SuspendLayout()
        CType(dgvHistorialDepositos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContenedorDeposito
        ' 
        pnlContenedorDeposito.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlContenedorDeposito.BackColor = Color.White
        pnlContenedorDeposito.Controls.Add(lblTitulo)
        pnlContenedorDeposito.Controls.Add(lblTipo)
        pnlContenedorDeposito.Controls.Add(cmbTipoDeposito)
        pnlContenedorDeposito.Controls.Add(lblFecha)
        pnlContenedorDeposito.Controls.Add(dtpFechaDeposito)
        pnlContenedorDeposito.Controls.Add(lblMonto)
        pnlContenedorDeposito.Controls.Add(txtMonto)
        pnlContenedorDeposito.Controls.Add(btnRegistrarDeposito)
        pnlContenedorDeposito.Controls.Add(dgvHistorialDepositos)
        pnlContenedorDeposito.Cursor = Cursors.No
        pnlContenedorDeposito.Location = New Point(40, 36)
        pnlContenedorDeposito.Margin = New Padding(5)
        pnlContenedorDeposito.Name = "pnlContenedorDeposito"
        pnlContenedorDeposito.Size = New Size(720, 452)
        pnlContenedorDeposito.TabIndex = 0
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblTitulo.Location = New Point(26, 118)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(198, 25)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Registro de Depósitos"
        ' 
        ' lblTipo
        ' 
        lblTipo.AutoSize = True
        lblTipo.Font = New Font("Segoe UI", 9.0F)
        lblTipo.Location = New Point(26, 166)
        lblTipo.Name = "lblTipo"
        lblTipo.Size = New Size(99, 15)
        lblTipo.TabIndex = 1
        lblTipo.Text = "Tipo de Depósito:"
        ' 
        ' cmbTipoDeposito
        ' 
        cmbTipoDeposito.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTipoDeposito.Location = New Point(160, 158)
        cmbTipoDeposito.Name = "cmbTipoDeposito"
        cmbTipoDeposito.Size = New Size(200, 23)
        cmbTipoDeposito.TabIndex = 2
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Location = New Point(385, 161)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(41, 15)
        lblFecha.TabIndex = 3
        lblFecha.Text = "Fecha:"
        ' 
        ' dtpFechaDeposito
        ' 
        dtpFechaDeposito.Format = DateTimePickerFormat.Short
        dtpFechaDeposito.Location = New Point(451, 158)
        dtpFechaDeposito.Name = "dtpFechaDeposito"
        dtpFechaDeposito.Size = New Size(200, 23)
        dtpFechaDeposito.TabIndex = 4
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Location = New Point(26, 215)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(46, 15)
        lblMonto.TabIndex = 5
        lblMonto.Text = "Monto:"
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(160, 212)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(200, 23)
        txtMonto.TabIndex = 6
        ' 
        ' btnRegistrarDeposito
        ' 
        btnRegistrarDeposito.BackColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        btnRegistrarDeposito.ForeColor = Color.White
        btnRegistrarDeposito.Location = New Point(451, 205)
        btnRegistrarDeposito.Name = "btnRegistrarDeposito"
        btnRegistrarDeposito.Size = New Size(200, 35)
        btnRegistrarDeposito.TabIndex = 7
        btnRegistrarDeposito.Text = "Registrar Depósito"
        btnRegistrarDeposito.UseVisualStyleBackColor = False
        ' 
        ' dgvHistorialDepositos
        ' 
        dgvHistorialDepositos.AllowUserToAddRows = False
        dgvHistorialDepositos.AllowUserToOrderColumns = True
        dgvHistorialDepositos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHistorialDepositos.Location = New Point(25, 257)
        dgvHistorialDepositos.Name = "dgvHistorialDepositos"
        dgvHistorialDepositos.Size = New Size(670, 160)
        dgvHistorialDepositos.TabIndex = 8
        ' 
        ' Depositos
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 500)
        Controls.Add(pnlContenedorDeposito)
        Name = "Depositos"
        RightToLeft = RightToLeft.Yes
        Text = "Depositos"
        pnlContenedorDeposito.ResumeLayout(False)
        pnlContenedorDeposito.PerformLayout()
        CType(dgvHistorialDepositos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContenedorDeposito As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents cmbTipoDeposito As ComboBox
    Friend WithEvents dtpFechaDeposito As DateTimePicker
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents btnRegistrarDeposito As Button
    Friend WithEvents dgvHistorialDepositos As DataGridView
End Class


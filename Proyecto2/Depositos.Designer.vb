<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Depositos
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
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
        pnlContenedorDeposito.Location = New Point(46, 48)
        pnlContenedorDeposito.Margin = New Padding(6, 7, 6, 7)
        pnlContenedorDeposito.Name = "pnlContenedorDeposito"
        pnlContenedorDeposito.Size = New Size(823, 603)
        pnlContenedorDeposito.TabIndex = 0
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblTitulo.Location = New Point(30, 157)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(251, 32)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Registro de Depósitos"
        ' 
        ' lblTipo
        ' 
        lblTipo.AutoSize = True
        lblTipo.Font = New Font("Segoe UI", 9F)
        lblTipo.Location = New Point(30, 221)
        lblTipo.Name = "lblTipo"
        lblTipo.Size = New Size(125, 20)
        lblTipo.TabIndex = 1
        lblTipo.Text = "Tipo de Depósito"
        ' 
        ' cmbTipoDeposito
        ' 
        cmbTipoDeposito.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTipoDeposito.Location = New Point(183, 211)
        cmbTipoDeposito.Margin = New Padding(3, 4, 3, 4)
        cmbTipoDeposito.Name = "cmbTipoDeposito"
        cmbTipoDeposito.Size = New Size(228, 28)
        cmbTipoDeposito.TabIndex = 2
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Location = New Point(462, 216)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(47, 20)
        lblFecha.TabIndex = 3
        lblFecha.Text = "Fecha"
        ' 
        ' dtpFechaDeposito
        ' 
        dtpFechaDeposito.Format = DateTimePickerFormat.Short
        dtpFechaDeposito.Location = New Point(515, 211)
        dtpFechaDeposito.Margin = New Padding(3, 4, 3, 4)
        dtpFechaDeposito.Name = "dtpFechaDeposito"
        dtpFechaDeposito.Size = New Size(228, 27)
        dtpFechaDeposito.TabIndex = 4
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Location = New Point(64, 286)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(53, 20)
        lblMonto.TabIndex = 5
        lblMonto.Text = "Monto"
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(183, 283)
        txtMonto.Margin = New Padding(3, 4, 3, 4)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(228, 27)
        txtMonto.TabIndex = 6
        ' 
        ' btnRegistrarDeposito
        ' 
        btnRegistrarDeposito.BackColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        btnRegistrarDeposito.ForeColor = Color.White
        btnRegistrarDeposito.Location = New Point(515, 273)
        btnRegistrarDeposito.Margin = New Padding(3, 4, 3, 4)
        btnRegistrarDeposito.Name = "btnRegistrarDeposito"
        btnRegistrarDeposito.Size = New Size(229, 47)
        btnRegistrarDeposito.TabIndex = 7
        btnRegistrarDeposito.Text = "Registrar Depósito"
        btnRegistrarDeposito.UseVisualStyleBackColor = False
        ' 
        ' dgvHistorialDepositos
        ' 
        dgvHistorialDepositos.AllowUserToAddRows = False
        dgvHistorialDepositos.AllowUserToOrderColumns = True
        dgvHistorialDepositos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHistorialDepositos.ColumnHeadersHeight = 29
        dgvHistorialDepositos.Location = New Point(29, 343)
        dgvHistorialDepositos.Margin = New Padding(3, 4, 3, 4)
        dgvHistorialDepositos.Name = "dgvHistorialDepositos"
        dgvHistorialDepositos.RowHeadersWidth = 51
        dgvHistorialDepositos.Size = New Size(766, 213)
        dgvHistorialDepositos.TabIndex = 8
        ' 
        ' Depositos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 667)
        Controls.Add(pnlContenedorDeposito)
        Margin = New Padding(3, 4, 3, 4)
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


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cheques
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        
        Me.BackColor = Color.FromArgb(240, 244, 248)
        ' Keep default FormBorderStyle and size when embedded; do not set StartPosition or explicit Size
        ' Me.FormBorderStyle = FormBorderStyle.None
        ' Me.StartPosition = FormStartPosition.CenterScreen
        ' Me.Size = New Size(1000, 700)

        ' Panel principal contenedor
        Dim mainPanel As New Panel()
        mainPanel.Dock = DockStyle.Fill
        mainPanel.Padding = New Padding(30)
        mainPanel.BackColor = Color.FromArgb(240, 244, 248)
        Me.Controls.Add(mainPanel)

        ' Panel para el formulario
        Dim formPanel As New Panel()
        formPanel.Size = New Size(940, 640)
        formPanel.BackColor = Color.White
        formPanel.Location = New Point(30, 30)
        formPanel.Padding = New Padding(40)
        ' Agregar sombra y bordes redondeados
        ApplyShadowAndRound(formPanel)
        mainPanel.Controls.Add(formPanel)

        txtNumeroCheque = New TextBox()
        dtpFechaCheque = New DateTimePicker()
        cmbProveedor = New ComboBox()
        txtMonto = New TextBox()
        txtMontoLetras = New TextBox()
        txtDetalle = New TextBox()
        cmbObjetoGasto = New ComboBox()
        dtpFechaAnulacion = New DateTimePicker()
        lblNumeroCheque = New Label()
        lblFechaCheque = New Label()
        lblProveedor = New Label()
        lblMonto = New Label()
        lblMontoLetras = New Label()
        lblDetalle = New Label()
        lblObjetoGasto = New Label()
        lblFechaAnulacion = New Label()
        btnRegistrar = New Button()
        btnAnular = New Button()
        dgvCheques = New DataGridView()
        lblTitulo = New Label()
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ChequesToolStripMenuItem = New ToolStripMenuItem()
        DepositosToolStripMenuItem = New ToolStripMenuItem()
        ConciliacionToolStripMenuItem = New ToolStripMenuItem()
        SalirDelSistemaToolStripMenuItem = New ToolStripMenuItem()
        CType(dgvCheques, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNumeroCheque
        ' 
        txtNumeroCheque.BorderStyle = BorderStyle.None
        txtNumeroCheque.Location = New Point(40, 120)
        txtNumeroCheque.Name = "txtNumeroCheque"
        txtNumeroCheque.Size = New Size(400, 35)
        txtNumeroCheque.TabIndex = 2
        txtNumeroCheque.Font = New Font("Segoe UI", 12.0F)
        txtNumeroCheque.BackColor = Color.FromArgb(250, 252, 255)
        ' Crear panel contenedor para efecto visual
        Dim pnlNumeroCheque As New Panel()
        pnlNumeroCheque.Size = New Size(400, 45)
        pnlNumeroCheque.Location = New Point(40, 120)
        pnlNumeroCheque.BackColor = Color.White
        pnlNumeroCheque.BorderStyle = BorderStyle.None
        ApplyShadowAndRound(pnlNumeroCheque)
        pnlNumeroCheque.Controls.Add(txtNumeroCheque)
        ' 
        ' dtpFechaCheque
        ' 
        dtpFechaCheque.Location = New Point(176, 142)
        dtpFechaCheque.Name = "dtpFechaCheque"
        dtpFechaCheque.Size = New Size(250, 25)
        dtpFechaCheque.TabIndex = 4
        dtpFechaCheque.Font = New Font("Segoe UI", 11.0F)
        dtpFechaCheque.Format = DateTimePickerFormat.Short
        ' 
        ' cmbProveedor
        ' 
        cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProveedor.Location = New Point(176, 182)
        cmbProveedor.Name = "cmbProveedor"
        cmbProveedor.Size = New Size(200, 23)
        cmbProveedor.TabIndex = 6
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(176, 222)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(200, 23)
        txtMonto.TabIndex = 8
        ' 
        ' txtMontoLetras
        ' 
        txtMontoLetras.Location = New Point(176, 262)
        txtMontoLetras.Name = "txtMontoLetras"
        txtMontoLetras.ReadOnly = True
        txtMontoLetras.Size = New Size(400, 23)
        txtMontoLetras.TabIndex = 10
        ' 
        ' txtDetalle
        ' 
        txtDetalle.Location = New Point(176, 302)
        txtDetalle.Name = "txtDetalle"
        txtDetalle.Size = New Size(400, 23)
        txtDetalle.TabIndex = 12
        ' 
        ' cmbObjetoGasto
        ' 
        cmbObjetoGasto.DropDownStyle = ComboBoxStyle.DropDownList
        cmbObjetoGasto.Location = New Point(176, 342)
        cmbObjetoGasto.Name = "cmbObjetoGasto"
        cmbObjetoGasto.Size = New Size(200, 23)
        cmbObjetoGasto.TabIndex = 14
        ' 
        ' dtpFechaAnulacion
        ' 
        dtpFechaAnulacion.Location = New Point(176, 382)
        dtpFechaAnulacion.Name = "dtpFechaAnulacion"
        dtpFechaAnulacion.Size = New Size(200, 23)
        dtpFechaAnulacion.TabIndex = 16
        dtpFechaAnulacion.Visible = False
        ' 
        ' lblNumeroCheque
        ' 
        lblNumeroCheque.Location = New Point(16, 102)
        lblNumeroCheque.Name = "lblNumeroCheque"
        lblNumeroCheque.Size = New Size(150, 23)
        lblNumeroCheque.TabIndex = 1
        lblNumeroCheque.Text = "Número de cheque:"
        ' 
        ' lblFechaCheque
        ' 
        lblFechaCheque.Location = New Point(16, 142)
        lblFechaCheque.Name = "lblFechaCheque"
        lblFechaCheque.Size = New Size(150, 23)
        lblFechaCheque.TabIndex = 3
        lblFechaCheque.Text = "Fecha del cheque:"
        ' 
        ' lblProveedor
        ' 
        lblProveedor.Location = New Point(16, 182)
        lblProveedor.Name = "lblProveedor"
        lblProveedor.Size = New Size(150, 23)
        lblProveedor.TabIndex = 5
        lblProveedor.Text = "Beneficiario/Proveedor:"
        ' 
        ' lblMonto
        ' 
        lblMonto.Location = New Point(16, 222)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(150, 23)
        lblMonto.TabIndex = 7
        lblMonto.Text = "Monto numérico:"
        ' 
        ' lblMontoLetras
        ' 
        lblMontoLetras.Location = New Point(16, 262)
        lblMontoLetras.Name = "lblMontoLetras"
        lblMontoLetras.Size = New Size(150, 23)
        lblMontoLetras.TabIndex = 9
        lblMontoLetras.Text = "Monto en letras:"
        ' 
        ' lblDetalle
        ' 
        lblDetalle.Location = New Point(16, 302)
        lblDetalle.Name = "lblDetalle"
        lblDetalle.Size = New Size(150, 23)
        lblDetalle.TabIndex = 11
        lblDetalle.Text = "Detalle:"
        ' 
        ' lblObjetoGasto
        ' 
        lblObjetoGasto.Location = New Point(16, 342)
        lblObjetoGasto.Name = "lblObjetoGasto"
        lblObjetoGasto.Size = New Size(150, 23)
        lblObjetoGasto.TabIndex = 13
        lblObjetoGasto.Text = "Objeto de gasto:"
        ' 
        ' lblFechaAnulacion
        ' 
        lblFechaAnulacion.Location = New Point(16, 382)
        lblFechaAnulacion.Name = "lblFechaAnulacion"
        lblFechaAnulacion.Size = New Size(150, 23)
        lblFechaAnulacion.TabIndex = 15
        lblFechaAnulacion.Text = "Fecha de anulación:"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.BackColor = Color.FromArgb(CByte(63), CByte(114), CByte(241))
        btnRegistrar.FlatStyle = FlatStyle.Flat
        btnRegistrar.FlatAppearance.BorderSize = 0
        btnRegistrar.ForeColor = Color.White
        btnRegistrar.Location = New Point(176, 422)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(180, 40)
        btnRegistrar.TabIndex = 17
        btnRegistrar.Text = "Registrar cheque"
        btnRegistrar.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnRegistrar.Cursor = Cursors.Hand
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' btnAnular
        ' 
        btnAnular.BackColor = Color.FromArgb(CByte(200), CByte(60), CByte(60))
        btnAnular.FlatStyle = FlatStyle.Flat
        btnAnular.ForeColor = Color.White
        btnAnular.Location = New Point(336, 422)
        btnAnular.Name = "btnAnular"
        btnAnular.Size = New Size(150, 30)
        btnAnular.TabIndex = 18
        btnAnular.Text = "Anular cheque"
        btnAnular.UseVisualStyleBackColor = False
        ' 
        ' dgvCheques
        ' 
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(220), CByte(230), CByte(240))
        dgvCheques.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        dgvCheques.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dgvCheques.BackgroundColor = Color.White
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(60), CByte(120), CByte(200))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvCheques.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvCheques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.White
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle9.ForeColor = Color.Black
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvCheques.DefaultCellStyle = DataGridViewCellStyle9
        dgvCheques.EnableHeadersVisualStyles = False
        dgvCheques.GridColor = Color.LightGray
        dgvCheques.Location = New Point(596, 102)
        dgvCheques.Name = "dgvCheques"
        dgvCheques.Size = New Size(280, 350)
        dgvCheques.TabIndex = 19
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblTitulo.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblTitulo.Location = New Point(40, 40)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(600, 50)
        lblTitulo.TabIndex = 10
        lblTitulo.Text = "Gestión de Cheques Bancarios"
        
        ' Agregar línea decorativa bajo el título
        Dim lineaDecorativa As New Panel()
        lineaDecorativa.BackColor = Color.FromArgb(CByte(63), CByte(114), CByte(241))
        lineaDecorativa.Size = New Size(100, 3)
        lineaDecorativa.Location = New Point(40, 95)
        formPanel.Controls.Add(lineaDecorativa)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.LightGray
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(900, 24)
        MenuStrip1.TabIndex = 20
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripSeparator1, ChequesToolStripMenuItem, DepositosToolStripMenuItem, ConciliacionToolStripMenuItem, SalirDelSistemaToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(50, 20)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(155, 6)
        ' 
        ' ChequesToolStripMenuItem
        ' 
        ChequesToolStripMenuItem.Name = "ChequesToolStripMenuItem"
        ChequesToolStripMenuItem.Size = New Size(158, 22)
        ChequesToolStripMenuItem.Text = "Cheques "
        ' 
        ' DepositosToolStripMenuItem
        ' 
        DepositosToolStripMenuItem.Name = "DepositosToolStripMenuItem"
        DepositosToolStripMenuItem.Size = New Size(158, 22)
        DepositosToolStripMenuItem.Text = "Depositos"
        ' 
        ' ConciliacionToolStripMenuItem
        ' 
        ConciliacionToolStripMenuItem.Name = "ConciliacionToolStripMenuItem"
        ConciliacionToolStripMenuItem.Size = New Size(158, 22)
        ConciliacionToolStripMenuItem.Text = "Conciliacion"
        ' 
        ' SalirDelSistemaToolStripMenuItem
        ' 
        SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        SalirDelSistemaToolStripMenuItem.Size = New Size(158, 22)
        SalirDelSistemaToolStripMenuItem.Text = "Salir del sistema"
        ' 
        ' Cheques
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        ClientSize = New Size(900, 500)
        Controls.Add(MenuStrip1)
        Controls.Add(lblTitulo)
        Controls.Add(lblNumeroCheque)
        Controls.Add(txtNumeroCheque)
        Controls.Add(lblFechaCheque)
        Controls.Add(dtpFechaCheque)
        Controls.Add(lblProveedor)
        Controls.Add(cmbProveedor)
        Controls.Add(lblMonto)
        Controls.Add(txtMonto)
        Controls.Add(lblMontoLetras)
        Controls.Add(txtMontoLetras)
        Controls.Add(lblDetalle)
        Controls.Add(txtDetalle)
        Controls.Add(lblObjetoGasto)
        Controls.Add(cmbObjetoGasto)
        Controls.Add(lblFechaAnulacion)
        Controls.Add(dtpFechaAnulacion)
        Controls.Add(btnRegistrar)
        Controls.Add(btnAnular)
        Controls.Add(dgvCheques)
        Name = "Cheques"
        Text = "Cheques"
        CType(dgvCheques, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumeroCheque As TextBox
    Friend WithEvents dtpFechaCheque As DateTimePicker
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtMontoLetras As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents cmbObjetoGasto As ComboBox
    Friend WithEvents dtpFechaAnulacion As DateTimePicker
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnAnular As Button
    Friend WithEvents dgvCheques As DataGridView
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNumeroCheque As Label
    Friend WithEvents lblFechaCheque As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblMontoLetras As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblObjetoGasto As Label
    Friend WithEvents lblFechaAnulacion As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ChequesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepositosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConciliacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As ToolStripMenuItem
End Class

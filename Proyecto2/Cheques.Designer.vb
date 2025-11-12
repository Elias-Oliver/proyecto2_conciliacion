<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cheques
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlContent = New Panel()
        pnlCardHolder = New Panel()
        pnlForm = New Panel()
        pnlTopInner = New FlowLayoutPanel()
        btnTopRegistrar = New Button()
        btnTopConsultar = New Button()
        lblTitulo = New Label()
        tblFields = New TableLayoutPanel()
        txtNumeroCheque = New TextBox()
        dtpFechaCheque = New DateTimePicker()
        lblProveedor = New Label()
        cmbProveedor = New ComboBox()
        lblObjetoGasto = New Label()
        cmbObjetoGasto = New ComboBox()
        lblMonto = New Label()
        txtMonto = New TextBox()
        lblMontoLetras = New Label()
        txtMontoLetras = New TextBox()
        lblDetalle = New Label()
        lblFechaCheque = New Label()
        lblNumeroCheque = New Label()
        txtDetalle = New TextBox()
        btnRegistrarBottom = New Button()
        pnlConsultar = New Panel()
        lblConsultarTitle = New Label()
        lblConsultarMessage = New Label()
        dgvCheques = New DataGridView()
        pnlMain.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlCardHolder.SuspendLayout()
        pnlForm.SuspendLayout()
        pnlTopInner.SuspendLayout()
        tblFields.SuspendLayout()
        pnlConsultar.SuspendLayout()
        CType(dgvCheques, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(249))
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1200, 700)
        pnlMain.TabIndex = 0
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(249))
        pnlContent.Controls.Add(pnlCardHolder)
        pnlContent.Controls.Add(pnlConsultar)
        pnlContent.Controls.Add(dgvCheques)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(20)
        pnlContent.Size = New Size(1200, 700)
        pnlContent.TabIndex = 1
        ' 
        ' pnlCardHolder
        ' 
        pnlCardHolder.BackColor = Color.Transparent
        pnlCardHolder.Controls.Add(pnlForm)
        pnlCardHolder.Dock = DockStyle.Bottom
        pnlCardHolder.Location = New Point(20, 129)
        pnlCardHolder.Name = "pnlCardHolder"
        pnlCardHolder.Padding = New Padding(20, 40, 20, 20)
        pnlCardHolder.Size = New Size(1160, 551)
        pnlCardHolder.TabIndex = 0
        ' 
        ' pnlForm
        ' 
        pnlForm.BackColor = Color.White
        pnlForm.Controls.Add(pnlTopInner)
        pnlForm.Controls.Add(lblTitulo)
        pnlForm.Controls.Add(tblFields)
        pnlForm.Controls.Add(btnRegistrarBottom)
        pnlForm.Location = New Point(20, 77)
        pnlForm.Name = "pnlForm"
        pnlForm.Padding = New Padding(20)
        pnlForm.Size = New Size(1120, 474)
        pnlForm.TabIndex = 0
        ' 
        ' pnlTopInner
        ' 
        pnlTopInner.AutoSize = True
        pnlTopInner.Controls.Add(btnTopRegistrar)
        pnlTopInner.Controls.Add(btnTopConsultar)
        pnlTopInner.Location = New Point(20, 23)
        pnlTopInner.Name = "pnlTopInner"
        pnlTopInner.Size = New Size(338, 43)
        pnlTopInner.TabIndex = 0
        pnlTopInner.WrapContents = False
        ' 
        ' btnTopRegistrar
        ' 
        btnTopRegistrar.AutoSize = True
        btnTopRegistrar.BackColor = Color.White
        btnTopRegistrar.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(225), CByte(230))
        btnTopRegistrar.FlatStyle = FlatStyle.Flat
        btnTopRegistrar.Font = New Font("Segoe UI", 9F)
        btnTopRegistrar.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        btnTopRegistrar.Location = New Point(0, 0)
        btnTopRegistrar.Margin = New Padding(0, 0, 12, 0)
        btnTopRegistrar.Name = "btnTopRegistrar"
        btnTopRegistrar.Padding = New Padding(14, 8, 14, 8)
        btnTopRegistrar.Size = New Size(157, 43)
        btnTopRegistrar.TabIndex = 0
        btnTopRegistrar.Text = "  +  Registrar Cheque"
        btnTopRegistrar.UseVisualStyleBackColor = False
        ' 
        ' btnTopConsultar
        ' 
        btnTopConsultar.AutoSize = True
        btnTopConsultar.BackColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        btnTopConsultar.FlatAppearance.BorderSize = 0
        btnTopConsultar.FlatStyle = FlatStyle.Flat
        btnTopConsultar.Font = New Font("Segoe UI", 9F)
        btnTopConsultar.ForeColor = Color.White
        btnTopConsultar.Location = New Point(169, 0)
        btnTopConsultar.Margin = New Padding(0)
        btnTopConsultar.Name = "btnTopConsultar"
        btnTopConsultar.Padding = New Padding(14, 8, 14, 8)
        btnTopConsultar.Size = New Size(169, 41)
        btnTopConsultar.TabIndex = 1
        btnTopConsultar.Text = "  🔍  Consultar Cheques"
        btnTopConsultar.UseVisualStyleBackColor = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTitulo.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblTitulo.Location = New Point(19, 81)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(158, 21)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Registro de Cheque"
        ' 
        ' tblFields
        ' 
        tblFields.BackColor = Color.White
        tblFields.ColumnCount = 2
        tblFields.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblFields.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblFields.Controls.Add(txtNumeroCheque, 0, 1)
        tblFields.Controls.Add(dtpFechaCheque, 1, 1)
        tblFields.Controls.Add(lblProveedor, 0, 2)
        tblFields.Controls.Add(cmbProveedor, 0, 3)
        tblFields.Controls.Add(lblObjetoGasto, 1, 2)
        tblFields.Controls.Add(cmbObjetoGasto, 1, 3)
        tblFields.Controls.Add(lblMonto, 0, 4)
        tblFields.Controls.Add(txtMonto, 0, 5)
        tblFields.Controls.Add(lblMontoLetras, 1, 4)
        tblFields.Controls.Add(txtMontoLetras, 1, 5)
        tblFields.Controls.Add(lblDetalle, 0, 6)
        tblFields.Controls.Add(lblFechaCheque, 1, 0)
        tblFields.Controls.Add(lblNumeroCheque, 0, 0)
        tblFields.Controls.Add(txtDetalle, 0, 7)
        tblFields.Location = New Point(20, 115)
        tblFields.Name = "tblFields"
        tblFields.Padding = New Padding(0, 10, 0, 10)
        tblFields.RowCount = 8
        tblFields.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tblFields.RowStyles.Add(New RowStyle(SizeType.Absolute, 41F))
        tblFields.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tblFields.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        tblFields.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tblFields.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        tblFields.RowStyles.Add(New RowStyle(SizeType.Absolute, 17F))
        tblFields.RowStyles.Add(New RowStyle(SizeType.Absolute, 122F))
        tblFields.Size = New Size(1080, 291)
        tblFields.TabIndex = 1
        ' 
        ' txtNumeroCheque
        ' 
        txtNumeroCheque.BorderStyle = BorderStyle.FixedSingle
        txtNumeroCheque.Dock = DockStyle.Fill
        txtNumeroCheque.Font = New Font("Segoe UI", 10F)
        txtNumeroCheque.Location = New Point(3, 33)
        txtNumeroCheque.Name = "txtNumeroCheque"
        txtNumeroCheque.PlaceholderText = "Ej: 001234"
        txtNumeroCheque.Size = New Size(534, 25)
        txtNumeroCheque.TabIndex = 0
        ' 
        ' dtpFechaCheque
        ' 
        dtpFechaCheque.CustomFormat = "MM/dd/yyyy"
        dtpFechaCheque.Dock = DockStyle.Fill
        dtpFechaCheque.Font = New Font("Segoe UI", 10F)
        dtpFechaCheque.Format = DateTimePickerFormat.Custom
        dtpFechaCheque.Location = New Point(543, 33)
        dtpFechaCheque.Name = "dtpFechaCheque"
        dtpFechaCheque.Size = New Size(534, 25)
        dtpFechaCheque.TabIndex = 0
        ' 
        ' lblProveedor
        ' 
        lblProveedor.AutoSize = True
        lblProveedor.Font = New Font("Segoe UI", 9F)
        lblProveedor.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblProveedor.Location = New Point(3, 71)
        lblProveedor.Name = "lblProveedor"
        lblProveedor.Size = New Size(134, 15)
        lblProveedor.TabIndex = 0
        lblProveedor.Text = "Beneficiario / Proveedor"
        ' 
        ' cmbProveedor
        ' 
        cmbProveedor.Dock = DockStyle.Fill
        cmbProveedor.FlatStyle = FlatStyle.System
        cmbProveedor.Font = New Font("Segoe UI", 10F)
        cmbProveedor.FormattingEnabled = True
        cmbProveedor.Location = New Point(3, 94)
        cmbProveedor.Name = "cmbProveedor"
        cmbProveedor.Size = New Size(534, 25)
        cmbProveedor.TabIndex = 0
        ' 
        ' lblObjetoGasto
        ' 
        lblObjetoGasto.AutoSize = True
        lblObjetoGasto.Font = New Font("Segoe UI", 9F)
        lblObjetoGasto.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblObjetoGasto.Location = New Point(543, 71)
        lblObjetoGasto.Name = "lblObjetoGasto"
        lblObjetoGasto.Size = New Size(92, 15)
        lblObjetoGasto.TabIndex = 0
        lblObjetoGasto.Text = "Objeto de Gasto"
        ' 
        ' cmbObjetoGasto
        ' 
        cmbObjetoGasto.Dock = DockStyle.Fill
        cmbObjetoGasto.FlatStyle = FlatStyle.System
        cmbObjetoGasto.Font = New Font("Segoe UI", 10F)
        cmbObjetoGasto.FormattingEnabled = True
        cmbObjetoGasto.Location = New Point(543, 94)
        cmbObjetoGasto.Name = "cmbObjetoGasto"
        cmbObjetoGasto.Size = New Size(534, 25)
        cmbObjetoGasto.TabIndex = 0
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Font = New Font("Segoe UI", 9F)
        lblMonto.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblMonto.Location = New Point(3, 129)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(105, 15)
        lblMonto.TabIndex = 0
        lblMonto.Text = "Monto (numérico)"
        ' 
        ' txtMonto
        ' 
        txtMonto.BorderStyle = BorderStyle.FixedSingle
        txtMonto.Dock = DockStyle.Fill
        txtMonto.Font = New Font("Segoe UI", 10F)
        txtMonto.Location = New Point(3, 152)
        txtMonto.Name = "txtMonto"
        txtMonto.PlaceholderText = "0.00"
        txtMonto.Size = New Size(534, 25)
        txtMonto.TabIndex = 0
        ' 
        ' lblMontoLetras
        ' 
        lblMontoLetras.AutoSize = True
        lblMontoLetras.Font = New Font("Segoe UI", 9F)
        lblMontoLetras.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblMontoLetras.Location = New Point(543, 129)
        lblMontoLetras.Name = "lblMontoLetras"
        lblMontoLetras.Size = New Size(98, 15)
        lblMontoLetras.TabIndex = 0
        lblMontoLetras.Text = "Monto (en letras)"
        ' 
        ' txtMontoLetras
        ' 
        txtMontoLetras.BorderStyle = BorderStyle.FixedSingle
        txtMontoLetras.Dock = DockStyle.Fill
        txtMontoLetras.Font = New Font("Segoe UI", 10F)
        txtMontoLetras.Location = New Point(543, 152)
        txtMontoLetras.Name = "txtMontoLetras"
        txtMontoLetras.PlaceholderText = "Se genera automáticamente"
        txtMontoLetras.ReadOnly = True
        txtMontoLetras.Size = New Size(534, 25)
        txtMontoLetras.TabIndex = 0
        ' 
        ' lblDetalle
        ' 
        lblDetalle.AutoSize = True
        lblDetalle.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDetalle.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblDetalle.Location = New Point(3, 194)
        lblDetalle.Name = "lblDetalle"
        lblDetalle.Size = New Size(47, 15)
        lblDetalle.TabIndex = 0
        lblDetalle.Text = "Detalle"
        ' 
        ' lblFechaCheque
        ' 
        lblFechaCheque.AutoSize = True
        lblFechaCheque.Font = New Font("Segoe UI", 9F)
        lblFechaCheque.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblFechaCheque.Location = New Point(543, 10)
        lblFechaCheque.Name = "lblFechaCheque"
        lblFechaCheque.Size = New Size(101, 15)
        lblFechaCheque.TabIndex = 0
        lblFechaCheque.Text = "Fecha del Cheque"
        ' 
        ' lblNumeroCheque
        ' 
        lblNumeroCheque.AutoSize = True
        lblNumeroCheque.Font = New Font("Segoe UI", 9F)
        lblNumeroCheque.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblNumeroCheque.Location = New Point(3, 10)
        lblNumeroCheque.Name = "lblNumeroCheque"
        lblNumeroCheque.Size = New Size(111, 15)
        lblNumeroCheque.TabIndex = 0
        lblNumeroCheque.Text = "Número de Cheque"
        ' 
        ' txtDetalle
        ' 
        tblFields.SetColumnSpan(txtDetalle, 2)
        txtDetalle.Location = New Point(3, 214)
        txtDetalle.Multiline = True
        txtDetalle.Name = "txtDetalle"
        txtDetalle.Size = New Size(1074, 71)
        txtDetalle.TabIndex = 1
        ' 
        ' btnRegistrarBottom
        ' 
        btnRegistrarBottom.BackColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        btnRegistrarBottom.Cursor = Cursors.Hand
        btnRegistrarBottom.FlatAppearance.BorderSize = 0
        btnRegistrarBottom.FlatStyle = FlatStyle.Flat
        btnRegistrarBottom.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnRegistrarBottom.ForeColor = Color.White
        btnRegistrarBottom.Location = New Point(20, 427)
        btnRegistrarBottom.Name = "btnRegistrarBottom"
        btnRegistrarBottom.Size = New Size(1080, 44)
        btnRegistrarBottom.TabIndex = 2
        btnRegistrarBottom.Text = "Registrar Cheque"
        btnRegistrarBottom.UseVisualStyleBackColor = False
        ' 
        ' pnlConsultar
        ' 
        pnlConsultar.BackColor = Color.Transparent
        pnlConsultar.Controls.Add(lblConsultarTitle)
        pnlConsultar.Controls.Add(lblConsultarMessage)
        pnlConsultar.Dock = DockStyle.Fill
        pnlConsultar.Location = New Point(20, 20)
        pnlConsultar.Name = "pnlConsultar"
        pnlConsultar.Size = New Size(1160, 660)
        pnlConsultar.TabIndex = 1
        pnlConsultar.Visible = False
        ' 
        ' lblConsultarTitle
        ' 
        lblConsultarTitle.AutoSize = True
        lblConsultarTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblConsultarTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblConsultarTitle.Location = New Point(20, 20)
        lblConsultarTitle.Name = "lblConsultarTitle"
        lblConsultarTitle.Size = New Size(209, 20)
        lblConsultarTitle.TabIndex = 0
        lblConsultarTitle.Text = "Listado de Cheques Emitidos"
        ' 
        ' lblConsultarMessage
        ' 
        lblConsultarMessage.AutoSize = True
        lblConsultarMessage.Font = New Font("Segoe UI", 9F)
        lblConsultarMessage.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblConsultarMessage.Location = New Point(40, 50)
        lblConsultarMessage.Name = "lblConsultarMessage"
        lblConsultarMessage.Size = New Size(153, 15)
        lblConsultarMessage.TabIndex = 1
        lblConsultarMessage.Text = "No hay cheques registrados"
        ' 
        ' dgvCheques
        ' 
        dgvCheques.BackgroundColor = Color.White
        dgvCheques.BorderStyle = BorderStyle.None
        dgvCheques.Dock = DockStyle.Fill
        dgvCheques.Location = New Point(20, 20)
        dgvCheques.Name = "dgvCheques"
        dgvCheques.Size = New Size(1160, 660)
        dgvCheques.TabIndex = 1
        dgvCheques.Visible = False
        ' 
        ' Cheques
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1200, 700)
        Controls.Add(pnlMain)
        Name = "Cheques"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cheques"
        pnlMain.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlCardHolder.ResumeLayout(False)
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        pnlTopInner.ResumeLayout(False)
        pnlTopInner.PerformLayout()
        tblFields.ResumeLayout(False)
        tblFields.PerformLayout()
        pnlConsultar.ResumeLayout(False)
        pnlConsultar.PerformLayout()
        CType(dgvCheques, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents txtNumeroCheque As TextBox
    Friend WithEvents dtpFechaCheque As DateTimePicker
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtMontoLetras As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents cmbObjetoGasto As ComboBox
    Friend WithEvents dgvCheques As DataGridView
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNumeroCheque As Label
    Friend WithEvents lblFechaCheque As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblMontoLetras As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblObjetoGasto As Label
    Friend WithEvents pnlTopInner As FlowLayoutPanel
    Friend WithEvents btnTopRegistrar As Button
    Friend WithEvents btnTopConsultar As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlCardHolder As Panel
    Friend WithEvents pnlForm As Panel
    Friend WithEvents pnlConsultar As Panel
    Friend WithEvents lblConsultarTitle As Label
    Friend WithEvents lblConsultarMessage As Label
    Friend WithEvents tblFields As TableLayoutPanel
    Friend WithEvents btnRegistrarBottom As Button
End Class
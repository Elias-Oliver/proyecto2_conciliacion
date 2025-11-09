<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaginaPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblHeaderTitle = New Label()
        pnlNav = New Panel()
        flpNav = New FlowLayoutPanel()
        btnCheques = New Button()
        btnDepositos = New Button()
        btnConciliacion = New Button()
        btnSalir = New Button()
        pnlContent = New Panel()
        lblWelcome = New Label()
        pnlHeader.SuspendLayout()
        pnlNav.SuspendLayout()
        flpNav.SuspendLayout()
        pnlContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 80)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(20)
        pnlHeader.Size = New Size(1000, 39)
        pnlHeader.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(40, 3)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(389, 32)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Sistema de Conciliación Bancaria"
        ' 
        ' pnlNav
        ' 
        pnlNav.BackColor = Color.FromArgb(CByte(20), CByte(30), CByte(48))
        pnlNav.Controls.Add(flpNav)
        pnlNav.Dock = DockStyle.Top
        pnlNav.Location = New Point(0, 0)
        pnlNav.Name = "pnlNav"
        pnlNav.Padding = New Padding(20)
        pnlNav.Size = New Size(1000, 80)
        pnlNav.TabIndex = 1
        ' 
        ' flpNav
        ' 
        flpNav.AutoSize = True
        flpNav.BackColor = Color.Transparent
        flpNav.Controls.Add(btnCheques)
        flpNav.Controls.Add(btnDepositos)
        flpNav.Controls.Add(btnConciliacion)
        flpNav.Controls.Add(btnSalir)
        flpNav.Location = New Point(40, 20)
        flpNav.Name = "flpNav"
        flpNav.Size = New Size(630, 40)
        flpNav.TabIndex = 0
        flpNav.WrapContents = False
        ' 
        ' btnCheques
        ' 
        btnCheques.BackColor = Color.Transparent
        btnCheques.Cursor = Cursors.Hand
        btnCheques.FlatAppearance.BorderSize = 0
        btnCheques.FlatStyle = FlatStyle.Flat
        btnCheques.Font = New Font("Segoe UI", 9.0F)
        btnCheques.ForeColor = Color.White
        btnCheques.Location = New Point(0, 0)
        btnCheques.Margin = New Padding(0, 0, 10, 0)
        btnCheques.Name = "btnCheques"
        btnCheques.Size = New Size(140, 40)
        btnCheques.TabIndex = 0
        btnCheques.Text = "Cheques"
        btnCheques.UseVisualStyleBackColor = False
        ' 
        ' btnDepositos
        ' 
        btnDepositos.BackColor = Color.Transparent
        btnDepositos.Cursor = Cursors.Hand
        btnDepositos.FlatAppearance.BorderSize = 0
        btnDepositos.FlatStyle = FlatStyle.Flat
        btnDepositos.Font = New Font("Segoe UI", 9.0F)
        btnDepositos.ForeColor = Color.White
        btnDepositos.Location = New Point(150, 0)
        btnDepositos.Margin = New Padding(0, 0, 10, 0)
        btnDepositos.Name = "btnDepositos"
        btnDepositos.Size = New Size(140, 40)
        btnDepositos.TabIndex = 1
        btnDepositos.Text = "Depósitos"
        btnDepositos.UseVisualStyleBackColor = False
        ' 
        ' btnConciliacion
        ' 
        btnConciliacion.BackColor = Color.Transparent
        btnConciliacion.Cursor = Cursors.Hand
        btnConciliacion.FlatAppearance.BorderSize = 0
        btnConciliacion.FlatStyle = FlatStyle.Flat
        btnConciliacion.Font = New Font("Segoe UI", 9.0F)
        btnConciliacion.ForeColor = Color.White
        btnConciliacion.Location = New Point(300, 0)
        btnConciliacion.Margin = New Padding(0, 0, 10, 0)
        btnConciliacion.Name = "btnConciliacion"
        btnConciliacion.Size = New Size(160, 40)
        btnConciliacion.TabIndex = 2
        btnConciliacion.Text = "Conciliación"
        btnConciliacion.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.Transparent
        btnSalir.Cursor = Cursors.Hand
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Segoe UI", 9.0F)
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(470, 0)
        btnSalir.Margin = New Padding(0)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(160, 40)
        btnSalir.TabIndex = 3
        btnSalir.Text = "Salir a inicio de sesion"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        pnlContent.Controls.Add(lblWelcome)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(30)
        pnlContent.Size = New Size(1000, 700)
        pnlContent.TabIndex = 2
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Dock = DockStyle.Fill
        lblWelcome.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(82), CByte(95), CByte(110))
        lblWelcome.Location = New Point(30, 30)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(940, 640)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Bienvenido al Sistema de Conciliación Bancaria" & vbCrLf & "Seleccione una opción del menú superior para comenzar"
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PaginaPrincipal
        ' 
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        ClientSize = New Size(1000, 700)
        Controls.Add(pnlHeader)
        Controls.Add(pnlNav)
        Controls.Add(pnlContent)
        FormBorderStyle = FormBorderStyle.None
        Name = "PaginaPrincipal"
        Text = "Sistema de Conciliación Bancaria"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlNav.ResumeLayout(False)
        pnlNav.PerformLayout()
        flpNav.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents pnlNav As Panel
    Friend WithEvents flpNav As FlowLayoutPanel
    Friend WithEvents btnCheques As Button
    Friend WithEvents btnDepositos As Button
    Friend WithEvents btnConciliacion As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblWelcome As Label
End Class

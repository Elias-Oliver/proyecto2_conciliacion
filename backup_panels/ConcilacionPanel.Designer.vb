<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _Partial Class ConcilacionPanelPartial Class ConcilacionPanel

Partial Class ConcilacionPanel

    Inherits System.Windows.Forms.UserControl    'Form overrides dispose to clean up the component list.    Inherits System.Windows.Forms.UserControl



    'UserControl overrides dispose to clean up the component list.    <System.Diagnostics.DebuggerNonUserCode()>

    <System.Diagnostics.DebuggerNonUserCode()> _

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)    Protected Overrides Sub Dispose(ByVal disposing As Boolean)    'UserControl overrides dispose to clean up the component list.

        Try

            If disposing AndAlso components IsNot Nothing Then        Try    <System.Diagnostics.DebuggerNonUserCode()>

                components.Dispose()

            End If            If disposing AndAlso components IsNot Nothing Then    Protected Overrides Sub Dispose(ByVal disposing As Boolean)

        Finally

            MyBase.Dispose(disposing)                components.Dispose()        Try

        End Try

    End Sub            End If            If disposing AndAlso components IsNot Nothing Then



    'Required by the Windows Form Designer        Finally                components.Dispose()

    Private components As System.ComponentModel.IContainer

            MyBase.Dispose(disposing)            End If

    <System.Diagnostics.DebuggerStepThrough()> _

    Private Sub InitializeComponent()        End Try        Finally

        Me.pnlTools = New System.Windows.Forms.Panel()

        Me.pnlBody = New System.Windows.Forms.Panel()    End Sub            MyBase.Dispose(disposing)

        Me.lblTitle = New System.Windows.Forms.Label()

        Me.SuspendLayout()        End Try

        '

        'pnlTools    'Required by the Windows Form Designer    End Sub

        '

        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top    Private components As System.ComponentModel.IContainer

        Me.pnlTools.Height = 60

        Me.pnlTools.BackColor = System.Drawing.Color.White    'Required by the Windows Form Designer

        '

        'lblTitle    'NOTE: The following procedure is required by the Windows Form Designer    Private components As System.ComponentModel.IContainer

        '

        Me.lblTitle.AutoSize = True    'It can be modified using the Windows Form Designer.  

        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)

        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 58, 71)    'Do not modify it using the code editor.    'NOTE: The following procedure is required by the Windows Form Designer

        Me.lblTitle.Location = New System.Drawing.Point(20, 15)

        Me.lblTitle.Text = "Conciliación"    <System.Diagnostics.DebuggerStepThrough()>    'It can be modified using the Windows Form Designer.  

        Me.pnlTools.Controls.Add(Me.lblTitle)

        '    Private Sub InitializeComponent()    'Do not modify it using the code editor.

        'pnlBody

        '        components = New System.ComponentModel.Container()    <System.Diagnostics.DebuggerStepThrough()>

        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill

        Me.pnlBody.BackColor = System.Drawing.Color.WhiteSmoke            Private Sub InitializeComponent()



        Me.Controls.Add(Me.pnlBody)        Me.pnlTools = New Panel()        Me.pnlTools = New System.Windows.Forms.Panel()

        Me.Controls.Add(Me.pnlTools)

        Me.btnNueva = New Button()        Me.btnNueva = New System.Windows.Forms.Button()

        Me.ResumeLayout(False)

    End Sub        Me.btnHistorial = New Button()        Me.btnHistorial = New System.Windows.Forms.Button()



    Friend WithEvents pnlTools As Panel        Me.pnlRegistro = New Panel()        Me.pnlRegistro = New System.Windows.Forms.Panel()

    Friend WithEvents pnlBody As Panel

    Friend WithEvents lblTitle As Label        Me.lblTitulo = New Label()        Me.lblTitulo = New System.Windows.Forms.Label()

End Class
        Me.lblSubtitulo = New Label()        Me.lblSubtitulo = New System.Windows.Forms.Label()

        Me.lblMes = New Label()        Me.lblMes = New System.Windows.Forms.Label()

        Me.cmbMes = New ComboBox()        Me.cmbMes = New System.Windows.Forms.ComboBox()

        Me.lblAnio = New Label()        Me.lblAnio = New System.Windows.Forms.Label()

        Me.txtAnio = New TextBox()        Me.txtAnio = New System.Windows.Forms.TextBox()

        Me.lblSaldoLibros = New Label()        Me.lblSaldoLibros = New System.Windows.Forms.Label()

        Me.txtSaldoLibros = New TextBox()        Me.txtSaldoLibros = New System.Windows.Forms.TextBox()

        Me.lblDepositosTransito = New Label()        Me.lblDepositosTransito = New System.Windows.Forms.Label()

        Me.txtDepositosTransito = New TextBox()        Me.txtDepositosTransito = New System.Windows.Forms.TextBox()

        Me.lblChequesPendientes = New Label()        Me.lblChequesPendientes = New System.Windows.Forms.Label()

        Me.txtChequesPendientes = New TextBox()        Me.txtChequesPendientes = New System.Windows.Forms.TextBox()

        Me.lblSaldoConciliado = New Label()        Me.lblSaldoConciliado = New System.Windows.Forms.Label()

        Me.txtSaldoConciliado = New TextBox()        Me.txtSaldoConciliado = New System.Windows.Forms.TextBox()

        Me.lblSaldoBancario = New Label()        Me.lblSaldoBancario = New System.Windows.Forms.Label()

        Me.txtSaldoBancario = New TextBox()        Me.txtSaldoBancario = New System.Windows.Forms.TextBox()

        Me.btnGuardar = New Button()        Me.btnGuardar = New System.Windows.Forms.Button()



        'Add controls to panels        'Add controls to panels

        Me.pnlTools.Controls.Add(Me.btnNueva)        Me.pnlTools.SuspendLayout()

        Me.pnlTools.Controls.Add(Me.btnHistorial)        Me.pnlRegistro.SuspendLayout()



        Me.pnlRegistro.Controls.Add(Me.lblTitulo)        'Add controls to panels

        Me.pnlRegistro.Controls.Add(Me.lblSubtitulo)        Me.pnlTools.Controls.Add(Me.btnNueva)

        Me.pnlRegistro.Controls.Add(Me.lblMes)        Me.pnlTools.Controls.Add(Me.btnHistorial)

        Me.pnlRegistro.Controls.Add(Me.cmbMes)        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top

        Me.pnlRegistro.Controls.Add(Me.lblAnio)

        Me.pnlRegistro.Controls.Add(Me.txtAnio)        Me.pnlRegistro.Controls.Add(Me.lblTitulo)

        Me.pnlRegistro.Controls.Add(Me.lblSaldoLibros)        Me.pnlRegistro.Controls.Add(Me.lblSubtitulo)

        Me.pnlRegistro.Controls.Add(Me.txtSaldoLibros)        Me.pnlRegistro.Controls.Add(Me.lblMes)

        Me.pnlRegistro.Controls.Add(Me.lblDepositosTransito)        Me.pnlRegistro.Controls.Add(Me.cmbMes)

        Me.pnlRegistro.Controls.Add(Me.txtDepositosTransito)        Me.pnlRegistro.Controls.Add(Me.lblAnio)

        Me.pnlRegistro.Controls.Add(Me.lblChequesPendientes)        Me.pnlRegistro.Controls.Add(Me.txtAnio)

        Me.pnlRegistro.Controls.Add(Me.txtChequesPendientes)        Me.pnlRegistro.Controls.Add(Me.lblSaldoLibros)

        Me.pnlRegistro.Controls.Add(Me.lblSaldoConciliado)        Me.pnlRegistro.Controls.Add(Me.txtSaldoLibros)

        Me.pnlRegistro.Controls.Add(Me.txtSaldoConciliado)        Me.pnlRegistro.Controls.Add(Me.lblDepositosTransito)

        Me.pnlRegistro.Controls.Add(Me.lblSaldoBancario)        Me.pnlRegistro.Controls.Add(Me.txtDepositosTransito)

        Me.pnlRegistro.Controls.Add(Me.txtSaldoBancario)        Me.pnlRegistro.Controls.Add(Me.lblChequesPendientes)

        Me.pnlRegistro.Controls.Add(Me.btnGuardar)        Me.pnlRegistro.Controls.Add(Me.txtChequesPendientes)

        Me.pnlRegistro.Controls.Add(Me.lblSaldoConciliado)

        'Add panels to form        Me.pnlRegistro.Controls.Add(Me.txtSaldoConciliado)

        Me.Controls.Add(Me.pnlRegistro)        Me.pnlRegistro.Controls.Add(Me.lblSaldoBancario)

        Me.Controls.Add(Me.pnlTools)        Me.pnlRegistro.Controls.Add(Me.txtSaldoBancario)

        Me.pnlRegistro.Controls.Add(Me.btnGuardar)

        'Configure panel docking        Me.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Fill

        Me.pnlTools.Dock = DockStyle.Top

        Me.pnlRegistro.Dock = DockStyle.Fill        'Add panels to UserControl

    End Sub        Me.Controls.Add(Me.pnlRegistro)

        Me.Controls.Add(Me.pnlTools)

    Friend WithEvents pnlTools As Panel

    Friend WithEvents btnNueva As Button        'Resume layouts

    Friend WithEvents btnHistorial As Button        Me.pnlTools.ResumeLayout(False)

    Friend WithEvents pnlRegistro As Panel        Me.pnlRegistro.ResumeLayout(False)

    Friend WithEvents lblTitulo As Label    End Sub

    Friend WithEvents lblSubtitulo As Label

    Friend WithEvents lblMes As Label    Friend WithEvents pnlTools As Panel

    Friend WithEvents cmbMes As ComboBox    Friend WithEvents btnNueva As Button

    Friend WithEvents lblAnio As Label    Friend WithEvents btnHistorial As Button

    Friend WithEvents txtAnio As TextBox    Friend WithEvents pnlRegistro As Panel

    Friend WithEvents lblSaldoLibros As Label    Friend WithEvents lblTitulo As Label

    Friend WithEvents txtSaldoLibros As TextBox    Friend WithEvents lblSubtitulo As Label

    Friend WithEvents lblDepositosTransito As Label    Friend WithEvents lblMes As Label

    Friend WithEvents txtDepositosTransito As TextBox    Friend WithEvents cmbMes As ComboBox

    Friend WithEvents lblChequesPendientes As Label    Friend WithEvents lblAnio As Label

    Friend WithEvents txtChequesPendientes As TextBox    Friend WithEvents txtAnio As TextBox

    Friend WithEvents lblSaldoConciliado As Label    Friend WithEvents lblSaldoLibros As Label

    Friend WithEvents txtSaldoConciliado As TextBox    Friend WithEvents txtSaldoLibros As TextBox

    Friend WithEvents lblSaldoBancario As Label    Friend WithEvents lblDepositosTransito As Label

    Friend WithEvents txtSaldoBancario As TextBox    Friend WithEvents txtDepositosTransito As TextBox

    Friend WithEvents btnGuardar As Button    Friend WithEvents lblChequesPendientes As Label

End Class    Friend WithEvents txtChequesPendientes As TextBox
    Friend WithEvents lblSaldoConciliado As Label
    Friend WithEvents txtSaldoConciliado As TextBox
    Friend WithEvents lblSaldoBancario As Label
    Friend WithEvents txtSaldoBancario As TextBox
    Friend WithEvents btnGuardar As Button
End Class
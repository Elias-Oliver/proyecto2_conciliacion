<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.lblLoginTitle = New System.Windows.Forms.Label()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.lblUserIcon = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.lblPassIcon = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        ' Form1
        '
        Me.BackColor = System.Drawing.Color.FromArgb(40, 60, 120)
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Name = "Form1"
        Me.Text = "Form1"
        '
        ' pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(220, 220, 230)
        Me.pnlLogin.Location = New System.Drawing.Point(100, 90)
        Me.pnlLogin.Size = New System.Drawing.Size(400, 220)
        Me.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        '
        ' lblLoginTitle
        '
        Me.lblLoginTitle.Text = "USER LOGIN"
        Me.lblLoginTitle.Font = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        Me.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 80)
        Me.lblLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoginTitle.Size = New System.Drawing.Size(400, 30)
        Me.lblLoginTitle.Location = New System.Drawing.Point(0, 10)
        '
        ' pnlUser
        '
        Me.pnlUser.BackColor = System.Drawing.Color.White
        Me.pnlUser.Location = New System.Drawing.Point(30, 50)
        Me.pnlUser.Size = New System.Drawing.Size(340, 40)
        Me.pnlUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        '
        ' lblUserIcon
        '
        Me.lblUserIcon.Text = "@"
        Me.lblUserIcon.Font = New System.Drawing.Font("Segoe UI", 16)
        Me.lblUserIcon.ForeColor = System.Drawing.Color.Gray
        Me.lblUserIcon.Location = New System.Drawing.Point(10, 7)
        Me.lblUserIcon.Size = New System.Drawing.Size(30, 30)
        '
        ' txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(50, 10)
        Me.txtUsuario.Size = New System.Drawing.Size(270, 23)
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 12)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Gray
        Me.txtUsuario.Text = ""
        '
        ' pnlPass
        '
        Me.pnlPass.BackColor = System.Drawing.Color.White
        Me.pnlPass.Location = New System.Drawing.Point(30, 100)
        Me.pnlPass.Size = New System.Drawing.Size(340, 40)
        Me.pnlPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        '
        ' lblPassIcon
        '
        Me.lblPassIcon.Text = "●"
        Me.lblPassIcon.Font = New System.Drawing.Font("Segoe UI", 16)
        Me.lblPassIcon.ForeColor = System.Drawing.Color.Gray
        Me.lblPassIcon.Location = New System.Drawing.Point(10, 7)
        Me.lblPassIcon.Size = New System.Drawing.Size(30, 30)
        '
        ' txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(50, 10)
        Me.txtContrasena.Size = New System.Drawing.Size(270, 23)
        Me.txtContrasena.Font = New System.Drawing.Font("Segoe UI", 12)
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasena.ForeColor = System.Drawing.Color.Gray
        Me.txtContrasena.Text = ""
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        ' btnLogin
        '
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.Location = New System.Drawing.Point(30, 160)
        Me.btnLogin.Size = New System.Drawing.Size(340, 40)
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold)
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(20, 30, 80)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.FlatAppearance.BorderSize = 0
        '
        ' Agregar controles a los paneles
        '
        Me.pnlUser.Controls.Add(Me.lblUserIcon)
        Me.pnlUser.Controls.Add(Me.txtUsuario)
        Me.pnlPass.Controls.Add(Me.lblPassIcon)
        Me.pnlPass.Controls.Add(Me.txtContrasena)
        Me.pnlLogin.Controls.Add(Me.lblLoginTitle)
        Me.pnlLogin.Controls.Add(Me.pnlUser)
        Me.pnlLogin.Controls.Add(Me.pnlPass)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.pnlLogin)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblLoginTitle As Label
    Friend WithEvents pnlUser As Panel
    Friend WithEvents lblUserIcon As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents pnlPass As Panel
    Friend WithEvents lblPassIcon As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnLogin As Button
End Class
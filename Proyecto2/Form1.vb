Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim contrasena As String = txtContrasena.Text.Trim()

        If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contrasena) Then
            MessageBox.Show("Ingrese usuario y contraseña", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TODO: Validar credenciales contra la base de datos o servicio.
        ' Por ahora, acepta cualquier usuario/contraseña no vacíos.
        Try
            Dim pagina As New PaginaPrincipal()
            pagina.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir la página principal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

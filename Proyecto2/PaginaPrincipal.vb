Imports Microsoft.VisualBasic.Logging

Public Class PaginaPrincipal
    Public Sub New()
        InitializeComponent()
        InitializeMainScreen()
    End Sub

    Private currentChildForm As Form = Nothing
    Private currentWrapper As Panel = Nothing

    Private Sub InitializeMainScreen()
        ' Aplicar estilos y enlazar eventos
        Try
            ControlStyles.StyleButton(btnCheques)
            ControlStyles.StyleButton(btnDepositos)
            ControlStyles.StyleButton(btnConciliacion)
            ControlStyles.StyleButton(btnSalir)
        Catch ex As Exception
            ' Si el módulo no existe o falla, seguir sin estilos
        End Try

        AddHandler btnCheques.Click, AddressOf BtnCheques_Click
        AddHandler btnDepositos.Click, AddressOf BtnDepositos_Click
        AddHandler btnConciliacion.Click, AddressOf BtnConciliacion_Click
        AddHandler btnSalir.Click, AddressOf BtnSalir_Click
    End Sub

    Private Sub BtnCheques_Click(sender As Object, e As EventArgs)
        ActivateButton(CType(sender, Button))
        OpenChildFormInPanel(New Cheques())
    End Sub

    Private Sub BtnDepositos_Click(sender As Object, e As EventArgs)
        ActivateButton(CType(sender, Button))
        OpenChildFormInPanel(New Depositos())
    End Sub

    Private Sub BtnConciliacion_Click(sender As Object, e As EventArgs)
        ActivateButton(CType(sender, Button))
        OpenChildFormInPanel(New Concilacion())
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Cerrar solo la página principal
            Me.Hide()

            ' Mostrar el login nuevamente
            Dim frmLogin As New Form1()
            frmLogin.Show()
        End If
    End Sub


    Private Sub OpenChildFormInPanel(child As Form)
        ' Si ya hay un formulario hijo del mismo tipo, sólo traer al frente
        If currentChildForm IsNot Nothing AndAlso currentChildForm.GetType() = child.GetType() Then
            If currentWrapper IsNot Nothing Then
                currentWrapper.BringToFront()
                currentChildForm.BringToFront()
            End If
            ' No crear otra instancia
            Return
        End If

        ' Eliminar sólo el formulario hijo/ wrapper actual conocido
        If currentWrapper IsNot Nothing Then
            If pnlContent.Controls.Contains(currentWrapper) Then
                pnlContent.Controls.Remove(currentWrapper)
            End If
            Try
                currentChildForm?.Dispose()
                currentWrapper.Dispose()
            Catch
            End Try
            currentChildForm = Nothing
            currentWrapper = Nothing
        End If

        ' Preparar wrapper para asegurar padding y que el hijo no quede bajo header
        Dim wrapper As New Panel()
        wrapper.Dock = DockStyle.Fill
        wrapper.Padding = New Padding(20)
        wrapper.BackColor = pnlContent.BackColor
        wrapper.AutoScroll = True
        wrapper.BringToFront() ' Asegurar que esté sobre otros controles

        ' Agregar wrapper al panel de contenido primero
        pnlContent.Controls.Add(wrapper)
        wrapper.BringToFront()

        ' Preparar formulario hijo para incrustar
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        child.Location = New Point(0, 0)
        child.Margin = New Padding(0)
        child.Padding = New Padding(0)
        child.BackColor = pnlContent.BackColor
        child.AutoScaleMode = AutoScaleMode.None
        child.AutoScroll = True

        ' Eliminar MenuStrip del formulario hijo si existe (evita superposición)
        For Each ms As MenuStrip In child.Controls.OfType(Of MenuStrip)().ToArray()
            child.Controls.Remove(ms)
            ms.Dispose()
        Next

        ' Agregar formulario hijo dentro del wrapper
        wrapper.Controls.Add(child)
        child.Show()
        child.BringToFront()

        ' Guardar referencias actuales
        currentWrapper = wrapper
        currentChildForm = child
    End Sub

    Private currentButton As Button = Nothing

    Private Sub ActivateButton(btn As Button)
        Try
            ' Reset all nav buttons first
            Dim navButtons = New Button() {btnCheques, btnDepositos, btnConciliacion, btnSalir}
            For Each b In navButtons
                b.BackColor = Color.Transparent
                b.ForeColor = Color.White
            Next

            ' Set active style
            btn.BackColor = Color.FromArgb(39, 60, 117)
            btn.ForeColor = Color.White
            currentButton = btn
        Catch ex As Exception
            ' ignore styling failures
        End Try
    End Sub
End Class

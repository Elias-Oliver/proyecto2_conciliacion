Public Class Cheques
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Cheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default to Registrar view so the registration card is visible when opening Cheques
        ActivateRegistrarView()
        ' Give the card panel rounded corners for nicer appearance
        Try
            ApplyCardRounding()
        Catch
            ' ignore if GDI calls fail on some environments
        End Try
    End Sub

    Private Sub Cheques_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Recalculate rounding when the form resizes so corners stay correct
        Try
            ApplyCardRounding()
        Catch
        End Try
    End Sub

    Private Sub Cheques_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Center the card after the form is shown (bounds are final)
        Try
            CenterCard()
            ApplyCardRounding()
        Catch
        End Try
    End Sub

    Private Sub CenterCard()
        ' Center pnlForm inside pnlContent (inside pnlCardHolder)
        If pnlForm Is Nothing OrElse pnlContent Is Nothing Then Return

        Dim margin As Integer = 40
        Dim maxWidth As Integer = 1120
        Dim available As Integer = Math.Max(0, pnlContent.ClientSize.Width - (pnlContent.Padding.Left + pnlContent.Padding.Right))
        Dim desiredWidth As Integer = Math.Min(maxWidth, Math.Max(300, available - margin))

        pnlForm.Width = desiredWidth

        ' Center horizontally
        Dim leftPos As Integer = (pnlContent.ClientSize.Width - pnlForm.Width) \ 2
        pnlForm.Left = Math.Max(pnlCardHolder.Padding.Left, leftPos)
        pnlForm.Top = pnlCardHolder.Padding.Top

        ' Ensure tblFields width matches inner width
        Try
            tblFields.Width = pnlForm.ClientSize.Width - pnlForm.Padding.Left - pnlForm.Padding.Right
        Catch
        End Try

        ' Position Register button right under the fields to remove big gap
        Try
            btnRegistrarBottom.Width = pnlForm.ClientSize.Width - pnlForm.Padding.Left - pnlForm.Padding.Right
            btnRegistrarBottom.Left = pnlForm.Padding.Left
            btnRegistrarBottom.Top = tblFields.Bottom + 16
        Catch
        End Try

        ' Adjust pnlForm height to fit contents tightly
        Try
            Dim desiredHeight As Integer = btnRegistrarBottom.Bottom + pnlForm.Padding.Bottom
            pnlForm.Height = Math.Max(pnlForm.Height, desiredHeight)
        Catch
        End Try
    End Sub

    Private Sub ActivateRegistrarView()
        btnTopRegistrar.BackColor = Color.FromArgb(17, 24, 39)
        btnTopRegistrar.ForeColor = Color.White
        btnTopRegistrar.FlatAppearance.BorderSize = 0

        btnTopConsultar.BackColor = Color.White
        btnTopConsultar.ForeColor = Color.FromArgb(17, 24, 39)
        btnTopConsultar.FlatAppearance.BorderSize = 1

        ' Show the card holder (registration card) and hide consult controls
        If pnlCardHolder IsNot Nothing Then pnlCardHolder.Visible = True
        pnlForm.Visible = True
        If dgvCheques IsNot Nothing Then dgvCheques.Visible = False
        If pnlConsultar IsNot Nothing Then pnlConsultar.Visible = False
    End Sub

    Private Sub ActivateConsultarView()
        btnTopRegistrar.BackColor = Color.White
        btnTopRegistrar.ForeColor = Color.FromArgb(17, 24, 39)
        btnTopRegistrar.FlatAppearance.BorderSize = 1

        btnTopConsultar.BackColor = Color.FromArgb(17, 24, 39)
        btnTopConsultar.ForeColor = Color.White
        btnTopConsultar.FlatAppearance.BorderSize = 0

        ' Hide the registration card holder so it doesn't reserve space
        If pnlCardHolder IsNot Nothing Then pnlCardHolder.Visible = False

        ' Update placeholder vs grid depending on data
        UpdateConsultarView()
        ' Ensure the visible consult control is on top
        If dgvCheques.Visible Then
            dgvCheques.BringToFront()
        ElseIf pnlConsultar.Visible Then
            pnlConsultar.BringToFront()
        End If
    End Sub

    Private Sub UpdateConsultarView()
        ' Ensure DataGridView has columns
        If dgvCheques.Columns.Count = 0 Then
            dgvCheques.Columns.Add("Numero", "Número")
            dgvCheques.Columns.Add("Fecha", "Fecha")
            dgvCheques.Columns.Add("Beneficiario", "Beneficiario")
            dgvCheques.Columns.Add("Objeto", "Objeto de Gasto")
            dgvCheques.Columns.Add("Monto", "Monto")
            dgvCheques.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If

        If dgvCheques.Rows.Count = 0 Then
            If pnlConsultar IsNot Nothing Then
                pnlConsultar.Visible = True
                pnlConsultar.BringToFront()
            End If
            If dgvCheques IsNot Nothing Then dgvCheques.Visible = False
        Else
            If pnlConsultar IsNot Nothing Then pnlConsultar.Visible = False
            If dgvCheques IsNot Nothing Then
                dgvCheques.Visible = True
                dgvCheques.BringToFront()
            End If
        End If
    End Sub

    Private Sub btnRegistrarBottom_Click(sender As Object, e As EventArgs) Handles btnRegistrarBottom.Click
        ' Collect fields and add a simulated row to the DataGridView for testing
        Dim numero = txtNumeroCheque.Text.Trim()
        Dim fecha = dtpFechaCheque.Value.ToString("MM/dd/yyyy")
        Dim beneficiario = If(String.IsNullOrWhiteSpace(cmbProveedor.Text), "-", cmbProveedor.Text)
        Dim objeto = If(String.IsNullOrWhiteSpace(cmbObjetoGasto.Text), "-", cmbObjetoGasto.Text)
        Dim monto = If(String.IsNullOrWhiteSpace(txtMonto.Text), "0.00", txtMonto.Text)

        Try
            If dgvCheques.Columns.Count = 0 Then
                dgvCheques.Columns.Add("Numero", "Número")
                dgvCheques.Columns.Add("Fecha", "Fecha")
                dgvCheques.Columns.Add("Beneficiario", "Beneficiario")
                dgvCheques.Columns.Add("Objeto", "Objeto de Gasto")
                dgvCheques.Columns.Add("Monto", "Monto")
                dgvCheques.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If

            dgvCheques.Rows.Add(numero, fecha, beneficiario, objeto, monto)
            MessageBox.Show("Cheque registrado (simulado)", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' After adding, update Consultar view placeholder
            UpdateConsultarView()
        Catch ex As Exception
            MessageBox.Show("Error al registrar cheque: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ApplyCardRounding()
        ' Apply rounded corners to the pnlForm for a modern card look
        Dim r As New Drawing2D.GraphicsPath()
        Dim bounds = pnlForm.ClientRectangle
        Dim radius As Integer = 12
        r.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        r.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        r.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        r.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        r.CloseFigure()
        pnlForm.Region = New Region(r)
        ' Also apply a small rounding to the bottom Register button for a polished look
        Try
            Dim br As New Drawing2D.GraphicsPath()
            Dim bBounds = btnRegistrarBottom.ClientRectangle
            Dim brRadius As Integer = 8
            br.AddArc(bBounds.X, bBounds.Y, brRadius, brRadius, 180, 90)
            br.AddArc(bBounds.Right - brRadius, bBounds.Y, brRadius, brRadius, 270, 90)
            br.AddArc(bBounds.Right - brRadius, bBounds.Bottom - brRadius, brRadius, brRadius, 0, 90)
            br.AddArc(bBounds.X, bBounds.Bottom - brRadius, brRadius, brRadius, 90, 90)
            br.CloseFigure()
            btnRegistrarBottom.Region = New Region(br)
        Catch
            ' ignore if sizing not ready
        End Try
    End Sub


End Class

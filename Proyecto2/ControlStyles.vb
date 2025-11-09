Module ControlStyles
    Public Sub ApplyShadowAndRound(control As Control)
        ' Agregar borde redondeado cuando el tamaño es válido
        Try
            Dim radius As Integer = 10
            If control.Width >= radius * 2 AndAlso control.Height >= radius * 2 Then
                Dim path As New Drawing2D.GraphicsPath()
                path.AddArc(0, 0, radius, radius, 180, 90)
                path.AddArc(control.Width - radius, 0, radius, radius, 270, 90)
                path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90)
                path.AddArc(0, control.Height - radius, radius, radius, 90, 90)
                path.CloseFigure()
                control.Region = New Region(path)
            End If
        Catch ex As Exception
            ' Evitar romper el diseñador si falla el cálculo de la región
        End Try
    End Sub

    Public Sub StyleTextBox(txt As TextBox, parent As Control)
        ' Estilo moderno para TextBox
        txt.BorderStyle = BorderStyle.None
        txt.Font = New Font("Segoe UI", 12.0F)
        txt.BackColor = Color.FromArgb(250, 252, 255)

        ' Panel contenedor con sombra y bordes redondeados
        Dim pnl As New Panel()
        pnl.Size = New Size(txt.Width, txt.Height + 10)
        pnl.Location = txt.Location
        pnl.BackColor = Color.White
        ApplyShadowAndRound(pnl)
        
        ' Ajustar posición del TextBox dentro del panel
        txt.Location = New Point(10, 5)
        txt.Width = pnl.Width - 20
        
        ' Agregar al contenedor
        parent.Controls.Add(pnl)
        pnl.Controls.Add(txt)
    End Sub

    Public Sub StyleComboBox(cmb As ComboBox, parent As Control)
        ' Estilo moderno para ComboBox
        cmb.FlatStyle = FlatStyle.Flat
        cmb.Font = New Font("Segoe UI", 12.0F)
        cmb.BackColor = Color.FromArgb(250, 252, 255)

        ' Panel contenedor con sombra y bordes redondeados
        Dim pnl As New Panel()
        pnl.Size = New Size(cmb.Width, cmb.Height + 10)
        pnl.Location = cmb.Location
        pnl.BackColor = Color.White
        ApplyShadowAndRound(pnl)
        
        ' Ajustar posición del ComboBox dentro del panel
        cmb.Location = New Point(10, 5)
        cmb.Width = pnl.Width - 20
        
        ' Agregar al contenedor
        parent.Controls.Add(pnl)
        pnl.Controls.Add(cmb)
    End Sub

    Public Sub StyleButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(63, 114, 241)
        btn.ForeColor = Color.White
        btn.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btn.Cursor = Cursors.Hand
        btn.Size = New Size(200, 45)
        
        ' Crear efecto de sombra y bordes redondeados
        ApplyShadowAndRound(btn)
        
        ' Agregar eventos para efectos hover
        AddHandler btn.MouseEnter, Sub(sender, e)
            btn.BackColor = Color.FromArgb(45, 85, 200)
        End Sub
        
        AddHandler btn.MouseLeave, Sub(sender, e)
            btn.BackColor = Color.FromArgb(63, 114, 241)
        End Sub
    End Sub
End Module
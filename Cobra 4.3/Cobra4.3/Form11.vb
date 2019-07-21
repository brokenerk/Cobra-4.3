Public Class FrmGenerar

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Hide()

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If (RdoNuevo.Checked = True) Then
            Me.Hide()
            FrmInicio.Hide()
            FrmNuevo.Show()

        End If

        If (RdoExist.Checked = True) Then
            Me.Hide()
            FrmInicio.Hide()
            FrmContol.Show()
        End If
    End Sub
End Class
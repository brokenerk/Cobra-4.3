Public Class FrmSelct

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
        FrmInicio.Show()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If RdoNuevo.Checked = True Then
            Me.Close()
            FrmMensual.Show()
        End If

        If RdoExist.Checked = True Then
            Me.Close()
            FrmInformeEx.Show()

        End If
    End Sub
End Class
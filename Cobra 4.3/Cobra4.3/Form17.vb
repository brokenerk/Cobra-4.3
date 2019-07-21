Public Class FrmGener

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
        FrmInicio.Show()

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If (RdoNuevo.Checked) Then
            Me.Close()
            FrmControl.Show()


        End If

        If (RdoExist.Checked) Then
            Me.Close()
            FrmFund.Show()


        End If




    End Sub
End Class
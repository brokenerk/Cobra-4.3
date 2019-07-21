Public Class FrmDocumentos

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Hide()
        FrmInicio.Show()

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click

        If (RdbFundamentacion.Checked = True) Then
            Me.Hide()
            FrmInicio.Hide()
            FrmFundamentacion.Show()

        End If
        If (RdbNom.Checked = True) Then
            Me.Hide()
            FrmInicio.Hide()
            FrmCoordinacion.Show()

        End If


        If (RdbInforme.Checked = True) Then
            Me.Hide()
            FrmInicio.Hide()
            FrmInforme.Show()

        End If
        If (RdbMensual.Checked = True) Then
            Me.Hide()
            FrmSelct.Show()
        End If
        If (RdbAvisos.Checked = True) Then
            Me.Hide()
            FrmGenerar.Show()

        End If
        If (RdbControl.Checked = True) Then
            Me.Hide()
            FrmGener.Show()

        End If


    End Sub

    Private Sub RbdControl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbControl.CheckedChanged

    End Sub
End Class
Public Class FrmInicio

    Private Sub BtnProfesor_Click(sender As System.Object, e As System.EventArgs) Handles BtnProfesor.Click
        FrmProfesor.Show()
        Me.Hide()
    End Sub

    Private Sub FrmInicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnDirectivo_Click(sender As System.Object, e As System.EventArgs) Handles BtnDirectivo.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSalir_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click
        FrmDirectivo.Close()
        FrmAlumno.Close()
        FrmProfesor.Close()
        FrmVisita.Close()
        FrmEmpresa.Close()
        FrmMenu.Close()
        FormPantallaCarga.Close()
        Me.Close()
        End
    End Sub

    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        FrmDocumentos.Show()

    End Sub
End Class

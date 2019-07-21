Public Class FrmVisita
    Dim NoPractica As String
    Private Sub BtnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegresar.Click
        FrmMenu.Show()
        Me.Close()

    End Sub

    Private Sub VISITABindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles VISITABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VISITABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UPISCECYT8DataSet)

    End Sub

    Private Sub FrmVisita_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UPISCECYT8DataSet.VISITA' Puede moverla o quitarla según sea necesario.
        Me.VISITATableAdapter.Fill(Me.UPISCECYT8DataSet.VISITA)

    End Sub

    Private Sub BtnPrev_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrev.Click
        NoPractica = TxtNoPractica.Text
        If (TxtNoPractica.Text = "" And TxtCosto.Text = "" And TxtRAP.Text = "" And TxtCompetencia.Text = "" And TxtAsistentes.Text = "" And TxtFecha.Text = "" And TxtProgramaAcademico.Text = "" And CboConfirmacion.Text = "") Then
            MsgBox("Ingrese datos porfavor.")
        Else
            If (Me.VISITATableAdapter.SelectNoPractica(NoPractica) <> Nothing) Then
                MsgBox("ERROR. Esta Visita ya fue registrada.")
            Else
                Me.VISITATableAdapter.InsertarVisita(TxtNoPractica.Text, TxtCosto.Text, TxtRAP.Text, TxtCompetencia.Text, TxtProgramaAcademico.Text, TxtAsistentes.Text, TxtFecha.Text, CboConfirmacion.Text)
                Me.VISITATableAdapter.Fill(Me.UPISCECYT8DataSet.VISITA)
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditar.Click
        Me.VISITATableAdapter.EditarVisita(TxtNoPractica.Text, TxtCosto.Text, TxtRAP.Text, TxtCompetencia.Text, TxtProgramaAcademico.Text, TxtAsistentes.Text, TxtFecha.Text, CboConfirmacion.Text, TxtNoPractica.Text)
        Me.VISITATableAdapter.Fill(Me.UPISCECYT8DataSet.VISITA)
        MsgBox("El registro fue modificado satisfactoriamente.")
    End Sub

    Private Sub BtnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBorrar.Click
        Me.VISITATableAdapter.BorrarVisita(TxtNoPractica.Text)
        Me.VISITATableAdapter.Fill(Me.UPISCECYT8DataSet.VISITA)
        MsgBox("Se ha eliminado el registro seleccionado.")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TxtNoPractica.Text = ""
        TxtCosto.Text = ""
        TxtRAP.Text = ""
        TxtCompetencia.Text = ""
        TxtAsistentes.Text = ""
        TxtFecha.Text = ""
        TxtProgramaAcademico.Text = ""
        CboConfirmacion.Text = ""
    End Sub
End Class
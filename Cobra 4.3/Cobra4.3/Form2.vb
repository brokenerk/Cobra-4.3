Public Class FrmProfesor
    Dim ClaveProf As String
    Private Sub BtnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegresar.Click
        FrmInicio.Show()
        Me.Close()

    End Sub

    Private Sub FrmProfesor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UPISCECYT8DataSet.PROFESOR' Puede moverla o quitarla según sea necesario.
        Me.PROFESORTableAdapter.Fill(Me.UPISCECYT8DataSet.PROFESOR)

    End Sub

    Private Sub PROFESORBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PROFESORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PROFESORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UPISCECYT8DataSet)

    End Sub

    Private Sub BtnPrev_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrev.Click
        ClaveProf = TxtClaveProfesor.Text
        If (TxtAcademia.Text = "" And TxtClaveProfesor.Text = "" And TxtEmail.Text = "" And TxtNombreProfesor.Text = "" And TxtJefeArea.Text = "" And TxtTelefonoProfesor.Text = "" And TxtUnidaAprendizaje.Text = "" And CboArea.Text = "" And CboCarrera.Text = "" And CboSemestre.Text = "" And CboTurno.Text = "") Then
            MsgBox("Ingrese datos porfavor.")
        Else
            If (Me.PROFESORTableAdapter.SelectClaveProf(ClaveProf) <> Nothing) Then
                MsgBox("ERROR. Este Profesor ya fue registrado.")
            Else


                Me.PROFESORTableAdapter.InsertarProfesor(TxtClaveProfesor.Text, TxtNombreProfesor.Text, TxtTelefonoProfesor.Text, CboArea.Text, TxtUnidaAprendizaje.Text, TxtEmail.Text, TxtAcademia.Text, CboTurno.Text, CboCarrera.Text, CboSemestre.Text, TxtJefeArea.Text)
                Me.PROFESORTableAdapter.Fill(Me.UPISCECYT8DataSet.PROFESOR)
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditar.Click
        Me.PROFESORTableAdapter.EditarProfesor(TxtClaveProfesor.Text, TxtNombreProfesor.Text, TxtTelefonoProfesor.Text, CboArea.Text, TxtUnidaAprendizaje.Text, TxtEmail.Text, TxtAcademia.Text, CboTurno.Text, CboCarrera.Text, CboSemestre.Text, TxtJefeArea.Text, TxtClaveProfesor.Text)
        Me.PROFESORTableAdapter.Fill(Me.UPISCECYT8DataSet.PROFESOR)
        MsgBox("El registro fue modificado satisfactoriamente.")
    End Sub

    Private Sub BtnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBorrar.Click
        Me.PROFESORTableAdapter.BorrarProfesor(TxtClaveProfesor.Text)
        Me.PROFESORTableAdapter.Fill(Me.UPISCECYT8DataSet.PROFESOR)
        MsgBox("Se ha eliminado el registro seleccionado.")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TxtAcademia.Text = ""
        TxtClaveProfesor.Text = ""
        TxtEmail.Text = ""
        TxtNombreProfesor.Text = ""
        TxtJefeArea.Text = ""
        TxtTelefonoProfesor.Text = ""
        TxtUnidaAprendizaje.Text = ""
        CboArea.Text = ""
        CboCarrera.Text = ""
        CboSemestre.Text = ""
        CboTurno.Text = ""
    End Sub
End Class
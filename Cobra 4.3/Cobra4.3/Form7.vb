Public Class FrmDirectivo
    Dim Registro As String
    Private Sub BtnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
        FrmMenu.Show()
    End Sub

    Private Sub AUTORIDADESBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles AUTORIDADESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AUTORIDADESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DirectivosCecyt8DataSet)

    End Sub

    Private Sub FrmDirectivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DirectivosCecyt8DataSet.AUTORIDADES' Puede moverla o quitarla según sea necesario.
        Me.AUTORIDADESTableAdapter.Fill(Me.DirectivosCecyt8DataSet.AUTORIDADES)

    End Sub

    Private Sub BtnInsertar_Click(sender As System.Object, e As System.EventArgs) Handles BtnInsertar.Click
        Registro = TxtRegistro.Text

        If (TxtRegistro.Text = "" And TxtSubdirector.Text = "" And TxtSubdirectora.Text = "" And TxtPracticas.Text = "" And TxtServicios.Text = "" And TxtDirector.Text = "") Then
            MsgBox("Ingrese datos porfavor.")
        Else
            If (Me.AUTORIDADESTableAdapter.SelectRegistro(Registro) <> Nothing) Then
                MsgBox("ERROR. Estos Directivos ya fueron registrados.")
            Else
                Me.AUTORIDADESTableAdapter.InsertAutoridades(TxtRegistro.Text, TxtSubdirectora.Text, TxtServicios.Text, TxtSubdirector.Text, TxtPracticas.Text, TxtDirector.Text)
                Me.AUTORIDADESTableAdapter.Fill(Me.DirectivosCecyt8DataSet.AUTORIDADES)
                BtnInsertar.Enabled = False
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditar.Click
        Me.AUTORIDADESTableAdapter.EditarAutoridades(TxtRegistro.Text, TxtSubdirectora.Text, TxtServicios.Text, TxtSubdirector.Text, TxtPracticas.Text, TxtDirector.Text, TxtRegistro.Text)
        Me.AUTORIDADESTableAdapter.Fill(Me.DirectivosCecyt8DataSet.AUTORIDADES)
        MsgBox("El registro fue actualizado satisfactoriamente.")
    End Sub

    Private Sub BtnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBorrar.Click
        Me.AUTORIDADESTableAdapter.BorrarAutoridades(TxtRegistro.Text)
        Me.AUTORIDADESTableAdapter.Fill(Me.DirectivosCecyt8DataSet.AUTORIDADES)
        MsgBox("Se ha eliminado el registro seleccionado.")
        BtnInsertar.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TxtRegistro.Text = ""
        TxtSubdirector.Text = ""
        TxtSubdirectora.Text = ""
        TxtPracticas.Text = ""
        TxtServicios.Text = ""
        TxtDirector.Text = ""

    End Sub
End Class
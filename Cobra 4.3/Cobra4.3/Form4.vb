Public Class FrmAlumno
    Dim Boleta As String
    Private Sub ALUMNOBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ALUMNOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALUMNOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UPISCECYT8DataSet)

    End Sub

    Private Sub FrmAlumno_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UPISCECYT8DataSet.ALUMNO' Puede moverla o quitarla según sea necesario.
        Me.ALUMNOTableAdapter.Fill(Me.UPISCECYT8DataSet.ALUMNO)

    End Sub

    Private Sub BtnPrev_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrev.Click
        Boleta = BoletaTextBox.Text
        If (BoletaTextBox.Text = "" And NombreTextBox.Text = "" And GrupoTextBox.Text = "" And TutorTextBox.Text = "" And TelefonoTextBox.Text = "" And CelularTextBox.Text = "" And TxtImporte.Text = "") Then
            MsgBox("Ingrese datos porfavor.")

        Else
            If (Me.ALUMNOTableAdapter.SelectBoleta(Boleta) <> Nothing) Then
                MsgBox("ERROR. Este Alumno ya fue registrado.")
            Else
                Me.ALUMNOTableAdapter.InsertAlumno(BoletaTextBox.Text, NombreTextBox.Text, GrupoTextBox.Text, TelefonoTextBox.Text, CelularTextBox.Text, TutorTextBox.Text, TxtImporte.Text)
                Me.ALUMNOTableAdapter.Fill(Me.UPISCECYT8DataSet.ALUMNO)
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditar.Click
        Me.ALUMNOTableAdapter.EditarAlumno(BoletaTextBox.Text, NombreTextBox.Text, GrupoTextBox.Text, TelefonoTextBox.Text, CelularTextBox.Text, TutorTextBox.Text, TxtImporte.Text, BoletaTextBox.Text)
        Me.ALUMNOTableAdapter.Fill(Me.UPISCECYT8DataSet.ALUMNO)
        MsgBox("El registro fue modificado satisfactoriamente.")
    End Sub

    Private Sub BtnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBorrar.Click
        Me.ALUMNOTableAdapter.BorrarAlumno(BoletaTextBox.Text)
        Me.ALUMNOTableAdapter.Fill(Me.UPISCECYT8DataSet.ALUMNO)
        MsgBox("Se ha eliminado el registro seleccionado.")
    End Sub

    Private Sub BtnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegresar.Click
        FrmMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        BoletaTextBox.Text = ""
        NombreTextBox.Text = ""
        GrupoTextBox.Text = ""
        TutorTextBox.Text = ""
        TelefonoTextBox.Text = ""
        CelularTextBox.Text = ""
        TxtImporte.Text = ""
    End Sub
End Class
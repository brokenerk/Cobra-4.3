Public Class FrmMenu

    Private Sub BtnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        FrmInicio.Show()
    End Sub

    Private Sub BtnLlenar_Click(sender As System.Object, e As System.EventArgs) Handles BtnLlenar.Click
        If (RdoAlumno.Checked = True) Then
            FrmAlumno.Show()
            Me.Hide()

        End If

        If (RdoEmpresa.Checked = True) Then
            FrmEmpresa.Show()
            Me.Hide()

        End If

        If (RdoVisita.Checked = True) Then
            FrmVisita.Show()
            Me.Hide()

        End If

        If (RdoDirectivo.Checked = True) Then
            FrmDirectivo.Show()
            Me.Hide()

        End If

     
    End Sub

    Private Sub FrmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UPISCECYT8DataSet.VISITA' Puede moverla o quitarla según sea necesario.
        Me.VISITATableAdapter.Fill(Me.UPISCECYT8DataSet.VISITA)

    End Sub

    Private Sub VISITABindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles VISITABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VISITABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UPISCECYT8DataSet)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If (Me.VISITATableAdapter.SelectCont = 0) Then
            MsgBox("Debe de ingresar la informacion correspondiente a PROFESOR y VISITA")
        Else
            Form23.Show()
        End If
    End Sub
End Class
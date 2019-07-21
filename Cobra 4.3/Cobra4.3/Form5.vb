Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO
Public Class FrmEmpresa
    Dim Nombre As String
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        FrmMenu.Show()
        Me.Close()
    End Sub

    Private Sub EMPRESABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPRESABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMPRESABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UPISCECYT8DataSet)

    End Sub

    Private Sub FrmEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UPISCECYT8DataSet.EMPRESA' Puede moverla o quitarla según sea necesario.
        Me.EMPRESATableAdapter.Fill(Me.UPISCECYT8DataSet.EMPRESA)

    End Sub

    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        Nombre = TxtNombreEmpresa.Text
        If (TxtNombreEmpresa.Text = "" And TxtTelefonoEmpresa.Text = "" And TxtDireccionEmpresa.Text = "" And TxtGiroEmpresa.Text = "" And TxtEmailEmpresa.Text = "") Then
            MsgBox("Ingrese datos porfavor.")
        Else
            If (Me.EMPRESATableAdapter.SelectNombre(Nombre) <> Nothing) Then
                MsgBox("ERROR. Esta Empresa ya fue registrada.")
            Else
                Me.EMPRESATableAdapter.InsertarEmpresa(TxtNombreEmpresa.Text, TxtTelefonoEmpresa.Text, TxtDireccionEmpresa.Text, TxtGiroEmpresa.Text, TxtEmailEmpresa.Text)
                Me.EMPRESATableAdapter.Fill(Me.UPISCECYT8DataSet.EMPRESA)
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        Me.EMPRESATableAdapter.EditarEmpresa(TxtNombreEmpresa.Text, TxtTelefonoEmpresa.Text, TxtDireccionEmpresa.Text, TxtGiroEmpresa.Text, TxtEmailEmpresa.Text, TxtNombreEmpresa.Text)
        Me.EMPRESATableAdapter.Fill(Me.UPISCECYT8DataSet.EMPRESA)
        MsgBox("El registro fue modificado satisfactoriamente.")
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Me.EMPRESATableAdapter.BorrarEmpresa(TxtNombreEmpresa.Text)
        Me.EMPRESATableAdapter.Fill(Me.UPISCECYT8DataSet.EMPRESA)
        MsgBox("Se ha eliminado el registro seleccionado.")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document

        MsgBox("El TDR se guardará en : C:\Users\Alumno\Desktop")
        Documento = MSWord.Documents.Open("D:\UPIS conectadas a bd\UPIS\Recreacion de Documentos\UPIS Seguimientos.docx")

        'Documento.Bookmarks.Item("apellido").Range.Text = txtapellido.Text
        Documento.Bookmarks.Item("empresa").Range.Text = TxtNombreEmpresa.Text

        Documento.Bookmarks.Item("domicilio").Range.Text = TxtDireccionEmpresa.Text

        Documento.Save()
        MSWord.Visible = True

    End Sub

    Private Sub BtnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles BtnLimpiar.Click
        TxtNombreEmpresa.Text = ""
        TxtTelefonoEmpresa.Text = ""
        TxtDireccionEmpresa.Text = ""
        TxtGiroEmpresa.Text = ""
        TxtEmailEmpresa.Text = ""


    End Sub
End Class
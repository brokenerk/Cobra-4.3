
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO


Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim MSWord As New Word.Application
        Dim Documento As Word.Document


        MsgBox("El TDR se guardará en : C:\Users\Alumno\Desktop")
        FileCopy("D:\UPIS conectadas a bd\UPIS\Recreacion de Documentos", "C:\Users\Alumno\Desktop")
        Documento = MSWord.Documents.Open("D:\UPIS conectadas a bd\UPIS\Recreacion de Documentos\UPIS Seguimientos.docx")

       


        Documento.Save()
        MSWord.Visible = True







    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class
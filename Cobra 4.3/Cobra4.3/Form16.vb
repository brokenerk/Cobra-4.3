Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO
Public Class FrmControl
    Private conexion As String
    Private Sub BtnRegrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegrear.Click
        Me.Close()
        FrmInicio.Show()

    End Sub

    Private Sub FrmControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cargar()

    End Sub

    Private Sub Cargar()
        Dim Cadena As String
        Cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\UPISCECYT8.mdb" 'Proveedor de la Base de Datos y nos permitira comunicarnos con ella
        Dim conexion As OleDbConnection 'Se encarga de la conexion con la base de Datos 
        conexion = New OleDbConnection(Cadena) 'Parametro que conecta con la base de 

        'Empresa'

        Dim EmpresaTableAdapter As OleDbDataAdapter
        EmpresaTableAdapter = New OleDbDataAdapter

        EmpresaTableAdapter.SelectCommand = New OleDbCommand("SELECT * From EMPRESA", conexion) 'Comando de Seleccion para Datos de la Tabla

        Dim FirstDataSet As DataSet
        FirstDataSet = New DataSet
        FirstDataSet.Tables.Add("empresa")

        'Aviso'

        Dim VisitaTableAdapter As OleDbDataAdapter
        VisitaTableAdapter = New OleDbDataAdapter

        VisitaTableAdapter.SelectCommand = New OleDbCommand("SELECT * From VISITA", conexion)

        Dim ThirdDataSet As DataSet
        ThirdDataSet = New DataSet
        ThirdDataSet.Tables.Add("visita")





        EmpresaTableAdapter.Fill(FirstDataSet.Tables("empresa"))
        VisitaTableAdapter.Fill(ThirdDataSet.Tables("visita"))


        'Campos Empresa'
        CboEmp.DataSource = FirstDataSet.Tables("empresa")
        CboEmp.DisplayMember = "Nombre Empresa"


        TxtGiro.DataBindings.Add("Text", FirstDataSet.Tables("empresa"), "Giro")


        'Campos Visita'

        CboPrac.DataSource = ThirdDataSet.Tables("visita")
        CboPrac.DisplayMember = "No Practica"

        TxtFecha.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Fecha")
        TxtConfir.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Confirmacion")



    End Sub

    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        Dim op As Integer
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        op = CboPrac.Text
        Documento = MSWord.Documents.Open("C:\Program Files (x86)\UPIS\Upis Solicitud.docx")
        Select Case op
            Case 1, 9, 17

                Documento.Bookmarks.Item("Empresa").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Giro").Range.Text = TxtGiro.Text
                Documento.Bookmarks.Item("Fecha").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Confir").Range.Text = TxtConfir.Text
                Documento.Bookmarks.Item("Mes").Range.Text = CboMes.Text


                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs("Solicitud Mes " + CboMes.Text)
                MSWord.Visible = True

            Case 2, 10, 18

                Documento.Bookmarks.Item("Empresa1").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Giro1").Range.Text = TxtGiro.Text
                Documento.Bookmarks.Item("Fecha1").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Confir1").Range.Text = TxtConfir.Text
                Documento.Bookmarks.Item("Mes").Range.Text = CboMes.Text


                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs("Solicitud Mes " + CboMes.Text)
                MSWord.Visible = True
            Case 3, 11, 19

                Documento.Bookmarks.Item("Empresa2").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Giro2").Range.Text = TxtGiro.Text
                Documento.Bookmarks.Item("Fecha2").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Confir2").Range.Text = TxtConfir.Text
                Documento.Bookmarks.Item("Mes").Range.Text = CboMes.Text


                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs("Solicitud Mes " + CboMes.Text)
                MSWord.Visible = True
            Case 4, 12, 20

                Documento.Bookmarks.Item("Empresa3").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Giro3").Range.Text = TxtGiro.Text
                Documento.Bookmarks.Item("Fecha3").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Confir3").Range.Text = TxtConfir.Text
                Documento.Bookmarks.Item("Mes").Range.Text = CboMes.Text


                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs("Solicitud Mes " + CboMes.Text)

                MSWord.Visible = True
            Case 5, 13, 21


                Documento.Bookmarks.Item("Empresa4").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Giro4").Range.Text = TxtGiro.Text
                Documento.Bookmarks.Item("Fecha4").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Confir4").Range.Text = TxtConfir.Text
                Documento.Bookmarks.Item("Mes").Range.Text = CboMes.Text


                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs("Solicitud Mes " + CboMes.Text)
                MSWord.Visible = True
            Case 6, 14, 22
                Documento = MSWord.Documents.Open("C:\Users\Cesarin\UPIS\Upis Solicitud.docx")
                Documento.Bookmarks.Item("Empresa5").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Giro5").Range.Text = TxtGiro.Text
                Documento.Bookmarks.Item("Fecha5").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Confir5").Range.Text = TxtConfir.Text
                Documento.Bookmarks.Item("Mes").Range.Text = CboMes.Text


                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs("Solicitud Mes " + CboMes.Text)
                MSWord.Visible = True
            Case 7, 15, 23
                Documento = MSWord.Documents.Open("C:\Users\Cesarin\UPIS\Upis Solicitud.docx")
                Documento.Bookmarks.Item("Empresa6").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Giro6").Range.Text = TxtGiro.Text
                Documento.Bookmarks.Item("Fecha6").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Confir6").Range.Text = TxtConfir.Text
                Documento.Bookmarks.Item("Mes").Range.Text = CboMes.Text


                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs("Solicitud Mes " + CboMes.Text)
                MSWord.Visible = True
            Case 8, 16, 24
                Documento = MSWord.Documents.Open("C:\Users\Cesarin\UPIS\Upis Solicitud.docx")
                Documento.Bookmarks.Item("Empresa7").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Giro7").Range.Text = TxtGiro.Text
                Documento.Bookmarks.Item("Fecha7").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Confir7").Range.Text = TxtConfir.Text
                Documento.Bookmarks.Item("Mes").Range.Text = CboMes.Text


                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs("Solicitud Mes " + CboMes.Text)
                MSWord.Visible = True
        End Select



    End Sub
End Class
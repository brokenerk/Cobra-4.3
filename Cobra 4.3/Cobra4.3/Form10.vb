Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO
Public Class FrmContol
    Private conexion As String

    Private Sub BtnRegrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegrear.Click
        Me.Close()
        FrmInicio.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        Dim op As Integer
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim ubi As String
        Dim nom As String
        Dim con As String
        ubi = TxtUbi.Text
        op = CboPrac.Text
        nom = TxtNom.Text
        con = (ubi + "\" + nom + ".docx")
        

        Select Case op
            Case 1, 9, 17
                Documento = MSWord.Documents.Open(con)

                Documento.Bookmarks.Item("Np").Range.Text = CboPrac.Text
                Documento.Bookmarks.Item("PR").Range.Text = CboProf.Text
                Documento.Bookmarks.Item("Ua").Range.Text = TxtUa.Text
                Documento.Bookmarks.Item("Ca").Range.Text = TxtCarrera.Text
                Documento.Bookmarks.Item("IoE").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Do").Range.Text = TxtDir.Text
                Documento.Bookmarks.Item("Fe").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Gr").Range.Text = TxtGrupo.Text
                Documento.Bookmarks.Item("No").Range.Text = TxtAlu.Text

                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs(nom)
                Documento.Close()

            Case 2, 10, 18
                Documento = MSWord.Documents.Open(con)

                Documento.Bookmarks.Item("Np1").Range.Text = CboPrac.Text
                Documento.Bookmarks.Item("PR1").Range.Text = CboProf.Text
                Documento.Bookmarks.Item("Ua1").Range.Text = TxtUa.Text
                Documento.Bookmarks.Item("Ca1").Range.Text = TxtCarrera.Text
                Documento.Bookmarks.Item("IoE1").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Do1").Range.Text = TxtDir.Text
                Documento.Bookmarks.Item("Fe1").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Gr1").Range.Text = TxtGrupo.Text
                Documento.Bookmarks.Item("No1").Range.Text = TxtAlu.Text

                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs(nom)
                Documento.Close()


            Case 3, 11, 19
                Documento = MSWord.Documents.Open(con)

                Documento.Bookmarks.Item("Np2").Range.Text = CboPrac.Text
                Documento.Bookmarks.Item("PR2").Range.Text = CboProf.Text
                Documento.Bookmarks.Item("Ua2").Range.Text = TxtUa.Text
                Documento.Bookmarks.Item("Ca2").Range.Text = TxtCarrera.Text
                Documento.Bookmarks.Item("IoE2").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Do2").Range.Text = TxtDir.Text
                Documento.Bookmarks.Item("Fe2").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Gr2").Range.Text = TxtGrupo.Text
                Documento.Bookmarks.Item("No2").Range.Text = TxtAlu.Text

                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs(nom)
                Documento.Close()
               
            Case 4, 12, 20
                Documento = MSWord.Documents.Open(con)

                Documento.Bookmarks.Item("Np3").Range.Text = CboPrac.Text
                Documento.Bookmarks.Item("PR3").Range.Text = CboProf.Text
                Documento.Bookmarks.Item("Ua3").Range.Text = TxtUa.Text
                Documento.Bookmarks.Item("Ca3").Range.Text = TxtCarrera.Text
                Documento.Bookmarks.Item("IoE3").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Do3").Range.Text = TxtDir.Text
                Documento.Bookmarks.Item("Fe3").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Gr3").Range.Text = TxtGrupo.Text
                Documento.Bookmarks.Item("No3").Range.Text = TxtAlu.Text

                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs(nom)
                Documento.Close()


        
            Case 5, 13, 21
                Documento = MSWord.Documents.Open(con)

                Documento.Bookmarks.Item("Np4").Range.Text = CboPrac.Text
                Documento.Bookmarks.Item("PR4").Range.Text = CboProf.Text
                Documento.Bookmarks.Item("Ua4").Range.Text = TxtUa.Text
                Documento.Bookmarks.Item("Ca4").Range.Text = TxtCarrera.Text
                Documento.Bookmarks.Item("IoE4").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Do4").Range.Text = TxtDir.Text
                Documento.Bookmarks.Item("Fe4").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Gr4").Range.Text = TxtGrupo.Text
                Documento.Bookmarks.Item("No4").Range.Text = TxtAlu.Text

                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs(nom)
                Documento.Close()

          
            Case 6, 14, 22
                Documento = MSWord.Documents.Open(con)

                Documento.Bookmarks.Item("Np5").Range.Text = CboPrac.Text
                Documento.Bookmarks.Item("PR5").Range.Text = CboProf.Text
                Documento.Bookmarks.Item("Ua5").Range.Text = TxtUa.Text
                Documento.Bookmarks.Item("Ca5").Range.Text = TxtCarrera.Text
                Documento.Bookmarks.Item("IoE5").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Do5").Range.Text = TxtDir.Text
                Documento.Bookmarks.Item("Fe5").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Gr5").Range.Text = TxtGrupo.Text
                Documento.Bookmarks.Item("No5").Range.Text = TxtAlu.Text

                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs(nom)
                Documento.Close()


            Case 7, 15, 23
                Documento = MSWord.Documents.Open(con)

                Documento.Bookmarks.Item("Np6").Range.Text = CboPrac.Text
                Documento.Bookmarks.Item("PR6").Range.Text = CboProf.Text
                Documento.Bookmarks.Item("Ua6").Range.Text = TxtUa.Text
                Documento.Bookmarks.Item("Ca6").Range.Text = TxtCarrera.Text
                Documento.Bookmarks.Item("IoE6").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Do6").Range.Text = TxtDir.Text
                Documento.Bookmarks.Item("Fe6").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Gr6").Range.Text = TxtGrupo.Text
                Documento.Bookmarks.Item("No6").Range.Text = TxtAlu.Text

                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs(nom)
                Documento.Close()





            Case 8, 16, 24
                Documento = MSWord.Documents.Open(con)

                Documento.Bookmarks.Item("Np7").Range.Text = CboPrac.Text
                Documento.Bookmarks.Item("PR7").Range.Text = CboProf.Text
                Documento.Bookmarks.Item("Ua7").Range.Text = TxtUa.Text
                Documento.Bookmarks.Item("Ca7").Range.Text = TxtCarrera.Text
                Documento.Bookmarks.Item("IoE7").Range.Text = CboEmp.Text
                Documento.Bookmarks.Item("Do7").Range.Text = TxtDir.Text
                Documento.Bookmarks.Item("Fe7").Range.Text = TxtFecha.Text
                Documento.Bookmarks.Item("Gr7").Range.Text = TxtGrupo.Text
                Documento.Bookmarks.Item("No7").Range.Text = TxtAlu.Text

                MsgBox("El Archivo se ha generado Exitosamente")
                Documento.SaveAs(nom)
                Documento.Close()

        End Select



    End Sub

    Private Sub BtnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

       



    End Sub
   

    Private Sub TxtDir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDir.TextChanged

    End Sub
    
   
    Private Sub FrmControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cargar()

    End Sub

    Private Sub Cargar()
        Dim Cadena As String
        Cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\UPISCECYT8.mdb" 'Proveedor de la Base de Datos y nos permitira comunicarnos con ella
        Dim conexion As OleDbConnection 'Se encarga de la conexion con la base de Datos 
        conexion = New OleDbConnection(Cadena) 'Parametro que conecta con la base de 

        Dim EmpresaTableAdapter As OleDbDataAdapter
        EmpresaTableAdapter = New OleDbDataAdapter

        EmpresaTableAdapter.SelectCommand = New OleDbCommand("SELECT * From EMPRESA", conexion) 'Comando de Seleccion para Datos de la Tabla

        Dim FirstDataSet As DataSet
        FirstDataSet = New DataSet
        FirstDataSet.Tables.Add("empresa")

        Dim ProfesorTableAdapter As OleDbDataAdapter
        ProfesorTableAdapter = New OleDbDataAdapter

        ProfesorTableAdapter.SelectCommand = New OleDbCommand("SELECT * From PROFESOR", conexion)

        Dim SecondDataSet As DataSet
        SecondDataSet = New DataSet
        SecondDataSet.Tables.Add("profesor")

        Dim VisitaTableAdapter As OleDbDataAdapter
        VisitaTableAdapter = New OleDbDataAdapter

        VisitaTableAdapter.SelectCommand = New OleDbCommand("SELECT * From VISITA", conexion)

        Dim ThirdDataSet As DataSet
        ThirdDataSet = New DataSet
        ThirdDataSet.Tables.Add("visita")




        EmpresaTableAdapter.Fill(FirstDataSet.Tables("empresa"))
        VisitaTableAdapter.Fill(ThirdDataSet.Tables("visita"))
        ProfesorTableAdapter.Fill(SecondDataSet.Tables("profesor"))

        CboEmp.DataSource = FirstDataSet.Tables("empresa")
        CboEmp.DisplayMember = "Nombre Empresa"

        TxtDir.DataBindings.Add("Text", FirstDataSet.Tables("empresa"), "Direccion")

        CboProf.DataSource = SecondDataSet.Tables("profesor")
        CboProf.DisplayMember = "Nombre Profesor"

        CboPrac.DataSource = ThirdDataSet.Tables("visita")
        CboPrac.DisplayMember = "No Practica"

        TxtFecha.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Fecha")
        TxtAlu.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Asistentes")


        TxtUa.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Unidad de Aprendizaje")
        TxtCarrera.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Carrera")

    End Sub

End Class
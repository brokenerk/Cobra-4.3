Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO

Public Class FrmInforme

    Private conexion As String

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cargar()
    End Sub

    Private Sub BtnRegrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegrear.Click
        Me.Close()
        FrmInicio.Show()


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

        'Profesor'

        Dim ProfesorTableAdapter As OleDbDataAdapter
        ProfesorTableAdapter = New OleDbDataAdapter

        ProfesorTableAdapter.SelectCommand = New OleDbCommand("SELECT * From PROFESOR", conexion)

        Dim SecondDataSet As DataSet
        SecondDataSet = New DataSet
        SecondDataSet.Tables.Add("profesor")




        EmpresaTableAdapter.Fill(FirstDataSet.Tables("empresa"))
        VisitaTableAdapter.Fill(ThirdDataSet.Tables("visita"))
        ProfesorTableAdapter.Fill(SecondDataSet.Tables("profesor"))

        'Campos Empresa'
        CboNomEmp.DataSource = FirstDataSet.Tables("empresa")
        CboNomEmp.DisplayMember = "Nombre Empresa"

        TxtDomicilio.DataBindings.Add("Text", FirstDataSet.Tables("empresa"), "Direccion")
        TxtGiro.DataBindings.Add("Text", FirstDataSet.Tables("empresa"), "Giro")

        'Campos Profesor'
        CboProf.DataSource = SecondDataSet.Tables("profesor")
        CboProf.DisplayMember = "Nombre Profesor"


        TxtUa.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Unidad de Aprendizaje")
        TxtTurno.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Turno")
        TxtSemestre.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Semestre")
        TxtAcademia.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Academia")
        TxtArea.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Area Profesor")

        'Campos Visita'

        CboPrac.DataSource = ThirdDataSet.Tables("visita")
        CboPrac.DisplayMember = "No Practica"

        TxtFecha.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Fecha")
        TxtAsistentes.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Asistentes")
        TxtCompetencia.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Competencia")
        TxtPrograma.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Programa Academico")
        TxtRAP.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "RAP")
        TxtCosto.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Costo")




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document



        Documento = MSWord.Documents.Open("C:\Program Files (x86)\UPIS\Informe.docx")
        Documento.Bookmarks.Item("Np").Range.Text = CboPrac.Text
        Documento.Bookmarks.Item("Ua").Range.Text = TxtUa.Text
        Documento.Bookmarks.Item("Alu").Range.Text = TxtAsistentes.Text
        Documento.Bookmarks.Item("Do").Range.Text = TxtDomicilio.Text
        Documento.Bookmarks.Item("Fe").Range.Text = TxtFecha.Text
        Documento.Bookmarks.Item("Com").Range.Text = TxtCompetencia.Text
        Documento.Bookmarks.Item("RAP").Range.Text = TxtRAP.Text
        Documento.Bookmarks.Item("Giro").Range.Text = TxtGiro.Text
        Documento.Bookmarks.Item("Gr").Range.Text = TxtGrupo.Text
        Documento.Bookmarks.Item("Tur").Range.Text = TxtTurno.Text
        Documento.Bookmarks.Item("Sem").Range.Text = TxtSemestre.Text
        Documento.Bookmarks.Item("Costo").Range.Text = TxtCosto.Text
        Documento.Bookmarks.Item("Area").Range.Text = TxtArea.Text
        Documento.Bookmarks.Item("Academia").Range.Text = TxtAcademia.Text
        Documento.Bookmarks.Item("Programa").Range.Text = TxtPrograma.Text

        MsgBox("El Archivo se ha generado Exitosamente")
        Documento.SaveAs("Informe Practica " + CboPrac.Text)
        MSWord.Visible = True

    End Sub
End Class
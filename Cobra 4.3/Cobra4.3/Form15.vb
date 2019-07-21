Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO
Public Class FrmCoordinacion
    Private conexion As String
    Private Sub BtnRegrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegrear.Click
        Me.Close()
        FrmInicio.Show()

    End Sub

    Private Sub FrmCoordinacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cargar()

    End Sub

    Private Sub Cargar()
        Dim Cadena, Cadena2 As String
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

        Dim Profesor2TableAdapter As OleDbDataAdapter
        Profesor2TableAdapter = New OleDbDataAdapter

        Profesor2TableAdapter.SelectCommand = New OleDbCommand("SELECT * From PROFESOR", conexion)

        Dim FourDataSet As DataSet
        FourDataSet = New DataSet
        FourDataSet.Tables.Add("profesor")




        EmpresaTableAdapter.Fill(FirstDataSet.Tables("empresa"))
        VisitaTableAdapter.Fill(ThirdDataSet.Tables("visita"))
        ProfesorTableAdapter.Fill(SecondDataSet.Tables("profesor"))
        Profesor2TableAdapter.Fill(FourDataSet.Tables("profesor"))

        'Campos Empresa'
        CboNomEmp.DataSource = FirstDataSet.Tables("empresa")
        CboNomEmp.DisplayMember = "Nombre Empresa"

        'Campos Profesor'
        CboProf.DataSource = SecondDataSet.Tables("profesor")
        CboProf.DisplayMember = "Nombre Profesor"

        CboProf2.DataSource = FourDataSet.Tables("profesor")
        CboProf2.DisplayMember = "Nombre Profesor"

        TxtCarrera.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Carrera")
       

        'Campos Visita'

        CboPrac.DataSource = ThirdDataSet.Tables("visita")
        CboPrac.DisplayMember = "No Practica"

        TxtFecha.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Fecha")
        TxtCosto.DataBindings.Add("Text", ThirdDataSet.Tables("visita"), "Costo")



        'Conexion segunda BD'
        Cadena2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DirectivosCecyt8.mdb" 'Proveedor de la Base de Datos y nos permitira comunicarnos con ella
        Dim conexion2 As OleDbConnection 'Se encarga de la conexion con la base de Datos 
        conexion2 = New OleDbConnection(Cadena2) 'Parametro que conecta con la base de 

        'autoridades'
        Dim AutoridadesTableAdapter As OleDbDataAdapter
        AutoridadesTableAdapter = New OleDbDataAdapter

        AutoridadesTableAdapter.SelectCommand = New OleDbCommand("SELECT * From AUTORIDADES", conexion2)

        Dim FifthDataSet As DataSet
        FifthDataSet = New DataSet
        FifthDataSet.Tables.Add("autoridades")
        AutoridadesTableAdapter.Fill(FifthDataSet.Tables("autoridades"))

        'Campos autoridades'
        TxtSubdirectora.DataBindings.Add("Text", FifthDataSet.Tables("autoridades"), "Subdirectora Admin")
        TxtServicios.DataBindings.Add("Text", FifthDataSet.Tables("autoridades"), "Servicios Educativos")
        TxtSubdirector.DataBindings.Add("Text", FifthDataSet.Tables("autoridades"), "Subdirector Academico")
        TxtPracticas.DataBindings.Add("Text", FifthDataSet.Tables("autoridades"), "Responsable Practicas")
        TxtDirector.DataBindings.Add("Text", FifthDataSet.Tables("autoridades"), "Director")






    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document



        Documento = MSWord.Documents.Open("C:\Program Files (x86)\UPIS\Coordinacion.docx")
        Documento.Bookmarks.Item("Practica").Range.Text = CboPrac.Text
        Documento.Bookmarks.Item("Fecha").Range.Text = TxtFecha.Text
        Documento.Bookmarks.Item("Carrera").Range.Text = TxtCarrera.Text
        Documento.Bookmarks.Item("Profesor").Range.Text = CboProf.Text
        Documento.Bookmarks.Item("ProfTi").Range.Text = CboProf.Text
        Documento.Bookmarks.Item("Profesor2").Range.Text = CboProf2.Text
        Documento.Bookmarks.Item("ProfAu").Range.Text = CboProf2.Text
        Documento.Bookmarks.Item("Lugar").Range.Text = CboNomEmp.Text
        Documento.Bookmarks.Item("Costo").Range.Text = TxtCosto.Text

        Documento.Bookmarks.Item("Admin").Range.Text = TxtSubdirectora.Text
        Documento.Bookmarks.Item("Educa").Range.Text = TxtServicios.Text
        Documento.Bookmarks.Item("SubdirectorA").Range.Text = TxtSubdirector.Text
        Documento.Bookmarks.Item("ResponsableVisitas").Range.Text = TxtPracticas.Text
        Documento.Bookmarks.Item("Director").Range.Text = TxtDirector.Text


        MsgBox("El Archivo se ha generado Exitosamente")
        Documento.SaveAs("Coordinacion de Practica No" + CboPrac.Text)
        MSWord.Visible = True

    End Sub
End Class
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO
Public Class FrmFundamentacion
    Private conexion As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim Fecha As DateTime = Today
       
        Documento = MSWord.Documents.Open("C:\Program Files (x86)\UPIS\Fundamentacion.docx")
            Documento.Bookmarks.Item("Area").Range.Text = TxtArea.Text
            Documento.Bookmarks.Item("Unidad").Range.Text = TxtUa.Text
        Documento.Bookmarks.Item("Profesor").Range.Text = CboProf.Text
        Documento.Bookmarks.Item("Profesor1").Range.Text = CboProf.Text
        Documento.Bookmarks.Item("Empresa").Range.Text = CboNomEmp.Text
        Documento.Bookmarks.Item("FechaLl").Range.Text = Fecha
        Documento.Bookmarks.Item("JefeA").Range.Text = TxtJefe.Text
            MsgBox("El Archivo se ha generado Exitosamente")
            Documento.SaveAs("Informe Practica " + CboProf.Text)
        MSWord.Visible = True



       

    End Sub
    Private Sub BtnRegrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegrear.Click
        Me.Close()
        FrmInicio.Show()

    End Sub

    Private Sub FrmFundamentacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        'Profesor'

        Dim ProfesorTableAdapter As OleDbDataAdapter
        ProfesorTableAdapter = New OleDbDataAdapter

        ProfesorTableAdapter.SelectCommand = New OleDbCommand("SELECT * From PROFESOR", conexion)

        Dim SecondDataSet As DataSet
        SecondDataSet = New DataSet
        SecondDataSet.Tables.Add("profesor")




        EmpresaTableAdapter.Fill(FirstDataSet.Tables("empresa"))

        ProfesorTableAdapter.Fill(SecondDataSet.Tables("profesor"))

        'Campos Empresa'
        CboNomEmp.DataSource = FirstDataSet.Tables("empresa")
        CboNomEmp.DisplayMember = "Nombre Empresa"


        'Campos Profesor'
        CboProf.DataSource = SecondDataSet.Tables("profesor")
        CboProf.DisplayMember = "Nombre Profesor"


        TxtUa.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Unidad de Aprendizaje")
        TxtArea.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Area Profesor")

        TxtJefe.DataBindings.Add("Text", SecondDataSet.Tables("profesor"), "Jefe de area")

    End Sub
End Class
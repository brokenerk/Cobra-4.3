Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO

Public Class FrmInformeEx
    Private conexion As String
    Private Sub CboPracticas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPracticas.SelectedIndexChanged
        Select Case CboPracticas.SelectedItem
            Case "Foraneas"
                CboLugar.Text = ""
                CboLugar.Items.Clear()
                CboLugar.Items.Add("Aguascalientes")
                CboLugar.Items.Add("Baja California")
                CboLugar.Items.Add("Baja California Sur")
                CboLugar.Items.Add("Campeche")
                CboLugar.Items.Add("Ciudad de México")
                CboLugar.Items.Add("Chiapas")
                CboLugar.Items.Add("Chihuahua")
                CboLugar.Items.Add("Coahuila")
                CboLugar.Items.Add("Colima")
                CboLugar.Items.Add("Durango")
                CboLugar.Items.Add("Estado de México")
                CboLugar.Items.Add("Guanajuato")
                CboLugar.Items.Add("Guerrero")
                CboLugar.Items.Add("Hidalgo")
                CboLugar.Items.Add("Jalisco")
                CboLugar.Items.Add("Michoacan")
                CboLugar.Items.Add("Morelos")
                CboLugar.Items.Add("Nayarit")
                CboLugar.Items.Add("Nuevo León")
                CboLugar.Items.Add("Oaxaca")
                CboLugar.Items.Add("Puebla")
                CboLugar.Items.Add("Querétaro")
                CboLugar.Items.Add("Quintana Roo")
                CboLugar.Items.Add("San Luis Potosí")
                CboLugar.Items.Add("Sinaloa")
                CboLugar.Items.Add("Sonora")
                CboLugar.Items.Add("Tabasco")
                CboLugar.Items.Add("Tamaulipas")
                CboLugar.Items.Add("Tlaxcala")

                CboLugar.Items.Add("Veracruz")
                CboLugar.Items.Add("Yucatán")
                CboLugar.Items.Add("Zacatecas")



            Case "Metropolitanas"
                CboLugar.Text = ""
                CboLugar.Items.Clear()
                CboLugar.Items.Add("Álvaro Obregón")
                CboLugar.Items.Add("Azcapotzalco")
                CboLugar.Items.Add("Benito Juárez")
                CboLugar.Items.Add("Cuajimalpa de Morelos")
                CboLugar.Items.Add("Coyoacán")
                CboLugar.Items.Add("Cuauhtémoc")
                CboLugar.Items.Add("Gustavo A. Madero")
                CboLugar.Items.Add("Iztacalco")
                CboLugar.Items.Add("Iztapalapa")
                CboLugar.Items.Add("La Magdalena Contreras")
                CboLugar.Items.Add("Miguel Hidalgo")
                CboLugar.Items.Add("Milpa Alta")
                CboLugar.Items.Add("Tláhuac")
                CboLugar.Items.Add("Tlalpan")
                CboLugar.Items.Add("Venustiano Carranza")
                CboLugar.Items.Add("Xochimilco")
        End Select

    End Sub

    Private Sub FrmInformeEx_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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



        'Campos Visita'

        CboPract.DataSource = ThirdDataSet.Tables("visita")
        CboPract.DisplayMember = "No Practica"





    End Sub

    Private Sub BtnRegrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegrear.Click
        Me.Close()
        FrmInicio.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim op As Integer
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim ubi As String
        Dim nom As String
        Dim con As String
        ubi = TxtUbi.Text
        op = CboPract.Text
        nom = TxtNom.Text
        con = (ubi + "\" + nom + ".docx")




        If (CboPracticas.SelectedItem = "Foraneas") Then
            Documento = MSWord.Documents.Open(con)
            Select Case op
                Case 1
                    Documento.Bookmarks.Item("Np").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F").Range.Text = CboLugar.Text
                Case 2
                    Documento.Bookmarks.Item("Np1").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E1").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F1").Range.Text = CboLugar.Text
                Case 3
                    Documento.Bookmarks.Item("Np2").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E2").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F2").Range.Text = CboLugar.Text
                Case 4
                    Documento.Bookmarks.Item("Np3").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E3").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F3").Range.Text = CboLugar.Text
                Case 5
                    Documento.Bookmarks.Item("Np4").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E4").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F4").Range.Text = CboLugar.Text
                Case 6
                    Documento.Bookmarks.Item("Np5").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E5").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F5").Range.Text = CboLugar.Text
                Case 7
                    Documento.Bookmarks.Item("Np6").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E6").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F6").Range.Text = CboLugar.Text
                Case 8
                    Documento.Bookmarks.Item("Np7").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E7").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F7").Range.Text = CboLugar.Text
                Case 9
                    Documento.Bookmarks.Item("Np8").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E8").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F8").Range.Text = CboLugar.Text
                Case 10
                    Documento.Bookmarks.Item("Np9").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E9").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F9").Range.Text = CboLugar.Text
                Case 11
                    Documento.Bookmarks.Item("Np10").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E10").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F10").Range.Text = CboLugar.Text
                Case 12
                    Documento.Bookmarks.Item("Np11").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E11").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F11").Range.Text = CboLugar.Text
                Case 13
                    Documento.Bookmarks.Item("Np12").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("E12").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("F12").Range.Text = CboLugar.Text
            End Select
            Documento.SaveAs(nom)
            Documento.Close()
        End If
        If (CboPracticas.SelectedItem = "Metropolitanas") Then
            Documento = MSWord.Documents.Open(con)
            Select Case op
                Case 1
                    Documento.Bookmarks.Item("N").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd").Range.Text = CboLugar.Text
                Case 2
                    Documento.Bookmarks.Item("N1").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em1").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd1").Range.Text = CboLugar.Text
                Case 3
                    Documento.Bookmarks.Item("N2").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em2").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd2").Range.Text = CboLugar.Text
                Case 4
                    Documento.Bookmarks.Item("N3").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em3").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd3").Range.Text = CboLugar.Text
                Case 5
                    Documento.Bookmarks.Item("N4").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em4").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd4").Range.Text = CboLugar.Text
                Case 6
                    Documento.Bookmarks.Item("N5").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em5").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd5").Range.Text = CboLugar.Text
                Case 7
                    Documento.Bookmarks.Item("Np6").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em6").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd6").Range.Text = CboLugar.Text
                Case 8
                    Documento.Bookmarks.Item("N7").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em7").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd7").Range.Text = CboLugar.Text
                Case 9
                    Documento.Bookmarks.Item("N8").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em8").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd8").Range.Text = CboLugar.Text
                Case 10
                    Documento.Bookmarks.Item("N9").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em9").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd9").Range.Text = CboLugar.Text
                Case 11
                    Documento.Bookmarks.Item("N10").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em10").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd10").Range.Text = CboLugar.Text
                Case 12
                    Documento.Bookmarks.Item("N11").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em11").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd11").Range.Text = CboLugar.Text
                Case 13
                    Documento.Bookmarks.Item("N12").Range.Text = CboPract.Text
                    Documento.Bookmarks.Item("Em12").Range.Text = CboEmp.Text
                    Documento.Bookmarks.Item("Fd12").Range.Text = CboLugar.Text
            End Select
            Documento.SaveAs(nom)
            Documento.Close()
        End If
        MsgBox("El Archivo se ha generado Exitosamente")
    End Sub
End Class

Imports System.Data.OleDb

Imports System.IO
Imports System.Net.Mail
Public Class Form23


    Dim visita, fecha, practica, email, claveprof As String
    Private Sub Form23_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Cargar()

    End Sub
    Private Sub Cargar()
        Dim Cadena As String
        Cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\UPISCECYT8.mdb" 'Proveedor de la Base de Datos y nos permitira comunicarnos con ella
        Dim conexion As OleDbConnection 'Se encarga de la conexion con la base de Datos 
        conexion = New OleDbConnection(Cadena) 'Parametro que conecta con la base de 

        Dim ProfesorTableAdapter As OleDbDataAdapter
        ProfesorTableAdapter = New OleDbDataAdapter

        ProfesorTableAdapter.SelectCommand = New OleDbCommand("SELECT * From PROFESOR", conexion)

        Dim FirstDataSet As DataSet
        FirstDataSet = New DataSet
        FirstDataSet.Tables.Add("profesor")

        Dim VisitaTableAdapter As OleDbDataAdapter
        VisitaTableAdapter = New OleDbDataAdapter

        VisitaTableAdapter.SelectCommand = New OleDbCommand("SELECT * From VISITA", conexion)

        Dim SecondDataSet As DataSet
        SecondDataSet = New DataSet

        SecondDataSet.Tables.Add("visita")
        VisitaTableAdapter.Fill(SecondDataSet.Tables("visita"))
        ProfesorTableAdapter.Fill(FirstDataSet.Tables("profesor"))

        CboPractica.DataSource = SecondDataSet.Tables("visita")
        CboPractica.DisplayMember = "No Practica"

        TxtFecha.DataBindings.Add("Text", SecondDataSet.Tables("visita"), "Fecha")

        CboClaveProf.DataSource = FirstDataSet.Tables("profesor")
        CboClaveProf.DisplayMember = "Clave Profesor"

        TxtEmail.DataBindings.Add("Text", FirstDataSet.Tables("profesor"), "Email Profesor")


    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
       

        

            fecha = TxtFecha.Text
            email = TxtEmail.Text
            Dim FINICIAL As DateTime = Today
            Dim FFINAL As DateTime = Convert.ToDateTime(fecha)
            Dim DIFDIAS As Integer

            DIFDIAS = (FFINAL - FINICIAL).TotalDays

            If (DIFDIAS = 3) Then
                Dim Mensaje, Asunto, Upis, Contra As String
                Mensaje = TxtMensaje.Text
                Asunto = TxtAsunto.Text
                Upis = TxtCorreoUpis.Text
                Contra = TxtContra.Text
                If Mensaje = "" Or Asunto = "" Then
                    MsgBox("Por favor, escriba el Asunto y/o Cuerpo del email.")
                Else
                    Dim _Message As New System.Net.Mail.MailMessage()
                    Dim _SMTP As New System.Net.Mail.SmtpClient


                    'CONFIGURACIÓN DEL STMP
                    '_SMTP.Credentials = New System.Net.NetworkCredential("cuenta de correo", "contraseña")
                    _SMTP.Credentials = New System.Net.NetworkCredential(Upis, Contra)
                    _SMTP.Host = "smtp.gmail.com"
                    _SMTP.Port = 587
                    _SMTP.EnableSsl = True

                    ' CONFIGURACION DEL MENSAJE
                    _Message.[To].Add(email) 'Cuenta de Correo al que se le quiere enviar el e-mail
                    _Message.From = New System.Net.Mail.MailAddress(Upis, "UPIS CECyT 8 NB", System.Text.Encoding.UTF8) 'Quien lo envía
                    _Message.Subject = Asunto 'Sujeto del e-mail
                    _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
                    _Message.Body = Mensaje 'contenido del mail
                    _Message.BodyEncoding = System.Text.Encoding.UTF8
                    _Message.Priority = System.Net.Mail.MailPriority.Normal
                    _Message.IsBodyHtml = False

                    'ENVIO
                    Try
                        _SMTP.Send(_Message)
                        MessageBox.Show("Mensaje enviado correctamente", "Aviso", MessageBoxButtons.OK)
                        Me.Close()
                    Catch ex As System.Net.Mail.SmtpException
                        MessageBox.Show(ex.ToString, "Error de conexion.", MessageBoxButtons.OK)
                    End Try
                End If
            Else
                MsgBox("Aun no se ha cumplido el periodo previo o se ha excedido el mismo")
            End If





    End Sub
End Class
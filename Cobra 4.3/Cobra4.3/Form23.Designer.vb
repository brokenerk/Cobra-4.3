<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form23
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form23))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PROFESORDataGridView = New System.Windows.Forms.DataGridView()
        Me.VISITADataGridView = New System.Windows.Forms.DataGridView()
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAsunto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCorreoUpis = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtContra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboPractica = New System.Windows.Forms.ComboBox()
        Me.CboClaveProf = New System.Windows.Forms.ComboBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        CType(Me.PROFESORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISITADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Seleccione la Clave del Profesor:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(225, 425)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 68)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Enviar Email"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Seleccione el Numero de Practica:"
        '
        'PROFESORDataGridView
        '
        Me.PROFESORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PROFESORDataGridView.Location = New System.Drawing.Point(1004, 68)
        Me.PROFESORDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PROFESORDataGridView.Name = "PROFESORDataGridView"
        Me.PROFESORDataGridView.Size = New System.Drawing.Size(153, 126)
        Me.PROFESORDataGridView.TabIndex = 13
        Me.PROFESORDataGridView.Visible = False
        '
        'VISITADataGridView
        '
        Me.VISITADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VISITADataGridView.Location = New System.Drawing.Point(1004, 230)
        Me.VISITADataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.VISITADataGridView.Name = "VISITADataGridView"
        Me.VISITADataGridView.Size = New System.Drawing.Size(346, 209)
        Me.VISITADataGridView.TabIndex = 13
        Me.VISITADataGridView.Visible = False
        '
        'TxtMensaje
        '
        Me.TxtMensaje.Location = New System.Drawing.Point(60, 211)
        Me.TxtMensaje.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMensaje.Multiline = True
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(522, 184)
        Me.TxtMensaje.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mensaje:"
        '
        'TxtAsunto
        '
        Me.TxtAsunto.Location = New System.Drawing.Point(60, 157)
        Me.TxtAsunto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAsunto.Name = "TxtAsunto"
        Me.TxtAsunto.Size = New System.Drawing.Size(522, 22)
        Me.TxtAsunto.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ASUNTO:"
        '
        'TxtCorreoUpis
        '
        Me.TxtCorreoUpis.Location = New System.Drawing.Point(16, 99)
        Me.TxtCorreoUpis.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCorreoUpis.Name = "TxtCorreoUpis"
        Me.TxtCorreoUpis.Size = New System.Drawing.Size(292, 22)
        Me.TxtCorreoUpis.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Correo electronico (UPIS) :"
        '
        'TxtContra
        '
        Me.TxtContra.Location = New System.Drawing.Point(329, 99)
        Me.TxtContra.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtContra.Name = "TxtContra"
        Me.TxtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContra.Size = New System.Drawing.Size(292, 22)
        Me.TxtContra.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(326, 79)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Contraseña:"
        '
        'CboPractica
        '
        Me.CboPractica.FormattingEnabled = True
        Me.CboPractica.Location = New System.Drawing.Point(383, 12)
        Me.CboPractica.Name = "CboPractica"
        Me.CboPractica.Size = New System.Drawing.Size(92, 24)
        Me.CboPractica.TabIndex = 22
        '
        'CboClaveProf
        '
        Me.CboClaveProf.FormattingEnabled = True
        Me.CboClaveProf.Location = New System.Drawing.Point(383, 45)
        Me.CboClaveProf.Name = "CboClaveProf"
        Me.CboClaveProf.Size = New System.Drawing.Size(92, 24)
        Me.CboClaveProf.TabIndex = 23
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(736, 157)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 22)
        Me.TxtFecha.TabIndex = 24
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(736, 192)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(100, 22)
        Me.TxtEmail.TabIndex = 25
        '
        'Form23
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(636, 508)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.CboClaveProf)
        Me.Controls.Add(Me.CboPractica)
        Me.Controls.Add(Me.TxtContra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtCorreoUpis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtAsunto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMensaje)
        Me.Controls.Add(Me.VISITADataGridView)
        Me.Controls.Add(Me.PROFESORDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form23"
        Me.Text = "Aviso al Profesor"
        CType(Me.PROFESORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISITADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PROFESORDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VISITADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TxtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCorreoUpis As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtContra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CboPractica As System.Windows.Forms.ComboBox
    Friend WithEvents CboClaveProf As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
End Class

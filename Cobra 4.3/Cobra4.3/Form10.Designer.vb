<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContol
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContol))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUa = New System.Windows.Forms.TextBox()
        Me.TxtDir = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtCarrera = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboPrac = New System.Windows.Forms.ComboBox()
        Me.TxtUbi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRegrear = New System.Windows.Forms.Button()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.CboEmp = New System.Windows.Forms.ComboBox()
        Me.CboProf = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtGrupo = New System.Windows.Forms.TextBox()
        Me.TxtAlu = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 16)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Profesor asignado "
        '
        'TxtUa
        '
        Me.TxtUa.Location = New System.Drawing.Point(151, 392)
        Me.TxtUa.Name = "TxtUa"
        Me.TxtUa.Size = New System.Drawing.Size(100, 20)
        Me.TxtUa.TabIndex = 90
        '
        'TxtDir
        '
        Me.TxtDir.Location = New System.Drawing.Point(257, 392)
        Me.TxtDir.Name = "TxtDir"
        Me.TxtDir.Size = New System.Drawing.Size(100, 20)
        Me.TxtDir.TabIndex = 89
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(363, 392)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 88
        '
        'TxtCarrera
        '
        Me.TxtCarrera.Location = New System.Drawing.Point(515, 376)
        Me.TxtCarrera.Name = "TxtCarrera"
        Me.TxtCarrera.Size = New System.Drawing.Size(100, 20)
        Me.TxtCarrera.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Nombre de Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(536, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "No. Practica"
        '
        'CboPrac
        '
        Me.CboPrac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPrac.FormattingEnabled = True
        Me.CboPrac.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
        Me.CboPrac.Location = New System.Drawing.Point(643, 22)
        Me.CboPrac.Name = "CboPrac"
        Me.CboPrac.Size = New System.Drawing.Size(48, 24)
        Me.CboPrac.TabIndex = 80
        '
        'TxtUbi
        '
        Me.TxtUbi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUbi.Location = New System.Drawing.Point(206, 16)
        Me.TxtUbi.Name = "TxtUbi"
        Me.TxtUbi.Size = New System.Drawing.Size(311, 22)
        Me.TxtUbi.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Ubicacion del documento "
        '
        'BtnRegrear
        '
        Me.BtnRegrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegrear.Location = New System.Drawing.Point(151, 214)
        Me.BtnRegrear.Name = "BtnRegrear"
        Me.BtnRegrear.Size = New System.Drawing.Size(122, 51)
        Me.BtnRegrear.TabIndex = 77
        Me.BtnRegrear.Text = "Regresar"
        Me.BtnRegrear.UseVisualStyleBackColor = False
        '
        'BtnGenerar
        '
        Me.BtnGenerar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerar.Location = New System.Drawing.Point(342, 205)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(235, 68)
        Me.BtnGenerar.TabIndex = 76
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = False
        '
        'CboEmp
        '
        Me.CboEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEmp.FormattingEnabled = True
        Me.CboEmp.Location = New System.Drawing.Point(206, 104)
        Me.CboEmp.Name = "CboEmp"
        Me.CboEmp.Size = New System.Drawing.Size(296, 24)
        Me.CboEmp.TabIndex = 95
        '
        'CboProf
        '
        Me.CboProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProf.FormattingEnabled = True
        Me.CboProf.Location = New System.Drawing.Point(206, 153)
        Me.CboProf.Name = "CboProf"
        Me.CboProf.Size = New System.Drawing.Size(296, 24)
        Me.CboProf.TabIndex = 96
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(536, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Grupo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 16)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Nombre Documento"
        '
        'TxtNom
        '
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(206, 59)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(238, 22)
        Me.TxtNom.TabIndex = 100
        '
        'TxtGrupo
        '
        Me.TxtGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrupo.Location = New System.Drawing.Point(643, 59)
        Me.TxtGrupo.Name = "TxtGrupo"
        Me.TxtGrupo.Size = New System.Drawing.Size(78, 22)
        Me.TxtGrupo.TabIndex = 101
        '
        'TxtAlu
        '
        Me.TxtAlu.Location = New System.Drawing.Point(775, 284)
        Me.TxtAlu.Name = "TxtAlu"
        Me.TxtAlu.Size = New System.Drawing.Size(100, 20)
        Me.TxtAlu.TabIndex = 102
        Me.TxtAlu.Visible = False
        '
        'FrmContol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(747, 299)
        Me.Controls.Add(Me.TxtAlu)
        Me.Controls.Add(Me.TxtGrupo)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CboProf)
        Me.Controls.Add(Me.CboEmp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtUa)
        Me.Controls.Add(Me.TxtDir)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtCarrera)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboPrac)
        Me.Controls.Add(Me.TxtUbi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnRegrear)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmContol"
        Me.Text = "Avisos y Seguimientos (Existente)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtUa As System.Windows.Forms.TextBox
    Friend WithEvents TxtDir As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtCarrera As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboPrac As System.Windows.Forms.ComboBox
    Friend WithEvents TxtUbi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnRegrear As System.Windows.Forms.Button
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents CboEmp As System.Windows.Forms.ComboBox
    Friend WithEvents CboProf As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents TxtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlu As System.Windows.Forms.TextBox
End Class

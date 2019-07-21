<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInforme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInforme))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboPrac = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnRegrear = New System.Windows.Forms.Button()
        Me.TxtRAP = New System.Windows.Forms.TextBox()
        Me.TxtPrograma = New System.Windows.Forms.TextBox()
        Me.TxtCompetencia = New System.Windows.Forms.TextBox()
        Me.TxtAsistentes = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtGiro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboNomEmp = New System.Windows.Forms.ComboBox()
        Me.TxtSemestre = New System.Windows.Forms.TextBox()
        Me.TxtTurno = New System.Windows.Forms.TextBox()
        Me.CboProf = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.TxtUa = New System.Windows.Forms.TextBox()
        Me.TxtGrupo = New System.Windows.Forms.TextBox()
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.TxtAcademia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Practica"
        '
        'CboPrac
        '
        Me.CboPrac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPrac.FormattingEnabled = True
        Me.CboPrac.Location = New System.Drawing.Point(139, 109)
        Me.CboPrac.Name = "CboPrac"
        Me.CboPrac.Size = New System.Drawing.Size(49, 24)
        Me.CboPrac.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(147, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 68)
        Me.Button1.TabIndex = 100
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnRegrear
        '
        Me.BtnRegrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegrear.Location = New System.Drawing.Point(12, 167)
        Me.BtnRegrear.Name = "BtnRegrear"
        Me.BtnRegrear.Size = New System.Drawing.Size(122, 51)
        Me.BtnRegrear.TabIndex = 101
        Me.BtnRegrear.Text = "Regresar"
        Me.BtnRegrear.UseVisualStyleBackColor = False
        '
        'TxtRAP
        '
        Me.TxtRAP.Location = New System.Drawing.Point(551, 63)
        Me.TxtRAP.Name = "TxtRAP"
        Me.TxtRAP.Size = New System.Drawing.Size(100, 20)
        Me.TxtRAP.TabIndex = 102
        '
        'TxtPrograma
        '
        Me.TxtPrograma.Location = New System.Drawing.Point(551, 167)
        Me.TxtPrograma.Name = "TxtPrograma"
        Me.TxtPrograma.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrograma.TabIndex = 103
        '
        'TxtCompetencia
        '
        Me.TxtCompetencia.Location = New System.Drawing.Point(551, 141)
        Me.TxtCompetencia.Name = "TxtCompetencia"
        Me.TxtCompetencia.Size = New System.Drawing.Size(100, 20)
        Me.TxtCompetencia.TabIndex = 104
        '
        'TxtAsistentes
        '
        Me.TxtAsistentes.Location = New System.Drawing.Point(551, 115)
        Me.TxtAsistentes.Name = "TxtAsistentes"
        Me.TxtAsistentes.Size = New System.Drawing.Size(100, 20)
        Me.TxtAsistentes.TabIndex = 105
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(551, 89)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 106
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(551, 219)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(100, 20)
        Me.TxtDomicilio.TabIndex = 107
        '
        'TxtGiro
        '
        Me.TxtGiro.Location = New System.Drawing.Point(551, 193)
        Me.TxtGiro.Name = "TxtGiro"
        Me.TxtGiro.Size = New System.Drawing.Size(100, 20)
        Me.TxtGiro.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Nombre de Empresa"
        '
        'CboNomEmp
        '
        Me.CboNomEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNomEmp.FormattingEnabled = True
        Me.CboNomEmp.Location = New System.Drawing.Point(211, 19)
        Me.CboNomEmp.Name = "CboNomEmp"
        Me.CboNomEmp.Size = New System.Drawing.Size(245, 24)
        Me.CboNomEmp.TabIndex = 110
        '
        'TxtSemestre
        '
        Me.TxtSemestre.Location = New System.Drawing.Point(551, 11)
        Me.TxtSemestre.Name = "TxtSemestre"
        Me.TxtSemestre.Size = New System.Drawing.Size(100, 20)
        Me.TxtSemestre.TabIndex = 111
        '
        'TxtTurno
        '
        Me.TxtTurno.Location = New System.Drawing.Point(551, 37)
        Me.TxtTurno.Name = "TxtTurno"
        Me.TxtTurno.Size = New System.Drawing.Size(100, 20)
        Me.TxtTurno.TabIndex = 112
        '
        'CboProf
        '
        Me.CboProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProf.FormattingEnabled = True
        Me.CboProf.Location = New System.Drawing.Point(211, 64)
        Me.CboProf.Name = "CboProf"
        Me.CboProf.Size = New System.Drawing.Size(245, 24)
        Me.CboProf.TabIndex = 113
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Profesor asignado"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.Location = New System.Drawing.Point(332, 112)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(50, 16)
        Me.Lbl.TabIndex = 115
        Me.Lbl.Text = "Grupo"
        '
        'TxtUa
        '
        Me.TxtUa.Location = New System.Drawing.Point(551, 245)
        Me.TxtUa.Name = "TxtUa"
        Me.TxtUa.Size = New System.Drawing.Size(100, 20)
        Me.TxtUa.TabIndex = 117
        '
        'TxtGrupo
        '
        Me.TxtGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrupo.Location = New System.Drawing.Point(384, 109)
        Me.TxtGrupo.Name = "TxtGrupo"
        Me.TxtGrupo.Size = New System.Drawing.Size(69, 22)
        Me.TxtGrupo.TabIndex = 118
        '
        'TxtArea
        '
        Me.TxtArea.Location = New System.Drawing.Point(551, 271)
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.Size = New System.Drawing.Size(100, 20)
        Me.TxtArea.TabIndex = 119
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(551, 297)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(100, 20)
        Me.TxtCosto.TabIndex = 120
        '
        'TxtAcademia
        '
        Me.TxtAcademia.Location = New System.Drawing.Point(551, 323)
        Me.TxtAcademia.Name = "TxtAcademia"
        Me.TxtAcademia.Size = New System.Drawing.Size(100, 20)
        Me.TxtAcademia.TabIndex = 121
        '
        'FrmInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(479, 237)
        Me.Controls.Add(Me.TxtAcademia)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.TxtArea)
        Me.Controls.Add(Me.TxtGrupo)
        Me.Controls.Add(Me.TxtUa)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CboProf)
        Me.Controls.Add(Me.TxtTurno)
        Me.Controls.Add(Me.TxtSemestre)
        Me.Controls.Add(Me.CboNomEmp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtGiro)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtAsistentes)
        Me.Controls.Add(Me.TxtCompetencia)
        Me.Controls.Add(Me.TxtPrograma)
        Me.Controls.Add(Me.TxtRAP)
        Me.Controls.Add(Me.BtnRegrear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CboPrac)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmInforme"
        Me.Text = "Informe Academico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboPrac As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnRegrear As System.Windows.Forms.Button
    Friend WithEvents TxtRAP As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrograma As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents TxtAsistentes As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents TxtGiro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboNomEmp As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSemestre As System.Windows.Forms.TextBox
    Friend WithEvents TxtTurno As System.Windows.Forms.TextBox
    Friend WithEvents CboProf As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents TxtUa As System.Windows.Forms.TextBox
    Friend WithEvents TxtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents TxtArea As System.Windows.Forms.TextBox
    Friend WithEvents TxtCosto As System.Windows.Forms.TextBox
    Friend WithEvents TxtAcademia As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCoordinacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCoordinacion))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboProf = New System.Windows.Forms.ComboBox()
        Me.CboNomEmp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboPrac = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegrear = New System.Windows.Forms.Button()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.TxtCarrera = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboProf2 = New System.Windows.Forms.ComboBox()
        Me.TxtDirector = New System.Windows.Forms.TextBox()
        Me.TxtPracticas = New System.Windows.Forms.TextBox()
        Me.TxtSubdirector = New System.Windows.Forms.TextBox()
        Me.TxtServicios = New System.Windows.Forms.TextBox()
        Me.TxtSubdirectora = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Profesor Titular"
        '
        'CboProf
        '
        Me.CboProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProf.FormattingEnabled = True
        Me.CboProf.Location = New System.Drawing.Point(194, 70)
        Me.CboProf.Name = "CboProf"
        Me.CboProf.Size = New System.Drawing.Size(245, 24)
        Me.CboProf.TabIndex = 119
        '
        'CboNomEmp
        '
        Me.CboNomEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNomEmp.FormattingEnabled = True
        Me.CboNomEmp.Location = New System.Drawing.Point(194, 25)
        Me.CboNomEmp.Name = "CboNomEmp"
        Me.CboNomEmp.Size = New System.Drawing.Size(245, 24)
        Me.CboNomEmp.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Nombre de Empresa"
        '
        'CboPrac
        '
        Me.CboPrac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPrac.FormattingEnabled = True
        Me.CboPrac.Location = New System.Drawing.Point(194, 155)
        Me.CboPrac.Name = "CboPrac"
        Me.CboPrac.Size = New System.Drawing.Size(49, 24)
        Me.CboPrac.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "No Practica"
        '
        'BtnRegrear
        '
        Me.BtnRegrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegrear.Location = New System.Drawing.Point(53, 210)
        Me.BtnRegrear.Name = "BtnRegrear"
        Me.BtnRegrear.Size = New System.Drawing.Size(122, 51)
        Me.BtnRegrear.TabIndex = 122
        Me.BtnRegrear.Text = "Regresar"
        Me.BtnRegrear.UseVisualStyleBackColor = False
        '
        'BtnGenerar
        '
        Me.BtnGenerar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerar.Location = New System.Drawing.Point(194, 201)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(235, 68)
        Me.BtnGenerar.TabIndex = 121
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = False
        '
        'TxtCarrera
        '
        Me.TxtCarrera.Location = New System.Drawing.Point(483, 22)
        Me.TxtCarrera.Name = "TxtCarrera"
        Me.TxtCarrera.Size = New System.Drawing.Size(100, 20)
        Me.TxtCarrera.TabIndex = 123
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(483, 49)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 124
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(483, 76)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(100, 20)
        Me.TxtCosto.TabIndex = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Profesor Auxiliar"
        '
        'CboProf2
        '
        Me.CboProf2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProf2.FormattingEnabled = True
        Me.CboProf2.Location = New System.Drawing.Point(194, 116)
        Me.CboProf2.Name = "CboProf2"
        Me.CboProf2.Size = New System.Drawing.Size(245, 24)
        Me.CboProf2.TabIndex = 126
        '
        'TxtDirector
        '
        Me.TxtDirector.Location = New System.Drawing.Point(483, 297)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(82, 20)
        Me.TxtDirector.TabIndex = 132
        '
        'TxtPracticas
        '
        Me.TxtPracticas.Location = New System.Drawing.Point(483, 261)
        Me.TxtPracticas.Name = "TxtPracticas"
        Me.TxtPracticas.Size = New System.Drawing.Size(82, 20)
        Me.TxtPracticas.TabIndex = 131
        '
        'TxtSubdirector
        '
        Me.TxtSubdirector.Location = New System.Drawing.Point(483, 223)
        Me.TxtSubdirector.Name = "TxtSubdirector"
        Me.TxtSubdirector.Size = New System.Drawing.Size(82, 20)
        Me.TxtSubdirector.TabIndex = 130
        '
        'TxtServicios
        '
        Me.TxtServicios.Location = New System.Drawing.Point(483, 187)
        Me.TxtServicios.Name = "TxtServicios"
        Me.TxtServicios.Size = New System.Drawing.Size(82, 20)
        Me.TxtServicios.TabIndex = 129
        '
        'TxtSubdirectora
        '
        Me.TxtSubdirectora.Location = New System.Drawing.Point(483, 148)
        Me.TxtSubdirectora.Name = "TxtSubdirectora"
        Me.TxtSubdirectora.Size = New System.Drawing.Size(82, 20)
        Me.TxtSubdirectora.TabIndex = 128
        '
        'FrmCoordinacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(461, 291)
        Me.Controls.Add(Me.TxtDirector)
        Me.Controls.Add(Me.TxtPracticas)
        Me.Controls.Add(Me.TxtSubdirector)
        Me.Controls.Add(Me.TxtServicios)
        Me.Controls.Add(Me.TxtSubdirectora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CboProf2)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtCarrera)
        Me.Controls.Add(Me.BtnRegrear)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CboProf)
        Me.Controls.Add(Me.CboNomEmp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboPrac)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCoordinacion"
        Me.Text = "Coordinacion de Practicas y Visitas Escolares"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboProf As System.Windows.Forms.ComboBox
    Friend WithEvents CboNomEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboPrac As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRegrear As System.Windows.Forms.Button
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents TxtCarrera As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboProf2 As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDirector As System.Windows.Forms.TextBox
    Friend WithEvents TxtPracticas As System.Windows.Forms.TextBox
    Friend WithEvents TxtSubdirector As System.Windows.Forms.TextBox
    Friend WithEvents TxtServicios As System.Windows.Forms.TextBox
    Friend WithEvents TxtSubdirectora As System.Windows.Forms.TextBox
End Class

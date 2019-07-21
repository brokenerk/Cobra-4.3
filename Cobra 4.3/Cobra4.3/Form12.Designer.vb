<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevo))
        Me.CboProf = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboPrac = New System.Windows.Forms.ComboBox()
        Me.BtnRegrear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtUa = New System.Windows.Forms.TextBox()
        Me.TxtDir = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtCarrera = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboEmp = New System.Windows.Forms.ComboBox()
        Me.TxtAlu = New System.Windows.Forms.TextBox()
        Me.TxtGrupo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CboProf
        '
        Me.CboProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProf.FormattingEnabled = True
        Me.CboProf.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
        Me.CboProf.Location = New System.Drawing.Point(181, 73)
        Me.CboProf.Name = "CboProf"
        Me.CboProf.Size = New System.Drawing.Size(296, 24)
        Me.CboProf.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 16)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Profesor asignado "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Nombre de Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(504, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "No. Practica"
        '
        'CboPrac
        '
        Me.CboPrac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPrac.FormattingEnabled = True
        Me.CboPrac.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
        Me.CboPrac.Location = New System.Drawing.Point(617, 24)
        Me.CboPrac.Name = "CboPrac"
        Me.CboPrac.Size = New System.Drawing.Size(48, 24)
        Me.CboPrac.TabIndex = 93
        '
        'BtnRegrear
        '
        Me.BtnRegrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegrear.Location = New System.Drawing.Point(12, 182)
        Me.BtnRegrear.Name = "BtnRegrear"
        Me.BtnRegrear.Size = New System.Drawing.Size(122, 51)
        Me.BtnRegrear.TabIndex = 100
        Me.BtnRegrear.Text = "Regresar"
        Me.BtnRegrear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(213, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 68)
        Me.Button1.TabIndex = 99
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtUa
        '
        Me.TxtUa.Location = New System.Drawing.Point(114, 310)
        Me.TxtUa.Name = "TxtUa"
        Me.TxtUa.Size = New System.Drawing.Size(100, 20)
        Me.TxtUa.TabIndex = 104
        '
        'TxtDir
        '
        Me.TxtDir.Location = New System.Drawing.Point(220, 310)
        Me.TxtDir.Name = "TxtDir"
        Me.TxtDir.Size = New System.Drawing.Size(100, 20)
        Me.TxtDir.TabIndex = 103
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(326, 310)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 102
        '
        'TxtCarrera
        '
        Me.TxtCarrera.Location = New System.Drawing.Point(478, 294)
        Me.TxtCarrera.Name = "TxtCarrera"
        Me.TxtCarrera.Size = New System.Drawing.Size(100, 20)
        Me.TxtCarrera.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(504, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Grupo"
        '
        'CboEmp
        '
        Me.CboEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEmp.FormattingEnabled = True
        Me.CboEmp.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
        Me.CboEmp.Location = New System.Drawing.Point(181, 24)
        Me.CboEmp.Name = "CboEmp"
        Me.CboEmp.Size = New System.Drawing.Size(296, 24)
        Me.CboEmp.TabIndex = 107
        '
        'TxtAlu
        '
        Me.TxtAlu.Location = New System.Drawing.Point(441, 320)
        Me.TxtAlu.Name = "TxtAlu"
        Me.TxtAlu.Size = New System.Drawing.Size(100, 20)
        Me.TxtAlu.TabIndex = 108
        '
        'TxtGrupo
        '
        Me.TxtGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrupo.Location = New System.Drawing.Point(617, 73)
        Me.TxtGrupo.Name = "TxtGrupo"
        Me.TxtGrupo.Size = New System.Drawing.Size(67, 22)
        Me.TxtGrupo.TabIndex = 109
        '
        'FrmNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(700, 245)
        Me.Controls.Add(Me.TxtGrupo)
        Me.Controls.Add(Me.TxtAlu)
        Me.Controls.Add(Me.CboEmp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtUa)
        Me.Controls.Add(Me.TxtDir)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtCarrera)
        Me.Controls.Add(Me.BtnRegrear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CboProf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboPrac)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmNuevo"
        Me.Text = "Avisos y Seguimientos (Nuevo)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CboProf As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboPrac As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRegrear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtUa As System.Windows.Forms.TextBox
    Friend WithEvents TxtDir As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtCarrera As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboEmp As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAlu As System.Windows.Forms.TextBox
    Friend WithEvents TxtGrupo As System.Windows.Forms.TextBox
End Class

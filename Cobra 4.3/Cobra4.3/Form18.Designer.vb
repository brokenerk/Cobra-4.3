<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFund
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFund))
        Me.BtnRegrear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtUbi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboEmp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboPrac = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtConfir = New System.Windows.Forms.TextBox()
        Me.TxtGiro = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtJefe = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnRegrear
        '
        Me.BtnRegrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegrear.Location = New System.Drawing.Point(89, 191)
        Me.BtnRegrear.Name = "BtnRegrear"
        Me.BtnRegrear.Size = New System.Drawing.Size(122, 51)
        Me.BtnRegrear.TabIndex = 126
        Me.BtnRegrear.Text = "Regresar"
        Me.BtnRegrear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(234, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 68)
        Me.Button1.TabIndex = 125
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtNom
        '
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(233, 48)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(238, 22)
        Me.TxtNom.TabIndex = 130
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 16)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Nombre Documento"
        '
        'TxtUbi
        '
        Me.TxtUbi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUbi.Location = New System.Drawing.Point(233, 15)
        Me.TxtUbi.Name = "TxtUbi"
        Me.TxtUbi.Size = New System.Drawing.Size(311, 22)
        Me.TxtUbi.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 16)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Ubicacion del documento "
        '
        'CboEmp
        '
        Me.CboEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEmp.FormattingEnabled = True
        Me.CboEmp.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio ", "Agosto", "Septiembre", "Octubre ", "Noviembre ", "Diciembre"})
        Me.CboEmp.Location = New System.Drawing.Point(233, 93)
        Me.CboEmp.Name = "CboEmp"
        Me.CboEmp.Size = New System.Drawing.Size(158, 24)
        Me.CboEmp.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Empresa"
        '
        'CboPrac
        '
        Me.CboPrac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPrac.FormattingEnabled = True
        Me.CboPrac.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio ", "Agosto", "Septiembre", "Octubre ", "Noviembre ", "Diciembre"})
        Me.CboPrac.Location = New System.Drawing.Point(231, 131)
        Me.CboPrac.Name = "CboPrac"
        Me.CboPrac.Size = New System.Drawing.Size(47, 24)
        Me.CboPrac.TabIndex = 134
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "No Practica"
        '
        'TxtConfir
        '
        Me.TxtConfir.Location = New System.Drawing.Point(716, 139)
        Me.TxtConfir.Name = "TxtConfir"
        Me.TxtConfir.Size = New System.Drawing.Size(100, 20)
        Me.TxtConfir.TabIndex = 139
        '
        'TxtGiro
        '
        Me.TxtGiro.Location = New System.Drawing.Point(716, 165)
        Me.TxtGiro.Name = "TxtGiro"
        Me.TxtGiro.Size = New System.Drawing.Size(100, 20)
        Me.TxtGiro.TabIndex = 138
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(716, 113)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 137
        '
        'TxtJefe
        '
        Me.TxtJefe.Location = New System.Drawing.Point(716, 191)
        Me.TxtJefe.Name = "TxtJefe"
        Me.TxtJefe.Size = New System.Drawing.Size(100, 20)
        Me.TxtJefe.TabIndex = 142
        '
        'FrmFund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(564, 275)
        Me.Controls.Add(Me.TxtJefe)
        Me.Controls.Add(Me.TxtConfir)
        Me.Controls.Add(Me.TxtGiro)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.CboEmp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CboPrac)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtUbi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegrear)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmFund"
        Me.Text = "Control de Solicitud (Existente)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRegrear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtUbi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboPrac As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtConfir As System.Windows.Forms.TextBox
    Friend WithEvents TxtGiro As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtJefe As System.Windows.Forms.TextBox
End Class

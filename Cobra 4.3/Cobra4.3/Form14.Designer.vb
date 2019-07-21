<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFundamentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFundamentacion))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboProf = New System.Windows.Forms.ComboBox()
        Me.CboNomEmp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnRegrear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtUa = New System.Windows.Forms.TextBox()
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.TxtJefe = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Profesor solicitante"
        '
        'CboProf
        '
        Me.CboProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProf.FormattingEnabled = True
        Me.CboProf.Location = New System.Drawing.Point(189, 80)
        Me.CboProf.Name = "CboProf"
        Me.CboProf.Size = New System.Drawing.Size(245, 24)
        Me.CboProf.TabIndex = 117
        '
        'CboNomEmp
        '
        Me.CboNomEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNomEmp.FormattingEnabled = True
        Me.CboNomEmp.Location = New System.Drawing.Point(189, 35)
        Me.CboNomEmp.Name = "CboNomEmp"
        Me.CboNomEmp.Size = New System.Drawing.Size(245, 24)
        Me.CboNomEmp.TabIndex = 116
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Nombre de Empresa"
        '
        'BtnRegrear
        '
        Me.BtnRegrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegrear.Location = New System.Drawing.Point(54, 147)
        Me.BtnRegrear.Name = "BtnRegrear"
        Me.BtnRegrear.Size = New System.Drawing.Size(122, 51)
        Me.BtnRegrear.TabIndex = 120
        Me.BtnRegrear.Text = "Regresar"
        Me.BtnRegrear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(189, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 68)
        Me.Button1.TabIndex = 119
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtUa
        '
        Me.TxtUa.Location = New System.Drawing.Point(555, 60)
        Me.TxtUa.Name = "TxtUa"
        Me.TxtUa.Size = New System.Drawing.Size(100, 20)
        Me.TxtUa.TabIndex = 121
        '
        'TxtArea
        '
        Me.TxtArea.Location = New System.Drawing.Point(555, 86)
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.Size = New System.Drawing.Size(100, 20)
        Me.TxtArea.TabIndex = 123
        '
        'TxtJefe
        '
        Me.TxtJefe.Location = New System.Drawing.Point(555, 134)
        Me.TxtJefe.Name = "TxtJefe"
        Me.TxtJefe.Size = New System.Drawing.Size(100, 20)
        Me.TxtJefe.TabIndex = 124
        '
        'FrmFundamentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(463, 247)
        Me.Controls.Add(Me.TxtJefe)
        Me.Controls.Add(Me.TxtArea)
        Me.Controls.Add(Me.TxtUa)
        Me.Controls.Add(Me.BtnRegrear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CboProf)
        Me.Controls.Add(Me.CboNomEmp)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmFundamentacion"
        Me.Text = "Fundamentacion de Practica/Visita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboProf As System.Windows.Forms.ComboBox
    Friend WithEvents CboNomEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnRegrear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtUa As System.Windows.Forms.TextBox
    Friend WithEvents TxtArea As System.Windows.Forms.TextBox
    Friend WithEvents TxtJefe As System.Windows.Forms.TextBox
End Class

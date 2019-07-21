<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.BtnDirectivo = New System.Windows.Forms.Button()
        Me.BtnProfesor = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnConsulta
        '
        Me.BtnConsulta.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsulta.Location = New System.Drawing.Point(290, 215)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(252, 105)
        Me.BtnConsulta.TabIndex = 5
        Me.BtnConsulta.Text = "Consulta de Formatos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnConsulta.UseVisualStyleBackColor = False
        '
        'BtnDirectivo
        '
        Me.BtnDirectivo.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnDirectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDirectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDirectivo.Location = New System.Drawing.Point(470, 83)
        Me.BtnDirectivo.Name = "BtnDirectivo"
        Me.BtnDirectivo.Size = New System.Drawing.Size(252, 105)
        Me.BtnDirectivo.TabIndex = 4
        Me.BtnDirectivo.Text = "Registros del Directivo"
        Me.BtnDirectivo.UseVisualStyleBackColor = False
        '
        'BtnProfesor
        '
        Me.BtnProfesor.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProfesor.Location = New System.Drawing.Point(120, 83)
        Me.BtnProfesor.Name = "BtnProfesor"
        Me.BtnProfesor.Size = New System.Drawing.Size(252, 105)
        Me.BtnProfesor.TabIndex = 3
        Me.BtnProfesor.Text = "Registro de Profesor"
        Me.BtnProfesor.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(12, 339)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(122, 51)
        Me.BtnSalir.TabIndex = 52
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(843, 402)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnConsulta)
        Me.Controls.Add(Me.BtnDirectivo)
        Me.Controls.Add(Me.BtnProfesor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmInicio"
        Me.Text = "Inicio Cobra 4.3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents BtnDirectivo As System.Windows.Forms.Button
    Friend WithEvents BtnProfesor As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button

End Class

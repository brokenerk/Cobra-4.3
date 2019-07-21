<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentos))
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GboSelec = New System.Windows.Forms.GroupBox()
        Me.RdbControl = New System.Windows.Forms.RadioButton()
        Me.RdbAvisos = New System.Windows.Forms.RadioButton()
        Me.RdbMensual = New System.Windows.Forms.RadioButton()
        Me.RdbInforme = New System.Windows.Forms.RadioButton()
        Me.RdbNom = New System.Windows.Forms.RadioButton()
        Me.RdbFundamentacion = New System.Windows.Forms.RadioButton()
        Me.GboSelec.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(146, 301)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(88, 32)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(35, 301)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(92, 32)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'GboSelec
        '
        Me.GboSelec.Controls.Add(Me.RdbControl)
        Me.GboSelec.Controls.Add(Me.RdbAvisos)
        Me.GboSelec.Controls.Add(Me.RdbMensual)
        Me.GboSelec.Controls.Add(Me.RdbInforme)
        Me.GboSelec.Controls.Add(Me.RdbNom)
        Me.GboSelec.Controls.Add(Me.RdbFundamentacion)
        Me.GboSelec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GboSelec.Location = New System.Drawing.Point(12, 12)
        Me.GboSelec.Name = "GboSelec"
        Me.GboSelec.Size = New System.Drawing.Size(250, 268)
        Me.GboSelec.TabIndex = 3
        Me.GboSelec.TabStop = False
        Me.GboSelec.Text = "Seleccione Documento"
        '
        'RdbControl
        '
        Me.RdbControl.AutoSize = True
        Me.RdbControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbControl.Location = New System.Drawing.Point(23, 218)
        Me.RdbControl.Name = "RdbControl"
        Me.RdbControl.Size = New System.Drawing.Size(161, 20)
        Me.RdbControl.TabIndex = 6
        Me.RdbControl.TabStop = True
        Me.RdbControl.Text = "Control de Solicitud"
        Me.RdbControl.UseVisualStyleBackColor = True
        '
        'RdbAvisos
        '
        Me.RdbAvisos.AutoSize = True
        Me.RdbAvisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbAvisos.Location = New System.Drawing.Point(23, 184)
        Me.RdbAvisos.Name = "RdbAvisos"
        Me.RdbAvisos.Size = New System.Drawing.Size(183, 20)
        Me.RdbAvisos.TabIndex = 5
        Me.RdbAvisos.TabStop = True
        Me.RdbAvisos.Text = "Avisos y Seguimientos"
        Me.RdbAvisos.UseVisualStyleBackColor = True
        '
        'RdbMensual
        '
        Me.RdbMensual.AutoSize = True
        Me.RdbMensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMensual.Location = New System.Drawing.Point(23, 149)
        Me.RdbMensual.Name = "RdbMensual"
        Me.RdbMensual.Size = New System.Drawing.Size(139, 20)
        Me.RdbMensual.TabIndex = 4
        Me.RdbMensual.TabStop = True
        Me.RdbMensual.Text = "Informe Mensual"
        Me.RdbMensual.UseVisualStyleBackColor = True
        '
        'RdbInforme
        '
        Me.RdbInforme.AutoSize = True
        Me.RdbInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbInforme.Location = New System.Drawing.Point(23, 112)
        Me.RdbInforme.Name = "RdbInforme"
        Me.RdbInforme.Size = New System.Drawing.Size(159, 20)
        Me.RdbInforme.TabIndex = 3
        Me.RdbInforme.TabStop = True
        Me.RdbInforme.Text = "Informe Academico"
        Me.RdbInforme.UseVisualStyleBackColor = True
        '
        'RdbNom
        '
        Me.RdbNom.AutoSize = True
        Me.RdbNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbNom.Location = New System.Drawing.Point(23, 76)
        Me.RdbNom.Name = "RdbNom"
        Me.RdbNom.Size = New System.Drawing.Size(209, 20)
        Me.RdbNom.TabIndex = 1
        Me.RdbNom.TabStop = True
        Me.RdbNom.Text = "Coordinacion de Practicas"
        Me.RdbNom.UseVisualStyleBackColor = True
        '
        'RdbFundamentacion
        '
        Me.RdbFundamentacion.AutoSize = True
        Me.RdbFundamentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbFundamentacion.Location = New System.Drawing.Point(23, 38)
        Me.RdbFundamentacion.Name = "RdbFundamentacion"
        Me.RdbFundamentacion.Size = New System.Drawing.Size(140, 20)
        Me.RdbFundamentacion.TabIndex = 0
        Me.RdbFundamentacion.TabStop = True
        Me.RdbFundamentacion.Text = "Fundamentacion"
        Me.RdbFundamentacion.UseVisualStyleBackColor = True
        '
        'FrmDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(277, 358)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GboSelec)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmDocumentos"
        Me.Text = "Documentos"
        Me.GboSelec.ResumeLayout(False)
        Me.GboSelec.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents GboSelec As System.Windows.Forms.GroupBox
    Friend WithEvents RdbControl As System.Windows.Forms.RadioButton
    Friend WithEvents RdbAvisos As System.Windows.Forms.RadioButton
    Friend WithEvents RdbMensual As System.Windows.Forms.RadioButton
    Friend WithEvents RdbInforme As System.Windows.Forms.RadioButton
    Friend WithEvents RdbNom As System.Windows.Forms.RadioButton
    Friend WithEvents RdbFundamentacion As System.Windows.Forms.RadioButton
End Class

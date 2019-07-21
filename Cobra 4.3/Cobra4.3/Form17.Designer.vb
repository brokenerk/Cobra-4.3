<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGener
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGener))
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.CboGenDoc = New System.Windows.Forms.GroupBox()
        Me.RdoExist = New System.Windows.Forms.RadioButton()
        Me.RdoNuevo = New System.Windows.Forms.RadioButton()
        Me.CboGenDoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(124, 144)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(101, 43)
        Me.BtnAceptar.TabIndex = 63
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(17, 144)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(101, 43)
        Me.BtnCancelar.TabIndex = 62
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'CboGenDoc
        '
        Me.CboGenDoc.Controls.Add(Me.RdoExist)
        Me.CboGenDoc.Controls.Add(Me.RdoNuevo)
        Me.CboGenDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboGenDoc.Location = New System.Drawing.Point(34, 12)
        Me.CboGenDoc.Name = "CboGenDoc"
        Me.CboGenDoc.Size = New System.Drawing.Size(172, 115)
        Me.CboGenDoc.TabIndex = 61
        Me.CboGenDoc.TabStop = False
        Me.CboGenDoc.Text = "Generar Documento"
        '
        'RdoExist
        '
        Me.RdoExist.AutoSize = True
        Me.RdoExist.Location = New System.Drawing.Point(31, 69)
        Me.RdoExist.Name = "RdoExist"
        Me.RdoExist.Size = New System.Drawing.Size(89, 20)
        Me.RdoExist.TabIndex = 1
        Me.RdoExist.TabStop = True
        Me.RdoExist.Text = "Existente"
        Me.RdoExist.UseVisualStyleBackColor = True
        '
        'RdoNuevo
        '
        Me.RdoNuevo.AutoSize = True
        Me.RdoNuevo.Location = New System.Drawing.Point(31, 33)
        Me.RdoNuevo.Name = "RdoNuevo"
        Me.RdoNuevo.Size = New System.Drawing.Size(71, 20)
        Me.RdoNuevo.TabIndex = 0
        Me.RdoNuevo.TabStop = True
        Me.RdoNuevo.Text = "Nuevo"
        Me.RdoNuevo.UseVisualStyleBackColor = True
        '
        'FrmGener
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(255, 217)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.CboGenDoc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmGener"
        Me.CboGenDoc.ResumeLayout(False)
        Me.CboGenDoc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents CboGenDoc As System.Windows.Forms.GroupBox
    Friend WithEvents RdoExist As System.Windows.Forms.RadioButton
    Friend WithEvents RdoNuevo As System.Windows.Forms.RadioButton
End Class

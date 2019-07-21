<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.BtnLlenar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdoVisita = New System.Windows.Forms.RadioButton()
        Me.RdoDirectivo = New System.Windows.Forms.RadioButton()
        Me.RdoEmpresa = New System.Windows.Forms.RadioButton()
        Me.RdoAlumno = New System.Windows.Forms.RadioButton()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.VISITABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.VISITABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UPISCECYT8DataSet = New Cobra4._3.UPISCECYT8DataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VISITABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VISITADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VISITATableAdapter = New Cobra4._3.UPISCECYT8DataSetTableAdapters.VISITATableAdapter()
        Me.TableAdapterManager = New Cobra4._3.UPISCECYT8DataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VISITABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VISITABindingNavigator.SuspendLayout()
        CType(Me.VISITABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPISCECYT8DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISITADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLlenar
        '
        Me.BtnLlenar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLlenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLlenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLlenar.Location = New System.Drawing.Point(53, 219)
        Me.BtnLlenar.Name = "BtnLlenar"
        Me.BtnLlenar.Size = New System.Drawing.Size(244, 85)
        Me.BtnLlenar.TabIndex = 3
        Me.BtnLlenar.Text = "Llenar Formulario"
        Me.BtnLlenar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdoVisita)
        Me.GroupBox1.Controls.Add(Me.RdoDirectivo)
        Me.GroupBox1.Controls.Add(Me.RdoEmpresa)
        Me.GroupBox1.Controls.Add(Me.RdoAlumno)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 184)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'RdoVisita
        '
        Me.RdoVisita.AutoSize = True
        Me.RdoVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoVisita.Location = New System.Drawing.Point(19, 145)
        Me.RdoVisita.Name = "RdoVisita"
        Me.RdoVisita.Size = New System.Drawing.Size(199, 20)
        Me.RdoVisita.TabIndex = 3
        Me.RdoVisita.Text = "Registro de Nueva Visita"
        Me.RdoVisita.UseVisualStyleBackColor = True
        '
        'RdoDirectivo
        '
        Me.RdoDirectivo.AutoSize = True
        Me.RdoDirectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoDirectivo.Location = New System.Drawing.Point(19, 105)
        Me.RdoDirectivo.Name = "RdoDirectivo"
        Me.RdoDirectivo.Size = New System.Drawing.Size(173, 20)
        Me.RdoDirectivo.TabIndex = 2
        Me.RdoDirectivo.Text = "Registro de Directivo"
        Me.RdoDirectivo.UseVisualStyleBackColor = True
        '
        'RdoEmpresa
        '
        Me.RdoEmpresa.AutoSize = True
        Me.RdoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoEmpresa.Location = New System.Drawing.Point(19, 65)
        Me.RdoEmpresa.Name = "RdoEmpresa"
        Me.RdoEmpresa.Size = New System.Drawing.Size(173, 20)
        Me.RdoEmpresa.TabIndex = 1
        Me.RdoEmpresa.Text = "Registro de Empresa"
        Me.RdoEmpresa.UseVisualStyleBackColor = True
        '
        'RdoAlumno
        '
        Me.RdoAlumno.AutoSize = True
        Me.RdoAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoAlumno.Location = New System.Drawing.Point(19, 24)
        Me.RdoAlumno.Name = "RdoAlumno"
        Me.RdoAlumno.Size = New System.Drawing.Size(162, 20)
        Me.RdoAlumno.TabIndex = 0
        Me.RdoAlumno.Text = "Registro de Alumno"
        Me.RdoAlumno.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 334)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(122, 51)
        Me.BtnRegresar.TabIndex = 52
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'VISITABindingNavigator
        '
        Me.VISITABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VISITABindingNavigator.BindingSource = Me.VISITABindingSource
        Me.VISITABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VISITABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VISITABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VISITABindingNavigatorSaveItem})
        Me.VISITABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VISITABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VISITABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VISITABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VISITABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VISITABindingNavigator.Name = "VISITABindingNavigator"
        Me.VISITABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VISITABindingNavigator.Size = New System.Drawing.Size(339, 25)
        Me.VISITABindingNavigator.TabIndex = 53
        Me.VISITABindingNavigator.Text = "BindingNavigator1"
        Me.VISITABindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'VISITABindingSource
        '
        Me.VISITABindingSource.DataMember = "VISITA"
        Me.VISITABindingSource.DataSource = Me.UPISCECYT8DataSet
        '
        'UPISCECYT8DataSet
        '
        Me.UPISCECYT8DataSet.DataSetName = "UPISCECYT8DataSet"
        Me.UPISCECYT8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'VISITABindingNavigatorSaveItem
        '
        Me.VISITABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VISITABindingNavigatorSaveItem.Image = CType(resources.GetObject("VISITABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VISITABindingNavigatorSaveItem.Name = "VISITABindingNavigatorSaveItem"
        Me.VISITABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VISITABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'VISITADataGridView
        '
        Me.VISITADataGridView.AutoGenerateColumns = False
        Me.VISITADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VISITADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.VISITADataGridView.DataSource = Me.VISITABindingSource
        Me.VISITADataGridView.Location = New System.Drawing.Point(589, 360)
        Me.VISITADataGridView.Name = "VISITADataGridView"
        Me.VISITADataGridView.Size = New System.Drawing.Size(15, 29)
        Me.VISITADataGridView.TabIndex = 53
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "No Practica"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No Practica"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Costo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RAP"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RAP"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Competencia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Competencia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Programa Academico"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Programa Academico"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Asistentes"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Asistentes"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Confirmacion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Confirmacion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'VISITATableAdapter
        '
        Me.VISITATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUMNOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DIRECTIVOTableAdapter = Nothing
        Me.TableAdapterManager.EMPRESATableAdapter = Nothing
        Me.TableAdapterManager.PROFESORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Cobra4._3.UPISCECYT8DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VISITATableAdapter = Me.VISITATableAdapter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(185, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 51)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Aviso al Profesor"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(352, 397)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VISITADataGridView)
        Me.Controls.Add(Me.VISITABindingNavigator)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnLlenar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMenu"
        Me.Text = "Menu de Directivo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VISITABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VISITABindingNavigator.ResumeLayout(False)
        Me.VISITABindingNavigator.PerformLayout()
        CType(Me.VISITABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPISCECYT8DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISITADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLlenar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoVisita As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDirectivo As System.Windows.Forms.RadioButton
    Friend WithEvents RdoEmpresa As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAlumno As System.Windows.Forms.RadioButton
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents UPISCECYT8DataSet As Cobra4._3.UPISCECYT8DataSet
    Friend WithEvents VISITABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VISITATableAdapter As Cobra4._3.UPISCECYT8DataSetTableAdapters.VISITATableAdapter
    Friend WithEvents TableAdapterManager As Cobra4._3.UPISCECYT8DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VISITABindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VISITABindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VISITADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

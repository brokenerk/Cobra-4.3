<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresa))
        Me.TxtEmailEmpresa = New System.Windows.Forms.TextBox()
        Me.LblEmailEmpresa = New System.Windows.Forms.Label()
        Me.TxtDireccionEmpresa = New System.Windows.Forms.TextBox()
        Me.TxtGiroEmpresa = New System.Windows.Forms.TextBox()
        Me.TxtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.TxtTelefonoEmpresa = New System.Windows.Forms.TextBox()
        Me.LblGiroEmpresa = New System.Windows.Forms.Label()
        Me.LblDireccionEmpresa = New System.Windows.Forms.Label()
        Me.LblNombreEmpresa = New System.Windows.Forms.Label()
        Me.LblTelefonoEmpresa = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.EMPRESABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.EMPRESABindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.EMPRESABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EMPRESADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPRESATableAdapter = New Cobra4._3.UPISCECYT8DataSetTableAdapters.EMPRESATableAdapter()
        Me.TableAdapterManager = New Cobra4._3.UPISCECYT8DataSetTableAdapters.TableAdapterManager()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.EMPRESABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EMPRESABindingNavigator.SuspendLayout()
        CType(Me.EMPRESABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPISCECYT8DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtEmailEmpresa
        '
        Me.TxtEmailEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmailEmpresa.Location = New System.Drawing.Point(598, 316)
        Me.TxtEmailEmpresa.Name = "TxtEmailEmpresa"
        Me.TxtEmailEmpresa.Size = New System.Drawing.Size(204, 22)
        Me.TxtEmailEmpresa.TabIndex = 61
        '
        'LblEmailEmpresa
        '
        Me.LblEmailEmpresa.AutoSize = True
        Me.LblEmailEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailEmpresa.Location = New System.Drawing.Point(537, 319)
        Me.LblEmailEmpresa.Name = "LblEmailEmpresa"
        Me.LblEmailEmpresa.Size = New System.Drawing.Size(47, 16)
        Me.LblEmailEmpresa.TabIndex = 60
        Me.LblEmailEmpresa.Text = "Email"
        '
        'TxtDireccionEmpresa
        '
        Me.TxtDireccionEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccionEmpresa.Location = New System.Drawing.Point(208, 360)
        Me.TxtDireccionEmpresa.Name = "TxtDireccionEmpresa"
        Me.TxtDireccionEmpresa.Size = New System.Drawing.Size(204, 22)
        Me.TxtDireccionEmpresa.TabIndex = 59
        '
        'TxtGiroEmpresa
        '
        Me.TxtGiroEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGiroEmpresa.Location = New System.Drawing.Point(598, 271)
        Me.TxtGiroEmpresa.Name = "TxtGiroEmpresa"
        Me.TxtGiroEmpresa.Size = New System.Drawing.Size(204, 22)
        Me.TxtGiroEmpresa.TabIndex = 58
        '
        'TxtNombreEmpresa
        '
        Me.TxtNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreEmpresa.Location = New System.Drawing.Point(208, 271)
        Me.TxtNombreEmpresa.Name = "TxtNombreEmpresa"
        Me.TxtNombreEmpresa.Size = New System.Drawing.Size(309, 22)
        Me.TxtNombreEmpresa.TabIndex = 57
        '
        'TxtTelefonoEmpresa
        '
        Me.TxtTelefonoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefonoEmpresa.Location = New System.Drawing.Point(208, 316)
        Me.TxtTelefonoEmpresa.Name = "TxtTelefonoEmpresa"
        Me.TxtTelefonoEmpresa.Size = New System.Drawing.Size(185, 22)
        Me.TxtTelefonoEmpresa.TabIndex = 56
        '
        'LblGiroEmpresa
        '
        Me.LblGiroEmpresa.AutoSize = True
        Me.LblGiroEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGiroEmpresa.Location = New System.Drawing.Point(537, 274)
        Me.LblGiroEmpresa.Name = "LblGiroEmpresa"
        Me.LblGiroEmpresa.Size = New System.Drawing.Size(37, 16)
        Me.LblGiroEmpresa.TabIndex = 55
        Me.LblGiroEmpresa.Text = "Giro"
        '
        'LblDireccionEmpresa
        '
        Me.LblDireccionEmpresa.AutoSize = True
        Me.LblDireccionEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccionEmpresa.Location = New System.Drawing.Point(15, 363)
        Me.LblDireccionEmpresa.Name = "LblDireccionEmpresa"
        Me.LblDireccionEmpresa.Size = New System.Drawing.Size(74, 16)
        Me.LblDireccionEmpresa.TabIndex = 54
        Me.LblDireccionEmpresa.Text = "Dirección"
        '
        'LblNombreEmpresa
        '
        Me.LblNombreEmpresa.AutoSize = True
        Me.LblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreEmpresa.Location = New System.Drawing.Point(15, 274)
        Me.LblNombreEmpresa.Name = "LblNombreEmpresa"
        Me.LblNombreEmpresa.Size = New System.Drawing.Size(168, 16)
        Me.LblNombreEmpresa.TabIndex = 53
        Me.LblNombreEmpresa.Text = "Nombre de la Empresa"
        '
        'LblTelefonoEmpresa
        '
        Me.LblTelefonoEmpresa.AutoSize = True
        Me.LblTelefonoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefonoEmpresa.Location = New System.Drawing.Point(15, 319)
        Me.LblTelefonoEmpresa.Name = "LblTelefonoEmpresa"
        Me.LblTelefonoEmpresa.Size = New System.Drawing.Size(175, 16)
        Me.LblTelefonoEmpresa.TabIndex = 52
        Me.LblTelefonoEmpresa.Text = "Telefono de la Empresa"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 419)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(122, 51)
        Me.BtnRegresar.TabIndex = 64
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(420, 419)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(138, 51)
        Me.BtnPrev.TabIndex = 87
        Me.BtnPrev.Text = "Insertar"
        Me.BtnPrev.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(573, 419)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(138, 51)
        Me.BtnEditar.TabIndex = 86
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(727, 419)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(138, 51)
        Me.BtnBorrar.TabIndex = 85
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'EMPRESABindingNavigator
        '
        Me.EMPRESABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EMPRESABindingNavigator.BindingSource = Me.EMPRESABindingSource
        Me.EMPRESABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EMPRESABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EMPRESABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EMPRESABindingNavigatorSaveItem})
        Me.EMPRESABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EMPRESABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EMPRESABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EMPRESABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EMPRESABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EMPRESABindingNavigator.Name = "EMPRESABindingNavigator"
        Me.EMPRESABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EMPRESABindingNavigator.Size = New System.Drawing.Size(973, 25)
        Me.EMPRESABindingNavigator.TabIndex = 88
        Me.EMPRESABindingNavigator.Text = "BindingNavigator1"
        Me.EMPRESABindingNavigator.Visible = False
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
        'EMPRESABindingSource
        '
        Me.EMPRESABindingSource.DataMember = "EMPRESA"
        Me.EMPRESABindingSource.DataSource = Me.UPISCECYT8DataSet
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
        'EMPRESABindingNavigatorSaveItem
        '
        Me.EMPRESABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EMPRESABindingNavigatorSaveItem.Image = CType(resources.GetObject("EMPRESABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EMPRESABindingNavigatorSaveItem.Name = "EMPRESABindingNavigatorSaveItem"
        Me.EMPRESABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EMPRESABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EMPRESADataGridView
        '
        Me.EMPRESADataGridView.AutoGenerateColumns = False
        Me.EMPRESADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMPRESADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.EMPRESADataGridView.DataSource = Me.EMPRESABindingSource
        Me.EMPRESADataGridView.Location = New System.Drawing.Point(12, 23)
        Me.EMPRESADataGridView.Name = "EMPRESADataGridView"
        Me.EMPRESADataGridView.Size = New System.Drawing.Size(858, 220)
        Me.EMPRESADataGridView.TabIndex = 88
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre Empresa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre Empresa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Telefono Empresa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Telefono Empresa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Giro"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Giro"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email Empresa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email Empresa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'EMPRESATableAdapter
        '
        Me.EMPRESATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUMNOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DIRECTIVOTableAdapter = Nothing
        Me.TableAdapterManager.EMPRESATableAdapter = Me.EMPRESATableAdapter
        Me.TableAdapterManager.PROFESORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Cobra4._3.UPISCECYT8DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VISITATableAdapter = Nothing
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(140, 419)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(138, 51)
        Me.BtnLimpiar.TabIndex = 90
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'FrmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(877, 485)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.EMPRESADataGridView)
        Me.Controls.Add(Me.EMPRESABindingNavigator)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.TxtEmailEmpresa)
        Me.Controls.Add(Me.LblEmailEmpresa)
        Me.Controls.Add(Me.TxtDireccionEmpresa)
        Me.Controls.Add(Me.TxtGiroEmpresa)
        Me.Controls.Add(Me.TxtNombreEmpresa)
        Me.Controls.Add(Me.TxtTelefonoEmpresa)
        Me.Controls.Add(Me.LblGiroEmpresa)
        Me.Controls.Add(Me.LblDireccionEmpresa)
        Me.Controls.Add(Me.LblNombreEmpresa)
        Me.Controls.Add(Me.LblTelefonoEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmEmpresa"
        Me.Text = "Registro de Empresa"
        CType(Me.EMPRESABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EMPRESABindingNavigator.ResumeLayout(False)
        Me.EMPRESABindingNavigator.PerformLayout()
        CType(Me.EMPRESABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPISCECYT8DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtEmailEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents LblEmailEmpresa As System.Windows.Forms.Label
    Friend WithEvents TxtDireccionEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TxtGiroEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefonoEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents LblGiroEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblDireccionEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblNombreEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblTelefonoEmpresa As System.Windows.Forms.Label
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents UPISCECYT8DataSet As Cobra4._3.UPISCECYT8DataSet
    Friend WithEvents EMPRESABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESATableAdapter As Cobra4._3.UPISCECYT8DataSetTableAdapters.EMPRESATableAdapter
    Friend WithEvents TableAdapterManager As Cobra4._3.UPISCECYT8DataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMPRESABindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EMPRESABindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EMPRESADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
End Class

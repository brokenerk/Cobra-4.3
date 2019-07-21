<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisita))
        Me.TxtProgramaAcademico = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.TxtAsistentes = New System.Windows.Forms.TextBox()
        Me.TxtCompetencia = New System.Windows.Forms.TextBox()
        Me.TxtNoPractica = New System.Windows.Forms.TextBox()
        Me.LblGiroEmpresa = New System.Windows.Forms.Label()
        Me.LblDireccionEmpresa = New System.Windows.Forms.Label()
        Me.LblNombreEmpresa = New System.Windows.Forms.Label()
        Me.LblTelefonoEmpresa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRAP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboConfirmacion = New System.Windows.Forms.ComboBox()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
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
        CType(Me.VISITABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VISITABindingNavigator.SuspendLayout()
        CType(Me.VISITABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPISCECYT8DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISITADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtProgramaAcademico
        '
        Me.TxtProgramaAcademico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProgramaAcademico.Location = New System.Drawing.Point(792, 368)
        Me.TxtProgramaAcademico.Name = "TxtProgramaAcademico"
        Me.TxtProgramaAcademico.Size = New System.Drawing.Size(204, 22)
        Me.TxtProgramaAcademico.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(544, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 16)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Programa Academico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtFecha
        '
        Me.TxtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha.Location = New System.Drawing.Point(792, 320)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(204, 22)
        Me.TxtFecha.TabIndex = 73
        '
        'TxtCosto
        '
        Me.TxtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCosto.Location = New System.Drawing.Point(189, 319)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(204, 22)
        Me.TxtCosto.TabIndex = 71
        '
        'TxtAsistentes
        '
        Me.TxtAsistentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAsistentes.Location = New System.Drawing.Point(792, 276)
        Me.TxtAsistentes.Name = "TxtAsistentes"
        Me.TxtAsistentes.Size = New System.Drawing.Size(92, 22)
        Me.TxtAsistentes.TabIndex = 70
        '
        'TxtCompetencia
        '
        Me.TxtCompetencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompetencia.Location = New System.Drawing.Point(189, 404)
        Me.TxtCompetencia.Name = "TxtCompetencia"
        Me.TxtCompetencia.Size = New System.Drawing.Size(309, 22)
        Me.TxtCompetencia.TabIndex = 69
        '
        'TxtNoPractica
        '
        Me.TxtNoPractica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoPractica.Location = New System.Drawing.Point(190, 279)
        Me.TxtNoPractica.Name = "TxtNoPractica"
        Me.TxtNoPractica.Size = New System.Drawing.Size(92, 22)
        Me.TxtNoPractica.TabIndex = 68
        '
        'LblGiroEmpresa
        '
        Me.LblGiroEmpresa.AutoSize = True
        Me.LblGiroEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGiroEmpresa.Location = New System.Drawing.Point(544, 282)
        Me.LblGiroEmpresa.Name = "LblGiroEmpresa"
        Me.LblGiroEmpresa.Size = New System.Drawing.Size(80, 16)
        Me.LblGiroEmpresa.TabIndex = 67
        Me.LblGiroEmpresa.Text = "Asistentes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblDireccionEmpresa
        '
        Me.LblDireccionEmpresa.AutoSize = True
        Me.LblDireccionEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccionEmpresa.Location = New System.Drawing.Point(33, 322)
        Me.LblDireccionEmpresa.Name = "LblDireccionEmpresa"
        Me.LblDireccionEmpresa.Size = New System.Drawing.Size(48, 16)
        Me.LblDireccionEmpresa.TabIndex = 66
        Me.LblDireccionEmpresa.Text = "Costo"
        '
        'LblNombreEmpresa
        '
        Me.LblNombreEmpresa.AutoSize = True
        Me.LblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreEmpresa.Location = New System.Drawing.Point(33, 407)
        Me.LblNombreEmpresa.Name = "LblNombreEmpresa"
        Me.LblNombreEmpresa.Size = New System.Drawing.Size(99, 16)
        Me.LblNombreEmpresa.TabIndex = 65
        Me.LblNombreEmpresa.Text = "Competencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblTelefonoEmpresa
        '
        Me.LblTelefonoEmpresa.AutoSize = True
        Me.LblTelefonoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefonoEmpresa.Location = New System.Drawing.Point(33, 282)
        Me.LblTelefonoEmpresa.Name = "LblTelefonoEmpresa"
        Me.LblTelefonoEmpresa.Size = New System.Drawing.Size(145, 16)
        Me.LblTelefonoEmpresa.TabIndex = 64
        Me.LblTelefonoEmpresa.Text = "Numero de Practica" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(544, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Confirmacion"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 463)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(122, 51)
        Me.BtnRegresar.TabIndex = 78
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(544, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Fecha de Visita (dd/mm/AAAA)"
        '
        'TxtRAP
        '
        Me.TxtRAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRAP.Location = New System.Drawing.Point(189, 359)
        Me.TxtRAP.Name = "TxtRAP"
        Me.TxtRAP.Size = New System.Drawing.Size(93, 22)
        Me.TxtRAP.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "RAP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CboConfirmacion
        '
        Me.CboConfirmacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboConfirmacion.FormattingEnabled = True
        Me.CboConfirmacion.Items.AddRange(New Object() {"Si", "No"})
        Me.CboConfirmacion.Location = New System.Drawing.Point(792, 404)
        Me.CboConfirmacion.Name = "CboConfirmacion"
        Me.CboConfirmacion.Size = New System.Drawing.Size(101, 24)
        Me.CboConfirmacion.TabIndex = 83
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(559, 463)
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
        Me.BtnEditar.Location = New System.Drawing.Point(712, 463)
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
        Me.BtnBorrar.Location = New System.Drawing.Point(874, 463)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(138, 51)
        Me.BtnBorrar.TabIndex = 85
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = False
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
        Me.VISITABindingNavigator.Size = New System.Drawing.Size(1028, 25)
        Me.VISITABindingNavigator.TabIndex = 88
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
        Me.VISITADataGridView.Location = New System.Drawing.Point(21, 12)
        Me.VISITADataGridView.Name = "VISITADataGridView"
        Me.VISITADataGridView.Size = New System.Drawing.Size(991, 236)
        Me.VISITADataGridView.TabIndex = 88
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
        Me.Button1.Location = New System.Drawing.Point(144, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 51)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1028, 535)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VISITADataGridView)
        Me.Controls.Add(Me.VISITABindingNavigator)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.CboConfirmacion)
        Me.Controls.Add(Me.TxtRAP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtProgramaAcademico)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.TxtAsistentes)
        Me.Controls.Add(Me.TxtCompetencia)
        Me.Controls.Add(Me.TxtNoPractica)
        Me.Controls.Add(Me.LblGiroEmpresa)
        Me.Controls.Add(Me.LblDireccionEmpresa)
        Me.Controls.Add(Me.LblNombreEmpresa)
        Me.Controls.Add(Me.LblTelefonoEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVisita"
        Me.Text = "Registro de Visita"
        CType(Me.VISITABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VISITABindingNavigator.ResumeLayout(False)
        Me.VISITABindingNavigator.PerformLayout()
        CType(Me.VISITABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPISCECYT8DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISITADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtProgramaAcademico As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtCosto As System.Windows.Forms.TextBox
    Friend WithEvents TxtAsistentes As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoPractica As System.Windows.Forms.TextBox
    Friend WithEvents LblGiroEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblDireccionEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblNombreEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblTelefonoEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtRAP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboConfirmacion As System.Windows.Forms.ComboBox
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
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

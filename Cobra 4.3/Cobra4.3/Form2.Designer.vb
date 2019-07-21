<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProfesor))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.CboCarrera = New System.Windows.Forms.ComboBox()
        Me.CboArea = New System.Windows.Forms.ComboBox()
        Me.TxtJefeArea = New System.Windows.Forms.TextBox()
        Me.TxtAcademia = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtUnidaAprendizaje = New System.Windows.Forms.TextBox()
        Me.TxtNombreProfesor = New System.Windows.Forms.TextBox()
        Me.TxtTelefonoProfesor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTelefonoProfesor = New System.Windows.Forms.Label()
        Me.PROFESORBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PROFESORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PROFESORBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PROFESORDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtClaveProfesor = New System.Windows.Forms.TextBox()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.PROFESORTableAdapter = New Cobra4._3.UPISCECYT8DataSetTableAdapters.PROFESORTableAdapter()
        Me.TableAdapterManager = New Cobra4._3.UPISCECYT8DataSetTableAdapters.TableAdapterManager()
        Me.CboTurno = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CboSemestre = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PROFESORBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PROFESORBindingNavigator.SuspendLayout()
        CType(Me.PROFESORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPISCECYT8DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFESORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 506)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(122, 51)
        Me.BtnRegresar.TabIndex = 51
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'CboCarrera
        '
        Me.CboCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCarrera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CboCarrera.FormattingEnabled = True
        Me.CboCarrera.Items.AddRange(New Object() {"Tronco Común", "Computación", "Plásticos", "Sistemas Automotrices", "Mantenimiento Industrial"})
        Me.CboCarrera.Location = New System.Drawing.Point(646, 331)
        Me.CboCarrera.Name = "CboCarrera"
        Me.CboCarrera.Size = New System.Drawing.Size(147, 24)
        Me.CboCarrera.TabIndex = 49
        '
        'CboArea
        '
        Me.CboArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CboArea.FormattingEnabled = True
        Me.CboArea.Items.AddRange(New Object() {"Básicas", "Tecnológicas", "Humanísticas"})
        Me.CboArea.Location = New System.Drawing.Point(203, 331)
        Me.CboArea.Name = "CboArea"
        Me.CboArea.Size = New System.Drawing.Size(106, 24)
        Me.CboArea.TabIndex = 48
        '
        'TxtJefeArea
        '
        Me.TxtJefeArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJefeArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtJefeArea.Location = New System.Drawing.Point(646, 370)
        Me.TxtJefeArea.Name = "TxtJefeArea"
        Me.TxtJefeArea.Size = New System.Drawing.Size(309, 22)
        Me.TxtJefeArea.TabIndex = 47
        '
        'TxtAcademia
        '
        Me.TxtAcademia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcademia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtAcademia.Location = New System.Drawing.Point(203, 446)
        Me.TxtAcademia.Name = "TxtAcademia"
        Me.TxtAcademia.Size = New System.Drawing.Size(204, 22)
        Me.TxtAcademia.TabIndex = 44
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtEmail.Location = New System.Drawing.Point(203, 406)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(204, 22)
        Me.TxtEmail.TabIndex = 43
        '
        'TxtUnidaAprendizaje
        '
        Me.TxtUnidaAprendizaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnidaAprendizaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtUnidaAprendizaje.Location = New System.Drawing.Point(203, 373)
        Me.TxtUnidaAprendizaje.Name = "TxtUnidaAprendizaje"
        Me.TxtUnidaAprendizaje.Size = New System.Drawing.Size(204, 22)
        Me.TxtUnidaAprendizaje.TabIndex = 42
        '
        'TxtNombreProfesor
        '
        Me.TxtNombreProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreProfesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNombreProfesor.Location = New System.Drawing.Point(203, 292)
        Me.TxtNombreProfesor.Name = "TxtNombreProfesor"
        Me.TxtNombreProfesor.Size = New System.Drawing.Size(309, 22)
        Me.TxtNombreProfesor.TabIndex = 41
        '
        'TxtTelefonoProfesor
        '
        Me.TxtTelefonoProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefonoProfesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTelefonoProfesor.Location = New System.Drawing.Point(646, 412)
        Me.TxtTelefonoProfesor.Name = "TxtTelefonoProfesor"
        Me.TxtTelefonoProfesor.Size = New System.Drawing.Size(185, 22)
        Me.TxtTelefonoProfesor.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(543, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Jefe de Area"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(543, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Carrera"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(543, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Turno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(27, 446)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Academia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(27, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "E-mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(27, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Unidad de Aprendizaje"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(27, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Area "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(27, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombre Completo"
        '
        'LblTelefonoProfesor
        '
        Me.LblTelefonoProfesor.AutoSize = True
        Me.LblTelefonoProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefonoProfesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTelefonoProfesor.Location = New System.Drawing.Point(543, 415)
        Me.LblTelefonoProfesor.Name = "LblTelefonoProfesor"
        Me.LblTelefonoProfesor.Size = New System.Drawing.Size(70, 16)
        Me.LblTelefonoProfesor.TabIndex = 29
        Me.LblTelefonoProfesor.Text = "Telefono"
        '
        'PROFESORBindingNavigator
        '
        Me.PROFESORBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PROFESORBindingNavigator.BindingSource = Me.PROFESORBindingSource
        Me.PROFESORBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PROFESORBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PROFESORBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PROFESORBindingNavigatorSaveItem})
        Me.PROFESORBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PROFESORBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PROFESORBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PROFESORBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PROFESORBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PROFESORBindingNavigator.Name = "PROFESORBindingNavigator"
        Me.PROFESORBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PROFESORBindingNavigator.Size = New System.Drawing.Size(993, 25)
        Me.PROFESORBindingNavigator.TabIndex = 54
        Me.PROFESORBindingNavigator.Text = "BindingNavigator1"
        Me.PROFESORBindingNavigator.Visible = False
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
        'PROFESORBindingSource
        '
        Me.PROFESORBindingSource.DataMember = "PROFESOR"
        Me.PROFESORBindingSource.DataSource = Me.UPISCECYT8DataSet
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
        'PROFESORBindingNavigatorSaveItem
        '
        Me.PROFESORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PROFESORBindingNavigatorSaveItem.Image = CType(resources.GetObject("PROFESORBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PROFESORBindingNavigatorSaveItem.Name = "PROFESORBindingNavigatorSaveItem"
        Me.PROFESORBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PROFESORBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PROFESORDataGridView
        '
        Me.PROFESORDataGridView.AutoGenerateColumns = False
        Me.PROFESORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PROFESORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.PROFESORDataGridView.DataSource = Me.PROFESORBindingSource
        Me.PROFESORDataGridView.Location = New System.Drawing.Point(12, 23)
        Me.PROFESORDataGridView.Name = "PROFESORDataGridView"
        Me.PROFESORDataGridView.Size = New System.Drawing.Size(1014, 204)
        Me.PROFESORDataGridView.TabIndex = 54
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Clave Profesor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Clave Profesor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre Profesor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Profesor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telefono Profesor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telefono Profesor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Area Profesor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Area Profesor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Unidad de Aprendizaje"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unidad de Aprendizaje"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email Profesor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email Profesor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Academia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Academia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Turno"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Turno"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Carrera"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Carrera"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Semestre"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Semestre"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Jefe de area"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Jefe de area"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(27, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 16)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Clave del Profesor"
        '
        'TxtClaveProfesor
        '
        Me.TxtClaveProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClaveProfesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtClaveProfesor.Location = New System.Drawing.Point(203, 246)
        Me.TxtClaveProfesor.Name = "TxtClaveProfesor"
        Me.TxtClaveProfesor.Size = New System.Drawing.Size(131, 22)
        Me.TxtClaveProfesor.TabIndex = 53
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(484, 506)
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
        Me.BtnEditar.Location = New System.Drawing.Point(631, 506)
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
        Me.BtnBorrar.Location = New System.Drawing.Point(775, 506)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(138, 51)
        Me.BtnBorrar.TabIndex = 85
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'PROFESORTableAdapter
        '
        Me.PROFESORTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUMNOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DIRECTIVOTableAdapter = Nothing
        Me.TableAdapterManager.EMPRESATableAdapter = Nothing
        Me.TableAdapterManager.PROFESORTableAdapter = Me.PROFESORTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cobra4._3.UPISCECYT8DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VISITATableAdapter = Nothing
        '
        'CboTurno
        '
        Me.CboTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTurno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CboTurno.FormattingEnabled = True
        Me.CboTurno.Items.AddRange(New Object() {"Matutino" & Global.Microsoft.VisualBasic.ChrW(9), "Vespertino" & Global.Microsoft.VisualBasic.ChrW(9), "Mixto"})
        Me.CboTurno.Location = New System.Drawing.Point(646, 249)
        Me.CboTurno.Name = "CboTurno"
        Me.CboTurno.Size = New System.Drawing.Size(121, 24)
        Me.CboTurno.TabIndex = 88
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(148, 506)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 51)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CboSemestre
        '
        Me.CboSemestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSemestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CboSemestre.FormattingEnabled = True
        Me.CboSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.CboSemestre.Location = New System.Drawing.Point(646, 295)
        Me.CboSemestre.Name = "CboSemestre"
        Me.CboSemestre.Size = New System.Drawing.Size(147, 24)
        Me.CboSemestre.TabIndex = 90
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(541, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Semestre"
        '
        'FrmProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1028, 582)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CboSemestre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CboTurno)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.PROFESORDataGridView)
        Me.Controls.Add(Me.PROFESORBindingNavigator)
        Me.Controls.Add(Me.TxtClaveProfesor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.CboCarrera)
        Me.Controls.Add(Me.CboArea)
        Me.Controls.Add(Me.TxtJefeArea)
        Me.Controls.Add(Me.TxtAcademia)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtUnidaAprendizaje)
        Me.Controls.Add(Me.TxtNombreProfesor)
        Me.Controls.Add(Me.TxtTelefonoProfesor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTelefonoProfesor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmProfesor"
        Me.Text = "Registro de Profesor"
        CType(Me.PROFESORBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PROFESORBindingNavigator.ResumeLayout(False)
        Me.PROFESORBindingNavigator.PerformLayout()
        CType(Me.PROFESORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPISCECYT8DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFESORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents CboCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents CboArea As System.Windows.Forms.ComboBox
    Friend WithEvents TxtJefeArea As System.Windows.Forms.TextBox
    Friend WithEvents TxtAcademia As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtUnidaAprendizaje As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreProfesor As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefonoProfesor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblTelefonoProfesor As System.Windows.Forms.Label
    Friend WithEvents UPISCECYT8DataSet As Cobra4._3.UPISCECYT8DataSet
    Friend WithEvents PROFESORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROFESORTableAdapter As Cobra4._3.UPISCECYT8DataSetTableAdapters.PROFESORTableAdapter
    Friend WithEvents TableAdapterManager As Cobra4._3.UPISCECYT8DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PROFESORBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PROFESORBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PROFESORDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtClaveProfesor As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents CboTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CboSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class

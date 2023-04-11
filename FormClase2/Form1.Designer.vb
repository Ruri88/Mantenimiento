<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblCarnet = New System.Windows.Forms.Label()
        Me.txtCarnet = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblGrado = New System.Windows.Forms.Label()
        Me.txtGrado = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.ALUMNOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ALUMNOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ALUMNOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALUMNOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTROLDataSet = New Mantenimiento.CONTROLDataSet()
        Me.ALUMNOSTableAdapter = New Mantenimiento.CONTROLDataSetTableAdapters.ALUMNOSTableAdapter()
        Me.TableAdapterManager = New Mantenimiento.CONTROLDataSetTableAdapters.TableAdapterManager()
        CType(Me.ALUMNOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALUMNOSBindingNavigator.SuspendLayout()
        CType(Me.ALUMNOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUMNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTROLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCarnet
        '
        Me.lblCarnet.AutoSize = True
        Me.lblCarnet.Location = New System.Drawing.Point(30, 43)
        Me.lblCarnet.Name = "lblCarnet"
        Me.lblCarnet.Size = New System.Drawing.Size(38, 13)
        Me.lblCarnet.TabIndex = 0
        Me.lblCarnet.Text = "Carnet"
        '
        'txtCarnet
        '
        Me.txtCarnet.Location = New System.Drawing.Point(84, 36)
        Me.txtCarnet.Name = "txtCarnet"
        Me.txtCarnet.Size = New System.Drawing.Size(100, 20)
        Me.txtCarnet.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(30, 79)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(84, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(30, 117)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(84, 110)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 5
        '
        'lblGrado
        '
        Me.lblGrado.AutoSize = True
        Me.lblGrado.Location = New System.Drawing.Point(30, 154)
        Me.lblGrado.Name = "lblGrado"
        Me.lblGrado.Size = New System.Drawing.Size(36, 13)
        Me.lblGrado.TabIndex = 6
        Me.lblGrado.Text = "Grado"
        '
        'txtGrado
        '
        Me.txtGrado.Location = New System.Drawing.Point(84, 147)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Size = New System.Drawing.Size(100, 20)
        Me.txtGrado.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(33, 225)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(253, 225)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 9
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(347, 225)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(440, 225)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'ALUMNOSBindingNavigator
        '
        Me.ALUMNOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ALUMNOSBindingNavigator.BindingSource = Me.ALUMNOSBindingSource
        Me.ALUMNOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ALUMNOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ALUMNOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ALUMNOSBindingNavigatorSaveItem})
        Me.ALUMNOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ALUMNOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ALUMNOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ALUMNOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ALUMNOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ALUMNOSBindingNavigator.Name = "ALUMNOSBindingNavigator"
        Me.ALUMNOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ALUMNOSBindingNavigator.Size = New System.Drawing.Size(806, 25)
        Me.ALUMNOSBindingNavigator.TabIndex = 12
        Me.ALUMNOSBindingNavigator.Text = "BindingNavigator1"
        Me.ALUMNOSBindingNavigator.Visible = False
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ALUMNOSBindingNavigatorSaveItem
        '
        Me.ALUMNOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ALUMNOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("ALUMNOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ALUMNOSBindingNavigatorSaveItem.Name = "ALUMNOSBindingNavigatorSaveItem"
        Me.ALUMNOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ALUMNOSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ALUMNOSDataGridView
        '
        Me.ALUMNOSDataGridView.AutoGenerateColumns = False
        Me.ALUMNOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ALUMNOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ALUMNOSDataGridView.DataSource = Me.ALUMNOSBindingSource
        Me.ALUMNOSDataGridView.Location = New System.Drawing.Point(253, 36)
        Me.ALUMNOSDataGridView.Name = "ALUMNOSDataGridView"
        Me.ALUMNOSDataGridView.Size = New System.Drawing.Size(448, 164)
        Me.ALUMNOSDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "carnet"
        Me.DataGridViewTextBoxColumn1.HeaderText = "carnet"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "grado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "grado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ALUMNOSBindingSource
        '
        Me.ALUMNOSBindingSource.DataMember = "ALUMNOS"
        Me.ALUMNOSBindingSource.DataSource = Me.CONTROLDataSet
        '
        'CONTROLDataSet
        '
        Me.CONTROLDataSet.DataSetName = "CONTROLDataSet"
        Me.CONTROLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALUMNOSTableAdapter
        '
        Me.ALUMNOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUMNOSTableAdapter = Me.ALUMNOSTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Mantenimiento.CONTROLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(806, 438)
        Me.Controls.Add(Me.ALUMNOSDataGridView)
        Me.Controls.Add(Me.ALUMNOSBindingNavigator)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtGrado)
        Me.Controls.Add(Me.lblGrado)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtCarnet)
        Me.Controls.Add(Me.lblCarnet)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ALUMNOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALUMNOSBindingNavigator.ResumeLayout(False)
        Me.ALUMNOSBindingNavigator.PerformLayout()
        CType(Me.ALUMNOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUMNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTROLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCarnet As Label
    Friend WithEvents txtCarnet As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblGrado As Label
    Friend WithEvents txtGrado As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents CONTROLDataSet As CONTROLDataSet
    Friend WithEvents ALUMNOSBindingSource As BindingSource
    Friend WithEvents ALUMNOSTableAdapter As CONTROLDataSetTableAdapters.ALUMNOSTableAdapter
    Friend WithEvents TableAdapterManager As CONTROLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ALUMNOSBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ALUMNOSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ALUMNOSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class

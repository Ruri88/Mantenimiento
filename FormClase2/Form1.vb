Public Class Form1
    Private Sub ALUMNOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ALUMNOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALUMNOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CONTROLDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CONTROLDataSet.ALUMNOS' Puede moverla o quitarla según sea necesario.
        Me.ALUMNOSTableAdapter.Fill(Me.CONTROLDataSet.ALUMNOS)
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Me.ALUMNOSTableAdapter.Insert(txtCarnet.Text, txtNombre.Text, txtApellido.Text, txtGrado.Text)
        Me.ALUMNOSTableAdapter.Fill(Me.CONTROLDataSet.ALUMNOS) 'Agrega o actualiza filas en DataSet.'
        MsgBox("Registro insertado correctamente")
        Me.limpiarCampos()

    End Sub

    Private Sub limpiarCampos()
        Me.txtCarnet.Clear()
        Me.txtNombre.Clear()
        Me.txtApellido.Clear()
        Me.txtGrado.Clear()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.ALUMNOSTableAdapter.EDITAR(txtCarnet.Text, txtNombre.Text, txtApellido.Text, txtGrado.Text)
        Me.ALUMNOSTableAdapter.Fill(Me.CONTROLDataSet.ALUMNOS)
        MsgBox("Registro editado correctamente")
        Me.limpiarCampos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ALUMNOSTableAdapter.FillBy(Me.CONTROLDataSet.ALUMNOS, txtCarnet.Text)
        Me.limpiarCampos()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.ALUMNOSTableAdapter.BORRAR(txtCarnet.Text)
        Me.ALUMNOSTableAdapter.Fill(Me.CONTROLDataSet.ALUMNOS)
        MsgBox("Registro borrado correctamente")
        Me.limpiarCampos()
    End Sub
End Class

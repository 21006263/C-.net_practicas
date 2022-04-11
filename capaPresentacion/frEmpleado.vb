Imports capaEntidad
Imports capaNegocio






Public Class frEmpleado

    Dim NegocioEmpleado As New CNEmpleado()




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnNombre_Click(sender As Object, e As EventArgs) Handles btnNombre.Click
        Limpiar()
        txtId.Value = 0
        txtNombre.Text = ""
        txtApellido.Text = ""
        picFoto.Image = Nothing

    End Sub

    Private Sub Limpiar()
        txtId.Value = 0
        txtNombre.Text = ""
        txtApellido.Text = ""
        picFoto.Image = Nothing
    End Sub





    Private Sub lnkFoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFoto.LinkClicked

        openFoto.ShowDialog()
        If openFoto.FileName <> "" Then
            picFoto.Load(openFoto.FileName
                         )
        End If



        picFoto.Load(openFoto.FileName)

        openFoto.FileName = ""

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim empleados As New CEEmpleado()

        Dim Validacion As Boolean

        empleados.Id = txtId.Value
        empleados.Nombre = txtNombre.Text
        empleados.Apellido = txtApellido.Text
        empleados.Foto = picFoto.ImageLocation



        Validacion = NegocioEmpleado.ValidarDatos(empleados)

        If Validacion = False Then Exit Sub

        If empleados.Id = 0 Then

            NegocioEmpleado.Insertar(empleados)
        Else

            NegocioEmpleado.Editar(empleados)

        End If


        CargarGrid()
        Limpiar()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If txtId.Value = 0 Then Exit Sub
        Dim empleados As New CEEmpleado()
        empleados.Id = txtId.Value
        NegocioEmpleado.Eliminar(empleados)
        CargarGrid()
        Limpiar()


    End Sub

    Private Sub frEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()

    End Sub

    Private Sub CargarGrid()
        gridDatos.DataSource = NegocioEmpleado.Listar().Tables("empleado")
    End Sub






    Private Sub gridDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridDatos.CellDoubleClick

        txtId.Value = gridDatos.CurrentRow.Cells("id").Value
        txtNombre.Text = gridDatos.CurrentRow.Cells("nombre").Value
        txtApellido.Text = gridDatos.CurrentRow.Cells("apellido").Value

        If gridDatos.CurrentRow.Cells("foto").Value <> "" Then

            If System.IO.File.Exists(gridDatos.CurrentRow.Cells("foto").Value) Then
                picFoto.Load(gridDatos.CurrentRow.Cells("foto").Value)
            End If
        End If







    End Sub
End Class

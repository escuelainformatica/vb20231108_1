Imports WinFormsAppInsertar.Models

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' crear un cliente
        Dim cli As New Cliente()
        cli.Id = TxtId.Value
        cli.Nombre = TxtNombre.Text
        cli.Apellido = TxtApellido.Text
        cli.Edad = TxtEdad.Value
        ' y guardarlo en la base de datos
        Using contexto As New BaseContext()
            contexto.Clientes.Add(cli)
            contexto.SaveChanges() ' aqui se guarda todas las operaciones pendientes.
            ' esto es para refrescar.
            Dim clientes As New List(Of Cliente)
            clientes = contexto.Clientes.ToList()
            DataGridView1.DataSource = clientes
        End Using
        PanelListado.Visible = True
        PanelEditar.Visible = False
        PanelFormulario.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using contexto As New BaseContext()
            Dim clientes As New List(Of Cliente)
            clientes = contexto.Clientes.ToList()
            DataGridView1.DataSource = clientes
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PanelListado.Visible = False
        PanelEditar.Visible = False
        PanelFormulario.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim clientes As New List(Of Cliente)
        clientes = DataGridView1.DataSource
        Dim clienteSeleccionado As New Cliente
        clienteSeleccionado = clientes.Item(e.RowIndex)
        If e.ColumnIndex = 0 Then
            ' abrimos la pantalla de editar
            PanelListado.Visible = False
            PanelEditar.Visible = True
            PanelFormulario.Visible = False


            ' estoy mostrando en el formulario de edicion los datos en la base de datos
            TxtEditarID.Value = clienteSeleccionado.Id
            TxtEditarNombre.Text = clienteSeleccionado.Nombre
            TxtEditarApellido.Text = clienteSeleccionado.Apellido
            TxtEditarEdad.Value = clienteSeleccionado.Edad
        End If
        If e.ColumnIndex = 1 Then
            ' borrar el elemento
            Using contexto As New BaseContext()
                contexto.Clientes.Remove(clienteSeleccionado)
                contexto.SaveChanges()

                ' esto es para refrescar.
                Dim clientes2 As New List(Of Cliente)
                clientes2 = contexto.Clientes.ToList()
                DataGridView1.DataSource = clientes2
            End Using
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' vamos a actualizar un cliente:
        ' crear un cliente
        Dim cli As New Cliente()
        cli.Id = TxtEditarID.Value
        cli.Nombre = TxtEditarNombre.Text
        cli.Apellido = TxtEditarApellido.Text
        cli.Edad = TxtEditarEdad.Value
        ' y guardarlo en la base de datos
        Using contexto As New BaseContext()
            ' tengo que leer el cliente antiguo desde la base de datos
            Dim cliAntiguo As New Cliente()
            cliAntiguo = contexto.Clientes.Find(cli.Id)
            cliAntiguo.Nombre = cli.Nombre
            cliAntiguo.Apellido = cli.Apellido
            cli.Edad = cli.Edad
            contexto.SaveChanges()

            ' esto es para refrescar.
            Dim clientes As New List(Of Cliente)
            clientes = contexto.Clientes.ToList()
            DataGridView1.DataSource = clientes
        End Using
        PanelListado.Visible = True
        PanelEditar.Visible = False
        PanelFormulario.Visible = False
    End Sub
End Class

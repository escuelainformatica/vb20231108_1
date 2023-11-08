# Ejercicio

## base de datos

Cree una base de datos nueva y una tabla con los siguientes datos:

**Productos**

* Id (entero y llave primaria)
* Nombre (varchar)
* Precio (entero)


## entity frameworks
En un proyecto nuevo, agregue el Entity Frameworks y corra el scaffold 

```bash
NuGet\Install-Package EntityFrameworkCore.VisualBasic -Version 7.0.0
NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 7.0.11
NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 7.0.11
````

Y use el scaffold para generar el codigo (reemplace ** por su cadena de conexion)

```bash
Scaffold-DbContext "**" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force  -Context BaseContext
```

## formulario
Y en el formulario, agregue lo siguiente
* un panel (cambie la propiedad dock para que use todo el tamaño)
* 1 Numeric-Updown con el nombre: TxtId
* 1 Textbox con el nombre: TxtNombre
* 1 Numeric-updown con el nombre: TxtPrecio
* 1 Button
* 1 galeria (en el mismo panel)

Cuando hace click en el boton, haga lo siguiente.
* Cree un Producto nuevo
* Agregue datos al producto usando los cuadros de texto y los numeric-updown
* Cree una conexion a la base de datos (contexto)
* A la tabla productos, agregue el producto nuevo
* Guarde los cambios
* Y muestre los datos de la grilla.

Ejemplo: (con cliente)
```vbnet
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
```

 



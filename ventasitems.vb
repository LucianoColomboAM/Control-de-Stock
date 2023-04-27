Imports WindowsApp1.Principal
Imports System.Data.SqlClient
Imports WindowsApp1.producto
Imports WindowsApp1.cliente


Public Class ventasitems
    Private viID As Integer
    Private viIDVenta As String
    Private viIDProducto As String
    Private viPrecioUnitario As String
    Private viCantidad As String
    Private viPrecioTotal As String
    Private viIDCliente As String
    Private viFecha As Date = Date.Now


    Public Sub ingVenta(IDProducto, Cantidad, IDCliente)
        Principal.conexion.Open()

        viIDProducto = IDProducto
        viCantidad = Cantidad
        viIDCliente = IDCliente


        Dim recuperarPrecio As New SqlCommand("SELECT Precio FROM productos WHERE id = @idP", Principal.conexion)

        recuperarPrecio.Parameters.AddWithValue("@idP", viIDProducto)

        Dim reader As SqlDataReader = recuperarPrecio.ExecuteReader()

        If reader.Read() Then
            viPrecioUnitario = reader.GetDouble(0)
            viPrecioTotal = viPrecioUnitario * viCantidad
        End If

        Dim IngresarVenta As New SqlCommand("INSERT INTO ventas (IDCliente, Fecha, Total) VALUES ('" & viIDCliente & "', '" & viFecha & "', '" & viPrecioTotal & "')", Principal.conexion)
        IngresarVenta.ExecuteNonQuery()

        Dim recuperarIDVenta As New SqlCommand("SELECT SCOPE_IDENTITY() AS ID", Principal.conexion)

        Dim reader2 As SqlDataReader = recuperarIDVenta.ExecuteReader()

        If reader2.Read() Then
            viIDVenta = reader2.GetDecimal(0)
        End If

        Dim ingresarVentasItems As New SqlCommand("INSERT INTO ventasitems (IDVenta,IDProducto,PrecioUnitario,Cantidad,PrecioTotal) VALUES ('" & viIDVenta & "', '" & viIDProducto & "', '" & viPrecioUnitario & "','" & viCantidad & "','" & viPrecioTotal & "')", Principal.conexion)
        ingresarVentasItems.ExecuteNonQuery()

        generarReporte(viIDCliente, viIDVenta, viIDProducto, viPrecioUnitario, viCantidad, viPrecioTotal)

        Principal.conexion.Close()


    End Sub

    Public Sub modVenta(IDVenta, IDProducto, Cantidad, IDCliente)
        Principal.conexion.Open()
        viIDVenta = IDVenta
        viIDProducto = IDProducto
        viCantidad = Cantidad
        viIDCliente = IDCliente

        Dim recuperarPrecio As New SqlCommand("SELECT Precio FROM productos WHERE id = @idP", Principal.conexion)

        recuperarPrecio.Parameters.AddWithValue("@idP", viIDProducto)

        Dim reader As SqlDataReader = recuperarPrecio.ExecuteReader()
        If reader.Read() Then
            viPrecioUnitario = reader.GetDouble(0)
            viPrecioTotal = viPrecioUnitario * viCantidad
        End If

        Dim modificarVenta As New SqlCommand("UPDATE ventas SET IDCliente = @IDCliente, Total = @Total WHERE id = @IDVENTA;", Principal.conexion)
        modificarVenta.Parameters.AddWithValue("@IDVenta", viIDVenta)
        modificarVenta.Parameters.AddWithValue("@IDCliente", viIDCliente)
        modificarVenta.Parameters.AddWithValue("@Total", viPrecioTotal)

        modificarVenta.ExecuteNonQuery()

        Dim modificarVentasItems As New SqlCommand("UPDATE ventasitems SET IDVenta = @IDVenta, IDProducto = @IDProducto, PrecioUnitario = @PrecioUnitario, Cantidad = @Cantidad, PrecioTotal = @PrecioTotal WHERE id = @IDVENTA;", Principal.conexion)
        modificarVentasItems.Parameters.AddWithValue("@IDVenta", viIDVenta)
        modificarVentasItems.Parameters.AddWithValue("@IDProducto", viIDProducto)
        modificarVentasItems.Parameters.AddWithValue("@PrecioUnitario", viPrecioUnitario)
        modificarVentasItems.Parameters.AddWithValue("@Cantidad", viCantidad)
        modificarVentasItems.Parameters.AddWithValue("@PrecioTotal", viPrecioTotal)
        modificarVentasItems.ExecuteNonQuery()
        Principal.conexion.Close()
    End Sub

    Public Sub bajaVenta(IDAEliminar)
        Principal.conexion.Open()

        viID = IDAEliminar

        Dim comando As New SqlCommand("DELETE FROM ventas WHERE id = @id;", Principal.conexion)
        comando.Parameters.AddWithValue("@id", viID)
        comando.ExecuteNonQuery()

        Dim comando2 As New SqlCommand("DELETE FROM ventasitems WHERE idventa = @id;", Principal.conexion)
        comando2.Parameters.AddWithValue("@id", viID)
        comando2.ExecuteNonQuery()



        Principal.conexion.Close()



    End Sub

    Public Sub generarReporte(IDCliente, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal)



        Dim viNombreProducto As String
        Dim viNombreCliente As String
        Dim viTelefonoCliente As String
        Dim viCorreoCliente As String



        Dim recuperarNombreProducto As New SqlCommand("SELECT Nombre FROM productos WHERE id = @id", Principal.conexion)

        recuperarNombreProducto.Parameters.AddWithValue("@id", IDProducto)

        Dim reader As SqlDataReader = recuperarNombreProducto.ExecuteReader()

        If reader.Read() Then
            viNombreProducto = reader.GetString(0)
        End If


        '   Dim busqueda As New SqlCommand("SELECT idcliente FROM ventas WHERE id = @id", Principal.conexion)
        '   busqueda.Parameters.AddWithValue("@id", IDVenta)
        '   Dim lector As SqlDataReader = busqueda.ExecuteReader()
        '
        '       If lector.Read() Then
        '       viNombreCliente = reader.GetString(0)
        '       End If





        Dim recuperarNombreCliente As New SqlCommand("SELECT Cliente FROM clientes WHERE id = @id", Principal.conexion)

        recuperarNombreCliente.Parameters.AddWithValue("@id", IDCliente)

        Dim reader2 As SqlDataReader = recuperarNombreCliente.ExecuteReader()

        If reader2.Read() Then
            viNombreCliente = reader2.GetString(0)
        End If

        Dim recuperarCorreoCliente As New SqlCommand("SELECT Correo FROM clientes WHERE id = @id", Principal.conexion)

        recuperarCorreoCliente.Parameters.AddWithValue("@id", IDCliente)

        Dim reader3 As SqlDataReader = recuperarCorreoCliente.ExecuteReader()

        If reader3.Read() Then
            viCorreoCliente = reader3.GetString(0)
        End If

        Dim recuperarTelefonoCliente As New SqlCommand("SELECT Telefono FROM clientes WHERE id = @id", Principal.conexion)

        recuperarTelefonoCliente.Parameters.AddWithValue("@id", IDCliente)

        Dim reader4 As SqlDataReader = recuperarTelefonoCliente.ExecuteReader()

        If reader4.Read() Then
            viTelefonoCliente = reader4.GetString(0)
        End If

        ReporteVentas.FechaDeVenta.Text = "La fecha de la venta es: " + viFecha
        ReporteVentas.LabelCliente.Text = "Por el cliente: " + viNombreCliente
        ReporteVentas.LabelIDC.Text = "ID del cliente: " + IDCliente
        ReporteVentas.LabelCorreo.Text = "Correo del cliente: " + viCorreoCliente
        ReporteVentas.LabelTelefono.Text = "Telefono del cliente: " + viTelefonoCliente
        ReporteVentas.LabelProducto.Text = "El producto comprado fue: " + viNombreProducto
        ReporteVentas.LabelIDP.Text = "El ID del producto es: " + IDProducto
        ReporteVentas.LabelPPU.Text = "El precio por unidad del producto es" + PrecioUnitario
        ReporteVentas.LabelCantidad.Text = "La cantidad de productos comprados fue: " + Cantidad
        ReporteVentas.LabelPrecioTotal.Text = "El importe total fue de: " + PrecioTotal

        ReporteVentas.Show()




        Principal.conexion.Close()

    End Sub

End Class

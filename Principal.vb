Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient
Imports System.Configuration
Imports WindowsApp1.cliente



Public Class Principal


    Dim ConnectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ToString
    Public conexion As New SqlConnection(ConnectionString)
    Dim Fecha As Date = Date.Now


    Public Sub GenerarReporteMensual()
        conexion.Open()
        '  Dim idProductos As String

        Dim busquedaPID As New SqlCommand("SELECT * FROM productos", conexion)
        Dim busquedaPVID As New SqlCommand("SELECT * FROM ventasitems", conexion)

        Dim busquedaPIDLectura As SqlDataReader = busquedaPID.ExecuteReader()
        Dim busquedaPVIDLectura As SqlDataReader = busquedaPVID.ExecuteReader()





        While busquedaPIDLectura.Read()

            Dim fila As String = ReporteMensual.DTVReporteMensual.Rows.Add()


            ReporteMensual.DTVReporteMensual.Rows(fila).Cells("IDProducto").Value = busquedaPIDLectura("id")

            ReporteMensual.DTVReporteMensual.Rows(fila).Cells("Productos").Value = busquedaPIDLectura("Nombre")



        End While

        While busquedaPVIDLectura.Read()

            For Each fila As DataGridViewRow In ReporteMensual.DTVReporteMensual.Rows

                Dim valorActual As String = fila.Cells("IDProducto").Value

                If valorActual = busquedaPVIDLectura("IDProducto") Then
                    ' El valor buscado se encuentra en la fila actual
                    ' Puedes hacer lo que necesites con la fila actual, por ejemplo:
                    fila.Cells("VentasMes").Value = fila.Cells("VentasMes").Value + busquedaPVIDLectura("Cantidad")


                End If
            Next

        End While

        busquedaPIDLectura.Close()

        ReporteMensual.Show()

        conexion.Close()
    End Sub


    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim objetoA As String
        Dim objetoB As String
        Dim objetoC As String

        objetoA = ListBoxA.SelectedItem

        Console.WriteLine(objetoA)

        Select Case objetoA

            Case "clientes"
                objetoB = ListBoxClientes.SelectedItem
                Console.WriteLine(objetoB)
                Select Case objetoB
                    Case "ID"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM clientes WHERE id = @id", Conexion)
                            busqueda.Parameters.AddWithValue("@id", objetoC)

                            ' Crea un objeto SqlDataAdapter para llenar un objeto DataTable con los datos
                            Dim da As New SqlDataAdapter(busqueda)

                            ' Crea un objeto DataTable para contener los datos
                            Dim dt As New DataTable()

                            ' Llena el objeto DataTable con los datos de la consulta SQL
                            da.Fill(dt)

                            ' Asigna el objeto DataTable como origen de datos del DataGridView
                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try


                    Case "Cliente"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM clientes WHERE Cliente = @Cliente", Conexion)
                            busqueda.Parameters.AddWithValue("@Cliente", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)


                            Dim dt As New DataTable()


                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try

                    Case "Telefono"

                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM clientes WHERE Telefono = @Telefono", Conexion)
                            busqueda.Parameters.AddWithValue("@Telefono", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try

                    Case "Correo"

                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM clientes WHERE Correo = @Correo", Conexion)
                            busqueda.Parameters.AddWithValue("@Correo", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try

                    Case Else
                        MsgBox("Seleccione si desea buscar por ID, Cliente, Telefono o Correo!")

                End Select

            Case "productos"
                objetoB = ListBoxProductos.SelectedItem
                Console.WriteLine(objetoB)
                Select Case objetoB
                    Case "ID"

                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM productos WHERE id = @id", Conexion)
                            busqueda.Parameters.AddWithValue("@id", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case "Nombre"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM productos WHERE Nombre = @Nombre", Conexion)
                            busqueda.Parameters.AddWithValue("@Nombre", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case "Precio"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM productos WHERE Precio = @Precio", Conexion)
                            busqueda.Parameters.AddWithValue("@Precio", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case "Categoria"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM productos WHERE Categoria = @Categoria", Conexion)
                            busqueda.Parameters.AddWithValue("@Categoria", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case Else
                        MsgBox("Seleccione si desea buscar por ID, Nombre, Precio o Categoria")

                End Select

            Case "ventas"
                objetoB = ListBoxVentas.SelectedItem
                Console.WriteLine(objetoB)
                Select Case objetoB
                    Case "ID"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM ventas WHERE id = @id", Conexion)
                            busqueda.Parameters.AddWithValue("@id", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case "IDCliente"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM ventas WHERE IDCliente = @IDCliente", Conexion)
                            busqueda.Parameters.AddWithValue("@IDCliente", objetoC)


                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case "Fecha"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM ventas WHERE Fecha = @Fecha", Conexion)
                            busqueda.Parameters.AddWithValue("@Fecha", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case "Total"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM ventas WHERE Total = @Total", Conexion)
                            busqueda.Parameters.AddWithValue("@Total", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case Else
                        MsgBox("Seleccione si desea buscar por ID, IDCLIENTE, Fecha o Total!")


                End Select
            Case "ventasitems"
                objetoB = ListBoxVentasItems.SelectedItem
                Console.WriteLine(objetoB)
                Select Case objetoB
                    Case "ID"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM ventasitems WHERE id = @id", Conexion)
                            busqueda.Parameters.AddWithValue("@id", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try

                    Case "IDVenta"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM ventasitems WHERE IDVenta = @IDVenta", Conexion)
                            busqueda.Parameters.AddWithValue("@IDVenta", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case "IDProducto"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM ventasitems WHERE IDProducto = @IDProducto", Conexion)
                            busqueda.Parameters.AddWithValue("@IDProducto", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case "PrecioUnitario"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM ventasitems WHERE PrecioUnitario = @PrecioUnitario", Conexion)
                            busqueda.Parameters.AddWithValue("@PrecioUnitario", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case "Cantidad"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM ventasitems WHERE Cantidad = @Cantidad", Conexion)
                            busqueda.Parameters.AddWithValue("@Cantidad", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try
                    Case "PrecioTotal"
                        objetoC = Ingreso.Text
                        Console.WriteLine(objetoC)

                        Try
                            Conexion.Open()
                            MsgBox("La busqueda fue exitosa")

                            Dim busqueda As New SqlCommand("SELECT * FROM ventasitems WHERE PrecioTotal = @PrecioTotal", Conexion)
                            busqueda.Parameters.AddWithValue("@PrecioTotal", objetoC)

                            Dim da As New SqlDataAdapter(busqueda)

                            Dim dt As New DataTable()

                            da.Fill(dt)

                            DataGridView1.DataSource = dt

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally
                            If Conexion.State = ConnectionState.Open Then
                                Conexion.Close()
                            End If

                        End Try

                    Case Else
                        MsgBox("Seleccione si desea buscar por ID, IDVENTA, IDProducto, PrecioUnitario, Cantidad o Precio Total!")

                End Select
            Case Else
                MsgBox("Seleccione si es cliente, producto, venta, o ventas items!")



        End Select



    End Sub


    Private Sub VerClientes_Click(sender As Object, e As EventArgs) Handles VerClientes.Click

        Try
            Conexion.Open()
            MsgBox("La conexion con la base de datos de Clientes fue exitosa")

            Dim cmd As New SqlCommand("SELECT * FROM clientes", Conexion)

            Dim da As New SqlDataAdapter(cmd)

            Dim dt As New DataTable()

            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If

        End Try

    End Sub

    Private Sub VerProductos_Click(sender As Object, e As EventArgs) Handles VerProductos.Click
        Try
            Conexion.Open()
            MsgBox("La conexion con la base de datos de Productos fue exitosa")

            Dim cmd As New SqlCommand("SELECT * FROM productos", Conexion)

            Dim da As New SqlDataAdapter(cmd)

            Dim dt As New DataTable()

            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If

        End Try



    End Sub

    Private Sub VerVentas_Click(sender As Object, e As EventArgs) Handles VerVentas.Click
        Try
            Conexion.Open()
            MsgBox("La conexion con la base de datos de Ventas fue exitosa")

            Dim cmd As New SqlCommand("SELECT * FROM ventas", Conexion)

            Dim da As New SqlDataAdapter(cmd)

            Dim dt As New DataTable()

            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If

        End Try
    End Sub


    Private Sub VerVentasItems_Click(sender As Object, e As EventArgs) Handles VerVentasItems.Click
        Try
            Conexion.Open()
            MsgBox("La conexion con la base de datos de venta de Items fue exitosa")

            Dim cmd As New SqlCommand("SELECT * FROM ventasitems", Conexion)

            Dim da As New SqlDataAdapter(cmd)

            Dim dt As New DataTable()

            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If

        End Try
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub ingCliente_Click(sender As Object, e As EventArgs) Handles ingCliente.Click
        Dim Cliente As String
        Dim Telefono As String
        Dim Correo As String


        Cliente = InputBox("Ingrese el Nombre del cliente que desea cambiar", "Ingresar Cliente Nuevo", "", 700, 300)
        Telefono = InputBox("Ingrese el Telefono del cliente", "Ingresar Cliente Nuevo", "", 700, 300)
        Correo = InputBox("Ingrese el Correo del cliente", "Ingresar Cliente Nuevo", "", 700, 300)

        If Cliente <> "" Or Telefono <> "" Or Correo <> "" Then

            Dim ingresar As New cliente()
            ingresar.ingCliente(Cliente, Telefono, Correo)
        Else

            MsgBox("Estas introduciendo caracteres invalidos")
        End If







    End Sub

    Private Sub modCliente_Click(sender As Object, e As EventArgs) Handles modCliente.Click
        Dim idAModificar As Integer
        Dim Cliente As String
        Dim Telefono As String
        Dim Correo As String
        idAModificar = InputBox("Ingrese el ID del cliente a modificar", "Modificar Cliente", "", 700, 300)
        Cliente = InputBox("Ingrese el Nombre nuevo del cliente", "Modificar Cliente", "", 700, 300)
        Telefono = InputBox("Ingrese el Telefono nuevo del cliente", "Modificar Cliente", "", 700, 300)
        Correo = InputBox("Ingrese el Correo nuevo del cliente", "Modificar Cliente", "", 700, 300)

        If idAModificar <> "" Or Cliente <> "" Or Telefono <> "" Or Correo <> "" Then
            Dim modificar As New cliente()
            modificar.modCliente(idAModificar, Cliente, Telefono, Correo)
        Else
            MsgBox("Estas introduciendo caracteres invalidos")
        End If


    End Sub

    Private Sub bajaCliente_Click(sender As Object, e As EventArgs) Handles bajaCliente.Click
        Dim idAEliminar As Integer
        Dim Comprobacion As String
        idAEliminar = InputBox("Ingrese el ID del cliente a dar de baja", "Eliminar Cliente", "", 700, 300)
        Comprobacion = InputBox("Ingrese de nuevo el ID del cliente", "Eliminar Cliente", "", 700, 300)

        If idAEliminar <> Comprobacion Then
            MsgBox("Ingrese dos ID iguales para lograr eliminarlos")


        Else
            Dim eliminar As New cliente()
            eliminar.bajaCliente(idAEliminar)
        End If
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ingProducto_Click(sender As Object, e As EventArgs) Handles ingProducto.Click
        Dim Nombre As String
        Dim Precio As Double
        Dim Categoria As String
        Nombre = InputBox("Ingrese el Nombre del Producto que desea ingresar", "Ingresar Producto Nuevo", "", 700, 300)
        Precio = InputBox("Ingrese el Precio del Producto", "Ingresar Producto Nuevo", "", 700, 300)
        Categoria = InputBox("Ingrese la Categoria del Producto", "Ingresar Producto Nuevo", "", 700, 300)

        If Nombre <> "" Or Precio <> "" Or Categoria <> "" Then

            Dim ingresar As New producto()
            ingresar.ingProducto(Nombre, Precio, Categoria)
        Else

            MsgBox("Estas introduciendo caracteres invalidos")
        End If




    End Sub

    Private Sub modProducto_Click(sender As Object, e As EventArgs) Handles modProducto.Click

        Dim idAModificar As String
        Dim Nombre As String
        Dim Precio As Double
        Dim Categoria As String

        idAModificar = InputBox("Ingrese el ID del producto a modificar", "Modificar Producto", "", 700, 300)
        Nombre = InputBox("Ingrese el Nombre nuevo del Producto", "Modificar Producto", "", 700, 300)
        Precio = InputBox("Ingrese el Precio nuevo del Producto", "Modificar Producto", "", 700, 300)
        Categoria = InputBox("Ingrese la Categoria nueva del Producto", "Modificar Producto", "", 700, 300)

        If idAModificar <> "" Or Nombre <> "" Or Precio <> "" Or Categoria <> "" Then

            Dim modificar As New producto()
            modificar.modProducto(idAModificar, Nombre, Precio, Categoria)
        Else

            MsgBox("Estas introduciendo caracteres invalidos")
        End If


    End Sub

    Private Sub bajaProducto_Click(sender As Object, e As EventArgs) Handles bajaProducto.Click
        Dim idAEliminar As Integer
        Dim Comprobacion As Integer
        idAEliminar = InputBox("Ingrese el ID del producto a dar de baja", "Eliminar Cliente", "", 700, 300)
        Comprobacion = InputBox("Ingrese de nuevo el ID Nombre  del prodcuto", "Eliminar Cliente", "", 700, 300)

        If idAEliminar <> Comprobacion Then
            MsgBox("Ingrese dos ID iguales para lograr eliminarlos")
        Else
            Dim eliminar As New producto()
            eliminar.bajaProducto(idAEliminar)
        End If
    End Sub



    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ingVenta_Click(sender As Object, e As EventArgs) Handles ingVenta.Click
        Dim IDProducto As String
        Dim Cantidad As String
        Dim IDCliente As String
        IDProducto = InputBox("Ingrese el ID del Producto que desea vender", "Vender Producto Nuevo", "", 700, 300)
        Cantidad = InputBox("Ingrese la cantidad de productos comprados", "Vender Producto Nuevo", "", 700, 300)
        IDCliente = InputBox("Ingrese el ID del Cliente que ha realizado la compra", "Vender Producto Nuevo", "", 700, 300)

        If IDProducto <> "" Or Cantidad <> "" Or IDCliente <> "" Then

            Dim ingresar As New ventasitems()
            ingresar.ingVenta(IDProducto, Cantidad, IDCliente)
        Else

            MsgBox("Estas introduciendo caracteres invalidos")
        End If


    End Sub

    Private Sub modVenta_Click(sender As Object, e As EventArgs) Handles modVenta.Click
        Dim IDVenta As String
        Dim IDProducto As String
        Dim Cantidad As String
        Dim IDCliente As String
        IDVenta = InputBox("Ingrese el ID de la Venta que desea modificar", "Modificar Venta", "", 700, 300)
        IDProducto = InputBox("Ingrese el ID del Producto que desea modificar", "Modificar Venta", "", 700, 300)
        Cantidad = InputBox("Ingrese la cantidad de productos comprados", "Modificar Venta", "", 700, 300)
        IDCliente = InputBox("Ingrese el ID del Cliente que ha realizado la compra", "Modificar Venta", "", 700, 300)


        If IDVenta <> "" Or IDProducto <> "" Or Cantidad <> "" Or IDCliente <> "" Then

            Dim modificar As New ventasitems()
            modificar.modVenta(IDVenta, IDProducto, Cantidad, IDCliente)

        Else

            MsgBox("Estas introduciendo caracteres invalidos")
        End If


    End Sub

    Private Sub bajaVenta_Click(sender As Object, e As EventArgs) Handles bajaVenta.Click
        Dim idAEliminar As Integer
        Dim Comprobacion As Integer
        idAEliminar = InputBox("Ingrese el ID de la venta a dar de baja", "Eliminar Venta", "", 700, 300)
        Comprobacion = InputBox("Ingrese de nuevo el ID de la venta", "Eliminar Venta", "", 700, 300)

        If idAEliminar <> Comprobacion Then
            MsgBox("Ingrese dos ID iguales para lograr eliminarlos")
        Else
            Dim eliminar As New ventasitems()
            eliminar.bajaVenta(idAEliminar)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GenerarReporteMensual()

    End Sub

End Class

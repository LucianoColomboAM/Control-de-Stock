Imports WindowsApp1.Principal
Imports System.Data.SqlClient


Public Class producto
    Private pID As Integer
    Private pNombre As String
    Private pPrecio As Double
    Private pCategoria As String

    Public Sub ingProducto(Nombre, Precio, Categoria)
        Principal.conexion.Open()

        pNombre = Nombre
        pPrecio = Precio
        pCategoria = Categoria

        Dim comando As New SqlCommand("INSERT INTO productos (Nombre, Precio, Categoria) VALUES ('" & pNombre & "', '" & pPrecio & "', '" & pCategoria & "')", Principal.conexion)
        comando.ExecuteNonQuery()



        Principal.conexion.Close()
    End Sub

    Public Sub modProducto(ID, Nombre, Precio, Categoria)
        Principal.conexion.Open()

        pID = ID
        pNombre = Nombre
        pPrecio = Precio
        pCategoria = Categoria
        Dim comando As New SqlCommand("UPDATE productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE id = @ID;", Principal.conexion)
        comando.Parameters.AddWithValue("@ID", pID)
        comando.Parameters.AddWithValue("@Nombre", pNombre)
        comando.Parameters.AddWithValue("@Precio", pPrecio)
        comando.Parameters.AddWithValue("@Categoria", pCategoria)
        comando.ExecuteNonQuery()


        Principal.conexion.Close()
    End Sub

    Public Sub bajaProducto(ID)
        Principal.conexion.Open()

        pID = ID
        Dim comando As New SqlCommand("DELETE FROM productos WHERE id = @id;", Principal.conexion)
        comando.Parameters.AddWithValue("@ID", pID)
        comando.ExecuteNonQuery()


        Principal.conexion.Close()
    End Sub

End Class
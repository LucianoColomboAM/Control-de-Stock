Imports WindowsApp1.Principal
Imports System.Data.SqlClient

Public Class cliente

    Private cID As String
    Private cCliente As String
    Private cTelefono As String
    Private cCorreo As String



    Public Sub ingCliente(Cliente, Telefono, Correo)
        Principal.conexion.Open()

        cCliente = Cliente
        cTelefono = Telefono
        cCorreo = Correo
        Dim comando As New SqlCommand("INSERT INTO clientes (Cliente, Telefono, Correo) VALUES ('" & cCliente & "', '" & cTelefono & "', '" & cCorreo & "')", Principal.conexion)
        comando.ExecuteNonQuery()


        Principal.conexion.Close()
    End Sub

    Public Sub modCliente(ID, Cliente, Telefono, Correo)
        Principal.conexion.Open()

        cID = ID
        cCliente = Cliente
        cTelefono = Telefono
        cCorreo = Correo
        Dim comando As New SqlCommand("UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE id = @id;", Principal.conexion)
        comando.Parameters.AddWithValue("@ID", cID)
        comando.Parameters.AddWithValue("@Cliente", cCliente)
        comando.Parameters.AddWithValue("@Telefono", cTelefono)
        comando.Parameters.AddWithValue("@Correo", cCorreo)
        comando.ExecuteNonQuery()


        Principal.conexion.Close()
    End Sub

    Public Sub bajaCliente(ID)
        Principal.conexion.Open()

        cID = ID
        Dim comando As New SqlCommand("DELETE FROM clientes WHERE id = @id;", Principal.conexion)
        comando.Parameters.AddWithValue("@ID", cID)
        comando.ExecuteNonQuery()


        Principal.conexion.Close()
    End Sub

End Class
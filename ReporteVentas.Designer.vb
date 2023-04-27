<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelPrecioTotal = New System.Windows.Forms.Label()
        Me.LabelIDP = New System.Windows.Forms.Label()
        Me.LabelPPU = New System.Windows.Forms.Label()
        Me.LabelCantidad = New System.Windows.Forms.Label()
        Me.LabelProducto = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelIDC = New System.Windows.Forms.Label()
        Me.LabelCliente = New System.Windows.Forms.Label()
        Me.FechaDeVenta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelPrecioTotal
        '
        Me.LabelPrecioTotal.AutoSize = True
        Me.LabelPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecioTotal.Location = New System.Drawing.Point(16, 402)
        Me.LabelPrecioTotal.Name = "LabelPrecioTotal"
        Me.LabelPrecioTotal.Size = New System.Drawing.Size(101, 17)
        Me.LabelPrecioTotal.TabIndex = 23
        Me.LabelPrecioTotal.Text = "Precio Total:"
        '
        'LabelIDP
        '
        Me.LabelIDP.AutoSize = True
        Me.LabelIDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDP.Location = New System.Drawing.Point(16, 311)
        Me.LabelIDP.Name = "LabelIDP"
        Me.LabelIDP.Size = New System.Drawing.Size(125, 17)
        Me.LabelIDP.TabIndex = 22
        Me.LabelIDP.Text = "ID del Producto:"
        '
        'LabelPPU
        '
        Me.LabelPPU.AutoSize = True
        Me.LabelPPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPPU.Location = New System.Drawing.Point(15, 371)
        Me.LabelPPU.Name = "LabelPPU"
        Me.LabelPPU.Size = New System.Drawing.Size(142, 17)
        Me.LabelPPU.TabIndex = 21
        Me.LabelPPU.Text = "Precio por unidad:"
        '
        'LabelCantidad
        '
        Me.LabelCantidad.AutoSize = True
        Me.LabelCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCantidad.Location = New System.Drawing.Point(15, 341)
        Me.LabelCantidad.Name = "LabelCantidad"
        Me.LabelCantidad.Size = New System.Drawing.Size(77, 17)
        Me.LabelCantidad.TabIndex = 20
        Me.LabelCantidad.Text = "Cantidad:"
        '
        'LabelProducto
        '
        Me.LabelProducto.AutoSize = True
        Me.LabelProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProducto.Location = New System.Drawing.Point(15, 276)
        Me.LabelProducto.Name = "LabelProducto"
        Me.LabelProducto.Size = New System.Drawing.Size(78, 17)
        Me.LabelProducto.TabIndex = 19
        Me.LabelProducto.Text = "Producto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Datos de la venta"
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefono.Location = New System.Drawing.Point(15, 202)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(77, 17)
        Me.LabelTelefono.TabIndex = 17
        Me.LabelTelefono.Text = "Telefono:"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.Location = New System.Drawing.Point(15, 169)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(62, 17)
        Me.LabelCorreo.TabIndex = 16
        Me.LabelCorreo.Text = "Correo:"
        '
        'LabelIDC
        '
        Me.LabelIDC.AutoSize = True
        Me.LabelIDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDC.Location = New System.Drawing.Point(15, 138)
        Me.LabelIDC.Name = "LabelIDC"
        Me.LabelIDC.Size = New System.Drawing.Size(110, 17)
        Me.LabelIDC.TabIndex = 15
        Me.LabelIDC.Text = "ID del Cliente:"
        '
        'LabelCliente
        '
        Me.LabelCliente.AutoSize = True
        Me.LabelCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCliente.Location = New System.Drawing.Point(15, 104)
        Me.LabelCliente.Name = "LabelCliente"
        Me.LabelCliente.Size = New System.Drawing.Size(114, 17)
        Me.LabelCliente.TabIndex = 14
        Me.LabelCliente.Text = "Por el cliente: "
        '
        'FechaDeVenta
        '
        Me.FechaDeVenta.AutoSize = True
        Me.FechaDeVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDeVenta.Location = New System.Drawing.Point(15, 59)
        Me.FechaDeVenta.Name = "FechaDeVenta"
        Me.FechaDeVenta.Size = New System.Drawing.Size(172, 17)
        Me.FechaDeVenta.TabIndex = 13
        Me.FechaDeVenta.Text = "Venta realizada el dia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Reporte de venta"
        '
        'ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(419, 493)
        Me.Controls.Add(Me.LabelPrecioTotal)
        Me.Controls.Add(Me.LabelIDP)
        Me.Controls.Add(Me.LabelPPU)
        Me.Controls.Add(Me.LabelCantidad)
        Me.Controls.Add(Me.LabelProducto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelTelefono)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.LabelIDC)
        Me.Controls.Add(Me.LabelCliente)
        Me.Controls.Add(Me.FechaDeVenta)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReporteVentas"
        Me.Text = "ReporteVentas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPrecioTotal As Label
    Friend WithEvents LabelIDP As Label
    Friend WithEvents LabelPPU As Label
    Friend WithEvents LabelCantidad As Label
    Friend WithEvents LabelProducto As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelIDC As Label
    Friend WithEvents LabelCliente As Label
    Friend WithEvents FechaDeVenta As Label
    Friend WithEvents Label1 As Label
End Class

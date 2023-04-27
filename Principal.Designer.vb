<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.VerClientes = New System.Windows.Forms.Button()
        Me.ingVenta = New System.Windows.Forms.Button()
        Me.ingCliente = New System.Windows.Forms.Button()
        Me.ingProducto = New System.Windows.Forms.Button()
        Me.modVenta = New System.Windows.Forms.Button()
        Me.bajaVenta = New System.Windows.Forms.Button()
        Me.modCliente = New System.Windows.Forms.Button()
        Me.bajaCliente = New System.Windows.Forms.Button()
        Me.modProducto = New System.Windows.Forms.Button()
        Me.bajaProducto = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VerProductos = New System.Windows.Forms.Button()
        Me.VerVentas = New System.Windows.Forms.Button()
        Me.VerVentasItems = New System.Windows.Forms.Button()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.ListBoxA = New System.Windows.Forms.ListBox()
        Me.ListBoxVentas = New System.Windows.Forms.ListBox()
        Me.ListBoxVentasItems = New System.Windows.Forms.ListBox()
        Me.ListBoxProductos = New System.Windows.Forms.ListBox()
        Me.ListBoxClientes = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ingreso = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VerClientes
        '
        Me.VerClientes.BackColor = System.Drawing.Color.Orange
        Me.VerClientes.Location = New System.Drawing.Point(820, 184)
        Me.VerClientes.Name = "VerClientes"
        Me.VerClientes.Size = New System.Drawing.Size(179, 89)
        Me.VerClientes.TabIndex = 0
        Me.VerClientes.Text = "Ver Clientes "
        Me.VerClientes.UseVisualStyleBackColor = False
        '
        'ingVenta
        '
        Me.ingVenta.AutoSize = True
        Me.ingVenta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ingVenta.Location = New System.Drawing.Point(15, 80)
        Me.ingVenta.Name = "ingVenta"
        Me.ingVenta.Size = New System.Drawing.Size(179, 59)
        Me.ingVenta.TabIndex = 1
        Me.ingVenta.Text = "Ingresar Venta"
        Me.ingVenta.UseVisualStyleBackColor = False
        '
        'ingCliente
        '
        Me.ingCliente.BackColor = System.Drawing.Color.Pink
        Me.ingCliente.Location = New System.Drawing.Point(200, 78)
        Me.ingCliente.Name = "ingCliente"
        Me.ingCliente.Size = New System.Drawing.Size(210, 61)
        Me.ingCliente.TabIndex = 2
        Me.ingCliente.Text = "Ingresar Cliente"
        Me.ingCliente.UseVisualStyleBackColor = False
        '
        'ingProducto
        '
        Me.ingProducto.BackColor = System.Drawing.Color.PaleGreen
        Me.ingProducto.Location = New System.Drawing.Point(416, 78)
        Me.ingProducto.Name = "ingProducto"
        Me.ingProducto.Size = New System.Drawing.Size(183, 61)
        Me.ingProducto.TabIndex = 2
        Me.ingProducto.Text = "Ingresar Productos"
        Me.ingProducto.UseVisualStyleBackColor = False
        '
        'modVenta
        '
        Me.modVenta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.modVenta.Location = New System.Drawing.Point(15, 145)
        Me.modVenta.Name = "modVenta"
        Me.modVenta.Size = New System.Drawing.Size(179, 61)
        Me.modVenta.TabIndex = 4
        Me.modVenta.Text = "Modificar Venta"
        Me.modVenta.UseVisualStyleBackColor = False
        '
        'bajaVenta
        '
        Me.bajaVenta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bajaVenta.Location = New System.Drawing.Point(15, 212)
        Me.bajaVenta.Name = "bajaVenta"
        Me.bajaVenta.Size = New System.Drawing.Size(179, 61)
        Me.bajaVenta.TabIndex = 5
        Me.bajaVenta.Text = "Dar de baja venta"
        Me.bajaVenta.UseVisualStyleBackColor = False
        '
        'modCliente
        '
        Me.modCliente.BackColor = System.Drawing.Color.Pink
        Me.modCliente.Location = New System.Drawing.Point(200, 145)
        Me.modCliente.Name = "modCliente"
        Me.modCliente.Size = New System.Drawing.Size(210, 61)
        Me.modCliente.TabIndex = 6
        Me.modCliente.Text = "Modificar Cliente"
        Me.modCliente.UseVisualStyleBackColor = False
        '
        'bajaCliente
        '
        Me.bajaCliente.BackColor = System.Drawing.Color.Pink
        Me.bajaCliente.Location = New System.Drawing.Point(200, 211)
        Me.bajaCliente.Name = "bajaCliente"
        Me.bajaCliente.Size = New System.Drawing.Size(210, 62)
        Me.bajaCliente.TabIndex = 7
        Me.bajaCliente.Text = "Dar de baja cliente"
        Me.bajaCliente.UseVisualStyleBackColor = False
        '
        'modProducto
        '
        Me.modProducto.BackColor = System.Drawing.Color.PaleGreen
        Me.modProducto.Location = New System.Drawing.Point(416, 145)
        Me.modProducto.Name = "modProducto"
        Me.modProducto.Size = New System.Drawing.Size(183, 61)
        Me.modProducto.TabIndex = 8
        Me.modProducto.Text = "Modificar productos"
        Me.modProducto.UseVisualStyleBackColor = False
        '
        'bajaProducto
        '
        Me.bajaProducto.BackColor = System.Drawing.Color.PaleGreen
        Me.bajaProducto.Location = New System.Drawing.Point(416, 211)
        Me.bajaProducto.Name = "bajaProducto"
        Me.bajaProducto.Size = New System.Drawing.Size(183, 62)
        Me.bajaProducto.TabIndex = 9
        Me.bajaProducto.Text = "Dar de baja productos"
        Me.bajaProducto.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MintCream
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(93, 713)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(865, 213)
        Me.DataGridView1.TabIndex = 20
        '
        'VerProductos
        '
        Me.VerProductos.BackColor = System.Drawing.Color.Orange
        Me.VerProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.VerProductos.Location = New System.Drawing.Point(605, 184)
        Me.VerProductos.Name = "VerProductos"
        Me.VerProductos.Size = New System.Drawing.Size(176, 89)
        Me.VerProductos.TabIndex = 21
        Me.VerProductos.Text = "Ver Productos"
        Me.VerProductos.UseVisualStyleBackColor = False
        '
        'VerVentas
        '
        Me.VerVentas.BackColor = System.Drawing.Color.Orange
        Me.VerVentas.Location = New System.Drawing.Point(605, 80)
        Me.VerVentas.Name = "VerVentas"
        Me.VerVentas.Size = New System.Drawing.Size(176, 89)
        Me.VerVentas.TabIndex = 22
        Me.VerVentas.Text = "Ver Ventas"
        Me.VerVentas.UseVisualStyleBackColor = False
        '
        'VerVentasItems
        '
        Me.VerVentasItems.BackColor = System.Drawing.Color.Orange
        Me.VerVentasItems.Location = New System.Drawing.Point(820, 80)
        Me.VerVentasItems.Name = "VerVentasItems"
        Me.VerVentasItems.Size = New System.Drawing.Size(179, 89)
        Me.VerVentasItems.TabIndex = 23
        Me.VerVentasItems.Text = "Ver VentasItems"
        Me.VerVentasItems.UseVisualStyleBackColor = False
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.Color.LavenderBlush
        Me.Buscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Buscar.FlatAppearance.BorderSize = 2
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.Location = New System.Drawing.Point(452, 664)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(158, 43)
        Me.Buscar.TabIndex = 24
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = False
        '
        'ListBoxA
        '
        Me.ListBoxA.FormattingEnabled = True
        Me.ListBoxA.ItemHeight = 16
        Me.ListBoxA.Items.AddRange(New Object() {"clientes", "productos", "ventas", "ventasitems"})
        Me.ListBoxA.Location = New System.Drawing.Point(464, 338)
        Me.ListBoxA.Name = "ListBoxA"
        Me.ListBoxA.Size = New System.Drawing.Size(121, 68)
        Me.ListBoxA.TabIndex = 25
        '
        'ListBoxVentas
        '
        Me.ListBoxVentas.FormattingEnabled = True
        Me.ListBoxVentas.ItemHeight = 16
        Me.ListBoxVentas.Items.AddRange(New Object() {"ID", "IDCliente", "Fecha", "Total"})
        Me.ListBoxVentas.Location = New System.Drawing.Point(561, 511)
        Me.ListBoxVentas.Name = "ListBoxVentas"
        Me.ListBoxVentas.Size = New System.Drawing.Size(121, 68)
        Me.ListBoxVentas.TabIndex = 26
        '
        'ListBoxVentasItems
        '
        Me.ListBoxVentasItems.FormattingEnabled = True
        Me.ListBoxVentasItems.ItemHeight = 16
        Me.ListBoxVentasItems.Items.AddRange(New Object() {"IDVenta", "IDProducto", "PrecioUnitario", "PrecioTotal"})
        Me.ListBoxVentasItems.Location = New System.Drawing.Point(748, 511)
        Me.ListBoxVentasItems.Name = "ListBoxVentasItems"
        Me.ListBoxVentasItems.Size = New System.Drawing.Size(121, 68)
        Me.ListBoxVentasItems.TabIndex = 27
        '
        'ListBoxProductos
        '
        Me.ListBoxProductos.FormattingEnabled = True
        Me.ListBoxProductos.ItemHeight = 16
        Me.ListBoxProductos.Items.AddRange(New Object() {"ID", "Nombre", "Precio", "Categoria"})
        Me.ListBoxProductos.Location = New System.Drawing.Point(376, 511)
        Me.ListBoxProductos.Name = "ListBoxProductos"
        Me.ListBoxProductos.Size = New System.Drawing.Size(120, 68)
        Me.ListBoxProductos.TabIndex = 28
        '
        'ListBoxClientes
        '
        Me.ListBoxClientes.FormattingEnabled = True
        Me.ListBoxClientes.ItemHeight = 16
        Me.ListBoxClientes.Items.AddRange(New Object() {"ID", "Cliente", "Telefono", "Correo"})
        Me.ListBoxClientes.Location = New System.Drawing.Point(186, 511)
        Me.ListBoxClientes.Name = "ListBoxClientes"
        Me.ListBoxClientes.Size = New System.Drawing.Size(113, 68)
        Me.ListBoxClientes.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(600, 479)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SeaShell
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(762, 479)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "VentasItems"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SeaShell
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(399, 479)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Productos"
        '
        'Ingreso
        '
        Me.Ingreso.Location = New System.Drawing.Point(440, 624)
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.Size = New System.Drawing.Size(176, 22)
        Me.Ingreso.TabIndex = 33
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.SeaShell
        Me.Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label.Location = New System.Drawing.Point(205, 479)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(60, 19)
        Me.Label.TabIndex = 34
        Me.Label.Text = "Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SeaShell
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(423, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Seleccione que desea buscar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SeaShell
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(340, 442)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(398, 19)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Ahora seleccione segun el atributo que desea buscar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SeaShell
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(366, 591)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(326, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Ahora ingrese el atributo que desea buscar"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label7.Location = New System.Drawing.Point(12, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 170)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(69, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 19)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Ventas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Pink
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(268, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 19)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Clientes"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.PaleGreen
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(464, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 19)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Productos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Orange
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(774, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 19)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Datos"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.Location = New System.Drawing.Point(655, 9)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(0, 17)
        Me.LabelFecha.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chocolate
        Me.Button1.Location = New System.Drawing.Point(669, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 29)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Reporte"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1023, 995)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Ingreso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxClientes)
        Me.Controls.Add(Me.ListBoxProductos)
        Me.Controls.Add(Me.ListBoxVentasItems)
        Me.Controls.Add(Me.ListBoxVentas)
        Me.Controls.Add(Me.ListBoxA)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.VerVentasItems)
        Me.Controls.Add(Me.VerVentas)
        Me.Controls.Add(Me.VerProductos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bajaProducto)
        Me.Controls.Add(Me.modProducto)
        Me.Controls.Add(Me.bajaCliente)
        Me.Controls.Add(Me.modCliente)
        Me.Controls.Add(Me.bajaVenta)
        Me.Controls.Add(Me.modVenta)
        Me.Controls.Add(Me.ingProducto)
        Me.Controls.Add(Me.ingCliente)
        Me.Controls.Add(Me.ingVenta)
        Me.Controls.Add(Me.VerClientes)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "Sistema de Control de Stock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VerClientes As Button
    Friend WithEvents ingVenta As Button
    Friend WithEvents ingCliente As Button
    Friend WithEvents ingProducto As Button
    Friend WithEvents modVenta As Button
    Friend WithEvents bajaVenta As Button
    Friend WithEvents modCliente As Button
    Friend WithEvents bajaCliente As Button
    Friend WithEvents modProducto As Button
    Friend WithEvents bajaProducto As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VerProductos As Button
    Friend WithEvents VerVentas As Button
    Friend WithEvents VerVentasItems As Button
    Friend WithEvents Buscar As Button
    Friend WithEvents ListBoxA As ListBox
    Friend WithEvents ListBoxVentas As ListBox
    Friend WithEvents ListBoxVentasItems As ListBox
    Friend WithEvents ListBoxProductos As ListBox
    Friend WithEvents ListBoxClientes As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Ingreso As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents Button1 As Button
End Class

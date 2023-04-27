<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteMensual
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
        Me.DTVReporteMensual = New System.Windows.Forms.DataGridView()
        Me.IDProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Productos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DTVReporteMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTVReporteMensual
        '
        Me.DTVReporteMensual.BackgroundColor = System.Drawing.Color.Cornsilk
        Me.DTVReporteMensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTVReporteMensual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProducto, Me.Productos, Me.VentasMes})
        Me.DTVReporteMensual.Location = New System.Drawing.Point(184, 96)
        Me.DTVReporteMensual.Name = "DTVReporteMensual"
        Me.DTVReporteMensual.RowTemplate.Height = 24
        Me.DTVReporteMensual.Size = New System.Drawing.Size(489, 468)
        Me.DTVReporteMensual.TabIndex = 0
        '
        'IDProducto
        '
        Me.IDProducto.HeaderText = "IDProductos"
        Me.IDProducto.Name = "IDProducto"
        '
        'Productos
        '
        Me.Productos.HeaderText = "Productos"
        Me.Productos.Name = "Productos"
        Me.Productos.ReadOnly = True
        '
        'VentasMes
        '
        Me.VentasMes.HeaderText = "Ventas en el mes"
        Me.VentasMes.Name = "VentasMes"
        Me.VentasMes.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(644, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Informe de venta de productos por mes"
        '
        'ReporteMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(815, 610)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTVReporteMensual)
        Me.Name = "ReporteMensual"
        Me.Text = "ReporteMensual"
        CType(Me.DTVReporteMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTVReporteMensual As DataGridView
    Friend WithEvents IDProducto As DataGridViewTextBoxColumn
    Friend WithEvents Productos As DataGridViewTextBoxColumn
    Friend WithEvents VentasMes As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class

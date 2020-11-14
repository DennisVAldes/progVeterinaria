<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaMascota
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inCi = New System.Windows.Forms.TextBox()
        Me.inName = New System.Windows.Forms.TextBox()
        Me.inFecha = New System.Windows.Forms.TextBox()
        Me.labe12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.submitMascota = New System.Windows.Forms.Button()
        Me.closeWindow = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inIdMascota = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mascotas"
        '
        'inCi
        '
        Me.inCi.Location = New System.Drawing.Point(58, 139)
        Me.inCi.Name = "inCi"
        Me.inCi.Size = New System.Drawing.Size(319, 20)
        Me.inCi.TabIndex = 1
        '
        'inName
        '
        Me.inName.Location = New System.Drawing.Point(58, 244)
        Me.inName.Name = "inName"
        Me.inName.Size = New System.Drawing.Size(319, 20)
        Me.inName.TabIndex = 2
        '
        'inFecha
        '
        Me.inFecha.Location = New System.Drawing.Point(58, 301)
        Me.inFecha.Name = "inFecha"
        Me.inFecha.Size = New System.Drawing.Size(319, 20)
        Me.inFecha.TabIndex = 3
        '
        'labe12
        '
        Me.labe12.AutoSize = True
        Me.labe12.Location = New System.Drawing.Point(59, 118)
        Me.labe12.Name = "labe12"
        Me.labe12.Size = New System.Drawing.Size(57, 13)
        Me.labe12.TabIndex = 4
        Me.labe12.Text = "Ci persona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre mascota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Año nacimiento"
        '
        'submitMascota
        '
        Me.submitMascota.Location = New System.Drawing.Point(219, 370)
        Me.submitMascota.Name = "submitMascota"
        Me.submitMascota.Size = New System.Drawing.Size(148, 38)
        Me.submitMascota.TabIndex = 7
        Me.submitMascota.Text = "Aceptar"
        Me.submitMascota.UseVisualStyleBackColor = True
        '
        'closeWindow
        '
        Me.closeWindow.Location = New System.Drawing.Point(62, 370)
        Me.closeWindow.Name = "closeWindow"
        Me.closeWindow.Size = New System.Drawing.Size(148, 38)
        Me.closeWindow.TabIndex = 9
        Me.closeWindow.Text = "Cancelar"
        Me.closeWindow.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Id mascota"
        '
        'inIdMascota
        '
        Me.inIdMascota.Location = New System.Drawing.Point(58, 192)
        Me.inIdMascota.Name = "inIdMascota"
        Me.inIdMascota.Size = New System.Drawing.Size(319, 20)
        Me.inIdMascota.TabIndex = 10
        '
        'altaMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 451)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inIdMascota)
        Me.Controls.Add(Me.closeWindow)
        Me.Controls.Add(Me.submitMascota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labe12)
        Me.Controls.Add(Me.inFecha)
        Me.Controls.Add(Me.inName)
        Me.Controls.Add(Me.inCi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "altaMascota"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inCi As TextBox
    Friend WithEvents inName As TextBox
    Friend WithEvents inFecha As TextBox
    Friend WithEvents labe12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents submitMascota As Button
    Friend WithEvents closeWindow As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents inIdMascota As TextBox
End Class

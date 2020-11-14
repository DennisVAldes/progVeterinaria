<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarMascota
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.deleteMascota = New System.Windows.Forms.Button()
        Me.updateMascota = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ciModificar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.añoModificar = New System.Windows.Forms.TextBox()
        Me.nombreModificar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListMascotas = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreMascota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AñoNacimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CiDueño = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idMascota = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'deleteMascota
        '
        Me.deleteMascota.BackColor = System.Drawing.Color.Red
        Me.deleteMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteMascota.Location = New System.Drawing.Point(476, 319)
        Me.deleteMascota.Name = "deleteMascota"
        Me.deleteMascota.Size = New System.Drawing.Size(120, 43)
        Me.deleteMascota.TabIndex = 35
        Me.deleteMascota.Text = "Eliminar"
        Me.deleteMascota.UseVisualStyleBackColor = False
        '
        'updateMascota
        '
        Me.updateMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateMascota.Location = New System.Drawing.Point(602, 319)
        Me.updateMascota.Name = "updateMascota"
        Me.updateMascota.Size = New System.Drawing.Size(137, 43)
        Me.updateMascota.TabIndex = 34
        Me.updateMascota.Text = "Modificar"
        Me.updateMascota.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(480, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Ci de dueño"
        '
        'ciModificar
        '
        Me.ciModificar.Location = New System.Drawing.Point(476, 259)
        Me.ciModificar.Name = "ciModificar"
        Me.ciModificar.Size = New System.Drawing.Size(263, 20)
        Me.ciModificar.TabIndex = 29
        Me.ciModificar.Text = "  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(480, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Año de nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nombre"
        '
        'añoModificar
        '
        Me.añoModificar.Location = New System.Drawing.Point(476, 201)
        Me.añoModificar.Name = "añoModificar"
        Me.añoModificar.Size = New System.Drawing.Size(263, 20)
        Me.añoModificar.TabIndex = 25
        '
        'nombreModificar
        '
        Me.nombreModificar.Location = New System.Drawing.Point(476, 152)
        Me.nombreModificar.Name = "nombreModificar"
        Me.nombreModificar.Size = New System.Drawing.Size(263, 20)
        Me.nombreModificar.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 31)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Mascota seleccionada"
        '
        'ListMascotas
        '
        Me.ListMascotas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.NombreMascota, Me.AñoNacimiento, Me.CiDueño})
        Me.ListMascotas.HideSelection = False
        Me.ListMascotas.Location = New System.Drawing.Point(9, 15)
        Me.ListMascotas.Name = "ListMascotas"
        Me.ListMascotas.Size = New System.Drawing.Size(408, 509)
        Me.ListMascotas.TabIndex = 21
        Me.ListMascotas.UseCompatibleStateImageBehavior = False
        Me.ListMascotas.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = "Id"
        Me.Id.Width = 70
        '
        'NombreMascota
        '
        Me.NombreMascota.Text = "Nombre mascota"
        Me.NombreMascota.Width = 102
        '
        'AñoNacimiento
        '
        Me.AñoNacimiento.Text = "Año nacimiento"
        Me.AñoNacimiento.Width = 108
        '
        'CiDueño
        '
        Me.CiDueño.Text = "Ci dueño"
        Me.CiDueño.Width = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(480, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Mascota numero"
        '
        'idMascota
        '
        Me.idMascota.AutoSize = True
        Me.idMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idMascota.Location = New System.Drawing.Point(572, 89)
        Me.idMascota.Name = "idMascota"
        Me.idMascota.Size = New System.Drawing.Size(15, 13)
        Me.idMascota.TabIndex = 37
        Me.idMascota.Text = "X"
        '
        'modificarMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 543)
        Me.Controls.Add(Me.idMascota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.deleteMascota)
        Me.Controls.Add(Me.updateMascota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ciModificar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.añoModificar)
        Me.Controls.Add(Me.nombreModificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListMascotas)
        Me.Name = "modificarMascota"
        Me.Text = "Modificar mascota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents deleteMascota As Button
    Friend WithEvents updateMascota As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents añoModificar As TextBox
    Friend WithEvents nombreModificar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListMascotas As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents NombreMascota As ColumnHeader
    Friend WithEvents AñoNacimiento As ColumnHeader
    Friend WithEvents CiDueño As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents idMascota As Label
    Friend WithEvents ciModificar As TextBox
End Class

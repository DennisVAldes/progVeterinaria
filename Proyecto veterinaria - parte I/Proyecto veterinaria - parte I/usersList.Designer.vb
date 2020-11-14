<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usersList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usersList))
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.ListPersonas = New System.Windows.Forms.ListView()
        Me.Ci = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Dir = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ciModificar = New System.Windows.Forms.TextBox()
        Me.nombreModificar = New System.Windows.Forms.TextBox()
        Me.direccionModificar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listTelefonos = New System.Windows.Forms.ListView()
        Me.btnPlusTelefono = New System.Windows.Forms.Button()
        Me.inTell = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.resetTelsList = New System.Windows.Forms.Button()
        Me.updatePersona = New System.Windows.Forms.Button()
        Me.deletePersona = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'ListPersonas
        '
        Me.ListPersonas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Ci, Me.Nombre, Me.Dir})
        Me.ListPersonas.HideSelection = False
        Me.ListPersonas.Location = New System.Drawing.Point(12, 40)
        Me.ListPersonas.Name = "ListPersonas"
        Me.ListPersonas.Size = New System.Drawing.Size(389, 509)
        Me.ListPersonas.TabIndex = 4
        Me.ListPersonas.UseCompatibleStateImageBehavior = False
        Me.ListPersonas.View = System.Windows.Forms.View.Details
        '
        'Ci
        '
        Me.Ci.Text = "Ci"
        Me.Ci.Width = 91
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 156
        '
        'Dir
        '
        Me.Dir.Text = "Direccion"
        Me.Dir.Width = 137
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Persona seleccionada"
        '
        'ciModificar
        '
        Me.ciModificar.Location = New System.Drawing.Point(437, 116)
        Me.ciModificar.Name = "ciModificar"
        Me.ciModificar.Size = New System.Drawing.Size(263, 20)
        Me.ciModificar.TabIndex = 6
        '
        'nombreModificar
        '
        Me.nombreModificar.Location = New System.Drawing.Point(437, 159)
        Me.nombreModificar.Name = "nombreModificar"
        Me.nombreModificar.Size = New System.Drawing.Size(263, 20)
        Me.nombreModificar.TabIndex = 7
        '
        'direccionModificar
        '
        Me.direccionModificar.Location = New System.Drawing.Point(437, 203)
        Me.direccionModificar.Name = "direccionModificar"
        Me.direccionModificar.Size = New System.Drawing.Size(263, 20)
        Me.direccionModificar.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Ci"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Direccion"
        '
        'listTelefonos
        '
        Me.listTelefonos.HideSelection = False
        Me.listTelefonos.Location = New System.Drawing.Point(742, 243)
        Me.listTelefonos.Name = "listTelefonos"
        Me.listTelefonos.Size = New System.Drawing.Size(228, 93)
        Me.listTelefonos.TabIndex = 16
        Me.listTelefonos.UseCompatibleStateImageBehavior = False
        Me.listTelefonos.View = System.Windows.Forms.View.List
        '
        'btnPlusTelefono
        '
        Me.btnPlusTelefono.Location = New System.Drawing.Point(706, 243)
        Me.btnPlusTelefono.Name = "btnPlusTelefono"
        Me.btnPlusTelefono.Size = New System.Drawing.Size(30, 21)
        Me.btnPlusTelefono.TabIndex = 15
        Me.btnPlusTelefono.Text = "+"
        Me.btnPlusTelefono.UseVisualStyleBackColor = True
        '
        'inTell
        '
        Me.inTell.Location = New System.Drawing.Point(437, 243)
        Me.inTell.Name = "inTell"
        Me.inTell.Size = New System.Drawing.Size(263, 20)
        Me.inTell.TabIndex = 14
        Me.inTell.Text = "  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(441, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Telefono"
        '
        'resetTelsList
        '
        Me.resetTelsList.Location = New System.Drawing.Point(743, 350)
        Me.resetTelsList.Name = "resetTelsList"
        Me.resetTelsList.Size = New System.Drawing.Size(226, 26)
        Me.resetTelsList.TabIndex = 18
        Me.resetTelsList.Text = "Eliminar lista"
        Me.resetTelsList.UseVisualStyleBackColor = True
        '
        'updatePersona
        '
        Me.updatePersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatePersona.Location = New System.Drawing.Point(563, 414)
        Me.updatePersona.Name = "updatePersona"
        Me.updatePersona.Size = New System.Drawing.Size(137, 43)
        Me.updatePersona.TabIndex = 19
        Me.updatePersona.Text = "Modificar"
        Me.updatePersona.UseVisualStyleBackColor = True
        '
        'deletePersona
        '
        Me.deletePersona.BackColor = System.Drawing.Color.Red
        Me.deletePersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletePersona.Location = New System.Drawing.Point(437, 414)
        Me.deletePersona.Name = "deletePersona"
        Me.deletePersona.Size = New System.Drawing.Size(120, 43)
        Me.deletePersona.TabIndex = 20
        Me.deletePersona.Text = "Eliminar"
        Me.deletePersona.UseVisualStyleBackColor = False
        '
        'usersList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.deletePersona)
        Me.Controls.Add(Me.updatePersona)
        Me.Controls.Add(Me.resetTelsList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.listTelefonos)
        Me.Controls.Add(Me.btnPlusTelefono)
        Me.Controls.Add(Me.inTell)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.direccionModificar)
        Me.Controls.Add(Me.nombreModificar)
        Me.Controls.Add(Me.ciModificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListPersonas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 600)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "usersList"
        Me.Text = "LIstado de personas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents ListPersonas As ListView
    Friend WithEvents Ci As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Dir As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents ciModificar As TextBox
    Friend WithEvents nombreModificar As TextBox
    Friend WithEvents direccionModificar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents listTelefonos As ListView
    Friend WithEvents btnPlusTelefono As Button
    Friend WithEvents inTell As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents resetTelsList As Button
    Friend WithEvents updatePersona As Button
    Friend WithEvents deletePersona As Button
End Class

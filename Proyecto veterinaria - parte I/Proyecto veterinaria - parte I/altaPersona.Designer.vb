﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaPersona
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
        Me.inAddress = New System.Windows.Forms.TextBox()
        Me.inTell = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.submitUser = New System.Windows.Forms.Button()
        Me.closeWindow = New System.Windows.Forms.Button()
        Me.btnPlusTelefono = New System.Windows.Forms.Button()
        Me.listTelefonos = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Persona"
        '
        'inCi
        '
        Me.inCi.Location = New System.Drawing.Point(32, 117)
        Me.inCi.Name = "inCi"
        Me.inCi.Size = New System.Drawing.Size(262, 20)
        Me.inCi.TabIndex = 1
        '
        'inName
        '
        Me.inName.Location = New System.Drawing.Point(32, 174)
        Me.inName.Name = "inName"
        Me.inName.Size = New System.Drawing.Size(262, 20)
        Me.inName.TabIndex = 2
        '
        'inAddress
        '
        Me.inAddress.Location = New System.Drawing.Point(32, 226)
        Me.inAddress.Name = "inAddress"
        Me.inAddress.Size = New System.Drawing.Size(262, 20)
        Me.inAddress.TabIndex = 3
        '
        'inTell
        '
        Me.inTell.Location = New System.Drawing.Point(32, 284)
        Me.inTell.Name = "inTell"
        Me.inTell.Size = New System.Drawing.Size(262, 20)
        Me.inTell.TabIndex = 4
        Me.inTell.Text = "  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Direccion"
        '
        'submitUser
        '
        Me.submitUser.Location = New System.Drawing.Point(180, 349)
        Me.submitUser.Name = "submitUser"
        Me.submitUser.Size = New System.Drawing.Size(114, 48)
        Me.submitUser.TabIndex = 9
        Me.submitUser.Text = "Aceptar"
        Me.submitUser.UseVisualStyleBackColor = True
        '
        'closeWindow
        '
        Me.closeWindow.Location = New System.Drawing.Point(32, 349)
        Me.closeWindow.Name = "closeWindow"
        Me.closeWindow.Size = New System.Drawing.Size(121, 48)
        Me.closeWindow.TabIndex = 11
        Me.closeWindow.Text = "Cancelar"
        Me.closeWindow.UseVisualStyleBackColor = True
        '
        'btnPlusTelefono
        '
        Me.btnPlusTelefono.Location = New System.Drawing.Point(324, 284)
        Me.btnPlusTelefono.Name = "btnPlusTelefono"
        Me.btnPlusTelefono.Size = New System.Drawing.Size(106, 27)
        Me.btnPlusTelefono.TabIndex = 12
        Me.btnPlusTelefono.Text = "+"
        Me.btnPlusTelefono.UseVisualStyleBackColor = True
        '
        'listTelefonos
        '
        Me.listTelefonos.HideSelection = False
        Me.listTelefonos.Location = New System.Drawing.Point(458, 284)
        Me.listTelefonos.Name = "listTelefonos"
        Me.listTelefonos.Size = New System.Drawing.Size(256, 158)
        Me.listTelefonos.TabIndex = 13
        Me.listTelefonos.UseCompatibleStateImageBehavior = False
        Me.listTelefonos.View = System.Windows.Forms.View.List
        '
        'altaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 498)
        Me.Controls.Add(Me.listTelefonos)
        Me.Controls.Add(Me.btnPlusTelefono)
        Me.Controls.Add(Me.closeWindow)
        Me.Controls.Add(Me.submitUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.inTell)
        Me.Controls.Add(Me.inAddress)
        Me.Controls.Add(Me.inName)
        Me.Controls.Add(Me.inCi)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(742, 537)
        Me.MinimumSize = New System.Drawing.Size(742, 537)
        Me.Name = "altaPersona"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inCi As TextBox
    Friend WithEvents inName As TextBox
    Friend WithEvents inAddress As TextBox
    Friend WithEvents inTell As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents submitUser As Button
    Friend WithEvents closeWindow As Button
    Friend WithEvents btnPlusTelefono As Button
    Friend WithEvents listTelefonos As ListView
End Class

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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.searchUser = New System.Windows.Forms.TextBox()
        Me.btnSearchUser = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Ci = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Dir = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(789, 330)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(16, 4)
        Me.CheckedListBox1.TabIndex = 1
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'searchUser
        '
        Me.searchUser.Location = New System.Drawing.Point(12, 12)
        Me.searchUser.Name = "searchUser"
        Me.searchUser.Size = New System.Drawing.Size(332, 20)
        Me.searchUser.TabIndex = 2
        '
        'btnSearchUser
        '
        Me.btnSearchUser.Location = New System.Drawing.Point(363, 12)
        Me.btnSearchUser.Name = "btnSearchUser"
        Me.btnSearchUser.Size = New System.Drawing.Size(116, 19)
        Me.btnSearchUser.TabIndex = 3
        Me.btnSearchUser.Text = "Buscar ci"
        Me.btnSearchUser.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Ci, Me.Nombre, Me.Dir})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 100)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(399, 319)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'usersList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnSearchUser)
        Me.Controls.Add(Me.searchUser)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Name = "usersList"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents searchUser As TextBox
    Friend WithEvents btnSearchUser As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Ci As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Dir As ColumnHeader
End Class

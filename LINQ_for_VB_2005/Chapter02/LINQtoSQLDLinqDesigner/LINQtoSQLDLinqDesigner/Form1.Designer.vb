<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgPerson = New System.Windows.Forms.DataGridView
        Me.dgRole = New System.Windows.Forms.DataGridView
        CType(Me.dgPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPerson
        '
        Me.dgPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPerson.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgPerson.Location = New System.Drawing.Point(0, 200)
        Me.dgPerson.Name = "dgPerson"
        Me.dgPerson.Size = New System.Drawing.Size(679, 150)
        Me.dgPerson.TabIndex = 3
        '
        'dgRole
        '
        Me.dgRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRole.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgRole.Location = New System.Drawing.Point(0, 0)
        Me.dgRole.Name = "dgRole"
        Me.dgRole.Size = New System.Drawing.Size(679, 150)
        Me.dgRole.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 350)
        Me.Controls.Add(Me.dgPerson)
        Me.Controls.Add(Me.dgRole)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dgPerson As System.Windows.Forms.DataGridView
    Private WithEvents dgRole As System.Windows.Forms.DataGridView

End Class

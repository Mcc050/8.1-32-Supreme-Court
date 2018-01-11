<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJustices
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
        Me.btnCLick = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCLick
        '
        Me.btnCLick.Location = New System.Drawing.Point(86, 37)
        Me.btnCLick.Name = "btnCLick"
        Me.btnCLick.Size = New System.Drawing.Size(181, 62)
        Me.btnCLick.TabIndex = 0
        Me.btnCLick.Text = "Click to generate file"
        Me.btnCLick.UseVisualStyleBackColor = True
        '
        'frmJustices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 130)
        Me.Controls.Add(Me.btnCLick)
        Me.Name = "frmJustices"
        Me.Text = "Supreme Court Justices"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCLick As System.Windows.Forms.Button

End Class

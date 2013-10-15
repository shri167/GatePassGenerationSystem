<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionScreen
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
        Me.SelectionCombo1 = New System.Windows.Forms.ComboBox()
        Me.SelectB1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SelectionCombo1
        '
        Me.SelectionCombo1.Enabled = False
        Me.SelectionCombo1.FormattingEnabled = True
        Me.SelectionCombo1.Items.AddRange(New Object() {"Visitor", "Vehicle"})
        Me.SelectionCombo1.Location = New System.Drawing.Point(368, 265)
        Me.SelectionCombo1.Name = "SelectionCombo1"
        Me.SelectionCombo1.Size = New System.Drawing.Size(253, 30)
        Me.SelectionCombo1.TabIndex = 0
        Me.SelectionCombo1.Text = "Please Select An Option"
        '
        'SelectB1
        '
        Me.SelectB1.Location = New System.Drawing.Point(381, 334)
        Me.SelectB1.Name = "SelectB1"
        Me.SelectB1.Size = New System.Drawing.Size(221, 37)
        Me.SelectB1.TabIndex = 1
        Me.SelectB1.Text = "OK"
        Me.SelectB1.UseVisualStyleBackColor = True
        '
        'SelectionScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 1002)
        Me.Controls.Add(Me.SelectB1)
        Me.Controls.Add(Me.SelectionCombo1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "SelectionScreen"
        Me.Text = "SelectionScreen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SelectionCombo1 As System.Windows.Forms.ComboBox
    Friend WithEvents SelectB1 As System.Windows.Forms.Button
End Class

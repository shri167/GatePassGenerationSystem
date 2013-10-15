<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.Login_B1 = New System.Windows.Forms.Button()
        Me.Login_TB2 = New System.Windows.Forms.TextBox()
        Me.Login_L2 = New System.Windows.Forms.Label()
        Me.Login_TB1 = New System.Windows.Forms.TextBox()
        Me.Login_L1 = New System.Windows.Forms.Label()
        Me.GB1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB1
        '
        Me.GB1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GB1.Controls.Add(Me.Login_B1)
        Me.GB1.Controls.Add(Me.Login_TB2)
        Me.GB1.Controls.Add(Me.Login_L2)
        Me.GB1.Controls.Add(Me.Login_TB1)
        Me.GB1.Controls.Add(Me.Login_L1)
        Me.GB1.Location = New System.Drawing.Point(255, 171)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(504, 359)
        Me.GB1.TabIndex = 0
        Me.GB1.TabStop = False
        Me.GB1.Text = "Enter Details"
        '
        'Login_B1
        '
        Me.Login_B1.Location = New System.Drawing.Point(103, 260)
        Me.Login_B1.Name = "Login_B1"
        Me.Login_B1.Size = New System.Drawing.Size(303, 41)
        Me.Login_B1.TabIndex = 4
        Me.Login_B1.Text = "Login"
        Me.Login_B1.UseVisualStyleBackColor = True
        '
        'Login_TB2
        '
        Me.Login_TB2.Location = New System.Drawing.Point(233, 166)
        Me.Login_TB2.Name = "Login_TB2"
        Me.Login_TB2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Login_TB2.Size = New System.Drawing.Size(231, 29)
        Me.Login_TB2.TabIndex = 3
        '
        'Login_L2
        '
        Me.Login_L2.AutoSize = True
        Me.Login_L2.Location = New System.Drawing.Point(31, 171)
        Me.Login_L2.Name = "Login_L2"
        Me.Login_L2.Size = New System.Drawing.Size(94, 22)
        Me.Login_L2.TabIndex = 2
        Me.Login_L2.Text = "Password"
        '
        'Login_TB1
        '
        Me.Login_TB1.Location = New System.Drawing.Point(235, 59)
        Me.Login_TB1.Name = "Login_TB1"
        Me.Login_TB1.Size = New System.Drawing.Size(230, 29)
        Me.Login_TB1.TabIndex = 1
        '
        'Login_L1
        '
        Me.Login_L1.AutoSize = True
        Me.Login_L1.Location = New System.Drawing.Point(31, 71)
        Me.Login_L1.Name = "Login_L1"
        Me.Login_L1.Size = New System.Drawing.Size(75, 22)
        Me.Login_L1.TabIndex = 0
        Me.Login_L1.Text = "User ID"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 717)
        Me.Controls.Add(Me.GB1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Login"
        Me.Text = "LoginForm"
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents Login_B1 As System.Windows.Forms.Button
    Friend WithEvents Login_TB2 As System.Windows.Forms.TextBox
    Friend WithEvents Login_L2 As System.Windows.Forms.Label
    Friend WithEvents Login_TB1 As System.Windows.Forms.TextBox
    Friend WithEvents Login_L1 As System.Windows.Forms.Label

End Class

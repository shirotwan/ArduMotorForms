<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.UserL = New System.Windows.Forms.Label()
        Me.PasL = New System.Windows.Forms.Label()
        Me.Language = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Pas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UserL
        '
        Me.UserL.AutoSize = True
        Me.UserL.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UserL.Location = New System.Drawing.Point(39, 83)
        Me.UserL.Name = "UserL"
        Me.UserL.Size = New System.Drawing.Size(150, 38)
        Me.UserL.TabIndex = 0
        Me.UserL.Text = "Usuario"
        '
        'PasL
        '
        Me.PasL.AutoSize = True
        Me.PasL.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PasL.Location = New System.Drawing.Point(39, 173)
        Me.PasL.Name = "PasL"
        Me.PasL.Size = New System.Drawing.Size(213, 38)
        Me.PasL.TabIndex = 1
        Me.PasL.Text = "Contraseña"
        '
        'Language
        '
        Me.Language.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Language.FormattingEnabled = True
        Me.Language.Items.AddRange(New Object() {"Engilsh/English", "Japanese/日本語", "Korean/한국어", "Spanish/Español"})
        Me.Language.Location = New System.Drawing.Point(46, 279)
        Me.Language.Name = "Language"
        Me.Language.Size = New System.Drawing.Size(172, 30)
        Me.Language.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("UD Digi Kyokasho N-R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Language"
        '
        'User
        '
        Me.User.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(350, 80)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(309, 41)
        Me.User.TabIndex = 4
        '
        'Pas
        '
        Me.Pas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pas.Location = New System.Drawing.Point(350, 170)
        Me.Pas.Name = "Pas"
        Me.Pas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(12539)
        Me.Pas.Size = New System.Drawing.Size(309, 41)
        Me.Pas.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Pas)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Language)
        Me.Controls.Add(Me.PasL)
        Me.Controls.Add(Me.UserL)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserL As Label
    Friend WithEvents PasL As Label
    Friend WithEvents Language As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents User As TextBox
    Friend WithEvents Pas As TextBox
End Class

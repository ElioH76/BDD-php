<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtcmdQuitt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboNomEtPrenomActeur = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(647, 143)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(143, 20)
        Me.txt1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(670, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Connexion :"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtcmdQuitt
        '
        Me.ButtcmdQuitt.Location = New System.Drawing.Point(814, 587)
        Me.ButtcmdQuitt.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtcmdQuitt.Name = "ButtcmdQuitt"
        Me.ButtcmdQuitt.Size = New System.Drawing.Size(206, 99)
        Me.ButtcmdQuitt.TabIndex = 19
        Me.ButtcmdQuitt.Text = "Quitter"
        Me.ButtcmdQuitt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Liste des acteurs"
        '
        'cboNomEtPrenomActeur
        '
        Me.cboNomEtPrenomActeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNomEtPrenomActeur.FormattingEnabled = True
        Me.cboNomEtPrenomActeur.Location = New System.Drawing.Point(194, 73)
        Me.cboNomEtPrenomActeur.Margin = New System.Windows.Forms.Padding(2)
        Me.cboNomEtPrenomActeur.Name = "cboNomEtPrenomActeur"
        Me.cboNomEtPrenomActeur.Size = New System.Drawing.Size(219, 28)
        Me.cboNomEtPrenomActeur.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(204, 272)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 697)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ButtcmdQuitt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboNomEtPrenomActeur)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtcmdQuitt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboNomEtPrenomActeur As ComboBox
    Friend WithEvents TextBox2 As TextBox
End Class

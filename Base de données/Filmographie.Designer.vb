<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilmographie
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
        Me.dgvFilmographie = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActeurRecherche = New System.Windows.Forms.Label()
        CType(Me.dgvFilmographie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFilmographie
        '
        Me.dgvFilmographie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFilmographie.Location = New System.Drawing.Point(58, 190)
        Me.dgvFilmographie.Name = "dgvFilmographie"
        Me.dgvFilmographie.RowTemplate.Height = 24
        Me.dgvFilmographie.Size = New System.Drawing.Size(346, 212)
        Me.dgvFilmographie.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Liste des films dans lesquels à joué "
        '
        'ActeurRecherche
        '
        Me.ActeurRecherche.AutoSize = True
        Me.ActeurRecherche.Location = New System.Drawing.Point(296, 51)
        Me.ActeurRecherche.Name = "ActeurRecherche"
        Me.ActeurRecherche.Size = New System.Drawing.Size(51, 17)
        Me.ActeurRecherche.TabIndex = 2
        Me.ActeurRecherche.Text = "Label2"
        '
        'frmFilmographie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ActeurRecherche)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvFilmographie)
        Me.Name = "frmFilmographie"
        Me.Text = "Filmographie"
        CType(Me.dgvFilmographie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvFilmographie As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ActeurRecherche As Label
End Class

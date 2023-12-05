<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.code = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.Label()
        Me.Prenom = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_afficher = New System.Windows.Forms.Button()
        Me.btn_recherche = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'code
        '
        Me.code.AutoSize = True
        Me.code.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Location = New System.Drawing.Point(35, 85)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(48, 18)
        Me.code.TabIndex = 0
        Me.code.Text = "Code"
        '
        'nom
        '
        Me.nom.AutoSize = True
        Me.nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(35, 139)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(44, 18)
        Me.nom.TabIndex = 1
        Me.nom.Text = "Nom"
        '
        'Prenom
        '
        Me.Prenom.AutoSize = True
        Me.Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prenom.Location = New System.Drawing.Point(39, 196)
        Me.Prenom.Name = "Prenom"
        Me.Prenom.Size = New System.Drawing.Size(67, 18)
        Me.Prenom.TabIndex = 2
        Me.Prenom.Text = "Prénom"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(117, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(117, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(160, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(117, 194)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(160, 20)
        Me.TextBox3.TabIndex = 5
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Location = New System.Drawing.Point(296, 300)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(102, 44)
        Me.btn_ajouter.TabIndex = 6
        Me.btn_ajouter.Text = "ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_afficher
        '
        Me.btn_afficher.Location = New System.Drawing.Point(458, 300)
        Me.btn_afficher.Name = "btn_afficher"
        Me.btn_afficher.Size = New System.Drawing.Size(114, 44)
        Me.btn_afficher.TabIndex = 7
        Me.btn_afficher.Text = "afficher "
        Me.btn_afficher.UseVisualStyleBackColor = True
        '
        'btn_recherche
        '
        Me.btn_recherche.Location = New System.Drawing.Point(627, 300)
        Me.btn_recherche.Name = "btn_recherche"
        Me.btn_recherche.Size = New System.Drawing.Size(108, 44)
        Me.btn_recherche.TabIndex = 8
        Me.btn_recherche.Text = "Rechercher"
        Me.btn_recherche.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_recherche)
        Me.Controls.Add(Me.btn_afficher)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Prenom)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.code)
        Me.Name = "Form2"
        Me.Text = "gestion patient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents code As Label
    Friend WithEvents nom As Label
    Friend WithEvents Prenom As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button
    Friend WithEvents btn_recherche As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.components = New System.ComponentModel.Container()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.l_nom = New System.Windows.Forms.Label()
        Me.l_prenom = New System.Windows.Forms.Label()
        Me.l_adresse = New System.Windows.Forms.Label()
        Me.femme = New System.Windows.Forms.CheckBox()
        Me.homme = New System.Windows.Forms.CheckBox()
        Me.box_nom = New System.Windows.Forms.TextBox()
        Me.box_prenom = New System.Windows.Forms.TextBox()
        Me.box_adresse = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.list_hopital = New System.Windows.Forms.ComboBox()
        Me.annuler = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.gestion_hopital.My.Resources.Resources.hh
        Me.PictureBox1.Location = New System.Drawing.Point(212, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 124)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'l_nom
        '
        Me.l_nom.AutoSize = True
        Me.l_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_nom.Location = New System.Drawing.Point(29, 166)
        Me.l_nom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_nom.Name = "l_nom"
        Me.l_nom.Size = New System.Drawing.Size(54, 18)
        Me.l_nom.TabIndex = 1
        Me.l_nom.Text = "Nom :"
        '
        'l_prenom
        '
        Me.l_prenom.AutoSize = True
        Me.l_prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_prenom.Location = New System.Drawing.Point(29, 208)
        Me.l_prenom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_prenom.Name = "l_prenom"
        Me.l_prenom.Size = New System.Drawing.Size(77, 18)
        Me.l_prenom.TabIndex = 2
        Me.l_prenom.Text = "Prénom :"
        '
        'l_adresse
        '
        Me.l_adresse.AutoSize = True
        Me.l_adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_adresse.Location = New System.Drawing.Point(29, 250)
        Me.l_adresse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_adresse.Name = "l_adresse"
        Me.l_adresse.Size = New System.Drawing.Size(79, 18)
        Me.l_adresse.TabIndex = 3
        Me.l_adresse.Text = "Adresse :"
        '
        'femme
        '
        Me.femme.AutoSize = True
        Me.femme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femme.Location = New System.Drawing.Point(470, 189)
        Me.femme.Margin = New System.Windows.Forms.Padding(2)
        Me.femme.Name = "femme"
        Me.femme.Size = New System.Drawing.Size(83, 22)
        Me.femme.TabIndex = 4
        Me.femme.Text = "Femme"
        Me.femme.UseVisualStyleBackColor = True
        '
        'homme
        '
        Me.homme.AutoSize = True
        Me.homme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homme.Location = New System.Drawing.Point(470, 233)
        Me.homme.Margin = New System.Windows.Forms.Padding(2)
        Me.homme.Name = "homme"
        Me.homme.Size = New System.Drawing.Size(86, 22)
        Me.homme.TabIndex = 5
        Me.homme.Text = "Homme"
        Me.homme.UseVisualStyleBackColor = True
        '
        'box_nom
        '
        Me.box_nom.Location = New System.Drawing.Point(121, 167)
        Me.box_nom.Margin = New System.Windows.Forms.Padding(2)
        Me.box_nom.Name = "box_nom"
        Me.box_nom.Size = New System.Drawing.Size(224, 20)
        Me.box_nom.TabIndex = 6
        '
        'box_prenom
        '
        Me.box_prenom.Location = New System.Drawing.Point(121, 208)
        Me.box_prenom.Margin = New System.Windows.Forms.Padding(2)
        Me.box_prenom.Name = "box_prenom"
        Me.box_prenom.Size = New System.Drawing.Size(224, 20)
        Me.box_prenom.TabIndex = 7
        '
        'box_adresse
        '
        Me.box_adresse.Location = New System.Drawing.Point(121, 252)
        Me.box_adresse.Margin = New System.Windows.Forms.Padding(2)
        Me.box_adresse.Name = "box_adresse"
        Me.box_adresse.Size = New System.Drawing.Size(224, 20)
        Me.box_adresse.TabIndex = 8
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(476, 321)
        Me.submit.Margin = New System.Windows.Forms.Padding(2)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(70, 27)
        Me.submit.TabIndex = 9
        Me.submit.Text = "submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'list_hopital
        '
        Me.list_hopital.FormattingEnabled = True
        Me.list_hopital.Items.AddRange(New Object() {"consultation", "IRM", "operation", "cas d'urgence", "visite"})
        Me.list_hopital.Location = New System.Drawing.Point(253, 309)
        Me.list_hopital.Margin = New System.Windows.Forms.Padding(2)
        Me.list_hopital.Name = "list_hopital"
        Me.list_hopital.Size = New System.Drawing.Size(92, 21)
        Me.list_hopital.TabIndex = 10
        '
        'annuler
        '
        Me.annuler.Location = New System.Drawing.Point(381, 323)
        Me.annuler.Name = "annuler"
        Me.annuler.Size = New System.Drawing.Size(75, 23)
        Me.annuler.TabIndex = 11
        Me.annuler.Text = "annuler"
        Me.annuler.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.annuler)
        Me.Controls.Add(Me.list_hopital)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.box_adresse)
        Me.Controls.Add(Me.box_prenom)
        Me.Controls.Add(Me.box_nom)
        Me.Controls.Add(Me.homme)
        Me.Controls.Add(Me.femme)
        Me.Controls.Add(Me.l_adresse)
        Me.Controls.Add(Me.l_prenom)
        Me.Controls.Add(Me.l_nom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "menu"
        Me.Text = "menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents l_nom As Label
    Friend WithEvents l_prenom As Label
    Friend WithEvents l_adresse As Label
    Friend WithEvents femme As CheckBox
    Friend WithEvents homme As CheckBox
    Friend WithEvents box_nom As TextBox
    Friend WithEvents box_prenom As TextBox
    Friend WithEvents box_adresse As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents list_hopital As ComboBox
    Friend WithEvents annuler As Button
End Class

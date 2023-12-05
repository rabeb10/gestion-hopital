Public Class Form2


    Structure Patient
            Dim Code As Integer
            Dim Nom As String
            Dim Prenom As String

    End Structure


    Dim tableauPatients(99) As Patient
        Dim nombrePatients As Integer = 0


    Function AjoutPatient(ByVal nouveauPatient As Patient) As Boolean
        If nombrePatients >= tableauPatients.Length Then
            MessageBox.Show("Le tableau est saturé")
            Return False
        End If
        For i As Integer = 0 To nombrePatients - 1
            If tableauPatients(i).Code = nouveauPatient.Code Then
                MessageBox.Show("Le code du patient existe déjà dans le tableau. Veuillez choisir un code unique")
                Return False
            End If
        Next
        tableauPatients(nombrePatients) = nouveauPatient
        nombrePatients += 1
        Return True
    End Function

    ' Exemple d'utilisation de la fonction AjoutPatient
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click

        Dim nouveauPatient As New Patient With {
            .Code = 111,
            .Nom = "rabeb",
            .Prenom = "mersani"
        }

        If AjoutPatient(nouveauPatient) Then
            MessageBox.Show("Le patient a été ajouté avec succès")
        End If
    End Sub
    Sub AfficherPatients(ByVal dataGridView As DataGridView)
        dataGridView.Rows.Clear()
        For i As Integer = 0 To nombrePatients - 1
            Dim patient As Patient = tableauPatients(i)
            dataGridView.Rows.Add(patient.Code, patient.Nom, patient.Prenom)
        Next
    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        AfficherPatients(dataGridView1)
    End Sub
    Sub RechercherPatients(ByVal dataGridView As DataGridView, ByVal nomRecherche As String, ByVal prenomRecherche As String, ByVal codeRecherche As Integer)
        dataGridView.Rows.Clear()

        For i As Integer = 0 To nombrePatients - 1
            Dim patient As Patient = tableauPatients(i)
            Dim correspondNom As Boolean = String.IsNullOrEmpty(nomRecherche) OrElse patient.Nom.ToLower().Contains(nomRecherche.ToLower())
            Dim correspondPrenom As Boolean = String.IsNullOrEmpty(prenomRecherche) OrElse patient.Prenom.ToLower().Contains(prenomRecherche.ToLower())
            Dim correspondCode As Boolean = codeRecherche = 0 OrElse patient.Code = codeRecherche

            If correspondNom AndAlso correspondPrenom AndAlso correspondCode Then
                dataGridView.Rows.Add(patient.Code, patient.Nom, patient.Prenom)
            End If
        Next
    End Sub
    Private Sub btn_recherche_Click(sender As Object, e As EventArgs) Handles btn_recherche.Click

        Dim nomRecherche As String = txtNomRecherche.Text
        Dim prenomRecherche As String = txtPrenomRecherche.Text
        Dim codeRecherche As Integer
        If Integer.TryParse(txtCodeRecherche.Text, codeRecherche) = False Then
            codeRecherche = 0
        End If
        RechercherPatients(dataGridView1, nomRecherche, prenomRecherche, codeRecherche)
    End Sub
End Class

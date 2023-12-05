Public Class menu
    Dim box_nom As String
    Dim box_prenom As String
    Dim box_adresse As String

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    Private Sub init()
        box_nom.Clear()
        box_prenom.Clear()
        box_adresse.Clear()
    End Sub


    Private Sub annuler_Click(sender As Object, e As EventArgs) Handles annuler.Click
        init()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim box_nom As String = box_nom
        Dim box_prenom As String = box_prenom
        Dim box_adresse As String = box_adresse
        Dim selectedHospital As String = list_hopital.SelectedItem.ToString()
        If Not String.IsNullOrEmpty(selectedHospital) Then
            MessageBox.Show($"Selected Hospital: {selectedHospital}", "Information")
        Else
            MessageBox.Show("Please select a hospital.", "Warning")
        End If
    End Sub
    Private Sub list_hopital_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_hopital.SelectedIndexChanged
        list_hopital.Items.Add("conslultation")
        list_hopital.Items.Add("IRM")
        list_hopital.Items.Add("cas d'urgence")
        list_hopital.Items.Add("operation")
        list_hopital.Items.Add("visite")
    End Sub
    End Sub

End Class

Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Filmographie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaConnection.Open()

        txt1.Text = MaConnection.State.ToString

        MaConnection.Close()
    End Sub
    Private Sub txt1_Click(sender As Object, e As EventArgs) Handles txt1.Click
        MaConnection.Open()

        txt1.Text = MaConnection.State.ToString

        MaConnection.Close()

    End Sub
    Private Sub Acteurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        MaConnection.Open()

        Dim MaCommandeSql As New MySqlCommand("Select actor_id, first_name, last_name from actor", MaConnection)

        MonReader = MaCommandeSql.ExecuteReader()


        While (MonReader.Read())

            cboNomEtPrenomActeur.Items.Add(MonReader.GetString(0) + " " + MonReader.GetString(1) + " " + MonReader.GetString(2))

        End While


        MaConnection.Close()

    End Sub
    Private Sub cboNomEtPrenomActeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNomEtPrenomActeur.SelectedIndexChanged

        Dim ValeurRetournee As String = cboNomEtPrenomActeur.SelectedItem.ToString
        TextBox2.Text = cboNomEtPrenomActeur.SelectedItem


    End Sub
    Private Sub ButtcmdQuitt_Click(sender As Object, e As EventArgs) Handles ButtcmdQuitt.Click
        Application.Exit()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click

    End Sub
End Class

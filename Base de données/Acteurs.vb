Imports MySql.Data.MySqlClient

Public Class Acteurs



    Private Sub ButtcmdQuitt_Click(sender As Object, e As EventArgs) Handles ButtcmdQuitt.Click
        Application.Exit()
    End Sub

    Private Sub Acteurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        MaConnection.Open()

        lblStatus.Text = MaConnection.State.ToString


        Dim MaCommandeSql As New MySqlCommand("Select actor_id,first_name, last_name from actor", MaConnection)



        MonReader = MaCommandeSql.ExecuteReader()

        dgvActeur.Columns.Add("id", "ID")
        dgvActeur.Columns.Add("nom", "Nom")
        dgvActeur.Columns.Add("Prenom", "Prenom")

        While (MonReader.Read())

            cboNomEtPrenomActeur.Items.Add(MonReader.GetString(0) + " " + MonReader.GetString(1) + " " + MonReader.GetString(2))
            dgvActeur.Rows.Add(MonReader.GetString(0), MonReader.GetString(1), MonReader.GetString(2))

        End While

        MaConnection.Close()

    End Sub

    Private Sub dgvActeur_click(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActeur.CellClick
        lblNumactDgv.Text = dgvActeur.Rows(dgvActeur.CurrentCell.RowIndex).Cells(0).Value
        NumActeur = Convert.ToInt16(lblNumactDgv.Text)

    End Sub



    Private Sub cboNomEtPrenomActeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNomEtPrenomActeur.SelectedIndexChanged

        Dim ValeurRetournee As String = cboNomEtPrenomActeur.SelectedItem.ToString
        lblActeurLst.Text = cboNomEtPrenomActeur.SelectedItem

        lstNbCar.Text = InStr(cboNomEtPrenomActeur.SelectedItem, " ")
        lblNumActeurLst.Text = ValeurRetournee.Substring(0, Convert.ToInt16(lstNbCar.Text) - 1)
    End Sub

    Private Sub cmdFilmographie_Click(sender As Object, e As EventArgs) Handles cmdFilmographie.Click
        frmFilmographie.Show()
    End Sub


End Class

Imports MySql.Data.MySqlClient


Public Class frmFilmographie


    Private Sub Filmographie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaConnection.Open()

        Dim MaCommandeSql As New MySqlCommand("select title from film inner join film_actor on film.film_id=film_actor.film_id inner join actor on film_actor.actor_id=actor.actor_id and actor.actor_id=" & NumActeur, MaConnection)

        Dim MonReader As MySqlDataReader

        MonReader = MaCommandeSql.ExecuteReader()
        dgvFilmographie.Columns.Add("FILM", "Film")
        While (MonReader.Read())
            dgvFilmographie.Rows.Add(MonReader.GetString(0))
        End While
        MaConnection.Close()
    End Sub
End Class
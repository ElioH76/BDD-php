Imports MySql.Data.MySqlClient


Module ModulepourEchangeDeVariable
    Public NumActeur As Int32
    Public MaConnection As New MySqlConnection("Server=localhost;Database=Sakila;Uid=root;pwd=;")
    Public MonReader As MySqlDataReader
End Module

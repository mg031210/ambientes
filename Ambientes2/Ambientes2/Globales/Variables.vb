Imports MySql.Data.MySqlClient

Module Variables
    Public cnx As New MySqlConnection
    Public session As Object
    Public esregistro As Boolean
    Public costoCat As Integer = 10
    Public costoEst As Integer = 50
    Public tipoCat As String = "C"
    Public tipoEst As String = "E"
    Public CostoMembresia As Integer = 100
    Public isadmin As Boolean = False

End Module

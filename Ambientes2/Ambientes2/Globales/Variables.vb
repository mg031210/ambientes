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
    Public isventa As Boolean = False
    Public isrenta As Boolean = False
    Public isdevol As Boolean = False
    Public iscompra As Boolean = False
    Public diasEstreno As Integer = 3
    Public diasCatalogo As Integer = 5
    Public compra As Integer = 30
    'estreno 3 y normal 5
End Module

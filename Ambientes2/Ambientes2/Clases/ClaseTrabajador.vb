Imports MySql.Data.MySqlClient

Public Class ClaseTrabajador

    Dim tabla As String = "trabajador"
    Public Sub New()
    End Sub

    Public Sub inserta(ByVal numtrabajador As String, ByVal usuario As String, ByVal contraseña As String, ByVal nombre As String, ByVal apep As String, ByVal apem As String, ByVal tel As String, ByVal cel As String, ByVal dir As String)
        Dim strSql As String
        strSql = "INSERT INTO " & tabla & " (numtrabajador,usuario,contrasena,nombre,apellidop,apellidom,telefono,celular,direccion) " &
                "VALUES('" & numtrabajador & "','" & usuario & "','" & contraseña & "','" & nombre & "','" & apep & "','" & apem & "','" & tel & "','" & cel & "','" & dir & "');"
        Dim xCnx As New Conexion
        xCnx.queryStr(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
End Class

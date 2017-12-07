Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class ClaseTrabajador
    Dim columnas As String = "idusuario as Trabajador,usuario as Usuario, contrasena as Contraseña, nombre as Nombre, apellidop as Paterno, apellidom as Materno, telefono as Telefono, celular as Celular, direccion as Direccion"
    Dim nombreid As String = "idusuario"
    Dim tabla As String = "trabajador"
    Public Sub New()
    End Sub

    Public Sub inserta(ByVal usuario As String, ByVal contraseña As String, ByVal nombre As String, ByVal apep As String, ByVal apem As String, ByVal tel As String, ByVal cel As String, ByVal dir As String)
        Dim strSql As String
        strSql = "INSERT INTO " & tabla & " (usuario,contrasena,nombre,apellidop,apellidom,telefono,celular,direccion) " &
                "VALUES('" & usuario & "','" & contraseña & "','" & nombre & "','" & apep & "','" & apem & "','" & tel & "','" & cel & "','" & dir & "');"
        Dim xCnx As New Conexion
        xCnx.queryStr(strSql)
        'MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Function selectAll(ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Try
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabla & " where estado = 'A'and rol='2'", cnx)
            DT = New DataTable
            DA.Fill(DT)
            dtg.DataSource = DT
            con.close()
            Return True
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function consultaID(ByVal id As String, ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Dim query As String = "Select " & columnas & " from " & tabla & " where  " & nombreid & " like '" & id & "%' and estado = 'A' and rol='2'"
        Try
            DA = New MySqlDataAdapter(query, cnx)
            DT = New DataTable
            DA.Fill(DT)
            dtg.DataSource = DT
            con.close()
            If DT.Rows.Count = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function
    Public Function consultaTitulo(ByVal titulo As String, ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        titulo = LCase(titulo)
        Try
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabla & "  where lower(nombre) like '%" & titulo & "%' and estado = 'A' and rol='2'", cnx)
            DT = New DataTable
            DA.Fill(DT)
            dtg.DataSource = DT
            con.close()
            Return True
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function actualiza(ByVal numtrab As String, ByVal user As String, ByVal apep As String, ByVal nombre As String, ByVal pass As String, ByVal dir As String, ByVal cel As String, ByVal apem As String, ByVal tel As String, ByVal id As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion
        Dim HashedPass As String = ""

        Using MD5hash As MD5 = MD5.Create()
            If pass <> "" Then
                HashedPass = Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(pass)))
            End If
        End Using

        strSql = "UPDATE " & tabla & " SET numtrabajador = '" & numtrab & "',usuario = '" & user & "',contrasena = '" & HashedPass & "',nombre = '" & nombre & "',apellidop = '" & apep & "',apellidom = '" & apem & "',telefono = '" & tel & "',celular = '" & cel & "',direccion = '" & dir & "' WHERE  " & nombreid & " = '" & id & "';"
        xCnx.queryStr(strSql)
        'MsgBox("Registro modificado")
        cnx.Close()
        Return True
    End Function

    Public Function elimina(ByVal numtrab As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion

        strSql = "UPDATE " & tabla & " SET estado = 'I' WHERE " & nombreid & " = '" & numtrab & "';"
        xCnx.queryStr(strSql)
        'MsgBox("Registro eliminado")
        cnx.Close()
        Return True
    End Function
End Class

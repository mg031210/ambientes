Imports MySql.Data.MySqlClient
Public Class ClaseProvee
    Dim tabla As String = "proveedor"
    Dim columnas As String = "nombre as Nombre,rfc as RFC,telefono1 as Telefono1, telefono2 as Telefono2, fax as Fax, direccion as Direccion, codigopostal as CodigoPostal, email as Email, personacontacto as Contacto"
    Dim nombreid As String = "rfc"
    Public Sub New()
    End Sub
    Public Function consultaID(ByVal id As String, ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Dim query As String = "Select " & columnas & " from " & tabla & " where " & nombreid & " like '" & id & "%' and estado = 'A'"
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
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabla & "  where lower(nombre) like '%" & titulo & "%' and estado = 'A'", cnx)
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
    Public Function selectAllmod(ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Try
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabla & " where estado = 'A'", cnx)
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
    Public Sub inserta(ByVal nombre As String, ByVal rfc As String, ByVal tel1 As String, ByVal tel2 As String, ByVal fax As String, ByVal direccion As String, ByVal codigopostal As String, ByVal email As String, ByVal contacto As String)
        Dim strSql As String
        strSql = "INSERT INTO " & tabla & " (nombre,rfc,telefono1,telefono2,fax,direccion,codigopostal,email,personacontacto) " &
            "VALUES('" & nombre & "','" & rfc & "','" & tel1 & "','" & tel2 & "','" & fax & "','" & direccion & "','" & codigopostal & "','" & email & "','" & contacto & "');"
        Dim xCnx As New Conexion
        xCnx.queryStr(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub

    Public Function actualiza(ByVal nombre As String, ByVal newrfc As String, ByVal tel1 As String, ByVal tel2 As String, ByVal fax As String, ByVal dir As String, ByVal codigo As String, ByVal email As String, ByVal contacto As String, ByVal oldrfc As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion

        strSql = "UPDATE " & tabla & " SET nombre = '" & nombre & "',telefono1 = '" & tel1 & "',fax = '" & fax & "',telefono2 = '" & tel2 & "',rfc = '" & newrfc & "',email = '" & email & "',personacontacto = '" & contacto & "',codigopostal = '" & codigo & "' WHERE " & nombreid & " = '" & oldrfc & "';"
        xCnx.queryStr(strSql)
        MsgBox("Registro modificado")
        cnx.Close()
        Return True
    End Function

    Public Function elimina(ByVal oldrfc As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion

        strSql = "UPDATE " & tabla & " SET estado = 'I' WHERE " & nombreid & " = '" & oldrfc & "';"
        xCnx.queryStr(strSql)
        MsgBox("Registro Eliminado")
        cnx.Close()
        Return True
    End Function
End Class

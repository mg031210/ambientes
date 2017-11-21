Imports MySql.Data.MySqlClient
Public Class ClaseRenta
    Dim tabla As String = "renta"
    Dim nombreid As String = "idrenta"
    Dim columnas As String = "idrenta as NumRenta, (montodevolucion + monto) as Monto "
    Public Sub inserta(ByVal monto As String, ByVal idpel As String, ByVal idsocio As String, ByVal fecharetorno As String)
        Dim strSql As String
        strSql = "INSERT INTO " & tabla & " (FechaRenta,fechaentrega,idusuario,idsocio,idpelicula,monto) VALUES('" & DateTime.Now.ToString("yyyy/MM/dd") & "','" & fecharetorno & "','" & session.item(0) & "','" & idsocio & "','" & idpel & "','" & monto & "');"
        Dim xCnx As New Conexion
        xCnx.queryStr(strSql)
        'MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Function insertadevol(ByVal id As String, ByVal monto As String, ByVal fecharetorno As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion
        strSql = "UPDATE " & tabla & " SET montodevolucion= '" & monto & "', fechaentregado='" & fecharetorno & "' WHERE " & nombreid & " = '" & id & "';"
        xCnx.queryStr(strSql)
        'MsgBox("Registro insertado")
        cnx.Close()
        Return True
    End Function
    Public Function selectAllhoy(ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Dim query As String = "Select " & columnas & " from " & tabla & " where fecharenta='" & DateTime.Now.ToString("yyyy/MM/dd") & "' "
        Try
            DA = New MySqlDataAdapter(query, cnx)
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
End Class

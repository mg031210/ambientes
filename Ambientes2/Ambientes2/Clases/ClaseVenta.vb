Imports MySql.Data.MySqlClient
Public Class ClaseVenta
    Dim tabla As String = "venta"
    Dim columnas As String = "idventa as NumVenta,monto as Monto "
    Public Sub inserta(ByVal monto As String, ByVal idpel As String)
        Dim strSql As String
        strSql = "INSERT INTO " & tabla & " (monto,fechaventa,idusuario,idpelicula) VALUES('" & monto & "','" & DateTime.Now.ToString("yyyy/MM/dd") & "','" & session.item(0) & "','" & idpel & "');"
        Dim xCnx As New Conexion
        xCnx.queryStr(strSql)
        'MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Function selectAllhoy(ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Dim query As String = "Select " & columnas & " from " & tabla & " where fechaventa='" & DateTime.Now.ToString("yyyy/MM/dd") & "' "
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

Imports MySql.Data.MySqlClient
Public Class ClasePeli

    Dim columnas As String = "idpelicula as CodigoBarras, nombre as Titulo, tipopelicula as Tipo, clasificacion as Clasificacion, cantidad as Cantidad"
    Dim columnasmod As String = "idpelicula as CodigoBarras, nombre as Titulo, tipopelicula as Tipo, clasificacion as Clasificacion, duracion as Duracion, categoria as Categoria"
    Dim tabla As String = "pelicula"
    Dim nombreid As String = "idpelicula"
    Public Sub New()
    End Sub

    Public Function consultaID(ByVal id As String, ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Dim query As String = "Select " & columnas & " from " & tabla & " where " & nombreid & " like '" & id & "%' and estado = 'A' and cantidad <> 0 "
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
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabla & "  where lower(Nombre) like '%" & titulo & "%' and estado = 'A' and cantidad <> 0", cnx)
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
    Public Function selectAll(ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Try
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabla & " where estado = 'A' and cantidad <> 0 ", cnx)
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

    Public Sub inserta(ByVal id As String, ByVal clas As String, ByVal duracion As String, ByVal tit As String, ByVal cat As String, ByVal tipo As String)
        Dim strSql As String
        strSql = "INSERT INTO " & tabla & " (idpelicula,nombre,tipopelicula,duracion,clasificacion,categoria) VALUES('" & id & "','" & tit & "','" & tipo & "','" & duracion & "','" & clas & "','" & cat & "');"
        Dim xCnx As New Conexion
        xCnx.queryStr(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Function selectAllMod(ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Try
            DA = New MySqlDataAdapter("Select " & columnasmod & " from " & tabla & " where estado = 'A'", cnx)
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

    Public Function actualiza(ByVal id As String, ByVal titulo As String, ByVal clas As String, ByVal cat As String, ByVal dur As String, ByVal tipo As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion
        strSql = "UPDATE " & tabla & " SET nombre = '" & titulo & "',categoria = '" & cat & "',tipopelicula = '" & tipo & "',duracion = '" & dur & "',clasificacion = '" & clas & "' WHERE " & nombreid & " = '" & id & "';"
        xCnx.queryStr(strSql)
        MsgBox("Registro modificado")
        cnx.Close()
        Return True
    End Function
    Public Function elimina(ByVal id As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion
        strSql = "UPDATE " & tabla & " SET estado = 'I' WHERE " & nombreid & " = '" & id & "';"
        xCnx.queryStr(strSql)
        MsgBox("Registro eliminado")
        cnx.Close()
        Return True
    End Function
    Public Function consultaIDcompra(ByVal id As String, ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Dim query As String = "Select " & columnas & " from " & tabla & " where " & nombreid & " like '" & id & "%' and estado = 'A' "
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
    Public Function consultaTitulocompra(ByVal titulo As String, ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        titulo = LCase(titulo)
        Try
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabla & "  where lower(Nombre) like '%" & titulo & "%' and estado = 'A' ", cnx)
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
    Public Function selectAllcompra(ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Try
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabla & " where estado = 'A' ", cnx)
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

    Public Function stockintrenta(ByVal newcant As String, ByVal idrenta As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Dim dtg As DataGridView

        DA = New MySqlDataAdapter("Select idpelicula from renta where idrenta = '" & idrenta & "';", cnx)
        DT = New DataTable
        DA.Fill(DT)

        Dim idpel As String = DT.Rows(0).Item(0)

        DA = New MySqlDataAdapter("Select cantidad from " & tabla & " where " & nombreid & " = '" & idpel & "';", cnx)
        DT = New DataTable
        DA.Fill(DT)

        Dim cant As String = DT.Rows(0).Item(0) + newcant

        strSql = "UPDATE " & tabla & " SET cantidad = '" & cant & "' WHERE " & nombreid & " = '" & idpel & "';"
        xCnx.queryStr(strSql)
        'MsgBox("stock cambiado")
        cnx.Close()
        Return True
    End Function
    Public Function stockout(ByVal newcant As String, ByVal id As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Dim dtg As DataGridView

        DA = New MySqlDataAdapter("Select cantidad from " & tabla & " where " & nombreid & " = '" & id & "';", cnx)
        DT = New DataTable
        DA.Fill(DT)

        Dim cant As String = DT.Rows(0).Item(0) - newcant

        strSql = "UPDATE " & tabla & " SET cantidad = '" & cant & "' WHERE " & nombreid & " = '" & id & "';"
        xCnx.queryStr(strSql)
        'MsgBox("stock cambiado")
        cnx.Close()
        Return True
    End Function

    Public Function stockin(ByVal newcant As String, ByVal id As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Dim dtg As DataGridView

        DA = New MySqlDataAdapter("Select cantidad from " & tabla & " where " & nombreid & " = '" & id & "';", cnx)
        DT = New DataTable
        DA.Fill(DT)

        Dim cant As String = DT.Rows(0).Item(0) + newcant

        strSql = "UPDATE " & tabla & " SET cantidad = '" & cant & "' WHERE " & nombreid & " = '" & id & "';"
        xCnx.queryStr(strSql)
        'MsgBox("stock cambiado")
        cnx.Close()
        Return True
    End Function

End Class


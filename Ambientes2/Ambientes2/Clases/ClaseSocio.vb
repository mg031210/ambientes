Imports MySql.Data.MySqlClient
Public Class ClaseSocio
    Dim columnas As String = "numsocio, CONCAT(nombre, ' ', apellidop) As Nombre"
    Dim columnasDevol As String = "FechaRenta as Renta,fechaentrega as Entrega,fechaentregado as Hoy, CONCAT(s.nombre, ' ', s.apellidop) As Nombre, p.nombre as Pelicula, p.tipopelicula as TipoPel"
    Dim tabsocio As String = "socio"
    Dim tablamen As String = "menbresia"
    Dim nombreid As String = "numsocio"
    Public Sub New()
    End Sub

    Public Function consultaID(ByVal id As String, ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        If id = "" Then
            id = 0
        End If
        Dim query As String = "Select " & columnas & " from " & tabsocio & " where " & nombreid & " like '" & id & "'"
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

    Public Function consultaVigencia(ByVal id As String, ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        If id = "" Then
            id = 0
        End If
        Dim query As String = "Select vigencia from socio s,menbresia m where s.idsocio = m." & nombreid & "  and s." & nombreid & "='" & id & "'"
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
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabsocio & "  where lower(Nombre) like '%" & titulo & "%'", cnx)
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
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabsocio & " ", cnx)
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
    Public Function consultaDevol(ByVal id As String, ByVal dtg As DataGridView) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        If id = "" Then
            id = 0
        End If
        'SELECT * FROM renta r,socio s,pelicula p WHERE r.idsocio=s.numsocio and p.idpelicula=r.idpelicula and r.idsocio=1 and fechaentregado is null
        Dim query As String = "SELECT " & columnasDevol & " FROM renta r,socio s,pelicula p WHERE r.idsocio=s.numsocio and p.idpelicula=r.idpelicula and r.idsocio='" & id & "%' and fechaentregado is null"
        Try
            DA = New MySqlDataAdapter(query, cnx)
            DT = New DataTable
            DA.Fill(DT)
            dtg.DataSource = DT
            con.close()
            If DT.Rows.Count >= 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Function

    Public Sub inserta(ByVal id As String, ByVal nombre As String, ByVal apellidop As String, ByVal apellidom As String, ByVal Dir As String, ByVal Telefono As String, ByVal Cel As String)
        Dim strSql, strSql2, strSql1 As String
        Dim hoy As Date = DateTime.Now.ToString("yyyy/MM/dd")
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable

        strSql = "INSERT INTO " & tabsocio & " (numsocio,nombre,apellidop,apellidom,direccion,telefono,celular) VALUES('" & id & "','" & nombre & "','" & apellidop & "','" & apellidom & "','" & Dir & "','" & Telefono & "','" & Cel & "');"
        Dim xCnx As New Conexion
        xCnx.queryStr(strSql)

        strSql1 = "Select idsocio from " & tabsocio & " where numsocio='" & id & "';"
        DA = New MySqlDataAdapter(strSql1, cnx)
        DT = New DataTable
        DA.Fill(DT)

        strSql2 = "INSERT INTO " & tablamen & " (vigencia,fechaingreso,numsocio,idusuario) VALUES('" & hoy.AddYears(1).ToString("yyyy'/'MM'/'dd") & "','" & hoy.ToString("yyyy'/'MM'/'dd") & "','" & DT.Rows(0).Item(0) & "','1');"
        ','" & session.item(0) & "');"
        xCnx.queryStr(strSql2)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
End Class

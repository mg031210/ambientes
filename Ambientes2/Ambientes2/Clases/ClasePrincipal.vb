Imports MySql.Data.MySqlClient
Public Class ClasePrincipal
    Protected id As Integer
    Protected nombre As String
    Public Sub New()
        id = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal nuevoNombre As String)
        nombre = nuevoNombre
    End Sub

    Public Sub New(ByVal nuevoid As Integer)
        id = nuevoid
    End Sub
    Public Property getSetid() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Overloads Function actualiza(ByVal Tabla As String, ByVal NuevoNombre As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion
        If NuevoNombre <> "" Then
            strSql = "UPDATE " & Tabla & " SET nombre = '" & NuevoNombre & "' WHERE nombre = '" & nombre & "';"
            xCnx.queryStr(strSql)
            MsgBox("Registro modificado")
            cnx.Close()
            Return True
        Else
            MsgBox("Ingrese el Nuevo Nombre")
            cnx.Close()
            Return False
        End If
    End Function
    Public Overloads Function elimina(ByVal tabla As String) As Boolean
        Dim strSql As String
        Dim xCnx As New Conexion

        If nombre <> "" Then
            strSql = "DELETE FROM " & tabla & " WHERE nombre='" & nombre & "';"
            xCnx.queryStr(strSql)
            MessageBox.Show("Registro Eliminado")
            cnx.Close()
            Return True
        Else
            MsgBox("Falta el Nombre a Eliminar", MsgBoxStyle.Critical)
            cnx.Close()
            Return False
        End If
    End Function
    Public Function AutoIncrement(ByVal tabla As String) As Integer
        id = getMaxId(tabla) + 1
        Return id
    End Function
    Public Function getMaxId(ByVal tabla As String) As String
        Dim strSql As String = Nothing
        Dim xCnx As New Conexion
        Dim xDT As DataTable
        Select Case (tabla)
            'Case pais
            '    strSql = "SELECT max(id_pais) as Columna FROM " & pais & ";"
        End Select
        Try
            xDT = xCnx.selectStr(strSql)
            id = CStr(xDT.Rows(0)("Columna"))
            cnx.Close()
            Return id
        Catch
        End Try
        id = 0
        cnx.Close()
        Return id
    End Function
    Public Overloads Function getId(ByVal tabla As String) As String
        Dim strSql As String = Nothing
        Dim xCnx As New Conexion
        Dim xDT As DataTable
        Select Case (tabla)
            'Case pais
            '    strSql = "SELECT id_pais as Columna FROM " & pais & " WHERE nombre = '" & nombre & "';"
        End Select
        Try
            xDT = xCnx.selectStr(strSql)
            id = CStr(xDT.Rows(0)("Columna"))
            cnx.Close()
            Return id
        Catch
        End Try
        id = 0
        cnx.Close()
        Return id
    End Function
    Public Function consultaUno(ByVal Tabla As String) As Boolean
        Dim strSQL As String = Nothing
        Dim xCnx As New Conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM " & Tabla & " WHERE nombre = '" & nombre & "';"
        consultaUno = False
        xDT = xCnx.selectStr(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombre = ""
            Else
                nombre = CStr(xDT.Rows(0)("nombre"))
                'EL_nombre = CStr(xDT.Rows(0)("nombre"))
            End If
            consultaUno = True
        End If
        cnx.Close()
    End Function
    Public Function consultaAlgo(ByVal Tabla As String, ByVal id As String) As Boolean
        Dim strSQL As String = Nothing
        Dim xCnx As New Conexion
        Dim xDT As DataTable
        Select Case (Tabla)
            '  Case estado
            '     strSQL = "SELECT * FROM " & Tabla & " WHERE id_pais = '" & id & "';"

        End Select
        consultaAlgo = False
        xDT = xCnx.selectStr(strSQL)
        If xDT.Rows.Count >= 1 Then
            consultaAlgo = True
        End If
        cnx.Close()
    End Function
    Public Overloads Function getNombre(ByVal tabla As String)
        Dim strSQL As String = Nothing
        Dim xCnx As New Conexion
        Dim xDT As DataTable
        Select Case (tabla)
            ' Case pais
            '    strSQL = "SELECT nombre FROM " & pais & " WHERE id_pais = " & id & ";"
        End Select
        xDT = xCnx.selectStr(strSQL)
        nombre = CStr(xDT.Rows(0)("nombre"))
        cnx.Close()
        Return nombre
    End Function

    Public Function consultaID(ByVal id As String, ByVal dtg As DataGridView, ByVal tabla As String, ByVal columnas As String, ByVal Nombreid As String) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Dim query As String = "Select " & columnas & " from " & tabla & " where " & Nombreid & " like '" & id & "%'"
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
    Public Function consultaTitulo(ByVal titulo As String, ByVal dtg As DataGridView, ByVal tabla As String, ByVal columnas As String) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        titulo = LCase(titulo)
        Try
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabla & "  where lower(Nombre) like '%" & titulo & "%'", cnx)
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
    Public Function selectAll(ByVal dtg As DataGridView, ByVal tabla As String, ByVal columnas As String) As Boolean
        Dim con As New Conexion
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Try
            DA = New MySqlDataAdapter("Select " & columnas & " from " & tabla & " ", cnx)
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


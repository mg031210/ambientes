Imports MySql.Data.MySqlClient
Public Class ClasePeli
    Inherits ClasePrincipal
    Dim columnas As String = "idpelicula as CodigoBarras, nombre as Titulo, tipopelicula as Tipo, duracion as Duracion,clasificacion as Clasificacion,categoria as Categoria"
    Dim tabla As String = "pelicula"
    Public Sub New()
        id = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal nuevoNombre As String)
        MyBase.New(nuevoNombre)
    End Sub
    Public Sub New(ByVal nuevoid As Integer)
        MyBase.New(nuevoid)
    End Sub
    Public Function consultaTodos() As DataTable
        Dim strSQL As String
        Dim xCnx As New Conexion

        strSQL = "SELECT nombre AS País FROM paises ORDER BY nombre ASC;"
        consultaTodos = xCnx.selectStr(strSQL)
        cnx.Close()
    End Function
    Public Sub poblarCombo(ByVal ComboP As ComboBox)
        Dim ds As DataTable
        ds = consultaTodos()
        ComboP.ValueMember = ds.Columns(0).ToString()
        ComboP.DataSource = ds
        ComboP.Refresh()
    End Sub

    Public Sub inserta()
        Dim strSql As String
        'strSql = "INSERT INTO " & pais & " (id_pais,nombre) VALUES(" & AutoIncrement(pais) & ",'" & nombre & "');"
        Dim xCnx As New Conexion
        xCnx.queryStr(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Overloads Function getNombre()
        '   Return MyBase.getNombre(pais)
    End Function

    Public Overloads Function getId()
        '    Return MyBase.getId(pais)
    End Function

    Public Overloads Function elimina()
        '    Return MyBase.elimina(pais)
    End Function

    Public Overloads Function consultaID(ByVal id As String, ByVal dtg As DataGridView)
        Return MyBase.consultaID(id, dtg, tabla, columnas)
    End Function
    Public Overloads Function consultaTitulo(ByVal titulo As String, ByVal dtg As DataGridView)
        Return MyBase.consultaTitulo(titulo, dtg, tabla, columnas)
    End Function

    Public Overloads Function selectAll(ByVal dtg As DataGridView)
        Return MyBase.selectAll(dtg, tabla, columnas)
    End Function
End Class


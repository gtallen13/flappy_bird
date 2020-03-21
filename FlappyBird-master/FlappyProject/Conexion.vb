Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Conexion
    Public conexion As MySqlConnection = New MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=flappy_bird")
    Private cmd As MySqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As MySqlDataAdapter
    Public Comando As MySqlCommand
    Public comand As MySqlCommand
    Public dv As New DataView
    Public adapter As MySqlDataAdapter
    Public datos2 As DataSet

    Public Sub conectar()
        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("Error en conexion a base de datos")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Llenar(ByVal table As String)
        ds.Tables.Clear()
        da = New MySqlDataAdapter("Select Usuario, Escuela, Puntaje From juego group by Usuario, Escuela order by CAST(Puntaje AS UNSIGNED) Desc LIMIT 10;", conexion)
        cmd = New MySqlCommandBuilder(da)
        da.Fill(ds, table)
        dv.Table = ds.Tables(0)
        conexion.Close()
    End Sub

    Public Sub Llenaradmin(ByVal table As String)
        ds.Tables.Clear()
        da = New MySqlDataAdapter("Select * From juego", conexion)
        cmd = New MySqlCommandBuilder(da)
        da.Fill(ds, table)
        dv.Table = ds.Tables(0)
        conexion.Close()
    End Sub

    Function agregar(ByVal usuario, ByVal escuela)
        Dim reader As MySqlDataReader
        Dim cont As Int32 = 0
        conexion.Open() 'validar
        comand = New MySqlCommand("select * from juego where Usuario ='" + usuario + "'and Escuela ='" + escuela + "'", conexion)
        reader = comand.ExecuteReader()
        While reader.Read
            cont = cont + 1
        End While
        reader.Close()
        If cont = 0 Then
            Comando = New MySqlCommand("insert into juego(Usuario, Escuela) values ('" + usuario + "','" + escuela + "')", conexion)
            Dim i As Integer = Comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False
            End If
        Else

            conexion.Close()
            Return True
        End If
    End Function

    Function agregar_puntos(ByVal usuario As String, ByVal puntaje As String, ByVal escuela As String)        Dim READER As MySqlDataReader        Dim cont As Int32 = 0        conexion.Open()
        comand = New MySqlCommand("UPDATE juego SET Puntaje = " + puntaje + " WHERE Usuario = '" + usuario + "' and Escuela='" + escuela + "'", conexion)
        Dim i As String = comand.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar(ByRef tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modd As String = "update " + tabla + " set " + campos + " where " + condicion
        Comando = New MySqlCommand(modd, conexion)
        Dim i As Integer = Comando.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim del As String = "delete from " + tabla + " where " + condicion
        Comando = New MySqlCommand(del, conexion)
        Dim i As String = Comando.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function reset(ByVal tabla)
        conexion.Open()
        Dim del As String = "truncate " + tabla
        Comando = New MySqlCommand(del, conexion)
        Dim i As String = Comando.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub llenar_escuela()
        conexion.Open()
        adapter = New MySqlDataAdapter("Select * from escuelas", conexion)
        datos2 = New DataSet
        datos2.Tables.Add("escuelas")
        adapter.Fill(datos2.Tables("escuelas"))
        conexion.Close()

    End Sub
    Function comparar(ByVal usuario As String, ByVal contraseña As String)   'ByVal contra)
        Dim READER As MySqlDataReader
        Dim cont As Int32 = 0
        Dim cont2 As Int32 = 0
        conexion.Open()
        comand = New MySqlCommand("select Nombre from login where Nombre ='" + usuario + "'", conexion)
        READER = comand.ExecuteReader()
        While READER.Read
            cont = cont + 1
        End While
        READER.Close()
        If (cont = 1) Then
            Comando = New MySqlCommand("Select Contra from login where Contra ='" + contraseña + "'", conexion)
            Dim i As MySqlDataReader = Comando.ExecuteReader
            While i.Read
                cont2 = cont2 + 1
            End While
            i.Close()
            conexion.Close()
            If (cont2 = 1) Then
                Return True
            End If
        Else
            conexion.Close()
            Return False
        End If
    End Function

    Function admin(ByVal usuario As String, ByVal contraseña As String)
        Dim READER As MySqlDataReader
        Dim cont As Int32 = 0
        Dim cont2 As Int32 = 0
        conexion.Open()
        comand = New MySqlCommand("select Nombre from login where Nombre ='" + usuario + "' and ID = 1", conexion)
        READER = comand.ExecuteReader()
        While READER.Read
            cont = cont + 1
        End While
        READER.Close()
        If (cont = 1) Then
            Comando = New MySqlCommand("Select Contra from login where Contra ='" + contraseña + "'", conexion)
            Dim i As MySqlDataReader = Comando.ExecuteReader
            While i.Read
                cont2 = cont2 + 1
            End While
            i.Close()
            conexion.Close()
            If (cont2 = 1) Then
                Return True
            End If
        Else
            conexion.Close()
            Return False
        End If
    End Function
End Class



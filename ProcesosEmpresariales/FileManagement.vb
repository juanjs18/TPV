Imports System.IO

Public Class FileManagement
    ' Funcio que copia un arxiu a la ruta especificada
    Public Shared Function copyFile(pathOut As String, pathIn As String) As Boolean
        Dim name As String = pathOut & Path.GetFileName(pathIn)
        If Not File.Exists(name) Then
            Try
                File.Copy(pathIn, name)
            Catch ex As Exception
                Return False
            End Try
        End If
        Return True
    End Function
    ' Funcio que comprova si hi han els arxius i els directoris per defecte en la ruta del programa
    Public Shared Sub haveDirectories()
        If Not Directory.Exists(Constantes.PATH_RESOURCES) Then
            Directory.CreateDirectory(Constantes.PATH_RESOURCES)
            Directory.CreateDirectory(Constantes.PATH_CATEGORIES)
            Directory.CreateDirectory(Constantes.PATH_PRODUCTS)
            Directory.CreateDirectory(Constantes.PATH_CONFIG)
        End If
        If Not Directory.Exists(Constantes.PATH_PRODUCTS) Then
            Directory.CreateDirectory(Constantes.PATH_PRODUCTS)
        End If
        If Not Directory.Exists(Constantes.PATH_CATEGORIES) Then
            Directory.CreateDirectory(Constantes.PATH_CATEGORIES)
        End If
        If Not Directory.Exists(Constantes.PATH_CONFIG) Then
            Directory.CreateDirectory(Constantes.PATH_CONFIG)
        End If
        If Not File.Exists(Constantes.FILE_CONFIG) Then
            Dim fs As FileStream = File.Create(Constantes.FILE_CONFIG)
            fs.Flush()
            fs.Close()
            Configuracion.defaultConfig()
        End If
    End Sub
End Class

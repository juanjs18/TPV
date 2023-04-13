Imports System.IO
Imports Newtonsoft.Json

<Serializable>
Public Class Configuracion
    Property Empresa As String
    Property Telefono As String
    Property NIF As String
    Property IVA As Double
    Property idCountry As Integer
    Property idPC As Integer
    Property idCity As Integer
    Property Country As String
    Property City As String
    Property PC As String
    Property Street As String
    Property Door As String
    Property ruta As String

    Public Sub New(empresa As String, telefono As String, nIF As String, iVA As Double, idCountry As Integer, idPC As Integer, idCity As Integer, country As String, city As String, pC As String, Street As String, Door As String, ruta As String)
        Me.Empresa = empresa
        Me.Telefono = telefono
        Me.NIF = nIF
        Me.IVA = iVA
        Me.idCountry = idCountry
        Me.idPC = idPC
        Me.idCity = idCity
        Me.Country = country
        Me.City = city
        Me.PC = pC
        Me.Street = Street
        Me.Door = Door
        Me.ruta = ruta
    End Sub
    ' Se guarda la configuracion en un JSON 
    Public Function saveConfig() As Boolean
        Dim json = JsonConvert.SerializeObject(Me)
        Try
            File.WriteAllText(Constantes.FILE_CONFIG, json)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    ' Funcion que retorna un objeto con la configuracion
    Public Shared Function returnConfig() As Configuracion
        Dim config As Configuracion
        Try
            config = JsonConvert.DeserializeObject(Of Configuracion)(File.ReadAllText(Constantes.FILE_CONFIG))
        Catch ex As Exception
            Return Nothing
        End Try
        Return config
    End Function
    ' Funcion que guarda un JSON con la configuración por defecto
    Public Shared Sub defaultConfig()
        Dim config As New Configuracion("Empresa", "Telefono", "NIF", 0.21, 0, 0, 0, "España", "Puigcerda", "17520", "Avinguda Catalunya", "1", "C:\")
        config.saveConfig()
    End Sub
End Class

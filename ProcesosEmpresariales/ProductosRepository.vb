Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.Entity
Imports ConexionBD
Imports ConexionBD.Product

Public Class Repository(Of T)
    Inherits ObservableCollection(Of T)
    Implements IListSource

    Private _bindingList As IBindingList


    Public ReadOnly Property ContainsListCollection As Boolean Implements IListSource.ContainsListCollection
        Get
            Return _bindingList.Count
        End Get
    End Property

    Public Function GetList() As IList Implements IListSource.GetList
        Return _bindingList
    End Function
End Class

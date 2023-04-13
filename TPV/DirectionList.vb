Imports ConexionBD

Public Class DirectionList
    Private pais As Boolean
    Private idPais As Integer
    Public row As DataRowView
    Public Sub New(pais As Boolean, dt As DatosTPV, idPais As Integer)
        InitializeComponent()
        DatosTPV = dt
        CiudadesBindingSource.DataSource = DatosTPV
        CountriesBindingSource.DataSource = DatosTPV
        Me.pais = pais
        Me.idPais = idPais
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            If Not pais Then
                filterCities()
            Else
                filterCountry()
            End If
        End If
    End Sub

    Private Sub DirectionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not pais Then
            CiudadesBindingSource.Filter = "country = " & idPais
            CiudadesDataGridView1.Visible = True
            CiudadesDataGridView.Visible = False
        Else
            CiudadesDataGridView1.Visible = False
            CiudadesDataGridView.Visible = True
        End If
    End Sub

    Private Sub filterCities()
        Try
            CiudadesBindingSource.Filter = "country = " & idPais & " AND postalCode = " & Integer.Parse(TextBox1.Text)
        Catch ex As Exception
            CiudadesBindingSource.Filter = "country = " & idPais & " AND nameCity LIKE '*" & TextBox1.Text & "*'"
        End Try
    End Sub

    Private Sub filterCountry()
        CountriesBindingSource.Filter = "name like '*" & TextBox1.Text & "*'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not pais Then
            CiudadesBindingSource.Filter = "country = " & idPais
        Else
            CountriesBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub CiudadesDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CiudadesDataGridView1.CellClick
        If e.RowIndex >= 0 Then
            row = CiudadesBindingSource.Current
            Me.Close()
        End If
    End Sub

    Private Sub CiudadesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CiudadesDataGridView.CellClick
        If e.RowIndex >= 0 Then
            row = CountriesBindingSource.Current
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
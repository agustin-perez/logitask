Public Class Lote

	Public Sub New()

	End Sub
	Private _codigoLote As String
	Public Property codigoLoteProperty() As String
		Get
			Return _codigoLote
		End Get
		Set(ByVal value As String)
			_codigoLote = value
		End Set
	End Property

	Private _descripcion As String
	Public Property descripcionProperty() As String
		Get
			Return _descripcion
		End Get
		Set(ByVal value As String)
			_descripcion = value
		End Set
	End Property
End Class

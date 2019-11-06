Public Class Danio

	Public Sub New(vin As String, descripcion As String)
		_vin = vin
		_descripcion = descripcion
	End Sub

	Private _vin As String
	Public Property vinProperty() As String
		Get
			Return _vin
		End Get
		Set(ByVal value As String)
			_vin = value
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

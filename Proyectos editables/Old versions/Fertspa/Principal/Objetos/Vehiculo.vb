Public Class vehiculo
	Public Sub New(vin As String, marca As String, modelo As String, anio As Integer, color As String, tipo As String, codigoLote As String, listo As String)
		_VIN = vin
		_marca = marca
		_modelo = modelo
		_anio = anio
		_color = color
		_tipo = tipo
		_codigoLote = codigoLote
		_listo = listo
	End Sub
	Private _VIN As String
	Public Property vinProperty() As String
		Get
			Return _VIN
		End Get
		Set(ByVal value As String)
			_VIN = value
		End Set
	End Property
	Private _marca As String
	Public Property marcaProperty() As String
		Get
			Return _marca
		End Get
		Set(ByVal value As String)
			_marca = value
		End Set
	End Property
	Private _modelo As String
	Public Property modeloProperty() As String
		Get
			Return _modelo
		End Get
		Set(ByVal value As String)
			_modelo = value
		End Set

	End Property
	Private _anio As Integer
	Public Property anioProperty() As Integer
		Get
			Return _anio
		End Get
		Set(ByVal value As Integer)
			_anio = value
		End Set
	End Property
	Private _color As String
	Public Property colorProperty() As String
		Get
			Return _color
		End Get
		Set(ByVal value As String)
			_color = value
		End Set
	End Property

	Private _tipo As String
	Public Property tipoProperty() As String
		Get
			Return _tipo
		End Get
		Set(ByVal value As String)
			_tipo = value
		End Set
	End Property

	Private _codigoLote As String
	Public Property codigoLoteProperty() As String
		Get
			Return _codigoLote
		End Get
		Set(ByVal value As String)
			_codigoLote = value
		End Set
	End Property

	Private _listo As String
	Public Property listoProperty() As String
		Get
			Return _listo
		End Get
		Set(ByVal value As String)
			_listo = value
		End Set
	End Property

	Public Function verInfo()
		Return _VIN & " " & _marca & " " & _modelo & " " & _anio & " " & _color & " " & _tipo & " " & _codigoLote & " " & _listo
	End Function
End Class

Public Class Inspeccion
	Public Sub New(codigoInsp As String, imagen As String, lugar As String, fecha As Date,
				   danio As String, danioAnterior As String, vin As String)
		_codigoInsp = codigoInsp
		_imagen = imagen
		_lugar = lugar
		_fecha = fecha
		_danio = danio
		_danioAnterior = danioAnterior
		_vin = vin
	End Sub
#Region "Propiedades"
	Private _codigoInsp As String
	Public Property codigoInspProperty() As String
		Get
			Return _codigoInsp
		End Get
		Set(ByVal value As String)
			_codigoInsp = value
		End Set
	End Property
	Private _imagen As String
	Public Property imagenProperty() As String
		Get
			Return _imagen
		End Get
		Set(ByVal value As String)
			_imagen = value
		End Set
	End Property
	Private _lugar As String
	Public Property lugarProperty() As String
		Get
			Return _lugar
		End Get
		Set(ByVal value As String)
			_lugar = value
		End Set
	End Property

	Private _fecha As DateTime
	Public Property fechaProperty() As DateTime
		Get
			Return _fecha
		End Get
		Set(ByVal value As DateTime)
			_fecha = value
		End Set
	End Property
	Private _danio As String
	Public Property danioProperty() As String
		Get
			Return _danio
		End Get
		Set(ByVal value As String)
			_danio = value
		End Set
	End Property
	Private _danioAnterior As String
	Public Property danioAnteriorProperty() As String
		Get
			Return _danioAnterior
		End Get
		Set(ByVal value As String)
			_danioAnterior = value
		End Set
	End Property

	Private _vin As String
	Public Property vinProperty() As String
		Get
			Return _vin
		End Get
		Set(ByVal value As String)
			_vin = value
		End Set
	End Property
#End Region
End Class



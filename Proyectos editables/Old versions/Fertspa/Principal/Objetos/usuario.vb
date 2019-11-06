Public Class usuario

	Private _cedula As Integer
	Private _contrasenia As String
	Private _rol As String

	Public Property cedula() As Integer
		Get
			Return _cedula
		End Get
		Set(ByVal value As Integer)
			_cedula = value
		End Set
	End Property

	Public Property contrasenia() As String
		Get
			Return _contrasenia
		End Get
		Set(ByVal value As String)
			_contrasenia = value
		End Set
	End Property
	Public Property rol() As String
		Get
			Return _rol
		End Get
		Set(ByVal value As String)
			_rol = value
		End Set
	End Property
	Public Sub New(ced As Integer, contra As String, rol As String)
		_cedula = ced
		_contrasenia = contra
		_rol = rol
	End Sub


End Class

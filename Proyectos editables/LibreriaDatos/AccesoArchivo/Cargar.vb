Imports System.Windows.Forms
Imports System.IO
Imports System.Text
Imports System.Runtime.Serialization.Formatters.Binary
''' <summary>
''' Clase encargada de abir archivos en texto plano y/o obtener rutas.
''' </summary>
Public Class Cargar
    ''' <summary>
    ''' Guardamos la ruta actual para poder consultarla luego de ser necesario.
    ''' </summary>
    Private rutaActual As String
    ''' <summary>
    ''' Función encargada de obtener una ruta de archivo mediante un OpenFileDialog.
    ''' </summary>
    ''' <param name="nombreArchivo">Nombre del archivo que aparecerá en el cuadro de texto del OpenFileDialog.</param>
    ''' <param name="nombreTipoDeDato">Tipo de dato que aparecerá en el ComboBox de extensiones en el OpenFileDialog.</param>
    ''' <param name="extension">Extensión del archivo a obtener su ruta, del tipo (ejemplo) "dsn", sin puntos ni asteriscos.</param>
    ''' <returns>Ruta del archivo.</returns>
    Public Function ObtenerRuta(nombreArchivo As String, nombreTipoDeDato As String, extension As String) As String
        Dim abrir As New OpenFileDialog
        abrir.FileName = nombreArchivo
        abrir.Filter = nombreTipoDeDato + " (*." + extension + ")|*." + extension
        If (abrir.ShowDialog = DialogResult.OK) Then
            Return abrir.FileName
        End If
        Throw New Exception 'Si no se encontró el archivo o hubo error de lectura, se lanza una excepción a controlar en librería gráfica.
    End Function
    ''' <summary>
    ''' Función encargada de leer todas las líneas del archivo solicitado mediante su ruta. Puede lanzar una excepción en tiempo de ejecución si no se logró leer el archivo correctamente.
    ''' </summary>
    ''' <param name="ruta">Ruta del archivo a leer.</param>
    ''' <returns>Array de String con todas las líneas del archivo.</returns>
    Public Function LeerArchivo(ruta As String) As String()
        Return IO.File.ReadAllLines(ruta)
    End Function
    ''' <summary>
    ''' Función encargada de devolver una tabla conteniendo todos los valores de un archivo CSV.
    ''' </summary>
    ''' <returns>Tabla conteniendo todos los datos del CSV en el orden del separador de campos.</returns>
    Public Function ImportarCSV() As DataTable
        Dim tabla As New DataTable
        tabla.Columns.Add("VIN", GetType(String))
        tabla.Columns.Item(0).MaxLength = 17
        tabla.Columns.Add("Marca", GetType(String))
        tabla.Columns.Item(1).MaxLength = 64
        tabla.Columns.Add("Modelo", GetType(String))
        tabla.Columns.Item(2).MaxLength = 64
        tabla.Columns.Add("Year", GetType(Short))
        tabla.Columns.Add("Color", GetType(String))
        tabla.Columns.Item(4).MaxLength = 32
        tabla.Columns.Add("Tipo", GetType(Char))
        Dim ruta As String
        ruta = ObtenerRuta("", "Comma separated values", "csv")
        rutaActual = ruta
        Dim lector As New StreamReader(ruta, Encoding.ASCII)
        Dim textoDelimitado() As String
        While (lector.Peek() > -1)
            Dim linea As String = lector.ReadLine()
            textoDelimitado = Split(linea, ";")
            tabla.Rows.Add(textoDelimitado)
        End While
        Return tabla
    End Function
    ''' <summary>
    ''' Función encargada de devolver un objeto en base a un archivo binario (BLOB) guardado previamente.
    ''' </summary>
    ''' <returns>Objeto guardado.</returns>
    Public Function CargarSerializable(Of T)() As Object
        Dim resultado As T = Nothing
        Dim flujo As New FileStream(Application.StartupPath + "\cfgdata.tsk", FileMode.Open)
        Dim decoder As New BinaryFormatter
        resultado = CType(decoder.Deserialize(flujo), T)
        flujo.Close()
        Return resultado
    End Function
    ''' <summary>
    ''' Devuelve la ruta actualmente utilizada para acceder al último archivo consultado.
    ''' </summary>
    ''' <returns>Ruta del archivo en cuestión.</returns>
    Public ReadOnly Property RutaTemp() As String
        Get
            Return rutaActual
        End Get
    End Property
End Class

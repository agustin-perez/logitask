Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Windows.Forms
''' <summary>
''' Clase encargada de escribir archivos en texto plano y/o obtener una ruta donde escribir un archivo.
''' </summary>
Public Class Guardar
    ''' <summary>
    ''' Función encargada de obtener la ruta de un archivo a escribir y generar el archivo vacío.
    ''' </summary>
    ''' <param name="nombreArchivo">Nombre del archivo por defecto a escribir que aparecerá en el cuadro de texto del SaveFileDialog.</param>
    ''' <param name="nombreTipoDeDato">Tipo de dato que aparecerá en el ComboBox de extensiones en el SaveFileDialog.</param>
    ''' <param name="extension">Extensión del archivo a obtener su ruta, del tipo (ejemplo) "dsn", sin puntos ni asteriscos.</param>
    ''' <returns>Ruta del archivo a escribir</returns>
    Public Function RutaGuardar(nombreArchivo As String, nombreTipoDeDato As String, extension As String) As String
        Dim guardar As New SaveFileDialog
        guardar.FileName = nombreArchivo
        guardar.Filter = nombreTipoDeDato + " (*." + extension + ")|*." + extension
        If (guardar.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Return guardar.FileName
        End If
        Throw New Exception 'Si no se pudo generar el archivo, se lanza una excepción a controlar en librería gráfica.
    End Function
    ''' <summary>
    ''' Función encargada de escribir todas las líneas de un Array de String en un archivo de texto plano.
    ''' Puede lanzar una excepción en tiempo de ejecución si no se logró escribir los datos.
    ''' </summary>
    ''' <param name="lineas">Array de String con los datos a escribir en el archivo.</param>
    ''' <param name="ruta">Ruta con el nombre del archivo donde se van a escribir los datos de lineas().</param>
    Public Sub EscribirArchivo(lineas() As String, ruta As String)
        IO.File.WriteAllLines(ruta, lineas)
    End Sub
    ''' <summary>
    ''' Función encargada de escribir un objeto con interfaz serializable a un archivo binario (BLOB).
    ''' </summary>
    ''' <param name="clase">Objeto a ser escrito.</param>
    ''' <returns>Devuelve el resultado de la operación. (True correcto, false erróneo).</returns>
    Public Function EscribirSerializable(clase As Object)
        Try
            Dim flujo As New FileStream(Application.StartupPath + "\cfgdata.tsk", FileMode.Create)
            Dim encoder As New BinaryFormatter()
            encoder.Serialize(flujo, clase)
            flujo.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class

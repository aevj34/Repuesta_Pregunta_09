Public Class Alumno
    Implements IMatricula

    Public Property Code As String
    Public Property Name As String
    Public Property Ciclo As String

    Public Function Save()
        'code
    End Function

    Public Function GetName(code As String) As String

        'code
    End Function

    Public Function GetFichaMatricula() As List(Of Matricula) Implements IMatricula.GetFichaMatricula

    End Function

    Public Function GetNotas() As List(Of Acta)

    End Function

End Class

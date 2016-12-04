Public Class Valumno

    Dim nombre, apellidos As String
    Dim id, cal1, cal2, cal3, cal4, cal5, cal6 As Integer

    Public Property gid
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(value)
            apellidos = value
        End Set
    End Property

    Public Property gcal1
        Get
            Return cal1
        End Get
        Set(value)
            cal1 = value
        End Set
    End Property

    Public Property gcal2
        Get
            Return cal2
        End Get
        Set(value)
            cal2 = value
        End Set
    End Property

    Public Property gcal3
        Get
            Return cal3
        End Get
        Set(value)
            cal3 = value
        End Set
    End Property

    Public Property gcal4
        Get
            Return cal4
        End Get
        Set(value)
            cal4 = value
        End Set
    End Property

    Public Property gcal5
        Get
            Return cal5
        End Get
        Set(value)
            cal5 = value
        End Set
    End Property

    Public Property gcal6
        Get
            Return cal6
        End Get
        Set(value)
            cal6 = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal cal1 As Integer, ByVal cal2 As Integer, ByVal cal3 As Integer, ByVal cal4 As Integer, ByVal cal5 As Integer, ByVal cal6 As Integer)

        gid = id
        gnombre = nombre
        gapellidos = apellidos
        gcal1 = cal1
        gcal2 = cal2
        gcal3 = cal3
        gcal4 = cal4
        gcal5 = cal5
        gcal6 = cal6

    End Sub

End Class

Module MOD_VENTANA
    Public idusu As Integer, nomusu As String, nickusu As String, tipusu As String

    Public Function cierre_ventana() As Integer
        Dim valor1 As Integer = MsgBox("ESTÀ SEGURO DE SALIR? ", 4 + 16, "PROYECTO")
        Return valor1
    End Function
End Module

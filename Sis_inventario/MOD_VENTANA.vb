Module MOD_VENTANA
    Public idusu As Integer, nomusu As String, nickusu As String, tipusu As String

    Public Function cierre_ventana() As Integer
        Dim valor1 As Integer = MsgBox("ESTÁ SEGURO DE SALIR? ", 4 + 16, "PROYECTO")
        Return valor1
    End Function

    Public Sub limpiatextos(contenedor As Control)
        For Each ctrl As Control In contenedor.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next
    End Sub
    Public Sub estadoboton(contenedor As Control, activarboton As List(Of String), desactivarboton As List(Of String))
        For Each ctrl As Control In contenedor.Controls
            If TypeOf ctrl Is Button Then
                Dim boton As Button = CType(ctrl, Button)
                If activarboton.Contains(boton.Name) Then
                    boton.Enabled = True
                ElseIf desactivarboton.Contains(boton.Name) Then
                    boton.Enabled = False
                End If
            End If
        Next
    End Sub
    Public Sub lecturayescritura(contenedor As Control, sololectura As List(Of String), editable As List(Of String))
        For Each ctrl As Control In contenedor.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If sololectura.Contains(txt.Name) Then
                    txt.ReadOnly = True
                ElseIf editable.Contains(txt.Name) Then
                    txt.ReadOnly = False
                End If
            End If
        Next
    End Sub

    Public Function cancelar_accion() As Integer
        Dim valoraccion As Integer = MsgBox("ESTÁS SEGURO DE CANCELAR ACCIÓN", 4 + 64, "PROYECTO")
        Return valoraccion
    End Function

End Module

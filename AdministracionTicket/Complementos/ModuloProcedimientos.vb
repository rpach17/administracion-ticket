Module ModuloProcedimientos

    Public Sub LimpiarControles(ByVal ParamArray Objetos() As Control)
        For Each ctrl As Control In Objetos
            If TypeOf (ctrl) Is TextBox Then
                Dim txtCtrl As TextBox = DirectCast(ctrl, TextBox)
                txtCtrl.Text = Nothing
            ElseIf TypeOf (ctrl) Is CheckBox Then
                Dim chkCtrl As CheckBox = DirectCast(ctrl, CheckBox)
                chkCtrl.Checked = False
            End If
        Next
    End Sub

End Module

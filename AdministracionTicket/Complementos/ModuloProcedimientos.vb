Module ModuloProcedimientos

    Public Sub LimpiarControles(ByVal ParamArray Objetos() As Control)
        For Each ctrl As Control In Objetos
            If TypeOf (ctrl) Is TextBox Then
                Dim txtCtrl As TextBox = DirectCast(ctrl, TextBox)
                txtCtrl.Text = Nothing
            ElseIf TypeOf (ctrl) Is CheckBox Then
                Dim chkCtrl As CheckBox = DirectCast(ctrl, CheckBox)
                chkCtrl.Checked = False
            ElseIf TypeOf (ctrl) Is ComboBox Then
                Dim cbo As ComboBox = DirectCast(ctrl, ComboBox)
                cbo.SelectedValue = -1
            ElseIf TypeOf (ctrl) Is NumericUpDown Then
                Dim nud As NumericUpDown = DirectCast(ctrl, NumericUpDown)
                nud.Value = 0
            End If
        Next
    End Sub

End Module

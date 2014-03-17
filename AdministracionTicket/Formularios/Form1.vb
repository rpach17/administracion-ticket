Public Class Form1
    Dim ctx1 As New EntidadesTablas
    Dim ctx2 As New EntidadesInsert
    Dim ctx3 As New EntidadesVistas

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim GestionVentanilla As New GESTIONES_VENTANILLAS With _
        '   {.IDVENTANILLA = 4, .IDDETALLE_GESTION_OFICINA = 9}
        'ctx2.GESTIONES_VENTANILLAS.AddObject(GestionVentanilla)
        'ctx2.SaveChanges()

        CargarGestionesVentanilla()

       

    End Sub

    Sub CargarGestionesVentanilla()
        Dim gestiones = (From vent In ctx3.V_SUCURSAL.ToList
                         Select vent).ToList

        DataGridView1.DataSource = gestiones
    End Sub
End Class
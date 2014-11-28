Public Class rptAtencionXOficina
    Public Sub New(Optional idso As Decimal = 0, Optional finicio As String = Nothing, Optional ffin As String = Nothing)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim ctx As New EntidadesVistas(My.Settings.CadenaAPPCAVistas)
        Dim datos = ctx.SP_RTE_ATENCIONXOFICINA1(idso, finicio, ffin)
        BindingSource1.DataSource = datos
    End Sub
End Class
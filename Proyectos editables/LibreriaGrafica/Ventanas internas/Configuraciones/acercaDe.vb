Imports LibreriaLogica
Public Class acercaDe
    Public Sub New()
        InitializeComponent()
        OpcGraficas()
        webview.Hide()
        lbl_title.Show()
        lbl_desc.Show()
        lbl_copyright.Show()
        traducirControles()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_git.LinkClicked
        Process.Start("http://gitlab.esi.edu.uy/fertspa/slta")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_letra.LinkClicked
        propiedadesVentanas.GetSingleton.OcultarControles(Me.Controls, webview)
        webview.Show()
        webview.Navigate("https://esi.edu.uy/media/recursos/Letra_-_Proyecto_EMT_ESI_2019.pdf")
    End Sub

    Private Sub Reload() Handles Me.Invalidated
        propiedadesVentanas.GetSingleton.MostrarControles(Me.Controls, webview)
        webview.Navigate("about:blank")
        webview.Hide()
    End Sub

    Private Sub link_pag_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_pag.LinkClicked
        Process.Start("https://fertspa.duckdns.org")
    End Sub

    Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        lbl_copyright.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_desc.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        link_git.ForeColor = Drawing.Color.Blue
        link_letra.ForeColor = Drawing.Color.Blue
        link_pag.ForeColor = Drawing.Color.Blue
    End Sub
    Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_title.Text = My.Resources.EN_UK.AcercaDe_lbltitle
            lbl_desc.Text = My.Resources.EN_UK.AcercaDe_desc
            link_letra.Text = My.Resources.EN_UK.AcercaDe_link_letra
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_title.Text = My.Resources.ES_LA.AcercaDe_lbltitle
            lbl_desc.Text = My.Resources.ES_LA.AcercaDe_desc
            link_letra.Text = My.Resources.ES_LA.AcercaDe_link_letra
        Else
            ''traduce al portugues
            lbl_title.Text = My.Resources.PT_BR.AcercaDe_lbltitle
            lbl_desc.Text = My.Resources.PT_BR.AcercaDe_desc
            link_letra.Text = My.Resources.PT_BR.AcercaDe_link_letra
        End If
    End Sub
End Class
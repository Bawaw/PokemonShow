Public Class PokemonShow
    Dim XVisibleValue As Integer = 90
    Dim WidthVisableValue As Integer = 176
    Dim PokemonNummer As Integer = 1

    Private Sub PokemonShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = SnelheidShow.Value
        SnelheidValue.Text = SnelheidShow.Value

        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Pokemons.BackColor = Color.Transparent
        SnelheidValue.BackColor = Color.Transparent
    End Sub

    Private Sub SnelheidShow_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SnelheidShow.Scroll
        SnelheidValue.Text = SnelheidShow.Value
        Timer1.Interval = SnelheidShow.Value
    End Sub



    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        If (Timer1.Enabled = False) Then
            Pokemons.Visible = True
            Nummer.Text = PokemonNummer
            Nummer.Visible = True
            blend.Visible = True
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub drawPokemon()
        Pokemons.SetBounds(XVisibleValue, 20, WidthVisableValue, 300)
        Pokemons.Refresh()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (PokemonNummer < 10) Then
            PokemonNummer += 1
            Nummer.Text = PokemonNummer
            XVisibleValue -= 187
            WidthVisableValue += 190
            drawPokemon()
        Else
            Nummer.Text = "End"
        End If

    End Sub

    Private Sub Einde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Einde.Click
        End
    End Sub

    Private Sub Pauze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pauze.Click
        Timer1.Enabled = False
        Nummer.Text = "P"
    End Sub
End Class

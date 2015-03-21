<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PokemonShow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PokemonShow))
        Me.Start = New System.Windows.Forms.Button()
        Me.Pauze = New System.Windows.Forms.Button()
        Me.Pokemons = New System.Windows.Forms.PictureBox()
        Me.SnelheidShow = New System.Windows.Forms.TrackBar()
        Me.SnelheidValue = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.blend = New System.Windows.Forms.Panel()
        Me.Nummer = New System.Windows.Forms.Label()
        Me.Einde = New System.Windows.Forms.Button()
        CType(Me.Pokemons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnelheidShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.blend.SuspendLayout()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(12, 12)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start!"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Pauze
        '
        Me.Pauze.Location = New System.Drawing.Point(282, 12)
        Me.Pauze.Name = "Pauze"
        Me.Pauze.Size = New System.Drawing.Size(75, 23)
        Me.Pauze.TabIndex = 1
        Me.Pauze.Text = "Pause!"
        Me.Pauze.UseVisualStyleBackColor = True
        '
        'Pokemons
        '
        Me.Pokemons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pokemons.BackColor = System.Drawing.Color.White
        Me.Pokemons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Pokemons.Image = CType(resources.GetObject("Pokemons.Image"), System.Drawing.Image)
        Me.Pokemons.Location = New System.Drawing.Point(93, 25)
        Me.Pokemons.Name = "Pokemons"
        Me.Pokemons.Size = New System.Drawing.Size(203, 227)
        Me.Pokemons.TabIndex = 2
        Me.Pokemons.TabStop = False
        Me.Pokemons.Visible = False
        '
        'SnelheidShow
        '
        Me.SnelheidShow.LargeChange = 1000
        Me.SnelheidShow.Location = New System.Drawing.Point(1, 294)
        Me.SnelheidShow.Maximum = 5000
        Me.SnelheidShow.Minimum = 500
        Me.SnelheidShow.Name = "SnelheidShow"
        Me.SnelheidShow.Size = New System.Drawing.Size(368, 45)
        Me.SnelheidShow.SmallChange = 500
        Me.SnelheidShow.TabIndex = 3
        Me.SnelheidShow.Value = 2000
        '
        'SnelheidValue
        '
        Me.SnelheidValue.AutoSize = True
        Me.SnelheidValue.ForeColor = System.Drawing.SystemColors.Info
        Me.SnelheidValue.Location = New System.Drawing.Point(332, 278)
        Me.SnelheidValue.Name = "SnelheidValue"
        Me.SnelheidValue.Size = New System.Drawing.Size(25, 13)
        Me.SnelheidValue.TabIndex = 4
        Me.SnelheidValue.Text = "100"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'blend
        '
        Me.blend.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.blend.Controls.Add(Me.Nummer)
        Me.blend.Location = New System.Drawing.Point(-24, 0)
        Me.blend.Name = "blend"
        Me.blend.Size = New System.Drawing.Size(111, 291)
        Me.blend.TabIndex = 6
        Me.blend.Visible = False
        '
        'Nummer
        '
        Me.Nummer.AutoSize = True
        Me.Nummer.Font = New System.Drawing.Font("Moire ExtraBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nummer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Nummer.Location = New System.Drawing.Point(15, 120)
        Me.Nummer.Name = "Nummer"
        Me.Nummer.Size = New System.Drawing.Size(65, 58)
        Me.Nummer.TabIndex = 0
        Me.Nummer.Text = "X"
        Me.Nummer.Visible = False
        '
        'Einde
        '
        Me.Einde.Location = New System.Drawing.Point(307, 229)
        Me.Einde.Name = "Einde"
        Me.Einde.Size = New System.Drawing.Size(50, 23)
        Me.Einde.TabIndex = 7
        Me.Einde.Text = "End"
        Me.Einde.UseVisualStyleBackColor = True
        '
        'PokemonShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(369, 341)
        Me.Controls.Add(Me.Einde)
        Me.Controls.Add(Me.SnelheidValue)
        Me.Controls.Add(Me.SnelheidShow)
        Me.Controls.Add(Me.Pauze)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.blend)
        Me.Controls.Add(Me.Pokemons)
        Me.Name = "PokemonShow"
        Me.Text = "Pokemon Show"
        Me.TransparencyKey = System.Drawing.Color.DarkRed
        CType(Me.Pokemons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnelheidShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.blend.ResumeLayout(False)
        Me.blend.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Pauze As System.Windows.Forms.Button
    Friend WithEvents Pokemons As System.Windows.Forms.PictureBox
    Friend WithEvents SnelheidShow As System.Windows.Forms.TrackBar
    Friend WithEvents SnelheidValue As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents blend As System.Windows.Forms.Panel
    Friend WithEvents Nummer As System.Windows.Forms.Label
    Friend WithEvents Einde As System.Windows.Forms.Button

End Class

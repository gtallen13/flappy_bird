<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jugador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jugador))
        Me.cbescuela = New System.Windows.Forms.ComboBox()
        Me.registrarse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtjugador = New System.Windows.Forms.TextBox()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbescuela
        '
        Me.cbescuela.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cbescuela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbescuela.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbescuela.ForeColor = System.Drawing.Color.White
        Me.cbescuela.FormattingEnabled = True
        Me.cbescuela.Location = New System.Drawing.Point(91, 177)
        Me.cbescuela.Name = "cbescuela"
        Me.cbescuela.Size = New System.Drawing.Size(164, 23)
        Me.cbescuela.TabIndex = 2
        '
        'registrarse
        '
        Me.registrarse.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.registrarse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registrarse.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrarse.ForeColor = System.Drawing.Color.White
        Me.registrarse.Location = New System.Drawing.Point(121, 217)
        Me.registrarse.Name = "registrarse"
        Me.registrarse.Size = New System.Drawing.Size(101, 31)
        Me.registrarse.TabIndex = 3
        Me.registrarse.Text = "Jugar"
        Me.registrarse.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(136, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Escuela"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(138, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Jugador"
        '
        'txtjugador
        '
        Me.txtjugador.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtjugador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjugador.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjugador.ForeColor = System.Drawing.Color.White
        Me.txtjugador.Location = New System.Drawing.Point(91, 118)
        Me.txtjugador.Name = "txtjugador"
        Me.txtjugador.Size = New System.Drawing.Size(163, 23)
        Me.txtjugador.TabIndex = 1
        '
        'btnregresar
        '
        Me.btnregresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregresar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregresar.ForeColor = System.Drawing.Color.White
        Me.btnregresar.Location = New System.Drawing.Point(121, 263)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(101, 31)
        Me.btnregresar.TabIndex = 41
        Me.btnregresar.Text = "Regresar"
        Me.btnregresar.UseVisualStyleBackColor = False
        '
        'Jugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(331, 351)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.registrarse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtjugador)
        Me.Controls.Add(Me.cbescuela)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Jugador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jugador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbescuela As ComboBox
    Friend WithEvents registrarse As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtjugador As TextBox
    Friend WithEvents btnregresar As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.oct_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dec_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hex_txt = New System.Windows.Forms.TextBox()
        Me.bin_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'oct_txt
        '
        Me.oct_txt.Location = New System.Drawing.Point(140, 27)
        Me.oct_txt.Name = "oct_txt"
        Me.oct_txt.Size = New System.Drawing.Size(122, 20)
        Me.oct_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OCT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(268, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DEC"
        '
        'dec_txt
        '
        Me.dec_txt.Location = New System.Drawing.Point(268, 27)
        Me.dec_txt.Name = "dec_txt"
        Me.dec_txt.Size = New System.Drawing.Size(122, 20)
        Me.dec_txt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(396, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "HEX"
        '
        'hex_txt
        '
        Me.hex_txt.Location = New System.Drawing.Point(396, 27)
        Me.hex_txt.Name = "hex_txt"
        Me.hex_txt.Size = New System.Drawing.Size(122, 20)
        Me.hex_txt.TabIndex = 6
        '
        'bin_txt
        '
        Me.bin_txt.Location = New System.Drawing.Point(12, 28)
        Me.bin_txt.Name = "bin_txt"
        Me.bin_txt.Size = New System.Drawing.Size(122, 20)
        Me.bin_txt.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "BIN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 61)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hex_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dec_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bin_txt)
        Me.Controls.Add(Me.oct_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.8R
        Me.Text = "BaseConverter"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents oct_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dec_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents hex_txt As TextBox
    Friend WithEvents bin_txt As TextBox
    Friend WithEvents Label5 As Label
End Class

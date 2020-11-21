<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_loading
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_loading))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New BASE_by_St3vka.FormSkin()
        Me.FlatLabel2 = New BASE_by_St3vka.FlatLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlatLabel1 = New BASE_by_St3vka.FlatLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatLabel3 = New BASE_by_St3vka.FlatLabel()
        Me.btn_mini = New BASE_by_St3vka.FlatMini()
        Me.credits_label = New BASE_by_St3vka.FlatLabel()
        Me.FlatProgressBar1 = New BASE_by_St3vka.FlatProgressBar()
        Me.btn_close = New BASE_by_St3vka.FlatClose()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.FormSkin1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.Panel3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.Panel2)
        Me.FormSkin1.Controls.Add(Me.Panel1)
        Me.FormSkin1.Controls.Add(Me.btn_mini)
        Me.FormSkin1.Controls.Add(Me.credits_label)
        Me.FormSkin1.Controls.Add(Me.FlatProgressBar1)
        Me.FormSkin1.Controls.Add(Me.btn_close)
        Me.FormSkin1.Controls.Add(Me.logo)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(513, 210)
        Me.FormSkin1.TabIndex = 0
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.Gray
        Me.FlatLabel2.Location = New System.Drawing.Point(326, 113)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(69, 13)
        Me.FlatLabel2.TabIndex = 9
        Me.FlatLabel2.Text = "BETA v. 0.0.1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(5, 14)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(18, 21)
        Me.Panel3.TabIndex = 8
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Silver
        Me.FlatLabel1.Location = New System.Drawing.Point(49, 118)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(64, 13)
        Me.FlatLabel1.TabIndex = 7
        Me.FlatLabel1.Text = "LOADING..."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(110, 1)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlatLabel3)
        Me.Panel1.Location = New System.Drawing.Point(3, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 21)
        Me.Panel1.TabIndex = 5
        '
        'FlatLabel3
        '
        Me.FlatLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.Gray
        Me.FlatLabel3.Location = New System.Drawing.Point(291, 8)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(216, 13)
        Me.FlatLabel3.TabIndex = 10
        Me.FlatLabel3.Text = "Checking for Updates..."
        Me.FlatLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_mini
        '
        Me.btn_mini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_mini.BackColor = System.Drawing.Color.White
        Me.btn_mini.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btn_mini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mini.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.btn_mini.Location = New System.Drawing.Point(461, 10)
        Me.btn_mini.Name = "btn_mini"
        Me.btn_mini.Size = New System.Drawing.Size(18, 18)
        Me.btn_mini.TabIndex = 4
        Me.btn_mini.Text = "FlatMini1"
        Me.btn_mini.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'credits_label
        '
        Me.credits_label.AutoSize = True
        Me.credits_label.BackColor = System.Drawing.Color.Transparent
        Me.credits_label.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.credits_label.ForeColor = System.Drawing.Color.DimGray
        Me.credits_label.Location = New System.Drawing.Point(428, 194)
        Me.credits_label.Name = "credits_label"
        Me.credits_label.Size = New System.Drawing.Size(82, 13)
        Me.credits_label.TabIndex = 3
        Me.credits_label.Text = "base by Frezzy"
        '
        'FlatProgressBar1
        '
        Me.FlatProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatProgressBar1.Location = New System.Drawing.Point(3, 149)
        Me.FlatProgressBar1.Maximum = 100
        Me.FlatProgressBar1.Name = "FlatProgressBar1"
        Me.FlatProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatProgressBar1.Size = New System.Drawing.Size(507, 42)
        Me.FlatProgressBar1.TabIndex = 2
        Me.FlatProgressBar1.Text = "progress_bar"
        Me.FlatProgressBar1.Value = 0
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BackColor = System.Drawing.Color.White
        Me.btn_close.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.btn_close.Location = New System.Drawing.Point(485, 10)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(18, 18)
        Me.btn_close.TabIndex = 1
        Me.btn_close.Text = "FlatClose1"
        Me.btn_close.TextColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(110, 29)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(292, 86)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'base_loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 210)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PASTE - Loading..."
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents btn_mini As FlatMini
    Friend WithEvents credits_label As FlatLabel
    Friend WithEvents FlatProgressBar1 As FlatProgressBar
    Friend WithEvents btn_close As FlatClose
    Friend WithEvents logo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents Timer1 As Timer
End Class

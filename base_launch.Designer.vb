<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_launch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_launch))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New BASE_by_St3vka.FormSkin()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlatLabel7 = New BASE_by_St3vka.FlatLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FlatLabel8 = New BASE_by_St3vka.FlatLabel()
        Me.FlatLabel5 = New BASE_by_St3vka.FlatLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FlatLabel6 = New BASE_by_St3vka.FlatLabel()
        Me.FlatLabel4 = New BASE_by_St3vka.FlatLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatLabel3 = New BASE_by_St3vka.FlatLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlatLabel2 = New BASE_by_St3vka.FlatLabel()
        Me.FlatLabel1 = New BASE_by_St3vka.FlatLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_mini = New BASE_by_St3vka.FlatMini()
        Me.btn_close = New BASE_by_St3vka.FlatClose()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.FlatStatusBar1 = New BASE_by_St3vka.FlatStatusBar()
        Me.FlatComboBox1 = New BASE_by_St3vka.FlatComboBox()
        Me.FlatLabel9 = New BASE_by_St3vka.FlatLabel()
        Me.FlatButton1 = New BASE_by_St3vka.FlatButton()
        Me.FlatCheckBox1 = New BASE_by_St3vka.FlatCheckBox()
        Me.FlatLabel10 = New BASE_by_St3vka.FlatLabel()
        Me.FormSkin1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FormSkin1.Controls.Add(Me.FlatLabel10)
        Me.FormSkin1.Controls.Add(Me.FlatCheckBox1)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel9)
        Me.FormSkin1.Controls.Add(Me.FlatComboBox1)
        Me.FormSkin1.Controls.Add(Me.Panel3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.Panel2)
        Me.FormSkin1.Controls.Add(Me.btn_mini)
        Me.FormSkin1.Controls.Add(Me.btn_close)
        Me.FormSkin1.Controls.Add(Me.logo)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(349, 447)
        Me.FormSkin1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel3.Controls.Add(Me.FlatLabel7)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.FlatLabel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.FlatLabel4)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(11, 149)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(326, 138)
        Me.Panel3.TabIndex = 19
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.Silver
        Me.FlatLabel7.Location = New System.Drawing.Point(95, 91)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(75, 13)
        Me.FlatLabel7.TabIndex = 25
        Me.FlatLabel7.Text = "Subscription:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel5.Controls.Add(Me.FlatLabel8)
        Me.Panel5.Location = New System.Drawing.Point(98, 104)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(184, 22)
        Me.Panel5.TabIndex = 24
        '
        'FlatLabel8
        '
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel8.ForeColor = System.Drawing.Color.LimeGreen
        Me.FlatLabel8.Location = New System.Drawing.Point(3, 4)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(181, 18)
        Me.FlatLabel8.TabIndex = 0
        Me.FlatLabel8.Text = "29 Days"
        Me.FlatLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.Silver
        Me.FlatLabel5.Location = New System.Drawing.Point(95, 52)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(36, 13)
        Me.FlatLabel5.TabIndex = 23
        Me.FlatLabel5.Text = "Rank:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel4.Controls.Add(Me.FlatLabel6)
        Me.Panel4.Location = New System.Drawing.Point(98, 65)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(184, 22)
        Me.Panel4.TabIndex = 22
        '
        'FlatLabel6
        '
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.Gold
        Me.FlatLabel6.Location = New System.Drawing.Point(3, 4)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(181, 18)
        Me.FlatLabel6.TabIndex = 0
        Me.FlatLabel6.Text = "PREMIUM"
        Me.FlatLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.Silver
        Me.FlatLabel4.Location = New System.Drawing.Point(95, 16)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(61, 13)
        Me.FlatLabel4.TabIndex = 21
        Me.FlatLabel4.Text = "Username:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlatLabel3)
        Me.Panel1.Location = New System.Drawing.Point(98, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 22)
        Me.Panel1.TabIndex = 20
        '
        'FlatLabel3
        '
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(3, 4)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(181, 18)
        Me.FlatLabel3.TabIndex = 0
        Me.FlatLabel3.Text = "Xtremecheater"
        Me.FlatLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel2.Location = New System.Drawing.Point(264, 428)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(82, 13)
        Me.FlatLabel2.TabIndex = 18
        Me.FlatLabel2.Text = "base by St3vka"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Silver
        Me.FlatLabel1.Location = New System.Drawing.Point(32, 118)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(64, 13)
        Me.FlatLabel1.TabIndex = 9
        Me.FlatLabel1.Text = "LAUNCHER"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(95, 1)
        Me.Panel2.TabIndex = 6
        '
        'btn_mini
        '
        Me.btn_mini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_mini.BackColor = System.Drawing.Color.White
        Me.btn_mini.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btn_mini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mini.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.btn_mini.Location = New System.Drawing.Point(298, 10)
        Me.btn_mini.Name = "btn_mini"
        Me.btn_mini.Size = New System.Drawing.Size(18, 18)
        Me.btn_mini.TabIndex = 4
        Me.btn_mini.Text = "FlatMini1"
        Me.btn_mini.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BackColor = System.Drawing.Color.White
        Me.btn_close.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.btn_close.Location = New System.Drawing.Point(322, 10)
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
        Me.logo.Location = New System.Drawing.Point(28, 29)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(292, 86)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 425)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.Yellow
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(349, 22)
        Me.FlatStatusBar1.TabIndex = 17
        Me.FlatStatusBar1.Text = "STATUS ┇ Choose Cheat..."
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'FlatComboBox1
        '
        Me.FlatComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FlatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlatComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatComboBox1.ForeColor = System.Drawing.Color.White
        Me.FlatComboBox1.FormattingEnabled = True
        Me.FlatComboBox1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatComboBox1.ItemHeight = 18
        Me.FlatComboBox1.Items.AddRange(New Object() {"PASTE - FREE", "PASTE - Premium"})
        Me.FlatComboBox1.Location = New System.Drawing.Point(11, 319)
        Me.FlatComboBox1.Name = "FlatComboBox1"
        Me.FlatComboBox1.Size = New System.Drawing.Size(326, 24)
        Me.FlatComboBox1.TabIndex = 20
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel9.ForeColor = System.Drawing.Color.White
        Me.FlatLabel9.Location = New System.Drawing.Point(17, 303)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(80, 13)
        Me.FlatLabel9.TabIndex = 21
        Me.FlatLabel9.Text = "Choose Cheat:"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton1.Location = New System.Drawing.Point(11, 382)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(326, 32)
        Me.FlatButton1.TabIndex = 22
        Me.FlatButton1.Text = "LAUNCH CHEAT"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatCheckBox1
        '
        Me.FlatCheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatCheckBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatCheckBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatCheckBox1.Checked = False
        Me.FlatCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatCheckBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatCheckBox1.Location = New System.Drawing.Point(20, 349)
        Me.FlatCheckBox1.Name = "FlatCheckBox1"
        Me.FlatCheckBox1.Options = BASE_by_St3vka.FlatCheckBox._Options.Style1
        Me.FlatCheckBox1.Size = New System.Drawing.Size(189, 22)
        Me.FlatCheckBox1.TabIndex = 23
        Me.FlatCheckBox1.Text = " (CLOSE AFTER INJECTION)"
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel10.ForeColor = System.Drawing.Color.Gray
        Me.FlatLabel10.Location = New System.Drawing.Point(264, 346)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(74, 15)
        Me.FlatLabel10.TabIndex = 24
        Me.FlatLabel10.Text = "Whats new?"
        '
        'base_launch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 447)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_launch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "base_launch"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_mini As FlatMini
    Friend WithEvents btn_close As FlatClose
    Friend WithEvents logo As PictureBox
    Friend WithEvents FlatStatusBar1 As FlatStatusBar
    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FlatLabel7 As FlatLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents FlatLabel8 As FlatLabel
    Friend WithEvents FlatLabel5 As FlatLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FlatLabel6 As FlatLabel
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlatComboBox1 As FlatComboBox
    Friend WithEvents FlatLabel9 As FlatLabel
    Friend WithEvents FlatCheckBox1 As FlatCheckBox
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatLabel10 As FlatLabel
End Class

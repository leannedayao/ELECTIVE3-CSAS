<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Community
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Minimize = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolLevel = New System.Windows.Forms.ComboBox()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.ProvCombo = New System.Windows.Forms.ComboBox()
        Me.ProvinceLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CancellButton = New System.Windows.Forms.Button()
        Me.CityCombo = New System.Windows.Forms.ComboBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RegionCombo = New System.Windows.Forms.ComboBox()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.RegionLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Minimize
        '
        Me.Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Minimize.BackgroundImage = Global.CSAS.My.Resources.Resources.Minimize
        Me.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimize.FlatAppearance.BorderSize = 0
        Me.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimize.ForeColor = System.Drawing.Color.White
        Me.Minimize.Location = New System.Drawing.Point(569, 7)
        Me.Minimize.Margin = New System.Windows.Forms.Padding(4)
        Me.Minimize.MaximumSize = New System.Drawing.Size(27, 25)
        Me.Minimize.MinimumSize = New System.Drawing.Size(27, 25)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(27, 25)
        Me.Minimize.TabIndex = 5
        Me.Minimize.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.BackgroundImage = Global.CSAS.My.Resources.Resources.ExitButton
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(619, 7)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseButton.MaximumSize = New System.Drawing.Size(27, 25)
        Me.CloseButton.MinimumSize = New System.Drawing.Size(27, 25)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(27, 25)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(69, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 26)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Suspend Classes for:"
        '
        'SchoolLevel
        '
        Me.SchoolLevel.BackColor = System.Drawing.Color.White
        Me.SchoolLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.SchoolLevel.FormattingEnabled = True
        Me.SchoolLevel.Location = New System.Drawing.Point(118, 287)
        Me.SchoolLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.SchoolLevel.Name = "SchoolLevel"
        Me.SchoolLevel.Size = New System.Drawing.Size(421, 32)
        Me.SchoolLevel.TabIndex = 40
        Me.SchoolLevel.Text = "                              School Level"
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.BackColor = System.Drawing.Color.Transparent
        Me.LevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelLabel.ForeColor = System.Drawing.Color.Black
        Me.LevelLabel.Location = New System.Drawing.Point(113, 253)
        Me.LevelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(143, 26)
        Me.LevelLabel.TabIndex = 39
        Me.LevelLabel.Text = "School Level:"
        '
        'ProvCombo
        '
        Me.ProvCombo.BackColor = System.Drawing.Color.White
        Me.ProvCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ProvCombo.FormattingEnabled = True
        Me.ProvCombo.Location = New System.Drawing.Point(118, 209)
        Me.ProvCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.ProvCombo.Name = "ProvCombo"
        Me.ProvCombo.Size = New System.Drawing.Size(421, 32)
        Me.ProvCombo.TabIndex = 38
        Me.ProvCombo.Text = "                                 Province"
        '
        'ProvinceLabel
        '
        Me.ProvinceLabel.AutoSize = True
        Me.ProvinceLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProvinceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinceLabel.ForeColor = System.Drawing.Color.Black
        Me.ProvinceLabel.Location = New System.Drawing.Point(113, 175)
        Me.ProvinceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProvinceLabel.Name = "ProvinceLabel"
        Me.ProvinceLabel.Size = New System.Drawing.Size(103, 26)
        Me.ProvinceLabel.TabIndex = 37
        Me.ProvinceLabel.Text = "Province:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(370, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 45)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "SUSPEND"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CancellButton
        '
        Me.CancellButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CancellButton.Location = New System.Drawing.Point(198, 413)
        Me.CancellButton.Name = "CancellButton"
        Me.CancellButton.Size = New System.Drawing.Size(100, 45)
        Me.CancellButton.TabIndex = 35
        Me.CancellButton.Text = "CANCEL"
        Me.CancellButton.UseVisualStyleBackColor = True
        '
        'CityCombo
        '
        Me.CityCombo.BackColor = System.Drawing.Color.White
        Me.CityCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.CityCombo.FormattingEnabled = True
        Me.CityCombo.Location = New System.Drawing.Point(301, 132)
        Me.CityCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.CityCombo.Name = "CityCombo"
        Me.CityCombo.Size = New System.Drawing.Size(238, 32)
        Me.CityCombo.TabIndex = 34
        Me.CityCombo.Text = "                   City"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.BackColor = System.Drawing.Color.Transparent
        Me.CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityLabel.ForeColor = System.Drawing.Color.Black
        Me.CityLabel.Location = New System.Drawing.Point(296, 98)
        Me.CityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(56, 26)
        Me.CityLabel.TabIndex = 33
        Me.CityLabel.Text = "City:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(118, 364)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(421, 29)
        Me.DateTimePicker1.TabIndex = 32
        '
        'RegionCombo
        '
        Me.RegionCombo.BackColor = System.Drawing.Color.White
        Me.RegionCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.RegionCombo.FormattingEnabled = True
        Me.RegionCombo.Location = New System.Drawing.Point(118, 132)
        Me.RegionCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.RegionCombo.Name = "RegionCombo"
        Me.RegionCombo.Size = New System.Drawing.Size(138, 32)
        Me.RegionCombo.TabIndex = 31
        Me.RegionCombo.Text = "     Region"
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.AutoSize = True
        Me.DateTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeLabel.ForeColor = System.Drawing.Color.Black
        Me.DateTimeLabel.Location = New System.Drawing.Point(113, 330)
        Me.DateTimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(160, 26)
        Me.DateTimeLabel.TabIndex = 30
        Me.DateTimeLabel.Text = "Date and Time:"
        '
        'RegionLabel
        '
        Me.RegionLabel.AutoSize = True
        Me.RegionLabel.BackColor = System.Drawing.Color.Transparent
        Me.RegionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionLabel.ForeColor = System.Drawing.Color.Black
        Me.RegionLabel.Location = New System.Drawing.Point(113, 98)
        Me.RegionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RegionLabel.Name = "RegionLabel"
        Me.RegionLabel.Size = New System.Drawing.Size(87, 26)
        Me.RegionLabel.TabIndex = 29
        Me.RegionLabel.Text = "Region:"
        '
        'Community
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.PopUp1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 515)
        Me.Controls.Add(Me.SchoolLevel)
        Me.Controls.Add(Me.LevelLabel)
        Me.Controls.Add(Me.ProvCombo)
        Me.Controls.Add(Me.ProvinceLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CancellButton)
        Me.Controls.Add(Me.CityCombo)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RegionCombo)
        Me.Controls.Add(Me.DateTimeLabel)
        Me.Controls.Add(Me.RegionLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(655, 515)
        Me.MinimumSize = New System.Drawing.Size(655, 515)
        Me.Name = "Community"
        Me.Text = "Community"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolLevel As ComboBox
    Friend WithEvents LevelLabel As Label
    Friend WithEvents ProvCombo As ComboBox
    Friend WithEvents ProvinceLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CancellButton As Button
    Friend WithEvents CityCombo As ComboBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RegionCombo As ComboBox
    Friend WithEvents DateTimeLabel As Label
    Friend WithEvents RegionLabel As Label
End Class

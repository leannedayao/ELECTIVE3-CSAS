<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHome
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
        Me.SuspendLabel = New System.Windows.Forms.Label()
        Me.ManageUsers = New System.Windows.Forms.Label()
        Me.LogOut = New System.Windows.Forms.Label()
        Me.SchoolButton = New System.Windows.Forms.Button()
        Me.CommunityButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Minimize.Location = New System.Drawing.Point(769, 7)
        Me.Minimize.Margin = New System.Windows.Forms.Padding(4)
        Me.Minimize.MaximumSize = New System.Drawing.Size(27, 25)
        Me.Minimize.MinimumSize = New System.Drawing.Size(27, 25)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(27, 25)
        Me.Minimize.TabIndex = 3
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
        Me.CloseButton.Location = New System.Drawing.Point(819, 7)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseButton.MaximumSize = New System.Drawing.Size(27, 25)
        Me.CloseButton.MinimumSize = New System.Drawing.Size(27, 25)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(27, 25)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'SuspendLabel
        '
        Me.SuspendLabel.AutoSize = True
        Me.SuspendLabel.BackColor = System.Drawing.Color.Transparent
        Me.SuspendLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuspendLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.SuspendLabel.Location = New System.Drawing.Point(50, 93)
        Me.SuspendLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SuspendLabel.Name = "SuspendLabel"
        Me.SuspendLabel.Size = New System.Drawing.Size(244, 29)
        Me.SuspendLabel.TabIndex = 5
        Me.SuspendLabel.Text = "SUSPEND CLASSES"
        '
        'ManageUsers
        '
        Me.ManageUsers.AutoSize = True
        Me.ManageUsers.BackColor = System.Drawing.Color.Transparent
        Me.ManageUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageUsers.ForeColor = System.Drawing.Color.Black
        Me.ManageUsers.Location = New System.Drawing.Point(327, 93)
        Me.ManageUsers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ManageUsers.Name = "ManageUsers"
        Me.ManageUsers.Size = New System.Drawing.Size(203, 29)
        Me.ManageUsers.TabIndex = 6
        Me.ManageUsers.Text = "MANAGE USERS"
        '
        'LogOut
        '
        Me.LogOut.AutoSize = True
        Me.LogOut.BackColor = System.Drawing.Color.Transparent
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.ForeColor = System.Drawing.Color.Black
        Me.LogOut.Location = New System.Drawing.Point(689, 93)
        Me.LogOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(121, 29)
        Me.LogOut.TabIndex = 7
        Me.LogOut.Text = "LOG OUT"
        '
        'SchoolButton
        '
        Me.SchoolButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.SchoolButton.FlatAppearance.BorderSize = 0
        Me.SchoolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SchoolButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolButton.Location = New System.Drawing.Point(206, 262)
        Me.SchoolButton.Name = "SchoolButton"
        Me.SchoolButton.Size = New System.Drawing.Size(170, 170)
        Me.SchoolButton.TabIndex = 8
        Me.SchoolButton.Text = "SCHOOL"
        Me.SchoolButton.UseVisualStyleBackColor = False
        '
        'CommunityButton
        '
        Me.CommunityButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.CommunityButton.FlatAppearance.BorderSize = 0
        Me.CommunityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CommunityButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommunityButton.Location = New System.Drawing.Point(487, 262)
        Me.CommunityButton.Name = "CommunityButton"
        Me.CommunityButton.Size = New System.Drawing.Size(170, 170)
        Me.CommunityButton.TabIndex = 9
        Me.CommunityButton.Text = "COMMUNITY"
        Me.CommunityButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(64, 195)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Suspend Classes for:"
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.Home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 591)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CommunityButton)
        Me.Controls.Add(Me.SchoolButton)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.ManageUsers)
        Me.Controls.Add(Me.SuspendLabel)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(853, 591)
        Me.MinimumSize = New System.Drawing.Size(853, 591)
        Me.Name = "AdminHome"
        Me.Text = "AdminHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SuspendLabel As Label
    Friend WithEvents ManageUsers As Label
    Friend WithEvents LogOut As Label
    Friend WithEvents SchoolButton As Button
    Friend WithEvents CommunityButton As Button
    Friend WithEvents Label1 As Label
End Class

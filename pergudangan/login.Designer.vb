<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.gb_username = New System.Windows.Forms.GroupBox()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.gb_password = New System.Windows.Forms.GroupBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.gb_username.SuspendLayout()
        Me.gb_password.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_username
        '
        Me.gb_username.Controls.Add(Me.tb_username)
        Me.gb_username.Location = New System.Drawing.Point(12, 12)
        Me.gb_username.Name = "gb_username"
        Me.gb_username.Size = New System.Drawing.Size(124, 53)
        Me.gb_username.TabIndex = 1
        Me.gb_username.TabStop = False
        Me.gb_username.Text = "Username"
        '
        'tb_username
        '
        Me.tb_username.Location = New System.Drawing.Point(6, 19)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(100, 20)
        Me.tb_username.TabIndex = 1
        '
        'tb_password
        '
        Me.tb_password.Location = New System.Drawing.Point(6, 19)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.Size = New System.Drawing.Size(100, 20)
        Me.tb_password.TabIndex = 1
        '
        'gb_password
        '
        Me.gb_password.Controls.Add(Me.tb_password)
        Me.gb_password.Location = New System.Drawing.Point(142, 12)
        Me.gb_password.Name = "gb_password"
        Me.gb_password.Size = New System.Drawing.Size(124, 53)
        Me.gb_password.TabIndex = 2
        Me.gb_password.TabStop = False
        Me.gb_password.Text = "Password"
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(191, 71)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 108)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.gb_password)
        Me.Controls.Add(Me.gb_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.Text = "Login"
        Me.gb_username.ResumeLayout(False)
        Me.gb_username.PerformLayout()
        Me.gb_password.ResumeLayout(False)
        Me.gb_password.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_username As System.Windows.Forms.GroupBox
    Friend WithEvents tb_username As System.Windows.Forms.TextBox
    Friend WithEvents tb_password As System.Windows.Forms.TextBox
    Friend WithEvents gb_password As System.Windows.Forms.GroupBox
    Friend WithEvents btn_login As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product_unit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(product_unit))
        Me.dgv_list = New System.Windows.Forms.DataGridView()
        Me.ms = New System.Windows.Forms.MenuStrip()
        Me.ms_add = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ms.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_list
        '
        Me.dgv_list.AllowUserToAddRows = False
        Me.dgv_list.AllowUserToDeleteRows = False
        Me.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_list.Location = New System.Drawing.Point(0, 24)
        Me.dgv_list.MultiSelect = False
        Me.dgv_list.Name = "dgv_list"
        Me.dgv_list.ReadOnly = True
        Me.dgv_list.Size = New System.Drawing.Size(850, 237)
        Me.dgv_list.TabIndex = 2
        '
        'ms
        '
        Me.ms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_add, Me.ReloadToolStripMenuItem})
        Me.ms.Location = New System.Drawing.Point(0, 0)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(850, 24)
        Me.ms.TabIndex = 3
        Me.ms.Text = "MenuStrip1"
        '
        'ms_add
        '
        Me.ms_add.Name = "ms_add"
        Me.ms_add.Size = New System.Drawing.Size(86, 20)
        Me.ms_add.Text = "Add Product"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ReloadToolStripMenuItem.Text = "Reload Product"
        '
        'product_unit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 261)
        Me.Controls.Add(Me.dgv_list)
        Me.Controls.Add(Me.ms)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "product_unit"
        Me.Text = "product_unit"
        CType(Me.dgv_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ms.ResumeLayout(False)
        Me.ms.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_list As System.Windows.Forms.DataGridView
    Friend WithEvents ms As System.Windows.Forms.MenuStrip
    Friend WithEvents ms_add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

Public Class product_unit

    Public Sub loadZX()
        dgv_list.DataSource = getDataToDataGrid("select pu_id, pu_name from product_unit")
        dgv_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect


    End Sub

    Private Sub product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadZX()

        Dim btn_edit As New DataGridViewButtonColumn
        btn_edit.HeaderText = "Edit"
        btn_edit.Text = "Edit"
        btn_edit.Name = "btn_edit"
        btn_edit.UseColumnTextForButtonValue = True
        dgv_list.Columns.Add(btn_edit)

        Dim btn_delete As New DataGridViewButtonColumn
        btn_delete.HeaderText = "Delete"
        btn_delete.Text = "Delete"
        btn_delete.Name = "btn_delete"
        btn_delete.UseColumnTextForButtonValue = True
        dgv_list.Columns.Add(btn_delete)
    End Sub

    Private Sub dgv_list_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_list.CellContentClick
        'MsgBox(dgv_list.CurrentRow.Cells("product_id").Value)
        If dgv_list.Columns(e.ColumnIndex).Name = "btn_edit" Then
            product_unit_add_edit.MdiParent = main_menu
            product_unit_add_edit.Show()
            product_unit_add_edit.loadParams(dgv_list.CurrentRow.Cells("pu_id").Value)
        ElseIf dgv_list.Columns(e.ColumnIndex).Name = "btn_delete" Then
            Dim result As DialogResult = MessageBox.Show("Delete " & dgv_list.CurrentRow.Cells("pu_name").Value & "?", "Are you sure?", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                getExecute("DELETE FROM product_unit WHERE pu_id = " & dgv_list.CurrentRow.Cells("pu_id").Value)

                MsgBox("Deleted", MsgBoxStyle.Information)
                Me.loadZX()
            End If

        End If
    End Sub



    Private Sub ms_add_Click(sender As Object, e As EventArgs) Handles ms_add.Click
        product_unit_add_edit.Show()
        product_unit_add_edit.loadParams(0)
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        loadZX()
    End Sub
End Class
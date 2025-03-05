Public Class product
    Public Sub load()
        dgv_list.DataSource = getDataToDataGrid("select product_id,product_name from product")
        dgv_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect


    End Sub

    Private Sub product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()

        Dim btn_image As New DataGridViewButtonColumn
        btn_image.HeaderText = "Show Images"
        btn_image.Text = "Show Images"
        btn_image.Name = "btn_image"
        btn_image.UseColumnTextForButtonValue = True
        dgv_list.Columns.Add(btn_image)

        Dim btn_image_edit As New DataGridViewButtonColumn
        btn_image_edit.HeaderText = "Edit Images"
        btn_image_edit.Text = "Edit Images"
        btn_image_edit.Name = "btn_image_edit"
        btn_image_edit.UseColumnTextForButtonValue = True
        dgv_list.Columns.Add(btn_image_edit)

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
            product_add_edit.Show()
            product_add_edit.loadParams(dgv_list.CurrentRow.Cells("product_id").Value)
        ElseIf dgv_list.Columns(e.ColumnIndex).Name = "btn_delete" Then
            Dim result As DialogResult = MessageBox.Show("Delete " & dgv_list.CurrentRow.Cells("product_name").Value & "?", "Are you sure?", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                getExecute("DELETE FROM product WHERE product_id = " & dgv_list.CurrentRow.Cells("product_id").Value)

                MsgBox("Deleted", MsgBoxStyle.Information)
                Me.load()
            End If

           
        ElseIf dgv_list.Columns(e.ColumnIndex).Name = "btn_image" Then
            'MsgBox(dgv_list.CurrentRow.Cells("product_id").Value)
            product_image.Show()
            product_image.loadParams(dgv_list.CurrentRow.Cells("product_id").Value, 1)
        End If
    End Sub



    Private Sub ms_add_Click(sender As Object, e As EventArgs) Handles ms_add.Click
        product_add_edit.Show()
        product_add_edit.loadParams(0)
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        load()
    End Sub
End Class
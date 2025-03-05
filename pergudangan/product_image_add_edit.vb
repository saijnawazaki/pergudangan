Public Class product_image_add_edit
    Public Sub load()
        dgv_list.DataSource = getDataToDataGrid("select counter, file_path from product_image")
        dgv_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        

    End Sub
    Private Sub product_image_add_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()

        Dim image_show As New DataGridViewImageColumn
        image_show.HeaderText = "Image"
        image_show.Name = "image_show"

        dgv_list.Columns.Add(image_show)

        dgv_list.Columns(2).Width = 400

        Dim i As Integer = 0
        For i = 0 To dgv_list.RowCount - 1
            Dim Img As New DataGridViewImageCell
            Img.ImageLayout = DataGridViewImageCellLayout.Stretch
            Img.Value = Image.FromFile(My.Application.Info.DirectoryPath & "\assets\product_image\" & dgv_list.Rows(i).Cells(1).Value)

            dgv_list.Rows(i).Cells(2).Value = Img.Value
            dgv_list.Rows(i).Height = 300

        Next

        Dim btn_delete As New DataGridViewButtonColumn
        btn_delete.HeaderText = "Delete"
        btn_delete.Text = "Delete"
        btn_delete.Name = "btn_delete"
        btn_delete.UseColumnTextForButtonValue = True
        dgv_list.Columns.Add(btn_delete)
    End Sub
End Class
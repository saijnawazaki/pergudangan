Imports System.IO
Public Class product_image_add_edit
    Dim g_product_id As Integer = 0
    Public Sub loadparam(product_id)
        g_product_id = product_id
        loadZ(g_product_id)
    End Sub
   
    Public Sub loadZ(product_id)
        dgv_list.Columns.Clear()
        dgv_list.DataSource = getDataToDataGrid("select counter, file_path from product_image where product_id = " & product_id)
        dgv_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect


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
    Private Sub dgv_list_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_list.CellContentClick
        'MsgBox(dgv_list.CurrentRow.Cells("product_id").Value)
        If dgv_list.Columns(e.ColumnIndex).Name = "btn_delete" Then
            Dim result As DialogResult = MessageBox.Show("Delete " & dgv_list.CurrentRow.Cells("counter").Value & "?", "Are you sure?", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim query
                query = "DELETE FROM [product_image] WHERE product_id = " & g_product_id & " AND [counter] = " & dgv_list.CurrentRow.Cells("counter").Value
                Debug.WriteLine(query)
                getExecute(query)

                Dim reader = getSoloRowData("select * from [product_image] where product_id = " & g_product_id)
                Dim lstWriteBits As List(Of String) = New List(Of String)
                While reader.Read()
                    lstWriteBits.Add(reader("file_path").ToString())
                End While

                getExecute("DELETE from [product_image] where product_id = " & g_product_id)

                'Debug.WriteLine(lstWriteBits)
                Dim ke = 0
                For Each item As String In lstWriteBits
                    ' write code here, for example:
                    ke += 1
                    'INSERT INTO [product_image] (product_id,file_path,counter) VALUES (1, '1_1741831532.png', 1)
                    'INSERT INTO [product_image] (product_id,file_path,counter) VALUES (1, '1_1741831532.png', 1)
                    query = "INSERT INTO [product_image] (product_id,[file_path],[counter]) VALUES (" & g_product_id & ", '" & item & "', " & ke & ")"
                    Debug.WriteLine(query)
                    getExecute(query)
                Next

                MsgBox("Deleted", MsgBoxStyle.Information)
                Me.loadZ(g_product_id)
            End If

        End If
    End Sub

    Private Sub ms_add_Click(sender As Object, e As EventArgs) Handles ms_add.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Images|*.jpg;*.jpeg;*.png"
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Dim strFileEXT = Path.GetExtension(strFileName).ToLower()

            Dim final_file_name = g_product_id & "_" & parsedate_now() & strFileEXT
            'Debug.WriteLine(strFileName)
            IO.File.Copy(strFileName, IO.Path.Combine(My.Application.Info.DirectoryPath & "\assets\product_image\", final_file_name))

            Dim reader = getSoloRowData("select * from [product_image] where product_id = " & g_product_id)
            Dim lstWriteBits As List(Of String) = New List(Of String)
            While reader.Read()
                lstWriteBits.Add(reader("file_path").ToString())
            End While

            lstWriteBits.Add(final_file_name)

            getExecute("DELETE from [product_image] where product_id = " & g_product_id)

            'Debug.WriteLine(lstWriteBits)
            Dim ke = 0
            For Each item As String In lstWriteBits
                ' write code here, for example:
                ke += 1
                'INSERT INTO [product_image] (product_id,file_path,counter) VALUES (1, '1_1741831532.png', 1)
                'INSERT INTO [product_image] (product_id,file_path,counter) VALUES (1, '1_1741831532.png', 1)
                Dim query = "INSERT INTO [product_image] (product_id,[file_path],[counter]) VALUES (" & g_product_id & ", '" & item & "', " & ke & ")"
                'Debug.WriteLine(query)
                getExecute(query)
            Next

            loadZ(g_product_id)
            MsgBox("Success", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub product_image_add_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class